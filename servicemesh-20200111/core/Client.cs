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
            this._signatureAlgorithm = "v2";
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

        public AddClusterIntoServiceMeshResponse AddClusterIntoServiceMeshWithOptions(AddClusterIntoServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreNamespaceCheck))
            {
                body["IgnoreNamespaceCheck"] = request.IgnoreNamespaceCheck;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreNamespaceCheck))
            {
                body["IgnoreNamespaceCheck"] = request.IgnoreNamespaceCheck;
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

        /**
          * @deprecated
          *
          * @param request AddVMIntoServiceMeshRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddVMIntoServiceMeshResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request AddVMIntoServiceMeshRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddVMIntoServiceMeshResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request AddVMIntoServiceMeshRequest
          * @return AddVMIntoServiceMeshResponse
         */
        // Deprecated
        public AddVMIntoServiceMeshResponse AddVMIntoServiceMesh(AddVMIntoServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVMIntoServiceMeshWithOptions(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request AddVMIntoServiceMeshRequest
          * @return AddVMIntoServiceMeshResponse
         */
        // Deprecated
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

        public CreateGatewaySecretResponse CreateGatewaySecretWithOptions(CreateGatewaySecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cert))
            {
                body["Cert"] = request.Cert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                body["SecretName"] = request.SecretName;
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
                Action = "CreateGatewaySecret",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewaySecretResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGatewaySecretResponse> CreateGatewaySecretWithOptionsAsync(CreateGatewaySecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cert))
            {
                body["Cert"] = request.Cert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                body["SecretName"] = request.SecretName;
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
                Action = "CreateGatewaySecret",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewaySecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGatewaySecretResponse CreateGatewaySecret(CreateGatewaySecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGatewaySecretWithOptions(request, runtime);
        }

        public async Task<CreateGatewaySecretResponse> CreateGatewaySecretAsync(CreateGatewaySecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGatewaySecretWithOptionsAsync(request, runtime);
        }

        public CreateIstioGatewayDomainsResponse CreateIstioGatewayDomainsWithOptions(CreateIstioGatewayDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                body["Credential"] = request.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceHttps))
            {
                body["ForceHttps"] = request.ForceHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hosts))
            {
                body["Hosts"] = request.Hosts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortName))
            {
                body["PortName"] = request.PortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["Protocol"] = request.Protocol;
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
                Action = "CreateIstioGatewayDomains",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIstioGatewayDomainsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateIstioGatewayDomainsResponse> CreateIstioGatewayDomainsWithOptionsAsync(CreateIstioGatewayDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                body["Credential"] = request.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceHttps))
            {
                body["ForceHttps"] = request.ForceHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hosts))
            {
                body["Hosts"] = request.Hosts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortName))
            {
                body["PortName"] = request.PortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["Protocol"] = request.Protocol;
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
                Action = "CreateIstioGatewayDomains",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIstioGatewayDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateIstioGatewayDomainsResponse CreateIstioGatewayDomains(CreateIstioGatewayDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIstioGatewayDomainsWithOptions(request, runtime);
        }

        public async Task<CreateIstioGatewayDomainsResponse> CreateIstioGatewayDomainsAsync(CreateIstioGatewayDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIstioGatewayDomainsWithOptionsAsync(request, runtime);
        }

        public CreateIstioGatewayRoutesResponse CreateIstioGatewayRoutesWithOptions(CreateIstioGatewayRoutesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIstioGatewayRoutesShrinkRequest request = new CreateIstioGatewayRoutesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GatewayRoute))
            {
                request.GatewayRouteShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GatewayRoute, "GatewayRoute", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayRouteShrink))
            {
                body["GatewayRoute"] = request.GatewayRouteShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIstioGatewayRoutes",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIstioGatewayRoutesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateIstioGatewayRoutesResponse> CreateIstioGatewayRoutesWithOptionsAsync(CreateIstioGatewayRoutesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIstioGatewayRoutesShrinkRequest request = new CreateIstioGatewayRoutesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GatewayRoute))
            {
                request.GatewayRouteShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GatewayRoute, "GatewayRoute", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayRouteShrink))
            {
                body["GatewayRoute"] = request.GatewayRouteShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIstioGatewayRoutes",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIstioGatewayRoutesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateIstioGatewayRoutesResponse CreateIstioGatewayRoutes(CreateIstioGatewayRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIstioGatewayRoutesWithOptions(request, runtime);
        }

        public async Task<CreateIstioGatewayRoutesResponse> CreateIstioGatewayRoutesAsync(CreateIstioGatewayRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIstioGatewayRoutesWithOptionsAsync(request, runtime);
        }

        public CreateServiceMeshResponse CreateServiceMeshWithOptions(CreateServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerLoadBalancerSpec))
            {
                body["ApiServerLoadBalancerSpec"] = request.ApiServerLoadBalancerSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerPublicEip))
            {
                body["ApiServerPublicEip"] = request.ApiServerPublicEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditProject))
            {
                body["AuditProject"] = request.AuditProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                body["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CRAggregationEnabled))
            {
                body["CRAggregationEnabled"] = request.CRAggregationEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDomain))
            {
                body["ClusterDomain"] = request.ClusterDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                body["ClusterSpec"] = request.ClusterSpec;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAmbient))
            {
                body["EnableAmbient"] = request.EnableAmbient;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingCaCert))
            {
                body["ExistingCaCert"] = request.ExistingCaCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingCaKey))
            {
                body["ExistingCaKey"] = request.ExistingCaKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingCaType))
            {
                body["ExistingCaType"] = request.ExistingCaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingRootCaCert))
            {
                body["ExistingRootCaCert"] = request.ExistingRootCaCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingRootCaKey))
            {
                body["ExistingRootCaKey"] = request.ExistingRootCaKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterGatewayClusterConfig))
            {
                body["FilterGatewayClusterConfig"] = request.FilterGatewayClusterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayAPIEnabled))
            {
                body["GatewayAPIEnabled"] = request.GatewayAPIEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestCluster))
            {
                body["GuestCluster"] = request.GuestCluster;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PilotLoadBalancerSpec))
            {
                body["PilotLoadBalancerSpec"] = request.PilotLoadBalancerSpec;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseExistingCA))
            {
                body["UseExistingCA"] = request.UseExistingCA;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerLoadBalancerSpec))
            {
                body["ApiServerLoadBalancerSpec"] = request.ApiServerLoadBalancerSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerPublicEip))
            {
                body["ApiServerPublicEip"] = request.ApiServerPublicEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditProject))
            {
                body["AuditProject"] = request.AuditProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                body["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CRAggregationEnabled))
            {
                body["CRAggregationEnabled"] = request.CRAggregationEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDomain))
            {
                body["ClusterDomain"] = request.ClusterDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                body["ClusterSpec"] = request.ClusterSpec;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAmbient))
            {
                body["EnableAmbient"] = request.EnableAmbient;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingCaCert))
            {
                body["ExistingCaCert"] = request.ExistingCaCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingCaKey))
            {
                body["ExistingCaKey"] = request.ExistingCaKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingCaType))
            {
                body["ExistingCaType"] = request.ExistingCaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingRootCaCert))
            {
                body["ExistingRootCaCert"] = request.ExistingRootCaCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistingRootCaKey))
            {
                body["ExistingRootCaKey"] = request.ExistingRootCaKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterGatewayClusterConfig))
            {
                body["FilterGatewayClusterConfig"] = request.FilterGatewayClusterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayAPIEnabled))
            {
                body["GatewayAPIEnabled"] = request.GatewayAPIEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestCluster))
            {
                body["GuestCluster"] = request.GuestCluster;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PilotLoadBalancerSpec))
            {
                body["PilotLoadBalancerSpec"] = request.PilotLoadBalancerSpec;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseExistingCA))
            {
                body["UseExistingCA"] = request.UseExistingCA;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        public CreateSwimLaneResponse CreateSwimLaneWithOptions(CreateSwimLaneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorKey))
            {
                body["LabelSelectorKey"] = request.LabelSelectorKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorValue))
            {
                body["LabelSelectorValue"] = request.LabelSelectorValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicesList))
            {
                body["ServicesList"] = request.ServicesList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimLaneName))
            {
                body["SwimLaneName"] = request.SwimLaneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSwimLane",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSwimLaneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSwimLaneResponse> CreateSwimLaneWithOptionsAsync(CreateSwimLaneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorKey))
            {
                body["LabelSelectorKey"] = request.LabelSelectorKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorValue))
            {
                body["LabelSelectorValue"] = request.LabelSelectorValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicesList))
            {
                body["ServicesList"] = request.ServicesList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimLaneName))
            {
                body["SwimLaneName"] = request.SwimLaneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSwimLane",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSwimLaneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSwimLaneResponse CreateSwimLane(CreateSwimLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSwimLaneWithOptions(request, runtime);
        }

        public async Task<CreateSwimLaneResponse> CreateSwimLaneAsync(CreateSwimLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSwimLaneWithOptionsAsync(request, runtime);
        }

        public CreateSwimLaneGroupResponse CreateSwimLaneGroupWithOptions(CreateSwimLaneGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressGatewayName))
            {
                body["IngressGatewayName"] = request.IngressGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressType))
            {
                body["IngressType"] = request.IngressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPermissive))
            {
                body["IsPermissive"] = request.IsPermissive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteHeader))
            {
                body["RouteHeader"] = request.RouteHeader;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicesList))
            {
                body["ServicesList"] = request.ServicesList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceHeader))
            {
                body["TraceHeader"] = request.TraceHeader;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSwimLaneGroup",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSwimLaneGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSwimLaneGroupResponse> CreateSwimLaneGroupWithOptionsAsync(CreateSwimLaneGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressGatewayName))
            {
                body["IngressGatewayName"] = request.IngressGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressType))
            {
                body["IngressType"] = request.IngressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPermissive))
            {
                body["IsPermissive"] = request.IsPermissive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteHeader))
            {
                body["RouteHeader"] = request.RouteHeader;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicesList))
            {
                body["ServicesList"] = request.ServicesList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceHeader))
            {
                body["TraceHeader"] = request.TraceHeader;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSwimLaneGroup",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSwimLaneGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSwimLaneGroupResponse CreateSwimLaneGroup(CreateSwimLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSwimLaneGroupWithOptions(request, runtime);
        }

        public async Task<CreateSwimLaneGroupResponse> CreateSwimLaneGroupAsync(CreateSwimLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSwimLaneGroupWithOptionsAsync(request, runtime);
        }

        public CreateWaypointResponse CreateWaypointWithOptions(CreateWaypointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAEnabled))
            {
                body["HPAEnabled"] = request.HPAEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAMaxReplicas))
            {
                body["HPAMaxReplicas"] = request.HPAMaxReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAMinReplicas))
            {
                body["HPAMinReplicas"] = request.HPAMinReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPATargetCPU))
            {
                body["HPATargetCPU"] = request.HPATargetCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPATargetMemory))
            {
                body["HPATargetMemory"] = request.HPATargetMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitCPU))
            {
                body["LimitCPU"] = request.LimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitMemory))
            {
                body["LimitMemory"] = request.LimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferECI))
            {
                body["PreferECI"] = request.PreferECI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestCPU))
            {
                body["RequestCPU"] = request.RequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestMemory))
            {
                body["RequestMemory"] = request.RequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceAccount))
            {
                body["ServiceAccount"] = request.ServiceAccount;
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
                Action = "CreateWaypoint",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWaypointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateWaypointResponse> CreateWaypointWithOptionsAsync(CreateWaypointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAEnabled))
            {
                body["HPAEnabled"] = request.HPAEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAMaxReplicas))
            {
                body["HPAMaxReplicas"] = request.HPAMaxReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAMinReplicas))
            {
                body["HPAMinReplicas"] = request.HPAMinReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPATargetCPU))
            {
                body["HPATargetCPU"] = request.HPATargetCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPATargetMemory))
            {
                body["HPATargetMemory"] = request.HPATargetMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitCPU))
            {
                body["LimitCPU"] = request.LimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitMemory))
            {
                body["LimitMemory"] = request.LimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferECI))
            {
                body["PreferECI"] = request.PreferECI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestCPU))
            {
                body["RequestCPU"] = request.RequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestMemory))
            {
                body["RequestMemory"] = request.RequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceAccount))
            {
                body["ServiceAccount"] = request.ServiceAccount;
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
                Action = "CreateWaypoint",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWaypointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateWaypointResponse CreateWaypoint(CreateWaypointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWaypointWithOptions(request, runtime);
        }

        public async Task<CreateWaypointResponse> CreateWaypointAsync(CreateWaypointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWaypointWithOptionsAsync(request, runtime);
        }

        public DeleteGatewayRouteResponse DeleteGatewayRouteWithOptions(DeleteGatewayRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteName))
            {
                body["RouteName"] = request.RouteName;
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
                Action = "DeleteGatewayRoute",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayRouteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGatewayRouteResponse> DeleteGatewayRouteWithOptionsAsync(DeleteGatewayRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteName))
            {
                body["RouteName"] = request.RouteName;
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
                Action = "DeleteGatewayRoute",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGatewayRouteResponse DeleteGatewayRoute(DeleteGatewayRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGatewayRouteWithOptions(request, runtime);
        }

        public async Task<DeleteGatewayRouteResponse> DeleteGatewayRouteAsync(DeleteGatewayRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGatewayRouteWithOptionsAsync(request, runtime);
        }

        public DeleteGatewaySecretResponse DeleteGatewaySecretWithOptions(DeleteGatewaySecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                body["SecretName"] = request.SecretName;
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
                Action = "DeleteGatewaySecret",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewaySecretResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGatewaySecretResponse> DeleteGatewaySecretWithOptionsAsync(DeleteGatewaySecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                body["SecretName"] = request.SecretName;
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
                Action = "DeleteGatewaySecret",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewaySecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGatewaySecretResponse DeleteGatewaySecret(DeleteGatewaySecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGatewaySecretWithOptions(request, runtime);
        }

        public async Task<DeleteGatewaySecretResponse> DeleteGatewaySecretAsync(DeleteGatewaySecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGatewaySecretWithOptionsAsync(request, runtime);
        }

        public DeleteIstioGatewayDomainsResponse DeleteIstioGatewayDomainsWithOptions(DeleteIstioGatewayDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hosts))
            {
                body["Hosts"] = request.Hosts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortName))
            {
                body["PortName"] = request.PortName;
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
                Action = "DeleteIstioGatewayDomains",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIstioGatewayDomainsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteIstioGatewayDomainsResponse> DeleteIstioGatewayDomainsWithOptionsAsync(DeleteIstioGatewayDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hosts))
            {
                body["Hosts"] = request.Hosts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortName))
            {
                body["PortName"] = request.PortName;
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
                Action = "DeleteIstioGatewayDomains",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIstioGatewayDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteIstioGatewayDomainsResponse DeleteIstioGatewayDomains(DeleteIstioGatewayDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIstioGatewayDomainsWithOptions(request, runtime);
        }

        public async Task<DeleteIstioGatewayDomainsResponse> DeleteIstioGatewayDomainsAsync(DeleteIstioGatewayDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIstioGatewayDomainsWithOptionsAsync(request, runtime);
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

        public DeleteSwimLaneResponse DeleteSwimLaneWithOptions(DeleteSwimLaneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimLaneName))
            {
                body["SwimLaneName"] = request.SwimLaneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSwimLane",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSwimLaneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSwimLaneResponse> DeleteSwimLaneWithOptionsAsync(DeleteSwimLaneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimLaneName))
            {
                body["SwimLaneName"] = request.SwimLaneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSwimLane",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSwimLaneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSwimLaneResponse DeleteSwimLane(DeleteSwimLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSwimLaneWithOptions(request, runtime);
        }

        public async Task<DeleteSwimLaneResponse> DeleteSwimLaneAsync(DeleteSwimLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSwimLaneWithOptionsAsync(request, runtime);
        }

        public DeleteSwimLaneGroupResponse DeleteSwimLaneGroupWithOptions(DeleteSwimLaneGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
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
                Action = "DeleteSwimLaneGroup",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSwimLaneGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSwimLaneGroupResponse> DeleteSwimLaneGroupWithOptionsAsync(DeleteSwimLaneGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
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
                Action = "DeleteSwimLaneGroup",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSwimLaneGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSwimLaneGroupResponse DeleteSwimLaneGroup(DeleteSwimLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSwimLaneGroupWithOptions(request, runtime);
        }

        public async Task<DeleteSwimLaneGroupResponse> DeleteSwimLaneGroupAsync(DeleteSwimLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSwimLaneGroupWithOptionsAsync(request, runtime);
        }

        public DeleteWaypointResponse DeleteWaypointWithOptions(DeleteWaypointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWaypoint",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWaypointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteWaypointResponse> DeleteWaypointWithOptionsAsync(DeleteWaypointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWaypoint",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWaypointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteWaypointResponse DeleteWaypoint(DeleteWaypointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWaypointWithOptions(request, runtime);
        }

        public async Task<DeleteWaypointResponse> DeleteWaypointAsync(DeleteWaypointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWaypointWithOptionsAsync(request, runtime);
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

        public DescribeEipResourcesResponse DescribeEipResourcesWithOptions(DescribeEipResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
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
                Action = "DescribeEipResources",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEipResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEipResourcesResponse> DescribeEipResourcesWithOptionsAsync(DescribeEipResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
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
                Action = "DescribeEipResources",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEipResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEipResourcesResponse DescribeEipResources(DescribeEipResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEipResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeEipResourcesResponse> DescribeEipResourcesAsync(DescribeEipResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEipResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeGatewaySecretDetailsResponse DescribeGatewaySecretDetailsWithOptions(DescribeGatewaySecretDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeGatewaySecretDetails",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewaySecretDetailsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGatewaySecretDetailsResponse> DescribeGatewaySecretDetailsWithOptionsAsync(DescribeGatewaySecretDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeGatewaySecretDetails",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewaySecretDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGatewaySecretDetailsResponse DescribeGatewaySecretDetails(DescribeGatewaySecretDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGatewaySecretDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeGatewaySecretDetailsResponse> DescribeGatewaySecretDetailsAsync(DescribeGatewaySecretDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGatewaySecretDetailsWithOptionsAsync(request, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowNsLabels))
            {
                body["ShowNsLabels"] = request.ShowNsLabels;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowNsLabels))
            {
                body["ShowNsLabels"] = request.ShowNsLabels;
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

        public DescribeIstioGatewayDomainsResponse DescribeIstioGatewayDomainsWithOptions(DescribeIstioGatewayDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
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
                Action = "DescribeIstioGatewayDomains",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIstioGatewayDomainsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeIstioGatewayDomainsResponse> DescribeIstioGatewayDomainsWithOptionsAsync(DescribeIstioGatewayDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
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
                Action = "DescribeIstioGatewayDomains",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIstioGatewayDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeIstioGatewayDomainsResponse DescribeIstioGatewayDomains(DescribeIstioGatewayDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIstioGatewayDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeIstioGatewayDomainsResponse> DescribeIstioGatewayDomainsAsync(DescribeIstioGatewayDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIstioGatewayDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeIstioGatewayRouteDetailResponse DescribeIstioGatewayRouteDetailWithOptions(DescribeIstioGatewayRouteDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteName))
            {
                body["RouteName"] = request.RouteName;
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
                Action = "DescribeIstioGatewayRouteDetail",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIstioGatewayRouteDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeIstioGatewayRouteDetailResponse> DescribeIstioGatewayRouteDetailWithOptionsAsync(DescribeIstioGatewayRouteDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteName))
            {
                body["RouteName"] = request.RouteName;
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
                Action = "DescribeIstioGatewayRouteDetail",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIstioGatewayRouteDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeIstioGatewayRouteDetailResponse DescribeIstioGatewayRouteDetail(DescribeIstioGatewayRouteDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIstioGatewayRouteDetailWithOptions(request, runtime);
        }

        public async Task<DescribeIstioGatewayRouteDetailResponse> DescribeIstioGatewayRouteDetailAsync(DescribeIstioGatewayRouteDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIstioGatewayRouteDetailWithOptionsAsync(request, runtime);
        }

        public DescribeIstioGatewayRoutesResponse DescribeIstioGatewayRoutesWithOptions(DescribeIstioGatewayRoutesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeIstioGatewayRoutes",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIstioGatewayRoutesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeIstioGatewayRoutesResponse> DescribeIstioGatewayRoutesWithOptionsAsync(DescribeIstioGatewayRoutesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeIstioGatewayRoutes",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIstioGatewayRoutesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeIstioGatewayRoutesResponse DescribeIstioGatewayRoutes(DescribeIstioGatewayRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIstioGatewayRoutesWithOptions(request, runtime);
        }

        public async Task<DescribeIstioGatewayRoutesResponse> DescribeIstioGatewayRoutesAsync(DescribeIstioGatewayRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIstioGatewayRoutesWithOptionsAsync(request, runtime);
        }

        public DescribeMetadataResponse DescribeMetadataWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetadata",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetadataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMetadataResponse> DescribeMetadataWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetadata",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetadataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMetadataResponse DescribeMetadata()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetadataWithOptions(runtime);
        }

        public async Task<DescribeMetadataResponse> DescribeMetadataAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetadataWithOptionsAsync(runtime);
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

        public DescribeReusableSlbResponse DescribeReusableSlbWithOptions(DescribeReusableSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                body["K8sClusterId"] = request.K8sClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeReusableSlb",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReusableSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeReusableSlbResponse> DescribeReusableSlbWithOptionsAsync(DescribeReusableSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                body["K8sClusterId"] = request.K8sClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeReusableSlb",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReusableSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeReusableSlbResponse DescribeReusableSlb(DescribeReusableSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReusableSlbWithOptions(request, runtime);
        }

        public async Task<DescribeReusableSlbResponse> DescribeReusableSlbAsync(DescribeReusableSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReusableSlbWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshAdditionalStatusResponse DescribeServiceMeshAdditionalStatusWithOptions(DescribeServiceMeshAdditionalStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckMode))
            {
                body["CheckMode"] = request.CheckMode;
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
                Action = "DescribeServiceMeshAdditionalStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshAdditionalStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshAdditionalStatusResponse> DescribeServiceMeshAdditionalStatusWithOptionsAsync(DescribeServiceMeshAdditionalStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckMode))
            {
                body["CheckMode"] = request.CheckMode;
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
                Action = "DescribeServiceMeshAdditionalStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshAdditionalStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServiceMeshAdditionalStatusResponse DescribeServiceMeshAdditionalStatus(DescribeServiceMeshAdditionalStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshAdditionalStatusWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshAdditionalStatusResponse> DescribeServiceMeshAdditionalStatusAsync(DescribeServiceMeshAdditionalStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshAdditionalStatusWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshClustersResponse DescribeServiceMeshClustersWithOptions(DescribeServiceMeshClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshClusters",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshClustersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshClustersResponse> DescribeServiceMeshClustersWithOptionsAsync(DescribeServiceMeshClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                query["ServiceMeshId"] = request.ServiceMeshId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMeshClusters",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServiceMeshClustersResponse DescribeServiceMeshClusters(DescribeServiceMeshClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshClustersWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshClustersResponse> DescribeServiceMeshClustersAsync(DescribeServiceMeshClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshClustersWithOptionsAsync(request, runtime);
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

        public DescribeServiceMeshLogsResponse DescribeServiceMeshLogsWithOptions(DescribeServiceMeshLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeServiceMeshLogs",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshLogsResponse> DescribeServiceMeshLogsWithOptionsAsync(DescribeServiceMeshLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeServiceMeshLogs",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServiceMeshLogsResponse DescribeServiceMeshLogs(DescribeServiceMeshLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshLogsWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshLogsResponse> DescribeServiceMeshLogsAsync(DescribeServiceMeshLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshLogsWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshProxyStatusResponse DescribeServiceMeshProxyStatusWithOptions(DescribeServiceMeshProxyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeServiceMeshProxyStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshProxyStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMeshProxyStatusResponse> DescribeServiceMeshProxyStatusWithOptionsAsync(DescribeServiceMeshProxyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeServiceMeshProxyStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMeshProxyStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServiceMeshProxyStatusResponse DescribeServiceMeshProxyStatus(DescribeServiceMeshProxyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshProxyStatusWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshProxyStatusResponse> DescribeServiceMeshProxyStatusAsync(DescribeServiceMeshProxyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshProxyStatusWithOptionsAsync(request, runtime);
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

        /**
          * @deprecated
          *
          * @param request DescribeServiceMeshVMsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeServiceMeshVMsResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request DescribeServiceMeshVMsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeServiceMeshVMsResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request DescribeServiceMeshVMsRequest
          * @return DescribeServiceMeshVMsResponse
         */
        // Deprecated
        public DescribeServiceMeshVMsResponse DescribeServiceMeshVMs(DescribeServiceMeshVMsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshVMsWithOptions(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request DescribeServiceMeshVMsRequest
          * @return DescribeServiceMeshVMsResponse
         */
        // Deprecated
        public async Task<DescribeServiceMeshVMsResponse> DescribeServiceMeshVMsAsync(DescribeServiceMeshVMsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshVMsWithOptionsAsync(request, runtime);
        }

        public DescribeServiceMeshesResponse DescribeServiceMeshesWithOptions(DescribeServiceMeshesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
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

        public async Task<DescribeServiceMeshesResponse> DescribeServiceMeshesWithOptionsAsync(DescribeServiceMeshesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
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

        public DescribeServiceMeshesResponse DescribeServiceMeshes(DescribeServiceMeshesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceMeshesWithOptions(request, runtime);
        }

        public async Task<DescribeServiceMeshesResponse> DescribeServiceMeshesAsync(DescribeServiceMeshesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceMeshesWithOptionsAsync(request, runtime);
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

        public DescribeUserPermissionsResponse DescribeUserPermissionsWithOptions(DescribeUserPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubAccountUserId))
            {
                body["SubAccountUserId"] = request.SubAccountUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserPermissions",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserPermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserPermissionsResponse> DescribeUserPermissionsWithOptionsAsync(DescribeUserPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubAccountUserId))
            {
                body["SubAccountUserId"] = request.SubAccountUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserPermissions",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserPermissionsResponse DescribeUserPermissions(DescribeUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserPermissionsWithOptions(request, runtime);
        }

        public async Task<DescribeUserPermissionsResponse> DescribeUserPermissionsAsync(DescribeUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserPermissionsWithOptionsAsync(request, runtime);
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

        /**
          * @deprecated
          *
          * @param request DescribeVMsInServiceMeshRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVMsInServiceMeshResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request DescribeVMsInServiceMeshRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVMsInServiceMeshResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request DescribeVMsInServiceMeshRequest
          * @return DescribeVMsInServiceMeshResponse
         */
        // Deprecated
        public DescribeVMsInServiceMeshResponse DescribeVMsInServiceMesh(DescribeVMsInServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVMsInServiceMeshWithOptions(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request DescribeVMsInServiceMeshRequest
          * @return DescribeVMsInServiceMeshResponse
         */
        // Deprecated
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

        public GetDeploymentBySelectorResponse GetDeploymentBySelectorWithOptions(GetDeploymentBySelectorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeploymentBySelectorShrinkRequest request = new GetDeploymentBySelectorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "LabelSelector", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestCluster))
            {
                body["GuestCluster"] = request.GuestCluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                body["LabelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mark))
            {
                body["Mark"] = request.Mark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpace))
            {
                body["NameSpace"] = request.NameSpace;
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
                Action = "GetDeploymentBySelector",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentBySelectorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDeploymentBySelectorResponse> GetDeploymentBySelectorWithOptionsAsync(GetDeploymentBySelectorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDeploymentBySelectorShrinkRequest request = new GetDeploymentBySelectorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "LabelSelector", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestCluster))
            {
                body["GuestCluster"] = request.GuestCluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                body["LabelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mark))
            {
                body["Mark"] = request.Mark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpace))
            {
                body["NameSpace"] = request.NameSpace;
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
                Action = "GetDeploymentBySelector",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentBySelectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDeploymentBySelectorResponse GetDeploymentBySelector(GetDeploymentBySelectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeploymentBySelectorWithOptions(request, runtime);
        }

        public async Task<GetDeploymentBySelectorResponse> GetDeploymentBySelectorAsync(GetDeploymentBySelectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeploymentBySelectorWithOptionsAsync(request, runtime);
        }

        public GetGrafanaDashboardUrlResponse GetGrafanaDashboardUrlWithOptions(GetGrafanaDashboardUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                body["K8sClusterId"] = request.K8sClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGrafanaDashboardUrl",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGrafanaDashboardUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetGrafanaDashboardUrlResponse> GetGrafanaDashboardUrlWithOptionsAsync(GetGrafanaDashboardUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                body["K8sClusterId"] = request.K8sClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGrafanaDashboardUrl",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGrafanaDashboardUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetGrafanaDashboardUrlResponse GetGrafanaDashboardUrl(GetGrafanaDashboardUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGrafanaDashboardUrlWithOptions(request, runtime);
        }

        public async Task<GetGrafanaDashboardUrlResponse> GetGrafanaDashboardUrlAsync(GetGrafanaDashboardUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGrafanaDashboardUrlWithOptionsAsync(request, runtime);
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

        public GetSwimLaneDetailResponse GetSwimLaneDetailWithOptions(GetSwimLaneDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimLaneName))
            {
                body["SwimLaneName"] = request.SwimLaneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSwimLaneDetail",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSwimLaneDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSwimLaneDetailResponse> GetSwimLaneDetailWithOptionsAsync(GetSwimLaneDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimLaneName))
            {
                body["SwimLaneName"] = request.SwimLaneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSwimLaneDetail",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSwimLaneDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSwimLaneDetailResponse GetSwimLaneDetail(GetSwimLaneDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSwimLaneDetailWithOptions(request, runtime);
        }

        public async Task<GetSwimLaneDetailResponse> GetSwimLaneDetailAsync(GetSwimLaneDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSwimLaneDetailWithOptionsAsync(request, runtime);
        }

        public GetSwimLaneGroupListResponse GetSwimLaneGroupListWithOptions(GetSwimLaneGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSwimLaneGroupList",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSwimLaneGroupListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSwimLaneGroupListResponse> GetSwimLaneGroupListWithOptionsAsync(GetSwimLaneGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSwimLaneGroupList",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSwimLaneGroupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSwimLaneGroupListResponse GetSwimLaneGroupList(GetSwimLaneGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSwimLaneGroupListWithOptions(request, runtime);
        }

        public async Task<GetSwimLaneGroupListResponse> GetSwimLaneGroupListAsync(GetSwimLaneGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSwimLaneGroupListWithOptionsAsync(request, runtime);
        }

        public GetSwimLaneListResponse GetSwimLaneListWithOptions(GetSwimLaneListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
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
                Action = "GetSwimLaneList",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSwimLaneListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSwimLaneListResponse> GetSwimLaneListWithOptionsAsync(GetSwimLaneListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
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
                Action = "GetSwimLaneList",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSwimLaneListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSwimLaneListResponse GetSwimLaneList(GetSwimLaneListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSwimLaneListWithOptions(request, runtime);
        }

        public async Task<GetSwimLaneListResponse> GetSwimLaneListAsync(GetSwimLaneListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSwimLaneListWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request GetVmAppMeshInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetVmAppMeshInfoResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request GetVmAppMeshInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetVmAppMeshInfoResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request GetVmAppMeshInfoRequest
          * @return GetVmAppMeshInfoResponse
         */
        // Deprecated
        public GetVmAppMeshInfoResponse GetVmAppMeshInfo(GetVmAppMeshInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVmAppMeshInfoWithOptions(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request GetVmAppMeshInfoRequest
          * @return GetVmAppMeshInfoResponse
         */
        // Deprecated
        public async Task<GetVmAppMeshInfoResponse> GetVmAppMeshInfoAsync(GetVmAppMeshInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVmAppMeshInfoWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request GetVmMetaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetVmMetaResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request GetVmMetaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetVmMetaResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request GetVmMetaRequest
          * @return GetVmMetaResponse
         */
        // Deprecated
        public GetVmMetaResponse GetVmMeta(GetVmMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVmMetaWithOptions(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request GetVmMetaRequest
          * @return GetVmMetaResponse
         */
        // Deprecated
        public async Task<GetVmMetaResponse> GetVmMetaAsync(GetVmMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVmMetaWithOptionsAsync(request, runtime);
        }

        public GrantUserPermissionsResponse GrantUserPermissionsWithOptions(GrantUserPermissionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantUserPermissionsShrinkRequest request = new GrantUserPermissionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubAccountUserIds))
            {
                request.SubAccountUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubAccountUserIds, "SubAccountUserIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["Permissions"] = request.Permissions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubAccountUserId))
            {
                body["SubAccountUserId"] = request.SubAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubAccountUserIdsShrink))
            {
                body["SubAccountUserIds"] = request.SubAccountUserIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantUserPermissions",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantUserPermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantUserPermissionsResponse> GrantUserPermissionsWithOptionsAsync(GrantUserPermissionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantUserPermissionsShrinkRequest request = new GrantUserPermissionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubAccountUserIds))
            {
                request.SubAccountUserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubAccountUserIds, "SubAccountUserIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["Permissions"] = request.Permissions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubAccountUserId))
            {
                body["SubAccountUserId"] = request.SubAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubAccountUserIdsShrink))
            {
                body["SubAccountUserIds"] = request.SubAccountUserIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantUserPermissions",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantUserPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantUserPermissionsResponse GrantUserPermissions(GrantUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantUserPermissionsWithOptions(request, runtime);
        }

        public async Task<GrantUserPermissionsResponse> GrantUserPermissionsAsync(GrantUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantUserPermissionsWithOptionsAsync(request, runtime);
        }

        public ListServiceAccountsResponse ListServiceAccountsWithOptions(ListServiceAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
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
                Action = "ListServiceAccounts",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceAccountsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServiceAccountsResponse> ListServiceAccountsWithOptionsAsync(ListServiceAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
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
                Action = "ListServiceAccounts",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServiceAccountsResponse ListServiceAccounts(ListServiceAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceAccountsWithOptions(request, runtime);
        }

        public async Task<ListServiceAccountsResponse> ListServiceAccountsAsync(ListServiceAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceAccountsWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListWaypointsResponse ListWaypointsWithOptions(ListWaypointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Continue))
            {
                body["Continue"] = request.Continue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWaypoints",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWaypointsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListWaypointsResponse> ListWaypointsWithOptionsAsync(ListWaypointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Continue))
            {
                body["Continue"] = request.Continue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWaypoints",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWaypointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListWaypointsResponse ListWaypoints(ListWaypointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWaypointsWithOptions(request, runtime);
        }

        public async Task<ListWaypointsResponse> ListWaypointsAsync(ListWaypointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWaypointsWithOptionsAsync(request, runtime);
        }

        public ModifyApiServerEipResourceResponse ModifyApiServerEipResourceWithOptions(ModifyApiServerEipResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEipId))
            {
                body["ApiServerEipId"] = request.ApiServerEipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
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
                Action = "ModifyApiServerEipResource",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyApiServerEipResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyApiServerEipResourceResponse> ModifyApiServerEipResourceWithOptionsAsync(ModifyApiServerEipResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEipId))
            {
                body["ApiServerEipId"] = request.ApiServerEipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["Operation"] = request.Operation;
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
                Action = "ModifyApiServerEipResource",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyApiServerEipResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyApiServerEipResourceResponse ModifyApiServerEipResource(ModifyApiServerEipResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyApiServerEipResourceWithOptions(request, runtime);
        }

        public async Task<ModifyApiServerEipResourceResponse> ModifyApiServerEipResourceAsync(ModifyApiServerEipResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyApiServerEipResourceWithOptionsAsync(request, runtime);
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

        /**
          * Before you call this operation, make sure that you understand the billing methods of Simple Log Service. For more information, visit the [pricing page](https://www.aliyun.com/price/product?spm=5176.10695662.1119587.4.194c6a67rcPWQH#/sls/detail).
          *
          * @param request ReActivateAuditRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ReActivateAuditResponse
         */
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

        /**
          * Before you call this operation, make sure that you understand the billing methods of Simple Log Service. For more information, visit the [pricing page](https://www.aliyun.com/price/product?spm=5176.10695662.1119587.4.194c6a67rcPWQH#/sls/detail).
          *
          * @param request ReActivateAuditRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ReActivateAuditResponse
         */
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

        /**
          * Before you call this operation, make sure that you understand the billing methods of Simple Log Service. For more information, visit the [pricing page](https://www.aliyun.com/price/product?spm=5176.10695662.1119587.4.194c6a67rcPWQH#/sls/detail).
          *
          * @param request ReActivateAuditRequest
          * @return ReActivateAuditResponse
         */
        public ReActivateAuditResponse ReActivateAudit(ReActivateAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReActivateAuditWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you understand the billing methods of Simple Log Service. For more information, visit the [pricing page](https://www.aliyun.com/price/product?spm=5176.10695662.1119587.4.194c6a67rcPWQH#/sls/detail).
          *
          * @param request ReActivateAuditRequest
          * @return ReActivateAuditResponse
         */
        public async Task<ReActivateAuditResponse> ReActivateAuditAsync(ReActivateAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReActivateAuditWithOptionsAsync(request, runtime);
        }

        public RemoveClusterFromServiceMeshResponse RemoveClusterFromServiceMeshWithOptions(RemoveClusterFromServiceMeshRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReserveNamespace))
            {
                body["ReserveNamespace"] = request.ReserveNamespace;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReserveNamespace))
            {
                body["ReserveNamespace"] = request.ReserveNamespace;
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

        /**
          * @deprecated
          *
          * @param request RemoveVMFromServiceMeshRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RemoveVMFromServiceMeshResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request RemoveVMFromServiceMeshRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RemoveVMFromServiceMeshResponse
         */
        // Deprecated
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

        /**
          * @deprecated
          *
          * @param request RemoveVMFromServiceMeshRequest
          * @return RemoveVMFromServiceMeshResponse
         */
        // Deprecated
        public RemoveVMFromServiceMeshResponse RemoveVMFromServiceMesh(RemoveVMFromServiceMeshRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveVMFromServiceMeshWithOptions(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request RemoveVMFromServiceMeshRequest
          * @return RemoveVMFromServiceMeshResponse
         */
        // Deprecated
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

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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

        public UpdateASMNamespaceFromGuestClusterResponse UpdateASMNamespaceFromGuestClusterWithOptions(UpdateASMNamespaceFromGuestClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                body["K8sClusterId"] = request.K8sClusterId;
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
                Action = "UpdateASMNamespaceFromGuestCluster",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateASMNamespaceFromGuestClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateASMNamespaceFromGuestClusterResponse> UpdateASMNamespaceFromGuestClusterWithOptionsAsync(UpdateASMNamespaceFromGuestClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sClusterId))
            {
                body["K8sClusterId"] = request.K8sClusterId;
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
                Action = "UpdateASMNamespaceFromGuestCluster",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateASMNamespaceFromGuestClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateASMNamespaceFromGuestClusterResponse UpdateASMNamespaceFromGuestCluster(UpdateASMNamespaceFromGuestClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateASMNamespaceFromGuestClusterWithOptions(request, runtime);
        }

        public async Task<UpdateASMNamespaceFromGuestClusterResponse> UpdateASMNamespaceFromGuestClusterAsync(UpdateASMNamespaceFromGuestClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateASMNamespaceFromGuestClusterWithOptionsAsync(request, runtime);
        }

        public UpdateControlPlaneLogConfigResponse UpdateControlPlaneLogConfigWithOptions(UpdateControlPlaneLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTTLInDay))
            {
                body["LogTTLInDay"] = request.LogTTLInDay;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTTLInDay))
            {
                body["LogTTLInDay"] = request.LogTTLInDay;
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

        public UpdateIstioGatewayRoutesResponse UpdateIstioGatewayRoutesWithOptions(UpdateIstioGatewayRoutesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateIstioGatewayRoutesShrinkRequest request = new UpdateIstioGatewayRoutesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GatewayRoute))
            {
                request.GatewayRouteShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GatewayRoute, "GatewayRoute", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayRouteShrink))
            {
                body["GatewayRoute"] = request.GatewayRouteShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIstioGatewayRoutes",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIstioGatewayRoutesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateIstioGatewayRoutesResponse> UpdateIstioGatewayRoutesWithOptionsAsync(UpdateIstioGatewayRoutesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateIstioGatewayRoutesShrinkRequest request = new UpdateIstioGatewayRoutesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GatewayRoute))
            {
                request.GatewayRouteShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GatewayRoute, "GatewayRoute", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayRouteShrink))
            {
                body["GatewayRoute"] = request.GatewayRouteShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioGatewayName))
            {
                body["IstioGatewayName"] = request.IstioGatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIstioGatewayRoutes",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIstioGatewayRoutesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateIstioGatewayRoutesResponse UpdateIstioGatewayRoutes(UpdateIstioGatewayRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIstioGatewayRoutesWithOptions(request, runtime);
        }

        public async Task<UpdateIstioGatewayRoutesResponse> UpdateIstioGatewayRoutesAsync(UpdateIstioGatewayRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIstioGatewayRoutesWithOptionsAsync(request, runtime);
        }

        public UpdateIstioInjectionConfigResponse UpdateIstioInjectionConfigWithOptions(UpdateIstioInjectionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPlaneMode))
            {
                body["DataPlaneMode"] = request.DataPlaneMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIstioInjection))
            {
                body["EnableIstioInjection"] = request.EnableIstioInjection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSidecarSetInjection))
            {
                body["EnableSidecarSetInjection"] = request.EnableSidecarSetInjection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioRev))
            {
                body["IstioRev"] = request.IstioRev;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataPlaneMode))
            {
                body["DataPlaneMode"] = request.DataPlaneMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIstioInjection))
            {
                body["EnableIstioInjection"] = request.EnableIstioInjection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSidecarSetInjection))
            {
                body["EnableSidecarSetInjection"] = request.EnableSidecarSetInjection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioRev))
            {
                body["IstioRev"] = request.IstioRev;
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

        public UpdateIstioRouteAdditionalStatusResponse UpdateIstioRouteAdditionalStatusWithOptions(UpdateIstioRouteAdditionalStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteName))
            {
                query["RouteName"] = request.RouteName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIstioRouteAdditionalStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIstioRouteAdditionalStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateIstioRouteAdditionalStatusResponse> UpdateIstioRouteAdditionalStatusWithOptionsAsync(UpdateIstioRouteAdditionalStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteName))
            {
                query["RouteName"] = request.RouteName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIstioRouteAdditionalStatus",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIstioRouteAdditionalStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateIstioRouteAdditionalStatusResponse UpdateIstioRouteAdditionalStatus(UpdateIstioRouteAdditionalStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIstioRouteAdditionalStatusWithOptions(request, runtime);
        }

        public async Task<UpdateIstioRouteAdditionalStatusResponse> UpdateIstioRouteAdditionalStatusAsync(UpdateIstioRouteAdditionalStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIstioRouteAdditionalStatusWithOptionsAsync(request, runtime);
        }

        public UpdateMeshCRAggregationResponse UpdateMeshCRAggregationWithOptions(UpdateMeshCRAggregationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CPULimit))
            {
                body["CPULimit"] = request.CPULimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CPURequirement))
            {
                body["CPURequirement"] = request.CPURequirement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                body["MemoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryRequirement))
            {
                body["MemoryRequirement"] = request.MemoryRequirement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePublicApiServer))
            {
                body["UsePublicApiServer"] = request.UsePublicApiServer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeshCRAggregation",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeshCRAggregationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMeshCRAggregationResponse> UpdateMeshCRAggregationWithOptionsAsync(UpdateMeshCRAggregationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CPULimit))
            {
                body["CPULimit"] = request.CPULimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CPURequirement))
            {
                body["CPURequirement"] = request.CPURequirement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryLimit))
            {
                body["MemoryLimit"] = request.MemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryRequirement))
            {
                body["MemoryRequirement"] = request.MemoryRequirement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePublicApiServer))
            {
                body["UsePublicApiServer"] = request.UsePublicApiServer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeshCRAggregation",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeshCRAggregationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMeshCRAggregationResponse UpdateMeshCRAggregation(UpdateMeshCRAggregationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMeshCRAggregationWithOptions(request, runtime);
        }

        public async Task<UpdateMeshCRAggregationResponse> UpdateMeshCRAggregationAsync(UpdateMeshCRAggregationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMeshCRAggregationWithOptionsAsync(request, runtime);
        }

        public UpdateMeshFeatureResponse UpdateMeshFeatureWithOptions(UpdateMeshFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogGatewayEnabled))
            {
                query["AccessLogGatewayEnabled"] = request.AccessLogGatewayEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogSidecarEnabled))
            {
                query["AccessLogSidecarEnabled"] = request.AccessLogSidecarEnabled;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogGatewayLifecycle))
            {
                body["AccessLogGatewayLifecycle"] = request.AccessLogGatewayLifecycle;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogSidecarLifecycle))
            {
                body["AccessLogSidecarLifecycle"] = request.AccessLogSidecarLifecycle;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                body["ClusterSpec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CniEnabled))
            {
                body["CniEnabled"] = request.CniEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CniExcludeNamespaces))
            {
                body["CniExcludeNamespaces"] = request.CniExcludeNamespaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["Concurrency"] = request.Concurrency;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultComponentsScheduleConfig))
            {
                body["DefaultComponentsScheduleConfig"] = request.DefaultComponentsScheduleConfig;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutoDiagnosis))
            {
                body["EnableAutoDiagnosis"] = request.EnableAutoDiagnosis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBootstrapXdsAgent))
            {
                body["EnableBootstrapXdsAgent"] = request.EnableBootstrapXdsAgent;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldApplicationUntilProxyStarts))
            {
                body["HoldApplicationUntilProxyStarts"] = request.HoldApplicationUntilProxyStarts;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeOutboundPorts))
            {
                body["IncludeOutboundPorts"] = request.IncludeOutboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrateKiali))
            {
                body["IntegrateKiali"] = request.IntegrateKiali;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterceptionMode))
            {
                body["InterceptionMode"] = request.InterceptionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KialiArmsAuthTokens))
            {
                body["KialiArmsAuthTokens"] = request.KialiArmsAuthTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KialiEnabled))
            {
                body["KialiEnabled"] = request.KialiEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KialiServiceAnnotations))
            {
                body["KialiServiceAnnotations"] = request.KialiServiceAnnotations;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLevel))
            {
                body["LogLevel"] = request.LogLevel;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NFDEnabled))
            {
                body["NFDEnabled"] = request.NFDEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NFDLabelPruned))
            {
                body["NFDLabelPruned"] = request.NFDLabelPruned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPAInjectorCPULimit))
            {
                body["OPAInjectorCPULimit"] = request.OPAInjectorCPULimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPAInjectorCPURequirement))
            {
                body["OPAInjectorCPURequirement"] = request.OPAInjectorCPURequirement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPAInjectorMemoryLimit))
            {
                body["OPAInjectorMemoryLimit"] = request.OPAInjectorMemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPAInjectorMemoryRequirement))
            {
                body["OPAInjectorMemoryRequirement"] = request.OPAInjectorMemoryRequirement;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPAScopeInjected))
            {
                body["OPAScopeInjected"] = request.OPAScopeInjected;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyStatsMatcher))
            {
                body["ProxyStatsMatcher"] = request.ProxyStatsMatcher;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceCustomTags))
            {
                body["TraceCustomTags"] = request.TraceCustomTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceMaxPathTagLength))
            {
                body["TraceMaxPathTagLength"] = request.TraceMaxPathTagLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceSampling))
            {
                body["TraceSampling"] = request.TraceSampling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tracing))
            {
                body["Tracing"] = request.Tracing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingOnExtZipkinLimitCPU))
            {
                body["TracingOnExtZipkinLimitCPU"] = request.TracingOnExtZipkinLimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingOnExtZipkinLimitMemory))
            {
                body["TracingOnExtZipkinLimitMemory"] = request.TracingOnExtZipkinLimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingOnExtZipkinRequestCPU))
            {
                body["TracingOnExtZipkinRequestCPU"] = request.TracingOnExtZipkinRequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingOnExtZipkinRequestMemory))
            {
                body["TracingOnExtZipkinRequestMemory"] = request.TracingOnExtZipkinRequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebAssemblyFilterEnabled))
            {
                body["WebAssemblyFilterEnabled"] = request.WebAssemblyFilterEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogGatewayEnabled))
            {
                query["AccessLogGatewayEnabled"] = request.AccessLogGatewayEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogSidecarEnabled))
            {
                query["AccessLogSidecarEnabled"] = request.AccessLogSidecarEnabled;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogGatewayLifecycle))
            {
                body["AccessLogGatewayLifecycle"] = request.AccessLogGatewayLifecycle;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogSidecarLifecycle))
            {
                body["AccessLogSidecarLifecycle"] = request.AccessLogSidecarLifecycle;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                body["ClusterSpec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CniEnabled))
            {
                body["CniEnabled"] = request.CniEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CniExcludeNamespaces))
            {
                body["CniExcludeNamespaces"] = request.CniExcludeNamespaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["Concurrency"] = request.Concurrency;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultComponentsScheduleConfig))
            {
                body["DefaultComponentsScheduleConfig"] = request.DefaultComponentsScheduleConfig;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutoDiagnosis))
            {
                body["EnableAutoDiagnosis"] = request.EnableAutoDiagnosis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBootstrapXdsAgent))
            {
                body["EnableBootstrapXdsAgent"] = request.EnableBootstrapXdsAgent;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldApplicationUntilProxyStarts))
            {
                body["HoldApplicationUntilProxyStarts"] = request.HoldApplicationUntilProxyStarts;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeOutboundPorts))
            {
                body["IncludeOutboundPorts"] = request.IncludeOutboundPorts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrateKiali))
            {
                body["IntegrateKiali"] = request.IntegrateKiali;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterceptionMode))
            {
                body["InterceptionMode"] = request.InterceptionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KialiArmsAuthTokens))
            {
                body["KialiArmsAuthTokens"] = request.KialiArmsAuthTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KialiEnabled))
            {
                body["KialiEnabled"] = request.KialiEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KialiServiceAnnotations))
            {
                body["KialiServiceAnnotations"] = request.KialiServiceAnnotations;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLevel))
            {
                body["LogLevel"] = request.LogLevel;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NFDEnabled))
            {
                body["NFDEnabled"] = request.NFDEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NFDLabelPruned))
            {
                body["NFDLabelPruned"] = request.NFDLabelPruned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPAInjectorCPULimit))
            {
                body["OPAInjectorCPULimit"] = request.OPAInjectorCPULimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPAInjectorCPURequirement))
            {
                body["OPAInjectorCPURequirement"] = request.OPAInjectorCPURequirement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPAInjectorMemoryLimit))
            {
                body["OPAInjectorMemoryLimit"] = request.OPAInjectorMemoryLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPAInjectorMemoryRequirement))
            {
                body["OPAInjectorMemoryRequirement"] = request.OPAInjectorMemoryRequirement;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OPAScopeInjected))
            {
                body["OPAScopeInjected"] = request.OPAScopeInjected;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyStatsMatcher))
            {
                body["ProxyStatsMatcher"] = request.ProxyStatsMatcher;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceCustomTags))
            {
                body["TraceCustomTags"] = request.TraceCustomTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceMaxPathTagLength))
            {
                body["TraceMaxPathTagLength"] = request.TraceMaxPathTagLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceSampling))
            {
                body["TraceSampling"] = request.TraceSampling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tracing))
            {
                body["Tracing"] = request.Tracing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingOnExtZipkinLimitCPU))
            {
                body["TracingOnExtZipkinLimitCPU"] = request.TracingOnExtZipkinLimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingOnExtZipkinLimitMemory))
            {
                body["TracingOnExtZipkinLimitMemory"] = request.TracingOnExtZipkinLimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingOnExtZipkinRequestCPU))
            {
                body["TracingOnExtZipkinRequestCPU"] = request.TracingOnExtZipkinRequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingOnExtZipkinRequestMemory))
            {
                body["TracingOnExtZipkinRequestMemory"] = request.TracingOnExtZipkinRequestMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebAssemblyFilterEnabled))
            {
                body["WebAssemblyFilterEnabled"] = request.WebAssemblyFilterEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCoreDump))
            {
                body["EnableCoreDump"] = request.EnableCoreDump;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldApplicationUntilProxyStarts))
            {
                body["HoldApplicationUntilProxyStarts"] = request.HoldApplicationUntilProxyStarts;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterceptionMode))
            {
                body["InterceptionMode"] = request.InterceptionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioDNSProxyEnabled))
            {
                body["IstioDNSProxyEnabled"] = request.IstioDNSProxyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lifecycle))
            {
                body["Lifecycle"] = request.Lifecycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLevel))
            {
                body["LogLevel"] = request.LogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                body["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                body["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Privileged))
            {
                body["Privileged"] = request.Privileged;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitAckSloCPUResourceLimit))
            {
                body["ProxyInitAckSloCPUResourceLimit"] = request.ProxyInitAckSloCPUResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitAckSloCPUResourceRequest))
            {
                body["ProxyInitAckSloCPUResourceRequest"] = request.ProxyInitAckSloCPUResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitAckSloMemoryResourceLimit))
            {
                body["ProxyInitAckSloMemoryResourceLimit"] = request.ProxyInitAckSloMemoryResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitAckSloMemoryResourceRequest))
            {
                body["ProxyInitAckSloMemoryResourceRequest"] = request.ProxyInitAckSloMemoryResourceRequest;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyMetadata))
            {
                body["ProxyMetadata"] = request.ProxyMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyStatsMatcher))
            {
                body["ProxyStatsMatcher"] = request.ProxyStatsMatcher;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadinessFailureThreshold))
            {
                body["ReadinessFailureThreshold"] = request.ReadinessFailureThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadinessInitialDelaySeconds))
            {
                body["ReadinessInitialDelaySeconds"] = request.ReadinessInitialDelaySeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadinessPeriodSeconds))
            {
                body["ReadinessPeriodSeconds"] = request.ReadinessPeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyAckSloCPUResourceLimit))
            {
                body["SidecarProxyAckSloCPUResourceLimit"] = request.SidecarProxyAckSloCPUResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyAckSloCPUResourceRequest))
            {
                body["SidecarProxyAckSloCPUResourceRequest"] = request.SidecarProxyAckSloCPUResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyAckSloMemoryResourceLimit))
            {
                body["SidecarProxyAckSloMemoryResourceLimit"] = request.SidecarProxyAckSloMemoryResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyAckSloMemoryResourceRequest))
            {
                body["SidecarProxyAckSloMemoryResourceRequest"] = request.SidecarProxyAckSloMemoryResourceRequest;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tracing))
            {
                body["Tracing"] = request.Tracing;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCoreDump))
            {
                body["EnableCoreDump"] = request.EnableCoreDump;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldApplicationUntilProxyStarts))
            {
                body["HoldApplicationUntilProxyStarts"] = request.HoldApplicationUntilProxyStarts;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterceptionMode))
            {
                body["InterceptionMode"] = request.InterceptionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IstioDNSProxyEnabled))
            {
                body["IstioDNSProxyEnabled"] = request.IstioDNSProxyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lifecycle))
            {
                body["Lifecycle"] = request.Lifecycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLevel))
            {
                body["LogLevel"] = request.LogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                body["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                body["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Privileged))
            {
                body["Privileged"] = request.Privileged;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitAckSloCPUResourceLimit))
            {
                body["ProxyInitAckSloCPUResourceLimit"] = request.ProxyInitAckSloCPUResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitAckSloCPUResourceRequest))
            {
                body["ProxyInitAckSloCPUResourceRequest"] = request.ProxyInitAckSloCPUResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitAckSloMemoryResourceLimit))
            {
                body["ProxyInitAckSloMemoryResourceLimit"] = request.ProxyInitAckSloMemoryResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyInitAckSloMemoryResourceRequest))
            {
                body["ProxyInitAckSloMemoryResourceRequest"] = request.ProxyInitAckSloMemoryResourceRequest;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyMetadata))
            {
                body["ProxyMetadata"] = request.ProxyMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyStatsMatcher))
            {
                body["ProxyStatsMatcher"] = request.ProxyStatsMatcher;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadinessFailureThreshold))
            {
                body["ReadinessFailureThreshold"] = request.ReadinessFailureThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadinessInitialDelaySeconds))
            {
                body["ReadinessInitialDelaySeconds"] = request.ReadinessInitialDelaySeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadinessPeriodSeconds))
            {
                body["ReadinessPeriodSeconds"] = request.ReadinessPeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyAckSloCPUResourceLimit))
            {
                body["SidecarProxyAckSloCPUResourceLimit"] = request.SidecarProxyAckSloCPUResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyAckSloCPUResourceRequest))
            {
                body["SidecarProxyAckSloCPUResourceRequest"] = request.SidecarProxyAckSloCPUResourceRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyAckSloMemoryResourceLimit))
            {
                body["SidecarProxyAckSloMemoryResourceLimit"] = request.SidecarProxyAckSloMemoryResourceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarProxyAckSloMemoryResourceRequest))
            {
                body["SidecarProxyAckSloMemoryResourceRequest"] = request.SidecarProxyAckSloMemoryResourceRequest;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tracing))
            {
                body["Tracing"] = request.Tracing;
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

        public UpdateSwimLaneResponse UpdateSwimLaneWithOptions(UpdateSwimLaneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorKey))
            {
                body["LabelSelectorKey"] = request.LabelSelectorKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorValue))
            {
                body["LabelSelectorValue"] = request.LabelSelectorValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicesList))
            {
                body["ServicesList"] = request.ServicesList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimLaneName))
            {
                body["SwimLaneName"] = request.SwimLaneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSwimLane",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSwimLaneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSwimLaneResponse> UpdateSwimLaneWithOptionsAsync(UpdateSwimLaneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorKey))
            {
                body["LabelSelectorKey"] = request.LabelSelectorKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorValue))
            {
                body["LabelSelectorValue"] = request.LabelSelectorValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicesList))
            {
                body["ServicesList"] = request.ServicesList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimLaneName))
            {
                body["SwimLaneName"] = request.SwimLaneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSwimLane",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSwimLaneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSwimLaneResponse UpdateSwimLane(UpdateSwimLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSwimLaneWithOptions(request, runtime);
        }

        public async Task<UpdateSwimLaneResponse> UpdateSwimLaneAsync(UpdateSwimLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSwimLaneWithOptionsAsync(request, runtime);
        }

        public UpdateSwimLaneGroupResponse UpdateSwimLaneGroupWithOptions(UpdateSwimLaneGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallbackTarget))
            {
                body["FallbackTarget"] = request.FallbackTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicesList))
            {
                body["ServicesList"] = request.ServicesList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSwimLaneGroup",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSwimLaneGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSwimLaneGroupResponse> UpdateSwimLaneGroupWithOptionsAsync(UpdateSwimLaneGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallbackTarget))
            {
                body["FallbackTarget"] = request.FallbackTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicesList))
            {
                body["ServicesList"] = request.ServicesList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSwimLaneGroup",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSwimLaneGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSwimLaneGroupResponse UpdateSwimLaneGroup(UpdateSwimLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSwimLaneGroupWithOptions(request, runtime);
        }

        public async Task<UpdateSwimLaneGroupResponse> UpdateSwimLaneGroupAsync(UpdateSwimLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSwimLaneGroupWithOptionsAsync(request, runtime);
        }

        public UpdateWaypointResponse UpdateWaypointWithOptions(UpdateWaypointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAEnabled))
            {
                body["HPAEnabled"] = request.HPAEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAMaxReplicas))
            {
                body["HPAMaxReplicas"] = request.HPAMaxReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAMinReplicas))
            {
                body["HPAMinReplicas"] = request.HPAMinReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPATargetCPU))
            {
                body["HPATargetCPU"] = request.HPATargetCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPATargetMemory))
            {
                body["HPATargetMemory"] = request.HPATargetMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitCPU))
            {
                body["LimitCPU"] = request.LimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitMemory))
            {
                body["LimitMemory"] = request.LimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferECI))
            {
                body["PreferECI"] = request.PreferECI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestCPU))
            {
                body["RequestCPU"] = request.RequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestMemory))
            {
                body["RequestMemory"] = request.RequestMemory;
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
                Action = "UpdateWaypoint",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWaypointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateWaypointResponse> UpdateWaypointWithOptionsAsync(UpdateWaypointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAEnabled))
            {
                body["HPAEnabled"] = request.HPAEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAMaxReplicas))
            {
                body["HPAMaxReplicas"] = request.HPAMaxReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPAMinReplicas))
            {
                body["HPAMinReplicas"] = request.HPAMinReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPATargetCPU))
            {
                body["HPATargetCPU"] = request.HPATargetCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPATargetMemory))
            {
                body["HPATargetMemory"] = request.HPATargetMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitCPU))
            {
                body["LimitCPU"] = request.LimitCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitMemory))
            {
                body["LimitMemory"] = request.LimitMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferECI))
            {
                body["PreferECI"] = request.PreferECI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestCPU))
            {
                body["RequestCPU"] = request.RequestCPU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestMemory))
            {
                body["RequestMemory"] = request.RequestMemory;
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
                Action = "UpdateWaypoint",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWaypointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateWaypointResponse UpdateWaypoint(UpdateWaypointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWaypointWithOptions(request, runtime);
        }

        public async Task<UpdateWaypointResponse> UpdateWaypointAsync(UpdateWaypointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWaypointWithOptionsAsync(request, runtime);
        }

        public UpgradeMeshEditionPartiallyResponse UpgradeMeshEditionPartiallyWithOptions(UpgradeMeshEditionPartiallyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASMGatewayContinue))
            {
                body["ASMGatewayContinue"] = request.ASMGatewayContinue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedVersion))
            {
                body["ExpectedVersion"] = request.ExpectedVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreCheck))
            {
                body["PreCheck"] = request.PreCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchToPro))
            {
                body["SwitchToPro"] = request.SwitchToPro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeGatewayRecords))
            {
                body["UpgradeGatewayRecords"] = request.UpgradeGatewayRecords;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeMeshEditionPartially",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeMeshEditionPartiallyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeMeshEditionPartiallyResponse> UpgradeMeshEditionPartiallyWithOptionsAsync(UpgradeMeshEditionPartiallyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ASMGatewayContinue))
            {
                body["ASMGatewayContinue"] = request.ASMGatewayContinue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedVersion))
            {
                body["ExpectedVersion"] = request.ExpectedVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreCheck))
            {
                body["PreCheck"] = request.PreCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceMeshId))
            {
                body["ServiceMeshId"] = request.ServiceMeshId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchToPro))
            {
                body["SwitchToPro"] = request.SwitchToPro;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeGatewayRecords))
            {
                body["UpgradeGatewayRecords"] = request.UpgradeGatewayRecords;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeMeshEditionPartially",
                Version = "2020-01-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeMeshEditionPartiallyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpgradeMeshEditionPartiallyResponse UpgradeMeshEditionPartially(UpgradeMeshEditionPartiallyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeMeshEditionPartiallyWithOptions(request, runtime);
        }

        public async Task<UpgradeMeshEditionPartiallyResponse> UpgradeMeshEditionPartiallyAsync(UpgradeMeshEditionPartiallyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeMeshEditionPartiallyWithOptionsAsync(request, runtime);
        }

        public UpgradeMeshVersionResponse UpgradeMeshVersionWithOptions(UpgradeMeshVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreCheck))
            {
                query["PreCheck"] = request.PreCheck;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreCheck))
            {
                query["PreCheck"] = request.PreCheck;
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
