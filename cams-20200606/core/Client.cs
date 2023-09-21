// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cams20200606.Models;

namespace AlibabaCloud.SDK.Cams20200606
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cams", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddChatappPhoneNumberResponse AddChatappPhoneNumberWithOptions(AddChatappPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cc))
            {
                body["Cc"] = request.Cc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreValidateId))
            {
                body["PreValidateId"] = request.PreValidateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifiedName))
            {
                body["VerifiedName"] = request.VerifiedName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddChatappPhoneNumber",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddChatappPhoneNumberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddChatappPhoneNumberResponse> AddChatappPhoneNumberWithOptionsAsync(AddChatappPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cc))
            {
                body["Cc"] = request.Cc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreValidateId))
            {
                body["PreValidateId"] = request.PreValidateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifiedName))
            {
                body["VerifiedName"] = request.VerifiedName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddChatappPhoneNumber",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddChatappPhoneNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddChatappPhoneNumberResponse AddChatappPhoneNumber(AddChatappPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddChatappPhoneNumberWithOptions(request, runtime);
        }

        public async Task<AddChatappPhoneNumberResponse> AddChatappPhoneNumberAsync(AddChatappPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddChatappPhoneNumberWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param tmpReq BeeBotAssociateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BeeBotAssociateResponse
         */
        public BeeBotAssociateResponse BeeBotAssociateWithOptions(BeeBotAssociateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BeeBotAssociateShrinkRequest request = new BeeBotAssociateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Perspective))
            {
                request.PerspectiveShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Perspective, "Perspective", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatBotInstanceId))
            {
                body["ChatBotInstanceId"] = request.ChatBotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerspectiveShrink))
            {
                body["Perspective"] = request.PerspectiveShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendNum))
            {
                body["RecommendNum"] = request.RecommendNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterance))
            {
                body["Utterance"] = request.Utterance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BeeBotAssociate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BeeBotAssociateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param tmpReq BeeBotAssociateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BeeBotAssociateResponse
         */
        public async Task<BeeBotAssociateResponse> BeeBotAssociateWithOptionsAsync(BeeBotAssociateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BeeBotAssociateShrinkRequest request = new BeeBotAssociateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Perspective))
            {
                request.PerspectiveShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Perspective, "Perspective", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatBotInstanceId))
            {
                body["ChatBotInstanceId"] = request.ChatBotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerspectiveShrink))
            {
                body["Perspective"] = request.PerspectiveShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendNum))
            {
                body["RecommendNum"] = request.RecommendNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterance))
            {
                body["Utterance"] = request.Utterance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BeeBotAssociate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BeeBotAssociateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request BeeBotAssociateRequest
          * @return BeeBotAssociateResponse
         */
        public BeeBotAssociateResponse BeeBotAssociate(BeeBotAssociateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BeeBotAssociateWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request BeeBotAssociateRequest
          * @return BeeBotAssociateResponse
         */
        public async Task<BeeBotAssociateResponse> BeeBotAssociateAsync(BeeBotAssociateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BeeBotAssociateWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param tmpReq BeeBotChatRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BeeBotChatResponse
         */
        public BeeBotChatResponse BeeBotChatWithOptions(BeeBotChatRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BeeBotChatShrinkRequest request = new BeeBotChatShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Perspective))
            {
                request.PerspectiveShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Perspective, "Perspective", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VendorParam))
            {
                request.VendorParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VendorParam, "VendorParam", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatBotInstanceId))
            {
                body["ChatBotInstanceId"] = request.ChatBotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentName))
            {
                body["IntentName"] = request.IntentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeId))
            {
                body["KnowledgeId"] = request.KnowledgeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerspectiveShrink))
            {
                body["Perspective"] = request.PerspectiveShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderId))
            {
                body["SenderId"] = request.SenderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderNick))
            {
                body["SenderNick"] = request.SenderNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterance))
            {
                body["Utterance"] = request.Utterance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorParamShrink))
            {
                body["VendorParam"] = request.VendorParamShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BeeBotChat",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BeeBotChatResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param tmpReq BeeBotChatRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BeeBotChatResponse
         */
        public async Task<BeeBotChatResponse> BeeBotChatWithOptionsAsync(BeeBotChatRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BeeBotChatShrinkRequest request = new BeeBotChatShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Perspective))
            {
                request.PerspectiveShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Perspective, "Perspective", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VendorParam))
            {
                request.VendorParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VendorParam, "VendorParam", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatBotInstanceId))
            {
                body["ChatBotInstanceId"] = request.ChatBotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentName))
            {
                body["IntentName"] = request.IntentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeId))
            {
                body["KnowledgeId"] = request.KnowledgeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerspectiveShrink))
            {
                body["Perspective"] = request.PerspectiveShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderId))
            {
                body["SenderId"] = request.SenderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderNick))
            {
                body["SenderNick"] = request.SenderNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterance))
            {
                body["Utterance"] = request.Utterance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorParamShrink))
            {
                body["VendorParam"] = request.VendorParamShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BeeBotChat",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BeeBotChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request BeeBotChatRequest
          * @return BeeBotChatResponse
         */
        public BeeBotChatResponse BeeBotChat(BeeBotChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BeeBotChatWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request BeeBotChatRequest
          * @return BeeBotChatResponse
         */
        public async Task<BeeBotChatResponse> BeeBotChatAsync(BeeBotChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BeeBotChatWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappBindWabaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappBindWabaResponse
         */
        public ChatappBindWabaResponse ChatappBindWabaWithOptions(ChatappBindWabaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WabaId))
            {
                body["WabaId"] = request.WabaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappBindWaba",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappBindWabaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappBindWabaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappBindWabaResponse
         */
        public async Task<ChatappBindWabaResponse> ChatappBindWabaWithOptionsAsync(ChatappBindWabaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WabaId))
            {
                body["WabaId"] = request.WabaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappBindWaba",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappBindWabaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappBindWabaRequest
          * @return ChatappBindWabaResponse
         */
        public ChatappBindWabaResponse ChatappBindWaba(ChatappBindWabaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatappBindWabaWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappBindWabaRequest
          * @return ChatappBindWabaResponse
         */
        public async Task<ChatappBindWabaResponse> ChatappBindWabaAsync(ChatappBindWabaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatappBindWabaWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappEmbedSignUpRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappEmbedSignUpResponse
         */
        public ChatappEmbedSignUpResponse ChatappEmbedSignUpWithOptions(ChatappEmbedSignUpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputToken))
            {
                body["InputToken"] = request.InputToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappEmbedSignUp",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappEmbedSignUpResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappEmbedSignUpRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappEmbedSignUpResponse
         */
        public async Task<ChatappEmbedSignUpResponse> ChatappEmbedSignUpWithOptionsAsync(ChatappEmbedSignUpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputToken))
            {
                body["InputToken"] = request.InputToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappEmbedSignUp",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappEmbedSignUpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappEmbedSignUpRequest
          * @return ChatappEmbedSignUpResponse
         */
        public ChatappEmbedSignUpResponse ChatappEmbedSignUp(ChatappEmbedSignUpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatappEmbedSignUpWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappEmbedSignUpRequest
          * @return ChatappEmbedSignUpResponse
         */
        public async Task<ChatappEmbedSignUpResponse> ChatappEmbedSignUpAsync(ChatappEmbedSignUpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatappEmbedSignUpWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappMigrationRegisterRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappMigrationRegisterResponse
         */
        public ChatappMigrationRegisterResponse ChatappMigrationRegisterWithOptions(ChatappMigrationRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappMigrationRegister",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappMigrationRegisterResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappMigrationRegisterRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappMigrationRegisterResponse
         */
        public async Task<ChatappMigrationRegisterResponse> ChatappMigrationRegisterWithOptionsAsync(ChatappMigrationRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappMigrationRegister",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappMigrationRegisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappMigrationRegisterRequest
          * @return ChatappMigrationRegisterResponse
         */
        public ChatappMigrationRegisterResponse ChatappMigrationRegister(ChatappMigrationRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatappMigrationRegisterWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappMigrationRegisterRequest
          * @return ChatappMigrationRegisterResponse
         */
        public async Task<ChatappMigrationRegisterResponse> ChatappMigrationRegisterAsync(ChatappMigrationRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatappMigrationRegisterWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappMigrationVerifiedRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappMigrationVerifiedResponse
         */
        public ChatappMigrationVerifiedResponse ChatappMigrationVerifiedWithOptions(ChatappMigrationVerifiedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                query["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappMigrationVerified",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappMigrationVerifiedResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappMigrationVerifiedRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappMigrationVerifiedResponse
         */
        public async Task<ChatappMigrationVerifiedResponse> ChatappMigrationVerifiedWithOptionsAsync(ChatappMigrationVerifiedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                query["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappMigrationVerified",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappMigrationVerifiedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappMigrationVerifiedRequest
          * @return ChatappMigrationVerifiedResponse
         */
        public ChatappMigrationVerifiedResponse ChatappMigrationVerified(ChatappMigrationVerifiedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatappMigrationVerifiedWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappMigrationVerifiedRequest
          * @return ChatappMigrationVerifiedResponse
         */
        public async Task<ChatappMigrationVerifiedResponse> ChatappMigrationVerifiedAsync(ChatappMigrationVerifiedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatappMigrationVerifiedWithOptionsAsync(request, runtime);
        }

        public ChatappPhoneNumberDeregisterResponse ChatappPhoneNumberDeregisterWithOptions(ChatappPhoneNumberDeregisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappPhoneNumberDeregister",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappPhoneNumberDeregisterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChatappPhoneNumberDeregisterResponse> ChatappPhoneNumberDeregisterWithOptionsAsync(ChatappPhoneNumberDeregisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappPhoneNumberDeregister",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappPhoneNumberDeregisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChatappPhoneNumberDeregisterResponse ChatappPhoneNumberDeregister(ChatappPhoneNumberDeregisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatappPhoneNumberDeregisterWithOptions(request, runtime);
        }

        public async Task<ChatappPhoneNumberDeregisterResponse> ChatappPhoneNumberDeregisterAsync(ChatappPhoneNumberDeregisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatappPhoneNumberDeregisterWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappPhoneNumberRegisterRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappPhoneNumberRegisterResponse
         */
        public ChatappPhoneNumberRegisterResponse ChatappPhoneNumberRegisterWithOptions(ChatappPhoneNumberRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappPhoneNumberRegister",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappPhoneNumberRegisterResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappPhoneNumberRegisterRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappPhoneNumberRegisterResponse
         */
        public async Task<ChatappPhoneNumberRegisterResponse> ChatappPhoneNumberRegisterWithOptionsAsync(ChatappPhoneNumberRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappPhoneNumberRegister",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappPhoneNumberRegisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappPhoneNumberRegisterRequest
          * @return ChatappPhoneNumberRegisterResponse
         */
        public ChatappPhoneNumberRegisterResponse ChatappPhoneNumberRegister(ChatappPhoneNumberRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatappPhoneNumberRegisterWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappPhoneNumberRegisterRequest
          * @return ChatappPhoneNumberRegisterResponse
         */
        public async Task<ChatappPhoneNumberRegisterResponse> ChatappPhoneNumberRegisterAsync(ChatappPhoneNumberRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatappPhoneNumberRegisterWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappSyncPhoneNumberRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappSyncPhoneNumberResponse
         */
        public ChatappSyncPhoneNumberResponse ChatappSyncPhoneNumberWithOptions(ChatappSyncPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappSyncPhoneNumber",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappSyncPhoneNumberResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappSyncPhoneNumberRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappSyncPhoneNumberResponse
         */
        public async Task<ChatappSyncPhoneNumberResponse> ChatappSyncPhoneNumberWithOptionsAsync(ChatappSyncPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappSyncPhoneNumber",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappSyncPhoneNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappSyncPhoneNumberRequest
          * @return ChatappSyncPhoneNumberResponse
         */
        public ChatappSyncPhoneNumberResponse ChatappSyncPhoneNumber(ChatappSyncPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatappSyncPhoneNumberWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappSyncPhoneNumberRequest
          * @return ChatappSyncPhoneNumberResponse
         */
        public async Task<ChatappSyncPhoneNumberResponse> ChatappSyncPhoneNumberAsync(ChatappSyncPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatappSyncPhoneNumberWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappVerifyAndRegisterRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappVerifyAndRegisterResponse
         */
        public ChatappVerifyAndRegisterResponse ChatappVerifyAndRegisterWithOptions(ChatappVerifyAndRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                body["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappVerifyAndRegister",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappVerifyAndRegisterResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappVerifyAndRegisterRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChatappVerifyAndRegisterResponse
         */
        public async Task<ChatappVerifyAndRegisterResponse> ChatappVerifyAndRegisterWithOptionsAsync(ChatappVerifyAndRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                body["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatappVerifyAndRegister",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatappVerifyAndRegisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappVerifyAndRegisterRequest
          * @return ChatappVerifyAndRegisterResponse
         */
        public ChatappVerifyAndRegisterResponse ChatappVerifyAndRegister(ChatappVerifyAndRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatappVerifyAndRegisterWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ChatappVerifyAndRegisterRequest
          * @return ChatappVerifyAndRegisterResponse
         */
        public async Task<ChatappVerifyAndRegisterResponse> ChatappVerifyAndRegisterAsync(ChatappVerifyAndRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatappVerifyAndRegisterWithOptionsAsync(request, runtime);
        }

        /**
          * The status of the phone number.
          *
          * @param request CreateChatappMigrationInitiateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateChatappMigrationInitiateResponse
         */
        public CreateChatappMigrationInitiateResponse CreateChatappMigrationInitiateWithOptions(CreateChatappMigrationInitiateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNumber))
            {
                query["MobileNumber"] = request.MobileNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatappMigrationInitiate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatappMigrationInitiateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The status of the phone number.
          *
          * @param request CreateChatappMigrationInitiateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateChatappMigrationInitiateResponse
         */
        public async Task<CreateChatappMigrationInitiateResponse> CreateChatappMigrationInitiateWithOptionsAsync(CreateChatappMigrationInitiateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNumber))
            {
                query["MobileNumber"] = request.MobileNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatappMigrationInitiate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatappMigrationInitiateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The status of the phone number.
          *
          * @param request CreateChatappMigrationInitiateRequest
          * @return CreateChatappMigrationInitiateResponse
         */
        public CreateChatappMigrationInitiateResponse CreateChatappMigrationInitiate(CreateChatappMigrationInitiateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChatappMigrationInitiateWithOptions(request, runtime);
        }

        /**
          * The status of the phone number.
          *
          * @param request CreateChatappMigrationInitiateRequest
          * @return CreateChatappMigrationInitiateResponse
         */
        public async Task<CreateChatappMigrationInitiateResponse> CreateChatappMigrationInitiateAsync(CreateChatappMigrationInitiateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChatappMigrationInitiateWithOptionsAsync(request, runtime);
        }

        /**
          * The error message.
          *
          * @param tmpReq CreateChatappTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateChatappTemplateResponse
         */
        public CreateChatappTemplateResponse CreateChatappTemplateWithOptions(CreateChatappTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateChatappTemplateShrinkRequest request = new CreateChatappTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Example))
            {
                request.ExampleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Example, "Example", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowCategoryChange))
            {
                body["AllowCategoryChange"] = request.AllowCategoryChange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                body["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExampleShrink))
            {
                body["Example"] = request.ExampleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSendTtlSeconds))
            {
                body["MessageSendTtlSeconds"] = request.MessageSendTtlSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatappTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The error message.
          *
          * @param tmpReq CreateChatappTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateChatappTemplateResponse
         */
        public async Task<CreateChatappTemplateResponse> CreateChatappTemplateWithOptionsAsync(CreateChatappTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateChatappTemplateShrinkRequest request = new CreateChatappTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Example))
            {
                request.ExampleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Example, "Example", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowCategoryChange))
            {
                body["AllowCategoryChange"] = request.AllowCategoryChange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                body["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExampleShrink))
            {
                body["Example"] = request.ExampleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSendTtlSeconds))
            {
                body["MessageSendTtlSeconds"] = request.MessageSendTtlSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatappTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The error message.
          *
          * @param request CreateChatappTemplateRequest
          * @return CreateChatappTemplateResponse
         */
        public CreateChatappTemplateResponse CreateChatappTemplate(CreateChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChatappTemplateWithOptions(request, runtime);
        }

        /**
          * The error message.
          *
          * @param request CreateChatappTemplateRequest
          * @return CreateChatappTemplateResponse
         */
        public async Task<CreateChatappTemplateResponse> CreateChatappTemplateAsync(CreateChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChatappTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * ### QPS limit
          * You can call this operation up to five times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DeleteChatappTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteChatappTemplateResponse
         */
        public DeleteChatappTemplateResponse DeleteChatappTemplateWithOptions(DeleteChatappTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChatappTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### QPS limit
          * You can call this operation up to five times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DeleteChatappTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteChatappTemplateResponse
         */
        public async Task<DeleteChatappTemplateResponse> DeleteChatappTemplateWithOptionsAsync(DeleteChatappTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChatappTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### QPS limit
          * You can call this operation up to five times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DeleteChatappTemplateRequest
          * @return DeleteChatappTemplateResponse
         */
        public DeleteChatappTemplateResponse DeleteChatappTemplate(DeleteChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChatappTemplateWithOptions(request, runtime);
        }

        /**
          * ### QPS limit
          * You can call this operation up to five times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DeleteChatappTemplateRequest
          * @return DeleteChatappTemplateResponse
         */
        public async Task<DeleteChatappTemplateResponse> DeleteChatappTemplateAsync(DeleteChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChatappTemplateWithOptionsAsync(request, runtime);
        }

        public EnableWhatsappROIMetricResponse EnableWhatsappROIMetricWithOptions(EnableWhatsappROIMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableWhatsappROIMetric",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableWhatsappROIMetricResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableWhatsappROIMetricResponse> EnableWhatsappROIMetricWithOptionsAsync(EnableWhatsappROIMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableWhatsappROIMetric",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableWhatsappROIMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableWhatsappROIMetricResponse EnableWhatsappROIMetric(EnableWhatsappROIMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableWhatsappROIMetricWithOptions(request, runtime);
        }

        public async Task<EnableWhatsappROIMetricResponse> EnableWhatsappROIMetricAsync(EnableWhatsappROIMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableWhatsappROIMetricWithOptionsAsync(request, runtime);
        }

        public GetChatappPhoneNumberMetricResponse GetChatappPhoneNumberMetricWithOptions(GetChatappPhoneNumberMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatappPhoneNumberMetric",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappPhoneNumberMetricResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetChatappPhoneNumberMetricResponse> GetChatappPhoneNumberMetricWithOptionsAsync(GetChatappPhoneNumberMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatappPhoneNumberMetric",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappPhoneNumberMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetChatappPhoneNumberMetricResponse GetChatappPhoneNumberMetric(GetChatappPhoneNumberMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChatappPhoneNumberMetricWithOptions(request, runtime);
        }

        public async Task<GetChatappPhoneNumberMetricResponse> GetChatappPhoneNumberMetricAsync(GetChatappPhoneNumberMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChatappPhoneNumberMetricWithOptionsAsync(request, runtime);
        }

        /**
          * ### QPS limit
          * You can call this API operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappTemplateDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetChatappTemplateDetailResponse
         */
        public GetChatappTemplateDetailResponse GetChatappTemplateDetailWithOptions(GetChatappTemplateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
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
                Action = "GetChatappTemplateDetail",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappTemplateDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### QPS limit
          * You can call this API operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappTemplateDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetChatappTemplateDetailResponse
         */
        public async Task<GetChatappTemplateDetailResponse> GetChatappTemplateDetailWithOptionsAsync(GetChatappTemplateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
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
                Action = "GetChatappTemplateDetail",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappTemplateDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### QPS limit
          * You can call this API operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappTemplateDetailRequest
          * @return GetChatappTemplateDetailResponse
         */
        public GetChatappTemplateDetailResponse GetChatappTemplateDetail(GetChatappTemplateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChatappTemplateDetailWithOptions(request, runtime);
        }

        /**
          * ### QPS limit
          * You can call this API operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappTemplateDetailRequest
          * @return GetChatappTemplateDetailResponse
         */
        public async Task<GetChatappTemplateDetailResponse> GetChatappTemplateDetailAsync(GetChatappTemplateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChatappTemplateDetailWithOptionsAsync(request, runtime);
        }

        public GetChatappTemplateMetricResponse GetChatappTemplateMetricWithOptions(GetChatappTemplateMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
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
                Action = "GetChatappTemplateMetric",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappTemplateMetricResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetChatappTemplateMetricResponse> GetChatappTemplateMetricWithOptionsAsync(GetChatappTemplateMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
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
                Action = "GetChatappTemplateMetric",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappTemplateMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetChatappTemplateMetricResponse GetChatappTemplateMetric(GetChatappTemplateMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChatappTemplateMetricWithOptions(request, runtime);
        }

        public async Task<GetChatappTemplateMetricResponse> GetChatappTemplateMetricAsync(GetChatappTemplateMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChatappTemplateMetricWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappUploadAuthorizationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetChatappUploadAuthorizationResponse
         */
        public GetChatappUploadAuthorizationResponse GetChatappUploadAuthorizationWithOptions(GetChatappUploadAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatappUploadAuthorization",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappUploadAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappUploadAuthorizationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetChatappUploadAuthorizationResponse
         */
        public async Task<GetChatappUploadAuthorizationResponse> GetChatappUploadAuthorizationWithOptionsAsync(GetChatappUploadAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatappUploadAuthorization",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappUploadAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappUploadAuthorizationRequest
          * @return GetChatappUploadAuthorizationResponse
         */
        public GetChatappUploadAuthorizationResponse GetChatappUploadAuthorization(GetChatappUploadAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChatappUploadAuthorizationWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappUploadAuthorizationRequest
          * @return GetChatappUploadAuthorizationResponse
         */
        public async Task<GetChatappUploadAuthorizationResponse> GetChatappUploadAuthorizationAsync(GetChatappUploadAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChatappUploadAuthorizationWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappVerifyCodeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetChatappVerifyCodeResponse
         */
        public GetChatappVerifyCodeResponse GetChatappVerifyCodeWithOptions(GetChatappVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                body["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["Method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatappVerifyCode",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappVerifyCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappVerifyCodeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetChatappVerifyCodeResponse
         */
        public async Task<GetChatappVerifyCodeResponse> GetChatappVerifyCodeWithOptionsAsync(GetChatappVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                body["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["Method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatappVerifyCode",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatappVerifyCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappVerifyCodeRequest
          * @return GetChatappVerifyCodeResponse
         */
        public GetChatappVerifyCodeResponse GetChatappVerifyCode(GetChatappVerifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChatappVerifyCodeWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetChatappVerifyCodeRequest
          * @return GetChatappVerifyCodeResponse
         */
        public async Task<GetChatappVerifyCodeResponse> GetChatappVerifyCodeAsync(GetChatappVerifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChatappVerifyCodeWithOptionsAsync(request, runtime);
        }

        /**
          * The ID of the phone number.
          *
          * @param request GetMigrationVerifyCodeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMigrationVerifyCodeResponse
         */
        public GetMigrationVerifyCodeResponse GetMigrationVerifyCodeWithOptions(GetMigrationVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["Method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMigrationVerifyCode",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMigrationVerifyCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The ID of the phone number.
          *
          * @param request GetMigrationVerifyCodeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMigrationVerifyCodeResponse
         */
        public async Task<GetMigrationVerifyCodeResponse> GetMigrationVerifyCodeWithOptionsAsync(GetMigrationVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["Method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMigrationVerifyCode",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMigrationVerifyCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The ID of the phone number.
          *
          * @param request GetMigrationVerifyCodeRequest
          * @return GetMigrationVerifyCodeResponse
         */
        public GetMigrationVerifyCodeResponse GetMigrationVerifyCode(GetMigrationVerifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMigrationVerifyCodeWithOptions(request, runtime);
        }

        /**
          * The ID of the phone number.
          *
          * @param request GetMigrationVerifyCodeRequest
          * @return GetMigrationVerifyCodeResponse
         */
        public async Task<GetMigrationVerifyCodeResponse> GetMigrationVerifyCodeAsync(GetMigrationVerifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMigrationVerifyCodeWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetPhoneNumberVerificationStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPhoneNumberVerificationStatusResponse
         */
        public GetPhoneNumberVerificationStatusResponse GetPhoneNumberVerificationStatusWithOptions(GetPhoneNumberVerificationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhoneNumberVerificationStatus",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhoneNumberVerificationStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetPhoneNumberVerificationStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPhoneNumberVerificationStatusResponse
         */
        public async Task<GetPhoneNumberVerificationStatusResponse> GetPhoneNumberVerificationStatusWithOptionsAsync(GetPhoneNumberVerificationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhoneNumberVerificationStatus",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhoneNumberVerificationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetPhoneNumberVerificationStatusRequest
          * @return GetPhoneNumberVerificationStatusResponse
         */
        public GetPhoneNumberVerificationStatusResponse GetPhoneNumberVerificationStatus(GetPhoneNumberVerificationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhoneNumberVerificationStatusWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetPhoneNumberVerificationStatusRequest
          * @return GetPhoneNumberVerificationStatusResponse
         */
        public async Task<GetPhoneNumberVerificationStatusResponse> GetPhoneNumberVerificationStatusAsync(GetPhoneNumberVerificationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhoneNumberVerificationStatusWithOptionsAsync(request, runtime);
        }

        public GetPreValidatePhoneIdResponse GetPreValidatePhoneIdWithOptions(GetPreValidatePhoneIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                body["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPreValidatePhoneId",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPreValidatePhoneIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPreValidatePhoneIdResponse> GetPreValidatePhoneIdWithOptionsAsync(GetPreValidatePhoneIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                body["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPreValidatePhoneId",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPreValidatePhoneIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPreValidatePhoneIdResponse GetPreValidatePhoneId(GetPreValidatePhoneIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPreValidatePhoneIdWithOptions(request, runtime);
        }

        public async Task<GetPreValidatePhoneIdResponse> GetPreValidatePhoneIdAsync(GetPreValidatePhoneIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPreValidatePhoneIdWithOptionsAsync(request, runtime);
        }

        public GetWhatsappConnectionCatalogResponse GetWhatsappConnectionCatalogWithOptions(GetWhatsappConnectionCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WabaId))
            {
                query["WabaId"] = request.WabaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWhatsappConnectionCatalog",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWhatsappConnectionCatalogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWhatsappConnectionCatalogResponse> GetWhatsappConnectionCatalogWithOptionsAsync(GetWhatsappConnectionCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WabaId))
            {
                query["WabaId"] = request.WabaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWhatsappConnectionCatalog",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWhatsappConnectionCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWhatsappConnectionCatalogResponse GetWhatsappConnectionCatalog(GetWhatsappConnectionCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWhatsappConnectionCatalogWithOptions(request, runtime);
        }

        public async Task<GetWhatsappConnectionCatalogResponse> GetWhatsappConnectionCatalogAsync(GetWhatsappConnectionCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWhatsappConnectionCatalogWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request IsvGetAppIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return IsvGetAppIdResponse
         */
        public IsvGetAppIdResponse IsvGetAppIdWithOptions(IsvGetAppIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "IsvGetAppId",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsvGetAppIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request IsvGetAppIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return IsvGetAppIdResponse
         */
        public async Task<IsvGetAppIdResponse> IsvGetAppIdWithOptionsAsync(IsvGetAppIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "IsvGetAppId",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsvGetAppIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request IsvGetAppIdRequest
          * @return IsvGetAppIdResponse
         */
        public IsvGetAppIdResponse IsvGetAppId(IsvGetAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IsvGetAppIdWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request IsvGetAppIdRequest
          * @return IsvGetAppIdResponse
         */
        public async Task<IsvGetAppIdResponse> IsvGetAppIdAsync(IsvGetAppIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IsvGetAppIdWithOptionsAsync(request, runtime);
        }

        /**
          * ### QPS limit
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param tmpReq ListChatappTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListChatappTemplateResponse
         */
        public ListChatappTemplateResponse ListChatappTemplateWithOptions(ListChatappTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListChatappTemplateShrinkRequest request = new ListChatappTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                query["Page"] = request.PageShrink;
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
                Action = "ListChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatappTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### QPS limit
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param tmpReq ListChatappTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListChatappTemplateResponse
         */
        public async Task<ListChatappTemplateResponse> ListChatappTemplateWithOptionsAsync(ListChatappTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListChatappTemplateShrinkRequest request = new ListChatappTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                query["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                query["Page"] = request.PageShrink;
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
                Action = "ListChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatappTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### QPS limit
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ListChatappTemplateRequest
          * @return ListChatappTemplateResponse
         */
        public ListChatappTemplateResponse ListChatappTemplate(ListChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChatappTemplateWithOptions(request, runtime);
        }

        /**
          * ### QPS limit
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ListChatappTemplateRequest
          * @return ListChatappTemplateResponse
         */
        public async Task<ListChatappTemplateResponse> ListChatappTemplateAsync(ListChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChatappTemplateWithOptionsAsync(request, runtime);
        }

        public ListProductResponse ListProductWithOptions(ListProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.After))
            {
                query["After"] = request.After;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Before))
            {
                query["Before"] = request.Before;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                query["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WabaId))
            {
                query["WabaId"] = request.WabaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProduct",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductResponse> ListProductWithOptionsAsync(ListProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.After))
            {
                query["After"] = request.After;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Before))
            {
                query["Before"] = request.Before;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                query["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WabaId))
            {
                query["WabaId"] = request.WabaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProduct",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductResponse ListProduct(ListProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductWithOptions(request, runtime);
        }

        public async Task<ListProductResponse> ListProductAsync(ListProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductWithOptionsAsync(request, runtime);
        }

        public ListProductCatalogResponse ListProductCatalogWithOptions(ListProductCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.After))
            {
                query["After"] = request.After;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Before))
            {
                query["Before"] = request.Before;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["BusinessId"] = request.BusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                query["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
                Action = "ListProductCatalog",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductCatalogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductCatalogResponse> ListProductCatalogWithOptionsAsync(ListProductCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.After))
            {
                query["After"] = request.After;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Before))
            {
                query["Before"] = request.Before;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["BusinessId"] = request.BusinessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                query["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
                Action = "ListProductCatalog",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductCatalogResponse ListProductCatalog(ListProductCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductCatalogWithOptions(request, runtime);
        }

        public async Task<ListProductCatalogResponse> ListProductCatalogAsync(ListProductCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductCatalogWithOptionsAsync(request, runtime);
        }

        /**
          * The name of the message template.
          *
          * @param tmpReq ModifyChatappTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyChatappTemplateResponse
         */
        public ModifyChatappTemplateResponse ModifyChatappTemplateWithOptions(ModifyChatappTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyChatappTemplateShrinkRequest request = new ModifyChatappTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Example))
            {
                request.ExampleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Example, "Example", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                body["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExampleShrink))
            {
                body["Example"] = request.ExampleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSendTtlSeconds))
            {
                body["MessageSendTtlSeconds"] = request.MessageSendTtlSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyChatappTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The name of the message template.
          *
          * @param tmpReq ModifyChatappTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyChatappTemplateResponse
         */
        public async Task<ModifyChatappTemplateResponse> ModifyChatappTemplateWithOptionsAsync(ModifyChatappTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyChatappTemplateShrinkRequest request = new ModifyChatappTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Example))
            {
                request.ExampleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Example, "Example", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                body["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExampleShrink))
            {
                body["Example"] = request.ExampleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSendTtlSeconds))
            {
                body["MessageSendTtlSeconds"] = request.MessageSendTtlSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyChatappTemplate",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyChatappTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The name of the message template.
          *
          * @param request ModifyChatappTemplateRequest
          * @return ModifyChatappTemplateResponse
         */
        public ModifyChatappTemplateResponse ModifyChatappTemplate(ModifyChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyChatappTemplateWithOptions(request, runtime);
        }

        /**
          * The name of the message template.
          *
          * @param request ModifyChatappTemplateRequest
          * @return ModifyChatappTemplateResponse
         */
        public async Task<ModifyChatappTemplateResponse> ModifyChatappTemplateAsync(ModifyChatappTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyChatappTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * ModifyPhoneBusinessProfile
          *
          * @param tmpReq ModifyPhoneBusinessProfileRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyPhoneBusinessProfileResponse
         */
        public ModifyPhoneBusinessProfileResponse ModifyPhoneBusinessProfileWithOptions(ModifyPhoneBusinessProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPhoneBusinessProfileShrinkRequest request = new ModifyPhoneBusinessProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Websites))
            {
                request.WebsitesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Websites, "Websites", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfilePictureUrl))
            {
                query["ProfilePictureUrl"] = request.ProfilePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vertical))
            {
                query["Vertical"] = request.Vertical;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebsitesShrink))
            {
                query["Websites"] = request.WebsitesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPhoneBusinessProfile",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPhoneBusinessProfileResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ModifyPhoneBusinessProfile
          *
          * @param tmpReq ModifyPhoneBusinessProfileRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyPhoneBusinessProfileResponse
         */
        public async Task<ModifyPhoneBusinessProfileResponse> ModifyPhoneBusinessProfileWithOptionsAsync(ModifyPhoneBusinessProfileRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPhoneBusinessProfileShrinkRequest request = new ModifyPhoneBusinessProfileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Websites))
            {
                request.WebsitesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Websites, "Websites", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfilePictureUrl))
            {
                query["ProfilePictureUrl"] = request.ProfilePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vertical))
            {
                query["Vertical"] = request.Vertical;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebsitesShrink))
            {
                query["Websites"] = request.WebsitesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPhoneBusinessProfile",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPhoneBusinessProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ModifyPhoneBusinessProfile
          *
          * @param request ModifyPhoneBusinessProfileRequest
          * @return ModifyPhoneBusinessProfileResponse
         */
        public ModifyPhoneBusinessProfileResponse ModifyPhoneBusinessProfile(ModifyPhoneBusinessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPhoneBusinessProfileWithOptions(request, runtime);
        }

        /**
          * ModifyPhoneBusinessProfile
          *
          * @param request ModifyPhoneBusinessProfileRequest
          * @return ModifyPhoneBusinessProfileResponse
         */
        public async Task<ModifyPhoneBusinessProfileResponse> ModifyPhoneBusinessProfileAsync(ModifyPhoneBusinessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPhoneBusinessProfileWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryChatappBindWabaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryChatappBindWabaResponse
         */
        public QueryChatappBindWabaResponse QueryChatappBindWabaWithOptions(QueryChatappBindWabaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChatappBindWaba",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChatappBindWabaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryChatappBindWabaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryChatappBindWabaResponse
         */
        public async Task<QueryChatappBindWabaResponse> QueryChatappBindWabaWithOptionsAsync(QueryChatappBindWabaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChatappBindWaba",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChatappBindWabaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryChatappBindWabaRequest
          * @return QueryChatappBindWabaResponse
         */
        public QueryChatappBindWabaResponse QueryChatappBindWaba(QueryChatappBindWabaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryChatappBindWabaWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryChatappBindWabaRequest
          * @return QueryChatappBindWabaResponse
         */
        public async Task<QueryChatappBindWabaResponse> QueryChatappBindWabaAsync(QueryChatappBindWabaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryChatappBindWabaWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryChatappPhoneNumbersRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryChatappPhoneNumbersResponse
         */
        public QueryChatappPhoneNumbersResponse QueryChatappPhoneNumbersWithOptions(QueryChatappPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChatappPhoneNumbers",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChatappPhoneNumbersResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryChatappPhoneNumbersRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryChatappPhoneNumbersResponse
         */
        public async Task<QueryChatappPhoneNumbersResponse> QueryChatappPhoneNumbersWithOptionsAsync(QueryChatappPhoneNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                query["IsvCode"] = request.IsvCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChatappPhoneNumbers",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChatappPhoneNumbersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryChatappPhoneNumbersRequest
          * @return QueryChatappPhoneNumbersResponse
         */
        public QueryChatappPhoneNumbersResponse QueryChatappPhoneNumbers(QueryChatappPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryChatappPhoneNumbersWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryChatappPhoneNumbersRequest
          * @return QueryChatappPhoneNumbersResponse
         */
        public async Task<QueryChatappPhoneNumbersResponse> QueryChatappPhoneNumbersAsync(QueryChatappPhoneNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryChatappPhoneNumbersWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryPhoneBusinessProfileRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryPhoneBusinessProfileResponse
         */
        public QueryPhoneBusinessProfileResponse QueryPhoneBusinessProfileWithOptions(QueryPhoneBusinessProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPhoneBusinessProfile",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPhoneBusinessProfileResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryPhoneBusinessProfileRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryPhoneBusinessProfileResponse
         */
        public async Task<QueryPhoneBusinessProfileResponse> QueryPhoneBusinessProfileWithOptionsAsync(QueryPhoneBusinessProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPhoneBusinessProfile",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPhoneBusinessProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryPhoneBusinessProfileRequest
          * @return QueryPhoneBusinessProfileResponse
         */
        public QueryPhoneBusinessProfileResponse QueryPhoneBusinessProfile(QueryPhoneBusinessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPhoneBusinessProfileWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryPhoneBusinessProfileRequest
          * @return QueryPhoneBusinessProfileResponse
         */
        public async Task<QueryPhoneBusinessProfileResponse> QueryPhoneBusinessProfileAsync(QueryPhoneBusinessProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPhoneBusinessProfileWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryWabaBusinessInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryWabaBusinessInfoResponse
         */
        public QueryWabaBusinessInfoResponse QueryWabaBusinessInfoWithOptions(QueryWabaBusinessInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WabaId))
            {
                query["WabaId"] = request.WabaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWabaBusinessInfo",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWabaBusinessInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryWabaBusinessInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryWabaBusinessInfoResponse
         */
        public async Task<QueryWabaBusinessInfoResponse> QueryWabaBusinessInfoWithOptionsAsync(QueryWabaBusinessInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WabaId))
            {
                query["WabaId"] = request.WabaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWabaBusinessInfo",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWabaBusinessInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryWabaBusinessInfoRequest
          * @return QueryWabaBusinessInfoResponse
         */
        public QueryWabaBusinessInfoResponse QueryWabaBusinessInfo(QueryWabaBusinessInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWabaBusinessInfoWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request QueryWabaBusinessInfoRequest
          * @return QueryWabaBusinessInfoResponse
         */
        public async Task<QueryWabaBusinessInfoResponse> QueryWabaBusinessInfoAsync(QueryWabaBusinessInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWabaBusinessInfoWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          * You can send messages to up to 1,000 phone numbers in a single request.
          *
          * @param tmpReq SendChatappMassMessageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SendChatappMassMessageResponse
         */
        public SendChatappMassMessageResponse SendChatappMassMessageWithOptions(SendChatappMassMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatappMassMessageShrinkRequest request = new SendChatappMassMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SenderList))
            {
                request.SenderListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SenderList, "SenderList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackContent))
            {
                body["FallBackContent"] = request.FallBackContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackDuration))
            {
                body["FallBackDuration"] = request.FallBackDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackId))
            {
                body["FallBackId"] = request.FallBackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackRule))
            {
                body["FallBackRule"] = request.FallBackRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderListShrink))
            {
                body["SenderList"] = request.SenderListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatappMassMessage",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatappMassMessageResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          * You can send messages to up to 1,000 phone numbers in a single request.
          *
          * @param tmpReq SendChatappMassMessageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SendChatappMassMessageResponse
         */
        public async Task<SendChatappMassMessageResponse> SendChatappMassMessageWithOptionsAsync(SendChatappMassMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatappMassMessageShrinkRequest request = new SendChatappMassMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SenderList))
            {
                request.SenderListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SenderList, "SenderList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackContent))
            {
                body["FallBackContent"] = request.FallBackContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackDuration))
            {
                body["FallBackDuration"] = request.FallBackDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackId))
            {
                body["FallBackId"] = request.FallBackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackRule))
            {
                body["FallBackRule"] = request.FallBackRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderListShrink))
            {
                body["SenderList"] = request.SenderListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatappMassMessage",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatappMassMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          * You can send messages to up to 1,000 phone numbers in a single request.
          *
          * @param request SendChatappMassMessageRequest
          * @return SendChatappMassMessageResponse
         */
        public SendChatappMassMessageResponse SendChatappMassMessage(SendChatappMassMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendChatappMassMessageWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          * You can send messages to up to 1,000 phone numbers in a single request.
          *
          * @param request SendChatappMassMessageRequest
          * @return SendChatappMassMessageResponse
         */
        public async Task<SendChatappMassMessageResponse> SendChatappMassMessageAsync(SendChatappMassMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendChatappMassMessageWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param tmpReq SendChatappMessageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SendChatappMessageResponse
         */
        public SendChatappMessageResponse SendChatappMessageWithOptions(SendChatappMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatappMessageShrinkRequest request = new SendChatappMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProductAction))
            {
                request.ProductActionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProductAction, "ProductAction", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateParams))
            {
                request.TemplateParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateParams, "TemplateParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextMessageId))
            {
                body["ContextMessageId"] = request.ContextMessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackContent))
            {
                body["FallBackContent"] = request.FallBackContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackDuration))
            {
                body["FallBackDuration"] = request.FallBackDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackId))
            {
                body["FallBackId"] = request.FallBackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackRule))
            {
                body["FallBackRule"] = request.FallBackRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductActionShrink))
            {
                body["ProductAction"] = request.ProductActionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParamsShrink))
            {
                body["TemplateParams"] = request.TemplateParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrackingData))
            {
                body["TrackingData"] = request.TrackingData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatappMessage",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatappMessageResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param tmpReq SendChatappMessageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SendChatappMessageResponse
         */
        public async Task<SendChatappMessageResponse> SendChatappMessageWithOptionsAsync(SendChatappMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatappMessageShrinkRequest request = new SendChatappMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProductAction))
            {
                request.ProductActionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProductAction, "ProductAction", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateParams))
            {
                request.TemplateParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateParams, "TemplateParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextMessageId))
            {
                body["ContextMessageId"] = request.ContextMessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustWabaId))
            {
                body["CustWabaId"] = request.CustWabaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackContent))
            {
                body["FallBackContent"] = request.FallBackContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackDuration))
            {
                body["FallBackDuration"] = request.FallBackDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackId))
            {
                body["FallBackId"] = request.FallBackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallBackRule))
            {
                body["FallBackRule"] = request.FallBackRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCode))
            {
                body["IsvCode"] = request.IsvCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductActionShrink))
            {
                body["ProductAction"] = request.ProductActionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParamsShrink))
            {
                body["TemplateParams"] = request.TemplateParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrackingData))
            {
                body["TrackingData"] = request.TrackingData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatappMessage",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatappMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request SendChatappMessageRequest
          * @return SendChatappMessageResponse
         */
        public SendChatappMessageResponse SendChatappMessage(SendChatappMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendChatappMessageWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request SendChatappMessageRequest
          * @return SendChatappMessageResponse
         */
        public async Task<SendChatappMessageResponse> SendChatappMessageAsync(SendChatappMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendChatappMessageWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request SubmitIsvCustomerTermsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitIsvCustomerTermsResponse
         */
        public SubmitIsvCustomerTermsResponse SubmitIsvCustomerTermsWithOptions(SubmitIsvCustomerTermsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessDesc))
            {
                query["BusinessDesc"] = request.BusinessDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactMail))
            {
                query["ContactMail"] = request.ContactMail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryId))
            {
                query["CountryId"] = request.CountryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustName))
            {
                query["CustName"] = request.CustName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvTerms))
            {
                query["IsvTerms"] = request.IsvTerms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeAddress))
            {
                query["OfficeAddress"] = request.OfficeAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIsvCustomerTerms",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIsvCustomerTermsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request SubmitIsvCustomerTermsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitIsvCustomerTermsResponse
         */
        public async Task<SubmitIsvCustomerTermsResponse> SubmitIsvCustomerTermsWithOptionsAsync(SubmitIsvCustomerTermsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessDesc))
            {
                query["BusinessDesc"] = request.BusinessDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactMail))
            {
                query["ContactMail"] = request.ContactMail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryId))
            {
                query["CountryId"] = request.CountryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustName))
            {
                query["CustName"] = request.CustName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvTerms))
            {
                query["IsvTerms"] = request.IsvTerms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeAddress))
            {
                query["OfficeAddress"] = request.OfficeAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIsvCustomerTerms",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIsvCustomerTermsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request SubmitIsvCustomerTermsRequest
          * @return SubmitIsvCustomerTermsResponse
         */
        public SubmitIsvCustomerTermsResponse SubmitIsvCustomerTerms(SubmitIsvCustomerTermsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitIsvCustomerTermsWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request SubmitIsvCustomerTermsRequest
          * @return SubmitIsvCustomerTermsResponse
         */
        public async Task<SubmitIsvCustomerTermsResponse> SubmitIsvCustomerTermsAsync(SubmitIsvCustomerTermsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitIsvCustomerTermsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request UpdateAccountWebhookRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAccountWebhookResponse
         */
        public UpdateAccountWebhookResponse UpdateAccountWebhookWithOptions(UpdateAccountWebhookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpFlag))
            {
                query["HttpFlag"] = request.HttpFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueFlag))
            {
                query["QueueFlag"] = request.QueueFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusCallbackUrl))
            {
                query["StatusCallbackUrl"] = request.StatusCallbackUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccountWebhook",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountWebhookResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request UpdateAccountWebhookRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAccountWebhookResponse
         */
        public async Task<UpdateAccountWebhookResponse> UpdateAccountWebhookWithOptionsAsync(UpdateAccountWebhookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpFlag))
            {
                query["HttpFlag"] = request.HttpFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueFlag))
            {
                query["QueueFlag"] = request.QueueFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusCallbackUrl))
            {
                query["StatusCallbackUrl"] = request.StatusCallbackUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccountWebhook",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccountWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request UpdateAccountWebhookRequest
          * @return UpdateAccountWebhookResponse
         */
        public UpdateAccountWebhookResponse UpdateAccountWebhook(UpdateAccountWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccountWebhookWithOptions(request, runtime);
        }

        /**
          * You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request UpdateAccountWebhookRequest
          * @return UpdateAccountWebhookResponse
         */
        public async Task<UpdateAccountWebhookResponse> UpdateAccountWebhookAsync(UpdateAccountWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccountWebhookWithOptionsAsync(request, runtime);
        }

        /**
          * The error message returned.
          *
          * @param request UpdatePhoneWebhookRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdatePhoneWebhookResponse
         */
        public UpdatePhoneWebhookResponse UpdatePhoneWebhookWithOptions(UpdatePhoneWebhookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpFlag))
            {
                query["HttpFlag"] = request.HttpFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueFlag))
            {
                query["QueueFlag"] = request.QueueFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusCallbackUrl))
            {
                query["StatusCallbackUrl"] = request.StatusCallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpCallbackUrl))
            {
                query["UpCallbackUrl"] = request.UpCallbackUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePhoneWebhook",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePhoneWebhookResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The error message returned.
          *
          * @param request UpdatePhoneWebhookRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdatePhoneWebhookResponse
         */
        public async Task<UpdatePhoneWebhookResponse> UpdatePhoneWebhookWithOptionsAsync(UpdatePhoneWebhookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpFlag))
            {
                query["HttpFlag"] = request.HttpFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueFlag))
            {
                query["QueueFlag"] = request.QueueFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusCallbackUrl))
            {
                query["StatusCallbackUrl"] = request.StatusCallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpCallbackUrl))
            {
                query["UpCallbackUrl"] = request.UpCallbackUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePhoneWebhook",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePhoneWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The error message returned.
          *
          * @param request UpdatePhoneWebhookRequest
          * @return UpdatePhoneWebhookResponse
         */
        public UpdatePhoneWebhookResponse UpdatePhoneWebhook(UpdatePhoneWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePhoneWebhookWithOptions(request, runtime);
        }

        /**
          * The error message returned.
          *
          * @param request UpdatePhoneWebhookRequest
          * @return UpdatePhoneWebhookResponse
         */
        public async Task<UpdatePhoneWebhookResponse> UpdatePhoneWebhookAsync(UpdatePhoneWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePhoneWebhookWithOptionsAsync(request, runtime);
        }

    }
}
