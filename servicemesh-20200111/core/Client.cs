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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBuiltinEnvoyFilter",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBuiltinEnvoyFilterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddBuiltinEnvoyFilterResponse> AddBuiltinEnvoyFilterWithOptionsAsync(AddBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBuiltinEnvoyFilter",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBuiltinEnvoyFilterResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddClusterIntoServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddClusterIntoServiceMeshResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddClusterIntoServiceMeshResponse> AddClusterIntoServiceMeshWithOptionsAsync(AddClusterIntoServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddClusterIntoServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddClusterIntoServiceMeshResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsId))
            {
                query["EcsId"] = request.EcsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMeshTagToEcs",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMeshTagToEcsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddMeshTagToEcsResponse> AddMeshTagToEcsWithOptionsAsync(AddMeshTagToEcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsId))
            {
                query["EcsId"] = request.EcsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMeshTagToEcs",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMeshTagToEcsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsId))
            {
                query["EcsId"] = request.EcsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVMIntoServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVMIntoServiceMeshResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddVMIntoServiceMeshResponse> AddVMIntoServiceMeshWithOptionsAsync(AddVMIntoServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsId))
            {
                query["EcsId"] = request.EcsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVMIntoServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVMIntoServiceMeshResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateASMGatewayResponse CreateASMGatewayWithOptions(CreateASMGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateASMGateway",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateASMGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateASMGatewayResponse> CreateASMGatewayWithOptionsAsync(CreateASMGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateASMGateway",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateASMGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateASMGatewayResponse CreateASMGateway(CreateASMGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateASMGatewayWithOptions(request, runtime);
        }

        public async Task<CreateASMGatewayResponse> CreateASMGatewayAsync(CreateASMGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateASMGatewayWithOptionsAsync(request, runtime);
        }

        public CreateExtensionProviderResponse CreateExtensionProviderWithOptions(CreateExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
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
                Action = "CreateExtensionProvider",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExtensionProviderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateExtensionProviderResponse> CreateExtensionProviderWithOptionsAsync(CreateExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
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
                Action = "CreateExtensionProvider",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExtensionProviderResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogEnabled))
            {
                body["AccessLogEnabled"] = request.AccessLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogFile))
            {
                body["AccessLogFile"] = request.AccessLogFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogFormat))
            {
                body["AccessLogFormat"] = request.AccessLogFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogProject))
            {
                body["AccessLogProject"] = request.AccessLogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServiceEnabled))
            {
                body["AccessLogServiceEnabled"] = request.AccessLogServiceEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServiceHost))
            {
                body["AccessLogServiceHost"] = request.AccessLogServiceHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServicePort))
            {
                body["AccessLogServicePort"] = request.AccessLogServicePort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerPublicEip))
            {
                body["ApiServerPublicEip"] = request.ApiServerPublicEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditProject))
            {
                body["AuditProject"] = request.AuditProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CRAggregationEnabled))
            {
                body["CRAggregationEnabled"] = request.CRAggregationEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigSourceEnabled))
            {
                body["ConfigSourceEnabled"] = request.ConfigSourceEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigSourceNacosID))
            {
                body["ConfigSourceNacosID"] = request.ConfigSourceNacosID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlPlaneLogEnabled))
            {
                body["ControlPlaneLogEnabled"] = request.ControlPlaneLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlPlaneLogProject))
            {
                body["ControlPlaneLogProject"] = request.ControlPlaneLogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomizedPrometheus))
            {
                body["CustomizedPrometheus"] = request.CustomizedPrometheus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomizedZipkin))
            {
                body["CustomizedZipkin"] = request.CustomizedZipkin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSProxyingEnabled))
            {
                body["DNSProxyingEnabled"] = request.DNSProxyingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboFilterEnabled))
            {
                body["DubboFilterEnabled"] = request.DubboFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Edition))
            {
                body["Edition"] = request.Edition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAudit))
            {
                body["EnableAudit"] = request.EnableAudit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCRHistory))
            {
                body["EnableCRHistory"] = request.EnableCRHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSDSServer))
            {
                body["EnableSDSServer"] = request.EnableSDSServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeIPRanges))
            {
                body["ExcludeIPRanges"] = request.ExcludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeInboundPorts))
            {
                body["ExcludeInboundPorts"] = request.ExcludeInboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeOutboundPorts))
            {
                body["ExcludeOutboundPorts"] = request.ExcludeOutboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterGatewayClusterConfig))
            {
                body["FilterGatewayClusterConfig"] = request.FilterGatewayClusterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayAPIEnabled))
            {
                body["GatewayAPIEnabled"] = request.GatewayAPIEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeIPRanges))
            {
                body["IncludeIPRanges"] = request.IncludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KialiEnabled))
            {
                body["KialiEnabled"] = request.KialiEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalityLBConf))
            {
                body["LocalityLBConf"] = request.LocalityLBConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalityLoadBalancing))
            {
                body["LocalityLoadBalancing"] = request.LocalityLoadBalancing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MSEEnabled))
            {
                body["MSEEnabled"] = request.MSEEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MysqlFilterEnabled))
            {
                body["MysqlFilterEnabled"] = request.MysqlFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALimitCPU))
            {
                body["OPALimitCPU"] = request.OPALimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALimitMemory))
            {
                body["OPALimitMemory"] = request.OPALimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALogLevel))
            {
                body["OPALogLevel"] = request.OPALogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPARequestCPU))
            {
                body["OPARequestCPU"] = request.OPARequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPARequestMemory))
            {
                body["OPARequestMemory"] = request.OPARequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpaEnabled))
            {
                body["OpaEnabled"] = request.OpaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenAgentPolicy))
            {
                body["OpenAgentPolicy"] = request.OpenAgentPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusUrl))
            {
                body["PrometheusUrl"] = request.PrometheusUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyLimitCPU))
            {
                body["ProxyLimitCPU"] = request.ProxyLimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyLimitMemory))
            {
                body["ProxyLimitMemory"] = request.ProxyLimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRequestCPU))
            {
                body["ProxyRequestCPU"] = request.ProxyRequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRequestMemory))
            {
                body["ProxyRequestMemory"] = request.ProxyRequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedisFilterEnabled))
            {
                body["RedisFilterEnabled"] = request.RedisFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telemetry))
            {
                body["Telemetry"] = request.Telemetry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThriftFilterEnabled))
            {
                body["ThriftFilterEnabled"] = request.ThriftFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceSampling))
            {
                body["TraceSampling"] = request.TraceSampling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tracing))
            {
                body["Tracing"] = request.Tracing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                body["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebAssemblyFilterEnabled))
            {
                body["WebAssemblyFilterEnabled"] = request.WebAssemblyFilterEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceMeshResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateServiceMeshResponse> CreateServiceMeshWithOptionsAsync(CreateServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogEnabled))
            {
                body["AccessLogEnabled"] = request.AccessLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogFile))
            {
                body["AccessLogFile"] = request.AccessLogFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogFormat))
            {
                body["AccessLogFormat"] = request.AccessLogFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogProject))
            {
                body["AccessLogProject"] = request.AccessLogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServiceEnabled))
            {
                body["AccessLogServiceEnabled"] = request.AccessLogServiceEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServiceHost))
            {
                body["AccessLogServiceHost"] = request.AccessLogServiceHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServicePort))
            {
                body["AccessLogServicePort"] = request.AccessLogServicePort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerPublicEip))
            {
                body["ApiServerPublicEip"] = request.ApiServerPublicEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditProject))
            {
                body["AuditProject"] = request.AuditProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CRAggregationEnabled))
            {
                body["CRAggregationEnabled"] = request.CRAggregationEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigSourceEnabled))
            {
                body["ConfigSourceEnabled"] = request.ConfigSourceEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigSourceNacosID))
            {
                body["ConfigSourceNacosID"] = request.ConfigSourceNacosID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlPlaneLogEnabled))
            {
                body["ControlPlaneLogEnabled"] = request.ControlPlaneLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlPlaneLogProject))
            {
                body["ControlPlaneLogProject"] = request.ControlPlaneLogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomizedPrometheus))
            {
                body["CustomizedPrometheus"] = request.CustomizedPrometheus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomizedZipkin))
            {
                body["CustomizedZipkin"] = request.CustomizedZipkin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSProxyingEnabled))
            {
                body["DNSProxyingEnabled"] = request.DNSProxyingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboFilterEnabled))
            {
                body["DubboFilterEnabled"] = request.DubboFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Edition))
            {
                body["Edition"] = request.Edition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAudit))
            {
                body["EnableAudit"] = request.EnableAudit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCRHistory))
            {
                body["EnableCRHistory"] = request.EnableCRHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSDSServer))
            {
                body["EnableSDSServer"] = request.EnableSDSServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeIPRanges))
            {
                body["ExcludeIPRanges"] = request.ExcludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeInboundPorts))
            {
                body["ExcludeInboundPorts"] = request.ExcludeInboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeOutboundPorts))
            {
                body["ExcludeOutboundPorts"] = request.ExcludeOutboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterGatewayClusterConfig))
            {
                body["FilterGatewayClusterConfig"] = request.FilterGatewayClusterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayAPIEnabled))
            {
                body["GatewayAPIEnabled"] = request.GatewayAPIEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeIPRanges))
            {
                body["IncludeIPRanges"] = request.IncludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KialiEnabled))
            {
                body["KialiEnabled"] = request.KialiEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalityLBConf))
            {
                body["LocalityLBConf"] = request.LocalityLBConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalityLoadBalancing))
            {
                body["LocalityLoadBalancing"] = request.LocalityLoadBalancing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MSEEnabled))
            {
                body["MSEEnabled"] = request.MSEEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MysqlFilterEnabled))
            {
                body["MysqlFilterEnabled"] = request.MysqlFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALimitCPU))
            {
                body["OPALimitCPU"] = request.OPALimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALimitMemory))
            {
                body["OPALimitMemory"] = request.OPALimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALogLevel))
            {
                body["OPALogLevel"] = request.OPALogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPARequestCPU))
            {
                body["OPARequestCPU"] = request.OPARequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPARequestMemory))
            {
                body["OPARequestMemory"] = request.OPARequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpaEnabled))
            {
                body["OpaEnabled"] = request.OpaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenAgentPolicy))
            {
                body["OpenAgentPolicy"] = request.OpenAgentPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusUrl))
            {
                body["PrometheusUrl"] = request.PrometheusUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyLimitCPU))
            {
                body["ProxyLimitCPU"] = request.ProxyLimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyLimitMemory))
            {
                body["ProxyLimitMemory"] = request.ProxyLimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRequestCPU))
            {
                body["ProxyRequestCPU"] = request.ProxyRequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRequestMemory))
            {
                body["ProxyRequestMemory"] = request.ProxyRequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedisFilterEnabled))
            {
                body["RedisFilterEnabled"] = request.RedisFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telemetry))
            {
                body["Telemetry"] = request.Telemetry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThriftFilterEnabled))
            {
                body["ThriftFilterEnabled"] = request.ThriftFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceSampling))
            {
                body["TraceSampling"] = request.TraceSampling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tracing))
            {
                body["Tracing"] = request.Tracing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                body["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebAssemblyFilterEnabled))
            {
                body["WebAssemblyFilterEnabled"] = request.WebAssemblyFilterEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceMeshResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
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
                Action = "DeleteExtensionProvider",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExtensionProviderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteExtensionProviderResponse> DeleteExtensionProviderWithOptionsAsync(DeleteExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
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
                Action = "DeleteExtensionProvider",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExtensionProviderResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResources))
            {
                body["RetainResources"] = request.RetainResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceMeshResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceMeshResponse> DeleteServiceMeshWithOptionsAsync(DeleteServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResources))
            {
                body["RetainResources"] = request.RetainResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceMeshResponse>(await CallApiAsync(params_, req, runtime));
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

        public DescribeASMGatewayImportedServicesResponse DescribeASMGatewayImportedServicesWithOptions(DescribeASMGatewayImportedServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASMGatewayName))
            {
                body["ASMGatewayName"] = request.ASMGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNamespace))
            {
                body["ServiceNamespace"] = request.ServiceNamespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeASMGatewayImportedServices",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeASMGatewayImportedServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeASMGatewayImportedServicesResponse> DescribeASMGatewayImportedServicesWithOptionsAsync(DescribeASMGatewayImportedServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASMGatewayName))
            {
                body["ASMGatewayName"] = request.ASMGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNamespace))
            {
                body["ServiceNamespace"] = request.ServiceNamespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeASMGatewayImportedServices",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeASMGatewayImportedServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeASMGatewayImportedServicesResponse DescribeASMGatewayImportedServices(DescribeASMGatewayImportedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeASMGatewayImportedServicesWithOptions(request, runtime);
        }

        public async Task<DescribeASMGatewayImportedServicesResponse> DescribeASMGatewayImportedServicesAsync(DescribeASMGatewayImportedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeASMGatewayImportedServicesWithOptionsAsync(request, runtime);
        }

        public DescribeAlertActionPoliciesResponse DescribeAlertActionPoliciesWithOptions(DescribeAlertActionPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertActionPolicies",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertActionPoliciesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertActionPoliciesResponse> DescribeAlertActionPoliciesWithOptionsAsync(DescribeAlertActionPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertActionPolicies",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertActionPoliciesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableNacosInstances",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableNacosInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAvailableNacosInstancesResponse> DescribeAvailableNacosInstancesWithOptionsAsync(DescribeAvailableNacosInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableNacosInstances",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableNacosInstancesResponse>(await CallApiAsync(params_, req, runtime));
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

        public DescribeCCMVersionResponse DescribeCCMVersionWithOptions(DescribeCCMVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCCMVersion",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCCMVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCCMVersionResponse> DescribeCCMVersionWithOptionsAsync(DescribeCCMVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCCMVersion",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCCMVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCCMVersionResponse DescribeCCMVersion(DescribeCCMVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCCMVersionWithOptions(request, runtime);
        }

        public async Task<DescribeCCMVersionResponse> DescribeCCMVersionAsync(DescribeCCMVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCCMVersionWithOptionsAsync(request, runtime);
        }

        public DescribeCensResponse DescribeCensWithOptions(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCens",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCensResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCensResponse> DescribeCensWithOptionsAsync(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCens",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCensResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                query["K8sClusterId"] = request.K8sClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterGrafana",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterGrafanaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterGrafanaResponse> DescribeClusterGrafanaWithOptionsAsync(DescribeClusterGrafanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                query["K8sClusterId"] = request.K8sClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterGrafana",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterGrafanaResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                query["K8sClusterId"] = request.K8sClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterRegionId))
            {
                query["K8sClusterRegionId"] = request.K8sClusterRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterPrometheus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterPrometheusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterPrometheusResponse> DescribeClusterPrometheusWithOptionsAsync(DescribeClusterPrometheusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                query["K8sClusterId"] = request.K8sClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterRegionId))
            {
                query["K8sClusterRegionId"] = request.K8sClusterRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterPrometheus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterPrometheusResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClustersInServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClustersInServiceMeshResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClustersInServiceMeshResponse> DescribeClustersInServiceMeshWithOptionsAsync(DescribeClustersInServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClustersInServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClustersInServiceMeshResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeControlPlaneLogAlertRules",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeControlPlaneLogAlertRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeControlPlaneLogAlertRulesResponse> DescribeControlPlaneLogAlertRulesWithOptionsAsync(DescribeControlPlaneLogAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeControlPlaneLogAlertRules",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeControlPlaneLogAlertRulesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                body["Kind"] = request.Kind;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrTemplates",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrTemplatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCrTemplatesResponse> DescribeCrTemplatesWithOptionsAsync(DescribeCrTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                body["Kind"] = request.Kind;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrTemplates",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrTemplatesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
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
                Action = "DescribeExtensionProvider",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExtensionProviderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeExtensionProviderResponse> DescribeExtensionProviderWithOptionsAsync(DescribeExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
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
                Action = "DescribeExtensionProvider",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExtensionProviderResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                body["K8sClusterId"] = request.K8sClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGuestClusterAccessLogDashboards",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGuestClusterAccessLogDashboardsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGuestClusterAccessLogDashboardsResponse> DescribeGuestClusterAccessLogDashboardsWithOptionsAsync(DescribeGuestClusterAccessLogDashboardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                body["K8sClusterId"] = request.K8sClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGuestClusterAccessLogDashboards",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGuestClusterAccessLogDashboardsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestClusterID))
            {
                body["GuestClusterID"] = request.GuestClusterID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGuestClusterNamespaces",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGuestClusterNamespacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGuestClusterNamespacesResponse> DescribeGuestClusterNamespacesWithOptionsAsync(DescribeGuestClusterNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestClusterID))
            {
                body["GuestClusterID"] = request.GuestClusterID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGuestClusterNamespaces",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGuestClusterNamespacesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestClusterID))
            {
                body["GuestClusterID"] = request.GuestClusterID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGuestClusterPods",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGuestClusterPodsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGuestClusterPodsResponse> DescribeGuestClusterPodsWithOptionsAsync(DescribeGuestClusterPodsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestClusterID))
            {
                body["GuestClusterID"] = request.GuestClusterID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGuestClusterPods",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGuestClusterPodsResponse>(await CallApiAsync(params_, req, runtime));
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

        public DescribeImportedServicesDetailResponse DescribeImportedServicesDetailWithOptions(DescribeImportedServicesDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASMGatewayName))
            {
                body["ASMGatewayName"] = request.ASMGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNamespace))
            {
                body["ServiceNamespace"] = request.ServiceNamespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImportedServicesDetail",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImportedServicesDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeImportedServicesDetailResponse> DescribeImportedServicesDetailWithOptionsAsync(DescribeImportedServicesDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASMGatewayName))
            {
                body["ASMGatewayName"] = request.ASMGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNamespace))
            {
                body["ServiceNamespace"] = request.ServiceNamespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImportedServicesDetail",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImportedServicesDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeImportedServicesDetailResponse DescribeImportedServicesDetail(DescribeImportedServicesDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImportedServicesDetailWithOptions(request, runtime);
        }

        public async Task<DescribeImportedServicesDetailResponse> DescribeImportedServicesDetailAsync(DescribeImportedServicesDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImportedServicesDetailWithOptionsAsync(request, runtime);
        }

        public DescribeIngressGatewaysResponse DescribeIngressGatewaysWithOptions(DescribeIngressGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIngressGateways",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIngressGatewaysResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeIngressGatewaysResponse> DescribeIngressGatewaysWithOptionsAsync(DescribeIngressGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIngressGateways",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIngressGatewaysResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaceScopeSidecarConfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceScopeSidecarConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeNamespaceScopeSidecarConfigResponse> DescribeNamespaceScopeSidecarConfigWithOptionsAsync(DescribeNamespaceScopeSidecarConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaceScopeSidecarConfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceScopeSidecarConfigResponse>(await CallApiAsync(params_, req, runtime));
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

        public DescribeNodesInstanceTypeResponse DescribeNodesInstanceTypeWithOptions(DescribeNodesInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodesInstanceType",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodesInstanceTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeNodesInstanceTypeResponse> DescribeNodesInstanceTypeWithOptionsAsync(DescribeNodesInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodesInstanceType",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodesInstanceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeNodesInstanceTypeResponse DescribeNodesInstanceType(DescribeNodesInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodesInstanceTypeWithOptions(request, runtime);
        }

        public async Task<DescribeNodesInstanceTypeResponse> DescribeNodesInstanceTypeAsync(DescribeNodesInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodesInstanceTypeWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshDetail",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshDetailResponse> DescribeServiceMeshDetailWithOptionsAsync(DescribeServiceMeshDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshDetail",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshDetailResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayFullName))
            {
                body["GatewayFullName"] = request.GatewayFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestClusterIds))
            {
                body["GuestClusterIds"] = request.GuestClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshGatewayPodStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshGatewayPodStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshGatewayPodStatusResponse> DescribeServiceMeshGatewayPodStatusWithOptionsAsync(DescribeServiceMeshGatewayPodStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayFullName))
            {
                body["GatewayFullName"] = request.GatewayFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestClusterIds))
            {
                body["GuestClusterIds"] = request.GuestClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshGatewayPodStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshGatewayPodStatusResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayAddresses))
            {
                body["GatewayAddresses"] = request.GatewayAddresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayFullName))
            {
                body["GatewayFullName"] = request.GatewayFullName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshGatewaySLBStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshGatewaySLBStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshGatewaySLBStatusResponse> DescribeServiceMeshGatewaySLBStatusWithOptionsAsync(DescribeServiceMeshGatewaySLBStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayAddresses))
            {
                body["GatewayAddresses"] = request.GatewayAddresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayFullName))
            {
                body["GatewayFullName"] = request.GatewayFullName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshGatewaySLBStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshGatewaySLBStatusResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshKubeconfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshKubeconfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshKubeconfigResponse> DescribeServiceMeshKubeconfigWithOptionsAsync(DescribeServiceMeshKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshKubeconfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshKubeconfigResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllIstioGatewayFullNames))
            {
                body["AllIstioGatewayFullNames"] = request.AllIstioGatewayFullNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestClusterIds))
            {
                body["GuestClusterIds"] = request.GuestClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshUpgradeStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshUpgradeStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshUpgradeStatusResponse> DescribeServiceMeshUpgradeStatusWithOptionsAsync(DescribeServiceMeshUpgradeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllIstioGatewayFullNames))
            {
                body["AllIstioGatewayFullNames"] = request.AllIstioGatewayFullNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestClusterIds))
            {
                body["GuestClusterIds"] = request.GuestClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshUpgradeStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshUpgradeStatusResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshVMs",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshVMsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshVMsResponse> DescribeServiceMeshVMsWithOptionsAsync(DescribeServiceMeshVMsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshVMs",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshVMsResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshes",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshesResponse> DescribeServiceMeshesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshes",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUpgradeVersion",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUpgradeVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUpgradeVersionResponse> DescribeUpgradeVersionWithOptionsAsync(DescribeUpgradeVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUpgradeVersion",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUpgradeVersionResponse>(await CallApiAsync(params_, req, runtime));
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

        public DescribeUsersWithPermissionsResponse DescribeUsersWithPermissionsWithOptions(DescribeUsersWithPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsersWithPermissions",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsersWithPermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUsersWithPermissionsResponse> DescribeUsersWithPermissionsWithOptionsAsync(DescribeUsersWithPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsersWithPermissions",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsersWithPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUsersWithPermissionsResponse DescribeUsersWithPermissions(DescribeUsersWithPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsersWithPermissionsWithOptions(request, runtime);
        }

        public async Task<DescribeUsersWithPermissionsResponse> DescribeUsersWithPermissionsAsync(DescribeUsersWithPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsersWithPermissionsWithOptionsAsync(request, runtime);
        }

        public DescribeVMsInServiceMeshResponse DescribeVMsInServiceMeshWithOptions(DescribeVMsInServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVMsInServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVMsInServiceMeshResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVMsInServiceMeshResponse> DescribeVMsInServiceMeshWithOptionsAsync(DescribeVMsInServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVMsInServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVMsInServiceMeshResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVSwitches",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesWithOptionsAsync(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVSwitches",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(await CallApiAsync(params_, req, runtime));
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

        public DescribeVersionsResponse DescribeVersionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVersions",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVersionsResponse> DescribeVersionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVersions",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVersionsResponse DescribeVersions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVersionsWithOptions(runtime);
        }

        public async Task<DescribeVersionsResponse> DescribeVersionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVersionsWithOptionsAsync(runtime);
        }

        public DescribeVpcsResponse DescribeVpcsWithOptions(DescribeVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcs",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVpcsResponse> DescribeVpcsWithOptionsAsync(DescribeVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcs",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableControlPlaneLogAlert",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableControlPlaneLogAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableControlPlaneLogAlertResponse> DisableControlPlaneLogAlertWithOptionsAsync(DisableControlPlaneLogAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableControlPlaneLogAlert",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableControlPlaneLogAlertResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionPolicyId))
            {
                body["ActionPolicyId"] = request.ActionPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableControlPlaneLogAlert",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableControlPlaneLogAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableControlPlaneLogAlertResponse> EnableControlPlaneLogAlertWithOptionsAsync(EnableControlPlaneLogAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionPolicyId))
            {
                body["ActionPolicyId"] = request.ActionPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableControlPlaneLogAlert",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableControlPlaneLogAlertResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoInjectionLabelSyncStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoInjectionLabelSyncStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAutoInjectionLabelSyncStatusResponse> GetAutoInjectionLabelSyncStatusWithOptionsAsync(GetAutoInjectionLabelSyncStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoInjectionLabelSyncStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoInjectionLabelSyncStatusResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBuiltinEnvoyFilter",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBuiltinEnvoyFilterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBuiltinEnvoyFilterResponse> GetBuiltinEnvoyFilterWithOptionsAsync(GetBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBuiltinEnvoyFilter",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBuiltinEnvoyFilterResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBuiltinEnvoyFilterCatalog",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBuiltinEnvoyFilterCatalogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBuiltinEnvoyFilterCatalogResponse> GetBuiltinEnvoyFilterCatalogWithOptionsAsync(GetBuiltinEnvoyFilterCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBuiltinEnvoyFilterCatalog",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBuiltinEnvoyFilterCatalogResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCaCert",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCaCertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCaCertResponse> GetCaCertWithOptionsAsync(GetCaCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCaCert",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCaCertResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnosis",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDiagnosisResponse> GetDiagnosisWithOptionsAsync(GetDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnosis",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEcsList",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEcsListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEcsListResponse> GetEcsListWithOptionsAsync(GetEcsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEcsList",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEcsListResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                body["ClusterIds"] = request.ClusterIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                body["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegisteredServiceEndpoints",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegisteredServiceEndpointsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRegisteredServiceEndpointsResponse> GetRegisteredServiceEndpointsWithOptionsAsync(GetRegisteredServiceEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                body["ClusterIds"] = request.ClusterIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                body["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegisteredServiceEndpoints",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegisteredServiceEndpointsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegisteredServiceNamespaces",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegisteredServiceNamespacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRegisteredServiceNamespacesResponse> GetRegisteredServiceNamespacesWithOptionsAsync(GetRegisteredServiceNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegisteredServiceNamespaces",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegisteredServiceNamespacesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestClusters))
            {
                body["GuestClusters"] = request.GuestClusters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestLimits))
            {
                body["GuestLimits"] = request.GuestLimits;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestMarkers))
            {
                body["GuestMarkers"] = request.GuestMarkers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeshLimit))
            {
                body["MeshLimit"] = request.MeshLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeshMarker))
            {
                body["MeshMarker"] = request.MeshMarker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegisteredServices",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegisteredServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRegisteredServicesResponse> GetRegisteredServicesWithOptionsAsync(GetRegisteredServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestClusters))
            {
                body["GuestClusters"] = request.GuestClusters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestLimits))
            {
                body["GuestLimits"] = request.GuestLimits;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestMarkers))
            {
                body["GuestMarkers"] = request.GuestMarkers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeshLimit))
            {
                body["MeshLimit"] = request.MeshLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeshMarker))
            {
                body["MeshMarker"] = request.MeshMarker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegisteredServices",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegisteredServicesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRefresh))
            {
                body["NeedRefresh"] = request.NeedRefresh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceAccountName))
            {
                body["ServiceAccountName"] = request.ServiceAccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSaToken",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSaTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSaTokenResponse> GetSaTokenWithOptionsAsync(GetSaTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRefresh))
            {
                body["NeedRefresh"] = request.NeedRefresh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceAccountName))
            {
                body["ServiceAccountName"] = request.ServiceAccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSaToken",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSaTokenResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceMeshSlb",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceMeshSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetServiceMeshSlbResponse> GetServiceMeshSlbWithOptionsAsync(GetServiceMeshSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceMeshSlb",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceMeshSlbResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceRegistrySource",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceRegistrySourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetServiceRegistrySourceResponse> GetServiceRegistrySourceWithOptionsAsync(GetServiceRegistrySourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceRegistrySource",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceRegistrySourceResponse>(await CallApiAsync(params_, req, runtime));
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVmAppMeshInfo",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVmAppMeshInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetVmAppMeshInfoResponse> GetVmAppMeshInfoWithOptionsAsync(GetVmAppMeshInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVmAppMeshInfo",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVmAppMeshInfoResponse>(await CallApiAsync(params_, req, runtime));
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVmMeta",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVmMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetVmMetaResponse> GetVmMetaWithOptionsAsync(GetVmMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVmMeta",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVmMetaResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitializeASMRole",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitializeASMRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitializeASMRoleResponse> InitializeASMRoleWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitializeASMRole",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitializeASMRoleResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBuiltinEnvoyFilter",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBuiltinEnvoyFilterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBuiltinEnvoyFilterResponse> ListBuiltinEnvoyFilterWithOptionsAsync(ListBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBuiltinEnvoyFilter",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBuiltinEnvoyFilterResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBuiltinEnvoyFilter",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBuiltinEnvoyFilterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyBuiltinEnvoyFilterResponse> ModifyBuiltinEnvoyFilterWithOptionsAsync(ModifyBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBuiltinEnvoyFilter",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBuiltinEnvoyFilterResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyServiceMeshName",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyServiceMeshNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyServiceMeshNameResponse> ModifyServiceMeshNameWithOptionsAsync(ModifyServiceMeshNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyServiceMeshName",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyServiceMeshNameResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAudit))
            {
                body["EnableAudit"] = request.EnableAudit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReActivateAudit",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReActivateAuditResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReActivateAuditResponse> ReActivateAuditWithOptionsAsync(ReActivateAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAudit))
            {
                body["EnableAudit"] = request.EnableAudit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReActivateAudit",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReActivateAuditResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveBuiltinEnvoyFilter",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveBuiltinEnvoyFilterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveBuiltinEnvoyFilterResponse> RemoveBuiltinEnvoyFilterWithOptionsAsync(RemoveBuiltinEnvoyFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioVersion))
            {
                body["IstioVersion"] = request.IstioVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveBuiltinEnvoyFilter",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveBuiltinEnvoyFilterResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveClusterFromServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveClusterFromServiceMeshResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveClusterFromServiceMeshResponse> RemoveClusterFromServiceMeshWithOptionsAsync(RemoveClusterFromServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveClusterFromServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveClusterFromServiceMeshResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsId))
            {
                query["EcsId"] = request.EcsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveVMFromServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveVMFromServiceMeshResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveVMFromServiceMeshResponse> RemoveVMFromServiceMeshWithOptionsAsync(RemoveVMFromServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsId))
            {
                query["EcsId"] = request.EcsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveVMFromServiceMesh",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveVMFromServiceMeshResponse>(await CallApiAsync(params_, req, runtime));
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

        public RevokeKubeconfigResponse RevokeKubeconfigWithOptions(RevokeKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                body["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeKubeconfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeKubeconfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevokeKubeconfigResponse> RevokeKubeconfigWithOptionsAsync(RevokeKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                body["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeKubeconfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeKubeconfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevokeKubeconfigResponse RevokeKubeconfig(RevokeKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeKubeconfigWithOptions(request, runtime);
        }

        public async Task<RevokeKubeconfigResponse> RevokeKubeconfigAsync(RevokeKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeKubeconfigWithOptionsAsync(request, runtime);
        }

        public RunDiagnosisResponse RunDiagnosisWithOptions(RunDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDiagnosis",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RunDiagnosisResponse> RunDiagnosisWithOptionsAsync(RunDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDiagnosis",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                body["Config"] = request.ConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetServiceRegistrySource",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetServiceRegistrySourceResponse>(CallApi(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                body["Config"] = request.ConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetServiceRegistrySource",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetServiceRegistrySourceResponse>(await CallApiAsync(params_, req, runtime));
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

        public UpdateASMGatewayResponse UpdateASMGatewayWithOptions(UpdateASMGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateASMGateway",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateASMGatewayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateASMGatewayResponse> UpdateASMGatewayWithOptionsAsync(UpdateASMGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateASMGateway",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateASMGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateASMGatewayResponse UpdateASMGateway(UpdateASMGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateASMGatewayWithOptions(request, runtime);
        }

        public async Task<UpdateASMGatewayResponse> UpdateASMGatewayAsync(UpdateASMGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateASMGatewayWithOptionsAsync(request, runtime);
        }

        public UpdateASMGatewayImportedServicesResponse UpdateASMGatewayImportedServicesWithOptions(UpdateASMGatewayImportedServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASMGatewayName))
            {
                body["ASMGatewayName"] = request.ASMGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNames))
            {
                body["ServiceNames"] = request.ServiceNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNamespace))
            {
                body["ServiceNamespace"] = request.ServiceNamespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateASMGatewayImportedServices",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateASMGatewayImportedServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateASMGatewayImportedServicesResponse> UpdateASMGatewayImportedServicesWithOptionsAsync(UpdateASMGatewayImportedServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASMGatewayName))
            {
                body["ASMGatewayName"] = request.ASMGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNames))
            {
                body["ServiceNames"] = request.ServiceNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNamespace))
            {
                body["ServiceNamespace"] = request.ServiceNamespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateASMGatewayImportedServices",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateASMGatewayImportedServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateASMGatewayImportedServicesResponse UpdateASMGatewayImportedServices(UpdateASMGatewayImportedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateASMGatewayImportedServicesWithOptions(request, runtime);
        }

        public async Task<UpdateASMGatewayImportedServicesResponse> UpdateASMGatewayImportedServicesAsync(UpdateASMGatewayImportedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateASMGatewayImportedServicesWithOptionsAsync(request, runtime);
        }

        public UpdateControlPlaneLogAlertActionPolicyResponse UpdateControlPlaneLogAlertActionPolicyWithOptions(UpdateControlPlaneLogAlertActionPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionPolicyId))
            {
                body["ActionPolicyId"] = request.ActionPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateControlPlaneLogAlertActionPolicy",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateControlPlaneLogAlertActionPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateControlPlaneLogAlertActionPolicyResponse> UpdateControlPlaneLogAlertActionPolicyWithOptionsAsync(UpdateControlPlaneLogAlertActionPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionPolicyId))
            {
                body["ActionPolicyId"] = request.ActionPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateControlPlaneLogAlertActionPolicy",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateControlPlaneLogAlertActionPolicyResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                body["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateControlPlaneLogConfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateControlPlaneLogConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateControlPlaneLogConfigResponse> UpdateControlPlaneLogConfigWithOptionsAsync(UpdateControlPlaneLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                body["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateControlPlaneLogConfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateControlPlaneLogConfigResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
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
                Action = "UpdateExtensionProvider",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExtensionProviderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateExtensionProviderResponse> UpdateExtensionProviderWithOptionsAsync(UpdateExtensionProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
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
                Action = "UpdateExtensionProvider",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExtensionProviderResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIstioInjection))
            {
                body["EnableIstioInjection"] = request.EnableIstioInjection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSidecarSetInjection))
            {
                body["EnableSidecarSetInjection"] = request.EnableSidecarSetInjection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIstioInjectionConfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIstioInjectionConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateIstioInjectionConfigResponse> UpdateIstioInjectionConfigWithOptionsAsync(UpdateIstioInjectionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIstioInjection))
            {
                body["EnableIstioInjection"] = request.EnableIstioInjection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSidecarSetInjection))
            {
                body["EnableSidecarSetInjection"] = request.EnableSidecarSetInjection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIstioInjectionConfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIstioInjectionConfigResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogEnabled))
            {
                body["AccessLogEnabled"] = request.AccessLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogFile))
            {
                body["AccessLogFile"] = request.AccessLogFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogFormat))
            {
                body["AccessLogFormat"] = request.AccessLogFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogProject))
            {
                body["AccessLogProject"] = request.AccessLogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServiceEnabled))
            {
                body["AccessLogServiceEnabled"] = request.AccessLogServiceEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServiceHost))
            {
                body["AccessLogServiceHost"] = request.AccessLogServiceHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServicePort))
            {
                body["AccessLogServicePort"] = request.AccessLogServicePort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditProject))
            {
                body["AuditProject"] = request.AuditProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInjectionPolicyEnabled))
            {
                body["AutoInjectionPolicyEnabled"] = request.AutoInjectionPolicyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CRAggregationEnabled))
            {
                body["CRAggregationEnabled"] = request.CRAggregationEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CniEnabled))
            {
                body["CniEnabled"] = request.CniEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CniExcludeNamespaces))
            {
                body["CniExcludeNamespaces"] = request.CniExcludeNamespaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigSourceEnabled))
            {
                body["ConfigSourceEnabled"] = request.ConfigSourceEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigSourceNacosID))
            {
                body["ConfigSourceNacosID"] = request.ConfigSourceNacosID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomizedPrometheus))
            {
                body["CustomizedPrometheus"] = request.CustomizedPrometheus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomizedZipkin))
            {
                body["CustomizedZipkin"] = request.CustomizedZipkin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSProxyingEnabled))
            {
                body["DNSProxyingEnabled"] = request.DNSProxyingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoverySelectors))
            {
                body["DiscoverySelectors"] = request.DiscoverySelectors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboFilterEnabled))
            {
                body["DubboFilterEnabled"] = request.DubboFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAudit))
            {
                body["EnableAudit"] = request.EnableAudit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCRHistory))
            {
                body["EnableCRHistory"] = request.EnableCRHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNamespacesByDefault))
            {
                body["EnableNamespacesByDefault"] = request.EnableNamespacesByDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSDSServer))
            {
                body["EnableSDSServer"] = request.EnableSDSServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeIPRanges))
            {
                body["ExcludeIPRanges"] = request.ExcludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeInboundPorts))
            {
                body["ExcludeInboundPorts"] = request.ExcludeInboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeOutboundPorts))
            {
                body["ExcludeOutboundPorts"] = request.ExcludeOutboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterGatewayClusterConfig))
            {
                body["FilterGatewayClusterConfig"] = request.FilterGatewayClusterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayAPIEnabled))
            {
                body["GatewayAPIEnabled"] = request.GatewayAPIEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http10Enabled))
            {
                body["Http10Enabled"] = request.Http10Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeIPRanges))
            {
                body["IncludeIPRanges"] = request.IncludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeInboundPorts))
            {
                body["IncludeInboundPorts"] = request.IncludeInboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KialiEnabled))
            {
                body["KialiEnabled"] = request.KialiEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lifecycle))
            {
                body["Lifecycle"] = request.Lifecycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalityLBConf))
            {
                body["LocalityLBConf"] = request.LocalityLBConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalityLoadBalancing))
            {
                body["LocalityLoadBalancing"] = request.LocalityLoadBalancing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MSEEnabled))
            {
                body["MSEEnabled"] = request.MSEEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiBufferEnabled))
            {
                body["MultiBufferEnabled"] = request.MultiBufferEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiBufferPollDelay))
            {
                body["MultiBufferPollDelay"] = request.MultiBufferPollDelay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MysqlFilterEnabled))
            {
                body["MysqlFilterEnabled"] = request.MysqlFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALimitCPU))
            {
                body["OPALimitCPU"] = request.OPALimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALimitMemory))
            {
                body["OPALimitMemory"] = request.OPALimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALogLevel))
            {
                body["OPALogLevel"] = request.OPALogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPARequestCPU))
            {
                body["OPARequestCPU"] = request.OPARequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPARequestMemory))
            {
                body["OPARequestMemory"] = request.OPARequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpaEnabled))
            {
                body["OpaEnabled"] = request.OpaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenAgentPolicy))
            {
                body["OpenAgentPolicy"] = request.OpenAgentPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTrafficPolicy))
            {
                body["OutboundTrafficPolicy"] = request.OutboundTrafficPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusUrl))
            {
                body["PrometheusUrl"] = request.PrometheusUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitCPUResourceLimit))
            {
                body["ProxyInitCPUResourceLimit"] = request.ProxyInitCPUResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitCPUResourceRequest))
            {
                body["ProxyInitCPUResourceRequest"] = request.ProxyInitCPUResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitMemoryResourceLimit))
            {
                body["ProxyInitMemoryResourceLimit"] = request.ProxyInitMemoryResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitMemoryResourceRequest))
            {
                body["ProxyInitMemoryResourceRequest"] = request.ProxyInitMemoryResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyLimitCPU))
            {
                body["ProxyLimitCPU"] = request.ProxyLimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyLimitMemory))
            {
                body["ProxyLimitMemory"] = request.ProxyLimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRequestCPU))
            {
                body["ProxyRequestCPU"] = request.ProxyRequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRequestMemory))
            {
                body["ProxyRequestMemory"] = request.ProxyRequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedisFilterEnabled))
            {
                body["RedisFilterEnabled"] = request.RedisFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarInjectorLimitCPU))
            {
                body["SidecarInjectorLimitCPU"] = request.SidecarInjectorLimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarInjectorLimitMemory))
            {
                body["SidecarInjectorLimitMemory"] = request.SidecarInjectorLimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarInjectorRequestCPU))
            {
                body["SidecarInjectorRequestCPU"] = request.SidecarInjectorRequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarInjectorRequestMemory))
            {
                body["SidecarInjectorRequestMemory"] = request.SidecarInjectorRequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarInjectorWebhookAsYaml))
            {
                body["SidecarInjectorWebhookAsYaml"] = request.SidecarInjectorWebhookAsYaml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telemetry))
            {
                body["Telemetry"] = request.Telemetry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationDrainDuration))
            {
                body["TerminationDrainDuration"] = request.TerminationDrainDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThriftFilterEnabled))
            {
                body["ThriftFilterEnabled"] = request.ThriftFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceSampling))
            {
                body["TraceSampling"] = request.TraceSampling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tracing))
            {
                body["Tracing"] = request.Tracing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebAssemblyFilterEnabled))
            {
                body["WebAssemblyFilterEnabled"] = request.WebAssemblyFilterEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeshFeature",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeshFeatureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMeshFeatureResponse> UpdateMeshFeatureWithOptionsAsync(UpdateMeshFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogEnabled))
            {
                body["AccessLogEnabled"] = request.AccessLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogFile))
            {
                body["AccessLogFile"] = request.AccessLogFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogFormat))
            {
                body["AccessLogFormat"] = request.AccessLogFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogProject))
            {
                body["AccessLogProject"] = request.AccessLogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServiceEnabled))
            {
                body["AccessLogServiceEnabled"] = request.AccessLogServiceEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServiceHost))
            {
                body["AccessLogServiceHost"] = request.AccessLogServiceHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogServicePort))
            {
                body["AccessLogServicePort"] = request.AccessLogServicePort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditProject))
            {
                body["AuditProject"] = request.AuditProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoInjectionPolicyEnabled))
            {
                body["AutoInjectionPolicyEnabled"] = request.AutoInjectionPolicyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CRAggregationEnabled))
            {
                body["CRAggregationEnabled"] = request.CRAggregationEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CniEnabled))
            {
                body["CniEnabled"] = request.CniEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CniExcludeNamespaces))
            {
                body["CniExcludeNamespaces"] = request.CniExcludeNamespaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigSourceEnabled))
            {
                body["ConfigSourceEnabled"] = request.ConfigSourceEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigSourceNacosID))
            {
                body["ConfigSourceNacosID"] = request.ConfigSourceNacosID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomizedPrometheus))
            {
                body["CustomizedPrometheus"] = request.CustomizedPrometheus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomizedZipkin))
            {
                body["CustomizedZipkin"] = request.CustomizedZipkin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSProxyingEnabled))
            {
                body["DNSProxyingEnabled"] = request.DNSProxyingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoverySelectors))
            {
                body["DiscoverySelectors"] = request.DiscoverySelectors;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboFilterEnabled))
            {
                body["DubboFilterEnabled"] = request.DubboFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAudit))
            {
                body["EnableAudit"] = request.EnableAudit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCRHistory))
            {
                body["EnableCRHistory"] = request.EnableCRHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNamespacesByDefault))
            {
                body["EnableNamespacesByDefault"] = request.EnableNamespacesByDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSDSServer))
            {
                body["EnableSDSServer"] = request.EnableSDSServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeIPRanges))
            {
                body["ExcludeIPRanges"] = request.ExcludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeInboundPorts))
            {
                body["ExcludeInboundPorts"] = request.ExcludeInboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeOutboundPorts))
            {
                body["ExcludeOutboundPorts"] = request.ExcludeOutboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterGatewayClusterConfig))
            {
                body["FilterGatewayClusterConfig"] = request.FilterGatewayClusterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayAPIEnabled))
            {
                body["GatewayAPIEnabled"] = request.GatewayAPIEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http10Enabled))
            {
                body["Http10Enabled"] = request.Http10Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeIPRanges))
            {
                body["IncludeIPRanges"] = request.IncludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeInboundPorts))
            {
                body["IncludeInboundPorts"] = request.IncludeInboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KialiEnabled))
            {
                body["KialiEnabled"] = request.KialiEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lifecycle))
            {
                body["Lifecycle"] = request.Lifecycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalityLBConf))
            {
                body["LocalityLBConf"] = request.LocalityLBConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalityLoadBalancing))
            {
                body["LocalityLoadBalancing"] = request.LocalityLoadBalancing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MSEEnabled))
            {
                body["MSEEnabled"] = request.MSEEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiBufferEnabled))
            {
                body["MultiBufferEnabled"] = request.MultiBufferEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiBufferPollDelay))
            {
                body["MultiBufferPollDelay"] = request.MultiBufferPollDelay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MysqlFilterEnabled))
            {
                body["MysqlFilterEnabled"] = request.MysqlFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALimitCPU))
            {
                body["OPALimitCPU"] = request.OPALimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALimitMemory))
            {
                body["OPALimitMemory"] = request.OPALimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPALogLevel))
            {
                body["OPALogLevel"] = request.OPALogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPARequestCPU))
            {
                body["OPARequestCPU"] = request.OPARequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPARequestMemory))
            {
                body["OPARequestMemory"] = request.OPARequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpaEnabled))
            {
                body["OpaEnabled"] = request.OpaEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenAgentPolicy))
            {
                body["OpenAgentPolicy"] = request.OpenAgentPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundTrafficPolicy))
            {
                body["OutboundTrafficPolicy"] = request.OutboundTrafficPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrometheusUrl))
            {
                body["PrometheusUrl"] = request.PrometheusUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitCPUResourceLimit))
            {
                body["ProxyInitCPUResourceLimit"] = request.ProxyInitCPUResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitCPUResourceRequest))
            {
                body["ProxyInitCPUResourceRequest"] = request.ProxyInitCPUResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitMemoryResourceLimit))
            {
                body["ProxyInitMemoryResourceLimit"] = request.ProxyInitMemoryResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitMemoryResourceRequest))
            {
                body["ProxyInitMemoryResourceRequest"] = request.ProxyInitMemoryResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyLimitCPU))
            {
                body["ProxyLimitCPU"] = request.ProxyLimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyLimitMemory))
            {
                body["ProxyLimitMemory"] = request.ProxyLimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRequestCPU))
            {
                body["ProxyRequestCPU"] = request.ProxyRequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRequestMemory))
            {
                body["ProxyRequestMemory"] = request.ProxyRequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedisFilterEnabled))
            {
                body["RedisFilterEnabled"] = request.RedisFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarInjectorLimitCPU))
            {
                body["SidecarInjectorLimitCPU"] = request.SidecarInjectorLimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarInjectorLimitMemory))
            {
                body["SidecarInjectorLimitMemory"] = request.SidecarInjectorLimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarInjectorRequestCPU))
            {
                body["SidecarInjectorRequestCPU"] = request.SidecarInjectorRequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarInjectorRequestMemory))
            {
                body["SidecarInjectorRequestMemory"] = request.SidecarInjectorRequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarInjectorWebhookAsYaml))
            {
                body["SidecarInjectorWebhookAsYaml"] = request.SidecarInjectorWebhookAsYaml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telemetry))
            {
                body["Telemetry"] = request.Telemetry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationDrainDuration))
            {
                body["TerminationDrainDuration"] = request.TerminationDrainDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThriftFilterEnabled))
            {
                body["ThriftFilterEnabled"] = request.ThriftFilterEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceSampling))
            {
                body["TraceSampling"] = request.TraceSampling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tracing))
            {
                body["Tracing"] = request.Tracing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebAssemblyFilterEnabled))
            {
                body["WebAssemblyFilterEnabled"] = request.WebAssemblyFilterEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeshFeature",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeshFeatureResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeIPRanges))
            {
                body["ExcludeIPRanges"] = request.ExcludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeInboundPorts))
            {
                body["ExcludeInboundPorts"] = request.ExcludeInboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeOutboundPorts))
            {
                body["ExcludeOutboundPorts"] = request.ExcludeOutboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeIPRanges))
            {
                body["IncludeIPRanges"] = request.IncludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeInboundPorts))
            {
                body["IncludeInboundPorts"] = request.IncludeInboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeOutboundPorts))
            {
                body["IncludeOutboundPorts"] = request.IncludeOutboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioDNSProxyEnabled))
            {
                body["IstioDNSProxyEnabled"] = request.IstioDNSProxyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lifecycle))
            {
                body["Lifecycle"] = request.Lifecycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitCPUResourceLimit))
            {
                body["ProxyInitCPUResourceLimit"] = request.ProxyInitCPUResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitCPUResourceRequest))
            {
                body["ProxyInitCPUResourceRequest"] = request.ProxyInitCPUResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitMemoryResourceLimit))
            {
                body["ProxyInitMemoryResourceLimit"] = request.ProxyInitMemoryResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitMemoryResourceRequest))
            {
                body["ProxyInitMemoryResourceRequest"] = request.ProxyInitMemoryResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyCPUResourceLimit))
            {
                body["SidecarProxyCPUResourceLimit"] = request.SidecarProxyCPUResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyCPUResourceRequest))
            {
                body["SidecarProxyCPUResourceRequest"] = request.SidecarProxyCPUResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyMemoryResourceLimit))
            {
                body["SidecarProxyMemoryResourceLimit"] = request.SidecarProxyMemoryResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyMemoryResourceRequest))
            {
                body["SidecarProxyMemoryResourceRequest"] = request.SidecarProxyMemoryResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationDrainDuration))
            {
                body["TerminationDrainDuration"] = request.TerminationDrainDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespaceScopeSidecarConfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceScopeSidecarConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateNamespaceScopeSidecarConfigResponse> UpdateNamespaceScopeSidecarConfigWithOptionsAsync(UpdateNamespaceScopeSidecarConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeIPRanges))
            {
                body["ExcludeIPRanges"] = request.ExcludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeInboundPorts))
            {
                body["ExcludeInboundPorts"] = request.ExcludeInboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeOutboundPorts))
            {
                body["ExcludeOutboundPorts"] = request.ExcludeOutboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeIPRanges))
            {
                body["IncludeIPRanges"] = request.IncludeIPRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeInboundPorts))
            {
                body["IncludeInboundPorts"] = request.IncludeInboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeOutboundPorts))
            {
                body["IncludeOutboundPorts"] = request.IncludeOutboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioDNSProxyEnabled))
            {
                body["IstioDNSProxyEnabled"] = request.IstioDNSProxyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lifecycle))
            {
                body["Lifecycle"] = request.Lifecycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitCPUResourceLimit))
            {
                body["ProxyInitCPUResourceLimit"] = request.ProxyInitCPUResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitCPUResourceRequest))
            {
                body["ProxyInitCPUResourceRequest"] = request.ProxyInitCPUResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitMemoryResourceLimit))
            {
                body["ProxyInitMemoryResourceLimit"] = request.ProxyInitMemoryResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitMemoryResourceRequest))
            {
                body["ProxyInitMemoryResourceRequest"] = request.ProxyInitMemoryResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyCPUResourceLimit))
            {
                body["SidecarProxyCPUResourceLimit"] = request.SidecarProxyCPUResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyCPUResourceRequest))
            {
                body["SidecarProxyCPUResourceRequest"] = request.SidecarProxyCPUResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyMemoryResourceLimit))
            {
                body["SidecarProxyMemoryResourceLimit"] = request.SidecarProxyMemoryResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyMemoryResourceRequest))
            {
                body["SidecarProxyMemoryResourceRequest"] = request.SidecarProxyMemoryResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationDrainDuration))
            {
                body["TerminationDrainDuration"] = request.TerminationDrainDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespaceScopeSidecarConfig",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceScopeSidecarConfigResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeMeshVersion",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeMeshVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeMeshVersionResponse> UpgradeMeshVersionWithOptionsAsync(UpgradeMeshVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeMeshVersion",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeMeshVersionResponse>(await CallApiAsync(params_, req, runtime));
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
