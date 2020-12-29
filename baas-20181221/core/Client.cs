// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Baas20181221.Models;

namespace AlibabaCloud.SDK.Baas20181221
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "baas.aliyuncs.com"},
                {"cn-beijing", "baas.aliyuncs.com"},
                {"cn-zhangjiakou", "baas.aliyuncs.com"},
                {"cn-huhehaote", "baas.aliyuncs.com"},
                {"cn-shanghai", "baas.aliyuncs.com"},
                {"cn-shenzhen", "baas.aliyuncs.com"},
                {"cn-hongkong", "baas.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "baas.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-1", "baas.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "baas.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "baas.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "baas.ap-southeast-1.aliyuncs.com"},
                {"eu-central-1", "baas.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "baas.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("baas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AcceptFabricInvitationResponse AcceptFabricInvitationWithOptions(AcceptFabricInvitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AcceptFabricInvitationResponse>(DoRPCRequest("AcceptFabricInvitation", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AcceptFabricInvitationResponse> AcceptFabricInvitationWithOptionsAsync(AcceptFabricInvitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AcceptFabricInvitationResponse>(await DoRPCRequestAsync("AcceptFabricInvitation", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AcceptFabricInvitationResponse AcceptFabricInvitation(AcceptFabricInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptFabricInvitationWithOptions(request, runtime);
        }

        public async Task<AcceptFabricInvitationResponse> AcceptFabricInvitationAsync(AcceptFabricInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptFabricInvitationWithOptionsAsync(request, runtime);
        }

        public ApplyAntChainCertificateResponse ApplyAntChainCertificateWithOptions(ApplyAntChainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyAntChainCertificateResponse>(DoRPCRequest("ApplyAntChainCertificate", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplyAntChainCertificateResponse> ApplyAntChainCertificateWithOptionsAsync(ApplyAntChainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyAntChainCertificateResponse>(await DoRPCRequestAsync("ApplyAntChainCertificate", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplyAntChainCertificateResponse ApplyAntChainCertificate(ApplyAntChainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyAntChainCertificateWithOptions(request, runtime);
        }

        public async Task<ApplyAntChainCertificateResponse> ApplyAntChainCertificateAsync(ApplyAntChainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyAntChainCertificateWithOptionsAsync(request, runtime);
        }

        public ApplyAntChainCertificateWithKeyAutoCreationResponse ApplyAntChainCertificateWithKeyAutoCreationWithOptions(ApplyAntChainCertificateWithKeyAutoCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyAntChainCertificateWithKeyAutoCreationResponse>(DoRPCRequest("ApplyAntChainCertificateWithKeyAutoCreation", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplyAntChainCertificateWithKeyAutoCreationResponse> ApplyAntChainCertificateWithKeyAutoCreationWithOptionsAsync(ApplyAntChainCertificateWithKeyAutoCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyAntChainCertificateWithKeyAutoCreationResponse>(await DoRPCRequestAsync("ApplyAntChainCertificateWithKeyAutoCreation", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplyAntChainCertificateWithKeyAutoCreationResponse ApplyAntChainCertificateWithKeyAutoCreation(ApplyAntChainCertificateWithKeyAutoCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyAntChainCertificateWithKeyAutoCreationWithOptions(request, runtime);
        }

        public async Task<ApplyAntChainCertificateWithKeyAutoCreationResponse> ApplyAntChainCertificateWithKeyAutoCreationAsync(ApplyAntChainCertificateWithKeyAutoCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyAntChainCertificateWithKeyAutoCreationWithOptionsAsync(request, runtime);
        }

        public BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse BatchAddAntChainMiniAppQRCodeAuthorizedUsersWithOptions(BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchAddAntChainMiniAppQRCodeAuthorizedUsersShrinkRequest request = new BatchAddAntChainMiniAppQRCodeAuthorizedUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhoneList))
            {
                request.PhoneListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhoneList, "PhoneList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse>(DoRPCRequest("BatchAddAntChainMiniAppQRCodeAuthorizedUsers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse> BatchAddAntChainMiniAppQRCodeAuthorizedUsersWithOptionsAsync(BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchAddAntChainMiniAppQRCodeAuthorizedUsersShrinkRequest request = new BatchAddAntChainMiniAppQRCodeAuthorizedUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhoneList))
            {
                request.PhoneListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhoneList, "PhoneList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse>(await DoRPCRequestAsync("BatchAddAntChainMiniAppQRCodeAuthorizedUsers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse BatchAddAntChainMiniAppQRCodeAuthorizedUsers(BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddAntChainMiniAppQRCodeAuthorizedUsersWithOptions(request, runtime);
        }

        public async Task<BatchAddAntChainMiniAppQRCodeAuthorizedUsersResponse> BatchAddAntChainMiniAppQRCodeAuthorizedUsersAsync(BatchAddAntChainMiniAppQRCodeAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddAntChainMiniAppQRCodeAuthorizedUsersWithOptionsAsync(request, runtime);
        }

        public CheckFabricConsortiumDomainResponse CheckFabricConsortiumDomainWithOptions(CheckFabricConsortiumDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckFabricConsortiumDomainResponse>(DoRPCRequest("CheckFabricConsortiumDomain", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckFabricConsortiumDomainResponse> CheckFabricConsortiumDomainWithOptionsAsync(CheckFabricConsortiumDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckFabricConsortiumDomainResponse>(await DoRPCRequestAsync("CheckFabricConsortiumDomain", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckFabricConsortiumDomainResponse CheckFabricConsortiumDomain(CheckFabricConsortiumDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFabricConsortiumDomainWithOptions(request, runtime);
        }

        public async Task<CheckFabricConsortiumDomainResponse> CheckFabricConsortiumDomainAsync(CheckFabricConsortiumDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFabricConsortiumDomainWithOptionsAsync(request, runtime);
        }

        public CheckFabricOrganizationDomainResponse CheckFabricOrganizationDomainWithOptions(CheckFabricOrganizationDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckFabricOrganizationDomainResponse>(DoRPCRequest("CheckFabricOrganizationDomain", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckFabricOrganizationDomainResponse> CheckFabricOrganizationDomainWithOptionsAsync(CheckFabricOrganizationDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckFabricOrganizationDomainResponse>(await DoRPCRequestAsync("CheckFabricOrganizationDomain", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckFabricOrganizationDomainResponse CheckFabricOrganizationDomain(CheckFabricOrganizationDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFabricOrganizationDomainWithOptions(request, runtime);
        }

        public async Task<CheckFabricOrganizationDomainResponse> CheckFabricOrganizationDomainAsync(CheckFabricOrganizationDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFabricOrganizationDomainWithOptionsAsync(request, runtime);
        }

        public ConfirmFabricConsortiumMemberResponse ConfirmFabricConsortiumMemberWithOptions(ConfirmFabricConsortiumMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfirmFabricConsortiumMemberResponse>(DoRPCRequest("ConfirmFabricConsortiumMember", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfirmFabricConsortiumMemberResponse> ConfirmFabricConsortiumMemberWithOptionsAsync(ConfirmFabricConsortiumMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfirmFabricConsortiumMemberResponse>(await DoRPCRequestAsync("ConfirmFabricConsortiumMember", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfirmFabricConsortiumMemberResponse ConfirmFabricConsortiumMember(ConfirmFabricConsortiumMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmFabricConsortiumMemberWithOptions(request, runtime);
        }

        public async Task<ConfirmFabricConsortiumMemberResponse> ConfirmFabricConsortiumMemberAsync(ConfirmFabricConsortiumMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmFabricConsortiumMemberWithOptionsAsync(request, runtime);
        }

        public CopyAntChainContractProjectResponse CopyAntChainContractProjectWithOptions(CopyAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyAntChainContractProjectResponse>(DoRPCRequest("CopyAntChainContractProject", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CopyAntChainContractProjectResponse> CopyAntChainContractProjectWithOptionsAsync(CopyAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyAntChainContractProjectResponse>(await DoRPCRequestAsync("CopyAntChainContractProject", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CopyAntChainContractProjectResponse CopyAntChainContractProject(CopyAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyAntChainContractProjectWithOptions(request, runtime);
        }

        public async Task<CopyAntChainContractProjectResponse> CopyAntChainContractProjectAsync(CopyAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyAntChainContractProjectWithOptionsAsync(request, runtime);
        }

        public CreateAntChainAccountResponse CreateAntChainAccountWithOptions(CreateAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntChainAccountResponse>(DoRPCRequest("CreateAntChainAccount", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAntChainAccountResponse> CreateAntChainAccountWithOptionsAsync(CreateAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntChainAccountResponse>(await DoRPCRequestAsync("CreateAntChainAccount", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAntChainAccountResponse CreateAntChainAccount(CreateAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainAccountWithOptions(request, runtime);
        }

        public async Task<CreateAntChainAccountResponse> CreateAntChainAccountAsync(CreateAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainAccountWithOptionsAsync(request, runtime);
        }

        public CreateAntChainAccountWithKeyPairAutoCreationResponse CreateAntChainAccountWithKeyPairAutoCreationWithOptions(CreateAntChainAccountWithKeyPairAutoCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntChainAccountWithKeyPairAutoCreationResponse>(DoRPCRequest("CreateAntChainAccountWithKeyPairAutoCreation", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAntChainAccountWithKeyPairAutoCreationResponse> CreateAntChainAccountWithKeyPairAutoCreationWithOptionsAsync(CreateAntChainAccountWithKeyPairAutoCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntChainAccountWithKeyPairAutoCreationResponse>(await DoRPCRequestAsync("CreateAntChainAccountWithKeyPairAutoCreation", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAntChainAccountWithKeyPairAutoCreationResponse CreateAntChainAccountWithKeyPairAutoCreation(CreateAntChainAccountWithKeyPairAutoCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainAccountWithKeyPairAutoCreationWithOptions(request, runtime);
        }

        public async Task<CreateAntChainAccountWithKeyPairAutoCreationResponse> CreateAntChainAccountWithKeyPairAutoCreationAsync(CreateAntChainAccountWithKeyPairAutoCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainAccountWithKeyPairAutoCreationWithOptionsAsync(request, runtime);
        }

        public CreateAntChainConsortiumResponse CreateAntChainConsortiumWithOptions(CreateAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntChainConsortiumResponse>(DoRPCRequest("CreateAntChainConsortium", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAntChainConsortiumResponse> CreateAntChainConsortiumWithOptionsAsync(CreateAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntChainConsortiumResponse>(await DoRPCRequestAsync("CreateAntChainConsortium", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAntChainConsortiumResponse CreateAntChainConsortium(CreateAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainConsortiumWithOptions(request, runtime);
        }

        public async Task<CreateAntChainConsortiumResponse> CreateAntChainConsortiumAsync(CreateAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainConsortiumWithOptionsAsync(request, runtime);
        }

        public CreateAntChainContractContentResponse CreateAntChainContractContentWithOptions(CreateAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntChainContractContentResponse>(DoRPCRequest("CreateAntChainContractContent", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAntChainContractContentResponse> CreateAntChainContractContentWithOptionsAsync(CreateAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntChainContractContentResponse>(await DoRPCRequestAsync("CreateAntChainContractContent", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAntChainContractContentResponse CreateAntChainContractContent(CreateAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainContractContentWithOptions(request, runtime);
        }

        public async Task<CreateAntChainContractContentResponse> CreateAntChainContractContentAsync(CreateAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainContractContentWithOptionsAsync(request, runtime);
        }

        public CreateAntChainContractProjectResponse CreateAntChainContractProjectWithOptions(CreateAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntChainContractProjectResponse>(DoRPCRequest("CreateAntChainContractProject", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAntChainContractProjectResponse> CreateAntChainContractProjectWithOptionsAsync(CreateAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAntChainContractProjectResponse>(await DoRPCRequestAsync("CreateAntChainContractProject", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAntChainContractProjectResponse CreateAntChainContractProject(CreateAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAntChainContractProjectWithOptions(request, runtime);
        }

        public async Task<CreateAntChainContractProjectResponse> CreateAntChainContractProjectAsync(CreateAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAntChainContractProjectWithOptionsAsync(request, runtime);
        }

        public CreateFabricChaincodeResponse CreateFabricChaincodeWithOptions(CreateFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricChaincodeResponse>(DoRPCRequest("CreateFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFabricChaincodeResponse> CreateFabricChaincodeWithOptionsAsync(CreateFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricChaincodeResponse>(await DoRPCRequestAsync("CreateFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFabricChaincodeResponse CreateFabricChaincode(CreateFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricChaincodeWithOptions(request, runtime);
        }

        public async Task<CreateFabricChaincodeResponse> CreateFabricChaincodeAsync(CreateFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricChaincodeWithOptionsAsync(request, runtime);
        }

        public CreateFabricChannelResponse CreateFabricChannelWithOptions(CreateFabricChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricChannelResponse>(DoRPCRequest("CreateFabricChannel", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFabricChannelResponse> CreateFabricChannelWithOptionsAsync(CreateFabricChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricChannelResponse>(await DoRPCRequestAsync("CreateFabricChannel", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFabricChannelResponse CreateFabricChannel(CreateFabricChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricChannelWithOptions(request, runtime);
        }

        public async Task<CreateFabricChannelResponse> CreateFabricChannelAsync(CreateFabricChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricChannelWithOptionsAsync(request, runtime);
        }

        public CreateFabricChannelMemberResponse CreateFabricChannelMemberWithOptions(CreateFabricChannelMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricChannelMemberResponse>(DoRPCRequest("CreateFabricChannelMember", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFabricChannelMemberResponse> CreateFabricChannelMemberWithOptionsAsync(CreateFabricChannelMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricChannelMemberResponse>(await DoRPCRequestAsync("CreateFabricChannelMember", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFabricChannelMemberResponse CreateFabricChannelMember(CreateFabricChannelMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricChannelMemberWithOptions(request, runtime);
        }

        public async Task<CreateFabricChannelMemberResponse> CreateFabricChannelMemberAsync(CreateFabricChannelMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricChannelMemberWithOptionsAsync(request, runtime);
        }

        public CreateFabricConsortiumResponse CreateFabricConsortiumWithOptions(CreateFabricConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricConsortiumResponse>(DoRPCRequest("CreateFabricConsortium", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFabricConsortiumResponse> CreateFabricConsortiumWithOptionsAsync(CreateFabricConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricConsortiumResponse>(await DoRPCRequestAsync("CreateFabricConsortium", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFabricConsortiumResponse CreateFabricConsortium(CreateFabricConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricConsortiumWithOptions(request, runtime);
        }

        public async Task<CreateFabricConsortiumResponse> CreateFabricConsortiumAsync(CreateFabricConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricConsortiumWithOptionsAsync(request, runtime);
        }

        public CreateFabricConsortiumMemberResponse CreateFabricConsortiumMemberWithOptions(CreateFabricConsortiumMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricConsortiumMemberResponse>(DoRPCRequest("CreateFabricConsortiumMember", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFabricConsortiumMemberResponse> CreateFabricConsortiumMemberWithOptionsAsync(CreateFabricConsortiumMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricConsortiumMemberResponse>(await DoRPCRequestAsync("CreateFabricConsortiumMember", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFabricConsortiumMemberResponse CreateFabricConsortiumMember(CreateFabricConsortiumMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricConsortiumMemberWithOptions(request, runtime);
        }

        public async Task<CreateFabricConsortiumMemberResponse> CreateFabricConsortiumMemberAsync(CreateFabricConsortiumMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricConsortiumMemberWithOptionsAsync(request, runtime);
        }

        public CreateFabricOrganizationResponse CreateFabricOrganizationWithOptions(CreateFabricOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricOrganizationResponse>(DoRPCRequest("CreateFabricOrganization", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFabricOrganizationResponse> CreateFabricOrganizationWithOptionsAsync(CreateFabricOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricOrganizationResponse>(await DoRPCRequestAsync("CreateFabricOrganization", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFabricOrganizationResponse CreateFabricOrganization(CreateFabricOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricOrganizationWithOptions(request, runtime);
        }

        public async Task<CreateFabricOrganizationResponse> CreateFabricOrganizationAsync(CreateFabricOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricOrganizationWithOptionsAsync(request, runtime);
        }

        public CreateFabricOrganizationUserResponse CreateFabricOrganizationUserWithOptions(CreateFabricOrganizationUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricOrganizationUserResponse>(DoRPCRequest("CreateFabricOrganizationUser", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFabricOrganizationUserResponse> CreateFabricOrganizationUserWithOptionsAsync(CreateFabricOrganizationUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFabricOrganizationUserResponse>(await DoRPCRequestAsync("CreateFabricOrganizationUser", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFabricOrganizationUserResponse CreateFabricOrganizationUser(CreateFabricOrganizationUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFabricOrganizationUserWithOptions(request, runtime);
        }

        public async Task<CreateFabricOrganizationUserResponse> CreateFabricOrganizationUserAsync(CreateFabricOrganizationUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFabricOrganizationUserWithOptionsAsync(request, runtime);
        }

        public DeleteAntChainConsortiumResponse DeleteAntChainConsortiumWithOptions(DeleteAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAntChainConsortiumResponse>(DoRPCRequest("DeleteAntChainConsortium", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAntChainConsortiumResponse> DeleteAntChainConsortiumWithOptionsAsync(DeleteAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAntChainConsortiumResponse>(await DoRPCRequestAsync("DeleteAntChainConsortium", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAntChainConsortiumResponse DeleteAntChainConsortium(DeleteAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAntChainConsortiumWithOptions(request, runtime);
        }

        public async Task<DeleteAntChainConsortiumResponse> DeleteAntChainConsortiumAsync(DeleteAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAntChainConsortiumWithOptionsAsync(request, runtime);
        }

        public DeleteAntChainContractContentResponse DeleteAntChainContractContentWithOptions(DeleteAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAntChainContractContentResponse>(DoRPCRequest("DeleteAntChainContractContent", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAntChainContractContentResponse> DeleteAntChainContractContentWithOptionsAsync(DeleteAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAntChainContractContentResponse>(await DoRPCRequestAsync("DeleteAntChainContractContent", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAntChainContractContentResponse DeleteAntChainContractContent(DeleteAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAntChainContractContentWithOptions(request, runtime);
        }

        public async Task<DeleteAntChainContractContentResponse> DeleteAntChainContractContentAsync(DeleteAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAntChainContractContentWithOptionsAsync(request, runtime);
        }

        public DeleteAntChainContractProjectResponse DeleteAntChainContractProjectWithOptions(DeleteAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAntChainContractProjectResponse>(DoRPCRequest("DeleteAntChainContractProject", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAntChainContractProjectResponse> DeleteAntChainContractProjectWithOptionsAsync(DeleteAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAntChainContractProjectResponse>(await DoRPCRequestAsync("DeleteAntChainContractProject", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAntChainContractProjectResponse DeleteAntChainContractProject(DeleteAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAntChainContractProjectWithOptions(request, runtime);
        }

        public async Task<DeleteAntChainContractProjectResponse> DeleteAntChainContractProjectAsync(DeleteAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAntChainContractProjectWithOptionsAsync(request, runtime);
        }

        public DeleteAntChainMiniAppQRCodeAuthorizedUserResponse DeleteAntChainMiniAppQRCodeAuthorizedUserWithOptions(DeleteAntChainMiniAppQRCodeAuthorizedUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAntChainMiniAppQRCodeAuthorizedUserResponse>(DoRPCRequest("DeleteAntChainMiniAppQRCodeAuthorizedUser", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAntChainMiniAppQRCodeAuthorizedUserResponse> DeleteAntChainMiniAppQRCodeAuthorizedUserWithOptionsAsync(DeleteAntChainMiniAppQRCodeAuthorizedUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAntChainMiniAppQRCodeAuthorizedUserResponse>(await DoRPCRequestAsync("DeleteAntChainMiniAppQRCodeAuthorizedUser", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAntChainMiniAppQRCodeAuthorizedUserResponse DeleteAntChainMiniAppQRCodeAuthorizedUser(DeleteAntChainMiniAppQRCodeAuthorizedUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAntChainMiniAppQRCodeAuthorizedUserWithOptions(request, runtime);
        }

        public async Task<DeleteAntChainMiniAppQRCodeAuthorizedUserResponse> DeleteAntChainMiniAppQRCodeAuthorizedUserAsync(DeleteAntChainMiniAppQRCodeAuthorizedUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAntChainMiniAppQRCodeAuthorizedUserWithOptionsAsync(request, runtime);
        }

        public DeleteFabricChaincodeResponse DeleteFabricChaincodeWithOptions(DeleteFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFabricChaincodeResponse>(DoRPCRequest("DeleteFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFabricChaincodeResponse> DeleteFabricChaincodeWithOptionsAsync(DeleteFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFabricChaincodeResponse>(await DoRPCRequestAsync("DeleteFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFabricChaincodeResponse DeleteFabricChaincode(DeleteFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFabricChaincodeWithOptions(request, runtime);
        }

        public async Task<DeleteFabricChaincodeResponse> DeleteFabricChaincodeAsync(DeleteFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFabricChaincodeWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainAccountsResponse DescribeAntChainAccountsWithOptions(DescribeAntChainAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainAccountsResponse>(DoRPCRequest("DescribeAntChainAccounts", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainAccountsResponse> DescribeAntChainAccountsWithOptionsAsync(DescribeAntChainAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainAccountsResponse>(await DoRPCRequestAsync("DescribeAntChainAccounts", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainAccountsResponse DescribeAntChainAccounts(DescribeAntChainAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainAccountsWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainAccountsResponse> DescribeAntChainAccountsAsync(DescribeAntChainAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainAccountsWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainBlockResponse DescribeAntChainBlockWithOptions(DescribeAntChainBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainBlockResponse>(DoRPCRequest("DescribeAntChainBlock", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainBlockResponse> DescribeAntChainBlockWithOptionsAsync(DescribeAntChainBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainBlockResponse>(await DoRPCRequestAsync("DescribeAntChainBlock", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainBlockResponse DescribeAntChainBlock(DescribeAntChainBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainBlockWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainBlockResponse> DescribeAntChainBlockAsync(DescribeAntChainBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainBlockWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainCertificateApplicationsResponse DescribeAntChainCertificateApplicationsWithOptions(DescribeAntChainCertificateApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainCertificateApplicationsResponse>(DoRPCRequest("DescribeAntChainCertificateApplications", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainCertificateApplicationsResponse> DescribeAntChainCertificateApplicationsWithOptionsAsync(DescribeAntChainCertificateApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainCertificateApplicationsResponse>(await DoRPCRequestAsync("DescribeAntChainCertificateApplications", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainCertificateApplicationsResponse DescribeAntChainCertificateApplications(DescribeAntChainCertificateApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainCertificateApplicationsWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainCertificateApplicationsResponse> DescribeAntChainCertificateApplicationsAsync(DescribeAntChainCertificateApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainCertificateApplicationsWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainConsortiumsResponse DescribeAntChainConsortiumsWithOptions(DescribeAntChainConsortiumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainConsortiumsResponse>(DoRPCRequest("DescribeAntChainConsortiums", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainConsortiumsResponse> DescribeAntChainConsortiumsWithOptionsAsync(DescribeAntChainConsortiumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainConsortiumsResponse>(await DoRPCRequestAsync("DescribeAntChainConsortiums", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainConsortiumsResponse DescribeAntChainConsortiums(DescribeAntChainConsortiumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainConsortiumsWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainConsortiumsResponse> DescribeAntChainConsortiumsAsync(DescribeAntChainConsortiumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainConsortiumsWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainContractProjectContentTreeResponse DescribeAntChainContractProjectContentTreeWithOptions(DescribeAntChainContractProjectContentTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectContentTreeResponse>(DoRPCRequest("DescribeAntChainContractProjectContentTree", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainContractProjectContentTreeResponse> DescribeAntChainContractProjectContentTreeWithOptionsAsync(DescribeAntChainContractProjectContentTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectContentTreeResponse>(await DoRPCRequestAsync("DescribeAntChainContractProjectContentTree", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainContractProjectContentTreeResponse DescribeAntChainContractProjectContentTree(DescribeAntChainContractProjectContentTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainContractProjectContentTreeWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainContractProjectContentTreeResponse> DescribeAntChainContractProjectContentTreeAsync(DescribeAntChainContractProjectContentTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainContractProjectContentTreeWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainContractProjectsResponse DescribeAntChainContractProjectsWithOptions(DescribeAntChainContractProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectsResponse>(DoRPCRequest("DescribeAntChainContractProjects", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainContractProjectsResponse> DescribeAntChainContractProjectsWithOptionsAsync(DescribeAntChainContractProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainContractProjectsResponse>(await DoRPCRequestAsync("DescribeAntChainContractProjects", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainContractProjectsResponse DescribeAntChainContractProjects(DescribeAntChainContractProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainContractProjectsWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainContractProjectsResponse> DescribeAntChainContractProjectsAsync(DescribeAntChainContractProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainContractProjectsWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainDownloadPathsResponse DescribeAntChainDownloadPathsWithOptions(DescribeAntChainDownloadPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainDownloadPathsResponse>(DoRPCRequest("DescribeAntChainDownloadPaths", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainDownloadPathsResponse> DescribeAntChainDownloadPathsWithOptionsAsync(DescribeAntChainDownloadPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainDownloadPathsResponse>(await DoRPCRequestAsync("DescribeAntChainDownloadPaths", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainDownloadPathsResponse DescribeAntChainDownloadPaths(DescribeAntChainDownloadPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainDownloadPathsWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainDownloadPathsResponse> DescribeAntChainDownloadPathsAsync(DescribeAntChainDownloadPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainDownloadPathsWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainInformationResponse DescribeAntChainInformationWithOptions(DescribeAntChainInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainInformationResponse>(DoRPCRequest("DescribeAntChainInformation", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainInformationResponse> DescribeAntChainInformationWithOptionsAsync(DescribeAntChainInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainInformationResponse>(await DoRPCRequestAsync("DescribeAntChainInformation", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainInformationResponse DescribeAntChainInformation(DescribeAntChainInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainInformationWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainInformationResponse> DescribeAntChainInformationAsync(DescribeAntChainInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainInformationWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainLatestBlocksResponse DescribeAntChainLatestBlocksWithOptions(DescribeAntChainLatestBlocksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainLatestBlocksResponse>(DoRPCRequest("DescribeAntChainLatestBlocks", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainLatestBlocksResponse> DescribeAntChainLatestBlocksWithOptionsAsync(DescribeAntChainLatestBlocksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainLatestBlocksResponse>(await DoRPCRequestAsync("DescribeAntChainLatestBlocks", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainLatestBlocksResponse DescribeAntChainLatestBlocks(DescribeAntChainLatestBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainLatestBlocksWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainLatestBlocksResponse> DescribeAntChainLatestBlocksAsync(DescribeAntChainLatestBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainLatestBlocksWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainLatestTransactionDigestsResponse DescribeAntChainLatestTransactionDigestsWithOptions(DescribeAntChainLatestTransactionDigestsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainLatestTransactionDigestsResponse>(DoRPCRequest("DescribeAntChainLatestTransactionDigests", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainLatestTransactionDigestsResponse> DescribeAntChainLatestTransactionDigestsWithOptionsAsync(DescribeAntChainLatestTransactionDigestsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainLatestTransactionDigestsResponse>(await DoRPCRequestAsync("DescribeAntChainLatestTransactionDigests", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainLatestTransactionDigestsResponse DescribeAntChainLatestTransactionDigests(DescribeAntChainLatestTransactionDigestsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainLatestTransactionDigestsWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainLatestTransactionDigestsResponse> DescribeAntChainLatestTransactionDigestsAsync(DescribeAntChainLatestTransactionDigestsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainLatestTransactionDigestsWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainMembersResponse DescribeAntChainMembersWithOptions(DescribeAntChainMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainMembersResponse>(DoRPCRequest("DescribeAntChainMembers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainMembersResponse> DescribeAntChainMembersWithOptionsAsync(DescribeAntChainMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainMembersResponse>(await DoRPCRequestAsync("DescribeAntChainMembers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainMembersResponse DescribeAntChainMembers(DescribeAntChainMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMembersWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainMembersResponse> DescribeAntChainMembersAsync(DescribeAntChainMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMembersWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse DescribeAntChainMiniAppBrowserQRCodeAccessLogWithOptions(DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse>(DoRPCRequest("DescribeAntChainMiniAppBrowserQRCodeAccessLog", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse> DescribeAntChainMiniAppBrowserQRCodeAccessLogWithOptionsAsync(DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse>(await DoRPCRequestAsync("DescribeAntChainMiniAppBrowserQRCodeAccessLog", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse DescribeAntChainMiniAppBrowserQRCodeAccessLog(DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMiniAppBrowserQRCodeAccessLogWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainMiniAppBrowserQRCodeAccessLogResponse> DescribeAntChainMiniAppBrowserQRCodeAccessLogAsync(DescribeAntChainMiniAppBrowserQRCodeAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMiniAppBrowserQRCodeAccessLogWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersWithOptions(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse>(DoRPCRequest("DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse> DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersWithOptionsAsync(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse>(await DoRPCRequestAsync("DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsers(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersResponse> DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersAsync(DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMiniAppBrowserQRCodeAuthorizedUsersWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainMiniAppBrowserTransactionQRCodeResponse DescribeAntChainMiniAppBrowserTransactionQRCodeWithOptions(DescribeAntChainMiniAppBrowserTransactionQRCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserTransactionQRCodeResponse>(DoRPCRequest("DescribeAntChainMiniAppBrowserTransactionQRCode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainMiniAppBrowserTransactionQRCodeResponse> DescribeAntChainMiniAppBrowserTransactionQRCodeWithOptionsAsync(DescribeAntChainMiniAppBrowserTransactionQRCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainMiniAppBrowserTransactionQRCodeResponse>(await DoRPCRequestAsync("DescribeAntChainMiniAppBrowserTransactionQRCode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainMiniAppBrowserTransactionQRCodeResponse DescribeAntChainMiniAppBrowserTransactionQRCode(DescribeAntChainMiniAppBrowserTransactionQRCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainMiniAppBrowserTransactionQRCodeWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainMiniAppBrowserTransactionQRCodeResponse> DescribeAntChainMiniAppBrowserTransactionQRCodeAsync(DescribeAntChainMiniAppBrowserTransactionQRCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainMiniAppBrowserTransactionQRCodeWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainNodesResponse DescribeAntChainNodesWithOptions(DescribeAntChainNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainNodesResponse>(DoRPCRequest("DescribeAntChainNodes", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainNodesResponse> DescribeAntChainNodesWithOptionsAsync(DescribeAntChainNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainNodesResponse>(await DoRPCRequestAsync("DescribeAntChainNodes", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainNodesResponse DescribeAntChainNodes(DescribeAntChainNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainNodesWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainNodesResponse> DescribeAntChainNodesAsync(DescribeAntChainNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainNodesWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainQRCodeAuthorizationResponse DescribeAntChainQRCodeAuthorizationWithOptions(DescribeAntChainQRCodeAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainQRCodeAuthorizationResponse>(DoRPCRequest("DescribeAntChainQRCodeAuthorization", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainQRCodeAuthorizationResponse> DescribeAntChainQRCodeAuthorizationWithOptionsAsync(DescribeAntChainQRCodeAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainQRCodeAuthorizationResponse>(await DoRPCRequestAsync("DescribeAntChainQRCodeAuthorization", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainQRCodeAuthorizationResponse DescribeAntChainQRCodeAuthorization(DescribeAntChainQRCodeAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainQRCodeAuthorizationWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainQRCodeAuthorizationResponse> DescribeAntChainQRCodeAuthorizationAsync(DescribeAntChainQRCodeAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainQRCodeAuthorizationWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainsResponse DescribeAntChainsWithOptions(DescribeAntChainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainsResponse>(DoRPCRequest("DescribeAntChains", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainsResponse> DescribeAntChainsWithOptionsAsync(DescribeAntChainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainsResponse>(await DoRPCRequestAsync("DescribeAntChains", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainsResponse DescribeAntChains(DescribeAntChainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainsWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainsResponse> DescribeAntChainsAsync(DescribeAntChainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainsWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainTransactionResponse DescribeAntChainTransactionWithOptions(DescribeAntChainTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainTransactionResponse>(DoRPCRequest("DescribeAntChainTransaction", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainTransactionResponse> DescribeAntChainTransactionWithOptionsAsync(DescribeAntChainTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainTransactionResponse>(await DoRPCRequestAsync("DescribeAntChainTransaction", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainTransactionResponse DescribeAntChainTransaction(DescribeAntChainTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainTransactionWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainTransactionResponse> DescribeAntChainTransactionAsync(DescribeAntChainTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainTransactionWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainTransactionReceiptResponse DescribeAntChainTransactionReceiptWithOptions(DescribeAntChainTransactionReceiptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainTransactionReceiptResponse>(DoRPCRequest("DescribeAntChainTransactionReceipt", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainTransactionReceiptResponse> DescribeAntChainTransactionReceiptWithOptionsAsync(DescribeAntChainTransactionReceiptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainTransactionReceiptResponse>(await DoRPCRequestAsync("DescribeAntChainTransactionReceipt", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainTransactionReceiptResponse DescribeAntChainTransactionReceipt(DescribeAntChainTransactionReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainTransactionReceiptWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainTransactionReceiptResponse> DescribeAntChainTransactionReceiptAsync(DescribeAntChainTransactionReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainTransactionReceiptWithOptionsAsync(request, runtime);
        }

        public DescribeAntChainTransactionStatisticsResponse DescribeAntChainTransactionStatisticsWithOptions(DescribeAntChainTransactionStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainTransactionStatisticsResponse>(DoRPCRequest("DescribeAntChainTransactionStatistics", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAntChainTransactionStatisticsResponse> DescribeAntChainTransactionStatisticsWithOptionsAsync(DescribeAntChainTransactionStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAntChainTransactionStatisticsResponse>(await DoRPCRequestAsync("DescribeAntChainTransactionStatistics", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAntChainTransactionStatisticsResponse DescribeAntChainTransactionStatistics(DescribeAntChainTransactionStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAntChainTransactionStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeAntChainTransactionStatisticsResponse> DescribeAntChainTransactionStatisticsAsync(DescribeAntChainTransactionStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAntChainTransactionStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeEthereumDeletableResponse DescribeEthereumDeletableWithOptions(DescribeEthereumDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEthereumDeletableResponse>(DoRPCRequest("DescribeEthereumDeletable", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEthereumDeletableResponse> DescribeEthereumDeletableWithOptionsAsync(DescribeEthereumDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEthereumDeletableResponse>(await DoRPCRequestAsync("DescribeEthereumDeletable", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEthereumDeletableResponse DescribeEthereumDeletable(DescribeEthereumDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEthereumDeletableWithOptions(request, runtime);
        }

        public async Task<DescribeEthereumDeletableResponse> DescribeEthereumDeletableAsync(DescribeEthereumDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEthereumDeletableWithOptionsAsync(request, runtime);
        }

        public DescribeFabricCandidateOrganizationsResponse DescribeFabricCandidateOrganizationsWithOptions(DescribeFabricCandidateOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricCandidateOrganizationsResponse>(DoRPCRequest("DescribeFabricCandidateOrganizations", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricCandidateOrganizationsResponse> DescribeFabricCandidateOrganizationsWithOptionsAsync(DescribeFabricCandidateOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricCandidateOrganizationsResponse>(await DoRPCRequestAsync("DescribeFabricCandidateOrganizations", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricCandidateOrganizationsResponse DescribeFabricCandidateOrganizations(DescribeFabricCandidateOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricCandidateOrganizationsWithOptions(request, runtime);
        }

        public async Task<DescribeFabricCandidateOrganizationsResponse> DescribeFabricCandidateOrganizationsAsync(DescribeFabricCandidateOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricCandidateOrganizationsWithOptionsAsync(request, runtime);
        }

        public DescribeFabricChaincodeUploadPolicyResponse DescribeFabricChaincodeUploadPolicyWithOptions(DescribeFabricChaincodeUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricChaincodeUploadPolicyResponse>(DoRPCRequest("DescribeFabricChaincodeUploadPolicy", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricChaincodeUploadPolicyResponse> DescribeFabricChaincodeUploadPolicyWithOptionsAsync(DescribeFabricChaincodeUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricChaincodeUploadPolicyResponse>(await DoRPCRequestAsync("DescribeFabricChaincodeUploadPolicy", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricChaincodeUploadPolicyResponse DescribeFabricChaincodeUploadPolicy(DescribeFabricChaincodeUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricChaincodeUploadPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeFabricChaincodeUploadPolicyResponse> DescribeFabricChaincodeUploadPolicyAsync(DescribeFabricChaincodeUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricChaincodeUploadPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeFabricChannelMembersResponse DescribeFabricChannelMembersWithOptions(DescribeFabricChannelMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricChannelMembersResponse>(DoRPCRequest("DescribeFabricChannelMembers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricChannelMembersResponse> DescribeFabricChannelMembersWithOptionsAsync(DescribeFabricChannelMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricChannelMembersResponse>(await DoRPCRequestAsync("DescribeFabricChannelMembers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricChannelMembersResponse DescribeFabricChannelMembers(DescribeFabricChannelMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricChannelMembersWithOptions(request, runtime);
        }

        public async Task<DescribeFabricChannelMembersResponse> DescribeFabricChannelMembersAsync(DescribeFabricChannelMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricChannelMembersWithOptionsAsync(request, runtime);
        }

        public DescribeFabricConsortiumAdminStatusResponse DescribeFabricConsortiumAdminStatusWithOptions(DescribeFabricConsortiumAdminStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumAdminStatusResponse>(DoRPCRequest("DescribeFabricConsortiumAdminStatus", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricConsortiumAdminStatusResponse> DescribeFabricConsortiumAdminStatusWithOptionsAsync(DescribeFabricConsortiumAdminStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumAdminStatusResponse>(await DoRPCRequestAsync("DescribeFabricConsortiumAdminStatus", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricConsortiumAdminStatusResponse DescribeFabricConsortiumAdminStatus(DescribeFabricConsortiumAdminStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumAdminStatusWithOptions(request, runtime);
        }

        public async Task<DescribeFabricConsortiumAdminStatusResponse> DescribeFabricConsortiumAdminStatusAsync(DescribeFabricConsortiumAdminStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumAdminStatusWithOptionsAsync(request, runtime);
        }

        public DescribeFabricConsortiumChaincodesResponse DescribeFabricConsortiumChaincodesWithOptions(DescribeFabricConsortiumChaincodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumChaincodesResponse>(DoRPCRequest("DescribeFabricConsortiumChaincodes", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricConsortiumChaincodesResponse> DescribeFabricConsortiumChaincodesWithOptionsAsync(DescribeFabricConsortiumChaincodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumChaincodesResponse>(await DoRPCRequestAsync("DescribeFabricConsortiumChaincodes", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricConsortiumChaincodesResponse DescribeFabricConsortiumChaincodes(DescribeFabricConsortiumChaincodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumChaincodesWithOptions(request, runtime);
        }

        public async Task<DescribeFabricConsortiumChaincodesResponse> DescribeFabricConsortiumChaincodesAsync(DescribeFabricConsortiumChaincodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumChaincodesWithOptionsAsync(request, runtime);
        }

        public DescribeFabricConsortiumChannelsResponse DescribeFabricConsortiumChannelsWithOptions(DescribeFabricConsortiumChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumChannelsResponse>(DoRPCRequest("DescribeFabricConsortiumChannels", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricConsortiumChannelsResponse> DescribeFabricConsortiumChannelsWithOptionsAsync(DescribeFabricConsortiumChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumChannelsResponse>(await DoRPCRequestAsync("DescribeFabricConsortiumChannels", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricConsortiumChannelsResponse DescribeFabricConsortiumChannels(DescribeFabricConsortiumChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumChannelsWithOptions(request, runtime);
        }

        public async Task<DescribeFabricConsortiumChannelsResponse> DescribeFabricConsortiumChannelsAsync(DescribeFabricConsortiumChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumChannelsWithOptionsAsync(request, runtime);
        }

        public DescribeFabricConsortiumConfigResponse DescribeFabricConsortiumConfigWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeFabricConsortiumConfigResponse>(DoRPCRequest("DescribeFabricConsortiumConfig", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricConsortiumConfigResponse> DescribeFabricConsortiumConfigWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeFabricConsortiumConfigResponse>(await DoRPCRequestAsync("DescribeFabricConsortiumConfig", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricConsortiumConfigResponse DescribeFabricConsortiumConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumConfigWithOptions(runtime);
        }

        public async Task<DescribeFabricConsortiumConfigResponse> DescribeFabricConsortiumConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumConfigWithOptionsAsync(runtime);
        }

        public DescribeFabricConsortiumDeletableResponse DescribeFabricConsortiumDeletableWithOptions(DescribeFabricConsortiumDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumDeletableResponse>(DoRPCRequest("DescribeFabricConsortiumDeletable", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricConsortiumDeletableResponse> DescribeFabricConsortiumDeletableWithOptionsAsync(DescribeFabricConsortiumDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumDeletableResponse>(await DoRPCRequestAsync("DescribeFabricConsortiumDeletable", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricConsortiumDeletableResponse DescribeFabricConsortiumDeletable(DescribeFabricConsortiumDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumDeletableWithOptions(request, runtime);
        }

        public async Task<DescribeFabricConsortiumDeletableResponse> DescribeFabricConsortiumDeletableAsync(DescribeFabricConsortiumDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumDeletableWithOptionsAsync(request, runtime);
        }

        public DescribeFabricConsortiumMemberApprovalResponse DescribeFabricConsortiumMemberApprovalWithOptions(DescribeFabricConsortiumMemberApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumMemberApprovalResponse>(DoRPCRequest("DescribeFabricConsortiumMemberApproval", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricConsortiumMemberApprovalResponse> DescribeFabricConsortiumMemberApprovalWithOptionsAsync(DescribeFabricConsortiumMemberApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumMemberApprovalResponse>(await DoRPCRequestAsync("DescribeFabricConsortiumMemberApproval", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricConsortiumMemberApprovalResponse DescribeFabricConsortiumMemberApproval(DescribeFabricConsortiumMemberApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumMemberApprovalWithOptions(request, runtime);
        }

        public async Task<DescribeFabricConsortiumMemberApprovalResponse> DescribeFabricConsortiumMemberApprovalAsync(DescribeFabricConsortiumMemberApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumMemberApprovalWithOptionsAsync(request, runtime);
        }

        public DescribeFabricConsortiumMembersResponse DescribeFabricConsortiumMembersWithOptions(DescribeFabricConsortiumMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumMembersResponse>(DoRPCRequest("DescribeFabricConsortiumMembers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricConsortiumMembersResponse> DescribeFabricConsortiumMembersWithOptionsAsync(DescribeFabricConsortiumMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumMembersResponse>(await DoRPCRequestAsync("DescribeFabricConsortiumMembers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricConsortiumMembersResponse DescribeFabricConsortiumMembers(DescribeFabricConsortiumMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumMembersWithOptions(request, runtime);
        }

        public async Task<DescribeFabricConsortiumMembersResponse> DescribeFabricConsortiumMembersAsync(DescribeFabricConsortiumMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumMembersWithOptionsAsync(request, runtime);
        }

        public DescribeFabricConsortiumOrderersResponse DescribeFabricConsortiumOrderersWithOptions(DescribeFabricConsortiumOrderersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumOrderersResponse>(DoRPCRequest("DescribeFabricConsortiumOrderers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricConsortiumOrderersResponse> DescribeFabricConsortiumOrderersWithOptionsAsync(DescribeFabricConsortiumOrderersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumOrderersResponse>(await DoRPCRequestAsync("DescribeFabricConsortiumOrderers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricConsortiumOrderersResponse DescribeFabricConsortiumOrderers(DescribeFabricConsortiumOrderersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumOrderersWithOptions(request, runtime);
        }

        public async Task<DescribeFabricConsortiumOrderersResponse> DescribeFabricConsortiumOrderersAsync(DescribeFabricConsortiumOrderersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumOrderersWithOptionsAsync(request, runtime);
        }

        public DescribeFabricConsortiumsResponse DescribeFabricConsortiumsWithOptions(DescribeFabricConsortiumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumsResponse>(DoRPCRequest("DescribeFabricConsortiums", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricConsortiumsResponse> DescribeFabricConsortiumsWithOptionsAsync(DescribeFabricConsortiumsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricConsortiumsResponse>(await DoRPCRequestAsync("DescribeFabricConsortiums", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricConsortiumsResponse DescribeFabricConsortiums(DescribeFabricConsortiumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumsWithOptions(request, runtime);
        }

        public async Task<DescribeFabricConsortiumsResponse> DescribeFabricConsortiumsAsync(DescribeFabricConsortiumsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumsWithOptionsAsync(request, runtime);
        }

        public DescribeFabricConsortiumSpecsResponse DescribeFabricConsortiumSpecsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeFabricConsortiumSpecsResponse>(DoRPCRequest("DescribeFabricConsortiumSpecs", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricConsortiumSpecsResponse> DescribeFabricConsortiumSpecsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeFabricConsortiumSpecsResponse>(await DoRPCRequestAsync("DescribeFabricConsortiumSpecs", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricConsortiumSpecsResponse DescribeFabricConsortiumSpecs()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricConsortiumSpecsWithOptions(runtime);
        }

        public async Task<DescribeFabricConsortiumSpecsResponse> DescribeFabricConsortiumSpecsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricConsortiumSpecsWithOptionsAsync(runtime);
        }

        public DescribeFabricExplorerResponse DescribeFabricExplorerWithOptions(DescribeFabricExplorerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricExplorerResponse>(DoRPCRequest("DescribeFabricExplorer", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricExplorerResponse> DescribeFabricExplorerWithOptionsAsync(DescribeFabricExplorerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricExplorerResponse>(await DoRPCRequestAsync("DescribeFabricExplorer", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricExplorerResponse DescribeFabricExplorer(DescribeFabricExplorerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricExplorerWithOptions(request, runtime);
        }

        public async Task<DescribeFabricExplorerResponse> DescribeFabricExplorerAsync(DescribeFabricExplorerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricExplorerWithOptionsAsync(request, runtime);
        }

        public DescribeFabricInvitationCodeResponse DescribeFabricInvitationCodeWithOptions(DescribeFabricInvitationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricInvitationCodeResponse>(DoRPCRequest("DescribeFabricInvitationCode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricInvitationCodeResponse> DescribeFabricInvitationCodeWithOptionsAsync(DescribeFabricInvitationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricInvitationCodeResponse>(await DoRPCRequestAsync("DescribeFabricInvitationCode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricInvitationCodeResponse DescribeFabricInvitationCode(DescribeFabricInvitationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricInvitationCodeWithOptions(request, runtime);
        }

        public async Task<DescribeFabricInvitationCodeResponse> DescribeFabricInvitationCodeAsync(DescribeFabricInvitationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricInvitationCodeWithOptionsAsync(request, runtime);
        }

        public DescribeFabricInviterResponse DescribeFabricInviterWithOptions(DescribeFabricInviterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricInviterResponse>(DoRPCRequest("DescribeFabricInviter", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricInviterResponse> DescribeFabricInviterWithOptionsAsync(DescribeFabricInviterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricInviterResponse>(await DoRPCRequestAsync("DescribeFabricInviter", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricInviterResponse DescribeFabricInviter(DescribeFabricInviterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricInviterWithOptions(request, runtime);
        }

        public async Task<DescribeFabricInviterResponse> DescribeFabricInviterAsync(DescribeFabricInviterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricInviterWithOptionsAsync(request, runtime);
        }

        public DescribeFabricOrdererLogsResponse DescribeFabricOrdererLogsWithOptions(DescribeFabricOrdererLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrdererLogsResponse>(DoRPCRequest("DescribeFabricOrdererLogs", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricOrdererLogsResponse> DescribeFabricOrdererLogsWithOptionsAsync(DescribeFabricOrdererLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrdererLogsResponse>(await DoRPCRequestAsync("DescribeFabricOrdererLogs", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricOrdererLogsResponse DescribeFabricOrdererLogs(DescribeFabricOrdererLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrdererLogsWithOptions(request, runtime);
        }

        public async Task<DescribeFabricOrdererLogsResponse> DescribeFabricOrdererLogsAsync(DescribeFabricOrdererLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrdererLogsWithOptionsAsync(request, runtime);
        }

        public DescribeFabricOrganizationResponse DescribeFabricOrganizationWithOptions(DescribeFabricOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationResponse>(DoRPCRequest("DescribeFabricOrganization", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricOrganizationResponse> DescribeFabricOrganizationWithOptionsAsync(DescribeFabricOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationResponse>(await DoRPCRequestAsync("DescribeFabricOrganization", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricOrganizationResponse DescribeFabricOrganization(DescribeFabricOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationWithOptions(request, runtime);
        }

        public async Task<DescribeFabricOrganizationResponse> DescribeFabricOrganizationAsync(DescribeFabricOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationWithOptionsAsync(request, runtime);
        }

        public DescribeFabricOrganizationChaincodesResponse DescribeFabricOrganizationChaincodesWithOptions(DescribeFabricOrganizationChaincodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationChaincodesResponse>(DoRPCRequest("DescribeFabricOrganizationChaincodes", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricOrganizationChaincodesResponse> DescribeFabricOrganizationChaincodesWithOptionsAsync(DescribeFabricOrganizationChaincodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationChaincodesResponse>(await DoRPCRequestAsync("DescribeFabricOrganizationChaincodes", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricOrganizationChaincodesResponse DescribeFabricOrganizationChaincodes(DescribeFabricOrganizationChaincodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationChaincodesWithOptions(request, runtime);
        }

        public async Task<DescribeFabricOrganizationChaincodesResponse> DescribeFabricOrganizationChaincodesAsync(DescribeFabricOrganizationChaincodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationChaincodesWithOptionsAsync(request, runtime);
        }

        public DescribeFabricOrganizationDeletableResponse DescribeFabricOrganizationDeletableWithOptions(DescribeFabricOrganizationDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationDeletableResponse>(DoRPCRequest("DescribeFabricOrganizationDeletable", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricOrganizationDeletableResponse> DescribeFabricOrganizationDeletableWithOptionsAsync(DescribeFabricOrganizationDeletableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationDeletableResponse>(await DoRPCRequestAsync("DescribeFabricOrganizationDeletable", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricOrganizationDeletableResponse DescribeFabricOrganizationDeletable(DescribeFabricOrganizationDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationDeletableWithOptions(request, runtime);
        }

        public async Task<DescribeFabricOrganizationDeletableResponse> DescribeFabricOrganizationDeletableAsync(DescribeFabricOrganizationDeletableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationDeletableWithOptionsAsync(request, runtime);
        }

        public DescribeFabricOrganizationMembersResponse DescribeFabricOrganizationMembersWithOptions(DescribeFabricOrganizationMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationMembersResponse>(DoRPCRequest("DescribeFabricOrganizationMembers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricOrganizationMembersResponse> DescribeFabricOrganizationMembersWithOptionsAsync(DescribeFabricOrganizationMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationMembersResponse>(await DoRPCRequestAsync("DescribeFabricOrganizationMembers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricOrganizationMembersResponse DescribeFabricOrganizationMembers(DescribeFabricOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationMembersWithOptions(request, runtime);
        }

        public async Task<DescribeFabricOrganizationMembersResponse> DescribeFabricOrganizationMembersAsync(DescribeFabricOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationMembersWithOptionsAsync(request, runtime);
        }

        public DescribeFabricOrganizationPeersResponse DescribeFabricOrganizationPeersWithOptions(DescribeFabricOrganizationPeersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationPeersResponse>(DoRPCRequest("DescribeFabricOrganizationPeers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricOrganizationPeersResponse> DescribeFabricOrganizationPeersWithOptionsAsync(DescribeFabricOrganizationPeersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationPeersResponse>(await DoRPCRequestAsync("DescribeFabricOrganizationPeers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricOrganizationPeersResponse DescribeFabricOrganizationPeers(DescribeFabricOrganizationPeersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationPeersWithOptions(request, runtime);
        }

        public async Task<DescribeFabricOrganizationPeersResponse> DescribeFabricOrganizationPeersAsync(DescribeFabricOrganizationPeersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationPeersWithOptionsAsync(request, runtime);
        }

        public DescribeFabricOrganizationsResponse DescribeFabricOrganizationsWithOptions(DescribeFabricOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationsResponse>(DoRPCRequest("DescribeFabricOrganizations", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricOrganizationsResponse> DescribeFabricOrganizationsWithOptionsAsync(DescribeFabricOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationsResponse>(await DoRPCRequestAsync("DescribeFabricOrganizations", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricOrganizationsResponse DescribeFabricOrganizations(DescribeFabricOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationsWithOptions(request, runtime);
        }

        public async Task<DescribeFabricOrganizationsResponse> DescribeFabricOrganizationsAsync(DescribeFabricOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationsWithOptionsAsync(request, runtime);
        }

        public DescribeFabricOrganizationSpecsResponse DescribeFabricOrganizationSpecsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeFabricOrganizationSpecsResponse>(DoRPCRequest("DescribeFabricOrganizationSpecs", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricOrganizationSpecsResponse> DescribeFabricOrganizationSpecsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeFabricOrganizationSpecsResponse>(await DoRPCRequestAsync("DescribeFabricOrganizationSpecs", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricOrganizationSpecsResponse DescribeFabricOrganizationSpecs()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationSpecsWithOptions(runtime);
        }

        public async Task<DescribeFabricOrganizationSpecsResponse> DescribeFabricOrganizationSpecsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationSpecsWithOptionsAsync(runtime);
        }

        public DescribeFabricOrganizationUsersResponse DescribeFabricOrganizationUsersWithOptions(DescribeFabricOrganizationUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationUsersResponse>(DoRPCRequest("DescribeFabricOrganizationUsers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricOrganizationUsersResponse> DescribeFabricOrganizationUsersWithOptionsAsync(DescribeFabricOrganizationUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricOrganizationUsersResponse>(await DoRPCRequestAsync("DescribeFabricOrganizationUsers", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricOrganizationUsersResponse DescribeFabricOrganizationUsers(DescribeFabricOrganizationUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricOrganizationUsersWithOptions(request, runtime);
        }

        public async Task<DescribeFabricOrganizationUsersResponse> DescribeFabricOrganizationUsersAsync(DescribeFabricOrganizationUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricOrganizationUsersWithOptionsAsync(request, runtime);
        }

        public DescribeFabricPeerLogsResponse DescribeFabricPeerLogsWithOptions(DescribeFabricPeerLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricPeerLogsResponse>(DoRPCRequest("DescribeFabricPeerLogs", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFabricPeerLogsResponse> DescribeFabricPeerLogsWithOptionsAsync(DescribeFabricPeerLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFabricPeerLogsResponse>(await DoRPCRequestAsync("DescribeFabricPeerLogs", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFabricPeerLogsResponse DescribeFabricPeerLogs(DescribeFabricPeerLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFabricPeerLogsWithOptions(request, runtime);
        }

        public async Task<DescribeFabricPeerLogsResponse> DescribeFabricPeerLogsAsync(DescribeFabricPeerLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFabricPeerLogsWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeRootDomainResponse DescribeRootDomainWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRootDomainResponse>(DoRPCRequest("DescribeRootDomain", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRootDomainResponse> DescribeRootDomainWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRootDomainResponse>(await DoRPCRequestAsync("DescribeRootDomain", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRootDomainResponse DescribeRootDomain()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRootDomainWithOptions(runtime);
        }

        public async Task<DescribeRootDomainResponse> DescribeRootDomainAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRootDomainWithOptionsAsync(runtime);
        }

        public DescribeTasksResponse DescribeTasksWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeTasksResponse>(DoRPCRequest("DescribeTasks", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeTasksResponse>(await DoRPCRequestAsync("DescribeTasks", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTasksResponse DescribeTasks()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTasksWithOptions(runtime);
        }

        public async Task<DescribeTasksResponse> DescribeTasksAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTasksWithOptionsAsync(runtime);
        }

        public DownloadFabricOrganizationSDKResponse DownloadFabricOrganizationSDKWithOptions(DownloadFabricOrganizationSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadFabricOrganizationSDKResponse>(DoRPCRequest("DownloadFabricOrganizationSDK", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadFabricOrganizationSDKResponse> DownloadFabricOrganizationSDKWithOptionsAsync(DownloadFabricOrganizationSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadFabricOrganizationSDKResponse>(await DoRPCRequestAsync("DownloadFabricOrganizationSDK", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadFabricOrganizationSDKResponse DownloadFabricOrganizationSDK(DownloadFabricOrganizationSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadFabricOrganizationSDKWithOptions(request, runtime);
        }

        public async Task<DownloadFabricOrganizationSDKResponse> DownloadFabricOrganizationSDKAsync(DownloadFabricOrganizationSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadFabricOrganizationSDKWithOptionsAsync(request, runtime);
        }

        public FreezeAntChainAccountResponse FreezeAntChainAccountWithOptions(FreezeAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FreezeAntChainAccountResponse>(DoRPCRequest("FreezeAntChainAccount", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FreezeAntChainAccountResponse> FreezeAntChainAccountWithOptionsAsync(FreezeAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FreezeAntChainAccountResponse>(await DoRPCRequestAsync("FreezeAntChainAccount", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FreezeAntChainAccountResponse FreezeAntChainAccount(FreezeAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FreezeAntChainAccountWithOptions(request, runtime);
        }

        public async Task<FreezeAntChainAccountResponse> FreezeAntChainAccountAsync(FreezeAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FreezeAntChainAccountWithOptionsAsync(request, runtime);
        }

        public InstallFabricChaincodeResponse InstallFabricChaincodeWithOptions(InstallFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstallFabricChaincodeResponse>(DoRPCRequest("InstallFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InstallFabricChaincodeResponse> InstallFabricChaincodeWithOptionsAsync(InstallFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstallFabricChaincodeResponse>(await DoRPCRequestAsync("InstallFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InstallFabricChaincodeResponse InstallFabricChaincode(InstallFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallFabricChaincodeWithOptions(request, runtime);
        }

        public async Task<InstallFabricChaincodeResponse> InstallFabricChaincodeAsync(InstallFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallFabricChaincodeWithOptionsAsync(request, runtime);
        }

        public InstantiateFabricChaincodeResponse InstantiateFabricChaincodeWithOptions(InstantiateFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstantiateFabricChaincodeResponse>(DoRPCRequest("InstantiateFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InstantiateFabricChaincodeResponse> InstantiateFabricChaincodeWithOptionsAsync(InstantiateFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstantiateFabricChaincodeResponse>(await DoRPCRequestAsync("InstantiateFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InstantiateFabricChaincodeResponse InstantiateFabricChaincode(InstantiateFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstantiateFabricChaincodeWithOptions(request, runtime);
        }

        public async Task<InstantiateFabricChaincodeResponse> InstantiateFabricChaincodeAsync(InstantiateFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstantiateFabricChaincodeWithOptionsAsync(request, runtime);
        }

        public JoinFabricChannelResponse JoinFabricChannelWithOptions(JoinFabricChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinFabricChannelResponse>(DoRPCRequest("JoinFabricChannel", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinFabricChannelResponse> JoinFabricChannelWithOptionsAsync(JoinFabricChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinFabricChannelResponse>(await DoRPCRequestAsync("JoinFabricChannel", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public JoinFabricChannelResponse JoinFabricChannel(JoinFabricChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinFabricChannelWithOptions(request, runtime);
        }

        public async Task<JoinFabricChannelResponse> JoinFabricChannelAsync(JoinFabricChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinFabricChannelWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public ResetAntChainCertificateResponse ResetAntChainCertificateWithOptions(ResetAntChainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAntChainCertificateResponse>(DoRPCRequest("ResetAntChainCertificate", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetAntChainCertificateResponse> ResetAntChainCertificateWithOptionsAsync(ResetAntChainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAntChainCertificateResponse>(await DoRPCRequestAsync("ResetAntChainCertificate", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetAntChainCertificateResponse ResetAntChainCertificate(ResetAntChainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAntChainCertificateWithOptions(request, runtime);
        }

        public async Task<ResetAntChainCertificateResponse> ResetAntChainCertificateAsync(ResetAntChainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAntChainCertificateWithOptionsAsync(request, runtime);
        }

        public ResetAntChainUserCertificateResponse ResetAntChainUserCertificateWithOptions(ResetAntChainUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAntChainUserCertificateResponse>(DoRPCRequest("ResetAntChainUserCertificate", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetAntChainUserCertificateResponse> ResetAntChainUserCertificateWithOptionsAsync(ResetAntChainUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAntChainUserCertificateResponse>(await DoRPCRequestAsync("ResetAntChainUserCertificate", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetAntChainUserCertificateResponse ResetAntChainUserCertificate(ResetAntChainUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAntChainUserCertificateWithOptions(request, runtime);
        }

        public async Task<ResetAntChainUserCertificateResponse> ResetAntChainUserCertificateAsync(ResetAntChainUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAntChainUserCertificateWithOptionsAsync(request, runtime);
        }

        public ResetFabricOrganizationUserPasswordResponse ResetFabricOrganizationUserPasswordWithOptions(ResetFabricOrganizationUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetFabricOrganizationUserPasswordResponse>(DoRPCRequest("ResetFabricOrganizationUserPassword", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetFabricOrganizationUserPasswordResponse> ResetFabricOrganizationUserPasswordWithOptionsAsync(ResetFabricOrganizationUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetFabricOrganizationUserPasswordResponse>(await DoRPCRequestAsync("ResetFabricOrganizationUserPassword", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetFabricOrganizationUserPasswordResponse ResetFabricOrganizationUserPassword(ResetFabricOrganizationUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetFabricOrganizationUserPasswordWithOptions(request, runtime);
        }

        public async Task<ResetFabricOrganizationUserPasswordResponse> ResetFabricOrganizationUserPasswordAsync(ResetFabricOrganizationUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetFabricOrganizationUserPasswordWithOptionsAsync(request, runtime);
        }

        public SynchronizeFabricChaincodeResponse SynchronizeFabricChaincodeWithOptions(SynchronizeFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SynchronizeFabricChaincodeResponse>(DoRPCRequest("SynchronizeFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SynchronizeFabricChaincodeResponse> SynchronizeFabricChaincodeWithOptionsAsync(SynchronizeFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SynchronizeFabricChaincodeResponse>(await DoRPCRequestAsync("SynchronizeFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SynchronizeFabricChaincodeResponse SynchronizeFabricChaincode(SynchronizeFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SynchronizeFabricChaincodeWithOptions(request, runtime);
        }

        public async Task<SynchronizeFabricChaincodeResponse> SynchronizeFabricChaincodeAsync(SynchronizeFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SynchronizeFabricChaincodeWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public UnfreezeAntChainAccountResponse UnfreezeAntChainAccountWithOptions(UnfreezeAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnfreezeAntChainAccountResponse>(DoRPCRequest("UnfreezeAntChainAccount", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnfreezeAntChainAccountResponse> UnfreezeAntChainAccountWithOptionsAsync(UnfreezeAntChainAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnfreezeAntChainAccountResponse>(await DoRPCRequestAsync("UnfreezeAntChainAccount", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnfreezeAntChainAccountResponse UnfreezeAntChainAccount(UnfreezeAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnfreezeAntChainAccountWithOptions(request, runtime);
        }

        public async Task<UnfreezeAntChainAccountResponse> UnfreezeAntChainAccountAsync(UnfreezeAntChainAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnfreezeAntChainAccountWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        public UpdateAntChainResponse UpdateAntChainWithOptions(UpdateAntChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainResponse>(DoRPCRequest("UpdateAntChain", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAntChainResponse> UpdateAntChainWithOptionsAsync(UpdateAntChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainResponse>(await DoRPCRequestAsync("UpdateAntChain", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAntChainResponse UpdateAntChain(UpdateAntChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainWithOptions(request, runtime);
        }

        public async Task<UpdateAntChainResponse> UpdateAntChainAsync(UpdateAntChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainWithOptionsAsync(request, runtime);
        }

        public UpdateAntChainConsortiumResponse UpdateAntChainConsortiumWithOptions(UpdateAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainConsortiumResponse>(DoRPCRequest("UpdateAntChainConsortium", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAntChainConsortiumResponse> UpdateAntChainConsortiumWithOptionsAsync(UpdateAntChainConsortiumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainConsortiumResponse>(await DoRPCRequestAsync("UpdateAntChainConsortium", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAntChainConsortiumResponse UpdateAntChainConsortium(UpdateAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainConsortiumWithOptions(request, runtime);
        }

        public async Task<UpdateAntChainConsortiumResponse> UpdateAntChainConsortiumAsync(UpdateAntChainConsortiumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainConsortiumWithOptionsAsync(request, runtime);
        }

        public UpdateAntChainContractContentResponse UpdateAntChainContractContentWithOptions(UpdateAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainContractContentResponse>(DoRPCRequest("UpdateAntChainContractContent", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAntChainContractContentResponse> UpdateAntChainContractContentWithOptionsAsync(UpdateAntChainContractContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainContractContentResponse>(await DoRPCRequestAsync("UpdateAntChainContractContent", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAntChainContractContentResponse UpdateAntChainContractContent(UpdateAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainContractContentWithOptions(request, runtime);
        }

        public async Task<UpdateAntChainContractContentResponse> UpdateAntChainContractContentAsync(UpdateAntChainContractContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainContractContentWithOptionsAsync(request, runtime);
        }

        public UpdateAntChainContractProjectResponse UpdateAntChainContractProjectWithOptions(UpdateAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainContractProjectResponse>(DoRPCRequest("UpdateAntChainContractProject", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAntChainContractProjectResponse> UpdateAntChainContractProjectWithOptionsAsync(UpdateAntChainContractProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainContractProjectResponse>(await DoRPCRequestAsync("UpdateAntChainContractProject", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAntChainContractProjectResponse UpdateAntChainContractProject(UpdateAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainContractProjectWithOptions(request, runtime);
        }

        public async Task<UpdateAntChainContractProjectResponse> UpdateAntChainContractProjectAsync(UpdateAntChainContractProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainContractProjectWithOptionsAsync(request, runtime);
        }

        public UpdateAntChainMemberResponse UpdateAntChainMemberWithOptions(UpdateAntChainMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainMemberResponse>(DoRPCRequest("UpdateAntChainMember", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAntChainMemberResponse> UpdateAntChainMemberWithOptionsAsync(UpdateAntChainMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainMemberResponse>(await DoRPCRequestAsync("UpdateAntChainMember", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAntChainMemberResponse UpdateAntChainMember(UpdateAntChainMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainMemberWithOptions(request, runtime);
        }

        public async Task<UpdateAntChainMemberResponse> UpdateAntChainMemberAsync(UpdateAntChainMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainMemberWithOptionsAsync(request, runtime);
        }

        public UpdateAntChainQRCodeAuthorizationResponse UpdateAntChainQRCodeAuthorizationWithOptions(UpdateAntChainQRCodeAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainQRCodeAuthorizationResponse>(DoRPCRequest("UpdateAntChainQRCodeAuthorization", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAntChainQRCodeAuthorizationResponse> UpdateAntChainQRCodeAuthorizationWithOptionsAsync(UpdateAntChainQRCodeAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAntChainQRCodeAuthorizationResponse>(await DoRPCRequestAsync("UpdateAntChainQRCodeAuthorization", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAntChainQRCodeAuthorizationResponse UpdateAntChainQRCodeAuthorization(UpdateAntChainQRCodeAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAntChainQRCodeAuthorizationWithOptions(request, runtime);
        }

        public async Task<UpdateAntChainQRCodeAuthorizationResponse> UpdateAntChainQRCodeAuthorizationAsync(UpdateAntChainQRCodeAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAntChainQRCodeAuthorizationWithOptionsAsync(request, runtime);
        }

        public UpgradeFabricChaincodeResponse UpgradeFabricChaincodeWithOptions(UpgradeFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeFabricChaincodeResponse>(DoRPCRequest("UpgradeFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeFabricChaincodeResponse> UpgradeFabricChaincodeWithOptionsAsync(UpgradeFabricChaincodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeFabricChaincodeResponse>(await DoRPCRequestAsync("UpgradeFabricChaincode", "2018-12-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeFabricChaincodeResponse UpgradeFabricChaincode(UpgradeFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeFabricChaincodeWithOptions(request, runtime);
        }

        public async Task<UpgradeFabricChaincodeResponse> UpgradeFabricChaincodeAsync(UpgradeFabricChaincodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeFabricChaincodeWithOptionsAsync(request, runtime);
        }

    }
}
