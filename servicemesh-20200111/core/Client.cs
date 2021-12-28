// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Servicemesh20200111.Models;

namespace AlibabaCloud.SDK.Servicemesh20200111
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("servicemesh", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddBuiltinEnvoyFilterResponse AddBuiltinEnvoyFilterWithOptions(AddBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddBuiltinEnvoyFilterResponse>(DoRPCRequest("AddBuiltinEnvoyFilter", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddBuiltinEnvoyFilterResponse> AddBuiltinEnvoyFilterWithOptionsAsync(AddBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddBuiltinEnvoyFilterResponse>(await DoRPCRequestAsync("AddBuiltinEnvoyFilter", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddBuiltinEnvoyFilterResponse AddBuiltinEnvoyFilter(AddBuiltinEnvoyFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBuiltinEnvoyFilterWithOptions(request, runtime);
        }

        public async Task<AddBuiltinEnvoyFilterResponse> AddBuiltinEnvoyFilterAsync(AddBuiltinEnvoyFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBuiltinEnvoyFilterWithOptionsAsync(request, runtime);
        }

        public AddClusterIntoServiceMeshResponse AddClusterIntoServiceMeshWithOptions(AddClusterIntoServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddClusterIntoServiceMeshResponse>(DoRPCRequest("AddClusterIntoServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddClusterIntoServiceMeshResponse> AddClusterIntoServiceMeshWithOptionsAsync(AddClusterIntoServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddClusterIntoServiceMeshResponse>(await DoRPCRequestAsync("AddClusterIntoServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddClusterIntoServiceMeshResponse AddClusterIntoServiceMesh(AddClusterIntoServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddClusterIntoServiceMeshWithOptions(request, runtime);
        }

        public async Task<AddClusterIntoServiceMeshResponse> AddClusterIntoServiceMeshAsync(AddClusterIntoServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddClusterIntoServiceMeshWithOptionsAsync(request, runtime);
        }

        public AddMeshTagToEcsResponse AddMeshTagToEcsWithOptions(AddMeshTagToEcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMeshTagToEcsResponse>(DoRPCRequest("AddMeshTagToEcs", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddMeshTagToEcsResponse> AddMeshTagToEcsWithOptionsAsync(AddMeshTagToEcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMeshTagToEcsResponse>(await DoRPCRequestAsync("AddMeshTagToEcs", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddMeshTagToEcsResponse AddMeshTagToEcs(AddMeshTagToEcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMeshTagToEcsWithOptions(request, runtime);
        }

        public async Task<AddMeshTagToEcsResponse> AddMeshTagToEcsAsync(AddMeshTagToEcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMeshTagToEcsWithOptionsAsync(request, runtime);
        }

        public AddVMIntoServiceMeshResponse AddVMIntoServiceMeshWithOptions(AddVMIntoServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVMIntoServiceMeshResponse>(DoRPCRequest("AddVMIntoServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddVMIntoServiceMeshResponse> AddVMIntoServiceMeshWithOptionsAsync(AddVMIntoServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVMIntoServiceMeshResponse>(await DoRPCRequestAsync("AddVMIntoServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddVMIntoServiceMeshResponse AddVMIntoServiceMesh(AddVMIntoServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVMIntoServiceMeshWithOptions(request, runtime);
        }

        public async Task<AddVMIntoServiceMeshResponse> AddVMIntoServiceMeshAsync(AddVMIntoServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVMIntoServiceMeshWithOptionsAsync(request, runtime);
        }

        public CreateExtensionProviderResponse CreateExtensionProviderWithOptions(CreateExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateExtensionProviderResponse>(DoRPCRequest("CreateExtensionProvider", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateExtensionProviderResponse> CreateExtensionProviderWithOptionsAsync(CreateExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateExtensionProviderResponse>(await DoRPCRequestAsync("CreateExtensionProvider", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateExtensionProviderResponse CreateExtensionProvider(CreateExtensionProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExtensionProviderWithOptions(request, runtime);
        }

        public async Task<CreateExtensionProviderResponse> CreateExtensionProviderAsync(CreateExtensionProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExtensionProviderWithOptionsAsync(request, runtime);
        }

        public CreateServiceMeshResponse CreateServiceMeshWithOptions(CreateServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceMeshResponse>(DoRPCRequest("CreateServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateServiceMeshResponse> CreateServiceMeshWithOptionsAsync(CreateServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateServiceMeshResponse>(await DoRPCRequestAsync("CreateServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateServiceMeshResponse CreateServiceMesh(CreateServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceMeshWithOptions(request, runtime);
        }

        public async Task<CreateServiceMeshResponse> CreateServiceMeshAsync(CreateServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceMeshWithOptionsAsync(request, runtime);
        }

        public DeleteExtensionProviderResponse DeleteExtensionProviderWithOptions(DeleteExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExtensionProviderResponse>(DoRPCRequest("DeleteExtensionProvider", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteExtensionProviderResponse> DeleteExtensionProviderWithOptionsAsync(DeleteExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExtensionProviderResponse>(await DoRPCRequestAsync("DeleteExtensionProvider", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteExtensionProviderResponse DeleteExtensionProvider(DeleteExtensionProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExtensionProviderWithOptions(request, runtime);
        }

        public async Task<DeleteExtensionProviderResponse> DeleteExtensionProviderAsync(DeleteExtensionProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExtensionProviderWithOptionsAsync(request, runtime);
        }

        public DeleteServiceMeshResponse DeleteServiceMeshWithOptions(DeleteServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteServiceMeshResponse>(DoRPCRequest("DeleteServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteServiceMeshResponse> DeleteServiceMeshWithOptionsAsync(DeleteServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteServiceMeshResponse>(await DoRPCRequestAsync("DeleteServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteServiceMeshResponse DeleteServiceMesh(DeleteServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceMeshWithOptions(request, runtime);
        }

        public async Task<DeleteServiceMeshResponse> DeleteServiceMeshAsync(DeleteServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceMeshWithOptionsAsync(request, runtime);
        }

        public DescribeAlertActionPoliciesResponse DescribeAlertActionPoliciesWithOptions(DescribeAlertActionPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlertActionPoliciesResponse>(DoRPCRequest("DescribeAlertActionPolicies", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAlertActionPoliciesResponse> DescribeAlertActionPoliciesWithOptionsAsync(DescribeAlertActionPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAlertActionPoliciesResponse>(await DoRPCRequestAsync("DescribeAlertActionPolicies", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAlertActionPoliciesResponse DescribeAlertActionPolicies(DescribeAlertActionPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertActionPoliciesWithOptions(request, runtime);
        }

        public async Task<DescribeAlertActionPoliciesResponse> DescribeAlertActionPoliciesAsync(DescribeAlertActionPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertActionPoliciesWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableNacosInstancesResponse DescribeAvailableNacosInstancesWithOptions(DescribeAvailableNacosInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableNacosInstancesResponse>(DoRPCRequest("DescribeAvailableNacosInstances", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableNacosInstancesResponse> DescribeAvailableNacosInstancesWithOptionsAsync(DescribeAvailableNacosInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableNacosInstancesResponse>(await DoRPCRequestAsync("DescribeAvailableNacosInstances", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableNacosInstancesResponse DescribeAvailableNacosInstances(DescribeAvailableNacosInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableNacosInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableNacosInstancesResponse> DescribeAvailableNacosInstancesAsync(DescribeAvailableNacosInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableNacosInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeCensResponse DescribeCensWithOptions(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCensResponse>(DoRPCRequest("DescribeCens", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCensResponse> DescribeCensWithOptionsAsync(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCensResponse>(await DoRPCRequestAsync("DescribeCens", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCensResponse DescribeCens(DescribeCensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCensWithOptions(request, runtime);
        }

        public async Task<DescribeCensResponse> DescribeCensAsync(DescribeCensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCensWithOptionsAsync(request, runtime);
        }

        public DescribeClusterGrafanaResponse DescribeClusterGrafanaWithOptions(DescribeClusterGrafanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterGrafanaResponse>(DoRPCRequest("DescribeClusterGrafana", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterGrafanaResponse> DescribeClusterGrafanaWithOptionsAsync(DescribeClusterGrafanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterGrafanaResponse>(await DoRPCRequestAsync("DescribeClusterGrafana", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterGrafanaResponse DescribeClusterGrafana(DescribeClusterGrafanaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterGrafanaWithOptions(request, runtime);
        }

        public async Task<DescribeClusterGrafanaResponse> DescribeClusterGrafanaAsync(DescribeClusterGrafanaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterGrafanaWithOptionsAsync(request, runtime);
        }

        public DescribeClusterPrometheusResponse DescribeClusterPrometheusWithOptions(DescribeClusterPrometheusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterPrometheusResponse>(DoRPCRequest("DescribeClusterPrometheus", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterPrometheusResponse> DescribeClusterPrometheusWithOptionsAsync(DescribeClusterPrometheusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterPrometheusResponse>(await DoRPCRequestAsync("DescribeClusterPrometheus", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterPrometheusResponse DescribeClusterPrometheus(DescribeClusterPrometheusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterPrometheusWithOptions(request, runtime);
        }

        public async Task<DescribeClusterPrometheusResponse> DescribeClusterPrometheusAsync(DescribeClusterPrometheusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterPrometheusWithOptionsAsync(request, runtime);
        }

        public DescribeClustersInServiceMeshResponse DescribeClustersInServiceMeshWithOptions(DescribeClustersInServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClustersInServiceMeshResponse>(DoRPCRequest("DescribeClustersInServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClustersInServiceMeshResponse> DescribeClustersInServiceMeshWithOptionsAsync(DescribeClustersInServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClustersInServiceMeshResponse>(await DoRPCRequestAsync("DescribeClustersInServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClustersInServiceMeshResponse DescribeClustersInServiceMesh(DescribeClustersInServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClustersInServiceMeshWithOptions(request, runtime);
        }

        public async Task<DescribeClustersInServiceMeshResponse> DescribeClustersInServiceMeshAsync(DescribeClustersInServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClustersInServiceMeshWithOptionsAsync(request, runtime);
        }

        public DescribeControlPlaneLogAlertRulesResponse DescribeControlPlaneLogAlertRulesWithOptions(DescribeControlPlaneLogAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeControlPlaneLogAlertRulesResponse>(DoRPCRequest("DescribeControlPlaneLogAlertRules", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeControlPlaneLogAlertRulesResponse> DescribeControlPlaneLogAlertRulesWithOptionsAsync(DescribeControlPlaneLogAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeControlPlaneLogAlertRulesResponse>(await DoRPCRequestAsync("DescribeControlPlaneLogAlertRules", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeControlPlaneLogAlertRulesResponse DescribeControlPlaneLogAlertRules(DescribeControlPlaneLogAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeControlPlaneLogAlertRulesWithOptions(request, runtime);
        }

        public async Task<DescribeControlPlaneLogAlertRulesResponse> DescribeControlPlaneLogAlertRulesAsync(DescribeControlPlaneLogAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeControlPlaneLogAlertRulesWithOptionsAsync(request, runtime);
        }

        public DescribeCrTemplatesResponse DescribeCrTemplatesWithOptions(DescribeCrTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrTemplatesResponse>(DoRPCRequest("DescribeCrTemplates", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCrTemplatesResponse> DescribeCrTemplatesWithOptionsAsync(DescribeCrTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrTemplatesResponse>(await DoRPCRequestAsync("DescribeCrTemplates", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCrTemplatesResponse DescribeCrTemplates(DescribeCrTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribeCrTemplatesResponse> DescribeCrTemplatesAsync(DescribeCrTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribeExtensionProviderResponse DescribeExtensionProviderWithOptions(DescribeExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExtensionProviderResponse>(DoRPCRequest("DescribeExtensionProvider", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExtensionProviderResponse> DescribeExtensionProviderWithOptionsAsync(DescribeExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExtensionProviderResponse>(await DoRPCRequestAsync("DescribeExtensionProvider", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExtensionProviderResponse DescribeExtensionProvider(DescribeExtensionProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExtensionProviderWithOptions(request, runtime);
        }

        public async Task<DescribeExtensionProviderResponse> DescribeExtensionProviderAsync(DescribeExtensionProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExtensionProviderWithOptionsAsync(request, runtime);
        }

        public DescribeGuestClusterAccessLogDashboardsResponse DescribeGuestClusterAccessLogDashboardsWithOptions(DescribeGuestClusterAccessLogDashboardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGuestClusterAccessLogDashboardsResponse>(DoRPCRequest("DescribeGuestClusterAccessLogDashboards", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGuestClusterAccessLogDashboardsResponse> DescribeGuestClusterAccessLogDashboardsWithOptionsAsync(DescribeGuestClusterAccessLogDashboardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGuestClusterAccessLogDashboardsResponse>(await DoRPCRequestAsync("DescribeGuestClusterAccessLogDashboards", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGuestClusterAccessLogDashboardsResponse DescribeGuestClusterAccessLogDashboards(DescribeGuestClusterAccessLogDashboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGuestClusterAccessLogDashboardsWithOptions(request, runtime);
        }

        public async Task<DescribeGuestClusterAccessLogDashboardsResponse> DescribeGuestClusterAccessLogDashboardsAsync(DescribeGuestClusterAccessLogDashboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGuestClusterAccessLogDashboardsWithOptionsAsync(request, runtime);
        }

        public DescribeGuestClusterNamespacesResponse DescribeGuestClusterNamespacesWithOptions(DescribeGuestClusterNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGuestClusterNamespacesResponse>(DoRPCRequest("DescribeGuestClusterNamespaces", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGuestClusterNamespacesResponse> DescribeGuestClusterNamespacesWithOptionsAsync(DescribeGuestClusterNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGuestClusterNamespacesResponse>(await DoRPCRequestAsync("DescribeGuestClusterNamespaces", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGuestClusterNamespacesResponse DescribeGuestClusterNamespaces(DescribeGuestClusterNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGuestClusterNamespacesWithOptions(request, runtime);
        }

        public async Task<DescribeGuestClusterNamespacesResponse> DescribeGuestClusterNamespacesAsync(DescribeGuestClusterNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGuestClusterNamespacesWithOptionsAsync(request, runtime);
        }

        public DescribeGuestClusterPodsResponse DescribeGuestClusterPodsWithOptions(DescribeGuestClusterPodsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGuestClusterPodsResponse>(DoRPCRequest("DescribeGuestClusterPods", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGuestClusterPodsResponse> DescribeGuestClusterPodsWithOptionsAsync(DescribeGuestClusterPodsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGuestClusterPodsResponse>(await DoRPCRequestAsync("DescribeGuestClusterPods", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGuestClusterPodsResponse DescribeGuestClusterPods(DescribeGuestClusterPodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGuestClusterPodsWithOptions(request, runtime);
        }

        public async Task<DescribeGuestClusterPodsResponse> DescribeGuestClusterPodsAsync(DescribeGuestClusterPodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGuestClusterPodsWithOptionsAsync(request, runtime);
        }

        public DescribeIngressGatewaysResponse DescribeIngressGatewaysWithOptions(DescribeIngressGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeIngressGatewaysResponse>(DoRPCRequest("DescribeIngressGateways", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeIngressGatewaysResponse> DescribeIngressGatewaysWithOptionsAsync(DescribeIngressGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeIngressGatewaysResponse>(await DoRPCRequestAsync("DescribeIngressGateways", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeIngressGatewaysResponse DescribeIngressGateways(DescribeIngressGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIngressGatewaysWithOptions(request, runtime);
        }

        public async Task<DescribeIngressGatewaysResponse> DescribeIngressGatewaysAsync(DescribeIngressGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIngressGatewaysWithOptionsAsync(request, runtime);
        }

        public DescribeNamespaceScopeSidecarConfigResponse DescribeNamespaceScopeSidecarConfigWithOptions(DescribeNamespaceScopeSidecarConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNamespaceScopeSidecarConfigResponse>(DoRPCRequest("DescribeNamespaceScopeSidecarConfig", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNamespaceScopeSidecarConfigResponse> DescribeNamespaceScopeSidecarConfigWithOptionsAsync(DescribeNamespaceScopeSidecarConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNamespaceScopeSidecarConfigResponse>(await DoRPCRequestAsync("DescribeNamespaceScopeSidecarConfig", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNamespaceScopeSidecarConfigResponse DescribeNamespaceScopeSidecarConfig(DescribeNamespaceScopeSidecarConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNamespaceScopeSidecarConfigWithOptions(request, runtime);
        }

        public async Task<DescribeNamespaceScopeSidecarConfigResponse> DescribeNamespaceScopeSidecarConfigAsync(DescribeNamespaceScopeSidecarConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNamespaceScopeSidecarConfigWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DescribeServiceMeshDetailResponse DescribeServiceMeshDetailWithOptions(DescribeServiceMeshDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshDetailResponse>(DoRPCRequest("DescribeServiceMeshDetail", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServiceMeshDetailResponse> DescribeServiceMeshDetailWithOptionsAsync(DescribeServiceMeshDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshDetailResponse>(await DoRPCRequestAsync("DescribeServiceMeshDetail", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServiceMeshDetailResponse DescribeServiceMeshDetail(DescribeServiceMeshDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshDetailWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshDetailResponse> DescribeServiceMeshDetailAsync(DescribeServiceMeshDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshDetailWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshGatewayPodStatusResponse DescribeServiceMeshGatewayPodStatusWithOptions(DescribeServiceMeshGatewayPodStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshGatewayPodStatusResponse>(DoRPCRequest("DescribeServiceMeshGatewayPodStatus", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServiceMeshGatewayPodStatusResponse> DescribeServiceMeshGatewayPodStatusWithOptionsAsync(DescribeServiceMeshGatewayPodStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshGatewayPodStatusResponse>(await DoRPCRequestAsync("DescribeServiceMeshGatewayPodStatus", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServiceMeshGatewayPodStatusResponse DescribeServiceMeshGatewayPodStatus(DescribeServiceMeshGatewayPodStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshGatewayPodStatusWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshGatewayPodStatusResponse> DescribeServiceMeshGatewayPodStatusAsync(DescribeServiceMeshGatewayPodStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshGatewayPodStatusWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshGatewaySLBStatusResponse DescribeServiceMeshGatewaySLBStatusWithOptions(DescribeServiceMeshGatewaySLBStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshGatewaySLBStatusResponse>(DoRPCRequest("DescribeServiceMeshGatewaySLBStatus", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServiceMeshGatewaySLBStatusResponse> DescribeServiceMeshGatewaySLBStatusWithOptionsAsync(DescribeServiceMeshGatewaySLBStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshGatewaySLBStatusResponse>(await DoRPCRequestAsync("DescribeServiceMeshGatewaySLBStatus", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServiceMeshGatewaySLBStatusResponse DescribeServiceMeshGatewaySLBStatus(DescribeServiceMeshGatewaySLBStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshGatewaySLBStatusWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshGatewaySLBStatusResponse> DescribeServiceMeshGatewaySLBStatusAsync(DescribeServiceMeshGatewaySLBStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshGatewaySLBStatusWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshKubeconfigResponse DescribeServiceMeshKubeconfigWithOptions(DescribeServiceMeshKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshKubeconfigResponse>(DoRPCRequest("DescribeServiceMeshKubeconfig", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServiceMeshKubeconfigResponse> DescribeServiceMeshKubeconfigWithOptionsAsync(DescribeServiceMeshKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshKubeconfigResponse>(await DoRPCRequestAsync("DescribeServiceMeshKubeconfig", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServiceMeshKubeconfigResponse DescribeServiceMeshKubeconfig(DescribeServiceMeshKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshKubeconfigWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshKubeconfigResponse> DescribeServiceMeshKubeconfigAsync(DescribeServiceMeshKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshKubeconfigWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshUpgradeStatusResponse DescribeServiceMeshUpgradeStatusWithOptions(DescribeServiceMeshUpgradeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshUpgradeStatusResponse>(DoRPCRequest("DescribeServiceMeshUpgradeStatus", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServiceMeshUpgradeStatusResponse> DescribeServiceMeshUpgradeStatusWithOptionsAsync(DescribeServiceMeshUpgradeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshUpgradeStatusResponse>(await DoRPCRequestAsync("DescribeServiceMeshUpgradeStatus", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServiceMeshUpgradeStatusResponse DescribeServiceMeshUpgradeStatus(DescribeServiceMeshUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshUpgradeStatusWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshUpgradeStatusResponse> DescribeServiceMeshUpgradeStatusAsync(DescribeServiceMeshUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshUpgradeStatusWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshVMsResponse DescribeServiceMeshVMsWithOptions(DescribeServiceMeshVMsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshVMsResponse>(DoRPCRequest("DescribeServiceMeshVMs", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServiceMeshVMsResponse> DescribeServiceMeshVMsWithOptionsAsync(DescribeServiceMeshVMsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServiceMeshVMsResponse>(await DoRPCRequestAsync("DescribeServiceMeshVMs", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServiceMeshVMsResponse DescribeServiceMeshVMs(DescribeServiceMeshVMsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshVMsWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshVMsResponse> DescribeServiceMeshVMsAsync(DescribeServiceMeshVMsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshVMsWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshesResponse DescribeServiceMeshesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeServiceMeshesResponse>(DoRPCRequest("DescribeServiceMeshes", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeServiceMeshesResponse> DescribeServiceMeshesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeServiceMeshesResponse>(await DoRPCRequestAsync("DescribeServiceMeshes", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeServiceMeshesResponse DescribeServiceMeshes()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshesWithOptions(runtime);
        }

        public async Task<DescribeServiceMeshesResponse> DescribeServiceMeshesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshesWithOptionsAsync(runtime);
        }

        public DescribeUpgradeVersionResponse DescribeUpgradeVersionWithOptions(DescribeUpgradeVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpgradeVersionResponse>(DoRPCRequest("DescribeUpgradeVersion", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUpgradeVersionResponse> DescribeUpgradeVersionWithOptionsAsync(DescribeUpgradeVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpgradeVersionResponse>(await DoRPCRequestAsync("DescribeUpgradeVersion", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUpgradeVersionResponse DescribeUpgradeVersion(DescribeUpgradeVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUpgradeVersionWithOptions(request, runtime);
        }

        public async Task<DescribeUpgradeVersionResponse> DescribeUpgradeVersionAsync(DescribeUpgradeVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUpgradeVersionWithOptionsAsync(request, runtime);
        }

        public DescribeVMsInServiceMeshResponse DescribeVMsInServiceMeshWithOptions(DescribeVMsInServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVMsInServiceMeshResponse>(DoRPCRequest("DescribeVMsInServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVMsInServiceMeshResponse> DescribeVMsInServiceMeshWithOptionsAsync(DescribeVMsInServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVMsInServiceMeshResponse>(await DoRPCRequestAsync("DescribeVMsInServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVMsInServiceMeshResponse DescribeVMsInServiceMesh(DescribeVMsInServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVMsInServiceMeshWithOptions(request, runtime);
        }

        public async Task<DescribeVMsInServiceMeshResponse> DescribeVMsInServiceMeshAsync(DescribeVMsInServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVMsInServiceMeshWithOptionsAsync(request, runtime);
        }

        public DescribeVSwitchesResponse DescribeVSwitchesWithOptions(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(DoRPCRequest("DescribeVSwitches", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesWithOptionsAsync(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(await DoRPCRequestAsync("DescribeVSwitches", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeVpcsResponse DescribeVpcsWithOptions(DescribeVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcsResponse>(DoRPCRequest("DescribeVpcs", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpcsResponse> DescribeVpcsWithOptionsAsync(DescribeVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcsResponse>(await DoRPCRequestAsync("DescribeVpcs", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcsWithOptions(request, runtime);
        }

        public async Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcsWithOptionsAsync(request, runtime);
        }

        public DisableControlPlaneLogAlertResponse DisableControlPlaneLogAlertWithOptions(DisableControlPlaneLogAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableControlPlaneLogAlertResponse>(DoRPCRequest("DisableControlPlaneLogAlert", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableControlPlaneLogAlertResponse> DisableControlPlaneLogAlertWithOptionsAsync(DisableControlPlaneLogAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableControlPlaneLogAlertResponse>(await DoRPCRequestAsync("DisableControlPlaneLogAlert", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableControlPlaneLogAlertResponse DisableControlPlaneLogAlert(DisableControlPlaneLogAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableControlPlaneLogAlertWithOptions(request, runtime);
        }

        public async Task<DisableControlPlaneLogAlertResponse> DisableControlPlaneLogAlertAsync(DisableControlPlaneLogAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableControlPlaneLogAlertWithOptionsAsync(request, runtime);
        }

        public EnableControlPlaneLogAlertResponse EnableControlPlaneLogAlertWithOptions(EnableControlPlaneLogAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableControlPlaneLogAlertResponse>(DoRPCRequest("EnableControlPlaneLogAlert", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableControlPlaneLogAlertResponse> EnableControlPlaneLogAlertWithOptionsAsync(EnableControlPlaneLogAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableControlPlaneLogAlertResponse>(await DoRPCRequestAsync("EnableControlPlaneLogAlert", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableControlPlaneLogAlertResponse EnableControlPlaneLogAlert(EnableControlPlaneLogAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableControlPlaneLogAlertWithOptions(request, runtime);
        }

        public async Task<EnableControlPlaneLogAlertResponse> EnableControlPlaneLogAlertAsync(EnableControlPlaneLogAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableControlPlaneLogAlertWithOptionsAsync(request, runtime);
        }

        public GetAutoInjectionLabelSyncStatusResponse GetAutoInjectionLabelSyncStatusWithOptions(GetAutoInjectionLabelSyncStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAutoInjectionLabelSyncStatusResponse>(DoRPCRequest("GetAutoInjectionLabelSyncStatus", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAutoInjectionLabelSyncStatusResponse> GetAutoInjectionLabelSyncStatusWithOptionsAsync(GetAutoInjectionLabelSyncStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAutoInjectionLabelSyncStatusResponse>(await DoRPCRequestAsync("GetAutoInjectionLabelSyncStatus", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAutoInjectionLabelSyncStatusResponse GetAutoInjectionLabelSyncStatus(GetAutoInjectionLabelSyncStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoInjectionLabelSyncStatusWithOptions(request, runtime);
        }

        public async Task<GetAutoInjectionLabelSyncStatusResponse> GetAutoInjectionLabelSyncStatusAsync(GetAutoInjectionLabelSyncStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoInjectionLabelSyncStatusWithOptionsAsync(request, runtime);
        }

        public GetBuiltinEnvoyFilterResponse GetBuiltinEnvoyFilterWithOptions(GetBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBuiltinEnvoyFilterResponse>(DoRPCRequest("GetBuiltinEnvoyFilter", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBuiltinEnvoyFilterResponse> GetBuiltinEnvoyFilterWithOptionsAsync(GetBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBuiltinEnvoyFilterResponse>(await DoRPCRequestAsync("GetBuiltinEnvoyFilter", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBuiltinEnvoyFilterResponse GetBuiltinEnvoyFilter(GetBuiltinEnvoyFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBuiltinEnvoyFilterWithOptions(request, runtime);
        }

        public async Task<GetBuiltinEnvoyFilterResponse> GetBuiltinEnvoyFilterAsync(GetBuiltinEnvoyFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBuiltinEnvoyFilterWithOptionsAsync(request, runtime);
        }

        public GetBuiltinEnvoyFilterCatalogResponse GetBuiltinEnvoyFilterCatalogWithOptions(GetBuiltinEnvoyFilterCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBuiltinEnvoyFilterCatalogResponse>(DoRPCRequest("GetBuiltinEnvoyFilterCatalog", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBuiltinEnvoyFilterCatalogResponse> GetBuiltinEnvoyFilterCatalogWithOptionsAsync(GetBuiltinEnvoyFilterCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBuiltinEnvoyFilterCatalogResponse>(await DoRPCRequestAsync("GetBuiltinEnvoyFilterCatalog", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBuiltinEnvoyFilterCatalogResponse GetBuiltinEnvoyFilterCatalog(GetBuiltinEnvoyFilterCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBuiltinEnvoyFilterCatalogWithOptions(request, runtime);
        }

        public async Task<GetBuiltinEnvoyFilterCatalogResponse> GetBuiltinEnvoyFilterCatalogAsync(GetBuiltinEnvoyFilterCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBuiltinEnvoyFilterCatalogWithOptionsAsync(request, runtime);
        }

        public GetCaCertResponse GetCaCertWithOptions(GetCaCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCaCertResponse>(DoRPCRequest("GetCaCert", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCaCertResponse> GetCaCertWithOptionsAsync(GetCaCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCaCertResponse>(await DoRPCRequestAsync("GetCaCert", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCaCertResponse GetCaCert(GetCaCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCaCertWithOptions(request, runtime);
        }

        public async Task<GetCaCertResponse> GetCaCertAsync(GetCaCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCaCertWithOptionsAsync(request, runtime);
        }

        public GetDiagnosisResponse GetDiagnosisWithOptions(GetDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDiagnosisResponse>(DoRPCRequest("GetDiagnosis", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDiagnosisResponse> GetDiagnosisWithOptionsAsync(GetDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDiagnosisResponse>(await DoRPCRequestAsync("GetDiagnosis", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDiagnosisResponse GetDiagnosis(GetDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiagnosisWithOptions(request, runtime);
        }

        public async Task<GetDiagnosisResponse> GetDiagnosisAsync(GetDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiagnosisWithOptionsAsync(request, runtime);
        }

        public GetEcsListResponse GetEcsListWithOptions(GetEcsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetEcsListResponse>(DoRPCRequest("GetEcsList", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetEcsListResponse> GetEcsListWithOptionsAsync(GetEcsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetEcsListResponse>(await DoRPCRequestAsync("GetEcsList", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetEcsListResponse GetEcsList(GetEcsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEcsListWithOptions(request, runtime);
        }

        public async Task<GetEcsListResponse> GetEcsListAsync(GetEcsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEcsListWithOptionsAsync(request, runtime);
        }

        public GetRegisteredServiceEndpointsResponse GetRegisteredServiceEndpointsWithOptions(GetRegisteredServiceEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRegisteredServiceEndpointsResponse>(DoRPCRequest("GetRegisteredServiceEndpoints", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRegisteredServiceEndpointsResponse> GetRegisteredServiceEndpointsWithOptionsAsync(GetRegisteredServiceEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRegisteredServiceEndpointsResponse>(await DoRPCRequestAsync("GetRegisteredServiceEndpoints", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRegisteredServiceEndpointsResponse GetRegisteredServiceEndpoints(GetRegisteredServiceEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegisteredServiceEndpointsWithOptions(request, runtime);
        }

        public async Task<GetRegisteredServiceEndpointsResponse> GetRegisteredServiceEndpointsAsync(GetRegisteredServiceEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegisteredServiceEndpointsWithOptionsAsync(request, runtime);
        }

        public GetRegisteredServiceNamespacesResponse GetRegisteredServiceNamespacesWithOptions(GetRegisteredServiceNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRegisteredServiceNamespacesResponse>(DoRPCRequest("GetRegisteredServiceNamespaces", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRegisteredServiceNamespacesResponse> GetRegisteredServiceNamespacesWithOptionsAsync(GetRegisteredServiceNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRegisteredServiceNamespacesResponse>(await DoRPCRequestAsync("GetRegisteredServiceNamespaces", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRegisteredServiceNamespacesResponse GetRegisteredServiceNamespaces(GetRegisteredServiceNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegisteredServiceNamespacesWithOptions(request, runtime);
        }

        public async Task<GetRegisteredServiceNamespacesResponse> GetRegisteredServiceNamespacesAsync(GetRegisteredServiceNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegisteredServiceNamespacesWithOptionsAsync(request, runtime);
        }

        public GetRegisteredServicesResponse GetRegisteredServicesWithOptions(GetRegisteredServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRegisteredServicesResponse>(DoRPCRequest("GetRegisteredServices", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRegisteredServicesResponse> GetRegisteredServicesWithOptionsAsync(GetRegisteredServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRegisteredServicesResponse>(await DoRPCRequestAsync("GetRegisteredServices", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRegisteredServicesResponse GetRegisteredServices(GetRegisteredServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegisteredServicesWithOptions(request, runtime);
        }

        public async Task<GetRegisteredServicesResponse> GetRegisteredServicesAsync(GetRegisteredServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegisteredServicesWithOptionsAsync(request, runtime);
        }

        public GetSaTokenResponse GetSaTokenWithOptions(GetSaTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSaTokenResponse>(DoRPCRequest("GetSaToken", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSaTokenResponse> GetSaTokenWithOptionsAsync(GetSaTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSaTokenResponse>(await DoRPCRequestAsync("GetSaToken", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSaTokenResponse GetSaToken(GetSaTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSaTokenWithOptions(request, runtime);
        }

        public async Task<GetSaTokenResponse> GetSaTokenAsync(GetSaTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSaTokenWithOptionsAsync(request, runtime);
        }

        public GetServiceMeshSlbResponse GetServiceMeshSlbWithOptions(GetServiceMeshSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceMeshSlbResponse>(DoRPCRequest("GetServiceMeshSlb", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetServiceMeshSlbResponse> GetServiceMeshSlbWithOptionsAsync(GetServiceMeshSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceMeshSlbResponse>(await DoRPCRequestAsync("GetServiceMeshSlb", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetServiceMeshSlbResponse GetServiceMeshSlb(GetServiceMeshSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceMeshSlbWithOptions(request, runtime);
        }

        public async Task<GetServiceMeshSlbResponse> GetServiceMeshSlbAsync(GetServiceMeshSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceMeshSlbWithOptionsAsync(request, runtime);
        }

        public GetServiceRegistrySourceResponse GetServiceRegistrySourceWithOptions(GetServiceRegistrySourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceRegistrySourceResponse>(DoRPCRequest("GetServiceRegistrySource", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetServiceRegistrySourceResponse> GetServiceRegistrySourceWithOptionsAsync(GetServiceRegistrySourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceRegistrySourceResponse>(await DoRPCRequestAsync("GetServiceRegistrySource", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetServiceRegistrySourceResponse GetServiceRegistrySource(GetServiceRegistrySourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceRegistrySourceWithOptions(request, runtime);
        }

        public async Task<GetServiceRegistrySourceResponse> GetServiceRegistrySourceAsync(GetServiceRegistrySourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceRegistrySourceWithOptionsAsync(request, runtime);
        }

        public GetVmAppMeshInfoResponse GetVmAppMeshInfoWithOptions(GetVmAppMeshInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVmAppMeshInfoResponse>(DoRPCRequest("GetVmAppMeshInfo", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetVmAppMeshInfoResponse> GetVmAppMeshInfoWithOptionsAsync(GetVmAppMeshInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVmAppMeshInfoResponse>(await DoRPCRequestAsync("GetVmAppMeshInfo", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetVmAppMeshInfoResponse GetVmAppMeshInfo(GetVmAppMeshInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVmAppMeshInfoWithOptions(request, runtime);
        }

        public async Task<GetVmAppMeshInfoResponse> GetVmAppMeshInfoAsync(GetVmAppMeshInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVmAppMeshInfoWithOptionsAsync(request, runtime);
        }

        public GetVmMetaResponse GetVmMetaWithOptions(GetVmMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVmMetaResponse>(DoRPCRequest("GetVmMeta", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetVmMetaResponse> GetVmMetaWithOptionsAsync(GetVmMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVmMetaResponse>(await DoRPCRequestAsync("GetVmMeta", "2020-01-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetVmMetaResponse GetVmMeta(GetVmMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVmMetaWithOptions(request, runtime);
        }

        public async Task<GetVmMetaResponse> GetVmMetaAsync(GetVmMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVmMetaWithOptionsAsync(request, runtime);
        }

        public InitializeASMRoleResponse InitializeASMRoleWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<InitializeASMRoleResponse>(DoRPCRequest("InitializeASMRole", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InitializeASMRoleResponse> InitializeASMRoleWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<InitializeASMRoleResponse>(await DoRPCRequestAsync("InitializeASMRole", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InitializeASMRoleResponse InitializeASMRole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitializeASMRoleWithOptions(runtime);
        }

        public async Task<InitializeASMRoleResponse> InitializeASMRoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitializeASMRoleWithOptionsAsync(runtime);
        }

        public ListBuiltinEnvoyFilterResponse ListBuiltinEnvoyFilterWithOptions(ListBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBuiltinEnvoyFilterResponse>(DoRPCRequest("ListBuiltinEnvoyFilter", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBuiltinEnvoyFilterResponse> ListBuiltinEnvoyFilterWithOptionsAsync(ListBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBuiltinEnvoyFilterResponse>(await DoRPCRequestAsync("ListBuiltinEnvoyFilter", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBuiltinEnvoyFilterResponse ListBuiltinEnvoyFilter(ListBuiltinEnvoyFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBuiltinEnvoyFilterWithOptions(request, runtime);
        }

        public async Task<ListBuiltinEnvoyFilterResponse> ListBuiltinEnvoyFilterAsync(ListBuiltinEnvoyFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBuiltinEnvoyFilterWithOptionsAsync(request, runtime);
        }

        public ModifyBuiltinEnvoyFilterResponse ModifyBuiltinEnvoyFilterWithOptions(ModifyBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBuiltinEnvoyFilterResponse>(DoRPCRequest("ModifyBuiltinEnvoyFilter", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBuiltinEnvoyFilterResponse> ModifyBuiltinEnvoyFilterWithOptionsAsync(ModifyBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBuiltinEnvoyFilterResponse>(await DoRPCRequestAsync("ModifyBuiltinEnvoyFilter", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBuiltinEnvoyFilterResponse ModifyBuiltinEnvoyFilter(ModifyBuiltinEnvoyFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBuiltinEnvoyFilterWithOptions(request, runtime);
        }

        public async Task<ModifyBuiltinEnvoyFilterResponse> ModifyBuiltinEnvoyFilterAsync(ModifyBuiltinEnvoyFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBuiltinEnvoyFilterWithOptionsAsync(request, runtime);
        }

        public ModifyServiceMeshNameResponse ModifyServiceMeshNameWithOptions(ModifyServiceMeshNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyServiceMeshNameResponse>(DoRPCRequest("ModifyServiceMeshName", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyServiceMeshNameResponse> ModifyServiceMeshNameWithOptionsAsync(ModifyServiceMeshNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyServiceMeshNameResponse>(await DoRPCRequestAsync("ModifyServiceMeshName", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyServiceMeshNameResponse ModifyServiceMeshName(ModifyServiceMeshNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyServiceMeshNameWithOptions(request, runtime);
        }

        public async Task<ModifyServiceMeshNameResponse> ModifyServiceMeshNameAsync(ModifyServiceMeshNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyServiceMeshNameWithOptionsAsync(request, runtime);
        }

        public ReActivateAuditResponse ReActivateAuditWithOptions(ReActivateAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReActivateAuditResponse>(DoRPCRequest("ReActivateAudit", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReActivateAuditResponse> ReActivateAuditWithOptionsAsync(ReActivateAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReActivateAuditResponse>(await DoRPCRequestAsync("ReActivateAudit", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReActivateAuditResponse ReActivateAudit(ReActivateAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReActivateAuditWithOptions(request, runtime);
        }

        public async Task<ReActivateAuditResponse> ReActivateAuditAsync(ReActivateAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReActivateAuditWithOptionsAsync(request, runtime);
        }

        public RemoveBuiltinEnvoyFilterResponse RemoveBuiltinEnvoyFilterWithOptions(RemoveBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveBuiltinEnvoyFilterResponse>(DoRPCRequest("RemoveBuiltinEnvoyFilter", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveBuiltinEnvoyFilterResponse> RemoveBuiltinEnvoyFilterWithOptionsAsync(RemoveBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveBuiltinEnvoyFilterResponse>(await DoRPCRequestAsync("RemoveBuiltinEnvoyFilter", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveBuiltinEnvoyFilterResponse RemoveBuiltinEnvoyFilter(RemoveBuiltinEnvoyFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveBuiltinEnvoyFilterWithOptions(request, runtime);
        }

        public async Task<RemoveBuiltinEnvoyFilterResponse> RemoveBuiltinEnvoyFilterAsync(RemoveBuiltinEnvoyFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveBuiltinEnvoyFilterWithOptionsAsync(request, runtime);
        }

        public RemoveClusterFromServiceMeshResponse RemoveClusterFromServiceMeshWithOptions(RemoveClusterFromServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveClusterFromServiceMeshResponse>(DoRPCRequest("RemoveClusterFromServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveClusterFromServiceMeshResponse> RemoveClusterFromServiceMeshWithOptionsAsync(RemoveClusterFromServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveClusterFromServiceMeshResponse>(await DoRPCRequestAsync("RemoveClusterFromServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveClusterFromServiceMeshResponse RemoveClusterFromServiceMesh(RemoveClusterFromServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveClusterFromServiceMeshWithOptions(request, runtime);
        }

        public async Task<RemoveClusterFromServiceMeshResponse> RemoveClusterFromServiceMeshAsync(RemoveClusterFromServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveClusterFromServiceMeshWithOptionsAsync(request, runtime);
        }

        public RemoveVMFromServiceMeshResponse RemoveVMFromServiceMeshWithOptions(RemoveVMFromServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVMFromServiceMeshResponse>(DoRPCRequest("RemoveVMFromServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveVMFromServiceMeshResponse> RemoveVMFromServiceMeshWithOptionsAsync(RemoveVMFromServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVMFromServiceMeshResponse>(await DoRPCRequestAsync("RemoveVMFromServiceMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveVMFromServiceMeshResponse RemoveVMFromServiceMesh(RemoveVMFromServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveVMFromServiceMeshWithOptions(request, runtime);
        }

        public async Task<RemoveVMFromServiceMeshResponse> RemoveVMFromServiceMeshAsync(RemoveVMFromServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveVMFromServiceMeshWithOptionsAsync(request, runtime);
        }

        public RunDiagnosisResponse RunDiagnosisWithOptions(RunDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunDiagnosisResponse>(DoRPCRequest("RunDiagnosis", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunDiagnosisResponse> RunDiagnosisWithOptionsAsync(RunDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunDiagnosisResponse>(await DoRPCRequestAsync("RunDiagnosis", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunDiagnosisResponse RunDiagnosis(RunDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunDiagnosisWithOptions(request, runtime);
        }

        public async Task<RunDiagnosisResponse> RunDiagnosisAsync(RunDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunDiagnosisWithOptionsAsync(request, runtime);
        }

        public SetServiceRegistrySourceResponse SetServiceRegistrySourceWithOptions(SetServiceRegistrySourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetServiceRegistrySourceShrinkRequest request = new SetServiceRegistrySourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetServiceRegistrySourceResponse>(DoRPCRequest("SetServiceRegistrySource", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetServiceRegistrySourceResponse> SetServiceRegistrySourceWithOptionsAsync(SetServiceRegistrySourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetServiceRegistrySourceShrinkRequest request = new SetServiceRegistrySourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetServiceRegistrySourceResponse>(await DoRPCRequestAsync("SetServiceRegistrySource", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetServiceRegistrySourceResponse SetServiceRegistrySource(SetServiceRegistrySourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetServiceRegistrySourceWithOptions(request, runtime);
        }

        public async Task<SetServiceRegistrySourceResponse> SetServiceRegistrySourceAsync(SetServiceRegistrySourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetServiceRegistrySourceWithOptionsAsync(request, runtime);
        }

        public UpdateControlPlaneLogAlertActionPolicyResponse UpdateControlPlaneLogAlertActionPolicyWithOptions(UpdateControlPlaneLogAlertActionPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateControlPlaneLogAlertActionPolicyResponse>(DoRPCRequest("UpdateControlPlaneLogAlertActionPolicy", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateControlPlaneLogAlertActionPolicyResponse> UpdateControlPlaneLogAlertActionPolicyWithOptionsAsync(UpdateControlPlaneLogAlertActionPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateControlPlaneLogAlertActionPolicyResponse>(await DoRPCRequestAsync("UpdateControlPlaneLogAlertActionPolicy", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateControlPlaneLogAlertActionPolicyResponse UpdateControlPlaneLogAlertActionPolicy(UpdateControlPlaneLogAlertActionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateControlPlaneLogAlertActionPolicyWithOptions(request, runtime);
        }

        public async Task<UpdateControlPlaneLogAlertActionPolicyResponse> UpdateControlPlaneLogAlertActionPolicyAsync(UpdateControlPlaneLogAlertActionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateControlPlaneLogAlertActionPolicyWithOptionsAsync(request, runtime);
        }

        public UpdateControlPlaneLogConfigResponse UpdateControlPlaneLogConfigWithOptions(UpdateControlPlaneLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateControlPlaneLogConfigResponse>(DoRPCRequest("UpdateControlPlaneLogConfig", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateControlPlaneLogConfigResponse> UpdateControlPlaneLogConfigWithOptionsAsync(UpdateControlPlaneLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateControlPlaneLogConfigResponse>(await DoRPCRequestAsync("UpdateControlPlaneLogConfig", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateControlPlaneLogConfigResponse UpdateControlPlaneLogConfig(UpdateControlPlaneLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateControlPlaneLogConfigWithOptions(request, runtime);
        }

        public async Task<UpdateControlPlaneLogConfigResponse> UpdateControlPlaneLogConfigAsync(UpdateControlPlaneLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateControlPlaneLogConfigWithOptionsAsync(request, runtime);
        }

        public UpdateExtensionProviderResponse UpdateExtensionProviderWithOptions(UpdateExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateExtensionProviderResponse>(DoRPCRequest("UpdateExtensionProvider", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateExtensionProviderResponse> UpdateExtensionProviderWithOptionsAsync(UpdateExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateExtensionProviderResponse>(await DoRPCRequestAsync("UpdateExtensionProvider", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateExtensionProviderResponse UpdateExtensionProvider(UpdateExtensionProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateExtensionProviderWithOptions(request, runtime);
        }

        public async Task<UpdateExtensionProviderResponse> UpdateExtensionProviderAsync(UpdateExtensionProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateExtensionProviderWithOptionsAsync(request, runtime);
        }

        public UpdateIstioInjectionConfigResponse UpdateIstioInjectionConfigWithOptions(UpdateIstioInjectionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIstioInjectionConfigResponse>(DoRPCRequest("UpdateIstioInjectionConfig", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateIstioInjectionConfigResponse> UpdateIstioInjectionConfigWithOptionsAsync(UpdateIstioInjectionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIstioInjectionConfigResponse>(await DoRPCRequestAsync("UpdateIstioInjectionConfig", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateIstioInjectionConfigResponse UpdateIstioInjectionConfig(UpdateIstioInjectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIstioInjectionConfigWithOptions(request, runtime);
        }

        public async Task<UpdateIstioInjectionConfigResponse> UpdateIstioInjectionConfigAsync(UpdateIstioInjectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIstioInjectionConfigWithOptionsAsync(request, runtime);
        }

        public UpdateMeshFeatureResponse UpdateMeshFeatureWithOptions(UpdateMeshFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMeshFeatureResponse>(DoRPCRequest("UpdateMeshFeature", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMeshFeatureResponse> UpdateMeshFeatureWithOptionsAsync(UpdateMeshFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMeshFeatureResponse>(await DoRPCRequestAsync("UpdateMeshFeature", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMeshFeatureResponse UpdateMeshFeature(UpdateMeshFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMeshFeatureWithOptions(request, runtime);
        }

        public async Task<UpdateMeshFeatureResponse> UpdateMeshFeatureAsync(UpdateMeshFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMeshFeatureWithOptionsAsync(request, runtime);
        }

        public UpdateNamespaceScopeSidecarConfigResponse UpdateNamespaceScopeSidecarConfigWithOptions(UpdateNamespaceScopeSidecarConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNamespaceScopeSidecarConfigResponse>(DoRPCRequest("UpdateNamespaceScopeSidecarConfig", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateNamespaceScopeSidecarConfigResponse> UpdateNamespaceScopeSidecarConfigWithOptionsAsync(UpdateNamespaceScopeSidecarConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNamespaceScopeSidecarConfigResponse>(await DoRPCRequestAsync("UpdateNamespaceScopeSidecarConfig", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateNamespaceScopeSidecarConfigResponse UpdateNamespaceScopeSidecarConfig(UpdateNamespaceScopeSidecarConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNamespaceScopeSidecarConfigWithOptions(request, runtime);
        }

        public async Task<UpdateNamespaceScopeSidecarConfigResponse> UpdateNamespaceScopeSidecarConfigAsync(UpdateNamespaceScopeSidecarConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNamespaceScopeSidecarConfigWithOptionsAsync(request, runtime);
        }

        public UpgradeMeshVersionResponse UpgradeMeshVersionWithOptions(UpgradeMeshVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeMeshVersionResponse>(DoRPCRequest("UpgradeMeshVersion", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeMeshVersionResponse> UpgradeMeshVersionWithOptionsAsync(UpgradeMeshVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeMeshVersionResponse>(await DoRPCRequestAsync("UpgradeMeshVersion", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeMeshVersionResponse UpgradeMeshVersion(UpgradeMeshVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeMeshVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeMeshVersionResponse> UpgradeMeshVersionAsync(UpgradeMeshVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeMeshVersionWithOptionsAsync(request, runtime);
        }

    }
}
