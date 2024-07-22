// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.VoiceNavigator20180612.Models;

namespace AlibabaCloud.SDK.VoiceNavigator20180612
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("voicenavigator", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request AssociateChatbotInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssociateChatbotInstanceResponse
         */
        public AssociateChatbotInstanceResponse AssociateChatbotInstanceWithOptions(AssociateChatbotInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotInstanceId))
            {
                query["ChatbotInstanceId"] = request.ChatbotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotName))
            {
                query["ChatbotName"] = request.ChatbotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluServiceParamsJson))
            {
                query["NluServiceParamsJson"] = request.NluServiceParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluServiceType))
            {
                query["NluServiceType"] = request.NluServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionSource))
            {
                query["UnionSource"] = request.UnionSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateChatbotInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateChatbotInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AssociateChatbotInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssociateChatbotInstanceResponse
         */
        public async Task<AssociateChatbotInstanceResponse> AssociateChatbotInstanceWithOptionsAsync(AssociateChatbotInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotInstanceId))
            {
                query["ChatbotInstanceId"] = request.ChatbotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotName))
            {
                query["ChatbotName"] = request.ChatbotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluServiceParamsJson))
            {
                query["NluServiceParamsJson"] = request.NluServiceParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluServiceType))
            {
                query["NluServiceType"] = request.NluServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionSource))
            {
                query["UnionSource"] = request.UnionSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateChatbotInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateChatbotInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AssociateChatbotInstanceRequest
         * @return AssociateChatbotInstanceResponse
         */
        public AssociateChatbotInstanceResponse AssociateChatbotInstance(AssociateChatbotInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateChatbotInstanceWithOptions(request, runtime);
        }

        /**
         * @param request AssociateChatbotInstanceRequest
         * @return AssociateChatbotInstanceResponse
         */
        public async Task<AssociateChatbotInstanceResponse> AssociateChatbotInstanceAsync(AssociateChatbotInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateChatbotInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request AuditTTSVoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuditTTSVoiceResponse
         */
        public AuditTTSVoiceResponse AuditTTSVoiceWithOptions(AuditTTSVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PitchRate))
            {
                query["PitchRate"] = request.PitchRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                query["SecretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                query["SpeechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voice))
            {
                query["Voice"] = request.Voice;
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
                Action = "AuditTTSVoice",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuditTTSVoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AuditTTSVoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuditTTSVoiceResponse
         */
        public async Task<AuditTTSVoiceResponse> AuditTTSVoiceWithOptionsAsync(AuditTTSVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["AccessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PitchRate))
            {
                query["PitchRate"] = request.PitchRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretKey))
            {
                query["SecretKey"] = request.SecretKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                query["SpeechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voice))
            {
                query["Voice"] = request.Voice;
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
                Action = "AuditTTSVoice",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuditTTSVoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AuditTTSVoiceRequest
         * @return AuditTTSVoiceResponse
         */
        public AuditTTSVoiceResponse AuditTTSVoice(AuditTTSVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuditTTSVoiceWithOptions(request, runtime);
        }

        /**
         * @param request AuditTTSVoiceRequest
         * @return AuditTTSVoiceResponse
         */
        public async Task<AuditTTSVoiceResponse> AuditTTSVoiceAsync(AuditTTSVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuditTTSVoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request BeginDialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BeginDialogueResponse
         */
        public BeginDialogueResponse BeginDialogueWithOptions(BeginDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialContext))
            {
                query["InitialContext"] = request.InitialContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BeginDialogue",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BeginDialogueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request BeginDialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BeginDialogueResponse
         */
        public async Task<BeginDialogueResponse> BeginDialogueWithOptionsAsync(BeginDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialContext))
            {
                query["InitialContext"] = request.InitialContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BeginDialogue",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BeginDialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BeginDialogueRequest
         * @return BeginDialogueResponse
         */
        public BeginDialogueResponse BeginDialogue(BeginDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BeginDialogueWithOptions(request, runtime);
        }

        /**
         * @param request BeginDialogueRequest
         * @return BeginDialogueResponse
         */
        public async Task<BeginDialogueResponse> BeginDialogueAsync(BeginDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BeginDialogueWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CollectedNumberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollectedNumberResponse
         */
        public CollectedNumberResponse CollectedNumberWithOptions(CollectedNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalContext))
            {
                query["AdditionalContext"] = request.AdditionalContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CollectedNumber",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollectedNumberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CollectedNumberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollectedNumberResponse
         */
        public async Task<CollectedNumberResponse> CollectedNumberWithOptionsAsync(CollectedNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalContext))
            {
                query["AdditionalContext"] = request.AdditionalContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CollectedNumber",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollectedNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CollectedNumberRequest
         * @return CollectedNumberResponse
         */
        public CollectedNumberResponse CollectedNumber(CollectedNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CollectedNumberWithOptions(request, runtime);
        }

        /**
         * @param request CollectedNumberRequest
         * @return CollectedNumberResponse
         */
        public async Task<CollectedNumberResponse> CollectedNumberAsync(CollectedNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CollectedNumberWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateDownloadUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDownloadUrlResponse
         */
        public CreateDownloadUrlResponse CreateDownloadUrlWithOptions(CreateDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownloadUrl",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateDownloadUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDownloadUrlResponse
         */
        public async Task<CreateDownloadUrlResponse> CreateDownloadUrlWithOptionsAsync(CreateDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownloadUrl",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateDownloadUrlRequest
         * @return CreateDownloadUrlResponse
         */
        public CreateDownloadUrlResponse CreateDownloadUrl(CreateDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDownloadUrlWithOptions(request, runtime);
        }

        /**
         * @param request CreateDownloadUrlRequest
         * @return CreateDownloadUrlResponse
         */
        public async Task<CreateDownloadUrlResponse> CreateDownloadUrlAsync(CreateDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDownloadUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                query["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluServiceParamsJson))
            {
                query["NluServiceParamsJson"] = request.NluServiceParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionInstanceId))
            {
                query["UnionInstanceId"] = request.UnionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionSource))
            {
                query["UnionSource"] = request.UnionSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                query["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NluServiceParamsJson))
            {
                query["NluServiceParamsJson"] = request.NluServiceParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionInstanceId))
            {
                query["UnionInstanceId"] = request.UnionInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionSource))
            {
                query["UnionSource"] = request.UnionSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /**
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DebugBeginDialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DebugBeginDialogueResponse
         */
        public DebugBeginDialogueResponse DebugBeginDialogueWithOptions(DebugBeginDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialContext))
            {
                query["InitialContext"] = request.InitialContext;
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
                Action = "DebugBeginDialogue",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugBeginDialogueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DebugBeginDialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DebugBeginDialogueResponse
         */
        public async Task<DebugBeginDialogueResponse> DebugBeginDialogueWithOptionsAsync(DebugBeginDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialContext))
            {
                query["InitialContext"] = request.InitialContext;
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
                Action = "DebugBeginDialogue",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugBeginDialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DebugBeginDialogueRequest
         * @return DebugBeginDialogueResponse
         */
        public DebugBeginDialogueResponse DebugBeginDialogue(DebugBeginDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DebugBeginDialogueWithOptions(request, runtime);
        }

        /**
         * @param request DebugBeginDialogueRequest
         * @return DebugBeginDialogueResponse
         */
        public async Task<DebugBeginDialogueResponse> DebugBeginDialogueAsync(DebugBeginDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DebugBeginDialogueWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DebugCollectedNumberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DebugCollectedNumberResponse
         */
        public DebugCollectedNumberResponse DebugCollectedNumberWithOptions(DebugCollectedNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugCollectedNumber",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugCollectedNumberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DebugCollectedNumberRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DebugCollectedNumberResponse
         */
        public async Task<DebugCollectedNumberResponse> DebugCollectedNumberWithOptionsAsync(DebugCollectedNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugCollectedNumber",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugCollectedNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DebugCollectedNumberRequest
         * @return DebugCollectedNumberResponse
         */
        public DebugCollectedNumberResponse DebugCollectedNumber(DebugCollectedNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DebugCollectedNumberWithOptions(request, runtime);
        }

        /**
         * @param request DebugCollectedNumberRequest
         * @return DebugCollectedNumberResponse
         */
        public async Task<DebugCollectedNumberResponse> DebugCollectedNumberAsync(DebugCollectedNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DebugCollectedNumberWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DebugDialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DebugDialogueResponse
         */
        public DebugDialogueResponse DebugDialogueWithOptions(DebugDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalContext))
            {
                query["AdditionalContext"] = request.AdditionalContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterance))
            {
                query["Utterance"] = request.Utterance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugDialogue",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugDialogueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DebugDialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DebugDialogueResponse
         */
        public async Task<DebugDialogueResponse> DebugDialogueWithOptionsAsync(DebugDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalContext))
            {
                query["AdditionalContext"] = request.AdditionalContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterance))
            {
                query["Utterance"] = request.Utterance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugDialogue",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugDialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DebugDialogueRequest
         * @return DebugDialogueResponse
         */
        public DebugDialogueResponse DebugDialogue(DebugDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DebugDialogueWithOptions(request, runtime);
        }

        /**
         * @param request DebugDialogueRequest
         * @return DebugDialogueResponse
         */
        public async Task<DebugDialogueResponse> DebugDialogueAsync(DebugDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DebugDialogueWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteInstanceRequest
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /**
         * @param request DeleteInstanceRequest
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeConversationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConversationResponse
         */
        public DescribeConversationResponse DescribeConversationWithOptions(DescribeConversationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConversation",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConversationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeConversationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConversationResponse
         */
        public async Task<DescribeConversationResponse> DescribeConversationWithOptionsAsync(DescribeConversationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConversation",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConversationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeConversationRequest
         * @return DescribeConversationResponse
         */
        public DescribeConversationResponse DescribeConversation(DescribeConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConversationWithOptions(request, runtime);
        }

        /**
         * @param request DescribeConversationRequest
         * @return DescribeConversationResponse
         */
        public async Task<DescribeConversationResponse> DescribeConversationAsync(DescribeConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConversationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeConversationContextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConversationContextResponse
         */
        public DescribeConversationContextResponse DescribeConversationContextWithOptions(DescribeConversationContextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConversationContext",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConversationContextResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeConversationContextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConversationContextResponse
         */
        public async Task<DescribeConversationContextResponse> DescribeConversationContextWithOptionsAsync(DescribeConversationContextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConversationContext",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConversationContextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeConversationContextRequest
         * @return DescribeConversationContextResponse
         */
        public DescribeConversationContextResponse DescribeConversationContext(DescribeConversationContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConversationContextWithOptions(request, runtime);
        }

        /**
         * @param request DescribeConversationContextRequest
         * @return DescribeConversationContextResponse
         */
        public async Task<DescribeConversationContextResponse> DescribeConversationContextAsync(DescribeConversationContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConversationContextWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeExportProgressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExportProgressResponse
         */
        public DescribeExportProgressResponse DescribeExportProgressWithOptions(DescribeExportProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExportProgress",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExportProgressResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeExportProgressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExportProgressResponse
         */
        public async Task<DescribeExportProgressResponse> DescribeExportProgressWithOptionsAsync(DescribeExportProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExportProgress",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExportProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeExportProgressRequest
         * @return DescribeExportProgressResponse
         */
        public DescribeExportProgressResponse DescribeExportProgress(DescribeExportProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExportProgressWithOptions(request, runtime);
        }

        /**
         * @param request DescribeExportProgressRequest
         * @return DescribeExportProgressResponse
         */
        public async Task<DescribeExportProgressResponse> DescribeExportProgressAsync(DescribeExportProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExportProgressWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceResponse
         */
        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceResponse
         */
        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceRequest
         * @return DescribeInstanceResponse
         */
        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        /**
         * @param request DescribeInstanceRequest
         * @return DescribeInstanceResponse
         */
        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeNavigationConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNavigationConfigResponse
         */
        public DescribeNavigationConfigResponse DescribeNavigationConfigWithOptions(DescribeNavigationConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNavigationConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNavigationConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeNavigationConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNavigationConfigResponse
         */
        public async Task<DescribeNavigationConfigResponse> DescribeNavigationConfigWithOptionsAsync(DescribeNavigationConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNavigationConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNavigationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeNavigationConfigRequest
         * @return DescribeNavigationConfigResponse
         */
        public DescribeNavigationConfigResponse DescribeNavigationConfig(DescribeNavigationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNavigationConfigWithOptions(request, runtime);
        }

        /**
         * @param request DescribeNavigationConfigRequest
         * @return DescribeNavigationConfigResponse
         */
        public async Task<DescribeNavigationConfigResponse> DescribeNavigationConfigAsync(DescribeNavigationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNavigationConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRecordingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordingResponse
         */
        public DescribeRecordingResponse DescribeRecordingWithOptions(DescribeRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecording",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRecordingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordingResponse
         */
        public async Task<DescribeRecordingResponse> DescribeRecordingWithOptionsAsync(DescribeRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecording",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRecordingRequest
         * @return DescribeRecordingResponse
         */
        public DescribeRecordingResponse DescribeRecording(DescribeRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordingWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRecordingRequest
         * @return DescribeRecordingResponse
         */
        public async Task<DescribeRecordingResponse> DescribeRecordingAsync(DescribeRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordingWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeStatisticalDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStatisticalDataResponse
         */
        public DescribeStatisticalDataResponse DescribeStatisticalDataWithOptions(DescribeStatisticalDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStatisticalData",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStatisticalDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeStatisticalDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStatisticalDataResponse
         */
        public async Task<DescribeStatisticalDataResponse> DescribeStatisticalDataWithOptionsAsync(DescribeStatisticalDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStatisticalData",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStatisticalDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeStatisticalDataRequest
         * @return DescribeStatisticalDataResponse
         */
        public DescribeStatisticalDataResponse DescribeStatisticalData(DescribeStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStatisticalDataWithOptions(request, runtime);
        }

        /**
         * @param request DescribeStatisticalDataRequest
         * @return DescribeStatisticalDataResponse
         */
        public async Task<DescribeStatisticalDataResponse> DescribeStatisticalDataAsync(DescribeStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStatisticalDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeTTSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTTSConfigResponse
         */
        public DescribeTTSConfigResponse DescribeTTSConfigWithOptions(DescribeTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTTSConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTTSConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeTTSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTTSConfigResponse
         */
        public async Task<DescribeTTSConfigResponse> DescribeTTSConfigWithOptionsAsync(DescribeTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTTSConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTTSConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeTTSConfigRequest
         * @return DescribeTTSConfigResponse
         */
        public DescribeTTSConfigResponse DescribeTTSConfig(DescribeTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTTSConfigWithOptions(request, runtime);
        }

        /**
         * @param request DescribeTTSConfigRequest
         * @return DescribeTTSConfigResponse
         */
        public async Task<DescribeTTSConfigResponse> DescribeTTSConfigAsync(DescribeTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTTSConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DialogueResponse
         */
        public DialogueResponse DialogueWithOptions(DialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalContext))
            {
                query["AdditionalContext"] = request.AdditionalContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Emotion))
            {
                query["Emotion"] = request.Emotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterance))
            {
                query["Utterance"] = request.Utterance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Dialogue",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DialogueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DialogueResponse
         */
        public async Task<DialogueResponse> DialogueWithOptionsAsync(DialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalContext))
            {
                query["AdditionalContext"] = request.AdditionalContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Emotion))
            {
                query["Emotion"] = request.Emotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Utterance))
            {
                query["Utterance"] = request.Utterance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Dialogue",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DialogueRequest
         * @return DialogueResponse
         */
        public DialogueResponse Dialogue(DialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DialogueWithOptions(request, runtime);
        }

        /**
         * @param request DialogueRequest
         * @return DialogueResponse
         */
        public async Task<DialogueResponse> DialogueAsync(DialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DialogueWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DisableInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableInstanceResponse
         */
        public DisableInstanceResponse DisableInstanceWithOptions(DisableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DisableInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DisableInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableInstanceResponse
         */
        public async Task<DisableInstanceResponse> DisableInstanceWithOptionsAsync(DisableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DisableInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DisableInstanceRequest
         * @return DisableInstanceResponse
         */
        public DisableInstanceResponse DisableInstance(DisableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableInstanceWithOptions(request, runtime);
        }

        /**
         * @param request DisableInstanceRequest
         * @return DisableInstanceResponse
         */
        public async Task<DisableInstanceResponse> DisableInstanceAsync(DisableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request EnableInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableInstanceResponse
         */
        public EnableInstanceResponse EnableInstanceWithOptions(EnableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EnableInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request EnableInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableInstanceResponse
         */
        public async Task<EnableInstanceResponse> EnableInstanceWithOptionsAsync(EnableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EnableInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request EnableInstanceRequest
         * @return EnableInstanceResponse
         */
        public EnableInstanceResponse EnableInstance(EnableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableInstanceWithOptions(request, runtime);
        }

        /**
         * @param request EnableInstanceRequest
         * @return EnableInstanceResponse
         */
        public async Task<EnableInstanceResponse> EnableInstanceAsync(EnableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request EndDialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EndDialogueResponse
         */
        public EndDialogueResponse EndDialogueWithOptions(EndDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HangUpParams))
            {
                query["HangUpParams"] = request.HangUpParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EndDialogue",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EndDialogueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request EndDialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EndDialogueResponse
         */
        public async Task<EndDialogueResponse> EndDialogueWithOptionsAsync(EndDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HangUpParams))
            {
                query["HangUpParams"] = request.HangUpParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EndDialogue",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EndDialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request EndDialogueRequest
         * @return EndDialogueResponse
         */
        public EndDialogueResponse EndDialogue(EndDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EndDialogueWithOptions(request, runtime);
        }

        /**
         * @param request EndDialogueRequest
         * @return EndDialogueResponse
         */
        public async Task<EndDialogueResponse> EndDialogueAsync(EndDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EndDialogueWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ExportConversationDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportConversationDetailsResponse
         */
        public ExportConversationDetailsResponse ExportConversationDetailsWithOptions(ExportConversationDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeLeftRange))
            {
                query["BeginTimeLeftRange"] = request.BeginTimeLeftRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeRightRange))
            {
                query["BeginTimeRightRange"] = request.BeginTimeRightRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                query["Result"] = request.Result;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoundsLeftRange))
            {
                query["RoundsLeftRange"] = request.RoundsLeftRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoundsRightRange))
            {
                query["RoundsRightRange"] = request.RoundsRightRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportConversationDetails",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportConversationDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ExportConversationDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportConversationDetailsResponse
         */
        public async Task<ExportConversationDetailsResponse> ExportConversationDetailsWithOptionsAsync(ExportConversationDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeLeftRange))
            {
                query["BeginTimeLeftRange"] = request.BeginTimeLeftRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeRightRange))
            {
                query["BeginTimeRightRange"] = request.BeginTimeRightRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallingNumber))
            {
                query["CallingNumber"] = request.CallingNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                query["Result"] = request.Result;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoundsLeftRange))
            {
                query["RoundsLeftRange"] = request.RoundsLeftRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoundsRightRange))
            {
                query["RoundsRightRange"] = request.RoundsRightRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportConversationDetails",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportConversationDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ExportConversationDetailsRequest
         * @return ExportConversationDetailsResponse
         */
        public ExportConversationDetailsResponse ExportConversationDetails(ExportConversationDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportConversationDetailsWithOptions(request, runtime);
        }

        /**
         * @param request ExportConversationDetailsRequest
         * @return ExportConversationDetailsResponse
         */
        public async Task<ExportConversationDetailsResponse> ExportConversationDetailsAsync(ExportConversationDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportConversationDetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ExportStatisticalDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportStatisticalDataResponse
         */
        public ExportStatisticalDataResponse ExportStatisticalDataWithOptions(ExportStatisticalDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeLeftRange))
            {
                query["BeginTimeLeftRange"] = request.BeginTimeLeftRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeRightRange))
            {
                query["BeginTimeRightRange"] = request.BeginTimeRightRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportType))
            {
                query["ExportType"] = request.ExportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeUnit))
            {
                query["TimeUnit"] = request.TimeUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportStatisticalData",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportStatisticalDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ExportStatisticalDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportStatisticalDataResponse
         */
        public async Task<ExportStatisticalDataResponse> ExportStatisticalDataWithOptionsAsync(ExportStatisticalDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeLeftRange))
            {
                query["BeginTimeLeftRange"] = request.BeginTimeLeftRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimeRightRange))
            {
                query["BeginTimeRightRange"] = request.BeginTimeRightRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportType))
            {
                query["ExportType"] = request.ExportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeUnit))
            {
                query["TimeUnit"] = request.TimeUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportStatisticalData",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportStatisticalDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ExportStatisticalDataRequest
         * @return ExportStatisticalDataResponse
         */
        public ExportStatisticalDataResponse ExportStatisticalData(ExportStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportStatisticalDataWithOptions(request, runtime);
        }

        /**
         * @param request ExportStatisticalDataRequest
         * @return ExportStatisticalDataResponse
         */
        public async Task<ExportStatisticalDataResponse> ExportStatisticalDataAsync(ExportStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportStatisticalDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GenerateUploadUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateUploadUrlResponse
         */
        public GenerateUploadUrlResponse GenerateUploadUrlWithOptions(GenerateUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerBid))
            {
                body["CallerBid"] = request.CallerBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerIp))
            {
                body["CallerIp"] = request.CallerIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                body["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                body["CallerType"] = request.CallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                body["CallerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                body["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MfaPresent))
            {
                body["MfaPresent"] = request.MfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyOriginalSecurityTransport))
            {
                body["ProxyOriginalSecurityTransport"] = request.ProxyOriginalSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyOriginalSourceIp))
            {
                body["ProxyOriginalSourceIp"] = request.ProxyOriginalSourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyTrustTransportInfo))
            {
                body["ProxyTrustTransportInfo"] = request.ProxyTrustTransportInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityTransport))
            {
                body["SecurityTransport"] = request.SecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XspaceServicerId))
            {
                body["XspaceServicerId"] = request.XspaceServicerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XspaceTenantBuId))
            {
                body["XspaceTenantBuId"] = request.XspaceTenantBuId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadUrl",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GenerateUploadUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateUploadUrlResponse
         */
        public async Task<GenerateUploadUrlResponse> GenerateUploadUrlWithOptionsAsync(GenerateUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerBid))
            {
                body["CallerBid"] = request.CallerBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerIp))
            {
                body["CallerIp"] = request.CallerIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerParentId))
            {
                body["CallerParentId"] = request.CallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                body["CallerType"] = request.CallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerUid))
            {
                body["CallerUid"] = request.CallerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                body["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MfaPresent))
            {
                body["MfaPresent"] = request.MfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyOriginalSecurityTransport))
            {
                body["ProxyOriginalSecurityTransport"] = request.ProxyOriginalSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyOriginalSourceIp))
            {
                body["ProxyOriginalSourceIp"] = request.ProxyOriginalSourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyTrustTransportInfo))
            {
                body["ProxyTrustTransportInfo"] = request.ProxyTrustTransportInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityTransport))
            {
                body["SecurityTransport"] = request.SecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XspaceServicerId))
            {
                body["XspaceServicerId"] = request.XspaceServicerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XspaceTenantBuId))
            {
                body["XspaceTenantBuId"] = request.XspaceTenantBuId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadUrl",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GenerateUploadUrlRequest
         * @return GenerateUploadUrlResponse
         */
        public GenerateUploadUrlResponse GenerateUploadUrl(GenerateUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateUploadUrlWithOptions(request, runtime);
        }

        /**
         * @param request GenerateUploadUrlRequest
         * @return GenerateUploadUrlResponse
         */
        public async Task<GenerateUploadUrlResponse> GenerateUploadUrlAsync(GenerateUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateUploadUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetAsrConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsrConfigResponse
         */
        public GetAsrConfigResponse GetAsrConfigWithOptions(GetAsrConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigLevel))
            {
                query["ConfigLevel"] = request.ConfigLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsrConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsrConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetAsrConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsrConfigResponse
         */
        public async Task<GetAsrConfigResponse> GetAsrConfigWithOptionsAsync(GetAsrConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigLevel))
            {
                query["ConfigLevel"] = request.ConfigLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsrConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsrConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetAsrConfigRequest
         * @return GetAsrConfigResponse
         */
        public GetAsrConfigResponse GetAsrConfig(GetAsrConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsrConfigWithOptions(request, runtime);
        }

        /**
         * @param request GetAsrConfigRequest
         * @return GetAsrConfigResponse
         */
        public async Task<GetAsrConfigResponse> GetAsrConfigAsync(GetAsrConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsrConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetRealTimeConcurrencyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRealTimeConcurrencyResponse
         */
        public GetRealTimeConcurrencyResponse GetRealTimeConcurrencyWithOptions(GetRealTimeConcurrencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealTimeConcurrency",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealTimeConcurrencyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetRealTimeConcurrencyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRealTimeConcurrencyResponse
         */
        public async Task<GetRealTimeConcurrencyResponse> GetRealTimeConcurrencyWithOptionsAsync(GetRealTimeConcurrencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealTimeConcurrency",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealTimeConcurrencyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetRealTimeConcurrencyRequest
         * @return GetRealTimeConcurrencyResponse
         */
        public GetRealTimeConcurrencyResponse GetRealTimeConcurrency(GetRealTimeConcurrencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRealTimeConcurrencyWithOptions(request, runtime);
        }

        /**
         * @param request GetRealTimeConcurrencyRequest
         * @return GetRealTimeConcurrencyResponse
         */
        public async Task<GetRealTimeConcurrencyResponse> GetRealTimeConcurrencyAsync(GetRealTimeConcurrencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRealTimeConcurrencyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListChatbotInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChatbotInstancesResponse
         */
        public ListChatbotInstancesResponse ListChatbotInstancesWithOptions(ListChatbotInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatbotInstances",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatbotInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListChatbotInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChatbotInstancesResponse
         */
        public async Task<ListChatbotInstancesResponse> ListChatbotInstancesWithOptionsAsync(ListChatbotInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatbotInstances",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatbotInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListChatbotInstancesRequest
         * @return ListChatbotInstancesResponse
         */
        public ListChatbotInstancesResponse ListChatbotInstances(ListChatbotInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChatbotInstancesWithOptions(request, runtime);
        }

        /**
         * @param request ListChatbotInstancesRequest
         * @return ListChatbotInstancesResponse
         */
        public async Task<ListChatbotInstancesResponse> ListChatbotInstancesAsync(ListChatbotInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChatbotInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListConversationDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConversationDetailsResponse
         */
        public ListConversationDetailsResponse ListConversationDetailsWithOptions(ListConversationDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConversationDetails",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConversationDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListConversationDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConversationDetailsResponse
         */
        public async Task<ListConversationDetailsResponse> ListConversationDetailsWithOptionsAsync(ListConversationDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConversationDetails",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConversationDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListConversationDetailsRequest
         * @return ListConversationDetailsResponse
         */
        public ListConversationDetailsResponse ListConversationDetails(ListConversationDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConversationDetailsWithOptions(request, runtime);
        }

        /**
         * @param request ListConversationDetailsRequest
         * @return ListConversationDetailsResponse
         */
        public async Task<ListConversationDetailsResponse> ListConversationDetailsAsync(ListConversationDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConversationDetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListConversationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConversationsResponse
         */
        public ListConversationsResponse ListConversationsWithOptions(ListConversationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConversations",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConversationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListConversationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConversationsResponse
         */
        public async Task<ListConversationsResponse> ListConversationsWithOptionsAsync(ListConversationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConversations",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConversationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListConversationsRequest
         * @return ListConversationsResponse
         */
        public ListConversationsResponse ListConversations(ListConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConversationsWithOptions(request, runtime);
        }

        /**
         * @param request ListConversationsRequest
         * @return ListConversationsResponse
         */
        public async Task<ListConversationsResponse> ListConversationsAsync(ListConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConversationsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListDownloadTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDownloadTasksResponse
         */
        public ListDownloadTasksResponse ListDownloadTasksWithOptions(ListDownloadTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDownloadTasks",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDownloadTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListDownloadTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDownloadTasksResponse
         */
        public async Task<ListDownloadTasksResponse> ListDownloadTasksWithOptionsAsync(ListDownloadTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDownloadTasks",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDownloadTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListDownloadTasksRequest
         * @return ListDownloadTasksResponse
         */
        public ListDownloadTasksResponse ListDownloadTasks(ListDownloadTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDownloadTasksWithOptions(request, runtime);
        }

        /**
         * @param request ListDownloadTasksRequest
         * @return ListDownloadTasksResponse
         */
        public async Task<ListDownloadTasksResponse> ListDownloadTasksAsync(ListDownloadTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDownloadTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        /**
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyAsrConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAsrConfigResponse
         */
        public ModifyAsrConfigResponse ModifyAsrConfigWithOptions(ModifyAsrConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrAcousticModelId))
            {
                query["AsrAcousticModelId"] = request.AsrAcousticModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrClassVocabularyId))
            {
                query["AsrClassVocabularyId"] = request.AsrClassVocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrCustomizationId))
            {
                query["AsrCustomizationId"] = request.AsrCustomizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrVocabularyId))
            {
                query["AsrVocabularyId"] = request.AsrVocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigLevel))
            {
                query["ConfigLevel"] = request.ConfigLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAsrConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAsrConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyAsrConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAsrConfigResponse
         */
        public async Task<ModifyAsrConfigResponse> ModifyAsrConfigWithOptionsAsync(ModifyAsrConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrAcousticModelId))
            {
                query["AsrAcousticModelId"] = request.AsrAcousticModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrClassVocabularyId))
            {
                query["AsrClassVocabularyId"] = request.AsrClassVocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrCustomizationId))
            {
                query["AsrCustomizationId"] = request.AsrCustomizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrVocabularyId))
            {
                query["AsrVocabularyId"] = request.AsrVocabularyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigLevel))
            {
                query["ConfigLevel"] = request.ConfigLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryId))
            {
                query["EntryId"] = request.EntryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAsrConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAsrConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyAsrConfigRequest
         * @return ModifyAsrConfigResponse
         */
        public ModifyAsrConfigResponse ModifyAsrConfig(ModifyAsrConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAsrConfigWithOptions(request, runtime);
        }

        /**
         * @param request ModifyAsrConfigRequest
         * @return ModifyAsrConfigResponse
         */
        public async Task<ModifyAsrConfigResponse> ModifyAsrConfigAsync(ModifyAsrConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAsrConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyGreetingConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyGreetingConfigResponse
         */
        public ModifyGreetingConfigResponse ModifyGreetingConfigWithOptions(ModifyGreetingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreetingWords))
            {
                query["GreetingWords"] = request.GreetingWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentTrigger))
            {
                query["IntentTrigger"] = request.IntentTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGreetingConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGreetingConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyGreetingConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyGreetingConfigResponse
         */
        public async Task<ModifyGreetingConfigResponse> ModifyGreetingConfigWithOptionsAsync(ModifyGreetingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreetingWords))
            {
                query["GreetingWords"] = request.GreetingWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentTrigger))
            {
                query["IntentTrigger"] = request.IntentTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGreetingConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGreetingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyGreetingConfigRequest
         * @return ModifyGreetingConfigResponse
         */
        public ModifyGreetingConfigResponse ModifyGreetingConfig(ModifyGreetingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGreetingConfigWithOptions(request, runtime);
        }

        /**
         * @param request ModifyGreetingConfigRequest
         * @return ModifyGreetingConfigResponse
         */
        public async Task<ModifyGreetingConfigResponse> ModifyGreetingConfigAsync(ModifyGreetingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGreetingConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceResponse
         */
        public ModifyInstanceResponse ModifyInstanceWithOptions(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                query["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceResponse
         */
        public async Task<ModifyInstanceResponse> ModifyInstanceWithOptionsAsync(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                query["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstance",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyInstanceRequest
         * @return ModifyInstanceResponse
         */
        public ModifyInstanceResponse ModifyInstance(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceWithOptions(request, runtime);
        }

        /**
         * @param request ModifyInstanceRequest
         * @return ModifyInstanceResponse
         */
        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifySilenceTimeoutConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySilenceTimeoutConfigResponse
         */
        public ModifySilenceTimeoutConfigResponse ModifySilenceTimeoutConfigWithOptions(ModifySilenceTimeoutConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalAction))
            {
                query["FinalAction"] = request.FinalAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalActionParams))
            {
                query["FinalActionParams"] = request.FinalActionParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalPrompt))
            {
                query["FinalPrompt"] = request.FinalPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentTrigger))
            {
                query["IntentTrigger"] = request.IntentTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySilenceTimeoutConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySilenceTimeoutConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifySilenceTimeoutConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySilenceTimeoutConfigResponse
         */
        public async Task<ModifySilenceTimeoutConfigResponse> ModifySilenceTimeoutConfigWithOptionsAsync(ModifySilenceTimeoutConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalAction))
            {
                query["FinalAction"] = request.FinalAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalActionParams))
            {
                query["FinalActionParams"] = request.FinalActionParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalPrompt))
            {
                query["FinalPrompt"] = request.FinalPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentTrigger))
            {
                query["IntentTrigger"] = request.IntentTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySilenceTimeoutConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySilenceTimeoutConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifySilenceTimeoutConfigRequest
         * @return ModifySilenceTimeoutConfigResponse
         */
        public ModifySilenceTimeoutConfigResponse ModifySilenceTimeoutConfig(ModifySilenceTimeoutConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySilenceTimeoutConfigWithOptions(request, runtime);
        }

        /**
         * @param request ModifySilenceTimeoutConfigRequest
         * @return ModifySilenceTimeoutConfigResponse
         */
        public async Task<ModifySilenceTimeoutConfigResponse> ModifySilenceTimeoutConfigAsync(ModifySilenceTimeoutConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySilenceTimeoutConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyTTSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTTSConfigResponse
         */
        public ModifyTTSConfigResponse ModifyTTSConfigWithOptions(ModifyTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliCustomizedVoice))
            {
                query["AliCustomizedVoice"] = request.AliCustomizedVoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineXunfei))
            {
                query["EngineXunfei"] = request.EngineXunfei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsServiceType))
            {
                query["NlsServiceType"] = request.NlsServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                query["SpeechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voice))
            {
                query["Voice"] = request.Voice;
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
                Action = "ModifyTTSConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTTSConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyTTSConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTTSConfigResponse
         */
        public async Task<ModifyTTSConfigResponse> ModifyTTSConfigWithOptionsAsync(ModifyTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliCustomizedVoice))
            {
                query["AliCustomizedVoice"] = request.AliCustomizedVoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineXunfei))
            {
                query["EngineXunfei"] = request.EngineXunfei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlsServiceType))
            {
                query["NlsServiceType"] = request.NlsServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                query["SpeechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voice))
            {
                query["Voice"] = request.Voice;
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
                Action = "ModifyTTSConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTTSConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyTTSConfigRequest
         * @return ModifyTTSConfigResponse
         */
        public ModifyTTSConfigResponse ModifyTTSConfig(ModifyTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTTSConfigWithOptions(request, runtime);
        }

        /**
         * @param request ModifyTTSConfigRequest
         * @return ModifyTTSConfigResponse
         */
        public async Task<ModifyTTSConfigResponse> ModifyTTSConfigAsync(ModifyTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTTSConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyUnrecognizingConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyUnrecognizingConfigResponse
         */
        public ModifyUnrecognizingConfigResponse ModifyUnrecognizingConfigWithOptions(ModifyUnrecognizingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalAction))
            {
                query["FinalAction"] = request.FinalAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalActionParams))
            {
                query["FinalActionParams"] = request.FinalActionParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalPrompt))
            {
                query["FinalPrompt"] = request.FinalPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUnrecognizingConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUnrecognizingConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyUnrecognizingConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyUnrecognizingConfigResponse
         */
        public async Task<ModifyUnrecognizingConfigResponse> ModifyUnrecognizingConfigWithOptionsAsync(ModifyUnrecognizingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalAction))
            {
                query["FinalAction"] = request.FinalAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalActionParams))
            {
                query["FinalActionParams"] = request.FinalActionParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalPrompt))
            {
                query["FinalPrompt"] = request.FinalPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUnrecognizingConfig",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUnrecognizingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyUnrecognizingConfigRequest
         * @return ModifyUnrecognizingConfigResponse
         */
        public ModifyUnrecognizingConfigResponse ModifyUnrecognizingConfig(ModifyUnrecognizingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUnrecognizingConfigWithOptions(request, runtime);
        }

        /**
         * @param request ModifyUnrecognizingConfigRequest
         * @return ModifyUnrecognizingConfigResponse
         */
        public async Task<ModifyUnrecognizingConfigResponse> ModifyUnrecognizingConfigAsync(ModifyUnrecognizingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUnrecognizingConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryConversationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryConversationsResponse
         */
        public QueryConversationsResponse QueryConversationsWithOptions(QueryConversationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConversations",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConversationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryConversationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryConversationsResponse
         */
        public async Task<QueryConversationsResponse> QueryConversationsWithOptionsAsync(QueryConversationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConversations",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConversationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryConversationsRequest
         * @return QueryConversationsResponse
         */
        public QueryConversationsResponse QueryConversations(QueryConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConversationsWithOptions(request, runtime);
        }

        /**
         * @param request QueryConversationsRequest
         * @return QueryConversationsResponse
         */
        public async Task<QueryConversationsResponse> QueryConversationsAsync(QueryConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConversationsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveRecordingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveRecordingResponse
         */
        public SaveRecordingResponse SaveRecordingWithOptions(SaveRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceSliceRecordingList))
            {
                query["VoiceSliceRecordingList"] = request.VoiceSliceRecordingList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRecording",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveRecordingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SaveRecordingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveRecordingResponse
         */
        public async Task<SaveRecordingResponse> SaveRecordingWithOptionsAsync(SaveRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceSliceRecordingList))
            {
                query["VoiceSliceRecordingList"] = request.VoiceSliceRecordingList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRecording",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveRecordingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SaveRecordingRequest
         * @return SaveRecordingResponse
         */
        public SaveRecordingResponse SaveRecording(SaveRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveRecordingWithOptions(request, runtime);
        }

        /**
         * @param request SaveRecordingRequest
         * @return SaveRecordingResponse
         */
        public async Task<SaveRecordingResponse> SaveRecordingAsync(SaveRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveRecordingWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SilenceTimeoutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SilenceTimeoutResponse
         */
        public SilenceTimeoutResponse SilenceTimeoutWithOptions(SilenceTimeoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialContext))
            {
                query["InitialContext"] = request.InitialContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SilenceTimeout",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SilenceTimeoutResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SilenceTimeoutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SilenceTimeoutResponse
         */
        public async Task<SilenceTimeoutResponse> SilenceTimeoutWithOptionsAsync(SilenceTimeoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialContext))
            {
                query["InitialContext"] = request.InitialContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                query["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SilenceTimeout",
                Version = "2018-06-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SilenceTimeoutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SilenceTimeoutRequest
         * @return SilenceTimeoutResponse
         */
        public SilenceTimeoutResponse SilenceTimeout(SilenceTimeoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SilenceTimeoutWithOptions(request, runtime);
        }

        /**
         * @param request SilenceTimeoutRequest
         * @return SilenceTimeoutResponse
         */
        public async Task<SilenceTimeoutResponse> SilenceTimeoutAsync(SilenceTimeoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SilenceTimeoutWithOptionsAsync(request, runtime);
        }

    }
}
