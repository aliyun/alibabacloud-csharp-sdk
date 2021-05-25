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

        public RemoveVmAppFromMeshResponse RemoveVmAppFromMeshWithOptions(RemoveVmAppFromMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVmAppFromMeshResponse>(DoRPCRequest("RemoveVmAppFromMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveVmAppFromMeshResponse> RemoveVmAppFromMeshWithOptionsAsync(RemoveVmAppFromMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVmAppFromMeshResponse>(await DoRPCRequestAsync("RemoveVmAppFromMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveVmAppFromMeshResponse RemoveVmAppFromMesh(RemoveVmAppFromMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveVmAppFromMeshWithOptions(request, runtime);
        }

        public async Task<RemoveVmAppFromMeshResponse> RemoveVmAppFromMeshAsync(RemoveVmAppFromMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveVmAppFromMeshWithOptionsAsync(request, runtime);
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

        public AddVmAppToMeshResponse AddVmAppToMeshWithOptions(AddVmAppToMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVmAppToMeshResponse>(DoRPCRequest("AddVmAppToMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddVmAppToMeshResponse> AddVmAppToMeshWithOptionsAsync(AddVmAppToMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVmAppToMeshResponse>(await DoRPCRequestAsync("AddVmAppToMesh", "2020-01-11", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddVmAppToMeshResponse AddVmAppToMesh(AddVmAppToMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVmAppToMeshWithOptions(request, runtime);
        }

        public async Task<AddVmAppToMeshResponse> AddVmAppToMeshAsync(AddVmAppToMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVmAppToMeshWithOptionsAsync(request, runtime);
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

    }
}
