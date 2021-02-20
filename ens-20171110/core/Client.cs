// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ens20171110.Models;

namespace AlibabaCloud.SDK.Ens20171110
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ens", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddNetworkInterfaceToInstanceResponse AddNetworkInterfaceToInstanceWithOptions(AddNetworkInterfaceToInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddNetworkInterfaceToInstanceResponse>(DoRPCRequest("AddNetworkInterfaceToInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddNetworkInterfaceToInstanceResponse> AddNetworkInterfaceToInstanceWithOptionsAsync(AddNetworkInterfaceToInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddNetworkInterfaceToInstanceResponse>(await DoRPCRequestAsync("AddNetworkInterfaceToInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddNetworkInterfaceToInstanceResponse AddNetworkInterfaceToInstance(AddNetworkInterfaceToInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddNetworkInterfaceToInstanceWithOptions(request, runtime);
        }

        public async Task<AddNetworkInterfaceToInstanceResponse> AddNetworkInterfaceToInstanceAsync(AddNetworkInterfaceToInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddNetworkInterfaceToInstanceWithOptionsAsync(request, runtime);
        }

        public AllocateEipAddressResponse AllocateEipAddressWithOptions(AllocateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateEipAddressResponse>(DoRPCRequest("AllocateEipAddress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateEipAddressResponse> AllocateEipAddressWithOptionsAsync(AllocateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateEipAddressResponse>(await DoRPCRequestAsync("AllocateEipAddress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateEipAddressResponse AllocateEipAddress(AllocateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateEipAddressWithOptions(request, runtime);
        }

        public async Task<AllocateEipAddressResponse> AllocateEipAddressAsync(AllocateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateEipAddressWithOptionsAsync(request, runtime);
        }

        public AssociateEipAddressResponse AssociateEipAddressWithOptions(AssociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateEipAddressResponse>(DoRPCRequest("AssociateEipAddress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateEipAddressResponse> AssociateEipAddressWithOptionsAsync(AssociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateEipAddressResponse>(await DoRPCRequestAsync("AssociateEipAddress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateEipAddressResponse AssociateEipAddress(AssociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateEipAddressWithOptions(request, runtime);
        }

        public async Task<AssociateEipAddressResponse> AssociateEipAddressAsync(AssociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateEipAddressWithOptionsAsync(request, runtime);
        }

        public AttachEnsInstancesResponse AttachEnsInstancesWithOptions(AttachEnsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachEnsInstancesResponse>(DoRPCRequest("AttachEnsInstances", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachEnsInstancesResponse> AttachEnsInstancesWithOptionsAsync(AttachEnsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachEnsInstancesResponse>(await DoRPCRequestAsync("AttachEnsInstances", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachEnsInstancesResponse AttachEnsInstances(AttachEnsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachEnsInstancesWithOptions(request, runtime);
        }

        public async Task<AttachEnsInstancesResponse> AttachEnsInstancesAsync(AttachEnsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachEnsInstancesWithOptionsAsync(request, runtime);
        }

        public AuthorizeSecurityGroupResponse AuthorizeSecurityGroupWithOptions(AuthorizeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupResponse>(DoRPCRequest("AuthorizeSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AuthorizeSecurityGroupResponse> AuthorizeSecurityGroupWithOptionsAsync(AuthorizeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupResponse>(await DoRPCRequestAsync("AuthorizeSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AuthorizeSecurityGroupResponse AuthorizeSecurityGroup(AuthorizeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeSecurityGroupWithOptions(request, runtime);
        }

        public async Task<AuthorizeSecurityGroupResponse> AuthorizeSecurityGroupAsync(AuthorizeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeSecurityGroupWithOptionsAsync(request, runtime);
        }

        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgressWithOptions(AuthorizeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupEgressResponse>(DoRPCRequest("AuthorizeSecurityGroupEgress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressWithOptionsAsync(AuthorizeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupEgressResponse>(await DoRPCRequestAsync("AuthorizeSecurityGroupEgress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeSecurityGroupEgressWithOptions(request, runtime);
        }

        public async Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeSecurityGroupEgressWithOptionsAsync(request, runtime);
        }

        public CheckQuotaResponse CheckQuotaWithOptions(CheckQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckQuotaResponse>(DoRPCRequest("CheckQuota", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckQuotaResponse> CheckQuotaWithOptionsAsync(CheckQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckQuotaResponse>(await DoRPCRequestAsync("CheckQuota", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckQuotaResponse CheckQuota(CheckQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckQuotaWithOptions(request, runtime);
        }

        public async Task<CheckQuotaResponse> CheckQuotaAsync(CheckQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckQuotaWithOptionsAsync(request, runtime);
        }

        public CreateApplicationResponse CreateApplicationWithOptions(CreateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateApplicationResponse>(DoRPCRequest("CreateApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateApplicationResponse> CreateApplicationWithOptionsAsync(CreateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateApplicationResponse>(await DoRPCRequestAsync("CreateApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicationWithOptions(request, runtime);
        }

        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicationWithOptionsAsync(request, runtime);
        }

        public CreateEnsServiceResponse CreateEnsServiceWithOptions(CreateEnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEnsServiceResponse>(DoRPCRequest("CreateEnsService", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEnsServiceResponse> CreateEnsServiceWithOptionsAsync(CreateEnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEnsServiceResponse>(await DoRPCRequestAsync("CreateEnsService", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEnsServiceResponse CreateEnsService(CreateEnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEnsServiceWithOptions(request, runtime);
        }

        public async Task<CreateEnsServiceResponse> CreateEnsServiceAsync(CreateEnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEnsServiceWithOptionsAsync(request, runtime);
        }

        public CreateEPInstanceResponse CreateEPInstanceWithOptions(CreateEPInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEPInstanceResponse>(DoRPCRequest("CreateEPInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEPInstanceResponse> CreateEPInstanceWithOptionsAsync(CreateEPInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEPInstanceResponse>(await DoRPCRequestAsync("CreateEPInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEPInstanceResponse CreateEPInstance(CreateEPInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEPInstanceWithOptions(request, runtime);
        }

        public async Task<CreateEPInstanceResponse> CreateEPInstanceAsync(CreateEPInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEPInstanceWithOptionsAsync(request, runtime);
        }

        public CreateEpnInstanceResponse CreateEpnInstanceWithOptions(CreateEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEpnInstanceResponse>(DoRPCRequest("CreateEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEpnInstanceResponse> CreateEpnInstanceWithOptionsAsync(CreateEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEpnInstanceResponse>(await DoRPCRequestAsync("CreateEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEpnInstanceResponse CreateEpnInstance(CreateEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEpnInstanceWithOptions(request, runtime);
        }

        public async Task<CreateEpnInstanceResponse> CreateEpnInstanceAsync(CreateEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEpnInstanceWithOptionsAsync(request, runtime);
        }

        public CreateImageResponse CreateImageWithOptions(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageResponse>(DoRPCRequest("CreateImage", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateImageResponse> CreateImageWithOptionsAsync(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageResponse>(await DoRPCRequestAsync("CreateImage", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageWithOptions(request, runtime);
        }

        public async Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageWithOptionsAsync(request, runtime);
        }

        public CreateKeyPairResponse CreateKeyPairWithOptions(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateKeyPairResponse>(DoRPCRequest("CreateKeyPair", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateKeyPairResponse> CreateKeyPairWithOptionsAsync(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateKeyPairResponse>(await DoRPCRequestAsync("CreateKeyPair", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyPairWithOptions(request, runtime);
        }

        public async Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyPairWithOptionsAsync(request, runtime);
        }

        public CreateSecurityGroupResponse CreateSecurityGroupWithOptions(CreateSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSecurityGroupResponse>(DoRPCRequest("CreateSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSecurityGroupResponse> CreateSecurityGroupWithOptionsAsync(CreateSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSecurityGroupResponse>(await DoRPCRequestAsync("CreateSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecurityGroupWithOptions(request, runtime);
        }

        public async Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecurityGroupWithOptionsAsync(request, runtime);
        }

        public CreateVmAndSaveStockResponse CreateVmAndSaveStockWithOptions(CreateVmAndSaveStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVmAndSaveStockResponse>(DoRPCRequest("CreateVmAndSaveStock", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVmAndSaveStockResponse> CreateVmAndSaveStockWithOptionsAsync(CreateVmAndSaveStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVmAndSaveStockResponse>(await DoRPCRequestAsync("CreateVmAndSaveStock", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVmAndSaveStockResponse CreateVmAndSaveStock(CreateVmAndSaveStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVmAndSaveStockWithOptions(request, runtime);
        }

        public async Task<CreateVmAndSaveStockResponse> CreateVmAndSaveStockAsync(CreateVmAndSaveStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVmAndSaveStockWithOptionsAsync(request, runtime);
        }

        public CreateVSwitchResponse CreateVSwitchWithOptions(CreateVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVSwitchResponse>(DoRPCRequest("CreateVSwitch", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVSwitchResponse> CreateVSwitchWithOptionsAsync(CreateVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVSwitchResponse>(await DoRPCRequestAsync("CreateVSwitch", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVSwitchResponse CreateVSwitch(CreateVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVSwitchWithOptions(request, runtime);
        }

        public async Task<CreateVSwitchResponse> CreateVSwitchAsync(CreateVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVSwitchWithOptionsAsync(request, runtime);
        }

        public DeleteApplicationResponse DeleteApplicationWithOptions(DeleteApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(DoRPCRequest("DeleteApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteApplicationResponse> DeleteApplicationWithOptionsAsync(DeleteApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(await DoRPCRequestAsync("DeleteApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApplicationWithOptions(request, runtime);
        }

        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApplicationWithOptionsAsync(request, runtime);
        }

        public DeleteEpnInstanceResponse DeleteEpnInstanceWithOptions(DeleteEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEpnInstanceResponse>(DoRPCRequest("DeleteEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEpnInstanceResponse> DeleteEpnInstanceWithOptionsAsync(DeleteEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEpnInstanceResponse>(await DoRPCRequestAsync("DeleteEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEpnInstanceResponse DeleteEpnInstance(DeleteEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEpnInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteEpnInstanceResponse> DeleteEpnInstanceAsync(DeleteEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEpnInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteKeyPairsResponse DeleteKeyPairsWithOptions(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteKeyPairsResponse>(DoRPCRequest("DeleteKeyPairs", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsWithOptionsAsync(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteKeyPairsResponse>(await DoRPCRequestAsync("DeleteKeyPairs", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteKeyPairsResponse DeleteKeyPairs(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeyPairsWithOptions(request, runtime);
        }

        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsAsync(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeyPairsWithOptionsAsync(request, runtime);
        }

        public DeleteSecurityGroupResponse DeleteSecurityGroupWithOptions(DeleteSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecurityGroupResponse>(DoRPCRequest("DeleteSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupWithOptionsAsync(DeleteSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecurityGroupResponse>(await DoRPCRequestAsync("DeleteSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecurityGroupWithOptions(request, runtime);
        }

        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecurityGroupWithOptionsAsync(request, runtime);
        }

        public DeleteVmResponse DeleteVmWithOptions(DeleteVmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVmResponse>(DoRPCRequest("DeleteVm", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVmResponse> DeleteVmWithOptionsAsync(DeleteVmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVmResponse>(await DoRPCRequestAsync("DeleteVm", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVmResponse DeleteVm(DeleteVmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVmWithOptions(request, runtime);
        }

        public async Task<DeleteVmResponse> DeleteVmAsync(DeleteVmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVmWithOptionsAsync(request, runtime);
        }

        public DeleteVSwitchResponse DeleteVSwitchWithOptions(DeleteVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVSwitchResponse>(DoRPCRequest("DeleteVSwitch", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVSwitchResponse> DeleteVSwitchWithOptionsAsync(DeleteVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVSwitchResponse>(await DoRPCRequestAsync("DeleteVSwitch", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVSwitchResponse DeleteVSwitch(DeleteVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVSwitchWithOptions(request, runtime);
        }

        public async Task<DeleteVSwitchResponse> DeleteVSwitchAsync(DeleteVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVSwitchWithOptionsAsync(request, runtime);
        }

        public DescribeApplicationResponse DescribeApplicationWithOptions(DescribeApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApplicationResponse>(DoRPCRequest("DescribeApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApplicationResponse> DescribeApplicationWithOptionsAsync(DescribeApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApplicationResponse>(await DoRPCRequestAsync("DescribeApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApplicationWithOptions(request, runtime);
        }

        public async Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApplicationWithOptionsAsync(request, runtime);
        }

        public DescribeApplicationResourceSummaryResponse DescribeApplicationResourceSummaryWithOptions(DescribeApplicationResourceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApplicationResourceSummaryResponse>(DoRPCRequest("DescribeApplicationResourceSummary", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApplicationResourceSummaryResponse> DescribeApplicationResourceSummaryWithOptionsAsync(DescribeApplicationResourceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApplicationResourceSummaryResponse>(await DoRPCRequestAsync("DescribeApplicationResourceSummary", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApplicationResourceSummaryResponse DescribeApplicationResourceSummary(DescribeApplicationResourceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApplicationResourceSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeApplicationResourceSummaryResponse> DescribeApplicationResourceSummaryAsync(DescribeApplicationResourceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApplicationResourceSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(DoRPCRequest("DescribeAvailableResource", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await DoRPCRequestAsync("DescribeAvailableResource", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        public DescribeBandwitdhByInternetChargeTypeResponse DescribeBandwitdhByInternetChargeTypeWithOptions(DescribeBandwitdhByInternetChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBandwitdhByInternetChargeTypeResponse>(DoRPCRequest("DescribeBandwitdhByInternetChargeType", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBandwitdhByInternetChargeTypeResponse> DescribeBandwitdhByInternetChargeTypeWithOptionsAsync(DescribeBandwitdhByInternetChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBandwitdhByInternetChargeTypeResponse>(await DoRPCRequestAsync("DescribeBandwitdhByInternetChargeType", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBandwitdhByInternetChargeTypeResponse DescribeBandwitdhByInternetChargeType(DescribeBandwitdhByInternetChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBandwitdhByInternetChargeTypeWithOptions(request, runtime);
        }

        public async Task<DescribeBandwitdhByInternetChargeTypeResponse> DescribeBandwitdhByInternetChargeTypeAsync(DescribeBandwitdhByInternetChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBandwitdhByInternetChargeTypeWithOptionsAsync(request, runtime);
        }

        public DescribeBandWithdChargeTypeResponse DescribeBandWithdChargeTypeWithOptions(DescribeBandWithdChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBandWithdChargeTypeResponse>(DoRPCRequest("DescribeBandWithdChargeType", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBandWithdChargeTypeResponse> DescribeBandWithdChargeTypeWithOptionsAsync(DescribeBandWithdChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBandWithdChargeTypeResponse>(await DoRPCRequestAsync("DescribeBandWithdChargeType", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBandWithdChargeTypeResponse DescribeBandWithdChargeType(DescribeBandWithdChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBandWithdChargeTypeWithOptions(request, runtime);
        }

        public async Task<DescribeBandWithdChargeTypeResponse> DescribeBandWithdChargeTypeAsync(DescribeBandWithdChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBandWithdChargeTypeWithOptionsAsync(request, runtime);
        }

        public DescribeCreatePrePaidInstanceResultResponse DescribeCreatePrePaidInstanceResultWithOptions(DescribeCreatePrePaidInstanceResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCreatePrePaidInstanceResultResponse>(DoRPCRequest("DescribeCreatePrePaidInstanceResult", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCreatePrePaidInstanceResultResponse> DescribeCreatePrePaidInstanceResultWithOptionsAsync(DescribeCreatePrePaidInstanceResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCreatePrePaidInstanceResultResponse>(await DoRPCRequestAsync("DescribeCreatePrePaidInstanceResult", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCreatePrePaidInstanceResultResponse DescribeCreatePrePaidInstanceResult(DescribeCreatePrePaidInstanceResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCreatePrePaidInstanceResultWithOptions(request, runtime);
        }

        public async Task<DescribeCreatePrePaidInstanceResultResponse> DescribeCreatePrePaidInstanceResultAsync(DescribeCreatePrePaidInstanceResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCreatePrePaidInstanceResultWithOptionsAsync(request, runtime);
        }

        public DescribeDataDistResultResponse DescribeDataDistResultWithOptions(DescribeDataDistResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataDistResultResponse>(DoRPCRequest("DescribeDataDistResult", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataDistResultResponse> DescribeDataDistResultWithOptionsAsync(DescribeDataDistResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataDistResultResponse>(await DoRPCRequestAsync("DescribeDataDistResult", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataDistResultResponse DescribeDataDistResult(DescribeDataDistResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataDistResultWithOptions(request, runtime);
        }

        public async Task<DescribeDataDistResultResponse> DescribeDataDistResultAsync(DescribeDataDistResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataDistResultWithOptionsAsync(request, runtime);
        }

        public DescribeDataPushResultResponse DescribeDataPushResultWithOptions(DescribeDataPushResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataPushResultResponse>(DoRPCRequest("DescribeDataPushResult", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataPushResultResponse> DescribeDataPushResultWithOptionsAsync(DescribeDataPushResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataPushResultResponse>(await DoRPCRequestAsync("DescribeDataPushResult", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataPushResultResponse DescribeDataPushResult(DescribeDataPushResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataPushResultWithOptions(request, runtime);
        }

        public async Task<DescribeDataPushResultResponse> DescribeDataPushResultAsync(DescribeDataPushResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataPushResultWithOptionsAsync(request, runtime);
        }

        public DescribeEipAddressesResponse DescribeEipAddressesWithOptions(DescribeEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipAddressesResponse>(DoRPCRequest("DescribeEipAddresses", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEipAddressesResponse> DescribeEipAddressesWithOptionsAsync(DescribeEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipAddressesResponse>(await DoRPCRequestAsync("DescribeEipAddresses", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEipAddressesResponse DescribeEipAddresses(DescribeEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEipAddressesWithOptions(request, runtime);
        }

        public async Task<DescribeEipAddressesResponse> DescribeEipAddressesAsync(DescribeEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEipAddressesWithOptionsAsync(request, runtime);
        }

        public DescribeEnsNetDistrictResponse DescribeEnsNetDistrictWithOptions(DescribeEnsNetDistrictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsNetDistrictResponse>(DoRPCRequest("DescribeEnsNetDistrict", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEnsNetDistrictResponse> DescribeEnsNetDistrictWithOptionsAsync(DescribeEnsNetDistrictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsNetDistrictResponse>(await DoRPCRequestAsync("DescribeEnsNetDistrict", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEnsNetDistrictResponse DescribeEnsNetDistrict(DescribeEnsNetDistrictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsNetDistrictWithOptions(request, runtime);
        }

        public async Task<DescribeEnsNetDistrictResponse> DescribeEnsNetDistrictAsync(DescribeEnsNetDistrictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsNetDistrictWithOptionsAsync(request, runtime);
        }

        public DescribeEnsNetLevelResponse DescribeEnsNetLevelWithOptions(DescribeEnsNetLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsNetLevelResponse>(DoRPCRequest("DescribeEnsNetLevel", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEnsNetLevelResponse> DescribeEnsNetLevelWithOptionsAsync(DescribeEnsNetLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsNetLevelResponse>(await DoRPCRequestAsync("DescribeEnsNetLevel", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEnsNetLevelResponse DescribeEnsNetLevel(DescribeEnsNetLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsNetLevelWithOptions(request, runtime);
        }

        public async Task<DescribeEnsNetLevelResponse> DescribeEnsNetLevelAsync(DescribeEnsNetLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsNetLevelWithOptionsAsync(request, runtime);
        }

        public DescribeEnsNetSaleDistrictResponse DescribeEnsNetSaleDistrictWithOptions(DescribeEnsNetSaleDistrictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsNetSaleDistrictResponse>(DoRPCRequest("DescribeEnsNetSaleDistrict", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEnsNetSaleDistrictResponse> DescribeEnsNetSaleDistrictWithOptionsAsync(DescribeEnsNetSaleDistrictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsNetSaleDistrictResponse>(await DoRPCRequestAsync("DescribeEnsNetSaleDistrict", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEnsNetSaleDistrictResponse DescribeEnsNetSaleDistrict(DescribeEnsNetSaleDistrictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsNetSaleDistrictWithOptions(request, runtime);
        }

        public async Task<DescribeEnsNetSaleDistrictResponse> DescribeEnsNetSaleDistrictAsync(DescribeEnsNetSaleDistrictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsNetSaleDistrictWithOptionsAsync(request, runtime);
        }

        public DescribeEnsRegionIdIpv6InfoResponse DescribeEnsRegionIdIpv6InfoWithOptions(DescribeEnsRegionIdIpv6InfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsRegionIdIpv6InfoResponse>(DoRPCRequest("DescribeEnsRegionIdIpv6Info", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEnsRegionIdIpv6InfoResponse> DescribeEnsRegionIdIpv6InfoWithOptionsAsync(DescribeEnsRegionIdIpv6InfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsRegionIdIpv6InfoResponse>(await DoRPCRequestAsync("DescribeEnsRegionIdIpv6Info", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEnsRegionIdIpv6InfoResponse DescribeEnsRegionIdIpv6Info(DescribeEnsRegionIdIpv6InfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsRegionIdIpv6InfoWithOptions(request, runtime);
        }

        public async Task<DescribeEnsRegionIdIpv6InfoResponse> DescribeEnsRegionIdIpv6InfoAsync(DescribeEnsRegionIdIpv6InfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsRegionIdIpv6InfoWithOptionsAsync(request, runtime);
        }

        public DescribeEnsRegionIdResourceResponse DescribeEnsRegionIdResourceWithOptions(DescribeEnsRegionIdResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsRegionIdResourceResponse>(DoRPCRequest("DescribeEnsRegionIdResource", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEnsRegionIdResourceResponse> DescribeEnsRegionIdResourceWithOptionsAsync(DescribeEnsRegionIdResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsRegionIdResourceResponse>(await DoRPCRequestAsync("DescribeEnsRegionIdResource", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEnsRegionIdResourceResponse DescribeEnsRegionIdResource(DescribeEnsRegionIdResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsRegionIdResourceWithOptions(request, runtime);
        }

        public async Task<DescribeEnsRegionIdResourceResponse> DescribeEnsRegionIdResourceAsync(DescribeEnsRegionIdResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsRegionIdResourceWithOptionsAsync(request, runtime);
        }

        public DescribeEnsRegionsResponse DescribeEnsRegionsWithOptions(DescribeEnsRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsRegionsResponse>(DoRPCRequest("DescribeEnsRegions", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEnsRegionsResponse> DescribeEnsRegionsWithOptionsAsync(DescribeEnsRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEnsRegionsResponse>(await DoRPCRequestAsync("DescribeEnsRegions", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEnsRegionsResponse DescribeEnsRegions(DescribeEnsRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnsRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeEnsRegionsResponse> DescribeEnsRegionsAsync(DescribeEnsRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnsRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeEpnBandWidthDataResponse DescribeEpnBandWidthDataWithOptions(DescribeEpnBandWidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEpnBandWidthDataResponse>(DoRPCRequest("DescribeEpnBandWidthData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEpnBandWidthDataResponse> DescribeEpnBandWidthDataWithOptionsAsync(DescribeEpnBandWidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEpnBandWidthDataResponse>(await DoRPCRequestAsync("DescribeEpnBandWidthData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEpnBandWidthDataResponse DescribeEpnBandWidthData(DescribeEpnBandWidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEpnBandWidthDataWithOptions(request, runtime);
        }

        public async Task<DescribeEpnBandWidthDataResponse> DescribeEpnBandWidthDataAsync(DescribeEpnBandWidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEpnBandWidthDataWithOptionsAsync(request, runtime);
        }

        public DescribeEpnBandwitdhByInternetChargeTypeResponse DescribeEpnBandwitdhByInternetChargeTypeWithOptions(DescribeEpnBandwitdhByInternetChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEpnBandwitdhByInternetChargeTypeResponse>(DoRPCRequest("DescribeEpnBandwitdhByInternetChargeType", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEpnBandwitdhByInternetChargeTypeResponse> DescribeEpnBandwitdhByInternetChargeTypeWithOptionsAsync(DescribeEpnBandwitdhByInternetChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEpnBandwitdhByInternetChargeTypeResponse>(await DoRPCRequestAsync("DescribeEpnBandwitdhByInternetChargeType", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEpnBandwitdhByInternetChargeTypeResponse DescribeEpnBandwitdhByInternetChargeType(DescribeEpnBandwitdhByInternetChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEpnBandwitdhByInternetChargeTypeWithOptions(request, runtime);
        }

        public async Task<DescribeEpnBandwitdhByInternetChargeTypeResponse> DescribeEpnBandwitdhByInternetChargeTypeAsync(DescribeEpnBandwitdhByInternetChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEpnBandwitdhByInternetChargeTypeWithOptionsAsync(request, runtime);
        }

        public DescribeEpnInstanceAttributeResponse DescribeEpnInstanceAttributeWithOptions(DescribeEpnInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEpnInstanceAttributeResponse>(DoRPCRequest("DescribeEpnInstanceAttribute", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEpnInstanceAttributeResponse> DescribeEpnInstanceAttributeWithOptionsAsync(DescribeEpnInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEpnInstanceAttributeResponse>(await DoRPCRequestAsync("DescribeEpnInstanceAttribute", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEpnInstanceAttributeResponse DescribeEpnInstanceAttribute(DescribeEpnInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEpnInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeEpnInstanceAttributeResponse> DescribeEpnInstanceAttributeAsync(DescribeEpnInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEpnInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeEpnInstancesResponse DescribeEpnInstancesWithOptions(DescribeEpnInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEpnInstancesResponse>(DoRPCRequest("DescribeEpnInstances", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEpnInstancesResponse> DescribeEpnInstancesWithOptionsAsync(DescribeEpnInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEpnInstancesResponse>(await DoRPCRequestAsync("DescribeEpnInstances", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEpnInstancesResponse DescribeEpnInstances(DescribeEpnInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEpnInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeEpnInstancesResponse> DescribeEpnInstancesAsync(DescribeEpnInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEpnInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeEpnMeasurementDataResponse DescribeEpnMeasurementDataWithOptions(DescribeEpnMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEpnMeasurementDataResponse>(DoRPCRequest("DescribeEpnMeasurementData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEpnMeasurementDataResponse> DescribeEpnMeasurementDataWithOptionsAsync(DescribeEpnMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEpnMeasurementDataResponse>(await DoRPCRequestAsync("DescribeEpnMeasurementData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEpnMeasurementDataResponse DescribeEpnMeasurementData(DescribeEpnMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEpnMeasurementDataWithOptions(request, runtime);
        }

        public async Task<DescribeEpnMeasurementDataResponse> DescribeEpnMeasurementDataAsync(DescribeEpnMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEpnMeasurementDataWithOptionsAsync(request, runtime);
        }

        public DescribeExportImageInfoResponse DescribeExportImageInfoWithOptions(DescribeExportImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExportImageInfoResponse>(DoRPCRequest("DescribeExportImageInfo", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExportImageInfoResponse> DescribeExportImageInfoWithOptionsAsync(DescribeExportImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExportImageInfoResponse>(await DoRPCRequestAsync("DescribeExportImageInfo", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExportImageInfoResponse DescribeExportImageInfo(DescribeExportImageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExportImageInfoWithOptions(request, runtime);
        }

        public async Task<DescribeExportImageInfoResponse> DescribeExportImageInfoAsync(DescribeExportImageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExportImageInfoWithOptionsAsync(request, runtime);
        }

        public DescribeExportImageStatusResponse DescribeExportImageStatusWithOptions(DescribeExportImageStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExportImageStatusResponse>(DoRPCRequest("DescribeExportImageStatus", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExportImageStatusResponse> DescribeExportImageStatusWithOptionsAsync(DescribeExportImageStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExportImageStatusResponse>(await DoRPCRequestAsync("DescribeExportImageStatus", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExportImageStatusResponse DescribeExportImageStatus(DescribeExportImageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExportImageStatusWithOptions(request, runtime);
        }

        public async Task<DescribeExportImageStatusResponse> DescribeExportImageStatusAsync(DescribeExportImageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExportImageStatusWithOptionsAsync(request, runtime);
        }

        public DescribeImageInfosResponse DescribeImageInfosWithOptions(DescribeImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageInfosResponse>(DoRPCRequest("DescribeImageInfos", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImageInfosResponse> DescribeImageInfosWithOptionsAsync(DescribeImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageInfosResponse>(await DoRPCRequestAsync("DescribeImageInfos", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImageInfosResponse DescribeImageInfos(DescribeImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageInfosWithOptions(request, runtime);
        }

        public async Task<DescribeImageInfosResponse> DescribeImageInfosAsync(DescribeImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageInfosWithOptionsAsync(request, runtime);
        }

        public DescribeImagesResponse DescribeImagesWithOptions(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImagesResponse>(DoRPCRequest("DescribeImages", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImagesResponse> DescribeImagesWithOptionsAsync(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImagesResponse>(await DoRPCRequestAsync("DescribeImages", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImagesWithOptions(request, runtime);
        }

        public async Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImagesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAutoRenewAttributeResponse DescribeInstanceAutoRenewAttributeWithOptions(DescribeInstanceAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewAttributeResponse>(DoRPCRequest("DescribeInstanceAutoRenewAttribute", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAutoRenewAttributeResponse> DescribeInstanceAutoRenewAttributeWithOptionsAsync(DescribeInstanceAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewAttributeResponse>(await DoRPCRequestAsync("DescribeInstanceAutoRenewAttribute", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAutoRenewAttributeResponse DescribeInstanceAutoRenewAttribute(DescribeInstanceAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAutoRenewAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAutoRenewAttributeResponse> DescribeInstanceAutoRenewAttributeAsync(DescribeInstanceAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAutoRenewAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceMonitorDataResponse DescribeInstanceMonitorDataWithOptions(DescribeInstanceMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceMonitorDataResponse>(DoRPCRequest("DescribeInstanceMonitorData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceMonitorDataResponse> DescribeInstanceMonitorDataWithOptionsAsync(DescribeInstanceMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceMonitorDataResponse>(await DoRPCRequestAsync("DescribeInstanceMonitorData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceMonitorDataResponse DescribeInstanceMonitorData(DescribeInstanceMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceMonitorDataResponse> DescribeInstanceMonitorDataAsync(DescribeInstanceMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSpecResponse DescribeInstanceSpecWithOptions(DescribeInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSpecResponse>(DoRPCRequest("DescribeInstanceSpec", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceSpecResponse> DescribeInstanceSpecWithOptionsAsync(DescribeInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSpecResponse>(await DoRPCRequestAsync("DescribeInstanceSpec", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceSpecResponse DescribeInstanceSpec(DescribeInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSpecWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSpecResponse> DescribeInstanceSpecAsync(DescribeInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSpecWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceTypesResponse DescribeInstanceTypesWithOptions(DescribeInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTypesResponse>(DoRPCRequest("DescribeInstanceTypes", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceTypesResponse> DescribeInstanceTypesWithOptionsAsync(DescribeInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTypesResponse>(await DoRPCRequestAsync("DescribeInstanceTypes", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceTypesResponse DescribeInstanceTypes(DescribeInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTypesWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceTypesResponse> DescribeInstanceTypesAsync(DescribeInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTypesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlWithOptions(DescribeInstanceVncUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceVncUrlResponse>(DoRPCRequest("DescribeInstanceVncUrl", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrlWithOptionsAsync(DescribeInstanceVncUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceVncUrlResponse>(await DoRPCRequestAsync("DescribeInstanceVncUrl", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceVncUrlWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrlAsync(DescribeInstanceVncUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceVncUrlWithOptionsAsync(request, runtime);
        }

        public DescribeKeyPairsResponse DescribeKeyPairsWithOptions(DescribeKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeKeyPairsResponse>(DoRPCRequest("DescribeKeyPairs", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeKeyPairsResponse> DescribeKeyPairsWithOptionsAsync(DescribeKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeKeyPairsResponse>(await DoRPCRequestAsync("DescribeKeyPairs", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyPairsWithOptions(request, runtime);
        }

        public async Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyPairsWithOptionsAsync(request, runtime);
        }

        public DescribeMeasurementDataResponse DescribeMeasurementDataWithOptions(DescribeMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMeasurementDataResponse>(DoRPCRequest("DescribeMeasurementData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMeasurementDataResponse> DescribeMeasurementDataWithOptionsAsync(DescribeMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMeasurementDataResponse>(await DoRPCRequestAsync("DescribeMeasurementData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMeasurementDataResponse DescribeMeasurementData(DescribeMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeasurementDataWithOptions(request, runtime);
        }

        public async Task<DescribeMeasurementDataResponse> DescribeMeasurementDataAsync(DescribeMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeasurementDataWithOptionsAsync(request, runtime);
        }

        public DescribeNetworkInterfacesResponse DescribeNetworkInterfacesWithOptions(DescribeNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkInterfacesResponse>(DoRPCRequest("DescribeNetworkInterfaces", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesWithOptionsAsync(DescribeNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkInterfacesResponse>(await DoRPCRequestAsync("DescribeNetworkInterfaces", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkInterfacesWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkInterfacesWithOptionsAsync(request, runtime);
        }

        public DescribePrePaidInstanceStockResponse DescribePrePaidInstanceStockWithOptions(DescribePrePaidInstanceStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePrePaidInstanceStockResponse>(DoRPCRequest("DescribePrePaidInstanceStock", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePrePaidInstanceStockResponse> DescribePrePaidInstanceStockWithOptionsAsync(DescribePrePaidInstanceStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePrePaidInstanceStockResponse>(await DoRPCRequestAsync("DescribePrePaidInstanceStock", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePrePaidInstanceStockResponse DescribePrePaidInstanceStock(DescribePrePaidInstanceStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePrePaidInstanceStockWithOptions(request, runtime);
        }

        public async Task<DescribePrePaidInstanceStockResponse> DescribePrePaidInstanceStockAsync(DescribePrePaidInstanceStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePrePaidInstanceStockWithOptionsAsync(request, runtime);
        }

        public DescribePriceResponse DescribePriceWithOptions(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePriceResponse>(DoRPCRequest("DescribePrice", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePriceResponse> DescribePriceWithOptionsAsync(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePriceResponse>(await DoRPCRequestAsync("DescribePrice", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePriceResponse DescribePrice(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePriceWithOptions(request, runtime);
        }

        public async Task<DescribePriceResponse> DescribePriceAsync(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePriceWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupAttributeResponse DescribeSecurityGroupAttributeWithOptions(DescribeSecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupAttributeResponse>(DoRPCRequest("DescribeSecurityGroupAttribute", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityGroupAttributeResponse> DescribeSecurityGroupAttributeWithOptionsAsync(DescribeSecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupAttributeResponse>(await DoRPCRequestAsync("DescribeSecurityGroupAttribute", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityGroupAttributeResponse DescribeSecurityGroupAttribute(DescribeSecurityGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupAttributeResponse> DescribeSecurityGroupAttributeAsync(DescribeSecurityGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupsResponse DescribeSecurityGroupsWithOptions(DescribeSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupsResponse>(DoRPCRequest("DescribeSecurityGroups", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsWithOptionsAsync(DescribeSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupsResponse>(await DoRPCRequestAsync("DescribeSecurityGroups", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeServcieScheduleResponse DescribeServcieScheduleWithOptions(DescribeServcieScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServcieScheduleResponse>(DoRPCRequest("DescribeServcieSchedule", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServcieScheduleResponse> DescribeServcieScheduleWithOptionsAsync(DescribeServcieScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServcieScheduleResponse>(await DoRPCRequestAsync("DescribeServcieSchedule", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServcieScheduleResponse DescribeServcieSchedule(DescribeServcieScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServcieScheduleWithOptions(request, runtime);
        }

        public async Task<DescribeServcieScheduleResponse> DescribeServcieScheduleAsync(DescribeServcieScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServcieScheduleWithOptionsAsync(request, runtime);
        }

        public DescribeUserBandWidthDataResponse DescribeUserBandWidthDataWithOptions(DescribeUserBandWidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserBandWidthDataResponse>(DoRPCRequest("DescribeUserBandWidthData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserBandWidthDataResponse> DescribeUserBandWidthDataWithOptionsAsync(DescribeUserBandWidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserBandWidthDataResponse>(await DoRPCRequestAsync("DescribeUserBandWidthData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserBandWidthDataResponse DescribeUserBandWidthData(DescribeUserBandWidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserBandWidthDataWithOptions(request, runtime);
        }

        public async Task<DescribeUserBandWidthDataResponse> DescribeUserBandWidthDataAsync(DescribeUserBandWidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserBandWidthDataWithOptionsAsync(request, runtime);
        }

        public DescribeVSwitchesResponse DescribeVSwitchesWithOptions(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(DoRPCRequest("DescribeVSwitches", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesWithOptionsAsync(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(await DoRPCRequestAsync("DescribeVSwitches", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVSwitchesResponse DescribeVSwitches(DescribeVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVSwitchesWithOptions(request, runtime);
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesAsync(DescribeVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVSwitchesWithOptionsAsync(request, runtime);
        }

        public ExportBillDetailDataResponse ExportBillDetailDataWithOptions(ExportBillDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportBillDetailDataResponse>(DoRPCRequest("ExportBillDetailData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportBillDetailDataResponse> ExportBillDetailDataWithOptionsAsync(ExportBillDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportBillDetailDataResponse>(await DoRPCRequestAsync("ExportBillDetailData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportBillDetailDataResponse ExportBillDetailData(ExportBillDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportBillDetailDataWithOptions(request, runtime);
        }

        public async Task<ExportBillDetailDataResponse> ExportBillDetailDataAsync(ExportBillDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportBillDetailDataWithOptionsAsync(request, runtime);
        }

        public ExportImageResponse ExportImageWithOptions(ExportImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportImageResponse>(DoRPCRequest("ExportImage", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportImageResponse> ExportImageWithOptionsAsync(ExportImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportImageResponse>(await DoRPCRequestAsync("ExportImage", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportImageResponse ExportImage(ExportImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportImageWithOptions(request, runtime);
        }

        public async Task<ExportImageResponse> ExportImageAsync(ExportImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportImageWithOptionsAsync(request, runtime);
        }

        public ExportMeasurementDataResponse ExportMeasurementDataWithOptions(ExportMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportMeasurementDataResponse>(DoRPCRequest("ExportMeasurementData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportMeasurementDataResponse> ExportMeasurementDataWithOptionsAsync(ExportMeasurementDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportMeasurementDataResponse>(await DoRPCRequestAsync("ExportMeasurementData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportMeasurementDataResponse ExportMeasurementData(ExportMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportMeasurementDataWithOptions(request, runtime);
        }

        public async Task<ExportMeasurementDataResponse> ExportMeasurementDataAsync(ExportMeasurementDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportMeasurementDataWithOptionsAsync(request, runtime);
        }

        public GetVmListResponse GetVmListWithOptions(GetVmListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVmListResponse>(DoRPCRequest("GetVmList", "2017-11-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetVmListResponse> GetVmListWithOptionsAsync(GetVmListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVmListResponse>(await DoRPCRequestAsync("GetVmList", "2017-11-10", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetVmListResponse GetVmList(GetVmListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVmListWithOptions(request, runtime);
        }

        public async Task<GetVmListResponse> GetVmListAsync(GetVmListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVmListWithOptionsAsync(request, runtime);
        }

        public ImportKeyPairResponse ImportKeyPairWithOptions(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportKeyPairResponse>(DoRPCRequest("ImportKeyPair", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportKeyPairResponse> ImportKeyPairWithOptionsAsync(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportKeyPairResponse>(await DoRPCRequestAsync("ImportKeyPair", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportKeyPairWithOptions(request, runtime);
        }

        public async Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportKeyPairWithOptionsAsync(request, runtime);
        }

        public JoinPublicIpsToEpnInstanceResponse JoinPublicIpsToEpnInstanceWithOptions(JoinPublicIpsToEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinPublicIpsToEpnInstanceResponse>(DoRPCRequest("JoinPublicIpsToEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinPublicIpsToEpnInstanceResponse> JoinPublicIpsToEpnInstanceWithOptionsAsync(JoinPublicIpsToEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinPublicIpsToEpnInstanceResponse>(await DoRPCRequestAsync("JoinPublicIpsToEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public JoinPublicIpsToEpnInstanceResponse JoinPublicIpsToEpnInstance(JoinPublicIpsToEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinPublicIpsToEpnInstanceWithOptions(request, runtime);
        }

        public async Task<JoinPublicIpsToEpnInstanceResponse> JoinPublicIpsToEpnInstanceAsync(JoinPublicIpsToEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinPublicIpsToEpnInstanceWithOptionsAsync(request, runtime);
        }

        public JoinSecurityGroupResponse JoinSecurityGroupWithOptions(JoinSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinSecurityGroupResponse>(DoRPCRequest("JoinSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinSecurityGroupResponse> JoinSecurityGroupWithOptionsAsync(JoinSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinSecurityGroupResponse>(await DoRPCRequestAsync("JoinSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public JoinSecurityGroupResponse JoinSecurityGroup(JoinSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinSecurityGroupWithOptions(request, runtime);
        }

        public async Task<JoinSecurityGroupResponse> JoinSecurityGroupAsync(JoinSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinSecurityGroupWithOptionsAsync(request, runtime);
        }

        public JoinVSwitchesToEpnInstanceResponse JoinVSwitchesToEpnInstanceWithOptions(JoinVSwitchesToEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinVSwitchesToEpnInstanceResponse>(DoRPCRequest("JoinVSwitchesToEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinVSwitchesToEpnInstanceResponse> JoinVSwitchesToEpnInstanceWithOptionsAsync(JoinVSwitchesToEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinVSwitchesToEpnInstanceResponse>(await DoRPCRequestAsync("JoinVSwitchesToEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public JoinVSwitchesToEpnInstanceResponse JoinVSwitchesToEpnInstance(JoinVSwitchesToEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinVSwitchesToEpnInstanceWithOptions(request, runtime);
        }

        public async Task<JoinVSwitchesToEpnInstanceResponse> JoinVSwitchesToEpnInstanceAsync(JoinVSwitchesToEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinVSwitchesToEpnInstanceWithOptionsAsync(request, runtime);
        }

        public LeaveSecurityGroupResponse LeaveSecurityGroupWithOptions(LeaveSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LeaveSecurityGroupResponse>(DoRPCRequest("LeaveSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LeaveSecurityGroupResponse> LeaveSecurityGroupWithOptionsAsync(LeaveSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LeaveSecurityGroupResponse>(await DoRPCRequestAsync("LeaveSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LeaveSecurityGroupResponse LeaveSecurityGroup(LeaveSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LeaveSecurityGroupWithOptions(request, runtime);
        }

        public async Task<LeaveSecurityGroupResponse> LeaveSecurityGroupAsync(LeaveSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LeaveSecurityGroupWithOptionsAsync(request, runtime);
        }

        public ListApplicationsResponse ListApplicationsWithOptions(ListApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListApplicationsResponse>(DoRPCRequest("ListApplications", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListApplicationsResponse> ListApplicationsWithOptionsAsync(ListApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListApplicationsResponse>(await DoRPCRequestAsync("ListApplications", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsWithOptions(request, runtime);
        }

        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsWithOptionsAsync(request, runtime);
        }

        public ModifyEpnInstanceResponse ModifyEpnInstanceWithOptions(ModifyEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEpnInstanceResponse>(DoRPCRequest("ModifyEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyEpnInstanceResponse> ModifyEpnInstanceWithOptionsAsync(ModifyEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEpnInstanceResponse>(await DoRPCRequestAsync("ModifyEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyEpnInstanceResponse ModifyEpnInstance(ModifyEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEpnInstanceWithOptions(request, runtime);
        }

        public async Task<ModifyEpnInstanceResponse> ModifyEpnInstanceAsync(ModifyEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEpnInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyImageAttributeResponse ModifyImageAttributeWithOptions(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageAttributeResponse>(DoRPCRequest("ModifyImageAttribute", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyImageAttributeResponse> ModifyImageAttributeWithOptionsAsync(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageAttributeResponse>(await DoRPCRequestAsync("ModifyImageAttribute", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyImageAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyImageAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyImageSharePermissionResponse ModifyImageSharePermissionWithOptions(ModifyImageSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageSharePermissionResponse>(DoRPCRequest("ModifyImageSharePermission", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyImageSharePermissionResponse> ModifyImageSharePermissionWithOptionsAsync(ModifyImageSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageSharePermissionResponse>(await DoRPCRequestAsync("ModifyImageSharePermission", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyImageSharePermissionResponse ModifyImageSharePermission(ModifyImageSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyImageSharePermissionWithOptions(request, runtime);
        }

        public async Task<ModifyImageSharePermissionResponse> ModifyImageSharePermissionAsync(ModifyImageSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyImageSharePermissionWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttributeWithOptions(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(DoRPCRequest("ModifyInstanceAttribute", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeWithOptionsAsync(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(await DoRPCRequestAsync("ModifyInstanceAttribute", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public PreCreateEnsServiceResponse PreCreateEnsServiceWithOptions(PreCreateEnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreCreateEnsServiceResponse>(DoRPCRequest("PreCreateEnsService", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PreCreateEnsServiceResponse> PreCreateEnsServiceWithOptionsAsync(PreCreateEnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreCreateEnsServiceResponse>(await DoRPCRequestAsync("PreCreateEnsService", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PreCreateEnsServiceResponse PreCreateEnsService(PreCreateEnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreCreateEnsServiceWithOptions(request, runtime);
        }

        public async Task<PreCreateEnsServiceResponse> PreCreateEnsServiceAsync(PreCreateEnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreCreateEnsServiceWithOptionsAsync(request, runtime);
        }

        public PushApplicationDataResponse PushApplicationDataWithOptions(PushApplicationDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushApplicationDataResponse>(DoRPCRequest("PushApplicationData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PushApplicationDataResponse> PushApplicationDataWithOptionsAsync(PushApplicationDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushApplicationDataResponse>(await DoRPCRequestAsync("PushApplicationData", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PushApplicationDataResponse PushApplicationData(PushApplicationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushApplicationDataWithOptions(request, runtime);
        }

        public async Task<PushApplicationDataResponse> PushApplicationDataAsync(PushApplicationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushApplicationDataWithOptionsAsync(request, runtime);
        }

        public RebootInstanceResponse RebootInstanceWithOptions(RebootInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootInstanceResponse>(DoRPCRequest("RebootInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RebootInstanceResponse> RebootInstanceWithOptionsAsync(RebootInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootInstanceResponse>(await DoRPCRequestAsync("RebootInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootInstanceWithOptions(request, runtime);
        }

        public async Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootInstanceWithOptionsAsync(request, runtime);
        }

        public ReInitDiskResponse ReInitDiskWithOptions(ReInitDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReInitDiskResponse>(DoRPCRequest("ReInitDisk", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReInitDiskResponse> ReInitDiskWithOptionsAsync(ReInitDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReInitDiskResponse>(await DoRPCRequestAsync("ReInitDisk", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReInitDiskResponse ReInitDisk(ReInitDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReInitDiskWithOptions(request, runtime);
        }

        public async Task<ReInitDiskResponse> ReInitDiskAsync(ReInitDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReInitDiskWithOptionsAsync(request, runtime);
        }

        public ReleaseEipAddressResponse ReleaseEipAddressWithOptions(ReleaseEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseEipAddressResponse>(DoRPCRequest("ReleaseEipAddress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseEipAddressResponse> ReleaseEipAddressWithOptionsAsync(ReleaseEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseEipAddressResponse>(await DoRPCRequestAsync("ReleaseEipAddress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseEipAddressResponse ReleaseEipAddress(ReleaseEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseEipAddressWithOptions(request, runtime);
        }

        public async Task<ReleaseEipAddressResponse> ReleaseEipAddressAsync(ReleaseEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseEipAddressWithOptionsAsync(request, runtime);
        }

        public ReleasePostPaidInstanceResponse ReleasePostPaidInstanceWithOptions(ReleasePostPaidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleasePostPaidInstanceResponse>(DoRPCRequest("ReleasePostPaidInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleasePostPaidInstanceResponse> ReleasePostPaidInstanceWithOptionsAsync(ReleasePostPaidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleasePostPaidInstanceResponse>(await DoRPCRequestAsync("ReleasePostPaidInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleasePostPaidInstanceResponse ReleasePostPaidInstance(ReleasePostPaidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePostPaidInstanceWithOptions(request, runtime);
        }

        public async Task<ReleasePostPaidInstanceResponse> ReleasePostPaidInstanceAsync(ReleasePostPaidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePostPaidInstanceWithOptionsAsync(request, runtime);
        }

        public ReleasePrePaidInstanceResponse ReleasePrePaidInstanceWithOptions(ReleasePrePaidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleasePrePaidInstanceResponse>(DoRPCRequest("ReleasePrePaidInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleasePrePaidInstanceResponse> ReleasePrePaidInstanceWithOptionsAsync(ReleasePrePaidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleasePrePaidInstanceResponse>(await DoRPCRequestAsync("ReleasePrePaidInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleasePrePaidInstanceResponse ReleasePrePaidInstance(ReleasePrePaidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePrePaidInstanceWithOptions(request, runtime);
        }

        public async Task<ReleasePrePaidInstanceResponse> ReleasePrePaidInstanceAsync(ReleasePrePaidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePrePaidInstanceWithOptionsAsync(request, runtime);
        }

        public RemovePublicIpsFromEpnInstanceResponse RemovePublicIpsFromEpnInstanceWithOptions(RemovePublicIpsFromEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePublicIpsFromEpnInstanceResponse>(DoRPCRequest("RemovePublicIpsFromEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemovePublicIpsFromEpnInstanceResponse> RemovePublicIpsFromEpnInstanceWithOptionsAsync(RemovePublicIpsFromEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemovePublicIpsFromEpnInstanceResponse>(await DoRPCRequestAsync("RemovePublicIpsFromEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemovePublicIpsFromEpnInstanceResponse RemovePublicIpsFromEpnInstance(RemovePublicIpsFromEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePublicIpsFromEpnInstanceWithOptions(request, runtime);
        }

        public async Task<RemovePublicIpsFromEpnInstanceResponse> RemovePublicIpsFromEpnInstanceAsync(RemovePublicIpsFromEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePublicIpsFromEpnInstanceWithOptionsAsync(request, runtime);
        }

        public RemoveVSwitchesFromEpnInstanceResponse RemoveVSwitchesFromEpnInstanceWithOptions(RemoveVSwitchesFromEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVSwitchesFromEpnInstanceResponse>(DoRPCRequest("RemoveVSwitchesFromEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveVSwitchesFromEpnInstanceResponse> RemoveVSwitchesFromEpnInstanceWithOptionsAsync(RemoveVSwitchesFromEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVSwitchesFromEpnInstanceResponse>(await DoRPCRequestAsync("RemoveVSwitchesFromEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveVSwitchesFromEpnInstanceResponse RemoveVSwitchesFromEpnInstance(RemoveVSwitchesFromEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveVSwitchesFromEpnInstanceWithOptions(request, runtime);
        }

        public async Task<RemoveVSwitchesFromEpnInstanceResponse> RemoveVSwitchesFromEpnInstanceAsync(RemoveVSwitchesFromEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveVSwitchesFromEpnInstanceWithOptionsAsync(request, runtime);
        }

        public RescaleApplicationResponse RescaleApplicationWithOptions(RescaleApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RescaleApplicationResponse>(DoRPCRequest("RescaleApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RescaleApplicationResponse> RescaleApplicationWithOptionsAsync(RescaleApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RescaleApplicationResponse>(await DoRPCRequestAsync("RescaleApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RescaleApplicationResponse RescaleApplication(RescaleApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RescaleApplicationWithOptions(request, runtime);
        }

        public async Task<RescaleApplicationResponse> RescaleApplicationAsync(RescaleApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RescaleApplicationWithOptionsAsync(request, runtime);
        }

        public RevokeSecurityGroupResponse RevokeSecurityGroupWithOptions(RevokeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeSecurityGroupResponse>(DoRPCRequest("RevokeSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeSecurityGroupResponse> RevokeSecurityGroupWithOptionsAsync(RevokeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeSecurityGroupResponse>(await DoRPCRequestAsync("RevokeSecurityGroup", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeSecurityGroupResponse RevokeSecurityGroup(RevokeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeSecurityGroupWithOptions(request, runtime);
        }

        public async Task<RevokeSecurityGroupResponse> RevokeSecurityGroupAsync(RevokeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeSecurityGroupWithOptionsAsync(request, runtime);
        }

        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgressWithOptions(RevokeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeSecurityGroupEgressResponse>(DoRPCRequest("RevokeSecurityGroupEgress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressWithOptionsAsync(RevokeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeSecurityGroupEgressResponse>(await DoRPCRequestAsync("RevokeSecurityGroupEgress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeSecurityGroupEgressWithOptions(request, runtime);
        }

        public async Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeSecurityGroupEgressWithOptionsAsync(request, runtime);
        }

        public RollbackApplicationResponse RollbackApplicationWithOptions(RollbackApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackApplicationResponse>(DoRPCRequest("RollbackApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RollbackApplicationResponse> RollbackApplicationWithOptionsAsync(RollbackApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackApplicationResponse>(await DoRPCRequestAsync("RollbackApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RollbackApplicationResponse RollbackApplication(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackApplicationWithOptions(request, runtime);
        }

        public async Task<RollbackApplicationResponse> RollbackApplicationAsync(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackApplicationWithOptionsAsync(request, runtime);
        }

        public RunServiceScheduleResponse RunServiceScheduleWithOptions(RunServiceScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunServiceScheduleResponse>(DoRPCRequest("RunServiceSchedule", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunServiceScheduleResponse> RunServiceScheduleWithOptionsAsync(RunServiceScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunServiceScheduleResponse>(await DoRPCRequestAsync("RunServiceSchedule", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunServiceScheduleResponse RunServiceSchedule(RunServiceScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunServiceScheduleWithOptions(request, runtime);
        }

        public async Task<RunServiceScheduleResponse> RunServiceScheduleAsync(RunServiceScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunServiceScheduleWithOptionsAsync(request, runtime);
        }

        public SchedulePodResponse SchedulePodWithOptions(SchedulePodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SchedulePodResponse>(DoRPCRequest("SchedulePod", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SchedulePodResponse> SchedulePodWithOptionsAsync(SchedulePodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SchedulePodResponse>(await DoRPCRequestAsync("SchedulePod", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SchedulePodResponse SchedulePod(SchedulePodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SchedulePodWithOptions(request, runtime);
        }

        public async Task<SchedulePodResponse> SchedulePodAsync(SchedulePodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SchedulePodWithOptionsAsync(request, runtime);
        }

        public StartEpnInstanceResponse StartEpnInstanceWithOptions(StartEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartEpnInstanceResponse>(DoRPCRequest("StartEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartEpnInstanceResponse> StartEpnInstanceWithOptionsAsync(StartEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartEpnInstanceResponse>(await DoRPCRequestAsync("StartEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartEpnInstanceResponse StartEpnInstance(StartEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartEpnInstanceWithOptions(request, runtime);
        }

        public async Task<StartEpnInstanceResponse> StartEpnInstanceAsync(StartEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartEpnInstanceWithOptionsAsync(request, runtime);
        }

        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstanceResponse>(DoRPCRequest("StartInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstanceResponse>(await DoRPCRequestAsync("StartInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstanceWithOptions(request, runtime);
        }

        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstanceWithOptionsAsync(request, runtime);
        }

        public StopEpnInstanceResponse StopEpnInstanceWithOptions(StopEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopEpnInstanceResponse>(DoRPCRequest("StopEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopEpnInstanceResponse> StopEpnInstanceWithOptionsAsync(StopEpnInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopEpnInstanceResponse>(await DoRPCRequestAsync("StopEpnInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopEpnInstanceResponse StopEpnInstance(StopEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopEpnInstanceWithOptions(request, runtime);
        }

        public async Task<StopEpnInstanceResponse> StopEpnInstanceAsync(StopEpnInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopEpnInstanceWithOptionsAsync(request, runtime);
        }

        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInstanceResponse>(DoRPCRequest("StopInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInstanceResponse>(await DoRPCRequestAsync("StopInstance", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        public UnassociateEipAddressResponse UnassociateEipAddressWithOptions(UnassociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateEipAddressResponse>(DoRPCRequest("UnassociateEipAddress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociateEipAddressResponse> UnassociateEipAddressWithOptionsAsync(UnassociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateEipAddressResponse>(await DoRPCRequestAsync("UnassociateEipAddress", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociateEipAddressResponse UnassociateEipAddress(UnassociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateEipAddressWithOptions(request, runtime);
        }

        public async Task<UnassociateEipAddressResponse> UnassociateEipAddressAsync(UnassociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateEipAddressWithOptionsAsync(request, runtime);
        }

        public UpgradeApplicationResponse UpgradeApplicationWithOptions(UpgradeApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeApplicationResponse>(DoRPCRequest("UpgradeApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeApplicationResponse> UpgradeApplicationWithOptionsAsync(UpgradeApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeApplicationResponse>(await DoRPCRequestAsync("UpgradeApplication", "2017-11-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeApplicationResponse UpgradeApplication(UpgradeApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeApplicationWithOptions(request, runtime);
        }

        public async Task<UpgradeApplicationResponse> UpgradeApplicationAsync(UpgradeApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeApplicationWithOptionsAsync(request, runtime);
        }

    }
}
