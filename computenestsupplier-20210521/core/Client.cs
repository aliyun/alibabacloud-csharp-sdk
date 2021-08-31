// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ComputeNestSupplier20210521.Models;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("computenestsupplier", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CancelServiceRegistrationResponse CancelServiceRegistrationWithOptions(CancelServiceRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelServiceRegistrationResponse>(DoRPCRequest("CancelServiceRegistration", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelServiceRegistrationResponse> CancelServiceRegistrationWithOptionsAsync(CancelServiceRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelServiceRegistrationResponse>(await DoRPCRequestAsync("CancelServiceRegistration", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelServiceRegistrationResponse CancelServiceRegistration(CancelServiceRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelServiceRegistrationWithOptions(request, runtime);
        }

        public async Task<CancelServiceRegistrationResponse> CancelServiceRegistrationAsync(CancelServiceRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelServiceRegistrationWithOptionsAsync(request, runtime);
        }

        public CreateServiceResponse CreateServiceWithOptions(CreateServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceResponse>(DoRPCRequest("CreateService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(CreateServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceResponse>(await DoRPCRequestAsync("CreateService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceWithOptions(request, runtime);
        }

        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceWithOptionsAsync(request, runtime);
        }

        public DeleteServiceResponse DeleteServiceWithOptions(DeleteServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteServiceResponse>(DoRPCRequest("DeleteService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(DeleteServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await DoRPCRequestAsync("DeleteService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceWithOptions(request, runtime);
        }

        public async Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceWithOptionsAsync(request, runtime);
        }

        public GetServiceResponse GetServiceWithOptions(GetServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceResponse>(DoRPCRequest("GetService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(GetServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceResponse>(await DoRPCRequestAsync("GetService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetServiceResponse GetService(GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceWithOptions(request, runtime);
        }

        public async Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceWithOptionsAsync(request, runtime);
        }

        public GetServiceInstanceResponse GetServiceInstanceWithOptions(GetServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceInstanceResponse>(DoRPCRequest("GetServiceInstance", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetServiceInstanceResponse> GetServiceInstanceWithOptionsAsync(GetServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceInstanceResponse>(await DoRPCRequestAsync("GetServiceInstance", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetServiceInstanceResponse GetServiceInstance(GetServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceInstanceWithOptions(request, runtime);
        }

        public async Task<GetServiceInstanceResponse> GetServiceInstanceAsync(GetServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceInstanceWithOptionsAsync(request, runtime);
        }

        public GetSupplierInformationResponse GetSupplierInformationWithOptions(GetSupplierInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSupplierInformationResponse>(DoRPCRequest("GetSupplierInformation", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSupplierInformationResponse> GetSupplierInformationWithOptionsAsync(GetSupplierInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSupplierInformationResponse>(await DoRPCRequestAsync("GetSupplierInformation", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSupplierInformationResponse GetSupplierInformation(GetSupplierInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSupplierInformationWithOptions(request, runtime);
        }

        public async Task<GetSupplierInformationResponse> GetSupplierInformationAsync(GetSupplierInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSupplierInformationWithOptionsAsync(request, runtime);
        }

        public LaunchServiceResponse LaunchServiceWithOptions(LaunchServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LaunchServiceResponse>(DoRPCRequest("LaunchService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LaunchServiceResponse> LaunchServiceWithOptionsAsync(LaunchServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LaunchServiceResponse>(await DoRPCRequestAsync("LaunchService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LaunchServiceResponse LaunchService(LaunchServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LaunchServiceWithOptions(request, runtime);
        }

        public async Task<LaunchServiceResponse> LaunchServiceAsync(LaunchServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LaunchServiceWithOptionsAsync(request, runtime);
        }

        public ListServiceInstancesResponse ListServiceInstancesWithOptions(ListServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(DoRPCRequest("ListServiceInstances", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListServiceInstancesResponse> ListServiceInstancesWithOptionsAsync(ListServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(await DoRPCRequestAsync("ListServiceInstances", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListServiceInstancesResponse ListServiceInstances(ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceInstancesWithOptions(request, runtime);
        }

        public async Task<ListServiceInstancesResponse> ListServiceInstancesAsync(ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceInstancesWithOptionsAsync(request, runtime);
        }

        public ListServiceRegistrationsResponse ListServiceRegistrationsWithOptions(ListServiceRegistrationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServiceRegistrationsResponse>(DoRPCRequest("ListServiceRegistrations", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListServiceRegistrationsResponse> ListServiceRegistrationsWithOptionsAsync(ListServiceRegistrationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServiceRegistrationsResponse>(await DoRPCRequestAsync("ListServiceRegistrations", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListServiceRegistrationsResponse ListServiceRegistrations(ListServiceRegistrationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceRegistrationsWithOptions(request, runtime);
        }

        public async Task<ListServiceRegistrationsResponse> ListServiceRegistrationsAsync(ListServiceRegistrationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceRegistrationsWithOptionsAsync(request, runtime);
        }

        public ListServicesResponse ListServicesWithOptions(ListServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServicesResponse>(DoRPCRequest("ListServices", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(ListServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServicesResponse>(await DoRPCRequestAsync("ListServices", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServicesWithOptions(request, runtime);
        }

        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServicesWithOptionsAsync(request, runtime);
        }

        public RegisterServiceResponse RegisterServiceWithOptions(RegisterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterServiceResponse>(DoRPCRequest("RegisterService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterServiceResponse> RegisterServiceWithOptionsAsync(RegisterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterServiceResponse>(await DoRPCRequestAsync("RegisterService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterServiceResponse RegisterService(RegisterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterServiceWithOptions(request, runtime);
        }

        public async Task<RegisterServiceResponse> RegisterServiceAsync(RegisterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterServiceWithOptionsAsync(request, runtime);
        }

        public UpdateServiceResponse UpdateServiceWithOptions(UpdateServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateServiceResponse>(DoRPCRequest("UpdateService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(UpdateServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await DoRPCRequestAsync("UpdateService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceWithOptions(request, runtime);
        }

        public async Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceWithOptionsAsync(request, runtime);
        }

        public WithdrawServiceResponse WithdrawServiceWithOptions(WithdrawServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WithdrawServiceResponse>(DoRPCRequest("WithdrawService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<WithdrawServiceResponse> WithdrawServiceWithOptionsAsync(WithdrawServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WithdrawServiceResponse>(await DoRPCRequestAsync("WithdrawService", "2021-05-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public WithdrawServiceResponse WithdrawService(WithdrawServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WithdrawServiceWithOptions(request, runtime);
        }

        public async Task<WithdrawServiceResponse> WithdrawServiceAsync(WithdrawServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WithdrawServiceWithOptionsAsync(request, runtime);
        }

    }
}
