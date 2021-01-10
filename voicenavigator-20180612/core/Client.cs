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

        public AssociateChatbotInstanceResponse AssociateChatbotInstanceWithOptions(AssociateChatbotInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateChatbotInstanceResponse>(DoRPCRequest("AssociateChatbotInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateChatbotInstanceResponse> AssociateChatbotInstanceWithOptionsAsync(AssociateChatbotInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateChatbotInstanceResponse>(await DoRPCRequestAsync("AssociateChatbotInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateChatbotInstanceResponse AssociateChatbotInstance(AssociateChatbotInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateChatbotInstanceWithOptions(request, runtime);
        }

        public async Task<AssociateChatbotInstanceResponse> AssociateChatbotInstanceAsync(AssociateChatbotInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateChatbotInstanceWithOptionsAsync(request, runtime);
        }

        public AuditTTSVoiceResponse AuditTTSVoiceWithOptions(AuditTTSVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuditTTSVoiceResponse>(DoRPCRequest("AuditTTSVoice", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AuditTTSVoiceResponse> AuditTTSVoiceWithOptionsAsync(AuditTTSVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuditTTSVoiceResponse>(await DoRPCRequestAsync("AuditTTSVoice", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AuditTTSVoiceResponse AuditTTSVoice(AuditTTSVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuditTTSVoiceWithOptions(request, runtime);
        }

        public async Task<AuditTTSVoiceResponse> AuditTTSVoiceAsync(AuditTTSVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuditTTSVoiceWithOptionsAsync(request, runtime);
        }

        public BeginDialogueResponse BeginDialogueWithOptions(BeginDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BeginDialogueResponse>(DoRPCRequest("BeginDialogue", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BeginDialogueResponse> BeginDialogueWithOptionsAsync(BeginDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BeginDialogueResponse>(await DoRPCRequestAsync("BeginDialogue", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BeginDialogueResponse BeginDialogue(BeginDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BeginDialogueWithOptions(request, runtime);
        }

        public async Task<BeginDialogueResponse> BeginDialogueAsync(BeginDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BeginDialogueWithOptionsAsync(request, runtime);
        }

        public CollectedNumberResponse CollectedNumberWithOptions(CollectedNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CollectedNumberResponse>(DoRPCRequest("CollectedNumber", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CollectedNumberResponse> CollectedNumberWithOptionsAsync(CollectedNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CollectedNumberResponse>(await DoRPCRequestAsync("CollectedNumber", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CollectedNumberResponse CollectedNumber(CollectedNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CollectedNumberWithOptions(request, runtime);
        }

        public async Task<CollectedNumberResponse> CollectedNumberAsync(CollectedNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CollectedNumberWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoRPCRequest("CreateInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRPCRequestAsync("CreateInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public DebugBeginDialogueResponse DebugBeginDialogueWithOptions(DebugBeginDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DebugBeginDialogueResponse>(DoRPCRequest("DebugBeginDialogue", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DebugBeginDialogueResponse> DebugBeginDialogueWithOptionsAsync(DebugBeginDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DebugBeginDialogueResponse>(await DoRPCRequestAsync("DebugBeginDialogue", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DebugBeginDialogueResponse DebugBeginDialogue(DebugBeginDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DebugBeginDialogueWithOptions(request, runtime);
        }

        public async Task<DebugBeginDialogueResponse> DebugBeginDialogueAsync(DebugBeginDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DebugBeginDialogueWithOptionsAsync(request, runtime);
        }

        public DebugCollectedNumberResponse DebugCollectedNumberWithOptions(DebugCollectedNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DebugCollectedNumberResponse>(DoRPCRequest("DebugCollectedNumber", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DebugCollectedNumberResponse> DebugCollectedNumberWithOptionsAsync(DebugCollectedNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DebugCollectedNumberResponse>(await DoRPCRequestAsync("DebugCollectedNumber", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DebugCollectedNumberResponse DebugCollectedNumber(DebugCollectedNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DebugCollectedNumberWithOptions(request, runtime);
        }

        public async Task<DebugCollectedNumberResponse> DebugCollectedNumberAsync(DebugCollectedNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DebugCollectedNumberWithOptionsAsync(request, runtime);
        }

        public DebugDialogueResponse DebugDialogueWithOptions(DebugDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DebugDialogueResponse>(DoRPCRequest("DebugDialogue", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DebugDialogueResponse> DebugDialogueWithOptionsAsync(DebugDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DebugDialogueResponse>(await DoRPCRequestAsync("DebugDialogue", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DebugDialogueResponse DebugDialogue(DebugDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DebugDialogueWithOptions(request, runtime);
        }

        public async Task<DebugDialogueResponse> DebugDialogueAsync(DebugDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DebugDialogueWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRPCRequest("DeleteInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRPCRequestAsync("DeleteInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeConversationResponse DescribeConversationWithOptions(DescribeConversationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeConversationResponse>(DoRPCRequest("DescribeConversation", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeConversationResponse> DescribeConversationWithOptionsAsync(DescribeConversationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeConversationResponse>(await DoRPCRequestAsync("DescribeConversation", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeConversationResponse DescribeConversation(DescribeConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConversationWithOptions(request, runtime);
        }

        public async Task<DescribeConversationResponse> DescribeConversationAsync(DescribeConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConversationWithOptionsAsync(request, runtime);
        }

        public DescribeConversationContextResponse DescribeConversationContextWithOptions(DescribeConversationContextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeConversationContextResponse>(DoRPCRequest("DescribeConversationContext", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeConversationContextResponse> DescribeConversationContextWithOptionsAsync(DescribeConversationContextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeConversationContextResponse>(await DoRPCRequestAsync("DescribeConversationContext", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeConversationContextResponse DescribeConversationContext(DescribeConversationContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConversationContextWithOptions(request, runtime);
        }

        public async Task<DescribeConversationContextResponse> DescribeConversationContextAsync(DescribeConversationContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConversationContextWithOptionsAsync(request, runtime);
        }

        public DescribeExportProgressResponse DescribeExportProgressWithOptions(DescribeExportProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeExportProgressResponse>(DoRPCRequest("DescribeExportProgress", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeExportProgressResponse> DescribeExportProgressWithOptionsAsync(DescribeExportProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeExportProgressResponse>(await DoRPCRequestAsync("DescribeExportProgress", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeExportProgressResponse DescribeExportProgress(DescribeExportProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExportProgressWithOptions(request, runtime);
        }

        public async Task<DescribeExportProgressResponse> DescribeExportProgressAsync(DescribeExportProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExportProgressWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(DoRPCRequest("DescribeInstance", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await DoRPCRequestAsync("DescribeInstance", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeNavigationConfigResponse DescribeNavigationConfigWithOptions(DescribeNavigationConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeNavigationConfigResponse>(DoRPCRequest("DescribeNavigationConfig", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeNavigationConfigResponse> DescribeNavigationConfigWithOptionsAsync(DescribeNavigationConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeNavigationConfigResponse>(await DoRPCRequestAsync("DescribeNavigationConfig", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeNavigationConfigResponse DescribeNavigationConfig(DescribeNavigationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNavigationConfigWithOptions(request, runtime);
        }

        public async Task<DescribeNavigationConfigResponse> DescribeNavigationConfigAsync(DescribeNavigationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNavigationConfigWithOptionsAsync(request, runtime);
        }

        public DescribeRecordingResponse DescribeRecordingWithOptions(DescribeRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeRecordingResponse>(DoRPCRequest("DescribeRecording", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordingResponse> DescribeRecordingWithOptionsAsync(DescribeRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeRecordingResponse>(await DoRPCRequestAsync("DescribeRecording", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeRecordingResponse DescribeRecording(DescribeRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordingWithOptions(request, runtime);
        }

        public async Task<DescribeRecordingResponse> DescribeRecordingAsync(DescribeRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordingWithOptionsAsync(request, runtime);
        }

        public DescribeStatisticalDataResponse DescribeStatisticalDataWithOptions(DescribeStatisticalDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeStatisticalDataResponse>(DoRPCRequest("DescribeStatisticalData", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeStatisticalDataResponse> DescribeStatisticalDataWithOptionsAsync(DescribeStatisticalDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeStatisticalDataResponse>(await DoRPCRequestAsync("DescribeStatisticalData", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeStatisticalDataResponse DescribeStatisticalData(DescribeStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStatisticalDataWithOptions(request, runtime);
        }

        public async Task<DescribeStatisticalDataResponse> DescribeStatisticalDataAsync(DescribeStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStatisticalDataWithOptionsAsync(request, runtime);
        }

        public DescribeTTSConfigResponse DescribeTTSConfigWithOptions(DescribeTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeTTSConfigResponse>(DoRPCRequest("DescribeTTSConfig", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeTTSConfigResponse> DescribeTTSConfigWithOptionsAsync(DescribeTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeTTSConfigResponse>(await DoRPCRequestAsync("DescribeTTSConfig", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeTTSConfigResponse DescribeTTSConfig(DescribeTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTTSConfigWithOptions(request, runtime);
        }

        public async Task<DescribeTTSConfigResponse> DescribeTTSConfigAsync(DescribeTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTTSConfigWithOptionsAsync(request, runtime);
        }

        public DialogueResponse DialogueWithOptions(DialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DialogueResponse>(DoRPCRequest("Dialogue", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DialogueResponse> DialogueWithOptionsAsync(DialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DialogueResponse>(await DoRPCRequestAsync("Dialogue", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DialogueResponse Dialogue(DialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DialogueWithOptions(request, runtime);
        }

        public async Task<DialogueResponse> DialogueAsync(DialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DialogueWithOptionsAsync(request, runtime);
        }

        public DisableInstanceResponse DisableInstanceWithOptions(DisableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableInstanceResponse>(DoRPCRequest("DisableInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableInstanceResponse> DisableInstanceWithOptionsAsync(DisableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableInstanceResponse>(await DoRPCRequestAsync("DisableInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableInstanceResponse DisableInstance(DisableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableInstanceWithOptions(request, runtime);
        }

        public async Task<DisableInstanceResponse> DisableInstanceAsync(DisableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableInstanceWithOptionsAsync(request, runtime);
        }

        public EnableInstanceResponse EnableInstanceWithOptions(EnableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableInstanceResponse>(DoRPCRequest("EnableInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableInstanceResponse> EnableInstanceWithOptionsAsync(EnableInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableInstanceResponse>(await DoRPCRequestAsync("EnableInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableInstanceResponse EnableInstance(EnableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableInstanceWithOptions(request, runtime);
        }

        public async Task<EnableInstanceResponse> EnableInstanceAsync(EnableInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableInstanceWithOptionsAsync(request, runtime);
        }

        public EndDialogueResponse EndDialogueWithOptions(EndDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EndDialogueResponse>(DoRPCRequest("EndDialogue", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EndDialogueResponse> EndDialogueWithOptionsAsync(EndDialogueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EndDialogueResponse>(await DoRPCRequestAsync("EndDialogue", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EndDialogueResponse EndDialogue(EndDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EndDialogueWithOptions(request, runtime);
        }

        public async Task<EndDialogueResponse> EndDialogueAsync(EndDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EndDialogueWithOptionsAsync(request, runtime);
        }

        public ExportConversationDetailsResponse ExportConversationDetailsWithOptions(ExportConversationDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportConversationDetailsResponse>(DoRPCRequest("ExportConversationDetails", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportConversationDetailsResponse> ExportConversationDetailsWithOptionsAsync(ExportConversationDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportConversationDetailsResponse>(await DoRPCRequestAsync("ExportConversationDetails", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportConversationDetailsResponse ExportConversationDetails(ExportConversationDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportConversationDetailsWithOptions(request, runtime);
        }

        public async Task<ExportConversationDetailsResponse> ExportConversationDetailsAsync(ExportConversationDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportConversationDetailsWithOptionsAsync(request, runtime);
        }

        public ExportStatisticalDataResponse ExportStatisticalDataWithOptions(ExportStatisticalDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportStatisticalDataResponse>(DoRPCRequest("ExportStatisticalData", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportStatisticalDataResponse> ExportStatisticalDataWithOptionsAsync(ExportStatisticalDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportStatisticalDataResponse>(await DoRPCRequestAsync("ExportStatisticalData", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportStatisticalDataResponse ExportStatisticalData(ExportStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportStatisticalDataWithOptions(request, runtime);
        }

        public async Task<ExportStatisticalDataResponse> ExportStatisticalDataAsync(ExportStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportStatisticalDataWithOptionsAsync(request, runtime);
        }

        public ListChatbotInstancesResponse ListChatbotInstancesWithOptions(ListChatbotInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListChatbotInstancesResponse>(DoRPCRequest("ListChatbotInstances", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListChatbotInstancesResponse> ListChatbotInstancesWithOptionsAsync(ListChatbotInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListChatbotInstancesResponse>(await DoRPCRequestAsync("ListChatbotInstances", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListChatbotInstancesResponse ListChatbotInstances(ListChatbotInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChatbotInstancesWithOptions(request, runtime);
        }

        public async Task<ListChatbotInstancesResponse> ListChatbotInstancesAsync(ListChatbotInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChatbotInstancesWithOptionsAsync(request, runtime);
        }

        public ListConversationDetailsResponse ListConversationDetailsWithOptions(ListConversationDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListConversationDetailsResponse>(DoRPCRequest("ListConversationDetails", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListConversationDetailsResponse> ListConversationDetailsWithOptionsAsync(ListConversationDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListConversationDetailsResponse>(await DoRPCRequestAsync("ListConversationDetails", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListConversationDetailsResponse ListConversationDetails(ListConversationDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConversationDetailsWithOptions(request, runtime);
        }

        public async Task<ListConversationDetailsResponse> ListConversationDetailsAsync(ListConversationDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConversationDetailsWithOptionsAsync(request, runtime);
        }

        public ListConversationsResponse ListConversationsWithOptions(ListConversationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListConversationsResponse>(DoRPCRequest("ListConversations", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListConversationsResponse> ListConversationsWithOptionsAsync(ListConversationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListConversationsResponse>(await DoRPCRequestAsync("ListConversations", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListConversationsResponse ListConversations(ListConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConversationsWithOptions(request, runtime);
        }

        public async Task<ListConversationsResponse> ListConversationsAsync(ListConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConversationsWithOptionsAsync(request, runtime);
        }

        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListInstancesResponse>(DoRPCRequest("ListInstances", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListInstancesResponse>(await DoRPCRequestAsync("ListInstances", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        public ModifyGreetingConfigResponse ModifyGreetingConfigWithOptions(ModifyGreetingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGreetingConfigResponse>(DoRPCRequest("ModifyGreetingConfig", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyGreetingConfigResponse> ModifyGreetingConfigWithOptionsAsync(ModifyGreetingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGreetingConfigResponse>(await DoRPCRequestAsync("ModifyGreetingConfig", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyGreetingConfigResponse ModifyGreetingConfig(ModifyGreetingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGreetingConfigWithOptions(request, runtime);
        }

        public async Task<ModifyGreetingConfigResponse> ModifyGreetingConfigAsync(ModifyGreetingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGreetingConfigWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceResponse ModifyInstanceWithOptions(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(DoRPCRequest("ModifyInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceWithOptionsAsync(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(await DoRPCRequestAsync("ModifyInstance", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceResponse ModifyInstance(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceWithOptionsAsync(request, runtime);
        }

        public ModifySilenceTimeoutConfigResponse ModifySilenceTimeoutConfigWithOptions(ModifySilenceTimeoutConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySilenceTimeoutConfigResponse>(DoRPCRequest("ModifySilenceTimeoutConfig", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySilenceTimeoutConfigResponse> ModifySilenceTimeoutConfigWithOptionsAsync(ModifySilenceTimeoutConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySilenceTimeoutConfigResponse>(await DoRPCRequestAsync("ModifySilenceTimeoutConfig", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySilenceTimeoutConfigResponse ModifySilenceTimeoutConfig(ModifySilenceTimeoutConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySilenceTimeoutConfigWithOptions(request, runtime);
        }

        public async Task<ModifySilenceTimeoutConfigResponse> ModifySilenceTimeoutConfigAsync(ModifySilenceTimeoutConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySilenceTimeoutConfigWithOptionsAsync(request, runtime);
        }

        public ModifyTTSConfigResponse ModifyTTSConfigWithOptions(ModifyTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTTSConfigResponse>(DoRPCRequest("ModifyTTSConfig", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyTTSConfigResponse> ModifyTTSConfigWithOptionsAsync(ModifyTTSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTTSConfigResponse>(await DoRPCRequestAsync("ModifyTTSConfig", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyTTSConfigResponse ModifyTTSConfig(ModifyTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTTSConfigWithOptions(request, runtime);
        }

        public async Task<ModifyTTSConfigResponse> ModifyTTSConfigAsync(ModifyTTSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTTSConfigWithOptionsAsync(request, runtime);
        }

        public ModifyUnrecognizingConfigResponse ModifyUnrecognizingConfigWithOptions(ModifyUnrecognizingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUnrecognizingConfigResponse>(DoRPCRequest("ModifyUnrecognizingConfig", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUnrecognizingConfigResponse> ModifyUnrecognizingConfigWithOptionsAsync(ModifyUnrecognizingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUnrecognizingConfigResponse>(await DoRPCRequestAsync("ModifyUnrecognizingConfig", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUnrecognizingConfigResponse ModifyUnrecognizingConfig(ModifyUnrecognizingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUnrecognizingConfigWithOptions(request, runtime);
        }

        public async Task<ModifyUnrecognizingConfigResponse> ModifyUnrecognizingConfigAsync(ModifyUnrecognizingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUnrecognizingConfigWithOptionsAsync(request, runtime);
        }

        public QueryConversationsResponse QueryConversationsWithOptions(QueryConversationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryConversationsResponse>(DoRPCRequest("QueryConversations", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryConversationsResponse> QueryConversationsWithOptionsAsync(QueryConversationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryConversationsResponse>(await DoRPCRequestAsync("QueryConversations", "2018-06-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryConversationsResponse QueryConversations(QueryConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConversationsWithOptions(request, runtime);
        }

        public async Task<QueryConversationsResponse> QueryConversationsAsync(QueryConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConversationsWithOptionsAsync(request, runtime);
        }

        public SaveRecordingResponse SaveRecordingWithOptions(SaveRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveRecordingResponse>(DoRPCRequest("SaveRecording", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveRecordingResponse> SaveRecordingWithOptionsAsync(SaveRecordingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveRecordingResponse>(await DoRPCRequestAsync("SaveRecording", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveRecordingResponse SaveRecording(SaveRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveRecordingWithOptions(request, runtime);
        }

        public async Task<SaveRecordingResponse> SaveRecordingAsync(SaveRecordingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveRecordingWithOptionsAsync(request, runtime);
        }

        public SilenceTimeoutResponse SilenceTimeoutWithOptions(SilenceTimeoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SilenceTimeoutResponse>(DoRPCRequest("SilenceTimeout", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SilenceTimeoutResponse> SilenceTimeoutWithOptionsAsync(SilenceTimeoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SilenceTimeoutResponse>(await DoRPCRequestAsync("SilenceTimeout", "2018-06-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SilenceTimeoutResponse SilenceTimeout(SilenceTimeoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SilenceTimeoutWithOptions(request, runtime);
        }

        public async Task<SilenceTimeoutResponse> SilenceTimeoutAsync(SilenceTimeoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SilenceTimeoutWithOptionsAsync(request, runtime);
        }

    }
}
