// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Aiccs20191015.Models;

namespace AlibabaCloud.SDK.Aiccs20191015
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aiccs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>新增热线号码</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddHotlineNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddHotlineNumberResponse
        /// </returns>
        public AddHotlineNumberResponse AddHotlineNumberWithOptions(AddHotlineNumberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddHotlineNumberShrinkRequest request = new AddHotlineNumberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutboundRangeList))
            {
                request.OutboundRangeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutboundRangeList, "OutboundRangeList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInbound))
            {
                body["EnableInbound"] = request.EnableInbound;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInboundEvaluation))
            {
                body["EnableInboundEvaluation"] = request.EnableInboundEvaluation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutbound))
            {
                body["EnableOutbound"] = request.EnableOutbound;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutboundEvaluation))
            {
                body["EnableOutboundEvaluation"] = request.EnableOutboundEvaluation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationLevel))
            {
                body["EvaluationLevel"] = request.EvaluationLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotlineNumber))
            {
                body["HotlineNumber"] = request.HotlineNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InboundFlowId))
            {
                body["InboundFlowId"] = request.InboundFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundAllDepart))
            {
                body["OutboundAllDepart"] = request.OutboundAllDepart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundRangeListShrink))
            {
                body["OutboundRangeList"] = request.OutboundRangeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddHotlineNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddHotlineNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增热线号码</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddHotlineNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddHotlineNumberResponse
        /// </returns>
        public async Task<AddHotlineNumberResponse> AddHotlineNumberWithOptionsAsync(AddHotlineNumberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddHotlineNumberShrinkRequest request = new AddHotlineNumberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutboundRangeList))
            {
                request.OutboundRangeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutboundRangeList, "OutboundRangeList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInbound))
            {
                body["EnableInbound"] = request.EnableInbound;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInboundEvaluation))
            {
                body["EnableInboundEvaluation"] = request.EnableInboundEvaluation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutbound))
            {
                body["EnableOutbound"] = request.EnableOutbound;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutboundEvaluation))
            {
                body["EnableOutboundEvaluation"] = request.EnableOutboundEvaluation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationLevel))
            {
                body["EvaluationLevel"] = request.EvaluationLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotlineNumber))
            {
                body["HotlineNumber"] = request.HotlineNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InboundFlowId))
            {
                body["InboundFlowId"] = request.InboundFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundAllDepart))
            {
                body["OutboundAllDepart"] = request.OutboundAllDepart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundRangeListShrink))
            {
                body["OutboundRangeList"] = request.OutboundRangeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddHotlineNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddHotlineNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增热线号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddHotlineNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddHotlineNumberResponse
        /// </returns>
        public AddHotlineNumberResponse AddHotlineNumber(AddHotlineNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddHotlineNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增热线号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddHotlineNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddHotlineNumberResponse
        /// </returns>
        public async Task<AddHotlineNumberResponse> AddHotlineNumberAsync(AddHotlineNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddHotlineNumberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AddOuterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOuterAccountResponse
        /// </returns>
        public AddOuterAccountResponse AddOuterAccountWithOptions(AddOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddOuterAccount",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOuterAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddOuterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOuterAccountResponse
        /// </returns>
        public async Task<AddOuterAccountResponse> AddOuterAccountWithOptionsAsync(AddOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddOuterAccount",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOuterAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddOuterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOuterAccountResponse
        /// </returns>
        public AddOuterAccountResponse AddOuterAccount(AddOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddOuterAccountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddOuterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOuterAccountResponse
        /// </returns>
        public async Task<AddOuterAccountResponse> AddOuterAccountAsync(AddOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddOuterAccountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AddSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSkillGroupResponse
        /// </returns>
        public AddSkillGroupResponse AddSkillGroupWithOptions(AddSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSkillGroupResponse
        /// </returns>
        public async Task<AddSkillGroupResponse> AddSkillGroupWithOptionsAsync(AddSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSkillGroupResponse
        /// </returns>
        public AddSkillGroupResponse AddSkillGroup(AddSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSkillGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSkillGroupResponse
        /// </returns>
        public async Task<AddSkillGroupResponse> AddSkillGroupAsync(AddSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSkillGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AiccsSmartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AiccsSmartCallResponse
        /// </returns>
        public AiccsSmartCallResponse AiccsSmartCallWithOptions(AiccsSmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeBreak))
            {
                query["ActionCodeBreak"] = request.ActionCodeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeTimeBreak))
            {
                query["ActionCodeTimeBreak"] = request.ActionCodeTimeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrAlsAmId))
            {
                query["AsrAlsAmId"] = request.AsrAlsAmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrBaseId))
            {
                query["AsrBaseId"] = request.AsrBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrModelId))
            {
                query["AsrModelId"] = request.AsrModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrVocabularyId))
            {
                query["AsrVocabularyId"] = request.AsrVocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundFileCode))
            {
                query["BackgroundFileCode"] = request.BackgroundFileCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundSpeed))
            {
                query["BackgroundSpeed"] = request.BackgroundSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundVolume))
            {
                query["BackgroundVolume"] = request.BackgroundVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicId))
            {
                query["DynamicId"] = request.DynamicId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarlyMediaAsr))
            {
                query["EarlyMediaAsr"] = request.EarlyMediaAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableITN))
            {
                query["EnableITN"] = request.EnableITN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteTime))
            {
                query["MuteTime"] = request.MuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseTime))
            {
                query["PauseTime"] = request.PauseTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFlag))
            {
                query["RecordFlag"] = request.RecordFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsConf))
            {
                query["TtsConf"] = request.TtsConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsSpeed))
            {
                query["TtsSpeed"] = request.TtsSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsStyle))
            {
                query["TtsStyle"] = request.TtsStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVolume))
            {
                query["TtsVolume"] = request.TtsVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["VoiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCodeParam))
            {
                query["VoiceCodeParam"] = request.VoiceCodeParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AiccsSmartCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AiccsSmartCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AiccsSmartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AiccsSmartCallResponse
        /// </returns>
        public async Task<AiccsSmartCallResponse> AiccsSmartCallWithOptionsAsync(AiccsSmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeBreak))
            {
                query["ActionCodeBreak"] = request.ActionCodeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeTimeBreak))
            {
                query["ActionCodeTimeBreak"] = request.ActionCodeTimeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrAlsAmId))
            {
                query["AsrAlsAmId"] = request.AsrAlsAmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrBaseId))
            {
                query["AsrBaseId"] = request.AsrBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrModelId))
            {
                query["AsrModelId"] = request.AsrModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrVocabularyId))
            {
                query["AsrVocabularyId"] = request.AsrVocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundFileCode))
            {
                query["BackgroundFileCode"] = request.BackgroundFileCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundSpeed))
            {
                query["BackgroundSpeed"] = request.BackgroundSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundVolume))
            {
                query["BackgroundVolume"] = request.BackgroundVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicId))
            {
                query["DynamicId"] = request.DynamicId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarlyMediaAsr))
            {
                query["EarlyMediaAsr"] = request.EarlyMediaAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableITN))
            {
                query["EnableITN"] = request.EnableITN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteTime))
            {
                query["MuteTime"] = request.MuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseTime))
            {
                query["PauseTime"] = request.PauseTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFlag))
            {
                query["RecordFlag"] = request.RecordFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsConf))
            {
                query["TtsConf"] = request.TtsConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsSpeed))
            {
                query["TtsSpeed"] = request.TtsSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsStyle))
            {
                query["TtsStyle"] = request.TtsStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVolume))
            {
                query["TtsVolume"] = request.TtsVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["VoiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCodeParam))
            {
                query["VoiceCodeParam"] = request.VoiceCodeParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AiccsSmartCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AiccsSmartCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AiccsSmartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// AiccsSmartCallResponse
        /// </returns>
        public AiccsSmartCallResponse AiccsSmartCall(AiccsSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AiccsSmartCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AiccsSmartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// AiccsSmartCallResponse
        /// </returns>
        public async Task<AiccsSmartCallResponse> AiccsSmartCallAsync(AiccsSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AiccsSmartCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AiccsSmartCallOperateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AiccsSmartCallOperateResponse
        /// </returns>
        public AiccsSmartCallOperateResponse AiccsSmartCallOperateWithOptions(AiccsSmartCallOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
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
                Action = "AiccsSmartCallOperate",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AiccsSmartCallOperateResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AiccsSmartCallOperateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AiccsSmartCallOperateResponse
        /// </returns>
        public async Task<AiccsSmartCallOperateResponse> AiccsSmartCallOperateWithOptionsAsync(AiccsSmartCallOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
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
                Action = "AiccsSmartCallOperate",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AiccsSmartCallOperateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AiccsSmartCallOperateRequest
        /// </param>
        /// 
        /// <returns>
        /// AiccsSmartCallOperateResponse
        /// </returns>
        public AiccsSmartCallOperateResponse AiccsSmartCallOperate(AiccsSmartCallOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AiccsSmartCallOperateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AiccsSmartCallOperateRequest
        /// </param>
        /// 
        /// <returns>
        /// AiccsSmartCallOperateResponse
        /// </returns>
        public async Task<AiccsSmartCallOperateResponse> AiccsSmartCallOperateAsync(AiccsSmartCallOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AiccsSmartCallOperateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AnswerCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnswerCallResponse
        /// </returns>
        public AnswerCallResponse AnswerCallWithOptions(AnswerCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "AnswerCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnswerCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AnswerCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnswerCallResponse
        /// </returns>
        public async Task<AnswerCallResponse> AnswerCallWithOptionsAsync(AnswerCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "AnswerCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnswerCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AnswerCallRequest
        /// </param>
        /// 
        /// <returns>
        /// AnswerCallResponse
        /// </returns>
        public AnswerCallResponse AnswerCall(AnswerCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AnswerCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AnswerCallRequest
        /// </param>
        /// 
        /// <returns>
        /// AnswerCallResponse
        /// </returns>
        public async Task<AnswerCallResponse> AnswerCallAsync(AnswerCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AnswerCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加任务明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachTaskResponse
        /// </returns>
        public AttachTaskResponse AttachTaskWithOptions(AttachTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallString))
            {
                query["CallString"] = request.CallString;
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
                Action = "AttachTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加任务明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachTaskResponse
        /// </returns>
        public async Task<AttachTaskResponse> AttachTaskWithOptionsAsync(AttachTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallString))
            {
                query["CallString"] = request.CallString;
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
                Action = "AttachTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加任务明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachTaskResponse
        /// </returns>
        public AttachTaskResponse AttachTask(AttachTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加任务明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachTaskResponse
        /// </returns>
        public async Task<AttachTaskResponse> AttachTaskAsync(AttachTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// BatchCreateQualityProjectsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateQualityProjectsResponse
        /// </returns>
        public BatchCreateQualityProjectsResponse BatchCreateQualityProjectsWithOptions(BatchCreateQualityProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisIds))
            {
                query["AnalysisIds"] = request.AnalysisIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelTouchType))
            {
                query["ChannelTouchType"] = request.ChannelTouchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckFreqType))
            {
                query["CheckFreqType"] = request.CheckFreqType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeEnd))
            {
                query["TimeRangeEnd"] = request.TimeRangeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeStart))
            {
                query["TimeRangeStart"] = request.TimeRangeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateQualityProjects",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateQualityProjectsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// BatchCreateQualityProjectsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateQualityProjectsResponse
        /// </returns>
        public async Task<BatchCreateQualityProjectsResponse> BatchCreateQualityProjectsWithOptionsAsync(BatchCreateQualityProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisIds))
            {
                query["AnalysisIds"] = request.AnalysisIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelTouchType))
            {
                query["ChannelTouchType"] = request.ChannelTouchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckFreqType))
            {
                query["CheckFreqType"] = request.CheckFreqType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeEnd))
            {
                query["TimeRangeEnd"] = request.TimeRangeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeStart))
            {
                query["TimeRangeStart"] = request.TimeRangeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateQualityProjects",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateQualityProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// BatchCreateQualityProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateQualityProjectsResponse
        /// </returns>
        public BatchCreateQualityProjectsResponse BatchCreateQualityProjects(BatchCreateQualityProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCreateQualityProjectsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// BatchCreateQualityProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateQualityProjectsResponse
        /// </returns>
        public async Task<BatchCreateQualityProjectsResponse> BatchCreateQualityProjectsAsync(BatchCreateQualityProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCreateQualityProjectsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
        public CancelTaskResponse CancelTaskWithOptions(CancelTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
        public async Task<CancelTaskResponse> CancelTaskWithOptionsAsync(CancelTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
        public CancelTaskResponse CancelTask(CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
        public async Task<CancelTaskResponse> CancelTaskAsync(CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改在线客服状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeChatAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeChatAgentStatusResponse
        /// </returns>
        public ChangeChatAgentStatusResponse ChangeChatAgentStatusWithOptions(ChangeChatAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["Method"] = request.Method;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeChatAgentStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeChatAgentStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改在线客服状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeChatAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeChatAgentStatusResponse
        /// </returns>
        public async Task<ChangeChatAgentStatusResponse> ChangeChatAgentStatusWithOptionsAsync(ChangeChatAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["Method"] = request.Method;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeChatAgentStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeChatAgentStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改在线客服状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeChatAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeChatAgentStatusResponse
        /// </returns>
        public ChangeChatAgentStatusResponse ChangeChatAgentStatus(ChangeChatAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeChatAgentStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改在线客服状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeChatAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeChatAgentStatusResponse
        /// </returns>
        public async Task<ChangeChatAgentStatusResponse> ChangeChatAgentStatusAsync(ChangeChatAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeChatAgentStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangeQualityProjectStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeQualityProjectStatusResponse
        /// </returns>
        public ChangeQualityProjectStatusResponse ChangeQualityProjectStatusWithOptions(ChangeQualityProjectStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "ChangeQualityProjectStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeQualityProjectStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeQualityProjectStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeQualityProjectStatusResponse
        /// </returns>
        public async Task<ChangeQualityProjectStatusResponse> ChangeQualityProjectStatusWithOptionsAsync(ChangeQualityProjectStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "ChangeQualityProjectStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeQualityProjectStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeQualityProjectStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeQualityProjectStatusResponse
        /// </returns>
        public ChangeQualityProjectStatusResponse ChangeQualityProjectStatus(ChangeQualityProjectStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeQualityProjectStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangeQualityProjectStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeQualityProjectStatusResponse
        /// </returns>
        public async Task<ChangeQualityProjectStatusResponse> ChangeQualityProjectStatusAsync(ChangeQualityProjectStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeQualityProjectStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public CreateAgentResponse CreateAgentWithOptions(CreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                bodyFlat["SkillGroupId"] = request.SkillGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdList))
            {
                bodyFlat["SkillGroupIdList"] = request.SkillGroupIdList;
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
                Action = "CreateAgent",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public async Task<CreateAgentResponse> CreateAgentWithOptionsAsync(CreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                bodyFlat["SkillGroupId"] = request.SkillGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdList))
            {
                bodyFlat["SkillGroupIdList"] = request.SkillGroupIdList;
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
                Action = "CreateAgent",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public async Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能外呼任务（预测式外呼、自动外呼）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAiOutboundTaskResponse
        /// </returns>
        public CreateAiOutboundTaskResponse CreateAiOutboundTaskWithOptions(CreateAiOutboundTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAiOutboundTaskShrinkRequest request = new CreateAiOutboundTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutboundNums))
            {
                request.OutboundNumsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutboundNums, "OutboundNums", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecallRule))
            {
                request.RecallRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecallRule, "RecallRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrentRate))
            {
                query["ConcurrentRate"] = request.ConcurrentRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTime))
            {
                query["ExecutionTime"] = request.ExecutionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastCallRate))
            {
                query["ForecastCallRate"] = request.ForecastCallRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandlerId))
            {
                query["HandlerId"] = request.HandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumRepeated))
            {
                query["NumRepeated"] = request.NumRepeated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundNumsShrink))
            {
                query["OutboundNums"] = request.OutboundNumsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallRuleShrink))
            {
                query["RecallRule"] = request.RecallRuleShrink;
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
                Action = "CreateAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAiOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能外呼任务（预测式外呼、自动外呼）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAiOutboundTaskResponse
        /// </returns>
        public async Task<CreateAiOutboundTaskResponse> CreateAiOutboundTaskWithOptionsAsync(CreateAiOutboundTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAiOutboundTaskShrinkRequest request = new CreateAiOutboundTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutboundNums))
            {
                request.OutboundNumsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutboundNums, "OutboundNums", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecallRule))
            {
                request.RecallRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecallRule, "RecallRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrentRate))
            {
                query["ConcurrentRate"] = request.ConcurrentRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTime))
            {
                query["ExecutionTime"] = request.ExecutionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastCallRate))
            {
                query["ForecastCallRate"] = request.ForecastCallRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandlerId))
            {
                query["HandlerId"] = request.HandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumRepeated))
            {
                query["NumRepeated"] = request.NumRepeated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundNumsShrink))
            {
                query["OutboundNums"] = request.OutboundNumsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallRuleShrink))
            {
                query["RecallRule"] = request.RecallRuleShrink;
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
                Action = "CreateAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAiOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能外呼任务（预测式外呼、自动外呼）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAiOutboundTaskResponse
        /// </returns>
        public CreateAiOutboundTaskResponse CreateAiOutboundTask(CreateAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAiOutboundTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能外呼任务（预测式外呼、自动外呼）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAiOutboundTaskResponse
        /// </returns>
        public async Task<CreateAiOutboundTaskResponse> CreateAiOutboundTaskAsync(CreateAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAiOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能外呼任务批次</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAiOutboundTaskBatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAiOutboundTaskBatchResponse
        /// </returns>
        public CreateAiOutboundTaskBatchResponse CreateAiOutboundTaskBatchWithOptions(CreateAiOutboundTaskBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "CreateAiOutboundTaskBatch",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAiOutboundTaskBatchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能外呼任务批次</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAiOutboundTaskBatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAiOutboundTaskBatchResponse
        /// </returns>
        public async Task<CreateAiOutboundTaskBatchResponse> CreateAiOutboundTaskBatchWithOptionsAsync(CreateAiOutboundTaskBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "CreateAiOutboundTaskBatch",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAiOutboundTaskBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能外呼任务批次</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAiOutboundTaskBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAiOutboundTaskBatchResponse
        /// </returns>
        public CreateAiOutboundTaskBatchResponse CreateAiOutboundTaskBatch(CreateAiOutboundTaskBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAiOutboundTaskBatchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能外呼任务批次</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAiOutboundTaskBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAiOutboundTaskBatchResponse
        /// </returns>
        public async Task<CreateAiOutboundTaskBatchResponse> CreateAiOutboundTaskBatchAsync(CreateAiOutboundTaskBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAiOutboundTaskBatchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDepartmentResponse
        /// </returns>
        public CreateDepartmentResponse CreateDepartmentWithOptions(CreateDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["DepartmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDepartment",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDepartmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDepartmentResponse
        /// </returns>
        public async Task<CreateDepartmentResponse> CreateDepartmentWithOptionsAsync(CreateDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["DepartmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDepartment",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDepartmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDepartmentResponse
        /// </returns>
        public CreateDepartmentResponse CreateDepartment(CreateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDepartmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDepartmentResponse
        /// </returns>
        public async Task<CreateDepartmentResponse> CreateDepartmentAsync(CreateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDepartmentWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOutboundTaskResponse
        /// </returns>
        public CreateOutboundTaskResponse CreateOutboundTaskWithOptions(CreateOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ani))
            {
                query["Ani"] = request.Ani;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallInfos))
            {
                query["CallInfos"] = request.CallInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtAttrs))
            {
                query["ExtAttrs"] = request.ExtAttrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryInterval))
            {
                query["RetryInterval"] = request.RetryInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryTime))
            {
                query["RetryTime"] = request.RetryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroup))
            {
                query["SkillGroup"] = request.SkillGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOutboundTaskResponse
        /// </returns>
        public async Task<CreateOutboundTaskResponse> CreateOutboundTaskWithOptionsAsync(CreateOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ani))
            {
                query["Ani"] = request.Ani;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallInfos))
            {
                query["CallInfos"] = request.CallInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtAttrs))
            {
                query["ExtAttrs"] = request.ExtAttrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryInterval))
            {
                query["RetryInterval"] = request.RetryInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryTime))
            {
                query["RetryTime"] = request.RetryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroup))
            {
                query["SkillGroup"] = request.SkillGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOutboundTaskResponse
        /// </returns>
        public CreateOutboundTaskResponse CreateOutboundTask(CreateOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOutboundTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOutboundTaskResponse
        /// </returns>
        public async Task<CreateOutboundTaskResponse> CreateOutboundTaskAsync(CreateOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateQualityProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityProjectResponse
        /// </returns>
        public CreateQualityProjectResponse CreateQualityProjectWithOptions(CreateQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisIds))
            {
                body["AnalysisIds"] = request.AnalysisIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelTouchType))
            {
                body["ChannelTouchType"] = request.ChannelTouchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckFreqType))
            {
                body["CheckFreqType"] = request.CheckFreqType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepList))
            {
                body["DepList"] = request.DepList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupList))
            {
                body["GroupList"] = request.GroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                body["ScopeType"] = request.ScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerList))
            {
                body["ServicerList"] = request.ServicerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeEnd))
            {
                body["TimeRangeEnd"] = request.TimeRangeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeStart))
            {
                body["TimeRangeStart"] = request.TimeRangeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQualityProject",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQualityProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateQualityProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityProjectResponse
        /// </returns>
        public async Task<CreateQualityProjectResponse> CreateQualityProjectWithOptionsAsync(CreateQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisIds))
            {
                body["AnalysisIds"] = request.AnalysisIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelTouchType))
            {
                body["ChannelTouchType"] = request.ChannelTouchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckFreqType))
            {
                body["CheckFreqType"] = request.CheckFreqType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepList))
            {
                body["DepList"] = request.DepList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupList))
            {
                body["GroupList"] = request.GroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                body["ScopeType"] = request.ScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerList))
            {
                body["ServicerList"] = request.ServicerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeEnd))
            {
                body["TimeRangeEnd"] = request.TimeRangeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeStart))
            {
                body["TimeRangeStart"] = request.TimeRangeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQualityProject",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQualityProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateQualityProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityProjectResponse
        /// </returns>
        public CreateQualityProjectResponse CreateQualityProject(CreateQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityProjectWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateQualityProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityProjectResponse
        /// </returns>
        public async Task<CreateQualityProjectResponse> CreateQualityProjectAsync(CreateQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityProjectWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateQualityRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityRuleResponse
        /// </returns>
        public CreateQualityRuleResponse CreateQualityRuleWithOptions(CreateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                body["KeyWords"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                body["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleTag))
            {
                body["RuleTag"] = request.RuleTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQualityRule",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQualityRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateQualityRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityRuleResponse
        /// </returns>
        public async Task<CreateQualityRuleResponse> CreateQualityRuleWithOptionsAsync(CreateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                body["KeyWords"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                body["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleTag))
            {
                body["RuleTag"] = request.RuleTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQualityRule",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQualityRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateQualityRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityRuleResponse
        /// </returns>
        public CreateQualityRuleResponse CreateQualityRule(CreateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateQualityRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityRuleResponse
        /// </returns>
        public async Task<CreateQualityRuleResponse> CreateQualityRuleAsync(CreateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillGroupResponse
        /// </returns>
        public CreateSkillGroupResponse CreateSkillGroupWithOptions(CreateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                body["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupName))
            {
                body["SkillGroupName"] = request.SkillGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillGroupResponse
        /// </returns>
        public async Task<CreateSkillGroupResponse> CreateSkillGroupWithOptionsAsync(CreateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                body["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupName))
            {
                body["SkillGroupName"] = request.SkillGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillGroupResponse
        /// </returns>
        public CreateSkillGroupResponse CreateSkillGroup(CreateSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSkillGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillGroupResponse
        /// </returns>
        public async Task<CreateSkillGroupResponse> CreateSkillGroupAsync(CreateSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSkillGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public CreateTaskResponse CreateTaskWithOptions(CreateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallString))
            {
                query["CallString"] = request.CallString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStringType))
            {
                query["CallStringType"] = request.CallStringType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryCount))
            {
                query["RetryCount"] = request.RetryCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryFlag))
            {
                query["RetryFlag"] = request.RetryFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryInterval))
            {
                query["RetryInterval"] = request.RetryInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStatusCode))
            {
                query["RetryStatusCode"] = request.RetryStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotId))
            {
                query["RobotId"] = request.RobotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatCount))
            {
                query["SeatCount"] = request.SeatCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartNow))
            {
                query["StartNow"] = request.StartNow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkDay))
            {
                query["WorkDay"] = request.WorkDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkTimeList))
            {
                query["WorkTimeList"] = request.WorkTimeList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public async Task<CreateTaskResponse> CreateTaskWithOptionsAsync(CreateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallString))
            {
                query["CallString"] = request.CallString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStringType))
            {
                query["CallStringType"] = request.CallStringType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryCount))
            {
                query["RetryCount"] = request.RetryCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryFlag))
            {
                query["RetryFlag"] = request.RetryFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryInterval))
            {
                query["RetryInterval"] = request.RetryInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStatusCode))
            {
                query["RetryStatusCode"] = request.RetryStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotId))
            {
                query["RobotId"] = request.RobotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatCount))
            {
                query["SeatCount"] = request.SeatCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartNow))
            {
                query["StartNow"] = request.StartNow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkDay))
            {
                query["WorkDay"] = request.WorkDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkTimeList))
            {
                query["WorkTimeList"] = request.WorkTimeList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public async Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建坐席并开通sso登录能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateThirdSsoAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateThirdSsoAgentResponse
        /// </returns>
        public CreateThirdSsoAgentResponse CreateThirdSsoAgentWithOptions(CreateThirdSsoAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                bodyFlat["RoleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIds))
            {
                bodyFlat["SkillGroupIds"] = request.SkillGroupIds;
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
                Action = "CreateThirdSsoAgent",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateThirdSsoAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建坐席并开通sso登录能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateThirdSsoAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateThirdSsoAgentResponse
        /// </returns>
        public async Task<CreateThirdSsoAgentResponse> CreateThirdSsoAgentWithOptionsAsync(CreateThirdSsoAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                bodyFlat["RoleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIds))
            {
                bodyFlat["SkillGroupIds"] = request.SkillGroupIds;
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
                Action = "CreateThirdSsoAgent",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateThirdSsoAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建坐席并开通sso登录能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateThirdSsoAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateThirdSsoAgentResponse
        /// </returns>
        public CreateThirdSsoAgentResponse CreateThirdSsoAgent(CreateThirdSsoAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateThirdSsoAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建坐席并开通sso登录能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateThirdSsoAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateThirdSsoAgentResponse
        /// </returns>
        public async Task<CreateThirdSsoAgentResponse> CreateThirdSsoAgentAsync(CreateThirdSsoAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateThirdSsoAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除坐席账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgentWithOptions(DeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgent",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除坐席账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentWithOptionsAsync(DeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgent",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除坐席账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除坐席账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAiOutboundTaskResponse
        /// </returns>
        public DeleteAiOutboundTaskResponse DeleteAiOutboundTaskWithOptions(DeleteAiOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAiOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAiOutboundTaskResponse
        /// </returns>
        public async Task<DeleteAiOutboundTaskResponse> DeleteAiOutboundTaskWithOptionsAsync(DeleteAiOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAiOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAiOutboundTaskResponse
        /// </returns>
        public DeleteAiOutboundTaskResponse DeleteAiOutboundTask(DeleteAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAiOutboundTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAiOutboundTaskResponse
        /// </returns>
        public async Task<DeleteAiOutboundTaskResponse> DeleteAiOutboundTaskAsync(DeleteAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAiOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDepartmentResponse
        /// </returns>
        public DeleteDepartmentResponse DeleteDepartmentWithOptions(DeleteDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDepartment",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDepartmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDepartmentResponse
        /// </returns>
        public async Task<DeleteDepartmentResponse> DeleteDepartmentWithOptionsAsync(DeleteDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDepartment",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDepartmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDepartmentResponse
        /// </returns>
        public DeleteDepartmentResponse DeleteDepartment(DeleteDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDepartmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDepartmentResponse
        /// </returns>
        public async Task<DeleteDepartmentResponse> DeleteDepartmentAsync(DeleteDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDepartmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除热线号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotlineNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotlineNumberResponse
        /// </returns>
        public DeleteHotlineNumberResponse DeleteHotlineNumberWithOptions(DeleteHotlineNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotlineNumber))
            {
                body["HotlineNumber"] = request.HotlineNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHotlineNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHotlineNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除热线号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotlineNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotlineNumberResponse
        /// </returns>
        public async Task<DeleteHotlineNumberResponse> DeleteHotlineNumberWithOptionsAsync(DeleteHotlineNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotlineNumber))
            {
                body["HotlineNumber"] = request.HotlineNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHotlineNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHotlineNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除热线号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotlineNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotlineNumberResponse
        /// </returns>
        public DeleteHotlineNumberResponse DeleteHotlineNumber(DeleteHotlineNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHotlineNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除热线号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHotlineNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHotlineNumberResponse
        /// </returns>
        public async Task<DeleteHotlineNumberResponse> DeleteHotlineNumberAsync(DeleteHotlineNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHotlineNumberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundTaskResponse
        /// </returns>
        public DeleteOutboundTaskResponse DeleteOutboundTaskWithOptions(DeleteOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTaskId))
            {
                query["OutboundTaskId"] = request.OutboundTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundTaskResponse
        /// </returns>
        public async Task<DeleteOutboundTaskResponse> DeleteOutboundTaskWithOptionsAsync(DeleteOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTaskId))
            {
                query["OutboundTaskId"] = request.OutboundTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundTaskResponse
        /// </returns>
        public DeleteOutboundTaskResponse DeleteOutboundTask(DeleteOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOutboundTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOutboundTaskResponse
        /// </returns>
        public async Task<DeleteOutboundTaskResponse> DeleteOutboundTaskAsync(DeleteOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteOuterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOuterAccountResponse
        /// </returns>
        public DeleteOuterAccountResponse DeleteOuterAccountWithOptions(DeleteOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOuterAccount",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOuterAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteOuterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOuterAccountResponse
        /// </returns>
        public async Task<DeleteOuterAccountResponse> DeleteOuterAccountWithOptionsAsync(DeleteOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOuterAccount",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOuterAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteOuterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOuterAccountResponse
        /// </returns>
        public DeleteOuterAccountResponse DeleteOuterAccount(DeleteOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOuterAccountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteOuterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOuterAccountResponse
        /// </returns>
        public async Task<DeleteOuterAccountResponse> DeleteOuterAccountAsync(DeleteOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOuterAccountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteQualityProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityProjectResponse
        /// </returns>
        public DeleteQualityProjectResponse DeleteQualityProjectWithOptions(DeleteQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteQualityProject",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQualityProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteQualityProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityProjectResponse
        /// </returns>
        public async Task<DeleteQualityProjectResponse> DeleteQualityProjectWithOptionsAsync(DeleteQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteQualityProject",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQualityProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteQualityProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityProjectResponse
        /// </returns>
        public DeleteQualityProjectResponse DeleteQualityProject(DeleteQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityProjectWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteQualityProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityProjectResponse
        /// </returns>
        public async Task<DeleteQualityProjectResponse> DeleteQualityProjectAsync(DeleteQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityProjectWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteQualityRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityRuleResponse
        /// </returns>
        public DeleteQualityRuleResponse DeleteQualityRuleWithOptions(DeleteQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQualityRule",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQualityRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteQualityRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityRuleResponse
        /// </returns>
        public async Task<DeleteQualityRuleResponse> DeleteQualityRuleWithOptionsAsync(DeleteQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQualityRule",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQualityRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteQualityRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityRuleResponse
        /// </returns>
        public DeleteQualityRuleResponse DeleteQualityRule(DeleteQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteQualityRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityRuleResponse
        /// </returns>
        public async Task<DeleteQualityRuleResponse> DeleteQualityRuleAsync(DeleteQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillGroupResponse
        /// </returns>
        public DeleteSkillGroupResponse DeleteSkillGroupWithOptions(DeleteSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillGroupResponse
        /// </returns>
        public async Task<DeleteSkillGroupResponse> DeleteSkillGroupWithOptionsAsync(DeleteSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillGroupResponse
        /// </returns>
        public DeleteSkillGroupResponse DeleteSkillGroup(DeleteSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSkillGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillGroupResponse
        /// </returns>
        public async Task<DeleteSkillGroupResponse> DeleteSkillGroupAsync(DeleteSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSkillGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeRecordDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordDataResponse
        /// </returns>
        public DescribeRecordDataResponse DescribeRecordDataWithOptions(DescribeRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acid))
            {
                query["Acid"] = request.Acid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecLevel))
            {
                query["SecLevel"] = request.SecLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordData",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordDataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeRecordDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordDataResponse
        /// </returns>
        public async Task<DescribeRecordDataResponse> DescribeRecordDataWithOptionsAsync(DescribeRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acid))
            {
                query["Acid"] = request.Acid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecLevel))
            {
                query["SecLevel"] = request.SecLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordData",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeRecordDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordDataResponse
        /// </returns>
        public DescribeRecordDataResponse DescribeRecordData(DescribeRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeRecordDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecordDataResponse
        /// </returns>
        public async Task<DescribeRecordDataResponse> DescribeRecordDataAsync(DescribeRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EditQualityProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditQualityProjectResponse
        /// </returns>
        public EditQualityProjectResponse EditQualityProjectWithOptions(EditQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisIds))
            {
                query["AnalysisIds"] = request.AnalysisIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelTouchType))
            {
                query["ChannelTouchType"] = request.ChannelTouchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckFreqType))
            {
                query["CheckFreqType"] = request.CheckFreqType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepList))
            {
                query["DepList"] = request.DepList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupList))
            {
                query["GroupList"] = request.GroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectVersion))
            {
                query["ProjectVersion"] = request.ProjectVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["ScopeType"] = request.ScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerList))
            {
                query["ServicerList"] = request.ServicerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeEnd))
            {
                query["TimeRangeEnd"] = request.TimeRangeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeStart))
            {
                query["TimeRangeStart"] = request.TimeRangeStart;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditQualityProject",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditQualityProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EditQualityProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditQualityProjectResponse
        /// </returns>
        public async Task<EditQualityProjectResponse> EditQualityProjectWithOptionsAsync(EditQualityProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisIds))
            {
                query["AnalysisIds"] = request.AnalysisIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelTouchType))
            {
                query["ChannelTouchType"] = request.ChannelTouchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckFreqType))
            {
                query["CheckFreqType"] = request.CheckFreqType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepList))
            {
                query["DepList"] = request.DepList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupList))
            {
                query["GroupList"] = request.GroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectVersion))
            {
                query["ProjectVersion"] = request.ProjectVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["ScopeType"] = request.ScopeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerList))
            {
                query["ServicerList"] = request.ServicerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeEnd))
            {
                query["TimeRangeEnd"] = request.TimeRangeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeStart))
            {
                query["TimeRangeStart"] = request.TimeRangeStart;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditQualityProject",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditQualityProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EditQualityProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// EditQualityProjectResponse
        /// </returns>
        public EditQualityProjectResponse EditQualityProject(EditQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditQualityProjectWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EditQualityProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// EditQualityProjectResponse
        /// </returns>
        public async Task<EditQualityProjectResponse> EditQualityProjectAsync(EditQualityProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditQualityProjectWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EditQualityRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditQualityRuleResponse
        /// </returns>
        public EditQualityRuleResponse EditQualityRuleWithOptions(EditQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                body["KeyWords"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                body["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityRuleId))
            {
                body["QualityRuleId"] = request.QualityRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleTag))
            {
                body["RuleTag"] = request.RuleTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditQualityRule",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditQualityRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EditQualityRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditQualityRuleResponse
        /// </returns>
        public async Task<EditQualityRuleResponse> EditQualityRuleWithOptionsAsync(EditQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                body["KeyWords"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                body["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityRuleId))
            {
                body["QualityRuleId"] = request.QualityRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleTag))
            {
                body["RuleTag"] = request.RuleTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditQualityRule",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditQualityRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EditQualityRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EditQualityRuleResponse
        /// </returns>
        public EditQualityRuleResponse EditQualityRule(EditQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditQualityRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EditQualityRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EditQualityRuleResponse
        /// </returns>
        public async Task<EditQualityRuleResponse> EditQualityRuleAsync(EditQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditQualityRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EditQualityRuleTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditQualityRuleTagResponse
        /// </returns>
        public EditQualityRuleTagResponse EditQualityRuleTagWithOptions(EditQualityRuleTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisTypes))
            {
                query["AnalysisTypes"] = request.AnalysisTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditQualityRuleTag",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditQualityRuleTagResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EditQualityRuleTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditQualityRuleTagResponse
        /// </returns>
        public async Task<EditQualityRuleTagResponse> EditQualityRuleTagWithOptionsAsync(EditQualityRuleTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalysisTypes))
            {
                query["AnalysisTypes"] = request.AnalysisTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditQualityRuleTag",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditQualityRuleTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EditQualityRuleTagRequest
        /// </param>
        /// 
        /// <returns>
        /// EditQualityRuleTagResponse
        /// </returns>
        public EditQualityRuleTagResponse EditQualityRuleTag(EditQualityRuleTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditQualityRuleTagWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EditQualityRuleTagRequest
        /// </param>
        /// 
        /// <returns>
        /// EditQualityRuleTagResponse
        /// </returns>
        public async Task<EditQualityRuleTagResponse> EditQualityRuleTagAsync(EditQualityRuleTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditQualityRuleTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线号码加密</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EncryptPhoneNumRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EncryptPhoneNumResponse
        /// </returns>
        public EncryptPhoneNumResponse EncryptPhoneNumWithOptions(EncryptPhoneNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EncryptPhoneNum",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EncryptPhoneNumResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线号码加密</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EncryptPhoneNumRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EncryptPhoneNumResponse
        /// </returns>
        public async Task<EncryptPhoneNumResponse> EncryptPhoneNumWithOptionsAsync(EncryptPhoneNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EncryptPhoneNum",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EncryptPhoneNumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线号码加密</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EncryptPhoneNumRequest
        /// </param>
        /// 
        /// <returns>
        /// EncryptPhoneNumResponse
        /// </returns>
        public EncryptPhoneNumResponse EncryptPhoneNum(EncryptPhoneNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EncryptPhoneNumWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线号码加密</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EncryptPhoneNumRequest
        /// </param>
        /// 
        /// <returns>
        /// EncryptPhoneNumResponse
        /// </returns>
        public async Task<EncryptPhoneNumResponse> EncryptPhoneNumAsync(EncryptPhoneNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EncryptPhoneNumWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FetchCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchCallResponse
        /// </returns>
        public FetchCallResponse FetchCallWithOptions(FetchCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldConnectionId))
            {
                body["HoldConnectionId"] = request.HoldConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "FetchCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FetchCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchCallResponse
        /// </returns>
        public async Task<FetchCallResponse> FetchCallWithOptionsAsync(FetchCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldConnectionId))
            {
                body["HoldConnectionId"] = request.HoldConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "FetchCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FetchCallRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchCallResponse
        /// </returns>
        public FetchCallResponse FetchCall(FetchCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FetchCallRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchCallResponse
        /// </returns>
        public async Task<FetchCallResponse> FetchCallAsync(FetchCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FinishHotlineServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FinishHotlineServiceResponse
        /// </returns>
        public FinishHotlineServiceResponse FinishHotlineServiceWithOptions(FinishHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishHotlineService",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishHotlineServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FinishHotlineServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FinishHotlineServiceResponse
        /// </returns>
        public async Task<FinishHotlineServiceResponse> FinishHotlineServiceWithOptionsAsync(FinishHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishHotlineService",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishHotlineServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FinishHotlineServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// FinishHotlineServiceResponse
        /// </returns>
        public FinishHotlineServiceResponse FinishHotlineService(FinishHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FinishHotlineServiceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FinishHotlineServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// FinishHotlineServiceResponse
        /// </returns>
        public async Task<FinishHotlineServiceResponse> FinishHotlineServiceAsync(FinishHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FinishHotlineServiceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GenerateWebSocketSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateWebSocketSignResponse
        /// </returns>
        public GenerateWebSocketSignResponse GenerateWebSocketSignWithOptions(GenerateWebSocketSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateWebSocketSign",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateWebSocketSignResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GenerateWebSocketSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateWebSocketSignResponse
        /// </returns>
        public async Task<GenerateWebSocketSignResponse> GenerateWebSocketSignWithOptionsAsync(GenerateWebSocketSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateWebSocketSign",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateWebSocketSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GenerateWebSocketSignRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateWebSocketSignResponse
        /// </returns>
        public GenerateWebSocketSignResponse GenerateWebSocketSign(GenerateWebSocketSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateWebSocketSignWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GenerateWebSocketSignRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateWebSocketSignResponse
        /// </returns>
        public async Task<GenerateWebSocketSignResponse> GenerateWebSocketSignAsync(GenerateWebSocketSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateWebSocketSignWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public GetAgentResponse GetAgentWithOptions(GetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgent",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public async Task<GetAgentResponse> GetAgentWithOptionsAsync(GetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgent",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public GetAgentResponse GetAgent(GetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public async Task<GetAgentResponse> GetAgentAsync(GetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席纬度基础状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAgentBasisStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentBasisStatusResponse
        /// </returns>
        public GetAgentBasisStatusResponse GetAgentBasisStatusWithOptions(GetAgentBasisStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentBasisStatusShrinkRequest request = new GetAgentBasisStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentBasisStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentBasisStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席纬度基础状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAgentBasisStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentBasisStatusResponse
        /// </returns>
        public async Task<GetAgentBasisStatusResponse> GetAgentBasisStatusWithOptionsAsync(GetAgentBasisStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentBasisStatusShrinkRequest request = new GetAgentBasisStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentBasisStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentBasisStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席纬度基础状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentBasisStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentBasisStatusResponse
        /// </returns>
        public GetAgentBasisStatusResponse GetAgentBasisStatus(GetAgentBasisStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentBasisStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席纬度基础状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentBasisStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentBasisStatusResponse
        /// </returns>
        public async Task<GetAgentBasisStatusResponse> GetAgentBasisStatusAsync(GetAgentBasisStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentBasisStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAgentByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentByIdResponse
        /// </returns>
        public GetAgentByIdResponse GetAgentByIdWithOptions(GetAgentByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentById",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgentByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentByIdResponse
        /// </returns>
        public async Task<GetAgentByIdResponse> GetAgentByIdWithOptionsAsync(GetAgentByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentById",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgentByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentByIdResponse
        /// </returns>
        public GetAgentByIdResponse GetAgentById(GetAgentByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentByIdWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAgentByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentByIdResponse
        /// </returns>
        public async Task<GetAgentByIdResponse> GetAgentByIdAsync(GetAgentByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线坐席纬度详情汇总</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAgentDetailReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentDetailReportResponse
        /// </returns>
        public GetAgentDetailReportResponse GetAgentDetailReportWithOptions(GetAgentDetailReportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentDetailReportShrinkRequest request = new GetAgentDetailReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentDetailReport",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentDetailReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线坐席纬度详情汇总</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAgentDetailReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentDetailReportResponse
        /// </returns>
        public async Task<GetAgentDetailReportResponse> GetAgentDetailReportWithOptionsAsync(GetAgentDetailReportRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentDetailReportShrinkRequest request = new GetAgentDetailReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentDetailReport",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentDetailReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线坐席纬度详情汇总</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentDetailReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentDetailReportResponse
        /// </returns>
        public GetAgentDetailReportResponse GetAgentDetailReport(GetAgentDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentDetailReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线坐席纬度详情汇总</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentDetailReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentDetailReportResponse
        /// </returns>
        public async Task<GetAgentDetailReportResponse> GetAgentDetailReportAsync(GetAgentDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentDetailReportWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAgentIndexRealTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIndexRealTimeResponse
        /// </returns>
        public GetAgentIndexRealTimeResponse GetAgentIndexRealTimeWithOptions(GetAgentIndexRealTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepIds))
            {
                query["DepIds"] = request.DepIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetAgentIndexRealTime",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentIndexRealTimeResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgentIndexRealTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIndexRealTimeResponse
        /// </returns>
        public async Task<GetAgentIndexRealTimeResponse> GetAgentIndexRealTimeWithOptionsAsync(GetAgentIndexRealTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepIds))
            {
                query["DepIds"] = request.DepIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetAgentIndexRealTime",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentIndexRealTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAgentIndexRealTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIndexRealTimeResponse
        /// </returns>
        public GetAgentIndexRealTimeResponse GetAgentIndexRealTime(GetAgentIndexRealTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentIndexRealTimeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAgentIndexRealTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIndexRealTimeResponse
        /// </returns>
        public async Task<GetAgentIndexRealTimeResponse> GetAgentIndexRealTimeAsync(GetAgentIndexRealTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentIndexRealTimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席服务状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAgentServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentServiceStatusResponse
        /// </returns>
        public GetAgentServiceStatusResponse GetAgentServiceStatusWithOptions(GetAgentServiceStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentServiceStatusShrinkRequest request = new GetAgentServiceStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentServiceStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席服务状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAgentServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentServiceStatusResponse
        /// </returns>
        public async Task<GetAgentServiceStatusResponse> GetAgentServiceStatusWithOptionsAsync(GetAgentServiceStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentServiceStatusShrinkRequest request = new GetAgentServiceStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentServiceStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席服务状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentServiceStatusResponse
        /// </returns>
        public GetAgentServiceStatusResponse GetAgentServiceStatus(GetAgentServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentServiceStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席服务状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentServiceStatusResponse
        /// </returns>
        public async Task<GetAgentServiceStatusResponse> GetAgentServiceStatusAsync(GetAgentServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentServiceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席纬度统计量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAgentStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentStatisticsResponse
        /// </returns>
        public GetAgentStatisticsResponse GetAgentStatisticsWithOptions(GetAgentStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentStatisticsShrinkRequest request = new GetAgentStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentStatistics",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席纬度统计量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAgentStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentStatisticsResponse
        /// </returns>
        public async Task<GetAgentStatisticsResponse> GetAgentStatisticsWithOptionsAsync(GetAgentStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAgentStatisticsShrinkRequest request = new GetAgentStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentStatistics",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席纬度统计量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentStatisticsResponse
        /// </returns>
        public GetAgentStatisticsResponse GetAgentStatistics(GetAgentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>坐席纬度统计量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentStatisticsResponse
        /// </returns>
        public async Task<GetAgentStatisticsResponse> GetAgentStatisticsAsync(GetAgentStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能外呼任务业务自定义信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskBizDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskBizDataResponse
        /// </returns>
        public GetAiOutboundTaskBizDataResponse GetAiOutboundTaskBizDataWithOptions(GetAiOutboundTaskBizDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiOutboundTaskBizData",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiOutboundTaskBizDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能外呼任务业务自定义信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskBizDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskBizDataResponse
        /// </returns>
        public async Task<GetAiOutboundTaskBizDataResponse> GetAiOutboundTaskBizDataWithOptionsAsync(GetAiOutboundTaskBizDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiOutboundTaskBizData",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiOutboundTaskBizDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能外呼任务业务自定义信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskBizDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskBizDataResponse
        /// </returns>
        public GetAiOutboundTaskBizDataResponse GetAiOutboundTaskBizData(GetAiOutboundTaskBizDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAiOutboundTaskBizDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能外呼任务业务自定义信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskBizDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskBizDataResponse
        /// </returns>
        public async Task<GetAiOutboundTaskBizDataResponse> GetAiOutboundTaskBizDataAsync(GetAiOutboundTaskBizDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAiOutboundTaskBizDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务配置详情查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskDetailResponse
        /// </returns>
        public GetAiOutboundTaskDetailResponse GetAiOutboundTaskDetailWithOptions(GetAiOutboundTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiOutboundTaskDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiOutboundTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务配置详情查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskDetailResponse
        /// </returns>
        public async Task<GetAiOutboundTaskDetailResponse> GetAiOutboundTaskDetailWithOptionsAsync(GetAiOutboundTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiOutboundTaskDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiOutboundTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务配置详情查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskDetailResponse
        /// </returns>
        public GetAiOutboundTaskDetailResponse GetAiOutboundTaskDetail(GetAiOutboundTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAiOutboundTaskDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务配置详情查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskDetailResponse
        /// </returns>
        public async Task<GetAiOutboundTaskDetailResponse> GetAiOutboundTaskDetailAsync(GetAiOutboundTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAiOutboundTaskDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务执行详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskExecDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskExecDetailResponse
        /// </returns>
        public GetAiOutboundTaskExecDetailResponse GetAiOutboundTaskExecDetailWithOptions(GetAiOutboundTaskExecDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiOutboundTaskExecDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiOutboundTaskExecDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务执行详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskExecDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskExecDetailResponse
        /// </returns>
        public async Task<GetAiOutboundTaskExecDetailResponse> GetAiOutboundTaskExecDetailWithOptionsAsync(GetAiOutboundTaskExecDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiOutboundTaskExecDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiOutboundTaskExecDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务执行详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskExecDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskExecDetailResponse
        /// </returns>
        public GetAiOutboundTaskExecDetailResponse GetAiOutboundTaskExecDetail(GetAiOutboundTaskExecDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAiOutboundTaskExecDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务执行详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskExecDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskExecDetailResponse
        /// </returns>
        public async Task<GetAiOutboundTaskExecDetailResponse> GetAiOutboundTaskExecDetailAsync(GetAiOutboundTaskExecDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAiOutboundTaskExecDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskListResponse
        /// </returns>
        public GetAiOutboundTaskListResponse GetAiOutboundTaskListWithOptions(GetAiOutboundTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiOutboundTaskList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiOutboundTaskListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskListResponse
        /// </returns>
        public async Task<GetAiOutboundTaskListResponse> GetAiOutboundTaskListWithOptionsAsync(GetAiOutboundTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiOutboundTaskList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiOutboundTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskListResponse
        /// </returns>
        public GetAiOutboundTaskListResponse GetAiOutboundTaskList(GetAiOutboundTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAiOutboundTaskListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskListResponse
        /// </returns>
        public async Task<GetAiOutboundTaskListResponse> GetAiOutboundTaskListAsync(GetAiOutboundTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAiOutboundTaskListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务执行进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskProgressResponse
        /// </returns>
        public GetAiOutboundTaskProgressResponse GetAiOutboundTaskProgressWithOptions(GetAiOutboundTaskProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiOutboundTaskProgress",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiOutboundTaskProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务执行进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskProgressResponse
        /// </returns>
        public async Task<GetAiOutboundTaskProgressResponse> GetAiOutboundTaskProgressWithOptionsAsync(GetAiOutboundTaskProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAiOutboundTaskProgress",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAiOutboundTaskProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务执行进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskProgressResponse
        /// </returns>
        public GetAiOutboundTaskProgressResponse GetAiOutboundTaskProgress(GetAiOutboundTaskProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAiOutboundTaskProgressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务执行进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAiOutboundTaskProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAiOutboundTaskProgressResponse
        /// </returns>
        public async Task<GetAiOutboundTaskProgressResponse> GetAiOutboundTaskProgressAsync(GetAiOutboundTaskProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAiOutboundTaskProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>getAllDepartment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllDepartmentResponse
        /// </returns>
        public GetAllDepartmentResponse GetAllDepartmentWithOptions(GetAllDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllDepartment",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllDepartmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>getAllDepartment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllDepartmentResponse
        /// </returns>
        public async Task<GetAllDepartmentResponse> GetAllDepartmentWithOptionsAsync(GetAllDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAllDepartment",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllDepartmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>getAllDepartment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllDepartmentResponse
        /// </returns>
        public GetAllDepartmentResponse GetAllDepartment(GetAllDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllDepartmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>getAllDepartment</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllDepartmentResponse
        /// </returns>
        public async Task<GetAllDepartmentResponse> GetAllDepartmentAsync(GetAllDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllDepartmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通话录音文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallSoundRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCallSoundRecordResponse
        /// </returns>
        public GetCallSoundRecordResponse GetCallSoundRecordWithOptions(GetCallSoundRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
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
                Action = "GetCallSoundRecord",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallSoundRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通话录音文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallSoundRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCallSoundRecordResponse
        /// </returns>
        public async Task<GetCallSoundRecordResponse> GetCallSoundRecordWithOptionsAsync(GetCallSoundRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
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
                Action = "GetCallSoundRecord",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallSoundRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通话录音文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallSoundRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCallSoundRecordResponse
        /// </returns>
        public GetCallSoundRecordResponse GetCallSoundRecord(GetCallSoundRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCallSoundRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通话录音文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallSoundRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCallSoundRecordResponse
        /// </returns>
        public async Task<GetCallSoundRecordResponse> GetCallSoundRecordAsync(GetCallSoundRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCallSoundRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线配置号码列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigNumListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfigNumListResponse
        /// </returns>
        public GetConfigNumListResponse GetConfigNumListWithOptions(GetConfigNumListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigNumList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigNumListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线配置号码列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigNumListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfigNumListResponse
        /// </returns>
        public async Task<GetConfigNumListResponse> GetConfigNumListWithOptionsAsync(GetConfigNumListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfigNumList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigNumListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线配置号码列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigNumListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfigNumListResponse
        /// </returns>
        public GetConfigNumListResponse GetConfigNumList(GetConfigNumListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigNumListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线配置号码列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigNumListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfigNumListResponse
        /// </returns>
        public async Task<GetConfigNumListResponse> GetConfigNumListAsync(GetConfigNumListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigNumListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerInfoResponse
        /// </returns>
        public GetCustomerInfoResponse GetCustomerInfoWithOptions(GetCustomerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerInfo",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerInfoResponse
        /// </returns>
        public async Task<GetCustomerInfoResponse> GetCustomerInfoWithOptionsAsync(GetCustomerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerInfo",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerInfoResponse
        /// </returns>
        public GetCustomerInfoResponse GetCustomerInfo(GetCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerInfoResponse
        /// </returns>
        public async Task<GetCustomerInfoResponse> GetCustomerInfoAsync(GetCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能组分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDepGroupTreeDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDepGroupTreeDataResponse
        /// </returns>
        public GetDepGroupTreeDataResponse GetDepGroupTreeDataWithOptions(GetDepGroupTreeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDepGroupTreeData",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDepGroupTreeDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能组分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDepGroupTreeDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDepGroupTreeDataResponse
        /// </returns>
        public async Task<GetDepGroupTreeDataResponse> GetDepGroupTreeDataWithOptionsAsync(GetDepGroupTreeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDepGroupTreeData",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDepGroupTreeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能组分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDepGroupTreeDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDepGroupTreeDataResponse
        /// </returns>
        public GetDepGroupTreeDataResponse GetDepGroupTreeData(GetDepGroupTreeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDepGroupTreeDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能组分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDepGroupTreeDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDepGroupTreeDataResponse
        /// </returns>
        public async Task<GetDepGroupTreeDataResponse> GetDepGroupTreeDataAsync(GetDepGroupTreeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDepGroupTreeDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部门纬度坐席状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDepartmentalLatitudeAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDepartmentalLatitudeAgentStatusResponse
        /// </returns>
        public GetDepartmentalLatitudeAgentStatusResponse GetDepartmentalLatitudeAgentStatusWithOptions(GetDepartmentalLatitudeAgentStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDepartmentalLatitudeAgentStatusShrinkRequest request = new GetDepartmentalLatitudeAgentStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDepartmentalLatitudeAgentStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDepartmentalLatitudeAgentStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部门纬度坐席状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDepartmentalLatitudeAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDepartmentalLatitudeAgentStatusResponse
        /// </returns>
        public async Task<GetDepartmentalLatitudeAgentStatusResponse> GetDepartmentalLatitudeAgentStatusWithOptionsAsync(GetDepartmentalLatitudeAgentStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDepartmentalLatitudeAgentStatusShrinkRequest request = new GetDepartmentalLatitudeAgentStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDepartmentalLatitudeAgentStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDepartmentalLatitudeAgentStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部门纬度坐席状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDepartmentalLatitudeAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDepartmentalLatitudeAgentStatusResponse
        /// </returns>
        public GetDepartmentalLatitudeAgentStatusResponse GetDepartmentalLatitudeAgentStatus(GetDepartmentalLatitudeAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDepartmentalLatitudeAgentStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部门纬度坐席状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDepartmentalLatitudeAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDepartmentalLatitudeAgentStatusResponse
        /// </returns>
        public async Task<GetDepartmentalLatitudeAgentStatusResponse> GetDepartmentalLatitudeAgentStatusAsync(GetDepartmentalLatitudeAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDepartmentalLatitudeAgentStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetHotlineAgentDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentDetailResponse
        /// </returns>
        public GetHotlineAgentDetailResponse GetHotlineAgentDetailWithOptions(GetHotlineAgentDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineAgentDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineAgentDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHotlineAgentDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentDetailResponse
        /// </returns>
        public async Task<GetHotlineAgentDetailResponse> GetHotlineAgentDetailWithOptionsAsync(GetHotlineAgentDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineAgentDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineAgentDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHotlineAgentDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentDetailResponse
        /// </returns>
        public GetHotlineAgentDetailResponse GetHotlineAgentDetail(GetHotlineAgentDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineAgentDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetHotlineAgentDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentDetailResponse
        /// </returns>
        public async Task<GetHotlineAgentDetailResponse> GetHotlineAgentDetailAsync(GetHotlineAgentDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineAgentDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetHotlineAgentDetailReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentDetailReportResponse
        /// </returns>
        public GetHotlineAgentDetailReportResponse GetHotlineAgentDetailReportWithOptions(GetHotlineAgentDetailReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepIds))
            {
                query["DepIds"] = request.DepIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineAgentDetailReport",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineAgentDetailReportResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHotlineAgentDetailReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentDetailReportResponse
        /// </returns>
        public async Task<GetHotlineAgentDetailReportResponse> GetHotlineAgentDetailReportWithOptionsAsync(GetHotlineAgentDetailReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepIds))
            {
                query["DepIds"] = request.DepIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineAgentDetailReport",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineAgentDetailReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHotlineAgentDetailReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentDetailReportResponse
        /// </returns>
        public GetHotlineAgentDetailReportResponse GetHotlineAgentDetailReport(GetHotlineAgentDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineAgentDetailReportWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetHotlineAgentDetailReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentDetailReportResponse
        /// </returns>
        public async Task<GetHotlineAgentDetailReportResponse> GetHotlineAgentDetailReportAsync(GetHotlineAgentDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineAgentDetailReportWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetHotlineAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentStatusResponse
        /// </returns>
        public GetHotlineAgentStatusResponse GetHotlineAgentStatusWithOptions(GetHotlineAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineAgentStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineAgentStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHotlineAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentStatusResponse
        /// </returns>
        public async Task<GetHotlineAgentStatusResponse> GetHotlineAgentStatusWithOptionsAsync(GetHotlineAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineAgentStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineAgentStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHotlineAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentStatusResponse
        /// </returns>
        public GetHotlineAgentStatusResponse GetHotlineAgentStatus(GetHotlineAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineAgentStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetHotlineAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineAgentStatusResponse
        /// </returns>
        public async Task<GetHotlineAgentStatusResponse> GetHotlineAgentStatusAsync(GetHotlineAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineAgentStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询话务动作结果数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineCallActionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineCallActionResponse
        /// </returns>
        public GetHotlineCallActionResponse GetHotlineCallActionWithOptions(GetHotlineCallActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acc))
            {
                body["Acc"] = request.Acc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Act))
            {
                body["Act"] = request.Act;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Biz))
            {
                body["Biz"] = request.Biz;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromSource))
            {
                body["FromSource"] = request.FromSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineCallAction",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineCallActionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询话务动作结果数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineCallActionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineCallActionResponse
        /// </returns>
        public async Task<GetHotlineCallActionResponse> GetHotlineCallActionWithOptionsAsync(GetHotlineCallActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acc))
            {
                body["Acc"] = request.Acc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Act))
            {
                body["Act"] = request.Act;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Biz))
            {
                body["Biz"] = request.Biz;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromSource))
            {
                body["FromSource"] = request.FromSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineCallAction",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineCallActionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询话务动作结果数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineCallActionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineCallActionResponse
        /// </returns>
        public GetHotlineCallActionResponse GetHotlineCallAction(GetHotlineCallActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineCallActionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询话务动作结果数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineCallActionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineCallActionResponse
        /// </returns>
        public async Task<GetHotlineCallActionResponse> GetHotlineCallActionAsync(GetHotlineCallActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineCallActionWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetHotlineGroupDetailReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineGroupDetailReportResponse
        /// </returns>
        public GetHotlineGroupDetailReportResponse GetHotlineGroupDetailReportWithOptions(GetHotlineGroupDetailReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepIds))
            {
                query["DepIds"] = request.DepIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineGroupDetailReport",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineGroupDetailReportResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHotlineGroupDetailReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineGroupDetailReportResponse
        /// </returns>
        public async Task<GetHotlineGroupDetailReportResponse> GetHotlineGroupDetailReportWithOptionsAsync(GetHotlineGroupDetailReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepIds))
            {
                query["DepIds"] = request.DepIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineGroupDetailReport",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineGroupDetailReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHotlineGroupDetailReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineGroupDetailReportResponse
        /// </returns>
        public GetHotlineGroupDetailReportResponse GetHotlineGroupDetailReport(GetHotlineGroupDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineGroupDetailReportWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetHotlineGroupDetailReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineGroupDetailReportResponse
        /// </returns>
        public async Task<GetHotlineGroupDetailReportResponse> GetHotlineGroupDetailReportAsync(GetHotlineGroupDetailReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineGroupDetailReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线聊天记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineMessageLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineMessageLogResponse
        /// </returns>
        public GetHotlineMessageLogResponse GetHotlineMessageLogWithOptions(GetHotlineMessageLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineMessageLog",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineMessageLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线聊天记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineMessageLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineMessageLogResponse
        /// </returns>
        public async Task<GetHotlineMessageLogResponse> GetHotlineMessageLogWithOptionsAsync(GetHotlineMessageLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineMessageLog",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineMessageLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线聊天记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineMessageLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineMessageLogResponse
        /// </returns>
        public GetHotlineMessageLogResponse GetHotlineMessageLog(GetHotlineMessageLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineMessageLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线聊天记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineMessageLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineMessageLogResponse
        /// </returns>
        public async Task<GetHotlineMessageLogResponse> GetHotlineMessageLogAsync(GetHotlineMessageLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineMessageLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线当前信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineRuntimeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineRuntimeInfoResponse
        /// </returns>
        public GetHotlineRuntimeInfoResponse GetHotlineRuntimeInfoWithOptions(GetHotlineRuntimeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineRuntimeInfo",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineRuntimeInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线当前信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineRuntimeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineRuntimeInfoResponse
        /// </returns>
        public async Task<GetHotlineRuntimeInfoResponse> GetHotlineRuntimeInfoWithOptionsAsync(GetHotlineRuntimeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineRuntimeInfo",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineRuntimeInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线当前信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineRuntimeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineRuntimeInfoResponse
        /// </returns>
        public GetHotlineRuntimeInfoResponse GetHotlineRuntimeInfo(GetHotlineRuntimeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineRuntimeInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热线当前信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineRuntimeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineRuntimeInfoResponse
        /// </returns>
        public async Task<GetHotlineRuntimeInfoResponse> GetHotlineRuntimeInfoAsync(GetHotlineRuntimeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineRuntimeInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务统计量数据</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotlineServiceStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineServiceStatisticsResponse
        /// </returns>
        public GetHotlineServiceStatisticsResponse GetHotlineServiceStatisticsWithOptions(GetHotlineServiceStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotlineServiceStatisticsShrinkRequest request = new GetHotlineServiceStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineServiceStatistics",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineServiceStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务统计量数据</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotlineServiceStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineServiceStatisticsResponse
        /// </returns>
        public async Task<GetHotlineServiceStatisticsResponse> GetHotlineServiceStatisticsWithOptionsAsync(GetHotlineServiceStatisticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotlineServiceStatisticsShrinkRequest request = new GetHotlineServiceStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineServiceStatistics",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineServiceStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务统计量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineServiceStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineServiceStatisticsResponse
        /// </returns>
        public GetHotlineServiceStatisticsResponse GetHotlineServiceStatistics(GetHotlineServiceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineServiceStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务统计量数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotlineServiceStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineServiceStatisticsResponse
        /// </returns>
        public async Task<GetHotlineServiceStatisticsResponse> GetHotlineServiceStatisticsAsync(GetHotlineServiceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineServiceStatisticsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetHotlineWaitingNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineWaitingNumberResponse
        /// </returns>
        public GetHotlineWaitingNumberResponse GetHotlineWaitingNumberWithOptions(GetHotlineWaitingNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineWaitingNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineWaitingNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHotlineWaitingNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineWaitingNumberResponse
        /// </returns>
        public async Task<GetHotlineWaitingNumberResponse> GetHotlineWaitingNumberWithOptionsAsync(GetHotlineWaitingNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineWaitingNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineWaitingNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHotlineWaitingNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineWaitingNumberResponse
        /// </returns>
        public GetHotlineWaitingNumberResponse GetHotlineWaitingNumber(GetHotlineWaitingNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineWaitingNumberWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetHotlineWaitingNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineWaitingNumberResponse
        /// </returns>
        public async Task<GetHotlineWaitingNumberResponse> GetHotlineWaitingNumberAsync(GetHotlineWaitingNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineWaitingNumberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetIndexCurrentValueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexCurrentValueResponse
        /// </returns>
        public GetIndexCurrentValueResponse GetIndexCurrentValueWithOptions(GetIndexCurrentValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepIds))
            {
                query["DepIds"] = request.DepIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexCurrentValue",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexCurrentValueResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetIndexCurrentValueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexCurrentValueResponse
        /// </returns>
        public async Task<GetIndexCurrentValueResponse> GetIndexCurrentValueWithOptionsAsync(GetIndexCurrentValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepIds))
            {
                query["DepIds"] = request.DepIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexCurrentValue",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexCurrentValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetIndexCurrentValueRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIndexCurrentValueResponse
        /// </returns>
        public GetIndexCurrentValueResponse GetIndexCurrentValue(GetIndexCurrentValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIndexCurrentValueWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetIndexCurrentValueRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIndexCurrentValueResponse
        /// </returns>
        public async Task<GetIndexCurrentValueResponse> GetIndexCurrentValueAsync(GetIndexCurrentValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIndexCurrentValueWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetInstanceListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceListResponse
        /// </returns>
        public GetInstanceListResponse GetInstanceListWithOptions(GetInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
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
                Action = "GetInstanceList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetInstanceListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceListResponse
        /// </returns>
        public async Task<GetInstanceListResponse> GetInstanceListWithOptionsAsync(GetInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
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
                Action = "GetInstanceList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetInstanceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceListResponse
        /// </returns>
        public GetInstanceListResponse GetInstanceList(GetInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetInstanceListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceListResponse
        /// </returns>
        public async Task<GetInstanceListResponse> GetInstanceListAsync(GetInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线检测获取mcu ip地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMcuLvsIpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcuLvsIpResponse
        /// </returns>
        public GetMcuLvsIpResponse GetMcuLvsIpWithOptions(GetMcuLvsIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcuLvsIp",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcuLvsIpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线检测获取mcu ip地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMcuLvsIpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcuLvsIpResponse
        /// </returns>
        public async Task<GetMcuLvsIpResponse> GetMcuLvsIpWithOptionsAsync(GetMcuLvsIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcuLvsIp",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcuLvsIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线检测获取mcu ip地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMcuLvsIpRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcuLvsIpResponse
        /// </returns>
        public GetMcuLvsIpResponse GetMcuLvsIp(GetMcuLvsIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMcuLvsIpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热线检测获取mcu ip地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMcuLvsIpRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcuLvsIpResponse
        /// </returns>
        public async Task<GetMcuLvsIpResponse> GetMcuLvsIpAsync(GetMcuLvsIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMcuLvsIpWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetNumLocationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNumLocationResponse
        /// </returns>
        public GetNumLocationResponse GetNumLocationWithOptions(GetNumLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNumLocation",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNumLocationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetNumLocationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNumLocationResponse
        /// </returns>
        public async Task<GetNumLocationResponse> GetNumLocationWithOptionsAsync(GetNumLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNumLocation",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNumLocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetNumLocationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNumLocationResponse
        /// </returns>
        public GetNumLocationResponse GetNumLocation(GetNumLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNumLocationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetNumLocationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNumLocationResponse
        /// </returns>
        public async Task<GetNumLocationResponse> GetNumLocationAsync(GetNumLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNumLocationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线坐席信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetOnlineSeatInformationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOnlineSeatInformationResponse
        /// </returns>
        public GetOnlineSeatInformationResponse GetOnlineSeatInformationWithOptions(GetOnlineSeatInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetOnlineSeatInformationShrinkRequest request = new GetOnlineSeatInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOnlineSeatInformation",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOnlineSeatInformationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线坐席信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetOnlineSeatInformationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOnlineSeatInformationResponse
        /// </returns>
        public async Task<GetOnlineSeatInformationResponse> GetOnlineSeatInformationWithOptionsAsync(GetOnlineSeatInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetOnlineSeatInformationShrinkRequest request = new GetOnlineSeatInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOnlineSeatInformation",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOnlineSeatInformationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线坐席信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOnlineSeatInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOnlineSeatInformationResponse
        /// </returns>
        public GetOnlineSeatInformationResponse GetOnlineSeatInformation(GetOnlineSeatInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOnlineSeatInformationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线坐席信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOnlineSeatInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOnlineSeatInformationResponse
        /// </returns>
        public async Task<GetOnlineSeatInformationResponse> GetOnlineSeatInformationAsync(GetOnlineSeatInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOnlineSeatInformationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线服务总量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetOnlineServiceVolumeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOnlineServiceVolumeResponse
        /// </returns>
        public GetOnlineServiceVolumeResponse GetOnlineServiceVolumeWithOptions(GetOnlineServiceVolumeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetOnlineServiceVolumeShrinkRequest request = new GetOnlineServiceVolumeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOnlineServiceVolume",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOnlineServiceVolumeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线服务总量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetOnlineServiceVolumeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOnlineServiceVolumeResponse
        /// </returns>
        public async Task<GetOnlineServiceVolumeResponse> GetOnlineServiceVolumeWithOptionsAsync(GetOnlineServiceVolumeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetOnlineServiceVolumeShrinkRequest request = new GetOnlineServiceVolumeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOnlineServiceVolume",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOnlineServiceVolumeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线服务总量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOnlineServiceVolumeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOnlineServiceVolumeResponse
        /// </returns>
        public GetOnlineServiceVolumeResponse GetOnlineServiceVolume(GetOnlineServiceVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOnlineServiceVolumeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线服务总量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOnlineServiceVolumeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOnlineServiceVolumeResponse
        /// </returns>
        public async Task<GetOnlineServiceVolumeResponse> GetOnlineServiceVolumeAsync(GetOnlineServiceVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOnlineServiceVolumeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetOutbounNumListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOutbounNumListResponse
        /// </returns>
        public GetOutbounNumListResponse GetOutbounNumListWithOptions(GetOutbounNumListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOutbounNumList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOutbounNumListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetOutbounNumListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOutbounNumListResponse
        /// </returns>
        public async Task<GetOutbounNumListResponse> GetOutbounNumListWithOptionsAsync(GetOutbounNumListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOutbounNumList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOutbounNumListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetOutbounNumListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOutbounNumListResponse
        /// </returns>
        public GetOutbounNumListResponse GetOutbounNumList(GetOutbounNumListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOutbounNumListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetOutbounNumListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOutbounNumListResponse
        /// </returns>
        public async Task<GetOutbounNumListResponse> GetOutbounNumListAsync(GetOutbounNumListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOutbounNumListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetQualityProjectDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectDetailResponse
        /// </returns>
        public GetQualityProjectDetailResponse GetQualityProjectDetailWithOptions(GetQualityProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetQualityProjectDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityProjectDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityProjectDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectDetailResponse
        /// </returns>
        public async Task<GetQualityProjectDetailResponse> GetQualityProjectDetailWithOptionsAsync(GetQualityProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetQualityProjectDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityProjectDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityProjectDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectDetailResponse
        /// </returns>
        public GetQualityProjectDetailResponse GetQualityProjectDetail(GetQualityProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityProjectDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetQualityProjectDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectDetailResponse
        /// </returns>
        public async Task<GetQualityProjectDetailResponse> GetQualityProjectDetailAsync(GetQualityProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityProjectDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetQualityProjectListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectListResponse
        /// </returns>
        public GetQualityProjectListResponse GetQualityProjectListWithOptions(GetQualityProjectListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckFreqType))
            {
                query["checkFreqType"] = request.CheckFreqType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityProjectList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityProjectListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityProjectListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectListResponse
        /// </returns>
        public async Task<GetQualityProjectListResponse> GetQualityProjectListWithOptionsAsync(GetQualityProjectListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckFreqType))
            {
                query["checkFreqType"] = request.CheckFreqType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityProjectList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityProjectListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityProjectListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectListResponse
        /// </returns>
        public GetQualityProjectListResponse GetQualityProjectList(GetQualityProjectListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityProjectListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetQualityProjectListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectListResponse
        /// </returns>
        public async Task<GetQualityProjectListResponse> GetQualityProjectListAsync(GetQualityProjectListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityProjectListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetQualityProjectLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectLogResponse
        /// </returns>
        public GetQualityProjectLogResponse GetQualityProjectLogWithOptions(GetQualityProjectLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetQualityProjectLog",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityProjectLogResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityProjectLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectLogResponse
        /// </returns>
        public async Task<GetQualityProjectLogResponse> GetQualityProjectLogWithOptionsAsync(GetQualityProjectLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetQualityProjectLog",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityProjectLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityProjectLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectLogResponse
        /// </returns>
        public GetQualityProjectLogResponse GetQualityProjectLog(GetQualityProjectLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityProjectLogWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetQualityProjectLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityProjectLogResponse
        /// </returns>
        public async Task<GetQualityProjectLogResponse> GetQualityProjectLogAsync(GetQualityProjectLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityProjectLogWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetQualityResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityResultResponse
        /// </returns>
        public GetQualityResultResponse GetQualityResultWithOptions(GetQualityResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HitStatus))
            {
                query["HitStatus"] = request.HitStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                query["ProjectIds"] = request.ProjectIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityRuleIds))
            {
                query["QualityRuleIds"] = request.QualityRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TouchEndTime))
            {
                query["TouchEndTime"] = request.TouchEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TouchStartTime))
            {
                query["TouchStartTime"] = request.TouchStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityResult",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityResultResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityResultResponse
        /// </returns>
        public async Task<GetQualityResultResponse> GetQualityResultWithOptionsAsync(GetQualityResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIds))
            {
                query["GroupIds"] = request.GroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HitStatus))
            {
                query["HitStatus"] = request.HitStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                query["ProjectIds"] = request.ProjectIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityRuleIds))
            {
                query["QualityRuleIds"] = request.QualityRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TouchEndTime))
            {
                query["TouchEndTime"] = request.TouchEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TouchStartTime))
            {
                query["TouchStartTime"] = request.TouchStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityResult",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityResultResponse
        /// </returns>
        public GetQualityResultResponse GetQualityResult(GetQualityResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityResultWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetQualityResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityResultResponse
        /// </returns>
        public async Task<GetQualityResultResponse> GetQualityResultAsync(GetQualityResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityResultWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetQualityRuleDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleDetailResponse
        /// </returns>
        public GetQualityRuleDetailResponse GetQualityRuleDetailWithOptions(GetQualityRuleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityRuleId))
            {
                query["QualityRuleId"] = request.QualityRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityRuleDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityRuleDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityRuleDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleDetailResponse
        /// </returns>
        public async Task<GetQualityRuleDetailResponse> GetQualityRuleDetailWithOptionsAsync(GetQualityRuleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityRuleId))
            {
                query["QualityRuleId"] = request.QualityRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityRuleDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityRuleDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityRuleDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleDetailResponse
        /// </returns>
        public GetQualityRuleDetailResponse GetQualityRuleDetail(GetQualityRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityRuleDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetQualityRuleDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleDetailResponse
        /// </returns>
        public async Task<GetQualityRuleDetailResponse> GetQualityRuleDetailAsync(GetQualityRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityRuleDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetQualityRuleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleListResponse
        /// </returns>
        public GetQualityRuleListResponse GetQualityRuleListWithOptions(GetQualityRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetQualityRuleList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityRuleListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityRuleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleListResponse
        /// </returns>
        public async Task<GetQualityRuleListResponse> GetQualityRuleListWithOptionsAsync(GetQualityRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetQualityRuleList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleListResponse
        /// </returns>
        public GetQualityRuleListResponse GetQualityRuleList(GetQualityRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityRuleListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetQualityRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleListResponse
        /// </returns>
        public async Task<GetQualityRuleListResponse> GetQualityRuleListAsync(GetQualityRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityRuleListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetQualityRuleTagListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleTagListResponse
        /// </returns>
        public GetQualityRuleTagListResponse GetQualityRuleTagListWithOptions(GetQualityRuleTagListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityRuleTagList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityRuleTagListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityRuleTagListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleTagListResponse
        /// </returns>
        public async Task<GetQualityRuleTagListResponse> GetQualityRuleTagListWithOptionsAsync(GetQualityRuleTagListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityRuleTagList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityRuleTagListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetQualityRuleTagListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleTagListResponse
        /// </returns>
        public GetQualityRuleTagListResponse GetQualityRuleTagList(GetQualityRuleTagListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityRuleTagListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetQualityRuleTagListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityRuleTagListResponse
        /// </returns>
        public async Task<GetQualityRuleTagListResponse> GetQualityRuleTagListAsync(GetQualityRuleTagListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityRuleTagListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度队列信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetQueueInformationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueueInformationResponse
        /// </returns>
        public GetQueueInformationResponse GetQueueInformationWithOptions(GetQueueInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetQueueInformationShrinkRequest request = new GetQueueInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueueInformation",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueInformationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度队列信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetQueueInformationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueueInformationResponse
        /// </returns>
        public async Task<GetQueueInformationResponse> GetQueueInformationWithOptionsAsync(GetQueueInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetQueueInformationShrinkRequest request = new GetQueueInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueueInformation",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueInformationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度队列信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueueInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueueInformationResponse
        /// </returns>
        public GetQueueInformationResponse GetQueueInformation(GetQueueInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueInformationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度队列信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueueInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueueInformationResponse
        /// </returns>
        public async Task<GetQueueInformationResponse> GetQueueInformationAsync(GetQueueInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueInformationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetRecordDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecordDataResponse
        /// </returns>
        public GetRecordDataResponse GetRecordDataWithOptions(GetRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acid))
            {
                query["Acid"] = request.Acid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecordData",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecordDataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRecordDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecordDataResponse
        /// </returns>
        public async Task<GetRecordDataResponse> GetRecordDataWithOptionsAsync(GetRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acid))
            {
                query["Acid"] = request.Acid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecordData",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecordDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRecordDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecordDataResponse
        /// </returns>
        public GetRecordDataResponse GetRecordData(GetRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRecordDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetRecordDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecordDataResponse
        /// </returns>
        public async Task<GetRecordDataResponse> GetRecordDataAsync(GetRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRecordDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取录音链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecordUrlResponse
        /// </returns>
        public GetRecordUrlResponse GetRecordUrlWithOptions(GetRecordUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecordUrl",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecordUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取录音链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecordUrlResponse
        /// </returns>
        public async Task<GetRecordUrlResponse> GetRecordUrlWithOptionsAsync(GetRecordUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRecordUrl",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecordUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取录音链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecordUrlResponse
        /// </returns>
        public GetRecordUrlResponse GetRecordUrl(GetRecordUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRecordUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取录音链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecordUrlResponse
        /// </returns>
        public async Task<GetRecordUrlResponse> GetRecordUrlAsync(GetRecordUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRecordUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RtcToken</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRtcTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRtcTokenResponse
        /// </returns>
        public GetRtcTokenResponse GetRtcTokenWithOptions(GetRtcTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRtcToken",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRtcTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RtcToken</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRtcTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRtcTokenResponse
        /// </returns>
        public async Task<GetRtcTokenResponse> GetRtcTokenWithOptionsAsync(GetRtcTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRtcToken",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRtcTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RtcToken</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRtcTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRtcTokenResponse
        /// </returns>
        public GetRtcTokenResponse GetRtcToken(GetRtcTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRtcTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RtcToken</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRtcTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRtcTokenResponse
        /// </returns>
        public async Task<GetRtcTokenResponse> GetRtcTokenAsync(GetRtcTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRtcTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部门纬度坐席信息数据</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSeatInformationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSeatInformationResponse
        /// </returns>
        public GetSeatInformationResponse GetSeatInformationWithOptions(GetSeatInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSeatInformationShrinkRequest request = new GetSeatInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "depIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSeatInformation",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSeatInformationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部门纬度坐席信息数据</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSeatInformationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSeatInformationResponse
        /// </returns>
        public async Task<GetSeatInformationResponse> GetSeatInformationWithOptionsAsync(GetSeatInformationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSeatInformationShrinkRequest request = new GetSeatInformationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "depIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSeatInformation",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSeatInformationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部门纬度坐席信息数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSeatInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSeatInformationResponse
        /// </returns>
        public GetSeatInformationResponse GetSeatInformation(GetSeatInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSeatInformationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>部门纬度坐席信息数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSeatInformationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSeatInformationResponse
        /// </returns>
        public async Task<GetSeatInformationResponse> GetSeatInformationAsync(GetSeatInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSeatInformationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组坐席状态详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupAgentStatusDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupAgentStatusDetailsResponse
        /// </returns>
        public GetSkillGroupAgentStatusDetailsResponse GetSkillGroupAgentStatusDetailsWithOptions(GetSkillGroupAgentStatusDetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupAgentStatusDetailsShrinkRequest request = new GetSkillGroupAgentStatusDetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupAgentStatusDetails",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupAgentStatusDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组坐席状态详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupAgentStatusDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupAgentStatusDetailsResponse
        /// </returns>
        public async Task<GetSkillGroupAgentStatusDetailsResponse> GetSkillGroupAgentStatusDetailsWithOptionsAsync(GetSkillGroupAgentStatusDetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupAgentStatusDetailsShrinkRequest request = new GetSkillGroupAgentStatusDetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupAgentStatusDetails",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupAgentStatusDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组坐席状态详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupAgentStatusDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupAgentStatusDetailsResponse
        /// </returns>
        public GetSkillGroupAgentStatusDetailsResponse GetSkillGroupAgentStatusDetails(GetSkillGroupAgentStatusDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupAgentStatusDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组坐席状态详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupAgentStatusDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupAgentStatusDetailsResponse
        /// </returns>
        public async Task<GetSkillGroupAgentStatusDetailsResponse> GetSkillGroupAgentStatusDetailsAsync(GetSkillGroupAgentStatusDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupAgentStatusDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组坐席汇总状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupAndAgentStatusSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupAndAgentStatusSummaryResponse
        /// </returns>
        public GetSkillGroupAndAgentStatusSummaryResponse GetSkillGroupAndAgentStatusSummaryWithOptions(GetSkillGroupAndAgentStatusSummaryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupAndAgentStatusSummaryShrinkRequest request = new GetSkillGroupAndAgentStatusSummaryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupAndAgentStatusSummary",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupAndAgentStatusSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组坐席汇总状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupAndAgentStatusSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupAndAgentStatusSummaryResponse
        /// </returns>
        public async Task<GetSkillGroupAndAgentStatusSummaryResponse> GetSkillGroupAndAgentStatusSummaryWithOptionsAsync(GetSkillGroupAndAgentStatusSummaryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupAndAgentStatusSummaryShrinkRequest request = new GetSkillGroupAndAgentStatusSummaryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupAndAgentStatusSummary",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupAndAgentStatusSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组坐席汇总状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupAndAgentStatusSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupAndAgentStatusSummaryResponse
        /// </returns>
        public GetSkillGroupAndAgentStatusSummaryResponse GetSkillGroupAndAgentStatusSummary(GetSkillGroupAndAgentStatusSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupAndAgentStatusSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组坐席汇总状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupAndAgentStatusSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupAndAgentStatusSummaryResponse
        /// </returns>
        public async Task<GetSkillGroupAndAgentStatusSummaryResponse> GetSkillGroupAndAgentStatusSummaryAsync(GetSkillGroupAndAgentStatusSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupAndAgentStatusSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupLatitudeStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupLatitudeStateResponse
        /// </returns>
        public GetSkillGroupLatitudeStateResponse GetSkillGroupLatitudeStateWithOptions(GetSkillGroupLatitudeStateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupLatitudeStateShrinkRequest request = new GetSkillGroupLatitudeStateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupLatitudeState",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupLatitudeStateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupLatitudeStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupLatitudeStateResponse
        /// </returns>
        public async Task<GetSkillGroupLatitudeStateResponse> GetSkillGroupLatitudeStateWithOptionsAsync(GetSkillGroupLatitudeStateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupLatitudeStateShrinkRequest request = new GetSkillGroupLatitudeStateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupLatitudeState",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupLatitudeStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupLatitudeStateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupLatitudeStateResponse
        /// </returns>
        public GetSkillGroupLatitudeStateResponse GetSkillGroupLatitudeState(GetSkillGroupLatitudeStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupLatitudeStateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupLatitudeStateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupLatitudeStateResponse
        /// </returns>
        public async Task<GetSkillGroupLatitudeStateResponse> GetSkillGroupLatitudeStateAsync(GetSkillGroupLatitudeStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupLatitudeStateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度服务能力</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupServiceCapabilityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupServiceCapabilityResponse
        /// </returns>
        public GetSkillGroupServiceCapabilityResponse GetSkillGroupServiceCapabilityWithOptions(GetSkillGroupServiceCapabilityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupServiceCapabilityShrinkRequest request = new GetSkillGroupServiceCapabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupServiceCapability",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupServiceCapabilityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度服务能力</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupServiceCapabilityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupServiceCapabilityResponse
        /// </returns>
        public async Task<GetSkillGroupServiceCapabilityResponse> GetSkillGroupServiceCapabilityWithOptionsAsync(GetSkillGroupServiceCapabilityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupServiceCapabilityShrinkRequest request = new GetSkillGroupServiceCapabilityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupServiceCapability",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupServiceCapabilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度服务能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupServiceCapabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupServiceCapabilityResponse
        /// </returns>
        public GetSkillGroupServiceCapabilityResponse GetSkillGroupServiceCapability(GetSkillGroupServiceCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupServiceCapabilityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组纬度服务能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupServiceCapabilityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupServiceCapabilityResponse
        /// </returns>
        public async Task<GetSkillGroupServiceCapabilityResponse> GetSkillGroupServiceCapabilityAsync(GetSkillGroupServiceCapabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupServiceCapabilityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组服务状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupServiceStatusResponse
        /// </returns>
        public GetSkillGroupServiceStatusResponse GetSkillGroupServiceStatusWithOptions(GetSkillGroupServiceStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupServiceStatusShrinkRequest request = new GetSkillGroupServiceStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupServiceStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组服务状态量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupServiceStatusResponse
        /// </returns>
        public async Task<GetSkillGroupServiceStatusResponse> GetSkillGroupServiceStatusWithOptionsAsync(GetSkillGroupServiceStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupServiceStatusShrinkRequest request = new GetSkillGroupServiceStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupServiceStatus",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组服务状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupServiceStatusResponse
        /// </returns>
        public GetSkillGroupServiceStatusResponse GetSkillGroupServiceStatus(GetSkillGroupServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupServiceStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组服务状态量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupServiceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupServiceStatusResponse
        /// </returns>
        public async Task<GetSkillGroupServiceStatusResponse> GetSkillGroupServiceStatusAsync(GetSkillGroupServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupServiceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组状态总量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupStatusTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupStatusTotalResponse
        /// </returns>
        public GetSkillGroupStatusTotalResponse GetSkillGroupStatusTotalWithOptions(GetSkillGroupStatusTotalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupStatusTotalShrinkRequest request = new GetSkillGroupStatusTotalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupStatusTotal",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupStatusTotalResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组状态总量</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSkillGroupStatusTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupStatusTotalResponse
        /// </returns>
        public async Task<GetSkillGroupStatusTotalResponse> GetSkillGroupStatusTotalWithOptionsAsync(GetSkillGroupStatusTotalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSkillGroupStatusTotalShrinkRequest request = new GetSkillGroupStatusTotalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DepIds))
            {
                request.DepIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DepIds, "DepIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupStatusTotal",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupStatusTotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组状态总量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupStatusTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupStatusTotalResponse
        /// </returns>
        public GetSkillGroupStatusTotalResponse GetSkillGroupStatusTotal(GetSkillGroupStatusTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupStatusTotalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>技能组状态总量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillGroupStatusTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupStatusTotalResponse
        /// </returns>
        public async Task<GetSkillGroupStatusTotalResponse> GetSkillGroupStatusTotalAsync(GetSkillGroupStatusTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupStatusTotalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动端呼叫挂断</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HangUpDoubleCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HangUpDoubleCallResponse
        /// </returns>
        public HangUpDoubleCallResponse HangUpDoubleCallWithOptions(HangUpDoubleCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acid))
            {
                query["Acid"] = request.Acid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HangUpDoubleCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HangUpDoubleCallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动端呼叫挂断</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HangUpDoubleCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HangUpDoubleCallResponse
        /// </returns>
        public async Task<HangUpDoubleCallResponse> HangUpDoubleCallWithOptionsAsync(HangUpDoubleCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acid))
            {
                query["Acid"] = request.Acid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HangUpDoubleCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HangUpDoubleCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动端呼叫挂断</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HangUpDoubleCallRequest
        /// </param>
        /// 
        /// <returns>
        /// HangUpDoubleCallResponse
        /// </returns>
        public HangUpDoubleCallResponse HangUpDoubleCall(HangUpDoubleCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HangUpDoubleCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动端呼叫挂断</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HangUpDoubleCallRequest
        /// </param>
        /// 
        /// <returns>
        /// HangUpDoubleCallResponse
        /// </returns>
        public async Task<HangUpDoubleCallResponse> HangUpDoubleCallAsync(HangUpDoubleCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HangUpDoubleCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// HangupCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HangupCallResponse
        /// </returns>
        public HangupCallResponse HangupCallWithOptions(HangupCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "HangupCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HangupCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// HangupCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HangupCallResponse
        /// </returns>
        public async Task<HangupCallResponse> HangupCallWithOptionsAsync(HangupCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "HangupCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HangupCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// HangupCallRequest
        /// </param>
        /// 
        /// <returns>
        /// HangupCallResponse
        /// </returns>
        public HangupCallResponse HangupCall(HangupCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HangupCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// HangupCallRequest
        /// </param>
        /// 
        /// <returns>
        /// HangupCallResponse
        /// </returns>
        public async Task<HangupCallResponse> HangupCallAsync(HangupCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HangupCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通信智能引擎中主动挂断通话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HangupOperateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HangupOperateResponse
        /// </returns>
        public HangupOperateResponse HangupOperateWithOptions(HangupOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateHangup))
            {
                query["ImmediateHangup"] = request.ImmediateHangup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HangupOperate",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HangupOperateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通信智能引擎中主动挂断通话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HangupOperateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HangupOperateResponse
        /// </returns>
        public async Task<HangupOperateResponse> HangupOperateWithOptionsAsync(HangupOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateHangup))
            {
                query["ImmediateHangup"] = request.ImmediateHangup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HangupOperate",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HangupOperateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通信智能引擎中主动挂断通话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HangupOperateRequest
        /// </param>
        /// 
        /// <returns>
        /// HangupOperateResponse
        /// </returns>
        public HangupOperateResponse HangupOperate(HangupOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HangupOperateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通信智能引擎中主动挂断通话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HangupOperateRequest
        /// </param>
        /// 
        /// <returns>
        /// HangupOperateResponse
        /// </returns>
        public async Task<HangupOperateResponse> HangupOperateAsync(HangupOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HangupOperateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// HangupThirdCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HangupThirdCallResponse
        /// </returns>
        public HangupThirdCallResponse HangupThirdCallWithOptions(HangupThirdCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "HangupThirdCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HangupThirdCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// HangupThirdCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HangupThirdCallResponse
        /// </returns>
        public async Task<HangupThirdCallResponse> HangupThirdCallWithOptionsAsync(HangupThirdCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "HangupThirdCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HangupThirdCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// HangupThirdCallRequest
        /// </param>
        /// 
        /// <returns>
        /// HangupThirdCallResponse
        /// </returns>
        public HangupThirdCallResponse HangupThirdCall(HangupThirdCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HangupThirdCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// HangupThirdCallRequest
        /// </param>
        /// 
        /// <returns>
        /// HangupThirdCallResponse
        /// </returns>
        public async Task<HangupThirdCallResponse> HangupThirdCallAsync(HangupThirdCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HangupThirdCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// HoldCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HoldCallResponse
        /// </returns>
        public HoldCallResponse HoldCallWithOptions(HoldCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "HoldCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HoldCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// HoldCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HoldCallResponse
        /// </returns>
        public async Task<HoldCallResponse> HoldCallWithOptionsAsync(HoldCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "HoldCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HoldCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// HoldCallRequest
        /// </param>
        /// 
        /// <returns>
        /// HoldCallResponse
        /// </returns>
        public HoldCallResponse HoldCall(HoldCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HoldCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// HoldCallRequest
        /// </param>
        /// 
        /// <returns>
        /// HoldCallResponse
        /// </returns>
        public async Task<HoldCallResponse> HoldCallAsync(HoldCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HoldCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// HotlineSessionQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HotlineSessionQueryResponse
        /// </returns>
        public HotlineSessionQueryResponse HotlineSessionQueryWithOptions(HotlineSessionQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acid))
            {
                query["Acid"] = request.Acid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcidList))
            {
                query["AcidList"] = request.AcidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallResult))
            {
                query["CallResult"] = request.CallResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallResultList))
            {
                query["CallResultList"] = request.CallResultList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallType))
            {
                query["CallType"] = request.CallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTypeList))
            {
                query["CallTypeList"] = request.CallTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumberList))
            {
                query["CalledNumberList"] = request.CalledNumberList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumberList))
            {
                query["CallingNumberList"] = request.CallingNumberList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdList))
            {
                query["GroupIdList"] = request.GroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberIdList))
            {
                query["MemberIdList"] = request.MemberIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryEndTime))
            {
                query["QueryEndTime"] = request.QueryEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryStartTime))
            {
                query["QueryStartTime"] = request.QueryStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerId))
            {
                query["ServicerId"] = request.ServicerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerIdList))
            {
                query["ServicerIdList"] = request.ServicerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerName))
            {
                query["ServicerName"] = request.ServicerName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotlineSessionQuery",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotlineSessionQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// HotlineSessionQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HotlineSessionQueryResponse
        /// </returns>
        public async Task<HotlineSessionQueryResponse> HotlineSessionQueryWithOptionsAsync(HotlineSessionQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acid))
            {
                query["Acid"] = request.Acid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcidList))
            {
                query["AcidList"] = request.AcidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallResult))
            {
                query["CallResult"] = request.CallResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallResultList))
            {
                query["CallResultList"] = request.CallResultList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallType))
            {
                query["CallType"] = request.CallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallTypeList))
            {
                query["CallTypeList"] = request.CallTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumberList))
            {
                query["CalledNumberList"] = request.CalledNumberList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumberList))
            {
                query["CallingNumberList"] = request.CallingNumberList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdList))
            {
                query["GroupIdList"] = request.GroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberIdList))
            {
                query["MemberIdList"] = request.MemberIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryEndTime))
            {
                query["QueryEndTime"] = request.QueryEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryStartTime))
            {
                query["QueryStartTime"] = request.QueryStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerId))
            {
                query["ServicerId"] = request.ServicerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerIdList))
            {
                query["ServicerIdList"] = request.ServicerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerName))
            {
                query["ServicerName"] = request.ServicerName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotlineSessionQuery",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotlineSessionQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// HotlineSessionQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// HotlineSessionQueryResponse
        /// </returns>
        public HotlineSessionQueryResponse HotlineSessionQuery(HotlineSessionQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HotlineSessionQueryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// HotlineSessionQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// HotlineSessionQueryResponse
        /// </returns>
        public async Task<HotlineSessionQueryResponse> HotlineSessionQueryAsync(HotlineSessionQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HotlineSessionQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务导入号码</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InsertAiOutboundPhoneNumsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertAiOutboundPhoneNumsResponse
        /// </returns>
        public InsertAiOutboundPhoneNumsResponse InsertAiOutboundPhoneNumsWithOptions(InsertAiOutboundPhoneNumsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertAiOutboundPhoneNumsShrinkRequest request = new InsertAiOutboundPhoneNumsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Details))
            {
                request.DetailsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Details, "Details", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchVersion))
            {
                query["BatchVersion"] = request.BatchVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailsShrink))
            {
                query["Details"] = request.DetailsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "InsertAiOutboundPhoneNums",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertAiOutboundPhoneNumsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务导入号码</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InsertAiOutboundPhoneNumsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertAiOutboundPhoneNumsResponse
        /// </returns>
        public async Task<InsertAiOutboundPhoneNumsResponse> InsertAiOutboundPhoneNumsWithOptionsAsync(InsertAiOutboundPhoneNumsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertAiOutboundPhoneNumsShrinkRequest request = new InsertAiOutboundPhoneNumsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Details))
            {
                request.DetailsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Details, "Details", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchVersion))
            {
                query["BatchVersion"] = request.BatchVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailsShrink))
            {
                query["Details"] = request.DetailsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "InsertAiOutboundPhoneNums",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertAiOutboundPhoneNumsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务导入号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertAiOutboundPhoneNumsRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertAiOutboundPhoneNumsResponse
        /// </returns>
        public InsertAiOutboundPhoneNumsResponse InsertAiOutboundPhoneNums(InsertAiOutboundPhoneNumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertAiOutboundPhoneNumsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能外呼任务导入号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertAiOutboundPhoneNumsRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertAiOutboundPhoneNumsResponse
        /// </returns>
        public async Task<InsertAiOutboundPhoneNumsResponse> InsertAiOutboundPhoneNumsAsync(InsertAiOutboundPhoneNumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertAiOutboundPhoneNumsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// InsertTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertTaskDetailResponse
        /// </returns>
        public InsertTaskDetailResponse InsertTaskDetailWithOptions(InsertTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallInfos))
            {
                query["CallInfos"] = request.CallInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTaskId))
            {
                query["OutboundTaskId"] = request.OutboundTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertTaskDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// InsertTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertTaskDetailResponse
        /// </returns>
        public async Task<InsertTaskDetailResponse> InsertTaskDetailWithOptionsAsync(InsertTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallInfos))
            {
                query["CallInfos"] = request.CallInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTaskId))
            {
                query["OutboundTaskId"] = request.OutboundTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertTaskDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// InsertTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertTaskDetailResponse
        /// </returns>
        public InsertTaskDetailResponse InsertTaskDetail(InsertTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertTaskDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// InsertTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertTaskDetailResponse
        /// </returns>
        public async Task<InsertTaskDetailResponse> InsertTaskDetailAsync(InsertTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertTaskDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// JoinThirdCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JoinThirdCallResponse
        /// </returns>
        public JoinThirdCallResponse JoinThirdCallWithOptions(JoinThirdCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldConnectionId))
            {
                body["HoldConnectionId"] = request.HoldConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "JoinThirdCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinThirdCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// JoinThirdCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// JoinThirdCallResponse
        /// </returns>
        public async Task<JoinThirdCallResponse> JoinThirdCallWithOptionsAsync(JoinThirdCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldConnectionId))
            {
                body["HoldConnectionId"] = request.HoldConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "JoinThirdCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinThirdCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// JoinThirdCallRequest
        /// </param>
        /// 
        /// <returns>
        /// JoinThirdCallResponse
        /// </returns>
        public JoinThirdCallResponse JoinThirdCall(JoinThirdCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinThirdCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// JoinThirdCallRequest
        /// </param>
        /// 
        /// <returns>
        /// JoinThirdCallResponse
        /// </returns>
        public async Task<JoinThirdCallResponse> JoinThirdCallAsync(JoinThirdCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinThirdCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAgentBySkillGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentBySkillGroupIdResponse
        /// </returns>
        public ListAgentBySkillGroupIdResponse ListAgentBySkillGroupIdWithOptions(ListAgentBySkillGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentBySkillGroupId",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentBySkillGroupIdResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAgentBySkillGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentBySkillGroupIdResponse
        /// </returns>
        public async Task<ListAgentBySkillGroupIdResponse> ListAgentBySkillGroupIdWithOptionsAsync(ListAgentBySkillGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentBySkillGroupId",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentBySkillGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAgentBySkillGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentBySkillGroupIdResponse
        /// </returns>
        public ListAgentBySkillGroupIdResponse ListAgentBySkillGroupId(ListAgentBySkillGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentBySkillGroupIdWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAgentBySkillGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentBySkillGroupIdResponse
        /// </returns>
        public async Task<ListAgentBySkillGroupIdResponse> ListAgentBySkillGroupIdAsync(ListAgentBySkillGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentBySkillGroupIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有机器人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAiccsRobotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAiccsRobotResponse
        /// </returns>
        public ListAiccsRobotResponse ListAiccsRobotWithOptions(ListAiccsRobotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotName))
            {
                query["RobotName"] = request.RobotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAiccsRobot",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAiccsRobotResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有机器人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAiccsRobotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAiccsRobotResponse
        /// </returns>
        public async Task<ListAiccsRobotResponse> ListAiccsRobotWithOptionsAsync(ListAiccsRobotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotName))
            {
                query["RobotName"] = request.RobotName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAiccsRobot",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAiccsRobotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有机器人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAiccsRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAiccsRobotResponse
        /// </returns>
        public ListAiccsRobotResponse ListAiccsRobot(ListAiccsRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAiccsRobotWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有机器人列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAiccsRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAiccsRobotResponse
        /// </returns>
        public async Task<ListAiccsRobotResponse> ListAiccsRobotAsync(ListAiccsRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAiccsRobotWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据时间段查询在线会话详情，包含会话内容，时间段范围最长不超过1天</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChatRecordDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatRecordDetailResponse
        /// </returns>
        public ListChatRecordDetailResponse ListChatRecordDetailWithOptions(ListChatRecordDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatRecordDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatRecordDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据时间段查询在线会话详情，包含会话内容，时间段范围最长不超过1天</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChatRecordDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatRecordDetailResponse
        /// </returns>
        public async Task<ListChatRecordDetailResponse> ListChatRecordDetailWithOptionsAsync(ListChatRecordDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatRecordDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatRecordDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据时间段查询在线会话详情，包含会话内容，时间段范围最长不超过1天</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChatRecordDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatRecordDetailResponse
        /// </returns>
        public ListChatRecordDetailResponse ListChatRecordDetail(ListChatRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChatRecordDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据时间段查询在线会话详情，包含会话内容，时间段范围最长不超过1天</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChatRecordDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatRecordDetailResponse
        /// </returns>
        public async Task<ListChatRecordDetailResponse> ListChatRecordDetailAsync(ListChatRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChatRecordDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看对话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDialogResponse
        /// </returns>
        public ListDialogResponse ListDialogWithOptions(ListDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Called))
            {
                query["Called"] = request.Called;
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
                Action = "ListDialog",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDialogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看对话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDialogResponse
        /// </returns>
        public async Task<ListDialogResponse> ListDialogWithOptionsAsync(ListDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Called))
            {
                query["Called"] = request.Called;
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
                Action = "ListDialog",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDialogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看对话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDialogResponse
        /// </returns>
        public ListDialogResponse ListDialog(ListDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDialogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看对话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDialogResponse
        /// </returns>
        public async Task<ListDialogResponse> ListDialogAsync(ListDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDialogWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListHotlineRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineRecordResponse
        /// </returns>
        public ListHotlineRecordResponse ListHotlineRecordWithOptions(ListHotlineRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotlineRecord",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotlineRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListHotlineRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineRecordResponse
        /// </returns>
        public async Task<ListHotlineRecordResponse> ListHotlineRecordWithOptionsAsync(ListHotlineRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotlineRecord",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotlineRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListHotlineRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineRecordResponse
        /// </returns>
        public ListHotlineRecordResponse ListHotlineRecord(ListHotlineRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotlineRecordWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListHotlineRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineRecordResponse
        /// </returns>
        public async Task<ListHotlineRecordResponse> ListHotlineRecordAsync(ListHotlineRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotlineRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据时间段查询热线详情列表，包含热线通话信息，时间段范围最长不超过1天</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotlineRecordDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineRecordDetailResponse
        /// </returns>
        public ListHotlineRecordDetailResponse ListHotlineRecordDetailWithOptions(ListHotlineRecordDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotlineRecordDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotlineRecordDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据时间段查询热线详情列表，包含热线通话信息，时间段范围最长不超过1天</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotlineRecordDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineRecordDetailResponse
        /// </returns>
        public async Task<ListHotlineRecordDetailResponse> ListHotlineRecordDetailWithOptionsAsync(ListHotlineRecordDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotlineRecordDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotlineRecordDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据时间段查询热线详情列表，包含热线通话信息，时间段范围最长不超过1天</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotlineRecordDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineRecordDetailResponse
        /// </returns>
        public ListHotlineRecordDetailResponse ListHotlineRecordDetail(ListHotlineRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotlineRecordDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据时间段查询热线详情列表，包含热线通话信息，时间段范围最长不超过1天</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotlineRecordDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineRecordDetailResponse
        /// </returns>
        public async Task<ListHotlineRecordDetailResponse> ListHotlineRecordDetailAsync(ListHotlineRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotlineRecordDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListOutboundPhoneNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundPhoneNumberResponse
        /// </returns>
        public ListOutboundPhoneNumberResponse ListOutboundPhoneNumberWithOptions(ListOutboundPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOutboundPhoneNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOutboundPhoneNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListOutboundPhoneNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundPhoneNumberResponse
        /// </returns>
        public async Task<ListOutboundPhoneNumberResponse> ListOutboundPhoneNumberWithOptionsAsync(ListOutboundPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOutboundPhoneNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOutboundPhoneNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListOutboundPhoneNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundPhoneNumberResponse
        /// </returns>
        public ListOutboundPhoneNumberResponse ListOutboundPhoneNumber(ListOutboundPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOutboundPhoneNumberWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListOutboundPhoneNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOutboundPhoneNumberResponse
        /// </returns>
        public async Task<ListOutboundPhoneNumberResponse> ListOutboundPhoneNumberAsync(ListOutboundPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOutboundPhoneNumberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看对话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotCallDialogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRobotCallDialogResponse
        /// </returns>
        public ListRobotCallDialogResponse ListRobotCallDialogWithOptions(ListRobotCallDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
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
                Action = "ListRobotCallDialog",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRobotCallDialogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看对话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotCallDialogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRobotCallDialogResponse
        /// </returns>
        public async Task<ListRobotCallDialogResponse> ListRobotCallDialogWithOptionsAsync(ListRobotCallDialogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
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
                Action = "ListRobotCallDialog",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRobotCallDialogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看对话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotCallDialogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRobotCallDialogResponse
        /// </returns>
        public ListRobotCallDialogResponse ListRobotCallDialog(ListRobotCallDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRobotCallDialogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看对话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotCallDialogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRobotCallDialogResponse
        /// </returns>
        public async Task<ListRobotCallDialogResponse> ListRobotCallDialogAsync(ListRobotCallDialogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRobotCallDialogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询机器人输出列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRobotNodeResponse
        /// </returns>
        public ListRobotNodeResponse ListRobotNodeWithOptions(ListRobotNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotId))
            {
                query["RobotId"] = request.RobotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRobotNode",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRobotNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询机器人输出列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRobotNodeResponse
        /// </returns>
        public async Task<ListRobotNodeResponse> ListRobotNodeWithOptionsAsync(ListRobotNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotId))
            {
                query["RobotId"] = request.RobotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRobotNode",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRobotNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询机器人输出列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRobotNodeResponse
        /// </returns>
        public ListRobotNodeResponse ListRobotNode(ListRobotNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRobotNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询机器人输出列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRobotNodeResponse
        /// </returns>
        public async Task<ListRobotNodeResponse> ListRobotNodeAsync(ListRobotNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRobotNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询参数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotParamsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRobotParamsResponse
        /// </returns>
        public ListRobotParamsResponse ListRobotParamsWithOptions(ListRobotParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotId))
            {
                query["RobotId"] = request.RobotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRobotParams",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRobotParamsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询参数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotParamsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRobotParamsResponse
        /// </returns>
        public async Task<ListRobotParamsResponse> ListRobotParamsWithOptionsAsync(ListRobotParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotId))
            {
                query["RobotId"] = request.RobotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRobotParams",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRobotParamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询参数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotParamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRobotParamsResponse
        /// </returns>
        public ListRobotParamsResponse ListRobotParams(ListRobotParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRobotParamsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询参数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRobotParamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRobotParamsResponse
        /// </returns>
        public async Task<ListRobotParamsResponse> ListRobotParamsAsync(ListRobotParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRobotParamsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取租户下的所有角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取租户下的所有角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取租户下的所有角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRolesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取租户下的所有角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public async Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRolesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillGroupResponse
        /// </returns>
        public ListSkillGroupResponse ListSkillGroupWithOptions(ListSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillGroupResponse
        /// </returns>
        public async Task<ListSkillGroupResponse> ListSkillGroupWithOptionsAsync(ListSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillGroupResponse
        /// </returns>
        public ListSkillGroupResponse ListSkillGroup(ListSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillGroupResponse
        /// </returns>
        public async Task<ListSkillGroupResponse> ListSkillGroupAsync(ListSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTaskResponse
        /// </returns>
        public ListTaskResponse ListTaskWithOptions(ListTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotName))
            {
                query["RobotName"] = request.RobotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTaskResponse
        /// </returns>
        public async Task<ListTaskResponse> ListTaskWithOptionsAsync(ListTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotName))
            {
                query["RobotName"] = request.RobotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTaskResponse
        /// </returns>
        public ListTaskResponse ListTask(ListTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTaskResponse
        /// </returns>
        public async Task<ListTaskResponse> ListTaskAsync(ListTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务详情查看通话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTaskDetailResponse
        /// </returns>
        public ListTaskDetailResponse ListTaskDetailWithOptions(ListTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Called))
            {
                query["Called"] = request.Called;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusCode))
            {
                query["StatusCode"] = request.StatusCode;
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
                Action = "ListTaskDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务详情查看通话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTaskDetailResponse
        /// </returns>
        public async Task<ListTaskDetailResponse> ListTaskDetailWithOptionsAsync(ListTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Called))
            {
                query["Called"] = request.Called;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusCode))
            {
                query["StatusCode"] = request.StatusCode;
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
                Action = "ListTaskDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务详情查看通话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTaskDetailResponse
        /// </returns>
        public ListTaskDetailResponse ListTaskDetail(ListTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务详情查看通话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTaskDetailResponse
        /// </returns>
        public async Task<ListTaskDetailResponse> ListTaskDetailAsync(ListTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于大模型的智能外呼</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// LlmSmartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LlmSmartCallResponse
        /// </returns>
        public LlmSmartCallResponse LlmSmartCallWithOptions(LlmSmartCallRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            LlmSmartCallShrinkRequest request = new LlmSmartCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BizParam))
            {
                request.BizParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BizParam, "BizParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptParam))
            {
                request.PromptParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptParam, "PromptParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartWordParam))
            {
                request.StartWordParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartWordParam, "StartWordParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationCode))
            {
                query["ApplicationCode"] = request.ApplicationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizParamShrink))
            {
                query["BizParam"] = request.BizParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerNumber))
            {
                query["CallerNumber"] = request.CallerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                query["Extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptParamShrink))
            {
                query["PromptParam"] = request.PromptParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartWordParamShrink))
            {
                query["StartWordParam"] = request.StartWordParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsSpeed))
            {
                query["TtsSpeed"] = request.TtsSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVoiceCode))
            {
                query["TtsVoiceCode"] = request.TtsVoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVolume))
            {
                query["TtsVolume"] = request.TtsVolume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LlmSmartCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LlmSmartCallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于大模型的智能外呼</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// LlmSmartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LlmSmartCallResponse
        /// </returns>
        public async Task<LlmSmartCallResponse> LlmSmartCallWithOptionsAsync(LlmSmartCallRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            LlmSmartCallShrinkRequest request = new LlmSmartCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BizParam))
            {
                request.BizParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BizParam, "BizParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptParam))
            {
                request.PromptParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptParam, "PromptParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartWordParam))
            {
                request.StartWordParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartWordParam, "StartWordParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationCode))
            {
                query["ApplicationCode"] = request.ApplicationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizParamShrink))
            {
                query["BizParam"] = request.BizParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerNumber))
            {
                query["CallerNumber"] = request.CallerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                query["Extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptParamShrink))
            {
                query["PromptParam"] = request.PromptParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartWordParamShrink))
            {
                query["StartWordParam"] = request.StartWordParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsSpeed))
            {
                query["TtsSpeed"] = request.TtsSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVoiceCode))
            {
                query["TtsVoiceCode"] = request.TtsVoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVolume))
            {
                query["TtsVolume"] = request.TtsVolume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LlmSmartCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LlmSmartCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于大模型的智能外呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LlmSmartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// LlmSmartCallResponse
        /// </returns>
        public LlmSmartCallResponse LlmSmartCall(LlmSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LlmSmartCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于大模型的智能外呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LlmSmartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// LlmSmartCallResponse
        /// </returns>
        public async Task<LlmSmartCallResponse> LlmSmartCallAsync(LlmSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LlmSmartCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>大模型外呼加密号码接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// LlmSmartCallEncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LlmSmartCallEncryptResponse
        /// </returns>
        public LlmSmartCallEncryptResponse LlmSmartCallEncryptWithOptions(LlmSmartCallEncryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            LlmSmartCallEncryptShrinkRequest request = new LlmSmartCallEncryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptParam))
            {
                request.PromptParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptParam, "PromptParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartWordParam))
            {
                request.StartWordParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartWordParam, "StartWordParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationCode))
            {
                query["ApplicationCode"] = request.ApplicationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerNumber))
            {
                query["CallerNumber"] = request.CallerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptCalledNumber))
            {
                query["EncryptCalledNumber"] = request.EncryptCalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptParamShrink))
            {
                query["PromptParam"] = request.PromptParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartWordParamShrink))
            {
                query["StartWordParam"] = request.StartWordParamShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LlmSmartCallEncrypt",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LlmSmartCallEncryptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>大模型外呼加密号码接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// LlmSmartCallEncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LlmSmartCallEncryptResponse
        /// </returns>
        public async Task<LlmSmartCallEncryptResponse> LlmSmartCallEncryptWithOptionsAsync(LlmSmartCallEncryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            LlmSmartCallEncryptShrinkRequest request = new LlmSmartCallEncryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PromptParam))
            {
                request.PromptParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PromptParam, "PromptParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartWordParam))
            {
                request.StartWordParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartWordParam, "StartWordParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationCode))
            {
                query["ApplicationCode"] = request.ApplicationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerNumber))
            {
                query["CallerNumber"] = request.CallerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptCalledNumber))
            {
                query["EncryptCalledNumber"] = request.EncryptCalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptParamShrink))
            {
                query["PromptParam"] = request.PromptParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartWordParamShrink))
            {
                query["StartWordParam"] = request.StartWordParamShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LlmSmartCallEncrypt",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LlmSmartCallEncryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>大模型外呼加密号码接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LlmSmartCallEncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// LlmSmartCallEncryptResponse
        /// </returns>
        public LlmSmartCallEncryptResponse LlmSmartCallEncrypt(LlmSmartCallEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LlmSmartCallEncryptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>大模型外呼加密号码接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LlmSmartCallEncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// LlmSmartCallEncryptResponse
        /// </returns>
        public async Task<LlmSmartCallEncryptResponse> LlmSmartCallEncryptAsync(LlmSmartCallEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LlmSmartCallEncryptWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// MakeCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MakeCallResponse
        /// </returns>
        public MakeCallResponse MakeCallWithOptions(MakeCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandCode))
            {
                query["CommandCode"] = request.CommandCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterAccountId))
            {
                query["OuterAccountId"] = request.OuterAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterAccountType))
            {
                query["OuterAccountType"] = request.OuterAccountType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MakeCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MakeCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// MakeCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MakeCallResponse
        /// </returns>
        public async Task<MakeCallResponse> MakeCallWithOptionsAsync(MakeCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandCode))
            {
                query["CommandCode"] = request.CommandCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterAccountId))
            {
                query["OuterAccountId"] = request.OuterAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterAccountType))
            {
                query["OuterAccountType"] = request.OuterAccountType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MakeCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MakeCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// MakeCallRequest
        /// </param>
        /// 
        /// <returns>
        /// MakeCallResponse
        /// </returns>
        public MakeCallResponse MakeCall(MakeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MakeCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// MakeCallRequest
        /// </param>
        /// 
        /// <returns>
        /// MakeCallResponse
        /// </returns>
        public async Task<MakeCallResponse> MakeCallAsync(MakeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MakeCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动端发起呼叫</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MakeDoubleCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MakeDoubleCallResponse
        /// </returns>
        public MakeDoubleCallResponse MakeDoubleCallWithOptions(MakeDoubleCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizData))
            {
                query["BizData"] = request.BizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberPhone))
            {
                query["MemberPhone"] = request.MemberPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundCallNumber))
            {
                query["OutboundCallNumber"] = request.OutboundCallNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerPhone))
            {
                query["ServicerPhone"] = request.ServicerPhone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MakeDoubleCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MakeDoubleCallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动端发起呼叫</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MakeDoubleCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MakeDoubleCallResponse
        /// </returns>
        public async Task<MakeDoubleCallResponse> MakeDoubleCallWithOptionsAsync(MakeDoubleCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizData))
            {
                query["BizData"] = request.BizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberPhone))
            {
                query["MemberPhone"] = request.MemberPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundCallNumber))
            {
                query["OutboundCallNumber"] = request.OutboundCallNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerPhone))
            {
                query["ServicerPhone"] = request.ServicerPhone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MakeDoubleCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MakeDoubleCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动端发起呼叫</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MakeDoubleCallRequest
        /// </param>
        /// 
        /// <returns>
        /// MakeDoubleCallResponse
        /// </returns>
        public MakeDoubleCallResponse MakeDoubleCall(MakeDoubleCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MakeDoubleCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移动端发起呼叫</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MakeDoubleCallRequest
        /// </param>
        /// 
        /// <returns>
        /// MakeDoubleCallResponse
        /// </returns>
        public async Task<MakeDoubleCallResponse> MakeDoubleCallAsync(MakeDoubleCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MakeDoubleCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryHotlineInQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHotlineInQueueResponse
        /// </returns>
        public QueryHotlineInQueueResponse QueryHotlineInQueueWithOptions(QueryHotlineInQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHotlineInQueue",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotlineInQueueResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryHotlineInQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHotlineInQueueResponse
        /// </returns>
        public async Task<QueryHotlineInQueueResponse> QueryHotlineInQueueWithOptionsAsync(QueryHotlineInQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHotlineInQueue",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotlineInQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryHotlineInQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHotlineInQueueResponse
        /// </returns>
        public QueryHotlineInQueueResponse QueryHotlineInQueue(QueryHotlineInQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryHotlineInQueueWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryHotlineInQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHotlineInQueueResponse
        /// </returns>
        public async Task<QueryHotlineInQueueResponse> QueryHotlineInQueueAsync(QueryHotlineInQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryHotlineInQueueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询热线号码配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryHotlineNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHotlineNumberResponse
        /// </returns>
        public QueryHotlineNumberResponse QueryHotlineNumberWithOptions(QueryHotlineNumberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryHotlineNumberShrinkRequest request = new QueryHotlineNumberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHotlineNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotlineNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询热线号码配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryHotlineNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryHotlineNumberResponse
        /// </returns>
        public async Task<QueryHotlineNumberResponse> QueryHotlineNumberWithOptionsAsync(QueryHotlineNumberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryHotlineNumberShrinkRequest request = new QueryHotlineNumberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupIds))
            {
                request.GroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupIds, "GroupIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHotlineNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotlineNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询热线号码配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHotlineNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHotlineNumberResponse
        /// </returns>
        public QueryHotlineNumberResponse QueryHotlineNumber(QueryHotlineNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryHotlineNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询热线号码配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryHotlineNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryHotlineNumberResponse
        /// </returns>
        public async Task<QueryHotlineNumberResponse> QueryHotlineNumberAsync(QueryHotlineNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryHotlineNumberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOutboundTaskResponse
        /// </returns>
        public QueryOutboundTaskResponse QueryOutboundTaskWithOptions(QueryOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ani))
            {
                query["Ani"] = request.Ani;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroup))
            {
                query["SkillGroup"] = request.SkillGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOutboundTaskResponse
        /// </returns>
        public async Task<QueryOutboundTaskResponse> QueryOutboundTaskWithOptionsAsync(QueryOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ani))
            {
                query["Ani"] = request.Ani;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroup))
            {
                query["SkillGroup"] = request.SkillGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOutboundTaskResponse
        /// </returns>
        public QueryOutboundTaskResponse QueryOutboundTask(QueryOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOutboundTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOutboundTaskResponse
        /// </returns>
        public async Task<QueryOutboundTaskResponse> QueryOutboundTaskAsync(QueryOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QuerySkillGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySkillGroupsResponse
        /// </returns>
        public QuerySkillGroupsResponse QuerySkillGroupsWithOptions(QuerySkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "QuerySkillGroups",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySkillGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySkillGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySkillGroupsResponse
        /// </returns>
        public async Task<QuerySkillGroupsResponse> QuerySkillGroupsWithOptionsAsync(QuerySkillGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "QuerySkillGroups",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySkillGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySkillGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySkillGroupsResponse
        /// </returns>
        public QuerySkillGroupsResponse QuerySkillGroups(QuerySkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySkillGroupsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QuerySkillGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySkillGroupsResponse
        /// </returns>
        public async Task<QuerySkillGroupsResponse> QuerySkillGroupsAsync(QuerySkillGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySkillGroupsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailResponse
        /// </returns>
        public QueryTaskDetailResponse QueryTaskDetailWithOptions(QueryTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ani))
            {
                query["Ani"] = request.Ani;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentIdList))
            {
                query["DepartmentIdList"] = request.DepartmentIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dnis))
            {
                query["Dnis"] = request.Dnis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndReasonList))
            {
                query["EndReasonList"] = request.EndReasonList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTaskId))
            {
                query["OutboundTaskId"] = request.OutboundTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriorityList))
            {
                query["PriorityList"] = request.PriorityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerId))
            {
                query["ServicerId"] = request.ServicerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerName))
            {
                query["ServicerName"] = request.ServicerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sid))
            {
                query["Sid"] = request.Sid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroup))
            {
                query["SkillGroup"] = request.SkillGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
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
                Action = "QueryTaskDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailResponse
        /// </returns>
        public async Task<QueryTaskDetailResponse> QueryTaskDetailWithOptionsAsync(QueryTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ani))
            {
                query["Ani"] = request.Ani;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentIdList))
            {
                query["DepartmentIdList"] = request.DepartmentIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dnis))
            {
                query["Dnis"] = request.Dnis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndReasonList))
            {
                query["EndReasonList"] = request.EndReasonList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTaskId))
            {
                query["OutboundTaskId"] = request.OutboundTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriorityList))
            {
                query["PriorityList"] = request.PriorityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerId))
            {
                query["ServicerId"] = request.ServicerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerName))
            {
                query["ServicerName"] = request.ServicerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sid))
            {
                query["Sid"] = request.Sid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroup))
            {
                query["SkillGroup"] = request.SkillGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
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
                Action = "QueryTaskDetail",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailResponse
        /// </returns>
        public QueryTaskDetailResponse QueryTaskDetail(QueryTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailResponse
        /// </returns>
        public async Task<QueryTaskDetailResponse> QueryTaskDetailAsync(QueryTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// QueryTicketsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTicketsResponse
        /// </returns>
        public QueryTicketsResponse QueryTicketsWithOptions(QueryTicketsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTicketsShrinkRequest request = new QueryTicketsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseId))
            {
                body["CaseId"] = request.CaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseStatus))
            {
                body["CaseStatus"] = request.CaseStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseType))
            {
                body["CaseType"] = request.CaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DealId))
            {
                body["DealId"] = request.DealId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["Extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrType))
            {
                body["SrType"] = request.SrType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TouchId))
            {
                body["TouchId"] = request.TouchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTickets",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTicketsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// QueryTicketsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTicketsResponse
        /// </returns>
        public async Task<QueryTicketsResponse> QueryTicketsWithOptionsAsync(QueryTicketsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTicketsShrinkRequest request = new QueryTicketsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extra))
            {
                request.ExtraShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extra, "Extra", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseId))
            {
                body["CaseId"] = request.CaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseStatus))
            {
                body["CaseStatus"] = request.CaseStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseType))
            {
                body["CaseType"] = request.CaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DealId))
            {
                body["DealId"] = request.DealId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraShrink))
            {
                body["Extra"] = request.ExtraShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrType))
            {
                body["SrType"] = request.SrType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TouchId))
            {
                body["TouchId"] = request.TouchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTickets",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTicketsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryTicketsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTicketsResponse
        /// </returns>
        public QueryTicketsResponse QueryTickets(QueryTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTicketsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryTicketsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTicketsResponse
        /// </returns>
        public async Task<QueryTicketsResponse> QueryTicketsAsync(QueryTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTicketsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryTouchListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTouchListResponse
        /// </returns>
        public QueryTouchListResponse QueryTouchListWithOptions(QueryTouchListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloseTimeEnd))
            {
                body["CloseTimeEnd"] = request.CloseTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloseTimeStart))
            {
                body["CloseTimeStart"] = request.CloseTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationLevel))
            {
                body["EvaluationLevel"] = request.EvaluationLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationScore))
            {
                body["EvaluationScore"] = request.EvaluationScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationStatus))
            {
                body["EvaluationStatus"] = request.EvaluationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstTimeEnd))
            {
                body["FirstTimeEnd"] = request.FirstTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstTimeStart))
            {
                body["FirstTimeStart"] = request.FirstTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                body["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                body["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueId))
            {
                body["QueueId"] = request.QueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerId))
            {
                body["ServicerId"] = request.ServicerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerName))
            {
                body["ServicerName"] = request.ServicerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TouchId))
            {
                body["TouchId"] = request.TouchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TouchType))
            {
                body["TouchType"] = request.TouchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTouchList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTouchListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryTouchListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTouchListResponse
        /// </returns>
        public async Task<QueryTouchListResponse> QueryTouchListWithOptionsAsync(QueryTouchListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloseTimeEnd))
            {
                body["CloseTimeEnd"] = request.CloseTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloseTimeStart))
            {
                body["CloseTimeStart"] = request.CloseTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationLevel))
            {
                body["EvaluationLevel"] = request.EvaluationLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationScore))
            {
                body["EvaluationScore"] = request.EvaluationScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationStatus))
            {
                body["EvaluationStatus"] = request.EvaluationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstTimeEnd))
            {
                body["FirstTimeEnd"] = request.FirstTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstTimeStart))
            {
                body["FirstTimeStart"] = request.FirstTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                body["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                body["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueId))
            {
                body["QueueId"] = request.QueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerId))
            {
                body["ServicerId"] = request.ServicerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicerName))
            {
                body["ServicerName"] = request.ServicerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TouchId))
            {
                body["TouchId"] = request.TouchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TouchType))
            {
                body["TouchType"] = request.TouchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTouchList",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTouchListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryTouchListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTouchListResponse
        /// </returns>
        public QueryTouchListResponse QueryTouchList(QueryTouchListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTouchListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryTouchListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTouchListResponse
        /// </returns>
        public async Task<QueryTouchListResponse> QueryTouchListAsync(QueryTouchListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTouchListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从技能组中移除坐席</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RemoveAgentFromSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveAgentFromSkillGroupResponse
        /// </returns>
        public RemoveAgentFromSkillGroupResponse RemoveAgentFromSkillGroupWithOptions(RemoveAgentFromSkillGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveAgentFromSkillGroupShrinkRequest request = new RemoveAgentFromSkillGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdsShrink))
            {
                query["AgentIds"] = request.AgentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                query["SkillGroupId"] = request.SkillGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAgentFromSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAgentFromSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从技能组中移除坐席</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RemoveAgentFromSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveAgentFromSkillGroupResponse
        /// </returns>
        public async Task<RemoveAgentFromSkillGroupResponse> RemoveAgentFromSkillGroupWithOptionsAsync(RemoveAgentFromSkillGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveAgentFromSkillGroupShrinkRequest request = new RemoveAgentFromSkillGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentIds))
            {
                request.AgentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentIds, "AgentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdsShrink))
            {
                query["AgentIds"] = request.AgentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                query["SkillGroupId"] = request.SkillGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAgentFromSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAgentFromSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从技能组中移除坐席</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveAgentFromSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveAgentFromSkillGroupResponse
        /// </returns>
        public RemoveAgentFromSkillGroupResponse RemoveAgentFromSkillGroup(RemoveAgentFromSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveAgentFromSkillGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从技能组中移除坐席</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveAgentFromSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveAgentFromSkillGroupResponse
        /// </returns>
        public async Task<RemoveAgentFromSkillGroupResponse> RemoveAgentFromSkillGroupAsync(RemoveAgentFromSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveAgentFromSkillGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RemoveSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveSkillGroupResponse
        /// </returns>
        public RemoveSkillGroupResponse RemoveSkillGroupWithOptions(RemoveSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                body["SkillGroupId"] = request.SkillGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RemoveSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveSkillGroupResponse
        /// </returns>
        public async Task<RemoveSkillGroupResponse> RemoveSkillGroupWithOptionsAsync(RemoveSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                body["SkillGroupId"] = request.SkillGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RemoveSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveSkillGroupResponse
        /// </returns>
        public RemoveSkillGroupResponse RemoveSkillGroup(RemoveSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveSkillGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RemoveSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveSkillGroupResponse
        /// </returns>
        public async Task<RemoveSkillGroupResponse> RemoveSkillGroupAsync(RemoveSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveSkillGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置热线号码</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ResetHotlineNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetHotlineNumberResponse
        /// </returns>
        public ResetHotlineNumberResponse ResetHotlineNumberWithOptions(ResetHotlineNumberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ResetHotlineNumberShrinkRequest request = new ResetHotlineNumberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutboundRangeList))
            {
                request.OutboundRangeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutboundRangeList, "OutboundRangeList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInbound))
            {
                body["EnableInbound"] = request.EnableInbound;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInboundEvaluation))
            {
                body["EnableInboundEvaluation"] = request.EnableInboundEvaluation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutbound))
            {
                body["EnableOutbound"] = request.EnableOutbound;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutboundEvaluation))
            {
                body["EnableOutboundEvaluation"] = request.EnableOutboundEvaluation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationLevel))
            {
                body["EvaluationLevel"] = request.EvaluationLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotlineNumber))
            {
                body["HotlineNumber"] = request.HotlineNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InboundFlowId))
            {
                body["InboundFlowId"] = request.InboundFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundAllDepart))
            {
                body["OutboundAllDepart"] = request.OutboundAllDepart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundRangeListShrink))
            {
                body["OutboundRangeList"] = request.OutboundRangeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetHotlineNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetHotlineNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置热线号码</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ResetHotlineNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetHotlineNumberResponse
        /// </returns>
        public async Task<ResetHotlineNumberResponse> ResetHotlineNumberWithOptionsAsync(ResetHotlineNumberRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ResetHotlineNumberShrinkRequest request = new ResetHotlineNumberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutboundRangeList))
            {
                request.OutboundRangeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutboundRangeList, "OutboundRangeList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInbound))
            {
                body["EnableInbound"] = request.EnableInbound;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInboundEvaluation))
            {
                body["EnableInboundEvaluation"] = request.EnableInboundEvaluation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutbound))
            {
                body["EnableOutbound"] = request.EnableOutbound;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOutboundEvaluation))
            {
                body["EnableOutboundEvaluation"] = request.EnableOutboundEvaluation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationLevel))
            {
                body["EvaluationLevel"] = request.EvaluationLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotlineNumber))
            {
                body["HotlineNumber"] = request.HotlineNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InboundFlowId))
            {
                body["InboundFlowId"] = request.InboundFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundAllDepart))
            {
                body["OutboundAllDepart"] = request.OutboundAllDepart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundRangeListShrink))
            {
                body["OutboundRangeList"] = request.OutboundRangeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetHotlineNumber",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetHotlineNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置热线号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetHotlineNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetHotlineNumberResponse
        /// </returns>
        public ResetHotlineNumberResponse ResetHotlineNumber(ResetHotlineNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetHotlineNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置热线号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetHotlineNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetHotlineNumberResponse
        /// </returns>
        public async Task<ResetHotlineNumberResponse> ResetHotlineNumberAsync(ResetHotlineNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetHotlineNumberWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RestartOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartOutboundTaskResponse
        /// </returns>
        public RestartOutboundTaskResponse RestartOutboundTaskWithOptions(RestartOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTaskId))
            {
                query["OutboundTaskId"] = request.OutboundTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RestartOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartOutboundTaskResponse
        /// </returns>
        public async Task<RestartOutboundTaskResponse> RestartOutboundTaskWithOptionsAsync(RestartOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTaskId))
            {
                query["OutboundTaskId"] = request.OutboundTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RestartOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartOutboundTaskResponse
        /// </returns>
        public RestartOutboundTaskResponse RestartOutboundTask(RestartOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartOutboundTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RestartOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartOutboundTaskResponse
        /// </returns>
        public async Task<RestartOutboundTaskResponse> RestartOutboundTaskAsync(RestartOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RobotCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RobotCallResponse
        /// </returns>
        public RobotCallResponse RobotCallWithOptions(RobotCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarlyMediaAsr))
            {
                query["EarlyMediaAsr"] = request.EarlyMediaAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFlag))
            {
                query["RecordFlag"] = request.RecordFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotId))
            {
                query["RobotId"] = request.RobotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RobotCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RobotCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RobotCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RobotCallResponse
        /// </returns>
        public async Task<RobotCallResponse> RobotCallWithOptionsAsync(RobotCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarlyMediaAsr))
            {
                query["EarlyMediaAsr"] = request.EarlyMediaAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFlag))
            {
                query["RecordFlag"] = request.RecordFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotId))
            {
                query["RobotId"] = request.RobotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RobotCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RobotCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RobotCallRequest
        /// </param>
        /// 
        /// <returns>
        /// RobotCallResponse
        /// </returns>
        public RobotCallResponse RobotCall(RobotCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RobotCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RobotCallRequest
        /// </param>
        /// 
        /// <returns>
        /// RobotCallResponse
        /// </returns>
        public async Task<RobotCallResponse> RobotCallAsync(RobotCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RobotCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SendCcoSmartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendCcoSmartCallResponse
        /// </returns>
        public SendCcoSmartCallResponse SendCcoSmartCallWithOptions(SendCcoSmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeBreak))
            {
                query["ActionCodeBreak"] = request.ActionCodeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeTimeBreak))
            {
                query["ActionCodeTimeBreak"] = request.ActionCodeTimeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrAlsAmId))
            {
                query["AsrAlsAmId"] = request.AsrAlsAmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrBaseId))
            {
                query["AsrBaseId"] = request.AsrBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrModelId))
            {
                query["AsrModelId"] = request.AsrModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrVocabularyId))
            {
                query["AsrVocabularyId"] = request.AsrVocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundFileCode))
            {
                query["BackgroundFileCode"] = request.BackgroundFileCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundSpeed))
            {
                query["BackgroundSpeed"] = request.BackgroundSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundVolume))
            {
                query["BackgroundVolume"] = request.BackgroundVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicId))
            {
                query["DynamicId"] = request.DynamicId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarlyMediaAsr))
            {
                query["EarlyMediaAsr"] = request.EarlyMediaAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableITN))
            {
                query["EnableITN"] = request.EnableITN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteTime))
            {
                query["MuteTime"] = request.MuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseTime))
            {
                query["PauseTime"] = request.PauseTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFlag))
            {
                query["RecordFlag"] = request.RecordFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsConf))
            {
                query["TtsConf"] = request.TtsConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsSpeed))
            {
                query["TtsSpeed"] = request.TtsSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsStyle))
            {
                query["TtsStyle"] = request.TtsStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVolume))
            {
                query["TtsVolume"] = request.TtsVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["VoiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCodeParam))
            {
                query["VoiceCodeParam"] = request.VoiceCodeParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendCcoSmartCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCcoSmartCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SendCcoSmartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendCcoSmartCallResponse
        /// </returns>
        public async Task<SendCcoSmartCallResponse> SendCcoSmartCallWithOptionsAsync(SendCcoSmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeBreak))
            {
                query["ActionCodeBreak"] = request.ActionCodeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeTimeBreak))
            {
                query["ActionCodeTimeBreak"] = request.ActionCodeTimeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrAlsAmId))
            {
                query["AsrAlsAmId"] = request.AsrAlsAmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrBaseId))
            {
                query["AsrBaseId"] = request.AsrBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrModelId))
            {
                query["AsrModelId"] = request.AsrModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrVocabularyId))
            {
                query["AsrVocabularyId"] = request.AsrVocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundFileCode))
            {
                query["BackgroundFileCode"] = request.BackgroundFileCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundSpeed))
            {
                query["BackgroundSpeed"] = request.BackgroundSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundVolume))
            {
                query["BackgroundVolume"] = request.BackgroundVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicId))
            {
                query["DynamicId"] = request.DynamicId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarlyMediaAsr))
            {
                query["EarlyMediaAsr"] = request.EarlyMediaAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableITN))
            {
                query["EnableITN"] = request.EnableITN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteTime))
            {
                query["MuteTime"] = request.MuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseTime))
            {
                query["PauseTime"] = request.PauseTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFlag))
            {
                query["RecordFlag"] = request.RecordFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsConf))
            {
                query["TtsConf"] = request.TtsConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsSpeed))
            {
                query["TtsSpeed"] = request.TtsSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsStyle))
            {
                query["TtsStyle"] = request.TtsStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVolume))
            {
                query["TtsVolume"] = request.TtsVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["VoiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCodeParam))
            {
                query["VoiceCodeParam"] = request.VoiceCodeParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendCcoSmartCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCcoSmartCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SendCcoSmartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// SendCcoSmartCallResponse
        /// </returns>
        public SendCcoSmartCallResponse SendCcoSmartCall(SendCcoSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCcoSmartCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SendCcoSmartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// SendCcoSmartCallResponse
        /// </returns>
        public async Task<SendCcoSmartCallResponse> SendCcoSmartCallAsync(SendCcoSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCcoSmartCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SendCcoSmartCallOperateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendCcoSmartCallOperateResponse
        /// </returns>
        public SendCcoSmartCallOperateResponse SendCcoSmartCallOperateWithOptions(SendCcoSmartCallOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
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
                Action = "SendCcoSmartCallOperate",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCcoSmartCallOperateResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SendCcoSmartCallOperateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendCcoSmartCallOperateResponse
        /// </returns>
        public async Task<SendCcoSmartCallOperateResponse> SendCcoSmartCallOperateWithOptionsAsync(SendCcoSmartCallOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
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
                Action = "SendCcoSmartCallOperate",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCcoSmartCallOperateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SendCcoSmartCallOperateRequest
        /// </param>
        /// 
        /// <returns>
        /// SendCcoSmartCallOperateResponse
        /// </returns>
        public SendCcoSmartCallOperateResponse SendCcoSmartCallOperate(SendCcoSmartCallOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCcoSmartCallOperateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SendCcoSmartCallOperateRequest
        /// </param>
        /// 
        /// <returns>
        /// SendCcoSmartCallOperateResponse
        /// </returns>
        public async Task<SendCcoSmartCallOperateResponse> SendCcoSmartCallOperateAsync(SendCcoSmartCallOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCcoSmartCallOperateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SendHotlineHeartBeatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendHotlineHeartBeatResponse
        /// </returns>
        public SendHotlineHeartBeatResponse SendHotlineHeartBeatWithOptions(SendHotlineHeartBeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendHotlineHeartBeat",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendHotlineHeartBeatResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SendHotlineHeartBeatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendHotlineHeartBeatResponse
        /// </returns>
        public async Task<SendHotlineHeartBeatResponse> SendHotlineHeartBeatWithOptionsAsync(SendHotlineHeartBeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendHotlineHeartBeat",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendHotlineHeartBeatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SendHotlineHeartBeatRequest
        /// </param>
        /// 
        /// <returns>
        /// SendHotlineHeartBeatResponse
        /// </returns>
        public SendHotlineHeartBeatResponse SendHotlineHeartBeat(SendHotlineHeartBeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendHotlineHeartBeatWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SendHotlineHeartBeatRequest
        /// </param>
        /// 
        /// <returns>
        /// SendHotlineHeartBeatResponse
        /// </returns>
        public async Task<SendHotlineHeartBeatResponse> SendHotlineHeartBeatAsync(SendHotlineHeartBeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendHotlineHeartBeatWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAiOutboundTaskResponse
        /// </returns>
        public StartAiOutboundTaskResponse StartAiOutboundTaskWithOptions(StartAiOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StartAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAiOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAiOutboundTaskResponse
        /// </returns>
        public async Task<StartAiOutboundTaskResponse> StartAiOutboundTaskWithOptionsAsync(StartAiOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StartAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAiOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAiOutboundTaskResponse
        /// </returns>
        public StartAiOutboundTaskResponse StartAiOutboundTask(StartAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAiOutboundTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAiOutboundTaskResponse
        /// </returns>
        public async Task<StartAiOutboundTaskResponse> StartAiOutboundTaskAsync(StartAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAiOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCallResponse
        /// </returns>
        public StartCallResponse StartCallWithOptions(StartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callee))
            {
                body["Callee"] = request.Callee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                body["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCallResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// StartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCallResponse
        /// </returns>
        public async Task<StartCallResponse> StartCallWithOptionsAsync(StartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callee))
            {
                body["Callee"] = request.Callee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                body["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCall",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// StartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCallResponse
        /// </returns>
        public StartCallResponse StartCall(StartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCallWithOptions(request, runtime);
        }

        /// <param name="request">
        /// StartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// StartCallResponse
        /// </returns>
        public async Task<StartCallResponse> StartCallAsync(StartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCallWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StartCallV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCallV2Response
        /// </returns>
        public StartCallV2Response StartCallV2WithOptions(StartCallV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callee))
            {
                body["Callee"] = request.Callee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                body["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                body["CallerType"] = request.CallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCallV2",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCallV2Response>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// StartCallV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartCallV2Response
        /// </returns>
        public async Task<StartCallV2Response> StartCallV2WithOptionsAsync(StartCallV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callee))
            {
                body["Callee"] = request.Callee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                body["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                body["CallerType"] = request.CallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCallV2",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCallV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// StartCallV2Request
        /// </param>
        /// 
        /// <returns>
        /// StartCallV2Response
        /// </returns>
        public StartCallV2Response StartCallV2(StartCallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCallV2WithOptions(request, runtime);
        }

        /// <param name="request">
        /// StartCallV2Request
        /// </param>
        /// 
        /// <returns>
        /// StartCallV2Response
        /// </returns>
        public async Task<StartCallV2Response> StartCallV2Async(StartCallV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCallV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改在线客服为上班状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartChatWorkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartChatWorkResponse
        /// </returns>
        public StartChatWorkResponse StartChatWorkWithOptions(StartChatWorkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartChatWork",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartChatWorkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改在线客服为上班状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartChatWorkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartChatWorkResponse
        /// </returns>
        public async Task<StartChatWorkResponse> StartChatWorkWithOptionsAsync(StartChatWorkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartChatWork",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartChatWorkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改在线客服为上班状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartChatWorkRequest
        /// </param>
        /// 
        /// <returns>
        /// StartChatWorkResponse
        /// </returns>
        public StartChatWorkResponse StartChatWork(StartChatWorkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartChatWorkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改在线客服为上班状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartChatWorkRequest
        /// </param>
        /// 
        /// <returns>
        /// StartChatWorkResponse
        /// </returns>
        public async Task<StartChatWorkResponse> StartChatWorkAsync(StartChatWorkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartChatWorkWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StartHotlineServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartHotlineServiceResponse
        /// </returns>
        public StartHotlineServiceResponse StartHotlineServiceWithOptions(StartHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartHotlineService",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartHotlineServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// StartHotlineServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartHotlineServiceResponse
        /// </returns>
        public async Task<StartHotlineServiceResponse> StartHotlineServiceWithOptionsAsync(StartHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartHotlineService",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartHotlineServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// StartHotlineServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartHotlineServiceResponse
        /// </returns>
        public StartHotlineServiceResponse StartHotlineService(StartHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartHotlineServiceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// StartHotlineServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartHotlineServiceResponse
        /// </returns>
        public async Task<StartHotlineServiceResponse> StartHotlineServiceAsync(StartHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartHotlineServiceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// StartMicroOutboundRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartMicroOutboundResponse
        /// </returns>
        public StartMicroOutboundResponse StartMicroOutboundWithOptions(StartMicroOutboundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandCode))
            {
                query["CommandCode"] = request.CommandCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
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
                Action = "StartMicroOutbound",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMicroOutboundResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// StartMicroOutboundRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartMicroOutboundResponse
        /// </returns>
        public async Task<StartMicroOutboundResponse> StartMicroOutboundWithOptionsAsync(StartMicroOutboundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandCode))
            {
                query["CommandCode"] = request.CommandCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
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
                Action = "StartMicroOutbound",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMicroOutboundResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// StartMicroOutboundRequest
        /// </param>
        /// 
        /// <returns>
        /// StartMicroOutboundResponse
        /// </returns>
        public StartMicroOutboundResponse StartMicroOutbound(StartMicroOutboundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMicroOutboundWithOptions(request, runtime);
        }

        /// <param name="request">
        /// StartMicroOutboundRequest
        /// </param>
        /// 
        /// <returns>
        /// StartMicroOutboundResponse
        /// </returns>
        public async Task<StartMicroOutboundResponse> StartMicroOutboundAsync(StartMicroOutboundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMicroOutboundWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>立即或定时启动智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTaskResponse
        /// </returns>
        public StartTaskResponse StartTaskWithOptions(StartTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartNow))
            {
                query["StartNow"] = request.StartNow;
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
                Action = "StartTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>立即或定时启动智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTaskResponse
        /// </returns>
        public async Task<StartTaskResponse> StartTaskWithOptionsAsync(StartTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartNow))
            {
                query["StartNow"] = request.StartNow;
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
                Action = "StartTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>立即或定时启动智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTaskResponse
        /// </returns>
        public StartTaskResponse StartTask(StartTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>立即或定时启动智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTaskResponse
        /// </returns>
        public async Task<StartTaskResponse> StartTaskAsync(StartTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手动暂停智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAiOutboundTaskResponse
        /// </returns>
        public StopAiOutboundTaskResponse StopAiOutboundTaskWithOptions(StopAiOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StopAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAiOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手动暂停智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAiOutboundTaskResponse
        /// </returns>
        public async Task<StopAiOutboundTaskResponse> StopAiOutboundTaskWithOptionsAsync(StopAiOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StopAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAiOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手动暂停智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAiOutboundTaskResponse
        /// </returns>
        public StopAiOutboundTaskResponse StopAiOutboundTask(StopAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAiOutboundTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手动暂停智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAiOutboundTaskResponse
        /// </returns>
        public async Task<StopAiOutboundTaskResponse> StopAiOutboundTaskAsync(StopAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAiOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTaskResponse
        /// </returns>
        public StopTaskResponse StopTaskWithOptions(StopTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTaskResponse
        /// </returns>
        public async Task<StopTaskResponse> StopTaskWithOptionsAsync(StopTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopTaskResponse
        /// </returns>
        public StopTaskResponse StopTask(StopTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopTaskResponse
        /// </returns>
        public async Task<StopTaskResponse> StopTaskAsync(StopTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SuspendHotlineServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendHotlineServiceResponse
        /// </returns>
        public SuspendHotlineServiceResponse SuspendHotlineServiceWithOptions(SuspendHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "SuspendHotlineService",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendHotlineServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SuspendHotlineServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendHotlineServiceResponse
        /// </returns>
        public async Task<SuspendHotlineServiceResponse> SuspendHotlineServiceWithOptionsAsync(SuspendHotlineServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "SuspendHotlineService",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendHotlineServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SuspendHotlineServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendHotlineServiceResponse
        /// </returns>
        public SuspendHotlineServiceResponse SuspendHotlineService(SuspendHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendHotlineServiceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SuspendHotlineServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendHotlineServiceResponse
        /// </returns>
        public async Task<SuspendHotlineServiceResponse> SuspendHotlineServiceAsync(SuspendHotlineServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendHotlineServiceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SuspendOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendOutboundTaskResponse
        /// </returns>
        public SuspendOutboundTaskResponse SuspendOutboundTaskWithOptions(SuspendOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTaskId))
            {
                query["OutboundTaskId"] = request.OutboundTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SuspendOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendOutboundTaskResponse
        /// </returns>
        public async Task<SuspendOutboundTaskResponse> SuspendOutboundTaskWithOptionsAsync(SuspendOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTaskId))
            {
                query["OutboundTaskId"] = request.OutboundTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SuspendOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendOutboundTaskResponse
        /// </returns>
        public SuspendOutboundTaskResponse SuspendOutboundTask(SuspendOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendOutboundTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SuspendOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendOutboundTaskResponse
        /// </returns>
        public async Task<SuspendOutboundTaskResponse> SuspendOutboundTaskAsync(SuspendOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateAiOutboundTaskResponse
        /// </returns>
        public TerminateAiOutboundTaskResponse TerminateAiOutboundTaskWithOptions(TerminateAiOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "TerminateAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateAiOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateAiOutboundTaskResponse
        /// </returns>
        public async Task<TerminateAiOutboundTaskResponse> TerminateAiOutboundTaskWithOptionsAsync(TerminateAiOutboundTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "TerminateAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateAiOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateAiOutboundTaskResponse
        /// </returns>
        public TerminateAiOutboundTaskResponse TerminateAiOutboundTask(TerminateAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TerminateAiOutboundTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>终止智能外呼任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateAiOutboundTaskResponse
        /// </returns>
        public async Task<TerminateAiOutboundTaskResponse> TerminateAiOutboundTaskAsync(TerminateAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TerminateAiOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// TransferCallToSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferCallToSkillGroupResponse
        /// </returns>
        public TransferCallToSkillGroupResponse TransferCallToSkillGroupWithOptions(TransferCallToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldConnectionId))
            {
                body["HoldConnectionId"] = request.HoldConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSingleTransfer))
            {
                body["IsSingleTransfer"] = request.IsSingleTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                body["SkillGroupId"] = request.SkillGroupId;
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
                Action = "TransferCallToSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferCallToSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// TransferCallToSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferCallToSkillGroupResponse
        /// </returns>
        public async Task<TransferCallToSkillGroupResponse> TransferCallToSkillGroupWithOptionsAsync(TransferCallToSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                body["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                body["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldConnectionId))
            {
                body["HoldConnectionId"] = request.HoldConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSingleTransfer))
            {
                body["IsSingleTransfer"] = request.IsSingleTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                body["SkillGroupId"] = request.SkillGroupId;
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
                Action = "TransferCallToSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferCallToSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// TransferCallToSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferCallToSkillGroupResponse
        /// </returns>
        public TransferCallToSkillGroupResponse TransferCallToSkillGroup(TransferCallToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferCallToSkillGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// TransferCallToSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferCallToSkillGroupResponse
        /// </returns>
        public async Task<TransferCallToSkillGroupResponse> TransferCallToSkillGroupAsync(TransferCallToSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferCallToSkillGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public UpdateAgentResponse UpdateAgentWithOptions(UpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                body["SkillGroupId"] = request.SkillGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdList))
            {
                body["SkillGroupIdList"] = request.SkillGroupIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgent",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "PUT",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public async Task<UpdateAgentResponse> UpdateAgentWithOptionsAsync(UpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                body["SkillGroupId"] = request.SkillGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdList))
            {
                body["SkillGroupIdList"] = request.SkillGroupIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgent",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "PUT",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAgentWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public async Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能外呼任务（预测式外呼、自动外呼）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAiOutboundTaskResponse
        /// </returns>
        public UpdateAiOutboundTaskResponse UpdateAiOutboundTaskWithOptions(UpdateAiOutboundTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAiOutboundTaskShrinkRequest request = new UpdateAiOutboundTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutboundNums))
            {
                request.OutboundNumsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutboundNums, "OutboundNums", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecallRule))
            {
                request.RecallRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecallRule, "RecallRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrentRate))
            {
                query["ConcurrentRate"] = request.ConcurrentRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTime))
            {
                query["ExecutionTime"] = request.ExecutionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastCallRate))
            {
                query["ForecastCallRate"] = request.ForecastCallRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandlerId))
            {
                query["HandlerId"] = request.HandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumRepeated))
            {
                query["NumRepeated"] = request.NumRepeated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundNumsShrink))
            {
                query["OutboundNums"] = request.OutboundNumsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallRuleShrink))
            {
                query["RecallRule"] = request.RecallRuleShrink;
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
                Action = "UpdateAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAiOutboundTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能外呼任务（预测式外呼、自动外呼）</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAiOutboundTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAiOutboundTaskResponse
        /// </returns>
        public async Task<UpdateAiOutboundTaskResponse> UpdateAiOutboundTaskWithOptionsAsync(UpdateAiOutboundTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAiOutboundTaskShrinkRequest request = new UpdateAiOutboundTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutboundNums))
            {
                request.OutboundNumsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutboundNums, "OutboundNums", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecallRule))
            {
                request.RecallRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecallRule, "RecallRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrentRate))
            {
                query["ConcurrentRate"] = request.ConcurrentRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTime))
            {
                query["ExecutionTime"] = request.ExecutionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForecastCallRate))
            {
                query["ForecastCallRate"] = request.ForecastCallRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandlerId))
            {
                query["HandlerId"] = request.HandlerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumRepeated))
            {
                query["NumRepeated"] = request.NumRepeated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundNumsShrink))
            {
                query["OutboundNums"] = request.OutboundNumsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallRuleShrink))
            {
                query["RecallRule"] = request.RecallRuleShrink;
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
                Action = "UpdateAiOutboundTask",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAiOutboundTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能外呼任务（预测式外呼、自动外呼）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAiOutboundTaskResponse
        /// </returns>
        public UpdateAiOutboundTaskResponse UpdateAiOutboundTask(UpdateAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAiOutboundTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能外呼任务（预测式外呼、自动外呼）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAiOutboundTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAiOutboundTaskResponse
        /// </returns>
        public async Task<UpdateAiOutboundTaskResponse> UpdateAiOutboundTaskAsync(UpdateAiOutboundTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAiOutboundTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDepartmentResponse
        /// </returns>
        public UpdateDepartmentResponse UpdateDepartmentWithOptions(UpdateDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["DepartmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDepartment",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDepartmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDepartmentResponse
        /// </returns>
        public async Task<UpdateDepartmentResponse> UpdateDepartmentWithOptionsAsync(UpdateDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["DepartmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDepartment",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDepartmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDepartmentResponse
        /// </returns>
        public UpdateDepartmentResponse UpdateDepartment(UpdateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDepartmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新部门信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDepartmentResponse
        /// </returns>
        public async Task<UpdateDepartmentResponse> UpdateDepartmentAsync(UpdateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDepartmentWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateOuterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOuterAccountResponse
        /// </returns>
        public UpdateOuterAccountResponse UpdateOuterAccountWithOptions(UpdateOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOuterAccount",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOuterAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateOuterAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOuterAccountResponse
        /// </returns>
        public async Task<UpdateOuterAccountResponse> UpdateOuterAccountWithOptionsAsync(UpdateOuterAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOuterAccount",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOuterAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateOuterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOuterAccountResponse
        /// </returns>
        public UpdateOuterAccountResponse UpdateOuterAccount(UpdateOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOuterAccountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateOuterAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOuterAccountResponse
        /// </returns>
        public async Task<UpdateOuterAccountResponse> UpdateOuterAccountAsync(UpdateOuterAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOuterAccountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillGroupResponse
        /// </returns>
        public UpdateSkillGroupResponse UpdateSkillGroupWithOptions(UpdateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                query["SkillGroupId"] = request.SkillGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupName))
            {
                query["SkillGroupName"] = request.SkillGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateSkillGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillGroupResponse
        /// </returns>
        public async Task<UpdateSkillGroupResponse> UpdateSkillGroupWithOptionsAsync(UpdateSkillGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                query["SkillGroupId"] = request.SkillGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupName))
            {
                query["SkillGroupName"] = request.SkillGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkillGroup",
                Version = "2019-10-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillGroupResponse
        /// </returns>
        public UpdateSkillGroupResponse UpdateSkillGroup(UpdateSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSkillGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateSkillGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillGroupResponse
        /// </returns>
        public async Task<UpdateSkillGroupResponse> UpdateSkillGroupAsync(UpdateSkillGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSkillGroupWithOptionsAsync(request, runtime);
        }

    }
}
