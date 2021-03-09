// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OnsMqtt20200420.Models;

namespace AlibabaCloud.SDK.OnsMqtt20200420
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("onsmqtt", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ApplyTokenResponse ApplyTokenWithOptions(ApplyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyTokenResponse>(DoRPCRequest("ApplyToken", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplyTokenResponse> ApplyTokenWithOptionsAsync(ApplyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyTokenResponse>(await DoRPCRequestAsync("ApplyToken", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplyTokenResponse ApplyToken(ApplyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyTokenWithOptions(request, runtime);
        }

        public async Task<ApplyTokenResponse> ApplyTokenAsync(ApplyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyTokenWithOptionsAsync(request, runtime);
        }

        public BatchQuerySessionByClientIdsResponse BatchQuerySessionByClientIdsWithOptions(BatchQuerySessionByClientIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchQuerySessionByClientIdsResponse>(DoRPCRequest("BatchQuerySessionByClientIds", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchQuerySessionByClientIdsResponse> BatchQuerySessionByClientIdsWithOptionsAsync(BatchQuerySessionByClientIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchQuerySessionByClientIdsResponse>(await DoRPCRequestAsync("BatchQuerySessionByClientIds", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchQuerySessionByClientIdsResponse BatchQuerySessionByClientIds(BatchQuerySessionByClientIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQuerySessionByClientIdsWithOptions(request, runtime);
        }

        public async Task<BatchQuerySessionByClientIdsResponse> BatchQuerySessionByClientIdsAsync(BatchQuerySessionByClientIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQuerySessionByClientIdsWithOptionsAsync(request, runtime);
        }

        public CreateGroupIdResponse CreateGroupIdWithOptions(CreateGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupIdResponse>(DoRPCRequest("CreateGroupId", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGroupIdResponse> CreateGroupIdWithOptionsAsync(CreateGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupIdResponse>(await DoRPCRequestAsync("CreateGroupId", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGroupIdResponse CreateGroupId(CreateGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupIdWithOptions(request, runtime);
        }

        public async Task<CreateGroupIdResponse> CreateGroupIdAsync(CreateGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupIdWithOptionsAsync(request, runtime);
        }

        public DeleteGroupIdResponse DeleteGroupIdWithOptions(DeleteGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGroupIdResponse>(DoRPCRequest("DeleteGroupId", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGroupIdResponse> DeleteGroupIdWithOptionsAsync(DeleteGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGroupIdResponse>(await DoRPCRequestAsync("DeleteGroupId", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteGroupIdResponse DeleteGroupId(DeleteGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupIdWithOptions(request, runtime);
        }

        public async Task<DeleteGroupIdResponse> DeleteGroupIdAsync(DeleteGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupIdWithOptionsAsync(request, runtime);
        }

        public GetDeviceCredentialResponse GetDeviceCredentialWithOptions(GetDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceCredentialResponse>(DoRPCRequest("GetDeviceCredential", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDeviceCredentialResponse> GetDeviceCredentialWithOptionsAsync(GetDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDeviceCredentialResponse>(await DoRPCRequestAsync("GetDeviceCredential", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDeviceCredentialResponse GetDeviceCredential(GetDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceCredentialWithOptions(request, runtime);
        }

        public async Task<GetDeviceCredentialResponse> GetDeviceCredentialAsync(GetDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceCredentialWithOptionsAsync(request, runtime);
        }

        public ListGroupIdResponse ListGroupIdWithOptions(ListGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListGroupIdResponse>(DoRPCRequest("ListGroupId", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListGroupIdResponse> ListGroupIdWithOptionsAsync(ListGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListGroupIdResponse>(await DoRPCRequestAsync("ListGroupId", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListGroupIdResponse ListGroupId(ListGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupIdWithOptions(request, runtime);
        }

        public async Task<ListGroupIdResponse> ListGroupIdAsync(ListGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupIdWithOptionsAsync(request, runtime);
        }

        public QuerySessionByClientIdResponse QuerySessionByClientIdWithOptions(QuerySessionByClientIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySessionByClientIdResponse>(DoRPCRequest("QuerySessionByClientId", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySessionByClientIdResponse> QuerySessionByClientIdWithOptionsAsync(QuerySessionByClientIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySessionByClientIdResponse>(await DoRPCRequestAsync("QuerySessionByClientId", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySessionByClientIdResponse QuerySessionByClientId(QuerySessionByClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySessionByClientIdWithOptions(request, runtime);
        }

        public async Task<QuerySessionByClientIdResponse> QuerySessionByClientIdAsync(QuerySessionByClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySessionByClientIdWithOptionsAsync(request, runtime);
        }

        public QueryTokenResponse QueryTokenWithOptions(QueryTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTokenResponse>(DoRPCRequest("QueryToken", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTokenResponse> QueryTokenWithOptionsAsync(QueryTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTokenResponse>(await DoRPCRequestAsync("QueryToken", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTokenResponse QueryToken(QueryTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTokenWithOptions(request, runtime);
        }

        public async Task<QueryTokenResponse> QueryTokenAsync(QueryTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTokenWithOptionsAsync(request, runtime);
        }

        public RefreshDeviceCredentialResponse RefreshDeviceCredentialWithOptions(RefreshDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshDeviceCredentialResponse>(DoRPCRequest("RefreshDeviceCredential", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshDeviceCredentialResponse> RefreshDeviceCredentialWithOptionsAsync(RefreshDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshDeviceCredentialResponse>(await DoRPCRequestAsync("RefreshDeviceCredential", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshDeviceCredentialResponse RefreshDeviceCredential(RefreshDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshDeviceCredentialWithOptions(request, runtime);
        }

        public async Task<RefreshDeviceCredentialResponse> RefreshDeviceCredentialAsync(RefreshDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshDeviceCredentialWithOptionsAsync(request, runtime);
        }

        public RegisterDeviceCredentialResponse RegisterDeviceCredentialWithOptions(RegisterDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterDeviceCredentialResponse>(DoRPCRequest("RegisterDeviceCredential", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterDeviceCredentialResponse> RegisterDeviceCredentialWithOptionsAsync(RegisterDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterDeviceCredentialResponse>(await DoRPCRequestAsync("RegisterDeviceCredential", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterDeviceCredentialResponse RegisterDeviceCredential(RegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDeviceCredentialWithOptions(request, runtime);
        }

        public async Task<RegisterDeviceCredentialResponse> RegisterDeviceCredentialAsync(RegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDeviceCredentialWithOptionsAsync(request, runtime);
        }

        public RevokeTokenResponse RevokeTokenWithOptions(RevokeTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeTokenResponse>(DoRPCRequest("RevokeToken", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeTokenResponse> RevokeTokenWithOptionsAsync(RevokeTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeTokenResponse>(await DoRPCRequestAsync("RevokeToken", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeTokenResponse RevokeToken(RevokeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeTokenWithOptions(request, runtime);
        }

        public async Task<RevokeTokenResponse> RevokeTokenAsync(RevokeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeTokenWithOptionsAsync(request, runtime);
        }

        public SendMessageResponse SendMessageWithOptions(SendMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMessageResponse>(DoRPCRequest("SendMessage", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendMessageResponse> SendMessageWithOptionsAsync(SendMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMessageResponse>(await DoRPCRequestAsync("SendMessage", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMessageWithOptions(request, runtime);
        }

        public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMessageWithOptionsAsync(request, runtime);
        }

        public UnRegisterDeviceCredentialResponse UnRegisterDeviceCredentialWithOptions(UnRegisterDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnRegisterDeviceCredentialResponse>(DoRPCRequest("UnRegisterDeviceCredential", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnRegisterDeviceCredentialResponse> UnRegisterDeviceCredentialWithOptionsAsync(UnRegisterDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnRegisterDeviceCredentialResponse>(await DoRPCRequestAsync("UnRegisterDeviceCredential", "2020-04-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnRegisterDeviceCredentialResponse UnRegisterDeviceCredential(UnRegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnRegisterDeviceCredentialWithOptions(request, runtime);
        }

        public async Task<UnRegisterDeviceCredentialResponse> UnRegisterDeviceCredentialAsync(UnRegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnRegisterDeviceCredentialWithOptionsAsync(request, runtime);
        }

    }
}
