// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.APIG20240327.Models;

namespace AlibabaCloud.SDK.APIG20240327
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("apig", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary 授权网关访问服务的安全组
         *
         * @param request AddGatewaySecurityGroupRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGatewaySecurityGroupRuleResponse
         */
        public AddGatewaySecurityGroupRuleResponse AddGatewaySecurityGroupRuleWithOptions(string gatewayId, AddGatewaySecurityGroupRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRanges))
            {
                body["portRanges"] = request.PortRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["securityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGatewaySecurityGroupRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/security-group-rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGatewaySecurityGroupRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 授权网关访问服务的安全组
         *
         * @param request AddGatewaySecurityGroupRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGatewaySecurityGroupRuleResponse
         */
        public async Task<AddGatewaySecurityGroupRuleResponse> AddGatewaySecurityGroupRuleWithOptionsAsync(string gatewayId, AddGatewaySecurityGroupRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRanges))
            {
                body["portRanges"] = request.PortRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["securityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGatewaySecurityGroupRule",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/security-group-rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGatewaySecurityGroupRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 授权网关访问服务的安全组
         *
         * @param request AddGatewaySecurityGroupRuleRequest
         * @return AddGatewaySecurityGroupRuleResponse
         */
        public AddGatewaySecurityGroupRuleResponse AddGatewaySecurityGroupRule(string gatewayId, AddGatewaySecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddGatewaySecurityGroupRuleWithOptions(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 授权网关访问服务的安全组
         *
         * @param request AddGatewaySecurityGroupRuleRequest
         * @return AddGatewaySecurityGroupRuleResponse
         */
        public async Task<AddGatewaySecurityGroupRuleResponse> AddGatewaySecurityGroupRuleAsync(string gatewayId, AddGatewaySecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddGatewaySecurityGroupRuleWithOptionsAsync(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 创建域名
         *
         * @param request CreateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomainWithOptions(CreateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertIndentifier))
            {
                body["caCertIndentifier"] = request.CaCertIndentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIndentifier))
            {
                body["certIndentifier"] = request.CertIndentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceHttps))
            {
                body["forceHttps"] = request.ForceHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Option))
            {
                body["http2Option"] = request.Http2Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMax))
            {
                body["tlsMax"] = request.TlsMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMin))
            {
                body["tlsMin"] = request.TlsMin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建域名
         *
         * @param request CreateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(CreateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertIndentifier))
            {
                body["caCertIndentifier"] = request.CaCertIndentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIndentifier))
            {
                body["certIndentifier"] = request.CertIndentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceHttps))
            {
                body["forceHttps"] = request.ForceHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Option))
            {
                body["http2Option"] = request.Http2Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMax))
            {
                body["tlsMax"] = request.TlsMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMin))
            {
                body["tlsMin"] = request.TlsMin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建域名
         *
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDomainWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建域名
         *
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDomainWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary CreateEnvironment
         *
         * @param request CreateEnvironmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEnvironmentResponse
         */
        public CreateEnvironmentResponse CreateEnvironmentWithOptions(CreateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary CreateEnvironment
         *
         * @param request CreateEnvironmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEnvironmentResponse
         */
        public async Task<CreateEnvironmentResponse> CreateEnvironmentWithOptionsAsync(CreateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                body["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary CreateEnvironment
         *
         * @param request CreateEnvironmentRequest
         * @return CreateEnvironmentResponse
         */
        public CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEnvironmentWithOptions(request, headers, runtime);
        }

        /**
         * @summary CreateEnvironment
         *
         * @param request CreateEnvironmentRequest
         * @return CreateEnvironmentResponse
         */
        public async Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEnvironmentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建网关路由
         *
         * @param request CreateGatewayRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGatewayRouteResponse
         */
        public CreateGatewayRouteResponse CreateGatewayRouteWithOptions(string gatewayId, CreateGatewayRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainConfig))
            {
                body["domainConfig"] = request.DomainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayRouteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建网关路由
         *
         * @param request CreateGatewayRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGatewayRouteResponse
         */
        public async Task<CreateGatewayRouteResponse> CreateGatewayRouteWithOptionsAsync(string gatewayId, CreateGatewayRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainConfig))
            {
                body["domainConfig"] = request.DomainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建网关路由
         *
         * @param request CreateGatewayRouteRequest
         * @return CreateGatewayRouteResponse
         */
        public CreateGatewayRouteResponse CreateGatewayRoute(string gatewayId, CreateGatewayRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGatewayRouteWithOptions(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 创建网关路由
         *
         * @param request CreateGatewayRouteRequest
         * @return CreateGatewayRouteResponse
         */
        public async Task<CreateGatewayRouteResponse> CreateGatewayRouteAsync(string gatewayId, CreateGatewayRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGatewayRouteWithOptionsAsync(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 创建服务
         *
         * @param request CreateGatewayServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGatewayServiceResponse
         */
        public CreateGatewayServiceResponse CreateGatewayServiceWithOptions(string gatewayId, CreateGatewayServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayServiceConfigs))
            {
                body["gatewayServiceConfigs"] = request.GatewayServiceConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建服务
         *
         * @param request CreateGatewayServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGatewayServiceResponse
         */
        public async Task<CreateGatewayServiceResponse> CreateGatewayServiceWithOptionsAsync(string gatewayId, CreateGatewayServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayServiceConfigs))
            {
                body["gatewayServiceConfigs"] = request.GatewayServiceConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建服务
         *
         * @param request CreateGatewayServiceRequest
         * @return CreateGatewayServiceResponse
         */
        public CreateGatewayServiceResponse CreateGatewayService(string gatewayId, CreateGatewayServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGatewayServiceWithOptions(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 创建服务
         *
         * @param request CreateGatewayServiceRequest
         * @return CreateGatewayServiceResponse
         */
        public async Task<CreateGatewayServiceResponse> CreateGatewayServiceAsync(string gatewayId, CreateGatewayServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGatewayServiceWithOptionsAsync(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 创建服务版本
         *
         * @param request CreateGatewayServiceVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGatewayServiceVersionResponse
         */
        public CreateGatewayServiceVersionResponse CreateGatewayServiceVersionWithOptions(string gatewayId, string gatewayServiceId, CreateGatewayServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId) + "/service-versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayServiceVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建服务版本
         *
         * @param request CreateGatewayServiceVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGatewayServiceVersionResponse
         */
        public async Task<CreateGatewayServiceVersionResponse> CreateGatewayServiceVersionWithOptionsAsync(string gatewayId, string gatewayServiceId, CreateGatewayServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId) + "/service-versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayServiceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建服务版本
         *
         * @param request CreateGatewayServiceVersionRequest
         * @return CreateGatewayServiceVersionResponse
         */
        public CreateGatewayServiceVersionResponse CreateGatewayServiceVersion(string gatewayId, string gatewayServiceId, CreateGatewayServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGatewayServiceVersionWithOptions(gatewayId, gatewayServiceId, request, headers, runtime);
        }

        /**
         * @summary 创建服务版本
         *
         * @param request CreateGatewayServiceVersionRequest
         * @return CreateGatewayServiceVersionResponse
         */
        public async Task<CreateGatewayServiceVersionResponse> CreateGatewayServiceVersionAsync(string gatewayId, string gatewayServiceId, CreateGatewayServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGatewayServiceVersionWithOptionsAsync(gatewayId, gatewayServiceId, request, headers, runtime);
        }

        /**
         * @summary 创建一个HTTP类型的API
         *
         * @param request CreateHttpApiRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHttpApiResponse
         */
        public CreateHttpApiResponse CreateHttpApiWithOptions(CreateHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasePath))
            {
                body["basePath"] = request.BasePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionConfig))
            {
                body["versionConfig"] = request.VersionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建一个HTTP类型的API
         *
         * @param request CreateHttpApiRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHttpApiResponse
         */
        public async Task<CreateHttpApiResponse> CreateHttpApiWithOptionsAsync(CreateHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasePath))
            {
                body["basePath"] = request.BasePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionConfig))
            {
                body["versionConfig"] = request.VersionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建一个HTTP类型的API
         *
         * @param request CreateHttpApiRequest
         * @return CreateHttpApiResponse
         */
        public CreateHttpApiResponse CreateHttpApi(CreateHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateHttpApiWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建一个HTTP类型的API
         *
         * @param request CreateHttpApiRequest
         * @return CreateHttpApiResponse
         */
        public async Task<CreateHttpApiResponse> CreateHttpApiAsync(CreateHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateHttpApiWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 为HTTP API创建Operation
         *
         * @param request CreateHttpApiOperationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHttpApiOperationResponse
         */
        public CreateHttpApiOperationResponse CreateHttpApiOperationWithOptions(string httpApiId, CreateHttpApiOperationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operations))
            {
                body["operations"] = request.Operations;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHttpApiOperationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 为HTTP API创建Operation
         *
         * @param request CreateHttpApiOperationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHttpApiOperationResponse
         */
        public async Task<CreateHttpApiOperationResponse> CreateHttpApiOperationWithOptionsAsync(string httpApiId, CreateHttpApiOperationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operations))
            {
                body["operations"] = request.Operations;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHttpApiOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 为HTTP API创建Operation
         *
         * @param request CreateHttpApiOperationRequest
         * @return CreateHttpApiOperationResponse
         */
        public CreateHttpApiOperationResponse CreateHttpApiOperation(string httpApiId, CreateHttpApiOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateHttpApiOperationWithOptions(httpApiId, request, headers, runtime);
        }

        /**
         * @summary 为HTTP API创建Operation
         *
         * @param request CreateHttpApiOperationRequest
         * @return CreateHttpApiOperationResponse
         */
        public async Task<CreateHttpApiOperationResponse> CreateHttpApiOperationAsync(string httpApiId, CreateHttpApiOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateHttpApiOperationWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /**
         * @summary 创建服务来源
         *
         * @param request CreateServiceSourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceSourceResponse
         */
        public CreateServiceSourceResponse CreateServiceSourceWithOptions(string gatewayId, CreateServiceSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sServiceSourceConfig))
            {
                body["k8sServiceSourceConfig"] = request.K8sServiceSourceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosServiceSourceConfig))
            {
                body["nacosServiceSourceConfig"] = request.NacosServiceSourceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/service-sources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建服务来源
         *
         * @param request CreateServiceSourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceSourceResponse
         */
        public async Task<CreateServiceSourceResponse> CreateServiceSourceWithOptionsAsync(string gatewayId, CreateServiceSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sServiceSourceConfig))
            {
                body["k8sServiceSourceConfig"] = request.K8sServiceSourceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosServiceSourceConfig))
            {
                body["nacosServiceSourceConfig"] = request.NacosServiceSourceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/service-sources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建服务来源
         *
         * @param request CreateServiceSourceRequest
         * @return CreateServiceSourceResponse
         */
        public CreateServiceSourceResponse CreateServiceSource(string gatewayId, CreateServiceSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceSourceWithOptions(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 创建服务来源
         *
         * @param request CreateServiceSourceRequest
         * @return CreateServiceSourceResponse
         */
        public async Task<CreateServiceSourceResponse> CreateServiceSourceAsync(string gatewayId, CreateServiceSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceSourceWithOptionsAsync(gatewayId, request, headers, runtime);
        }

        /**
         * @summary DeleteDomain
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomainWithOptions(string domainId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DeleteDomain
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(string domainId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DeleteDomain
         *
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomain(string domainId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDomainWithOptions(domainId, headers, runtime);
        }

        /**
         * @summary DeleteDomain
         *
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainAsync(string domainId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDomainWithOptionsAsync(domainId, headers, runtime);
        }

        /**
         * @summary DeleteEnvironment
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEnvironmentResponse
         */
        public DeleteEnvironmentResponse DeleteEnvironmentWithOptions(string environmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DeleteEnvironment
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEnvironmentResponse
         */
        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentWithOptionsAsync(string environmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DeleteEnvironment
         *
         * @return DeleteEnvironmentResponse
         */
        public DeleteEnvironmentResponse DeleteEnvironment(string environmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEnvironmentWithOptions(environmentId, headers, runtime);
        }

        /**
         * @summary DeleteEnvironment
         *
         * @return DeleteEnvironmentResponse
         */
        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(string environmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEnvironmentWithOptionsAsync(environmentId, headers, runtime);
        }

        /**
         * @summary 删除网关
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayResponse
         */
        public DeleteGatewayResponse DeleteGatewayWithOptions(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除网关
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayResponse
         */
        public async Task<DeleteGatewayResponse> DeleteGatewayWithOptionsAsync(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除网关
         *
         * @return DeleteGatewayResponse
         */
        public DeleteGatewayResponse DeleteGateway(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayWithOptions(gatewayId, headers, runtime);
        }

        /**
         * @summary 删除网关
         *
         * @return DeleteGatewayResponse
         */
        public async Task<DeleteGatewayResponse> DeleteGatewayAsync(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayWithOptionsAsync(gatewayId, headers, runtime);
        }

        /**
         * @summary 创建网关路由
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayRouteResponse
         */
        public DeleteGatewayRouteResponse DeleteGatewayRouteWithOptions(string gatewayId, string gatewayRouteId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayRouteId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayRouteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建网关路由
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayRouteResponse
         */
        public async Task<DeleteGatewayRouteResponse> DeleteGatewayRouteWithOptionsAsync(string gatewayId, string gatewayRouteId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayRouteId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建网关路由
         *
         * @return DeleteGatewayRouteResponse
         */
        public DeleteGatewayRouteResponse DeleteGatewayRoute(string gatewayId, string gatewayRouteId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayRouteWithOptions(gatewayId, gatewayRouteId, headers, runtime);
        }

        /**
         * @summary 创建网关路由
         *
         * @return DeleteGatewayRouteResponse
         */
        public async Task<DeleteGatewayRouteResponse> DeleteGatewayRouteAsync(string gatewayId, string gatewayRouteId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayRouteWithOptionsAsync(gatewayId, gatewayRouteId, headers, runtime);
        }

        /**
         * @summary 删除服务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayServiceResponse
         */
        public DeleteGatewayServiceResponse DeleteGatewayServiceWithOptions(string gatewayId, string gatewayServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除服务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayServiceResponse
         */
        public async Task<DeleteGatewayServiceResponse> DeleteGatewayServiceWithOptionsAsync(string gatewayId, string gatewayServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除服务
         *
         * @return DeleteGatewayServiceResponse
         */
        public DeleteGatewayServiceResponse DeleteGatewayService(string gatewayId, string gatewayServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayServiceWithOptions(gatewayId, gatewayServiceId, headers, runtime);
        }

        /**
         * @summary 删除服务
         *
         * @return DeleteGatewayServiceResponse
         */
        public async Task<DeleteGatewayServiceResponse> DeleteGatewayServiceAsync(string gatewayId, string gatewayServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayServiceWithOptionsAsync(gatewayId, gatewayServiceId, headers, runtime);
        }

        /**
         * @summary 删除服务版本
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayServiceVersionResponse
         */
        public DeleteGatewayServiceVersionResponse DeleteGatewayServiceVersionWithOptions(string gatewayId, string gatewayServiceId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId) + "/service-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayServiceVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除服务版本
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayServiceVersionResponse
         */
        public async Task<DeleteGatewayServiceVersionResponse> DeleteGatewayServiceVersionWithOptionsAsync(string gatewayId, string gatewayServiceId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId) + "/service-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayServiceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除服务版本
         *
         * @return DeleteGatewayServiceVersionResponse
         */
        public DeleteGatewayServiceVersionResponse DeleteGatewayServiceVersion(string gatewayId, string gatewayServiceId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayServiceVersionWithOptions(gatewayId, gatewayServiceId, name, headers, runtime);
        }

        /**
         * @summary 删除服务版本
         *
         * @return DeleteGatewayServiceVersionResponse
         */
        public async Task<DeleteGatewayServiceVersionResponse> DeleteGatewayServiceVersionAsync(string gatewayId, string gatewayServiceId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayServiceVersionWithOptionsAsync(gatewayId, gatewayServiceId, name, headers, runtime);
        }

        /**
         * @summary 删除HTTP API
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHttpApiResponse
         */
        public DeleteHttpApiResponse DeleteHttpApiWithOptions(string httpApiId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除HTTP API
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHttpApiResponse
         */
        public async Task<DeleteHttpApiResponse> DeleteHttpApiWithOptionsAsync(string httpApiId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除HTTP API
         *
         * @return DeleteHttpApiResponse
         */
        public DeleteHttpApiResponse DeleteHttpApi(string httpApiId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHttpApiWithOptions(httpApiId, headers, runtime);
        }

        /**
         * @summary 删除HTTP API
         *
         * @return DeleteHttpApiResponse
         */
        public async Task<DeleteHttpApiResponse> DeleteHttpApiAsync(string httpApiId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHttpApiWithOptionsAsync(httpApiId, headers, runtime);
        }

        /**
         * @summary 删除Operation
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHttpApiOperationResponse
         */
        public DeleteHttpApiOperationResponse DeleteHttpApiOperationWithOptions(string httpApiId, string operationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHttpApiOperationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除Operation
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHttpApiOperationResponse
         */
        public async Task<DeleteHttpApiOperationResponse> DeleteHttpApiOperationWithOptionsAsync(string httpApiId, string operationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHttpApiOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除Operation
         *
         * @return DeleteHttpApiOperationResponse
         */
        public DeleteHttpApiOperationResponse DeleteHttpApiOperation(string httpApiId, string operationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHttpApiOperationWithOptions(httpApiId, operationId, headers, runtime);
        }

        /**
         * @summary 删除Operation
         *
         * @return DeleteHttpApiOperationResponse
         */
        public async Task<DeleteHttpApiOperationResponse> DeleteHttpApiOperationAsync(string httpApiId, string operationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHttpApiOperationWithOptionsAsync(httpApiId, operationId, headers, runtime);
        }

        /**
         * @summary 删除服务来源
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceSourceResponse
         */
        public DeleteServiceSourceResponse DeleteServiceSourceWithOptions(string gatewayId, string serviceSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/service-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceSourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除服务来源
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceSourceResponse
         */
        public async Task<DeleteServiceSourceResponse> DeleteServiceSourceWithOptionsAsync(string gatewayId, string serviceSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/service-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceSourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除服务来源
         *
         * @return DeleteServiceSourceResponse
         */
        public DeleteServiceSourceResponse DeleteServiceSource(string gatewayId, string serviceSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceSourceWithOptions(gatewayId, serviceSourceId, headers, runtime);
        }

        /**
         * @summary 删除服务来源
         *
         * @return DeleteServiceSourceResponse
         */
        public async Task<DeleteServiceSourceResponse> DeleteServiceSourceAsync(string gatewayId, string serviceSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceSourceWithOptionsAsync(gatewayId, serviceSourceId, headers, runtime);
        }

        /**
         * @summary 查询域名详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainResponse
         */
        public GetDomainResponse GetDomainWithOptions(string domainId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询域名详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainResponse
         */
        public async Task<GetDomainResponse> GetDomainWithOptionsAsync(string domainId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询域名详情
         *
         * @return GetDomainResponse
         */
        public GetDomainResponse GetDomain(string domainId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDomainWithOptions(domainId, headers, runtime);
        }

        /**
         * @summary 查询域名详情
         *
         * @return GetDomainResponse
         */
        public async Task<GetDomainResponse> GetDomainAsync(string domainId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDomainWithOptionsAsync(domainId, headers, runtime);
        }

        /**
         * @summary GetEnvironment
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnvironmentResponse
         */
        public GetEnvironmentResponse GetEnvironmentWithOptions(string environmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary GetEnvironment
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEnvironmentResponse
         */
        public async Task<GetEnvironmentResponse> GetEnvironmentWithOptionsAsync(string environmentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary GetEnvironment
         *
         * @return GetEnvironmentResponse
         */
        public GetEnvironmentResponse GetEnvironment(string environmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnvironmentWithOptions(environmentId, headers, runtime);
        }

        /**
         * @summary GetEnvironment
         *
         * @return GetEnvironmentResponse
         */
        public async Task<GetEnvironmentResponse> GetEnvironmentAsync(string environmentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnvironmentWithOptionsAsync(environmentId, headers, runtime);
        }

        /**
         * @summary 获取网关实例详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGatewayResponse
         */
        public GetGatewayResponse GetGatewayWithOptions(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGatewayResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取网关实例详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGatewayResponse
         */
        public async Task<GetGatewayResponse> GetGatewayWithOptionsAsync(string gatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGateway",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取网关实例详情
         *
         * @return GetGatewayResponse
         */
        public GetGatewayResponse GetGateway(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGatewayWithOptions(gatewayId, headers, runtime);
        }

        /**
         * @summary 获取网关实例详情
         *
         * @return GetGatewayResponse
         */
        public async Task<GetGatewayResponse> GetGatewayAsync(string gatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGatewayWithOptionsAsync(gatewayId, headers, runtime);
        }

        /**
         * @summary 创建网关路由
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGatewayRouteResponse
         */
        public GetGatewayRouteResponse GetGatewayRouteWithOptions(string gatewayId, string gatewayRouteId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayRouteId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGatewayRouteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建网关路由
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGatewayRouteResponse
         */
        public async Task<GetGatewayRouteResponse> GetGatewayRouteWithOptionsAsync(string gatewayId, string gatewayRouteId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayRouteId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGatewayRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建网关路由
         *
         * @return GetGatewayRouteResponse
         */
        public GetGatewayRouteResponse GetGatewayRoute(string gatewayId, string gatewayRouteId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGatewayRouteWithOptions(gatewayId, gatewayRouteId, headers, runtime);
        }

        /**
         * @summary 创建网关路由
         *
         * @return GetGatewayRouteResponse
         */
        public async Task<GetGatewayRouteResponse> GetGatewayRouteAsync(string gatewayId, string gatewayRouteId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGatewayRouteWithOptionsAsync(gatewayId, gatewayRouteId, headers, runtime);
        }

        /**
         * @summary 查询服务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGatewayServiceResponse
         */
        public GetGatewayServiceResponse GetGatewayServiceWithOptions(string gatewayId, string gatewayServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGatewayService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGatewayServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGatewayServiceResponse
         */
        public async Task<GetGatewayServiceResponse> GetGatewayServiceWithOptionsAsync(string gatewayId, string gatewayServiceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGatewayService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGatewayServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务
         *
         * @return GetGatewayServiceResponse
         */
        public GetGatewayServiceResponse GetGatewayService(string gatewayId, string gatewayServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGatewayServiceWithOptions(gatewayId, gatewayServiceId, headers, runtime);
        }

        /**
         * @summary 查询服务
         *
         * @return GetGatewayServiceResponse
         */
        public async Task<GetGatewayServiceResponse> GetGatewayServiceAsync(string gatewayId, string gatewayServiceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGatewayServiceWithOptionsAsync(gatewayId, gatewayServiceId, headers, runtime);
        }

        /**
         * @summary 读取HttpApi
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHttpApiResponse
         */
        public GetHttpApiResponse GetHttpApiWithOptions(string httpApiId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 读取HttpApi
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHttpApiResponse
         */
        public async Task<GetHttpApiResponse> GetHttpApiWithOptionsAsync(string httpApiId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 读取HttpApi
         *
         * @return GetHttpApiResponse
         */
        public GetHttpApiResponse GetHttpApi(string httpApiId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHttpApiWithOptions(httpApiId, headers, runtime);
        }

        /**
         * @summary 读取HttpApi
         *
         * @return GetHttpApiResponse
         */
        public async Task<GetHttpApiResponse> GetHttpApiAsync(string httpApiId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHttpApiWithOptionsAsync(httpApiId, headers, runtime);
        }

        /**
         * @summary 读取Operation
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHttpApiOperationResponse
         */
        public GetHttpApiOperationResponse GetHttpApiOperationWithOptions(string httpApiId, string operationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHttpApiOperationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 读取Operation
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHttpApiOperationResponse
         */
        public async Task<GetHttpApiOperationResponse> GetHttpApiOperationWithOptionsAsync(string httpApiId, string operationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHttpApiOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 读取Operation
         *
         * @return GetHttpApiOperationResponse
         */
        public GetHttpApiOperationResponse GetHttpApiOperation(string httpApiId, string operationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHttpApiOperationWithOptions(httpApiId, operationId, headers, runtime);
        }

        /**
         * @summary 读取Operation
         *
         * @return GetHttpApiOperationResponse
         */
        public async Task<GetHttpApiOperationResponse> GetHttpApiOperationAsync(string httpApiId, string operationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHttpApiOperationWithOptionsAsync(httpApiId, operationId, headers, runtime);
        }

        /**
         * @summary ListDomains
         *
         * @param request ListDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDomainsResponse
         */
        public ListDomainsResponse ListDomainsWithOptions(ListDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ListDomains
         *
         * @param request ListDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDomainsResponse
         */
        public async Task<ListDomainsResponse> ListDomainsWithOptionsAsync(ListDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ListDomains
         *
         * @param request ListDomainsRequest
         * @return ListDomainsResponse
         */
        public ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDomainsWithOptions(request, headers, runtime);
        }

        /**
         * @summary ListDomains
         *
         * @param request ListDomainsRequest
         * @return ListDomainsResponse
         */
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDomainsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary ListEnvironments
         *
         * @param request ListEnvironmentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEnvironmentsResponse
         */
        public ListEnvironmentsResponse ListEnvironmentsWithOptions(ListEnvironmentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasLike))
            {
                query["aliasLike"] = request.AliasLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayNameLike))
            {
                query["gatewayNameLike"] = request.GatewayNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironments",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ListEnvironments
         *
         * @param request ListEnvironmentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEnvironmentsResponse
         */
        public async Task<ListEnvironmentsResponse> ListEnvironmentsWithOptionsAsync(ListEnvironmentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasLike))
            {
                query["aliasLike"] = request.AliasLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayNameLike))
            {
                query["gatewayNameLike"] = request.GatewayNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironments",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ListEnvironments
         *
         * @param request ListEnvironmentsRequest
         * @return ListEnvironmentsResponse
         */
        public ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnvironmentsWithOptions(request, headers, runtime);
        }

        /**
         * @summary ListEnvironments
         *
         * @param request ListEnvironmentsRequest
         * @return ListEnvironmentsResponse
         */
        public async Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnvironmentsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建网关路由
         *
         * @param request ListGatewayRoutesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGatewayRoutesResponse
         */
        public ListGatewayRoutesResponse ListGatewayRoutesWithOptions(string gatewayId, ListGatewayRoutesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayRoutes",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayRoutesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建网关路由
         *
         * @param request ListGatewayRoutesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGatewayRoutesResponse
         */
        public async Task<ListGatewayRoutesResponse> ListGatewayRoutesWithOptionsAsync(string gatewayId, ListGatewayRoutesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayRoutes",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayRoutesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建网关路由
         *
         * @param request ListGatewayRoutesRequest
         * @return ListGatewayRoutesResponse
         */
        public ListGatewayRoutesResponse ListGatewayRoutes(string gatewayId, ListGatewayRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayRoutesWithOptions(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 创建网关路由
         *
         * @param request ListGatewayRoutesRequest
         * @return ListGatewayRoutesResponse
         */
        public async Task<ListGatewayRoutesResponse> ListGatewayRoutesAsync(string gatewayId, ListGatewayRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayRoutesWithOptionsAsync(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 查询服务列表
         *
         * @param request ListGatewayServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGatewayServicesResponse
         */
        public ListGatewayServicesResponse ListGatewayServicesWithOptions(string gatewayId, ListGatewayServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayServices",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayServicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务列表
         *
         * @param request ListGatewayServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGatewayServicesResponse
         */
        public async Task<ListGatewayServicesResponse> ListGatewayServicesWithOptionsAsync(string gatewayId, ListGatewayServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayServices",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务列表
         *
         * @param request ListGatewayServicesRequest
         * @return ListGatewayServicesResponse
         */
        public ListGatewayServicesResponse ListGatewayServices(string gatewayId, ListGatewayServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayServicesWithOptions(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 查询服务列表
         *
         * @param request ListGatewayServicesRequest
         * @return ListGatewayServicesResponse
         */
        public async Task<ListGatewayServicesResponse> ListGatewayServicesAsync(string gatewayId, ListGatewayServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayServicesWithOptionsAsync(gatewayId, request, headers, runtime);
        }

        /**
         * @summary 获取已经创建的云原生网关列表
         *
         * @param request ListGatewaysRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGatewaysResponse
         */
        public ListGatewaysResponse ListGatewaysWithOptions(ListGatewaysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGateways",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewaysResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取已经创建的云原生网关列表
         *
         * @param request ListGatewaysRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGatewaysResponse
         */
        public async Task<ListGatewaysResponse> ListGatewaysWithOptionsAsync(ListGatewaysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["gatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGateways",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewaysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取已经创建的云原生网关列表
         *
         * @param request ListGatewaysRequest
         * @return ListGatewaysResponse
         */
        public ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewaysWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取已经创建的云原生网关列表
         *
         * @param request ListGatewaysRequest
         * @return ListGatewaysResponse
         */
        public async Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewaysWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 列举Operation
         *
         * @param request ListHttpApiOperationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHttpApiOperationsResponse
         */
        public ListHttpApiOperationsResponse ListHttpApiOperationsWithOptions(string httpApiId, ListHttpApiOperationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathLike))
            {
                query["pathLike"] = request.PathLike;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHttpApiOperations",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHttpApiOperationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列举Operation
         *
         * @param request ListHttpApiOperationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHttpApiOperationsResponse
         */
        public async Task<ListHttpApiOperationsResponse> ListHttpApiOperationsWithOptionsAsync(string httpApiId, ListHttpApiOperationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                query["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathLike))
            {
                query["pathLike"] = request.PathLike;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHttpApiOperations",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHttpApiOperationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列举Operation
         *
         * @param request ListHttpApiOperationsRequest
         * @return ListHttpApiOperationsResponse
         */
        public ListHttpApiOperationsResponse ListHttpApiOperations(string httpApiId, ListHttpApiOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHttpApiOperationsWithOptions(httpApiId, request, headers, runtime);
        }

        /**
         * @summary 列举Operation
         *
         * @param request ListHttpApiOperationsRequest
         * @return ListHttpApiOperationsResponse
         */
        public async Task<ListHttpApiOperationsResponse> ListHttpApiOperationsAsync(string httpApiId, ListHttpApiOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHttpApiOperationsWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /**
         * @summary 列举HTTP API
         *
         * @param request ListHttpApisRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHttpApisResponse
         */
        public ListHttpApisResponse ListHttpApisWithOptions(ListHttpApisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishedOnly))
            {
                query["publishedOnly"] = request.PublishedOnly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHttpApis",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHttpApisResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列举HTTP API
         *
         * @param request ListHttpApisRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHttpApisResponse
         */
        public async Task<ListHttpApisResponse> ListHttpApisWithOptionsAsync(ListHttpApisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishedOnly))
            {
                query["publishedOnly"] = request.PublishedOnly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHttpApis",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHttpApisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列举HTTP API
         *
         * @param request ListHttpApisRequest
         * @return ListHttpApisResponse
         */
        public ListHttpApisResponse ListHttpApis(ListHttpApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHttpApisWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列举HTTP API
         *
         * @param request ListHttpApisRequest
         * @return ListHttpApisResponse
         */
        public async Task<ListHttpApisResponse> ListHttpApisAsync(ListHttpApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHttpApisWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发布路由
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OfflineGatewayRouteResponse
         */
        public OfflineGatewayRouteResponse OfflineGatewayRouteWithOptions(string gatewayId, string gatewayRouteId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayRouteId) + "/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineGatewayRouteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 发布路由
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OfflineGatewayRouteResponse
         */
        public async Task<OfflineGatewayRouteResponse> OfflineGatewayRouteWithOptionsAsync(string gatewayId, string gatewayRouteId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayRouteId) + "/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineGatewayRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 发布路由
         *
         * @return OfflineGatewayRouteResponse
         */
        public OfflineGatewayRouteResponse OfflineGatewayRoute(string gatewayId, string gatewayRouteId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineGatewayRouteWithOptions(gatewayId, gatewayRouteId, headers, runtime);
        }

        /**
         * @summary 发布路由
         *
         * @return OfflineGatewayRouteResponse
         */
        public async Task<OfflineGatewayRouteResponse> OfflineGatewayRouteAsync(string gatewayId, string gatewayRouteId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineGatewayRouteWithOptionsAsync(gatewayId, gatewayRouteId, headers, runtime);
        }

        /**
         * @summary 下线已发布的HTTP API
         *
         * @param request OfflineHttpApiRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OfflineHttpApiResponse
         */
        public OfflineHttpApiResponse OfflineHttpApiWithOptions(string httpApiId, OfflineHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 下线已发布的HTTP API
         *
         * @param request OfflineHttpApiRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OfflineHttpApiResponse
         */
        public async Task<OfflineHttpApiResponse> OfflineHttpApiWithOptionsAsync(string httpApiId, OfflineHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentId))
            {
                body["environmentId"] = request.EnvironmentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 下线已发布的HTTP API
         *
         * @param request OfflineHttpApiRequest
         * @return OfflineHttpApiResponse
         */
        public OfflineHttpApiResponse OfflineHttpApi(string httpApiId, OfflineHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineHttpApiWithOptions(httpApiId, request, headers, runtime);
        }

        /**
         * @summary 下线已发布的HTTP API
         *
         * @param request OfflineHttpApiRequest
         * @return OfflineHttpApiResponse
         */
        public async Task<OfflineHttpApiResponse> OfflineHttpApiAsync(string httpApiId, OfflineHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineHttpApiWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /**
         * @summary 发布路由
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishGatewayRouteResponse
         */
        public PublishGatewayRouteResponse PublishGatewayRouteWithOptions(string gatewayId, string gatewayRouteId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayRouteId) + "/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishGatewayRouteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 发布路由
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishGatewayRouteResponse
         */
        public async Task<PublishGatewayRouteResponse> PublishGatewayRouteWithOptionsAsync(string gatewayId, string gatewayRouteId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayRouteId) + "/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishGatewayRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 发布路由
         *
         * @return PublishGatewayRouteResponse
         */
        public PublishGatewayRouteResponse PublishGatewayRoute(string gatewayId, string gatewayRouteId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishGatewayRouteWithOptions(gatewayId, gatewayRouteId, headers, runtime);
        }

        /**
         * @summary 发布路由
         *
         * @return PublishGatewayRouteResponse
         */
        public async Task<PublishGatewayRouteResponse> PublishGatewayRouteAsync(string gatewayId, string gatewayRouteId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishGatewayRouteWithOptionsAsync(gatewayId, gatewayRouteId, headers, runtime);
        }

        /**
         * @summary 发布HTTP API
         *
         * @param request PublishHttpApiRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishHttpApiResponse
         */
        public PublishHttpApiResponse PublishHttpApiWithOptions(string httpApiId, PublishHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowOverwrite))
            {
                body["allowOverwrite"] = request.AllowOverwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                body["revisionId"] = request.RevisionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 发布HTTP API
         *
         * @param request PublishHttpApiRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishHttpApiResponse
         */
        public async Task<PublishHttpApiResponse> PublishHttpApiWithOptionsAsync(string httpApiId, PublishHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowOverwrite))
            {
                body["allowOverwrite"] = request.AllowOverwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                body["revisionId"] = request.RevisionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 发布HTTP API
         *
         * @param request PublishHttpApiRequest
         * @return PublishHttpApiResponse
         */
        public PublishHttpApiResponse PublishHttpApi(string httpApiId, PublishHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishHttpApiWithOptions(httpApiId, request, headers, runtime);
        }

        /**
         * @summary 发布HTTP API
         *
         * @param request PublishHttpApiRequest
         * @return PublishHttpApiResponse
         */
        public async Task<PublishHttpApiResponse> PublishHttpApiAsync(string httpApiId, PublishHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishHttpApiWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /**
         * @summary UpdateDomain
         *
         * @param request UpdateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainResponse
         */
        public UpdateDomainResponse UpdateDomainWithOptions(string domainId, UpdateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertIndentifier))
            {
                body["caCertIndentifier"] = request.CaCertIndentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIndentifier))
            {
                body["certIndentifier"] = request.CertIndentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceHttps))
            {
                body["forceHttps"] = request.ForceHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Option))
            {
                body["http2Option"] = request.Http2Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMax))
            {
                body["tlsMax"] = request.TlsMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMin))
            {
                body["tlsMin"] = request.TlsMin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary UpdateDomain
         *
         * @param request UpdateDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainResponse
         */
        public async Task<UpdateDomainResponse> UpdateDomainWithOptionsAsync(string domainId, UpdateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaCertIndentifier))
            {
                body["caCertIndentifier"] = request.CaCertIndentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIndentifier))
            {
                body["certIndentifier"] = request.CertIndentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceHttps))
            {
                body["forceHttps"] = request.ForceHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Http2Option))
            {
                body["http2Option"] = request.Http2Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMax))
            {
                body["tlsMax"] = request.TlsMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsMin))
            {
                body["tlsMin"] = request.TlsMin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomain",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary UpdateDomain
         *
         * @param request UpdateDomainRequest
         * @return UpdateDomainResponse
         */
        public UpdateDomainResponse UpdateDomain(string domainId, UpdateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDomainWithOptions(domainId, request, headers, runtime);
        }

        /**
         * @summary UpdateDomain
         *
         * @param request UpdateDomainRequest
         * @return UpdateDomainResponse
         */
        public async Task<UpdateDomainResponse> UpdateDomainAsync(string domainId, UpdateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDomainWithOptionsAsync(domainId, request, headers, runtime);
        }

        /**
         * @summary UpdateEnvironment
         *
         * @param request UpdateEnvironmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEnvironmentResponse
         */
        public UpdateEnvironmentResponse UpdateEnvironmentWithOptions(string environmentId, UpdateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary UpdateEnvironment
         *
         * @param request UpdateEnvironmentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEnvironmentResponse
         */
        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentWithOptionsAsync(string environmentId, UpdateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironment",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(environmentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary UpdateEnvironment
         *
         * @param request UpdateEnvironmentRequest
         * @return UpdateEnvironmentResponse
         */
        public UpdateEnvironmentResponse UpdateEnvironment(string environmentId, UpdateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEnvironmentWithOptions(environmentId, request, headers, runtime);
        }

        /**
         * @summary UpdateEnvironment
         *
         * @param request UpdateEnvironmentRequest
         * @return UpdateEnvironmentResponse
         */
        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(string environmentId, UpdateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEnvironmentWithOptionsAsync(environmentId, request, headers, runtime);
        }

        /**
         * @summary 创建网关路由
         *
         * @param request UpdateGatewayRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGatewayRouteResponse
         */
        public UpdateGatewayRouteResponse UpdateGatewayRouteWithOptions(string gatewayId, string gatewayRouteId, UpdateGatewayRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainConfig))
            {
                body["domainConfig"] = request.DomainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayRouteId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayRouteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建网关路由
         *
         * @param request UpdateGatewayRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGatewayRouteResponse
         */
        public async Task<UpdateGatewayRouteResponse> UpdateGatewayRouteWithOptionsAsync(string gatewayId, string gatewayRouteId, UpdateGatewayRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackendConfig))
            {
                body["backendConfig"] = request.BackendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainConfig))
            {
                body["domainConfig"] = request.DomainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                body["match"] = request.Match;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayRoute",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/http-routes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayRouteId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建网关路由
         *
         * @param request UpdateGatewayRouteRequest
         * @return UpdateGatewayRouteResponse
         */
        public UpdateGatewayRouteResponse UpdateGatewayRoute(string gatewayId, string gatewayRouteId, UpdateGatewayRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGatewayRouteWithOptions(gatewayId, gatewayRouteId, request, headers, runtime);
        }

        /**
         * @summary 创建网关路由
         *
         * @param request UpdateGatewayRouteRequest
         * @return UpdateGatewayRouteResponse
         */
        public async Task<UpdateGatewayRouteResponse> UpdateGatewayRouteAsync(string gatewayId, string gatewayRouteId, UpdateGatewayRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGatewayRouteWithOptionsAsync(gatewayId, gatewayRouteId, request, headers, runtime);
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateGatewayServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGatewayServiceResponse
         */
        public UpdateGatewayServiceResponse UpdateGatewayServiceWithOptions(string gatewayId, string gatewayServiceId, UpdateGatewayServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addresses))
            {
                body["addresses"] = request.Addresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["port"] = request.Port;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateGatewayServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGatewayServiceResponse
         */
        public async Task<UpdateGatewayServiceResponse> UpdateGatewayServiceWithOptionsAsync(string gatewayId, string gatewayServiceId, UpdateGatewayServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addresses))
            {
                body["addresses"] = request.Addresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["port"] = request.Port;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayService",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateGatewayServiceRequest
         * @return UpdateGatewayServiceResponse
         */
        public UpdateGatewayServiceResponse UpdateGatewayService(string gatewayId, string gatewayServiceId, UpdateGatewayServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGatewayServiceWithOptions(gatewayId, gatewayServiceId, request, headers, runtime);
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateGatewayServiceRequest
         * @return UpdateGatewayServiceResponse
         */
        public async Task<UpdateGatewayServiceResponse> UpdateGatewayServiceAsync(string gatewayId, string gatewayServiceId, UpdateGatewayServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGatewayServiceWithOptionsAsync(gatewayId, gatewayServiceId, request, headers, runtime);
        }

        /**
         * @summary 更新服务版本
         *
         * @param request UpdateGatewayServiceVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGatewayServiceVersionResponse
         */
        public UpdateGatewayServiceVersionResponse UpdateGatewayServiceVersionWithOptions(string gatewayId, string gatewayServiceId, string name, UpdateGatewayServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId) + "/service-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayServiceVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新服务版本
         *
         * @param request UpdateGatewayServiceVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGatewayServiceVersionResponse
         */
        public async Task<UpdateGatewayServiceVersionResponse> UpdateGatewayServiceVersionWithOptionsAsync(string gatewayId, string gatewayServiceId, string name, UpdateGatewayServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGatewayServiceVersion",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/gateway-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayServiceId) + "/service-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayServiceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新服务版本
         *
         * @param request UpdateGatewayServiceVersionRequest
         * @return UpdateGatewayServiceVersionResponse
         */
        public UpdateGatewayServiceVersionResponse UpdateGatewayServiceVersion(string gatewayId, string gatewayServiceId, string name, UpdateGatewayServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGatewayServiceVersionWithOptions(gatewayId, gatewayServiceId, name, request, headers, runtime);
        }

        /**
         * @summary 更新服务版本
         *
         * @param request UpdateGatewayServiceVersionRequest
         * @return UpdateGatewayServiceVersionResponse
         */
        public async Task<UpdateGatewayServiceVersionResponse> UpdateGatewayServiceVersionAsync(string gatewayId, string gatewayServiceId, string name, UpdateGatewayServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGatewayServiceVersionWithOptionsAsync(gatewayId, gatewayServiceId, name, request, headers, runtime);
        }

        /**
         * @summary 更新HTTP API
         *
         * @param request UpdateHttpApiRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHttpApiResponse
         */
        public UpdateHttpApiResponse UpdateHttpApiWithOptions(string httpApiId, UpdateHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasePath))
            {
                body["basePath"] = request.BasePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionConfig))
            {
                body["versionConfig"] = request.VersionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHttpApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新HTTP API
         *
         * @param request UpdateHttpApiRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHttpApiResponse
         */
        public async Task<UpdateHttpApiResponse> UpdateHttpApiWithOptionsAsync(string httpApiId, UpdateHttpApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasePath))
            {
                body["basePath"] = request.BasePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocols))
            {
                body["protocols"] = request.Protocols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionConfig))
            {
                body["versionConfig"] = request.VersionConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHttpApi",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新HTTP API
         *
         * @param request UpdateHttpApiRequest
         * @return UpdateHttpApiResponse
         */
        public UpdateHttpApiResponse UpdateHttpApi(string httpApiId, UpdateHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateHttpApiWithOptions(httpApiId, request, headers, runtime);
        }

        /**
         * @summary 更新HTTP API
         *
         * @param request UpdateHttpApiRequest
         * @return UpdateHttpApiResponse
         */
        public async Task<UpdateHttpApiResponse> UpdateHttpApiAsync(string httpApiId, UpdateHttpApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateHttpApiWithOptionsAsync(httpApiId, request, headers, runtime);
        }

        /**
         * @summary 更新Operation
         *
         * @param request UpdateHttpApiOperationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHttpApiOperationResponse
         */
        public UpdateHttpApiOperationResponse UpdateHttpApiOperationWithOptions(string httpApiId, string operationId, UpdateHttpApiOperationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["operation"] = request.Operation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHttpApiOperationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新Operation
         *
         * @param request UpdateHttpApiOperationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHttpApiOperationResponse
         */
        public async Task<UpdateHttpApiOperationResponse> UpdateHttpApiOperationWithOptionsAsync(string httpApiId, string operationId, UpdateHttpApiOperationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                body["operation"] = request.Operation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHttpApiOperation",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/http-apis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(httpApiId) + "/operations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHttpApiOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新Operation
         *
         * @param request UpdateHttpApiOperationRequest
         * @return UpdateHttpApiOperationResponse
         */
        public UpdateHttpApiOperationResponse UpdateHttpApiOperation(string httpApiId, string operationId, UpdateHttpApiOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateHttpApiOperationWithOptions(httpApiId, operationId, request, headers, runtime);
        }

        /**
         * @summary 更新Operation
         *
         * @param request UpdateHttpApiOperationRequest
         * @return UpdateHttpApiOperationResponse
         */
        public async Task<UpdateHttpApiOperationResponse> UpdateHttpApiOperationAsync(string httpApiId, string operationId, UpdateHttpApiOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateHttpApiOperationWithOptionsAsync(httpApiId, operationId, request, headers, runtime);
        }

        /**
         * @summary 更新服务来源
         *
         * @param request UpdateServiceSourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceSourceResponse
         */
        public UpdateServiceSourceResponse UpdateServiceSourceWithOptions(string gatewayId, string serviceSourceId, UpdateServiceSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sServiceSourceConfig))
            {
                body["k8sServiceSourceConfig"] = request.K8sServiceSourceConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/service-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceSourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新服务来源
         *
         * @param request UpdateServiceSourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceSourceResponse
         */
        public async Task<UpdateServiceSourceResponse> UpdateServiceSourceWithOptionsAsync(string gatewayId, string serviceSourceId, UpdateServiceSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.K8sServiceSourceConfig))
            {
                body["k8sServiceSourceConfig"] = request.K8sServiceSourceConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceSource",
                Version = "2024-03-27",
                Protocol = "HTTPS",
                Pathname = "/v1/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(gatewayId) + "/service-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceSourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新服务来源
         *
         * @param request UpdateServiceSourceRequest
         * @return UpdateServiceSourceResponse
         */
        public UpdateServiceSourceResponse UpdateServiceSource(string gatewayId, string serviceSourceId, UpdateServiceSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceSourceWithOptions(gatewayId, serviceSourceId, request, headers, runtime);
        }

        /**
         * @summary 更新服务来源
         *
         * @param request UpdateServiceSourceRequest
         * @return UpdateServiceSourceResponse
         */
        public async Task<UpdateServiceSourceResponse> UpdateServiceSourceAsync(string gatewayId, string serviceSourceId, UpdateServiceSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceSourceWithOptionsAsync(gatewayId, serviceSourceId, request, headers, runtime);
        }

    }
}
