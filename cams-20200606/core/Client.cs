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

        /**
         * @summary Adds a phone number for a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddChatappPhoneNumberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddChatappPhoneNumberResponse
         */
        public AddChatappPhoneNumberResponse AddChatappPhoneNumberWithOptions(AddChatappPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cc))
            {
                query["Cc"] = request.Cc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreValidateId))
            {
                query["PreValidateId"] = request.PreValidateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifiedName))
            {
                query["VerifiedName"] = request.VerifiedName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary Adds a phone number for a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddChatappPhoneNumberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddChatappPhoneNumberResponse
         */
        public async Task<AddChatappPhoneNumberResponse> AddChatappPhoneNumberWithOptionsAsync(AddChatappPhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cc))
            {
                query["Cc"] = request.Cc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreValidateId))
            {
                query["PreValidateId"] = request.PreValidateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifiedName))
            {
                query["VerifiedName"] = request.VerifiedName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @summary Adds a phone number for a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddChatappPhoneNumberRequest
         * @return AddChatappPhoneNumberResponse
         */
        public AddChatappPhoneNumberResponse AddChatappPhoneNumber(AddChatappPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddChatappPhoneNumberWithOptions(request, runtime);
        }

        /**
         * @summary Adds a phone number for a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request AddChatappPhoneNumberRequest
         * @return AddChatappPhoneNumberResponse
         */
        public async Task<AddChatappPhoneNumberResponse> AddChatappPhoneNumberAsync(AddChatappPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddChatappPhoneNumberWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Associates FAQs in the knowledge base.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Associates FAQs in the knowledge base.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Associates FAQs in the knowledge base.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Associates FAQs in the knowledge base.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Conducts sessions with the bot based on its unique identifier (ID).
         *
         * @description You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Conducts sessions with the bot based on its unique identifier (ID).
         *
         * @description You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Conducts sessions with the bot based on its unique identifier (ID).
         *
         * @description You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Conducts sessions with the bot based on its unique identifier (ID).
         *
         * @description You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Binds the WhatsApp Business account with ChatApp.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappBindWabaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatappBindWabaResponse
         */
        public ChatappBindWabaResponse ChatappBindWabaWithOptions(ChatappBindWabaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
         * @summary Binds the WhatsApp Business account with ChatApp.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappBindWabaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatappBindWabaResponse
         */
        public async Task<ChatappBindWabaResponse> ChatappBindWabaWithOptionsAsync(ChatappBindWabaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
         * @summary Binds the WhatsApp Business account with ChatApp.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Binds the WhatsApp Business account with ChatApp.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries WhatsApp Business account (WABA) information after embedded signup. You do not need to call this API operation if you use Version 2 of WhatsApp embedded signup.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries WhatsApp Business account (WABA) information after embedded signup. You do not need to call this API operation if you use Version 2 of WhatsApp embedded signup.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries WhatsApp Business account (WABA) information after embedded signup. You do not need to call this API operation if you use Version 2 of WhatsApp embedded signup.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries WhatsApp Business account (WABA) information after embedded signup. You do not need to call this API operation if you use Version 2 of WhatsApp embedded signup.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Registers a phone number for migration.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Registers a phone number for migration.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Registers a phone number for migration.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Registers a phone number for migration.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Verifies a specified phone number for migration.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Verifies a specified phone number for migration.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Verifies a specified phone number for migration.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Verifies a specified phone number for migration.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappMigrationVerifiedRequest
         * @return ChatappMigrationVerifiedResponse
         */
        public async Task<ChatappMigrationVerifiedResponse> ChatappMigrationVerifiedAsync(ChatappMigrationVerifiedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatappMigrationVerifiedWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deregisters a phone number from a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappPhoneNumberDeregisterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatappPhoneNumberDeregisterResponse
         */
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

        /**
         * @summary Deregisters a phone number from a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappPhoneNumberDeregisterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatappPhoneNumberDeregisterResponse
         */
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

        /**
         * @summary Deregisters a phone number from a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappPhoneNumberDeregisterRequest
         * @return ChatappPhoneNumberDeregisterResponse
         */
        public ChatappPhoneNumberDeregisterResponse ChatappPhoneNumberDeregister(ChatappPhoneNumberDeregisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatappPhoneNumberDeregisterWithOptions(request, runtime);
        }

        /**
         * @summary Deregisters a phone number from a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappPhoneNumberDeregisterRequest
         * @return ChatappPhoneNumberDeregisterResponse
         */
        public async Task<ChatappPhoneNumberDeregisterResponse> ChatappPhoneNumberDeregisterAsync(ChatappPhoneNumberDeregisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatappPhoneNumberDeregisterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Registers a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappPhoneNumberRegisterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatappPhoneNumberRegisterResponse
         */
        public ChatappPhoneNumberRegisterResponse ChatappPhoneNumberRegisterWithOptions(ChatappPhoneNumberRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
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
         * @summary Registers a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappPhoneNumberRegisterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatappPhoneNumberRegisterResponse
         */
        public async Task<ChatappPhoneNumberRegisterResponse> ChatappPhoneNumberRegisterWithOptionsAsync(ChatappPhoneNumberRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
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
         * @summary Registers a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Registers a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Synchronizes phone numbers.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Synchronizes phone numbers.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Synchronizes phone numbers.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Synchronizes phone numbers.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Associates a phone number with a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappVerifyAndRegisterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatappVerifyAndRegisterResponse
         */
        public ChatappVerifyAndRegisterResponse ChatappVerifyAndRegisterWithOptions(ChatappVerifyAndRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
         * @summary Associates a phone number with a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ChatappVerifyAndRegisterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatappVerifyAndRegisterResponse
         */
        public async Task<ChatappVerifyAndRegisterResponse> ChatappVerifyAndRegisterWithOptionsAsync(ChatappVerifyAndRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
         * @summary Associates a phone number with a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Associates a phone number with a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary The ID of the number.
         *
         * @description The status of the phone number.
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
         * @summary The ID of the number.
         *
         * @description The status of the phone number.
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
         * @summary The ID of the number.
         *
         * @description The status of the phone number.
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
         * @summary The ID of the number.
         *
         * @description The status of the phone number.
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
         * @summary The HTTP status code.
         * \\\\*   Example: OK. This parameter indicates that the request is successful.
         * \\\\*   Other values indicate that the request fails. For more information, see \\[Error codes]\\\\(https://www.alibabacloud.com/help/zh/cams/latest/api-error-codes).
         *
         * @description The error message.
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
         * @summary The HTTP status code.
         * \\\\*   Example: OK. This parameter indicates that the request is successful.
         * \\\\*   Other values indicate that the request fails. For more information, see \\[Error codes]\\\\(https://www.alibabacloud.com/help/zh/cams/latest/api-error-codes).
         *
         * @description The error message.
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
         * @summary The HTTP status code.
         * \\\\*   Example: OK. This parameter indicates that the request is successful.
         * \\\\*   Other values indicate that the request fails. For more information, see \\[Error codes]\\\\(https://www.alibabacloud.com/help/zh/cams/latest/api-error-codes).
         *
         * @description The error message.
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
         * @summary The HTTP status code.
         * \\\\*   Example: OK. This parameter indicates that the request is successful.
         * \\\\*   Other values indicate that the request fails. For more information, see \\[Error codes]\\\\(https://www.alibabacloud.com/help/zh/cams/latest/api-error-codes).
         *
         * @description The error message.
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
         * @summary Creates a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param tmpReq CreateFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFlowResponse
         */
        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFlowShrinkRequest request = new CreateFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Categories))
            {
                request.CategoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Categories, "Categories", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoriesShrink))
            {
                body["Categories"] = request.CategoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param tmpReq CreateFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFlowResponse
         */
        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFlowShrinkRequest request = new CreateFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Categories))
            {
                request.CategoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Categories, "Categories", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoriesShrink))
            {
                body["Categories"] = request.CategoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateFlowRequest
         * @return CreateFlowResponse
         */
        public CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowWithOptions(request, runtime);
        }

        /**
         * @summary Creates a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateFlowRequest
         * @return CreateFlowResponse
         */
        public async Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建消息发送二维码
         *
         * @param request CreatePhoneMessageQrdlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePhoneMessageQrdlResponse
         */
        public CreatePhoneMessageQrdlResponse CreatePhoneMessageQrdlWithOptions(CreatePhoneMessageQrdlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateQrImage))
            {
                body["GenerateQrImage"] = request.GenerateQrImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefilledMessage))
            {
                body["PrefilledMessage"] = request.PrefilledMessage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePhoneMessageQrdl",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePhoneMessageQrdlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建消息发送二维码
         *
         * @param request CreatePhoneMessageQrdlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePhoneMessageQrdlResponse
         */
        public async Task<CreatePhoneMessageQrdlResponse> CreatePhoneMessageQrdlWithOptionsAsync(CreatePhoneMessageQrdlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateQrImage))
            {
                body["GenerateQrImage"] = request.GenerateQrImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefilledMessage))
            {
                body["PrefilledMessage"] = request.PrefilledMessage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePhoneMessageQrdl",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePhoneMessageQrdlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建消息发送二维码
         *
         * @param request CreatePhoneMessageQrdlRequest
         * @return CreatePhoneMessageQrdlResponse
         */
        public CreatePhoneMessageQrdlResponse CreatePhoneMessageQrdl(CreatePhoneMessageQrdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePhoneMessageQrdlWithOptions(request, runtime);
        }

        /**
         * @summary 创建消息发送二维码
         *
         * @param request CreatePhoneMessageQrdlRequest
         * @return CreatePhoneMessageQrdlResponse
         */
        public async Task<CreatePhoneMessageQrdlResponse> CreatePhoneMessageQrdlAsync(CreatePhoneMessageQrdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePhoneMessageQrdlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a message template.
         *
         * @description ### QPS limit
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
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
         * @summary Deletes a message template.
         *
         * @description ### QPS limit
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
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
         * @summary Deletes a message template.
         *
         * @description ### QPS limit
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
         * @summary Deletes a message template.
         *
         * @description ### QPS limit
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

        /**
         * @summary Deletes a Flow. Only Flows in the DRAFT state can be deleted.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFlowResponse
         */
        public DeleteFlowResponse DeleteFlowWithOptions(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a Flow. Only Flows in the DRAFT state can be deleted.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFlowResponse
         */
        public async Task<DeleteFlowResponse> DeleteFlowWithOptionsAsync(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a Flow. Only Flows in the DRAFT state can be deleted.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteFlowRequest
         * @return DeleteFlowResponse
         */
        public DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a Flow. Only Flows in the DRAFT state can be deleted.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteFlowRequest
         * @return DeleteFlowResponse
         */
        public async Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除消息发送二维码
         *
         * @param request DeletePhoneMessageQrdlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePhoneMessageQrdlResponse
         */
        public DeletePhoneMessageQrdlResponse DeletePhoneMessageQrdlWithOptions(DeletePhoneMessageQrdlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QrdlCode))
            {
                body["QrdlCode"] = request.QrdlCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePhoneMessageQrdl",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePhoneMessageQrdlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除消息发送二维码
         *
         * @param request DeletePhoneMessageQrdlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePhoneMessageQrdlResponse
         */
        public async Task<DeletePhoneMessageQrdlResponse> DeletePhoneMessageQrdlWithOptionsAsync(DeletePhoneMessageQrdlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QrdlCode))
            {
                body["QrdlCode"] = request.QrdlCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePhoneMessageQrdl",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePhoneMessageQrdlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除消息发送二维码
         *
         * @param request DeletePhoneMessageQrdlRequest
         * @return DeletePhoneMessageQrdlResponse
         */
        public DeletePhoneMessageQrdlResponse DeletePhoneMessageQrdl(DeletePhoneMessageQrdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePhoneMessageQrdlWithOptions(request, runtime);
        }

        /**
         * @summary 删除消息发送二维码
         *
         * @param request DeletePhoneMessageQrdlRequest
         * @return DeletePhoneMessageQrdlResponse
         */
        public async Task<DeletePhoneMessageQrdlResponse> DeletePhoneMessageQrdlAsync(DeletePhoneMessageQrdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePhoneMessageQrdlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 弃用Flow
         *
         * @param request DeprecateFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeprecateFlowResponse
         */
        public DeprecateFlowResponse DeprecateFlowWithOptions(DeprecateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeprecateFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeprecateFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 弃用Flow
         *
         * @param request DeprecateFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeprecateFlowResponse
         */
        public async Task<DeprecateFlowResponse> DeprecateFlowWithOptionsAsync(DeprecateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeprecateFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeprecateFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 弃用Flow
         *
         * @param request DeprecateFlowRequest
         * @return DeprecateFlowResponse
         */
        public DeprecateFlowResponse DeprecateFlow(DeprecateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeprecateFlowWithOptions(request, runtime);
        }

        /**
         * @summary 弃用Flow
         *
         * @param request DeprecateFlowRequest
         * @return DeprecateFlowResponse
         */
        public async Task<DeprecateFlowResponse> DeprecateFlowAsync(DeprecateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeprecateFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables the statistics on the metrics that are related to WhatsApp.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request EnableWhatsappROIMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableWhatsappROIMetricResponse
         */
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

        /**
         * @summary Enables the statistics on the metrics that are related to WhatsApp.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request EnableWhatsappROIMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableWhatsappROIMetricResponse
         */
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

        /**
         * @summary Enables the statistics on the metrics that are related to WhatsApp.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request EnableWhatsappROIMetricRequest
         * @return EnableWhatsappROIMetricResponse
         */
        public EnableWhatsappROIMetricResponse EnableWhatsappROIMetric(EnableWhatsappROIMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableWhatsappROIMetricWithOptions(request, runtime);
        }

        /**
         * @summary Enables the statistics on the metrics that are related to WhatsApp.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request EnableWhatsappROIMetricRequest
         * @return EnableWhatsappROIMetricResponse
         */
        public async Task<EnableWhatsappROIMetricResponse> EnableWhatsappROIMetricAsync(EnableWhatsappROIMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableWhatsappROIMetricWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the number of messages that are sent by using a phone number by a specific metric.
         *
         * @description You can call this operation up to 50 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetChatappPhoneNumberMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChatappPhoneNumberMetricResponse
         */
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

        /**
         * @summary Queries the number of messages that are sent by using a phone number by a specific metric.
         *
         * @description You can call this operation up to 50 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetChatappPhoneNumberMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChatappPhoneNumberMetricResponse
         */
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

        /**
         * @summary Queries the number of messages that are sent by using a phone number by a specific metric.
         *
         * @description You can call this operation up to 50 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetChatappPhoneNumberMetricRequest
         * @return GetChatappPhoneNumberMetricResponse
         */
        public GetChatappPhoneNumberMetricResponse GetChatappPhoneNumberMetric(GetChatappPhoneNumberMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChatappPhoneNumberMetricWithOptions(request, runtime);
        }

        /**
         * @summary Queries the number of messages that are sent by using a phone number by a specific metric.
         *
         * @description You can call this operation up to 50 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetChatappPhoneNumberMetricRequest
         * @return GetChatappPhoneNumberMetricResponse
         */
        public async Task<GetChatappPhoneNumberMetricResponse> GetChatappPhoneNumberMetricAsync(GetChatappPhoneNumberMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChatappPhoneNumberMetricWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of a message template.
         *
         * @description ### QPS limit
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
         * @summary Queries the information of a message template.
         *
         * @description ### QPS limit
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
         * @summary Queries the information of a message template.
         *
         * @description ### QPS limit
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
         * @summary Queries the information of a message template.
         *
         * @description ### QPS limit
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

        /**
         * @summary Queries the metrics about a marketing template.
         *
         * @description You can call this operation up to 50 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetChatappTemplateMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChatappTemplateMetricResponse
         */
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

        /**
         * @summary Queries the metrics about a marketing template.
         *
         * @description You can call this operation up to 50 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetChatappTemplateMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChatappTemplateMetricResponse
         */
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

        /**
         * @summary Queries the metrics about a marketing template.
         *
         * @description You can call this operation up to 50 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetChatappTemplateMetricRequest
         * @return GetChatappTemplateMetricResponse
         */
        public GetChatappTemplateMetricResponse GetChatappTemplateMetric(GetChatappTemplateMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChatappTemplateMetricWithOptions(request, runtime);
        }

        /**
         * @summary Queries the metrics about a marketing template.
         *
         * @description You can call this operation up to 50 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetChatappTemplateMetricRequest
         * @return GetChatappTemplateMetricResponse
         */
        public async Task<GetChatappTemplateMetricResponse> GetChatappTemplateMetricAsync(GetChatappTemplateMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChatappTemplateMetricWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the authentication information that is used to upload a file.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Obtains the authentication information that is used to upload a file.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Obtains the authentication information that is used to upload a file.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Obtains the authentication information that is used to upload a file.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Obtains a verification code.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetChatappVerifyCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChatappVerifyCodeResponse
         */
        public GetChatappVerifyCodeResponse GetChatappVerifyCodeWithOptions(GetChatappVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
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
         * @summary Obtains a verification code.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetChatappVerifyCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChatappVerifyCodeResponse
         */
        public async Task<GetChatappVerifyCodeResponse> GetChatappVerifyCodeWithOptionsAsync(GetChatappVerifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
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
         * @summary Obtains a verification code.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Obtains a verification code.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries the business settings of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetCommerceSettingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCommerceSettingResponse
         */
        public GetCommerceSettingResponse GetCommerceSettingWithOptions(GetCommerceSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
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
                Action = "GetCommerceSetting",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCommerceSettingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the business settings of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetCommerceSettingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCommerceSettingResponse
         */
        public async Task<GetCommerceSettingResponse> GetCommerceSettingWithOptionsAsync(GetCommerceSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
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
                Action = "GetCommerceSetting",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCommerceSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the business settings of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetCommerceSettingRequest
         * @return GetCommerceSettingResponse
         */
        public GetCommerceSettingResponse GetCommerceSetting(GetCommerceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCommerceSettingWithOptions(request, runtime);
        }

        /**
         * @summary Queries the business settings of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetCommerceSettingRequest
         * @return GetCommerceSettingResponse
         */
        public async Task<GetCommerceSettingResponse> GetCommerceSettingAsync(GetCommerceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCommerceSettingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowResponse
         */
        public GetFlowResponse GetFlowWithOptions(GetFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowResponse
         */
        public async Task<GetFlowResponse> GetFlowWithOptionsAsync(GetFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetFlowRequest
         * @return GetFlowResponse
         */
        public GetFlowResponse GetFlow(GetFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFlowWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetFlowRequest
         * @return GetFlowResponse
         */
        public async Task<GetFlowResponse> GetFlowAsync(GetFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取flow的JSON文件
         *
         * @param request GetFlowJSONAssestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowJSONAssestResponse
         */
        public GetFlowJSONAssestResponse GetFlowJSONAssestWithOptions(GetFlowJSONAssestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowJSONAssest",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowJSONAssestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取flow的JSON文件
         *
         * @param request GetFlowJSONAssestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowJSONAssestResponse
         */
        public async Task<GetFlowJSONAssestResponse> GetFlowJSONAssestWithOptionsAsync(GetFlowJSONAssestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowJSONAssest",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowJSONAssestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取flow的JSON文件
         *
         * @param request GetFlowJSONAssestRequest
         * @return GetFlowJSONAssestResponse
         */
        public GetFlowJSONAssestResponse GetFlowJSONAssest(GetFlowJSONAssestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFlowJSONAssestWithOptions(request, runtime);
        }

        /**
         * @summary 获取flow的JSON文件
         *
         * @param request GetFlowJSONAssestRequest
         * @return GetFlowJSONAssestResponse
         */
        public async Task<GetFlowJSONAssestResponse> GetFlowJSONAssestAsync(GetFlowJSONAssestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFlowJSONAssestWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the preview URL of a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetFlowPreviewUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowPreviewUrlResponse
         */
        public GetFlowPreviewUrlResponse GetFlowPreviewUrlWithOptions(GetFlowPreviewUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowPreviewUrl",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowPreviewUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the preview URL of a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetFlowPreviewUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowPreviewUrlResponse
         */
        public async Task<GetFlowPreviewUrlResponse> GetFlowPreviewUrlWithOptionsAsync(GetFlowPreviewUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowPreviewUrl",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowPreviewUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the preview URL of a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetFlowPreviewUrlRequest
         * @return GetFlowPreviewUrlResponse
         */
        public GetFlowPreviewUrlResponse GetFlowPreviewUrl(GetFlowPreviewUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFlowPreviewUrlWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the preview URL of a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetFlowPreviewUrlRequest
         * @return GetFlowPreviewUrlResponse
         */
        public async Task<GetFlowPreviewUrlResponse> GetFlowPreviewUrlAsync(GetFlowPreviewUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFlowPreviewUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The phone number.
         *
         * @description The ID of the phone number.
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
         * @summary The phone number.
         *
         * @description The ID of the phone number.
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
         * @summary The phone number.
         *
         * @description The ID of the phone number.
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
         * @summary The phone number.
         *
         * @description The ID of the phone number.
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
         * @summary 根据Code获取权限
         *
         * @param tmpReq GetPermissionByCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPermissionByCodeResponse
         */
        public GetPermissionByCodeResponse GetPermissionByCodeWithOptions(GetPermissionByCodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPermissionByCodeShrinkRequest request = new GetPermissionByCodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Permissions))
            {
                request.PermissionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Permissions, "Permissions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionsShrink))
            {
                body["Permissions"] = request.PermissionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPermissionByCode",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionByCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据Code获取权限
         *
         * @param tmpReq GetPermissionByCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPermissionByCodeResponse
         */
        public async Task<GetPermissionByCodeResponse> GetPermissionByCodeWithOptionsAsync(GetPermissionByCodeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPermissionByCodeShrinkRequest request = new GetPermissionByCodeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Permissions))
            {
                request.PermissionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Permissions, "Permissions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionsShrink))
            {
                body["Permissions"] = request.PermissionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPermissionByCode",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionByCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据Code获取权限
         *
         * @param request GetPermissionByCodeRequest
         * @return GetPermissionByCodeResponse
         */
        public GetPermissionByCodeResponse GetPermissionByCode(GetPermissionByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPermissionByCodeWithOptions(request, runtime);
        }

        /**
         * @summary 根据Code获取权限
         *
         * @param request GetPermissionByCodeRequest
         * @return GetPermissionByCodeResponse
         */
        public async Task<GetPermissionByCodeResponse> GetPermissionByCodeAsync(GetPermissionByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPermissionByCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取号码的公钥
         *
         * @param request GetPhoneEncryptionPublicKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPhoneEncryptionPublicKeyResponse
         */
        public GetPhoneEncryptionPublicKeyResponse GetPhoneEncryptionPublicKeyWithOptions(GetPhoneEncryptionPublicKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPhoneEncryptionPublicKey",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhoneEncryptionPublicKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取号码的公钥
         *
         * @param request GetPhoneEncryptionPublicKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPhoneEncryptionPublicKeyResponse
         */
        public async Task<GetPhoneEncryptionPublicKeyResponse> GetPhoneEncryptionPublicKeyWithOptionsAsync(GetPhoneEncryptionPublicKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPhoneEncryptionPublicKey",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhoneEncryptionPublicKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取号码的公钥
         *
         * @param request GetPhoneEncryptionPublicKeyRequest
         * @return GetPhoneEncryptionPublicKeyResponse
         */
        public GetPhoneEncryptionPublicKeyResponse GetPhoneEncryptionPublicKey(GetPhoneEncryptionPublicKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPhoneEncryptionPublicKeyWithOptions(request, runtime);
        }

        /**
         * @summary 获取号码的公钥
         *
         * @param request GetPhoneEncryptionPublicKeyRequest
         * @return GetPhoneEncryptionPublicKeyResponse
         */
        public async Task<GetPhoneEncryptionPublicKeyResponse> GetPhoneEncryptionPublicKeyAsync(GetPhoneEncryptionPublicKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhoneEncryptionPublicKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the verification status of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Obtains the verification status of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Obtains the verification status of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Obtains the verification status of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetPhoneNumberVerificationStatusRequest
         * @return GetPhoneNumberVerificationStatusResponse
         */
        public async Task<GetPhoneNumberVerificationStatusResponse> GetPhoneNumberVerificationStatusAsync(GetPhoneNumberVerificationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPhoneNumberVerificationStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the ID of a pre-registered phone number used for embedded signup without the need to re-obtain a verification code.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetPreValidatePhoneIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPreValidatePhoneIdResponse
         */
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

        /**
         * @summary Obtains the ID of a pre-registered phone number used for embedded signup without the need to re-obtain a verification code.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetPreValidatePhoneIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPreValidatePhoneIdResponse
         */
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

        /**
         * @summary Obtains the ID of a pre-registered phone number used for embedded signup without the need to re-obtain a verification code.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetPreValidatePhoneIdRequest
         * @return GetPreValidatePhoneIdResponse
         */
        public GetPreValidatePhoneIdResponse GetPreValidatePhoneId(GetPreValidatePhoneIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPreValidatePhoneIdWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the ID of a pre-registered phone number used for embedded signup without the need to re-obtain a verification code.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetPreValidatePhoneIdRequest
         * @return GetPreValidatePhoneIdResponse
         */
        public async Task<GetPreValidatePhoneIdResponse> GetPreValidatePhoneIdAsync(GetPreValidatePhoneIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPreValidatePhoneIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the product catalogs that are associated with a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetWhatsappConnectionCatalogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWhatsappConnectionCatalogResponse
         */
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

        /**
         * @summary Queries the product catalogs that are associated with a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetWhatsappConnectionCatalogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWhatsappConnectionCatalogResponse
         */
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

        /**
         * @summary Queries the product catalogs that are associated with a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetWhatsappConnectionCatalogRequest
         * @return GetWhatsappConnectionCatalogResponse
         */
        public GetWhatsappConnectionCatalogResponse GetWhatsappConnectionCatalog(GetWhatsappConnectionCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWhatsappConnectionCatalogWithOptions(request, runtime);
        }

        /**
         * @summary Queries the product catalogs that are associated with a WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetWhatsappConnectionCatalogRequest
         * @return GetWhatsappConnectionCatalogResponse
         */
        public async Task<GetWhatsappConnectionCatalogResponse> GetWhatsappConnectionCatalogAsync(GetWhatsappConnectionCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWhatsappConnectionCatalogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the application ID under the ISV account.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request IsvGetAppIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return IsvGetAppIdResponse
         */
        public IsvGetAppIdResponse IsvGetAppIdWithOptions(IsvGetAppIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["Permissions"] = request.Permissions;
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
         * @summary Obtains the application ID under the ISV account.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request IsvGetAppIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return IsvGetAppIdResponse
         */
        public async Task<IsvGetAppIdResponse> IsvGetAppIdWithOptionsAsync(IsvGetAppIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["Permissions"] = request.Permissions;
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
         * @summary Obtains the application ID under the ISV account.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Obtains the application ID under the ISV account.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries message templates.
         *
         * @description ### QPS limit
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
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
         * @summary Queries message templates.
         *
         * @description ### QPS limit
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
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
         * @summary Queries message templates.
         *
         * @description ### QPS limit
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
         * @summary Queries message templates.
         *
         * @description ### QPS limit
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

        /**
         * @summary Queries a list of Flows.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param tmpReq ListFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFlowResponse
         */
        public ListFlowResponse ListFlowWithOptions(ListFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFlowShrinkRequest request = new ListFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                body["Page"] = request.PageShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of Flows.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param tmpReq ListFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFlowResponse
         */
        public async Task<ListFlowResponse> ListFlowWithOptionsAsync(ListFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFlowShrinkRequest request = new ListFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Page))
            {
                request.PageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Page, "Page", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageShrink))
            {
                body["Page"] = request.PageShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of Flows.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListFlowRequest
         * @return ListFlowResponse
         */
        public ListFlowResponse ListFlow(ListFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of Flows.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListFlowRequest
         * @return ListFlowResponse
         */
        public async Task<ListFlowResponse> ListFlowAsync(ListFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询消息发送二维码
         *
         * @param request ListPhoneMessageQrdlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPhoneMessageQrdlResponse
         */
        public ListPhoneMessageQrdlResponse ListPhoneMessageQrdlWithOptions(ListPhoneMessageQrdlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListPhoneMessageQrdl",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPhoneMessageQrdlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询消息发送二维码
         *
         * @param request ListPhoneMessageQrdlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPhoneMessageQrdlResponse
         */
        public async Task<ListPhoneMessageQrdlResponse> ListPhoneMessageQrdlWithOptionsAsync(ListPhoneMessageQrdlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListPhoneMessageQrdl",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPhoneMessageQrdlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询消息发送二维码
         *
         * @param request ListPhoneMessageQrdlRequest
         * @return ListPhoneMessageQrdlResponse
         */
        public ListPhoneMessageQrdlResponse ListPhoneMessageQrdl(ListPhoneMessageQrdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhoneMessageQrdlWithOptions(request, runtime);
        }

        /**
         * @summary 查询消息发送二维码
         *
         * @param request ListPhoneMessageQrdlRequest
         * @return ListPhoneMessageQrdlResponse
         */
        public async Task<ListPhoneMessageQrdlResponse> ListPhoneMessageQrdlAsync(ListPhoneMessageQrdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhoneMessageQrdlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries products in a product catalog.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListProductRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductResponse
         */
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

        /**
         * @summary Queries products in a product catalog.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListProductRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductResponse
         */
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

        /**
         * @summary Queries products in a product catalog.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListProductRequest
         * @return ListProductResponse
         */
        public ListProductResponse ListProduct(ListProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductWithOptions(request, runtime);
        }

        /**
         * @summary Queries products in a product catalog.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListProductRequest
         * @return ListProductResponse
         */
        public async Task<ListProductResponse> ListProductAsync(ListProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the product catalogs on the Business Manager platform of Meta.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListProductCatalogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductCatalogResponse
         */
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

        /**
         * @summary Queries the product catalogs on the Business Manager platform of Meta.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListProductCatalogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductCatalogResponse
         */
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

        /**
         * @summary Queries the product catalogs on the Business Manager platform of Meta.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListProductCatalogRequest
         * @return ListProductCatalogResponse
         */
        public ListProductCatalogResponse ListProductCatalog(ListProductCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductCatalogWithOptions(request, runtime);
        }

        /**
         * @summary Queries the product catalogs on the Business Manager platform of Meta.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListProductCatalogRequest
         * @return ListProductCatalogResponse
         */
        public async Task<ListProductCatalogResponse> ListProductCatalogAsync(ListProductCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductCatalogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The code of the message template.
         *
         * @description The name of the message template.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
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
         * @summary The code of the message template.
         *
         * @description The name of the message template.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
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
         * @summary The code of the message template.
         *
         * @description The name of the message template.
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
         * @summary The code of the message template.
         *
         * @description The name of the message template.
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
         * @summary Modifies the basic information about a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param tmpReq ModifyFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyFlowResponse
         */
        public ModifyFlowResponse ModifyFlowWithOptions(ModifyFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyFlowShrinkRequest request = new ModifyFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Categories))
            {
                request.CategoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Categories, "Categories", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoriesShrink))
            {
                body["Categories"] = request.CategoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the basic information about a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param tmpReq ModifyFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyFlowResponse
         */
        public async Task<ModifyFlowResponse> ModifyFlowWithOptionsAsync(ModifyFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyFlowShrinkRequest request = new ModifyFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Categories))
            {
                request.CategoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Categories, "Categories", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoriesShrink))
            {
                body["Categories"] = request.CategoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                body["FlowName"] = request.FlowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the basic information about a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyFlowRequest
         * @return ModifyFlowResponse
         */
        public ModifyFlowResponse ModifyFlow(ModifyFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the basic information about a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyFlowRequest
         * @return ModifyFlowResponse
         */
        public async Task<ModifyFlowResponse> ModifyFlowAsync(ModifyFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the request.
         *
         * @description ModifyPhoneBusinessProfile
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.About))
            {
                query["About"] = request.About;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfilePictureUrl))
            {
                query["ProfilePictureUrl"] = request.ProfilePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
         * @summary The ID of the request.
         *
         * @description ModifyPhoneBusinessProfile
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.About))
            {
                query["About"] = request.About;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfilePictureUrl))
            {
                query["ProfilePictureUrl"] = request.ProfilePictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
         * @summary The ID of the request.
         *
         * @description ModifyPhoneBusinessProfile
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
         * @summary The ID of the request.
         *
         * @description ModifyPhoneBusinessProfile
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
         * @summary Publishes a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PublishFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishFlowResponse
         */
        public PublishFlowResponse PublishFlowWithOptions(PublishFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFlowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Publishes a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PublishFlowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishFlowResponse
         */
        public async Task<PublishFlowResponse> PublishFlowWithOptionsAsync(PublishFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishFlow",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Publishes a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PublishFlowRequest
         * @return PublishFlowResponse
         */
        public PublishFlowResponse PublishFlow(PublishFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishFlowWithOptions(request, runtime);
        }

        /**
         * @summary Publishes a Flow.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request PublishFlowRequest
         * @return PublishFlowResponse
         */
        public async Task<PublishFlowResponse> PublishFlowAsync(PublishFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishFlowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Query the WhatsApp Business account you associate with ChatApp.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Query the WhatsApp Business account you associate with ChatApp.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Query the WhatsApp Business account you associate with ChatApp.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Query the WhatsApp Business account you associate with ChatApp.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries phone numbers that receive messages and statuses of these numbers under a specified user.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries phone numbers that receive messages and statuses of these numbers under a specified user.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries phone numbers that receive messages and statuses of these numbers under a specified user.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries phone numbers that receive messages and statuses of these numbers under a specified user.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries the business information of the account to which a specified phone number is bound.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
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
         * @summary Queries the business information of the account to which a specified phone number is bound.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
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
         * @summary Queries the business information of the account to which a specified phone number is bound.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries the business information of the account to which a specified phone number is bound.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries the business information about the WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries the business information about the WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries the business information about the WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Queries the business information about the WhatsApp Business account (WABA).
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Sends a message to multiple phone numbers by using ChatAPP at a time.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
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
         * @summary Sends a message to multiple phone numbers by using ChatAPP at a time.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
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
         * @summary Sends a message to multiple phone numbers by using ChatAPP at a time.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Sends a message to multiple phone numbers by using ChatAPP at a time.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Sends messages by using ChatAPP.
         *
         * @description You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FlowAction))
            {
                request.FlowActionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FlowAction, "FlowAction", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowActionShrink))
            {
                body["FlowAction"] = request.FlowActionShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
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
         * @summary Sends messages by using ChatAPP.
         *
         * @description You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FlowAction))
            {
                request.FlowActionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FlowAction, "FlowAction", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowActionShrink))
            {
                body["FlowAction"] = request.FlowActionShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
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
         * @summary Sends messages by using ChatAPP.
         *
         * @description You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Sends messages by using ChatAPP.
         *
         * @description You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Submits the agreement information for independent software vendor (ISV) customers.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Submits the agreement information for independent software vendor (ISV) customers.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Submits the agreement information for independent software vendor (ISV) customers.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Submits the agreement information for independent software vendor (ISV) customers.
         *
         * @description You can call this operation up to five times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Modifies the callback URL of an account.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Modifies the callback URL of an account.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Modifies the callback URL of an account.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Modifies the callback URL of an account.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
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
         * @summary Modifies the business settings of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UpdateCommerceSettingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCommerceSettingResponse
         */
        public UpdateCommerceSettingResponse UpdateCommerceSettingWithOptions(UpdateCommerceSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CartEnable))
            {
                query["CartEnable"] = request.CartEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogVisible))
            {
                query["CatalogVisible"] = request.CatalogVisible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
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
                Action = "UpdateCommerceSetting",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCommerceSettingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the business settings of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UpdateCommerceSettingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCommerceSettingResponse
         */
        public async Task<UpdateCommerceSettingResponse> UpdateCommerceSettingWithOptionsAsync(UpdateCommerceSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CartEnable))
            {
                query["CartEnable"] = request.CartEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogVisible))
            {
                query["CatalogVisible"] = request.CatalogVisible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                query["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
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
                Action = "UpdateCommerceSetting",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCommerceSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the business settings of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UpdateCommerceSettingRequest
         * @return UpdateCommerceSettingResponse
         */
        public UpdateCommerceSettingResponse UpdateCommerceSetting(UpdateCommerceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCommerceSettingWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the business settings of a phone number.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UpdateCommerceSettingRequest
         * @return UpdateCommerceSettingResponse
         */
        public async Task<UpdateCommerceSettingResponse> UpdateCommerceSettingAsync(UpdateCommerceSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCommerceSettingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新flow的表单内容
         *
         * @param request UpdateFlowJSONAssetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFlowJSONAssetResponse
         */
        public UpdateFlowJSONAssetResponse UpdateFlowJSONAssetWithOptions(UpdateFlowJSONAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowJSONAsset",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowJSONAssetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新flow的表单内容
         *
         * @param request UpdateFlowJSONAssetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFlowJSONAssetResponse
         */
        public async Task<UpdateFlowJSONAssetResponse> UpdateFlowJSONAssetWithOptionsAsync(UpdateFlowJSONAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                body["FlowId"] = request.FlowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowJSONAsset",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowJSONAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新flow的表单内容
         *
         * @param request UpdateFlowJSONAssetRequest
         * @return UpdateFlowJSONAssetResponse
         */
        public UpdateFlowJSONAssetResponse UpdateFlowJSONAsset(UpdateFlowJSONAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlowJSONAssetWithOptions(request, runtime);
        }

        /**
         * @summary 更新flow的表单内容
         *
         * @param request UpdateFlowJSONAssetRequest
         * @return UpdateFlowJSONAssetResponse
         */
        public async Task<UpdateFlowJSONAssetResponse> UpdateFlowJSONAssetAsync(UpdateFlowJSONAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlowJSONAssetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新号码的公钥
         *
         * @param request UpdatePhoneEncryptionPublicKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePhoneEncryptionPublicKeyResponse
         */
        public UpdatePhoneEncryptionPublicKeyResponse UpdatePhoneEncryptionPublicKeyWithOptions(UpdatePhoneEncryptionPublicKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionPublicKey))
            {
                body["EncryptionPublicKey"] = request.EncryptionPublicKey;
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
                Action = "UpdatePhoneEncryptionPublicKey",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePhoneEncryptionPublicKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新号码的公钥
         *
         * @param request UpdatePhoneEncryptionPublicKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePhoneEncryptionPublicKeyResponse
         */
        public async Task<UpdatePhoneEncryptionPublicKeyResponse> UpdatePhoneEncryptionPublicKeyWithOptionsAsync(UpdatePhoneEncryptionPublicKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionPublicKey))
            {
                body["EncryptionPublicKey"] = request.EncryptionPublicKey;
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
                Action = "UpdatePhoneEncryptionPublicKey",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePhoneEncryptionPublicKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新号码的公钥
         *
         * @param request UpdatePhoneEncryptionPublicKeyRequest
         * @return UpdatePhoneEncryptionPublicKeyResponse
         */
        public UpdatePhoneEncryptionPublicKeyResponse UpdatePhoneEncryptionPublicKey(UpdatePhoneEncryptionPublicKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePhoneEncryptionPublicKeyWithOptions(request, runtime);
        }

        /**
         * @summary 更新号码的公钥
         *
         * @param request UpdatePhoneEncryptionPublicKeyRequest
         * @return UpdatePhoneEncryptionPublicKeyResponse
         */
        public async Task<UpdatePhoneEncryptionPublicKeyResponse> UpdatePhoneEncryptionPublicKeyAsync(UpdatePhoneEncryptionPublicKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePhoneEncryptionPublicKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改消息发送二维码
         *
         * @param request UpdatePhoneMessageQrdlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePhoneMessageQrdlResponse
         */
        public UpdatePhoneMessageQrdlResponse UpdatePhoneMessageQrdlWithOptions(UpdatePhoneMessageQrdlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateQrImage))
            {
                body["GenerateQrImage"] = request.GenerateQrImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefilledMessage))
            {
                body["PrefilledMessage"] = request.PrefilledMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QrdlCode))
            {
                body["QrdlCode"] = request.QrdlCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePhoneMessageQrdl",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePhoneMessageQrdlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改消息发送二维码
         *
         * @param request UpdatePhoneMessageQrdlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePhoneMessageQrdlResponse
         */
        public async Task<UpdatePhoneMessageQrdlResponse> UpdatePhoneMessageQrdlWithOptionsAsync(UpdatePhoneMessageQrdlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustSpaceId))
            {
                body["CustSpaceId"] = request.CustSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateQrImage))
            {
                body["GenerateQrImage"] = request.GenerateQrImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefilledMessage))
            {
                body["PrefilledMessage"] = request.PrefilledMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QrdlCode))
            {
                body["QrdlCode"] = request.QrdlCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePhoneMessageQrdl",
                Version = "2020-06-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePhoneMessageQrdlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改消息发送二维码
         *
         * @param request UpdatePhoneMessageQrdlRequest
         * @return UpdatePhoneMessageQrdlResponse
         */
        public UpdatePhoneMessageQrdlResponse UpdatePhoneMessageQrdl(UpdatePhoneMessageQrdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePhoneMessageQrdlWithOptions(request, runtime);
        }

        /**
         * @summary 修改消息发送二维码
         *
         * @param request UpdatePhoneMessageQrdlRequest
         * @return UpdatePhoneMessageQrdlResponse
         */
        public async Task<UpdatePhoneMessageQrdlResponse> UpdatePhoneMessageQrdlAsync(UpdatePhoneMessageQrdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePhoneMessageQrdlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The HTTP status code returned.
         * *   A value of OK indicates that the call is successful.
         * *   Other values indicate that the call fails. For more information, see [Error codes](https://help.aliyun.com/document_detail/196974.html).
         *
         * @description The error message returned.
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
         * @summary The HTTP status code returned.
         * *   A value of OK indicates that the call is successful.
         * *   Other values indicate that the call fails. For more information, see [Error codes](https://help.aliyun.com/document_detail/196974.html).
         *
         * @description The error message returned.
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
         * @summary The HTTP status code returned.
         * *   A value of OK indicates that the call is successful.
         * *   Other values indicate that the call fails. For more information, see [Error codes](https://help.aliyun.com/document_detail/196974.html).
         *
         * @description The error message returned.
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
         * @summary The HTTP status code returned.
         * *   A value of OK indicates that the call is successful.
         * *   Other values indicate that the call fails. For more information, see [Error codes](https://help.aliyun.com/document_detail/196974.html).
         *
         * @description The error message returned.
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
