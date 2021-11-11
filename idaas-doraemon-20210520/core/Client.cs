// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Idaas_doraemon20210520.Models;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "idaas-doraemon.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("idaas-doraemon", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateAuthenticatorRegistrationResponse CreateAuthenticatorRegistrationWithOptions(CreateAuthenticatorRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAuthenticatorRegistrationResponse>(DoRPCRequest("CreateAuthenticatorRegistration", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAuthenticatorRegistrationResponse> CreateAuthenticatorRegistrationWithOptionsAsync(CreateAuthenticatorRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAuthenticatorRegistrationResponse>(await DoRPCRequestAsync("CreateAuthenticatorRegistration", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAuthenticatorRegistrationResponse CreateAuthenticatorRegistration(CreateAuthenticatorRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAuthenticatorRegistrationWithOptions(request, runtime);
        }

        public async Task<CreateAuthenticatorRegistrationResponse> CreateAuthenticatorRegistrationAsync(CreateAuthenticatorRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAuthenticatorRegistrationWithOptionsAsync(request, runtime);
        }

        public CreateUserAuthenticateOptionsResponse CreateUserAuthenticateOptionsWithOptions(CreateUserAuthenticateOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserAuthenticateOptionsResponse>(DoRPCRequest("CreateUserAuthenticateOptions", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserAuthenticateOptionsResponse> CreateUserAuthenticateOptionsWithOptionsAsync(CreateUserAuthenticateOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserAuthenticateOptionsResponse>(await DoRPCRequestAsync("CreateUserAuthenticateOptions", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUserAuthenticateOptionsResponse CreateUserAuthenticateOptions(CreateUserAuthenticateOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserAuthenticateOptionsWithOptions(request, runtime);
        }

        public async Task<CreateUserAuthenticateOptionsResponse> CreateUserAuthenticateOptionsAsync(CreateUserAuthenticateOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserAuthenticateOptionsWithOptionsAsync(request, runtime);
        }

        public DeregisterAuthenticatorResponse DeregisterAuthenticatorWithOptions(DeregisterAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeregisterAuthenticatorResponse>(DoRPCRequest("DeregisterAuthenticator", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeregisterAuthenticatorResponse> DeregisterAuthenticatorWithOptionsAsync(DeregisterAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeregisterAuthenticatorResponse>(await DoRPCRequestAsync("DeregisterAuthenticator", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeregisterAuthenticatorResponse DeregisterAuthenticator(DeregisterAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeregisterAuthenticatorWithOptions(request, runtime);
        }

        public async Task<DeregisterAuthenticatorResponse> DeregisterAuthenticatorAsync(DeregisterAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeregisterAuthenticatorWithOptionsAsync(request, runtime);
        }

        public FetchAccessTokenResponse FetchAccessTokenWithOptions(FetchAccessTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchAccessTokenResponse>(DoRPCRequest("FetchAccessToken", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FetchAccessTokenResponse> FetchAccessTokenWithOptionsAsync(FetchAccessTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FetchAccessTokenResponse>(await DoRPCRequestAsync("FetchAccessToken", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FetchAccessTokenResponse FetchAccessToken(FetchAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchAccessTokenWithOptions(request, runtime);
        }

        public async Task<FetchAccessTokenResponse> FetchAccessTokenAsync(FetchAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchAccessTokenWithOptionsAsync(request, runtime);
        }

        public GetAuthenticatorResponse GetAuthenticatorWithOptions(GetAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuthenticatorResponse>(DoRPCRequest("GetAuthenticator", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAuthenticatorResponse> GetAuthenticatorWithOptionsAsync(GetAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuthenticatorResponse>(await DoRPCRequestAsync("GetAuthenticator", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAuthenticatorResponse GetAuthenticator(GetAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuthenticatorWithOptions(request, runtime);
        }

        public async Task<GetAuthenticatorResponse> GetAuthenticatorAsync(GetAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuthenticatorWithOptionsAsync(request, runtime);
        }

        public ListAuthenticationLogsResponse ListAuthenticationLogsWithOptions(ListAuthenticationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAuthenticationLogsResponse>(DoRPCRequest("ListAuthenticationLogs", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAuthenticationLogsResponse> ListAuthenticationLogsWithOptionsAsync(ListAuthenticationLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAuthenticationLogsResponse>(await DoRPCRequestAsync("ListAuthenticationLogs", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAuthenticationLogsResponse ListAuthenticationLogs(ListAuthenticationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthenticationLogsWithOptions(request, runtime);
        }

        public async Task<ListAuthenticationLogsResponse> ListAuthenticationLogsAsync(ListAuthenticationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthenticationLogsWithOptionsAsync(request, runtime);
        }

        public ListAuthenticatorOpsLogsResponse ListAuthenticatorOpsLogsWithOptions(ListAuthenticatorOpsLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAuthenticatorOpsLogsResponse>(DoRPCRequest("ListAuthenticatorOpsLogs", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAuthenticatorOpsLogsResponse> ListAuthenticatorOpsLogsWithOptionsAsync(ListAuthenticatorOpsLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAuthenticatorOpsLogsResponse>(await DoRPCRequestAsync("ListAuthenticatorOpsLogs", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAuthenticatorOpsLogsResponse ListAuthenticatorOpsLogs(ListAuthenticatorOpsLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthenticatorOpsLogsWithOptions(request, runtime);
        }

        public async Task<ListAuthenticatorOpsLogsResponse> ListAuthenticatorOpsLogsAsync(ListAuthenticatorOpsLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthenticatorOpsLogsWithOptionsAsync(request, runtime);
        }

        public ListAuthenticatorsResponse ListAuthenticatorsWithOptions(ListAuthenticatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAuthenticatorsResponse>(DoRPCRequest("ListAuthenticators", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAuthenticatorsResponse> ListAuthenticatorsWithOptionsAsync(ListAuthenticatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAuthenticatorsResponse>(await DoRPCRequestAsync("ListAuthenticators", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAuthenticatorsResponse ListAuthenticators(ListAuthenticatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthenticatorsWithOptions(request, runtime);
        }

        public async Task<ListAuthenticatorsResponse> ListAuthenticatorsAsync(ListAuthenticatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthenticatorsWithOptionsAsync(request, runtime);
        }

        public ListPwnedPasswordsResponse ListPwnedPasswordsWithOptions(ListPwnedPasswordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPwnedPasswordsResponse>(DoRPCRequest("ListPwnedPasswords", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPwnedPasswordsResponse> ListPwnedPasswordsWithOptionsAsync(ListPwnedPasswordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPwnedPasswordsResponse>(await DoRPCRequestAsync("ListPwnedPasswords", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPwnedPasswordsResponse ListPwnedPasswords(ListPwnedPasswordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPwnedPasswordsWithOptions(request, runtime);
        }

        public async Task<ListPwnedPasswordsResponse> ListPwnedPasswordsAsync(ListPwnedPasswordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPwnedPasswordsWithOptionsAsync(request, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(DoRPCRequest("ListUsers", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoRPCRequestAsync("ListUsers", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        public RegisterAuthenticatorResponse RegisterAuthenticatorWithOptions(RegisterAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterAuthenticatorResponse>(DoRPCRequest("RegisterAuthenticator", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterAuthenticatorResponse> RegisterAuthenticatorWithOptionsAsync(RegisterAuthenticatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterAuthenticatorResponse>(await DoRPCRequestAsync("RegisterAuthenticator", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterAuthenticatorResponse RegisterAuthenticator(RegisterAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterAuthenticatorWithOptions(request, runtime);
        }

        public async Task<RegisterAuthenticatorResponse> RegisterAuthenticatorAsync(RegisterAuthenticatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterAuthenticatorWithOptionsAsync(request, runtime);
        }

        public ServiceInvokeResponse ServiceInvokeWithOptions(ServiceInvokeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ServiceInvokeResponse>(DoRPCRequest("ServiceInvoke", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ServiceInvokeResponse> ServiceInvokeWithOptionsAsync(ServiceInvokeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ServiceInvokeResponse>(await DoRPCRequestAsync("ServiceInvoke", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ServiceInvokeResponse ServiceInvoke(ServiceInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ServiceInvokeWithOptions(request, runtime);
        }

        public async Task<ServiceInvokeResponse> ServiceInvokeAsync(ServiceInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ServiceInvokeWithOptionsAsync(request, runtime);
        }

        public UpdateAuthenticatorAttributeResponse UpdateAuthenticatorAttributeWithOptions(UpdateAuthenticatorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAuthenticatorAttributeResponse>(DoRPCRequest("UpdateAuthenticatorAttribute", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAuthenticatorAttributeResponse> UpdateAuthenticatorAttributeWithOptionsAsync(UpdateAuthenticatorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAuthenticatorAttributeResponse>(await DoRPCRequestAsync("UpdateAuthenticatorAttribute", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAuthenticatorAttributeResponse UpdateAuthenticatorAttribute(UpdateAuthenticatorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAuthenticatorAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateAuthenticatorAttributeResponse> UpdateAuthenticatorAttributeAsync(UpdateAuthenticatorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAuthenticatorAttributeWithOptionsAsync(request, runtime);
        }

        public VerifyUserAuthenticationResponse VerifyUserAuthenticationWithOptions(VerifyUserAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyUserAuthenticationResponse>(DoRPCRequest("VerifyUserAuthentication", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyUserAuthenticationResponse> VerifyUserAuthenticationWithOptionsAsync(VerifyUserAuthenticationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyUserAuthenticationResponse>(await DoRPCRequestAsync("VerifyUserAuthentication", "2021-05-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyUserAuthenticationResponse VerifyUserAuthentication(VerifyUserAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyUserAuthenticationWithOptions(request, runtime);
        }

        public async Task<VerifyUserAuthenticationResponse> VerifyUserAuthenticationAsync(VerifyUserAuthenticationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyUserAuthenticationWithOptionsAsync(request, runtime);
        }

    }
}
