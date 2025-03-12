// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ddoscoo20171228.Models;

namespace AlibabaCloud.SDK.Ddoscoo20171228
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ddoscoo", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <param name="request">
        /// AddLayer7CCRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddLayer7CCRuleResponse
        /// </returns>
        public AddLayer7CCRuleResponse AddLayer7CCRuleWithOptions(AddLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Act))
            {
                query["Act"] = request.Act;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                query["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLayer7CCRule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddLayer7CCRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddLayer7CCRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// AddLayer7CCRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddLayer7CCRuleResponse
        /// </returns>
        public async Task<AddLayer7CCRuleResponse> AddLayer7CCRuleWithOptionsAsync(AddLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Act))
            {
                query["Act"] = request.Act;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                query["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLayer7CCRule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddLayer7CCRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddLayer7CCRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// AddLayer7CCRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// AddLayer7CCRuleResponse
        /// </returns>
        public AddLayer7CCRuleResponse AddLayer7CCRule(AddLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLayer7CCRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddLayer7CCRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// AddLayer7CCRuleResponse
        /// </returns>
        public async Task<AddLayer7CCRuleResponse> AddLayer7CCRuleAsync(AddLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLayer7CCRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CloseDomainSlsConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseDomainSlsConfigResponse
        /// </returns>
        public CloseDomainSlsConfigResponse CloseDomainSlsConfigWithOptions(CloseDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseDomainSlsConfig",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CloseDomainSlsConfigResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CloseDomainSlsConfigResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// CloseDomainSlsConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseDomainSlsConfigResponse
        /// </returns>
        public async Task<CloseDomainSlsConfigResponse> CloseDomainSlsConfigWithOptionsAsync(CloseDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseDomainSlsConfig",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CloseDomainSlsConfigResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CloseDomainSlsConfigResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// CloseDomainSlsConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseDomainSlsConfigResponse
        /// </returns>
        public CloseDomainSlsConfigResponse CloseDomainSlsConfig(CloseDomainSlsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseDomainSlsConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CloseDomainSlsConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseDomainSlsConfigResponse
        /// </returns>
        public async Task<CloseDomainSlsConfigResponse> CloseDomainSlsConfigAsync(CloseDomainSlsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseDomainSlsConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ConfigHealthCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigHealthCheckResponse
        /// </returns>
        public ConfigHealthCheckResponse ConfigHealthCheckWithOptions(ConfigHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardProtocol))
            {
                query["ForwardProtocol"] = request.ForwardProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrontendPort))
            {
                query["FrontendPort"] = request.FrontendPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigHealthCheck",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigHealthCheckResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigHealthCheckResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigHealthCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigHealthCheckResponse
        /// </returns>
        public async Task<ConfigHealthCheckResponse> ConfigHealthCheckWithOptionsAsync(ConfigHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardProtocol))
            {
                query["ForwardProtocol"] = request.ForwardProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrontendPort))
            {
                query["FrontendPort"] = request.FrontendPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheck))
            {
                query["HealthCheck"] = request.HealthCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigHealthCheck",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigHealthCheckResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigHealthCheckResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigHealthCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigHealthCheckResponse
        /// </returns>
        public ConfigHealthCheckResponse ConfigHealthCheck(ConfigHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigHealthCheckWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ConfigHealthCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigHealthCheckResponse
        /// </returns>
        public async Task<ConfigHealthCheckResponse> ConfigHealthCheckAsync(ConfigHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigHealthCheckWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer4RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer4RuleResponse
        /// </returns>
        public ConfigLayer4RuleResponse ConfigLayer4RuleWithOptions(ConfigLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyEnable))
            {
                query["ProxyEnable"] = request.ProxyEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer4Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer4RuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer4RuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer4RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer4RuleResponse
        /// </returns>
        public async Task<ConfigLayer4RuleResponse> ConfigLayer4RuleWithOptionsAsync(ConfigLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyEnable))
            {
                query["ProxyEnable"] = request.ProxyEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer4Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer4RuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer4RuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer4RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer4RuleResponse
        /// </returns>
        public ConfigLayer4RuleResponse ConfigLayer4Rule(ConfigLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer4RuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer4RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer4RuleResponse
        /// </returns>
        public async Task<ConfigLayer4RuleResponse> ConfigLayer4RuleAsync(ConfigLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer4RuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer4RuleAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer4RuleAttributeResponse
        /// </returns>
        public ConfigLayer4RuleAttributeResponse ConfigLayer4RuleAttributeWithOptions(ConfigLayer4RuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardProtocol))
            {
                query["ForwardProtocol"] = request.ForwardProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrontendPort))
            {
                query["FrontendPort"] = request.FrontendPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer4RuleAttribute",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer4RuleAttributeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer4RuleAttributeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer4RuleAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer4RuleAttributeResponse
        /// </returns>
        public async Task<ConfigLayer4RuleAttributeResponse> ConfigLayer4RuleAttributeWithOptionsAsync(ConfigLayer4RuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardProtocol))
            {
                query["ForwardProtocol"] = request.ForwardProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrontendPort))
            {
                query["FrontendPort"] = request.FrontendPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer4RuleAttribute",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer4RuleAttributeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer4RuleAttributeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer4RuleAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer4RuleAttributeResponse
        /// </returns>
        public ConfigLayer4RuleAttributeResponse ConfigLayer4RuleAttribute(ConfigLayer4RuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer4RuleAttributeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer4RuleAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer4RuleAttributeResponse
        /// </returns>
        public async Task<ConfigLayer4RuleAttributeResponse> ConfigLayer4RuleAttributeAsync(ConfigLayer4RuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer4RuleAttributeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer7BlackWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7BlackWhiteListResponse
        /// </returns>
        public ConfigLayer7BlackWhiteListResponse ConfigLayer7BlackWhiteListWithOptions(ConfigLayer7BlackWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackList))
            {
                query["BlackList"] = request.BlackList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteList))
            {
                query["WhiteList"] = request.WhiteList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer7BlackWhiteList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer7BlackWhiteListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer7BlackWhiteListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer7BlackWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7BlackWhiteListResponse
        /// </returns>
        public async Task<ConfigLayer7BlackWhiteListResponse> ConfigLayer7BlackWhiteListWithOptionsAsync(ConfigLayer7BlackWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackList))
            {
                query["BlackList"] = request.BlackList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteList))
            {
                query["WhiteList"] = request.WhiteList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer7BlackWhiteList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer7BlackWhiteListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer7BlackWhiteListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer7BlackWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7BlackWhiteListResponse
        /// </returns>
        public ConfigLayer7BlackWhiteListResponse ConfigLayer7BlackWhiteList(ConfigLayer7BlackWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer7BlackWhiteListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer7BlackWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7BlackWhiteListResponse
        /// </returns>
        public async Task<ConfigLayer7BlackWhiteListResponse> ConfigLayer7BlackWhiteListAsync(ConfigLayer7BlackWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer7BlackWhiteListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer7CCRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CCRuleResponse
        /// </returns>
        public ConfigLayer7CCRuleResponse ConfigLayer7CCRuleWithOptions(ConfigLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Act))
            {
                query["Act"] = request.Act;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                query["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer7CCRule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer7CCRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer7CCRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer7CCRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CCRuleResponse
        /// </returns>
        public async Task<ConfigLayer7CCRuleResponse> ConfigLayer7CCRuleWithOptionsAsync(ConfigLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Act))
            {
                query["Act"] = request.Act;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                query["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer7CCRule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer7CCRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer7CCRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer7CCRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CCRuleResponse
        /// </returns>
        public ConfigLayer7CCRuleResponse ConfigLayer7CCRule(ConfigLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer7CCRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer7CCRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CCRuleResponse
        /// </returns>
        public async Task<ConfigLayer7CCRuleResponse> ConfigLayer7CCRuleAsync(ConfigLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer7CCRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer7CCTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CCTemplateResponse
        /// </returns>
        public ConfigLayer7CCTemplateResponse ConfigLayer7CCTemplateWithOptions(ConfigLayer7CCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                query["Template"] = request.Template;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer7CCTemplate",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer7CCTemplateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer7CCTemplateResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer7CCTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CCTemplateResponse
        /// </returns>
        public async Task<ConfigLayer7CCTemplateResponse> ConfigLayer7CCTemplateWithOptionsAsync(ConfigLayer7CCTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                query["Template"] = request.Template;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer7CCTemplate",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer7CCTemplateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer7CCTemplateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer7CCTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CCTemplateResponse
        /// </returns>
        public ConfigLayer7CCTemplateResponse ConfigLayer7CCTemplate(ConfigLayer7CCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer7CCTemplateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer7CCTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CCTemplateResponse
        /// </returns>
        public async Task<ConfigLayer7CCTemplateResponse> ConfigLayer7CCTemplateAsync(ConfigLayer7CCTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer7CCTemplateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer7CertRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CertResponse
        /// </returns>
        public ConfigLayer7CertResponse ConfigLayer7CertWithOptions(ConfigLayer7CertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cert))
            {
                query["Cert"] = request.Cert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRegion))
            {
                query["CertRegion"] = request.CertRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer7Cert",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer7CertResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer7CertResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer7CertRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CertResponse
        /// </returns>
        public async Task<ConfigLayer7CertResponse> ConfigLayer7CertWithOptionsAsync(ConfigLayer7CertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cert))
            {
                query["Cert"] = request.Cert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRegion))
            {
                query["CertRegion"] = request.CertRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer7Cert",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer7CertResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer7CertResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer7CertRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CertResponse
        /// </returns>
        public ConfigLayer7CertResponse ConfigLayer7Cert(ConfigLayer7CertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer7CertWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer7CertRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7CertResponse
        /// </returns>
        public async Task<ConfigLayer7CertResponse> ConfigLayer7CertAsync(ConfigLayer7CertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer7CertWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer7RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7RuleResponse
        /// </returns>
        public ConfigLayer7RuleResponse ConfigLayer7RuleWithOptions(ConfigLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyTypeList))
            {
                query["ProxyTypeList"] = request.ProxyTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyTypes))
            {
                query["ProxyTypes"] = request.ProxyTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealServers))
            {
                query["RealServers"] = request.RealServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RsType))
            {
                query["RsType"] = request.RsType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer7Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer7RuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer7RuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer7RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7RuleResponse
        /// </returns>
        public async Task<ConfigLayer7RuleResponse> ConfigLayer7RuleWithOptionsAsync(ConfigLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyTypeList))
            {
                query["ProxyTypeList"] = request.ProxyTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyTypes))
            {
                query["ProxyTypes"] = request.ProxyTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealServers))
            {
                query["RealServers"] = request.RealServers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RsType))
            {
                query["RsType"] = request.RsType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigLayer7Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ConfigLayer7RuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConfigLayer7RuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ConfigLayer7RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7RuleResponse
        /// </returns>
        public ConfigLayer7RuleResponse ConfigLayer7Rule(ConfigLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigLayer7RuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ConfigLayer7RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigLayer7RuleResponse
        /// </returns>
        public async Task<ConfigLayer7RuleResponse> ConfigLayer7RuleAsync(ConfigLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigLayer7RuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAsyncTaskResponse
        /// </returns>
        public CreateAsyncTaskResponse CreateAsyncTaskWithOptions(CreateAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskParams))
            {
                query["TaskParams"] = request.TaskParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAsyncTask",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateAsyncTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAsyncTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// CreateAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAsyncTaskResponse
        /// </returns>
        public async Task<CreateAsyncTaskResponse> CreateAsyncTaskWithOptionsAsync(CreateAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskParams))
            {
                query["TaskParams"] = request.TaskParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAsyncTask",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAsyncTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// CreateAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAsyncTaskResponse
        /// </returns>
        public CreateAsyncTaskResponse CreateAsyncTask(CreateAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAsyncTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAsyncTaskResponse
        /// </returns>
        public async Task<CreateAsyncTaskResponse> CreateAsyncTaskAsync(CreateAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAsyncTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateLayer4RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLayer4RuleResponse
        /// </returns>
        public CreateLayer4RuleResponse CreateLayer4RuleWithOptions(CreateLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyEnable))
            {
                query["ProxyEnable"] = request.ProxyEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLayer4Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateLayer4RuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateLayer4RuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// CreateLayer4RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLayer4RuleResponse
        /// </returns>
        public async Task<CreateLayer4RuleResponse> CreateLayer4RuleWithOptionsAsync(CreateLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyEnable))
            {
                query["ProxyEnable"] = request.ProxyEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLayer4Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateLayer4RuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateLayer4RuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// CreateLayer4RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLayer4RuleResponse
        /// </returns>
        public CreateLayer4RuleResponse CreateLayer4Rule(CreateLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLayer4RuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateLayer4RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLayer4RuleResponse
        /// </returns>
        public async Task<CreateLayer4RuleResponse> CreateLayer4RuleAsync(CreateLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLayer4RuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateLayer7RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLayer7RuleResponse
        /// </returns>
        public CreateLayer7RuleResponse CreateLayer7RuleWithOptions(CreateLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RsType))
            {
                query["RsType"] = request.RsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLayer7Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateLayer7RuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateLayer7RuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// CreateLayer7RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLayer7RuleResponse
        /// </returns>
        public async Task<CreateLayer7RuleResponse> CreateLayer7RuleWithOptionsAsync(CreateLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RsType))
            {
                query["RsType"] = request.RsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLayer7Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateLayer7RuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateLayer7RuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// CreateLayer7RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLayer7RuleResponse
        /// </returns>
        public CreateLayer7RuleResponse CreateLayer7Rule(CreateLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLayer7RuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateLayer7RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLayer7RuleResponse
        /// </returns>
        public async Task<CreateLayer7RuleResponse> CreateLayer7RuleAsync(CreateLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLayer7RuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAsyncTaskResponse
        /// </returns>
        public DeleteAsyncTaskResponse DeleteAsyncTaskWithOptions(DeleteAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAsyncTask",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteAsyncTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAsyncTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DeleteAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAsyncTaskResponse
        /// </returns>
        public async Task<DeleteAsyncTaskResponse> DeleteAsyncTaskWithOptionsAsync(DeleteAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAsyncTask",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAsyncTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DeleteAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAsyncTaskResponse
        /// </returns>
        public DeleteAsyncTaskResponse DeleteAsyncTask(DeleteAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAsyncTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAsyncTaskResponse
        /// </returns>
        public async Task<DeleteAsyncTaskResponse> DeleteAsyncTaskAsync(DeleteAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAsyncTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteLayer4RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer4RuleResponse
        /// </returns>
        public DeleteLayer4RuleResponse DeleteLayer4RuleWithOptions(DeleteLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayer4Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteLayer4RuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteLayer4RuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DeleteLayer4RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer4RuleResponse
        /// </returns>
        public async Task<DeleteLayer4RuleResponse> DeleteLayer4RuleWithOptionsAsync(DeleteLayer4RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayer4Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteLayer4RuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteLayer4RuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DeleteLayer4RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer4RuleResponse
        /// </returns>
        public DeleteLayer4RuleResponse DeleteLayer4Rule(DeleteLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLayer4RuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteLayer4RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer4RuleResponse
        /// </returns>
        public async Task<DeleteLayer4RuleResponse> DeleteLayer4RuleAsync(DeleteLayer4RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLayer4RuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteLayer7CCRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer7CCRuleResponse
        /// </returns>
        public DeleteLayer7CCRuleResponse DeleteLayer7CCRuleWithOptions(DeleteLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayer7CCRule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteLayer7CCRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteLayer7CCRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DeleteLayer7CCRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer7CCRuleResponse
        /// </returns>
        public async Task<DeleteLayer7CCRuleResponse> DeleteLayer7CCRuleWithOptionsAsync(DeleteLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayer7CCRule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteLayer7CCRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteLayer7CCRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DeleteLayer7CCRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer7CCRuleResponse
        /// </returns>
        public DeleteLayer7CCRuleResponse DeleteLayer7CCRule(DeleteLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLayer7CCRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteLayer7CCRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer7CCRuleResponse
        /// </returns>
        public async Task<DeleteLayer7CCRuleResponse> DeleteLayer7CCRuleAsync(DeleteLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLayer7CCRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteLayer7RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer7RuleResponse
        /// </returns>
        public DeleteLayer7RuleResponse DeleteLayer7RuleWithOptions(DeleteLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayer7Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteLayer7RuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteLayer7RuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DeleteLayer7RuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer7RuleResponse
        /// </returns>
        public async Task<DeleteLayer7RuleResponse> DeleteLayer7RuleWithOptionsAsync(DeleteLayer7RuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayer7Rule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteLayer7RuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteLayer7RuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DeleteLayer7RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer7RuleResponse
        /// </returns>
        public DeleteLayer7RuleResponse DeleteLayer7Rule(DeleteLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLayer7RuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteLayer7RuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayer7RuleResponse
        /// </returns>
        public async Task<DeleteLayer7RuleResponse> DeleteLayer7RuleAsync(DeleteLayer7RuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLayer7RuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeBackSourceCidrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackSourceCidrResponse
        /// </returns>
        public DescribeBackSourceCidrResponse DescribeBackSourceCidrWithOptions(DescribeBackSourceCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackSourceCidr",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeBackSourceCidrResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeBackSourceCidrResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeBackSourceCidrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackSourceCidrResponse
        /// </returns>
        public async Task<DescribeBackSourceCidrResponse> DescribeBackSourceCidrWithOptionsAsync(DescribeBackSourceCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackSourceCidr",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeBackSourceCidrResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeBackSourceCidrResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeBackSourceCidrRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackSourceCidrResponse
        /// </returns>
        public DescribeBackSourceCidrResponse DescribeBackSourceCidr(DescribeBackSourceCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackSourceCidrWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeBackSourceCidrRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackSourceCidrResponse
        /// </returns>
        public async Task<DescribeBackSourceCidrResponse> DescribeBackSourceCidrAsync(DescribeBackSourceCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackSourceCidrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>rosetta迁移</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBatchSlsDispatchStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBatchSlsDispatchStatusResponse
        /// </returns>
        public DescribeBatchSlsDispatchStatusResponse DescribeBatchSlsDispatchStatusWithOptions(DescribeBatchSlsDispatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBatchSlsDispatchStatus",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeBatchSlsDispatchStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeBatchSlsDispatchStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>rosetta迁移</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBatchSlsDispatchStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBatchSlsDispatchStatusResponse
        /// </returns>
        public async Task<DescribeBatchSlsDispatchStatusResponse> DescribeBatchSlsDispatchStatusWithOptionsAsync(DescribeBatchSlsDispatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBatchSlsDispatchStatus",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeBatchSlsDispatchStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeBatchSlsDispatchStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>rosetta迁移</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBatchSlsDispatchStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBatchSlsDispatchStatusResponse
        /// </returns>
        public DescribeBatchSlsDispatchStatusResponse DescribeBatchSlsDispatchStatus(DescribeBatchSlsDispatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBatchSlsDispatchStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>rosetta迁移</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBatchSlsDispatchStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBatchSlsDispatchStatusResponse
        /// </returns>
        public async Task<DescribeBatchSlsDispatchStatusResponse> DescribeBatchSlsDispatchStatusAsync(DescribeBatchSlsDispatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBatchSlsDispatchStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDDoSEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSEventsResponse
        /// </returns>
        public DescribeDDoSEventsResponse DescribeDDoSEventsWithOptions(DescribeDDoSEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Eip))
            {
                query["Eip"] = request.Eip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDDoSEvents",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDDoSEventsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDDoSEventsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDDoSEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSEventsResponse
        /// </returns>
        public async Task<DescribeDDoSEventsResponse> DescribeDDoSEventsWithOptionsAsync(DescribeDDoSEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Eip))
            {
                query["Eip"] = request.Eip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDDoSEvents",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDDoSEventsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDDoSEventsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDDoSEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSEventsResponse
        /// </returns>
        public DescribeDDoSEventsResponse DescribeDDoSEvents(DescribeDDoSEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDoSEventsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDDoSEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSEventsResponse
        /// </returns>
        public async Task<DescribeDDoSEventsResponse> DescribeDDoSEventsAsync(DescribeDDoSEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDoSEventsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDDoSTrafficRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSTrafficResponse
        /// </returns>
        public DescribeDDoSTrafficResponse DescribeDDoSTrafficWithOptions(DescribeDDoSTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Eip))
            {
                query["Eip"] = request.Eip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDDoSTraffic",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDDoSTrafficResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDDoSTrafficResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDDoSTrafficRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSTrafficResponse
        /// </returns>
        public async Task<DescribeDDoSTrafficResponse> DescribeDDoSTrafficWithOptionsAsync(DescribeDDoSTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Eip))
            {
                query["Eip"] = request.Eip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDDoSTraffic",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDDoSTrafficResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDDoSTrafficResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDDoSTrafficRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSTrafficResponse
        /// </returns>
        public DescribeDDoSTrafficResponse DescribeDDoSTraffic(DescribeDDoSTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDoSTrafficWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDDoSTrafficRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDDoSTrafficResponse
        /// </returns>
        public async Task<DescribeDDoSTrafficResponse> DescribeDDoSTrafficAsync(DescribeDDoSTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDoSTrafficWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDefenseCountStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDefenseCountStatisticsResponse
        /// </returns>
        public DescribeDefenseCountStatisticsResponse DescribeDefenseCountStatisticsWithOptions(DescribeDefenseCountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseCountStatistics",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDefenseCountStatisticsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDefenseCountStatisticsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDefenseCountStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDefenseCountStatisticsResponse
        /// </returns>
        public async Task<DescribeDefenseCountStatisticsResponse> DescribeDefenseCountStatisticsWithOptionsAsync(DescribeDefenseCountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseCountStatistics",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDefenseCountStatisticsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDefenseCountStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDefenseCountStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDefenseCountStatisticsResponse
        /// </returns>
        public DescribeDefenseCountStatisticsResponse DescribeDefenseCountStatistics(DescribeDefenseCountStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseCountStatisticsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDefenseCountStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDefenseCountStatisticsResponse
        /// </returns>
        public async Task<DescribeDefenseCountStatisticsResponse> DescribeDefenseCountStatisticsAsync(DescribeDefenseCountStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseCountStatisticsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainAccessModeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAccessModeResponse
        /// </returns>
        public DescribeDomainAccessModeResponse DescribeDomainAccessModeWithOptions(DescribeDomainAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainList))
            {
                query["DomainList"] = request.DomainList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainAccessMode",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainAccessModeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainAccessModeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainAccessModeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAccessModeResponse
        /// </returns>
        public async Task<DescribeDomainAccessModeResponse> DescribeDomainAccessModeWithOptionsAsync(DescribeDomainAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainList))
            {
                query["DomainList"] = request.DomainList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainAccessMode",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainAccessModeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainAccessModeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainAccessModeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAccessModeResponse
        /// </returns>
        public DescribeDomainAccessModeResponse DescribeDomainAccessMode(DescribeDomainAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainAccessModeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainAccessModeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAccessModeResponse
        /// </returns>
        public async Task<DescribeDomainAccessModeResponse> DescribeDomainAccessModeAsync(DescribeDomainAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainAccessModeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainAttackEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAttackEventListResponse
        /// </returns>
        public DescribeDomainAttackEventListResponse DescribeDomainAttackEventListWithOptions(DescribeDomainAttackEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainAttackEventList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainAttackEventListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainAttackEventListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainAttackEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAttackEventListResponse
        /// </returns>
        public async Task<DescribeDomainAttackEventListResponse> DescribeDomainAttackEventListWithOptionsAsync(DescribeDomainAttackEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainAttackEventList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainAttackEventListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainAttackEventListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainAttackEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAttackEventListResponse
        /// </returns>
        public DescribeDomainAttackEventListResponse DescribeDomainAttackEventList(DescribeDomainAttackEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainAttackEventListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainAttackEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAttackEventListResponse
        /// </returns>
        public async Task<DescribeDomainAttackEventListResponse> DescribeDomainAttackEventListAsync(DescribeDomainAttackEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainAttackEventListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainAttackMaxQpsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAttackMaxQpsResponse
        /// </returns>
        public DescribeDomainAttackMaxQpsResponse DescribeDomainAttackMaxQpsWithOptions(DescribeDomainAttackMaxQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainAttackMaxQps",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainAttackMaxQpsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainAttackMaxQpsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainAttackMaxQpsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAttackMaxQpsResponse
        /// </returns>
        public async Task<DescribeDomainAttackMaxQpsResponse> DescribeDomainAttackMaxQpsWithOptionsAsync(DescribeDomainAttackMaxQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainAttackMaxQps",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainAttackMaxQpsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainAttackMaxQpsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainAttackMaxQpsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAttackMaxQpsResponse
        /// </returns>
        public DescribeDomainAttackMaxQpsResponse DescribeDomainAttackMaxQps(DescribeDomainAttackMaxQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainAttackMaxQpsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainAttackMaxQpsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainAttackMaxQpsResponse
        /// </returns>
        public async Task<DescribeDomainAttackMaxQpsResponse> DescribeDomainAttackMaxQpsAsync(DescribeDomainAttackMaxQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainAttackMaxQpsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainOverviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainOverviewResponse
        /// </returns>
        public DescribeDomainOverviewResponse DescribeDomainOverviewWithOptions(DescribeDomainOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainOverview",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainOverviewResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainOverviewResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainOverviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainOverviewResponse
        /// </returns>
        public async Task<DescribeDomainOverviewResponse> DescribeDomainOverviewWithOptionsAsync(DescribeDomainOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainOverview",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainOverviewResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainOverviewResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainOverviewResponse
        /// </returns>
        public DescribeDomainOverviewResponse DescribeDomainOverview(DescribeDomainOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainOverviewWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainOverviewResponse
        /// </returns>
        public async Task<DescribeDomainOverviewResponse> DescribeDomainOverviewAsync(DescribeDomainOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainOverviewWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainQpsListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainQpsListResponse
        /// </returns>
        public DescribeDomainQpsListResponse DescribeDomainQpsListWithOptions(DescribeDomainQpsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainQpsList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainQpsListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainQpsListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainQpsListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainQpsListResponse
        /// </returns>
        public async Task<DescribeDomainQpsListResponse> DescribeDomainQpsListWithOptionsAsync(DescribeDomainQpsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainQpsList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainQpsListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainQpsListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainQpsListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainQpsListResponse
        /// </returns>
        public DescribeDomainQpsListResponse DescribeDomainQpsList(DescribeDomainQpsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainQpsListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainQpsListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainQpsListResponse
        /// </returns>
        public async Task<DescribeDomainQpsListResponse> DescribeDomainQpsListAsync(DescribeDomainQpsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainQpsListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainQpsWithCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainQpsWithCacheResponse
        /// </returns>
        public DescribeDomainQpsWithCacheResponse DescribeDomainQpsWithCacheWithOptions(DescribeDomainQpsWithCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainQpsWithCache",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainQpsWithCacheResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainQpsWithCacheResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainQpsWithCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainQpsWithCacheResponse
        /// </returns>
        public async Task<DescribeDomainQpsWithCacheResponse> DescribeDomainQpsWithCacheWithOptionsAsync(DescribeDomainQpsWithCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainQpsWithCache",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainQpsWithCacheResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainQpsWithCacheResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainQpsWithCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainQpsWithCacheResponse
        /// </returns>
        public DescribeDomainQpsWithCacheResponse DescribeDomainQpsWithCache(DescribeDomainQpsWithCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainQpsWithCacheWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainQpsWithCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainQpsWithCacheResponse
        /// </returns>
        public async Task<DescribeDomainQpsWithCacheResponse> DescribeDomainQpsWithCacheAsync(DescribeDomainQpsWithCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainQpsWithCacheWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainSlsStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainSlsStatusResponse
        /// </returns>
        public DescribeDomainSlsStatusResponse DescribeDomainSlsStatusWithOptions(DescribeDomainSlsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainSlsStatus",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainSlsStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainSlsStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainSlsStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainSlsStatusResponse
        /// </returns>
        public async Task<DescribeDomainSlsStatusResponse> DescribeDomainSlsStatusWithOptionsAsync(DescribeDomainSlsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainSlsStatus",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainSlsStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainSlsStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainSlsStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainSlsStatusResponse
        /// </returns>
        public DescribeDomainSlsStatusResponse DescribeDomainSlsStatus(DescribeDomainSlsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSlsStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainSlsStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainSlsStatusResponse
        /// </returns>
        public async Task<DescribeDomainSlsStatusResponse> DescribeDomainSlsStatusAsync(DescribeDomainSlsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSlsStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网站业务的响应状态码统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainStatusCodeListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainStatusCodeListResponse
        /// </returns>
        public DescribeDomainStatusCodeListResponse DescribeDomainStatusCodeListWithOptions(DescribeDomainStatusCodeListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainStatusCodeList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainStatusCodeListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainStatusCodeListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网站业务的响应状态码统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainStatusCodeListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainStatusCodeListResponse
        /// </returns>
        public async Task<DescribeDomainStatusCodeListResponse> DescribeDomainStatusCodeListWithOptionsAsync(DescribeDomainStatusCodeListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainStatusCodeList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainStatusCodeListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainStatusCodeListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网站业务的响应状态码统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainStatusCodeListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainStatusCodeListResponse
        /// </returns>
        public DescribeDomainStatusCodeListResponse DescribeDomainStatusCodeList(DescribeDomainStatusCodeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainStatusCodeListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询网站业务的响应状态码统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainStatusCodeListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainStatusCodeListResponse
        /// </returns>
        public async Task<DescribeDomainStatusCodeListResponse> DescribeDomainStatusCodeListAsync(DescribeDomainStatusCodeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainStatusCodeListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainsResponse
        /// </returns>
        public DescribeDomainsResponse DescribeDomainsWithOptions(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDomainPattern))
            {
                query["QueryDomainPattern"] = request.QueryDomainPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomains",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainsResponse
        /// </returns>
        public async Task<DescribeDomainsResponse> DescribeDomainsWithOptionsAsync(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDomainPattern))
            {
                query["QueryDomainPattern"] = request.QueryDomainPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomains",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDomainsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDomainsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainsResponse
        /// </returns>
        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainsResponse
        /// </returns>
        public async Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeElasticBandwidthSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeElasticBandwidthSpecResponse
        /// </returns>
        public DescribeElasticBandwidthSpecResponse DescribeElasticBandwidthSpecWithOptions(DescribeElasticBandwidthSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeElasticBandwidthSpec",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeElasticBandwidthSpecResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeElasticBandwidthSpecResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeElasticBandwidthSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeElasticBandwidthSpecResponse
        /// </returns>
        public async Task<DescribeElasticBandwidthSpecResponse> DescribeElasticBandwidthSpecWithOptionsAsync(DescribeElasticBandwidthSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeElasticBandwidthSpec",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeElasticBandwidthSpecResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeElasticBandwidthSpecResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeElasticBandwidthSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeElasticBandwidthSpecResponse
        /// </returns>
        public DescribeElasticBandwidthSpecResponse DescribeElasticBandwidthSpec(DescribeElasticBandwidthSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeElasticBandwidthSpecWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeElasticBandwidthSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeElasticBandwidthSpecResponse
        /// </returns>
        public async Task<DescribeElasticBandwidthSpecResponse> DescribeElasticBandwidthSpecAsync(DescribeElasticBandwidthSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeElasticBandwidthSpecWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeHealthCheckListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthCheckListResponse
        /// </returns>
        public DescribeHealthCheckListResponse DescribeHealthCheckListWithOptions(DescribeHealthCheckListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHealthCheckList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeHealthCheckListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeHealthCheckListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeHealthCheckListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthCheckListResponse
        /// </returns>
        public async Task<DescribeHealthCheckListResponse> DescribeHealthCheckListWithOptionsAsync(DescribeHealthCheckListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHealthCheckList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeHealthCheckListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeHealthCheckListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeHealthCheckListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthCheckListResponse
        /// </returns>
        public DescribeHealthCheckListResponse DescribeHealthCheckList(DescribeHealthCheckListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthCheckListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeHealthCheckListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthCheckListResponse
        /// </returns>
        public async Task<DescribeHealthCheckListResponse> DescribeHealthCheckListAsync(DescribeHealthCheckListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthCheckListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeHealthCheckStatusListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthCheckStatusListResponse
        /// </returns>
        public DescribeHealthCheckStatusListResponse DescribeHealthCheckStatusListWithOptions(DescribeHealthCheckStatusListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHealthCheckStatusList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeHealthCheckStatusListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeHealthCheckStatusListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeHealthCheckStatusListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthCheckStatusListResponse
        /// </returns>
        public async Task<DescribeHealthCheckStatusListResponse> DescribeHealthCheckStatusListWithOptionsAsync(DescribeHealthCheckStatusListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHealthCheckStatusList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeHealthCheckStatusListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeHealthCheckStatusListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeHealthCheckStatusListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthCheckStatusListResponse
        /// </returns>
        public DescribeHealthCheckStatusListResponse DescribeHealthCheckStatusList(DescribeHealthCheckStatusListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthCheckStatusListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeHealthCheckStatusListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHealthCheckStatusListResponse
        /// </returns>
        public async Task<DescribeHealthCheckStatusListResponse> DescribeHealthCheckStatusListAsync(DescribeHealthCheckStatusListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthCheckStatusListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeInstanceDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDetailsResponse
        /// </returns>
        public DescribeInstanceDetailsResponse DescribeInstanceDetailsWithOptions(DescribeInstanceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceDetails",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstanceDetailsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstanceDetailsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeInstanceDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDetailsResponse
        /// </returns>
        public async Task<DescribeInstanceDetailsResponse> DescribeInstanceDetailsWithOptionsAsync(DescribeInstanceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceDetails",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstanceDetailsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstanceDetailsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeInstanceDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDetailsResponse
        /// </returns>
        public DescribeInstanceDetailsResponse DescribeInstanceDetails(DescribeInstanceDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceDetailsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeInstanceDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDetailsResponse
        /// </returns>
        public async Task<DescribeInstanceDetailsResponse> DescribeInstanceDetailsAsync(DescribeInstanceDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceDetailsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeInstanceSpecsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceSpecsResponse
        /// </returns>
        public DescribeInstanceSpecsResponse DescribeInstanceSpecsWithOptions(DescribeInstanceSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSpecs",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstanceSpecsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstanceSpecsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeInstanceSpecsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceSpecsResponse
        /// </returns>
        public async Task<DescribeInstanceSpecsResponse> DescribeInstanceSpecsWithOptionsAsync(DescribeInstanceSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSpecs",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstanceSpecsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstanceSpecsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeInstanceSpecsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceSpecsResponse
        /// </returns>
        public DescribeInstanceSpecsResponse DescribeInstanceSpecs(DescribeInstanceSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSpecsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeInstanceSpecsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceSpecsResponse
        /// </returns>
        public async Task<DescribeInstanceSpecsResponse> DescribeInstanceSpecsAsync(DescribeInstanceSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSpecsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeInstanceStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceStatisticsResponse
        /// </returns>
        public DescribeInstanceStatisticsResponse DescribeInstanceStatisticsWithOptions(DescribeInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceStatistics",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeInstanceStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceStatisticsResponse
        /// </returns>
        public async Task<DescribeInstanceStatisticsResponse> DescribeInstanceStatisticsWithOptionsAsync(DescribeInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceStatistics",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstanceStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeInstanceStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceStatisticsResponse
        /// </returns>
        public DescribeInstanceStatisticsResponse DescribeInstanceStatistics(DescribeInstanceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceStatisticsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeInstanceStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceStatisticsResponse
        /// </returns>
        public async Task<DescribeInstanceStatisticsResponse> DescribeInstanceStatisticsAsync(DescribeInstanceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceStatisticsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Edition))
            {
                query["Edition"] = request.Edition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireEndTime))
            {
                query["ExpireEndTime"] = request.ExpireEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireStartTime))
            {
                query["ExpireStartTime"] = request.ExpireStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeInstances",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Edition))
            {
                query["Edition"] = request.Edition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireEndTime))
            {
                query["ExpireEndTime"] = request.ExpireEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireStartTime))
            {
                query["ExpireStartTime"] = request.ExpireStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeInstances",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeIpTrafficRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpTrafficResponse
        /// </returns>
        public DescribeIpTrafficResponse DescribeIpTrafficWithOptions(DescribeIpTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Eip))
            {
                query["Eip"] = request.Eip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryProtocol))
            {
                query["QueryProtocol"] = request.QueryProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpTraffic",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeIpTrafficResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeIpTrafficResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeIpTrafficRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpTrafficResponse
        /// </returns>
        public async Task<DescribeIpTrafficResponse> DescribeIpTrafficWithOptionsAsync(DescribeIpTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Eip))
            {
                query["Eip"] = request.Eip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryProtocol))
            {
                query["QueryProtocol"] = request.QueryProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpTraffic",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeIpTrafficResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeIpTrafficResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeIpTrafficRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpTrafficResponse
        /// </returns>
        public DescribeIpTrafficResponse DescribeIpTraffic(DescribeIpTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpTrafficWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeIpTrafficRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpTrafficResponse
        /// </returns>
        public async Task<DescribeIpTrafficResponse> DescribeIpTrafficAsync(DescribeIpTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpTrafficWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeLayer4RuleAttributesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer4RuleAttributesResponse
        /// </returns>
        public DescribeLayer4RuleAttributesResponse DescribeLayer4RuleAttributesWithOptions(DescribeLayer4RuleAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLayer4RuleAttributes",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeLayer4RuleAttributesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeLayer4RuleAttributesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeLayer4RuleAttributesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer4RuleAttributesResponse
        /// </returns>
        public async Task<DescribeLayer4RuleAttributesResponse> DescribeLayer4RuleAttributesWithOptionsAsync(DescribeLayer4RuleAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Listeners))
            {
                query["Listeners"] = request.Listeners;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLayer4RuleAttributes",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeLayer4RuleAttributesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeLayer4RuleAttributesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeLayer4RuleAttributesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer4RuleAttributesResponse
        /// </returns>
        public DescribeLayer4RuleAttributesResponse DescribeLayer4RuleAttributes(DescribeLayer4RuleAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLayer4RuleAttributesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeLayer4RuleAttributesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer4RuleAttributesResponse
        /// </returns>
        public async Task<DescribeLayer4RuleAttributesResponse> DescribeLayer4RuleAttributesAsync(DescribeLayer4RuleAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLayer4RuleAttributesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeLayer4Rules to query the detailed configuration of port forwarding rules for DDoS protection instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLayer4RulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer4RulesResponse
        /// </returns>
        public DescribeLayer4RulesResponse DescribeLayer4RulesWithOptions(DescribeLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardProtocol))
            {
                query["ForwardProtocol"] = request.ForwardProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrontendPort))
            {
                query["FrontendPort"] = request.FrontendPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLayer4Rules",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeLayer4RulesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeLayer4RulesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeLayer4Rules to query the detailed configuration of port forwarding rules for DDoS protection instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLayer4RulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer4RulesResponse
        /// </returns>
        public async Task<DescribeLayer4RulesResponse> DescribeLayer4RulesWithOptionsAsync(DescribeLayer4RulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardProtocol))
            {
                query["ForwardProtocol"] = request.ForwardProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrontendPort))
            {
                query["FrontendPort"] = request.FrontendPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLayer4Rules",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeLayer4RulesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeLayer4RulesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeLayer4Rules to query the detailed configuration of port forwarding rules for DDoS protection instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLayer4RulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer4RulesResponse
        /// </returns>
        public DescribeLayer4RulesResponse DescribeLayer4Rules(DescribeLayer4RulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLayer4RulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call DescribeLayer4Rules to query the detailed configuration of port forwarding rules for DDoS protection instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLayer4RulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer4RulesResponse
        /// </returns>
        public async Task<DescribeLayer4RulesResponse> DescribeLayer4RulesAsync(DescribeLayer4RulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLayer4RulesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeLayer7CCRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer7CCRulesResponse
        /// </returns>
        public DescribeLayer7CCRulesResponse DescribeLayer7CCRulesWithOptions(DescribeLayer7CCRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLayer7CCRules",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeLayer7CCRulesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeLayer7CCRulesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeLayer7CCRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer7CCRulesResponse
        /// </returns>
        public async Task<DescribeLayer7CCRulesResponse> DescribeLayer7CCRulesWithOptionsAsync(DescribeLayer7CCRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLayer7CCRules",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeLayer7CCRulesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeLayer7CCRulesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeLayer7CCRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer7CCRulesResponse
        /// </returns>
        public DescribeLayer7CCRulesResponse DescribeLayer7CCRules(DescribeLayer7CCRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLayer7CCRulesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeLayer7CCRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLayer7CCRulesResponse
        /// </returns>
        public async Task<DescribeLayer7CCRulesResponse> DescribeLayer7CCRulesAsync(DescribeLayer7CCRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLayer7CCRulesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeLogStoreExistStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogStoreExistStatusResponse
        /// </returns>
        public DescribeLogStoreExistStatusResponse DescribeLogStoreExistStatusWithOptions(DescribeLogStoreExistStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogStoreExistStatus",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeLogStoreExistStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeLogStoreExistStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeLogStoreExistStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogStoreExistStatusResponse
        /// </returns>
        public async Task<DescribeLogStoreExistStatusResponse> DescribeLogStoreExistStatusWithOptionsAsync(DescribeLogStoreExistStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogStoreExistStatus",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeLogStoreExistStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeLogStoreExistStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeLogStoreExistStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogStoreExistStatusResponse
        /// </returns>
        public DescribeLogStoreExistStatusResponse DescribeLogStoreExistStatus(DescribeLogStoreExistStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogStoreExistStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeLogStoreExistStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLogStoreExistStatusResponse
        /// </returns>
        public async Task<DescribeLogStoreExistStatusResponse> DescribeLogStoreExistStatusAsync(DescribeLogStoreExistStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogStoreExistStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeOpEntitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOpEntitiesResponse
        /// </returns>
        public DescribeOpEntitiesResponse DescribeOpEntitiesWithOptions(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityObject))
            {
                query["EntityObject"] = request.EntityObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpAction))
            {
                query["OpAction"] = request.OpAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOpEntities",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeOpEntitiesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeOpEntitiesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeOpEntitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOpEntitiesResponse
        /// </returns>
        public async Task<DescribeOpEntitiesResponse> DescribeOpEntitiesWithOptionsAsync(DescribeOpEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityObject))
            {
                query["EntityObject"] = request.EntityObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpAction))
            {
                query["OpAction"] = request.OpAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOpEntities",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeOpEntitiesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeOpEntitiesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeOpEntitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOpEntitiesResponse
        /// </returns>
        public DescribeOpEntitiesResponse DescribeOpEntities(DescribeOpEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOpEntitiesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeOpEntitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOpEntitiesResponse
        /// </returns>
        public async Task<DescribeOpEntitiesResponse> DescribeOpEntitiesAsync(DescribeOpEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOpEntitiesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeSimpleDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimpleDomainsResponse
        /// </returns>
        public DescribeSimpleDomainsResponse DescribeSimpleDomainsWithOptions(DescribeSimpleDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSimpleDomains",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSimpleDomainsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSimpleDomainsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeSimpleDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimpleDomainsResponse
        /// </returns>
        public async Task<DescribeSimpleDomainsResponse> DescribeSimpleDomainsWithOptionsAsync(DescribeSimpleDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSimpleDomains",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSimpleDomainsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSimpleDomainsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeSimpleDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimpleDomainsResponse
        /// </returns>
        public DescribeSimpleDomainsResponse DescribeSimpleDomains(DescribeSimpleDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSimpleDomainsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeSimpleDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimpleDomainsResponse
        /// </returns>
        public async Task<DescribeSimpleDomainsResponse> DescribeSimpleDomainsAsync(DescribeSimpleDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSimpleDomainsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeSlsAuthStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsAuthStatusResponse
        /// </returns>
        public DescribeSlsAuthStatusResponse DescribeSlsAuthStatusWithOptions(DescribeSlsAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsAuthStatus",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeSlsAuthStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsAuthStatusResponse
        /// </returns>
        public async Task<DescribeSlsAuthStatusResponse> DescribeSlsAuthStatusWithOptionsAsync(DescribeSlsAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsAuthStatus",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeSlsAuthStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsAuthStatusResponse
        /// </returns>
        public DescribeSlsAuthStatusResponse DescribeSlsAuthStatus(DescribeSlsAuthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsAuthStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeSlsAuthStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsAuthStatusResponse
        /// </returns>
        public async Task<DescribeSlsAuthStatusResponse> DescribeSlsAuthStatusAsync(DescribeSlsAuthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsAuthStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeSlsEmptyCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsEmptyCountResponse
        /// </returns>
        public DescribeSlsEmptyCountResponse DescribeSlsEmptyCountWithOptions(DescribeSlsEmptyCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsEmptyCount",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSlsEmptyCountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSlsEmptyCountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeSlsEmptyCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsEmptyCountResponse
        /// </returns>
        public async Task<DescribeSlsEmptyCountResponse> DescribeSlsEmptyCountWithOptionsAsync(DescribeSlsEmptyCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsEmptyCount",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSlsEmptyCountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSlsEmptyCountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeSlsEmptyCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsEmptyCountResponse
        /// </returns>
        public DescribeSlsEmptyCountResponse DescribeSlsEmptyCount(DescribeSlsEmptyCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsEmptyCountWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeSlsEmptyCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsEmptyCountResponse
        /// </returns>
        public async Task<DescribeSlsEmptyCountResponse> DescribeSlsEmptyCountAsync(DescribeSlsEmptyCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsEmptyCountWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeSlsLogstoreInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsLogstoreInfoResponse
        /// </returns>
        public DescribeSlsLogstoreInfoResponse DescribeSlsLogstoreInfoWithOptions(DescribeSlsLogstoreInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsLogstoreInfo",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSlsLogstoreInfoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSlsLogstoreInfoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeSlsLogstoreInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsLogstoreInfoResponse
        /// </returns>
        public async Task<DescribeSlsLogstoreInfoResponse> DescribeSlsLogstoreInfoWithOptionsAsync(DescribeSlsLogstoreInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsLogstoreInfo",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSlsLogstoreInfoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSlsLogstoreInfoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeSlsLogstoreInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsLogstoreInfoResponse
        /// </returns>
        public DescribeSlsLogstoreInfoResponse DescribeSlsLogstoreInfo(DescribeSlsLogstoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsLogstoreInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeSlsLogstoreInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsLogstoreInfoResponse
        /// </returns>
        public async Task<DescribeSlsLogstoreInfoResponse> DescribeSlsLogstoreInfoAsync(DescribeSlsLogstoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsLogstoreInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeSlsOpenStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsOpenStatusResponse
        /// </returns>
        public DescribeSlsOpenStatusResponse DescribeSlsOpenStatusWithOptions(DescribeSlsOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsOpenStatus",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSlsOpenStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSlsOpenStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeSlsOpenStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsOpenStatusResponse
        /// </returns>
        public async Task<DescribeSlsOpenStatusResponse> DescribeSlsOpenStatusWithOptionsAsync(DescribeSlsOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsOpenStatus",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSlsOpenStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSlsOpenStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeSlsOpenStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsOpenStatusResponse
        /// </returns>
        public DescribeSlsOpenStatusResponse DescribeSlsOpenStatus(DescribeSlsOpenStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsOpenStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeSlsOpenStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlsOpenStatusResponse
        /// </returns>
        public async Task<DescribeSlsOpenStatusResponse> DescribeSlsOpenStatusAsync(DescribeSlsOpenStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsOpenStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribleCertListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribleCertListResponse
        /// </returns>
        public DescribleCertListResponse DescribleCertListWithOptions(DescribleCertListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribleCertList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribleCertListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribleCertListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribleCertListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribleCertListResponse
        /// </returns>
        public async Task<DescribleCertListResponse> DescribleCertListWithOptionsAsync(DescribleCertListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribleCertList",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribleCertListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribleCertListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribleCertListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribleCertListResponse
        /// </returns>
        public DescribleCertListResponse DescribleCertList(DescribleCertListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribleCertListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribleCertListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribleCertListResponse
        /// </returns>
        public async Task<DescribleCertListResponse> DescribleCertListAsync(DescribleCertListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribleCertListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribleLayer7InstanceRelationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribleLayer7InstanceRelationsResponse
        /// </returns>
        public DescribleLayer7InstanceRelationsResponse DescribleLayer7InstanceRelationsWithOptions(DescribleLayer7InstanceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainList))
            {
                query["DomainList"] = request.DomainList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribleLayer7InstanceRelations",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribleLayer7InstanceRelationsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribleLayer7InstanceRelationsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribleLayer7InstanceRelationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribleLayer7InstanceRelationsResponse
        /// </returns>
        public async Task<DescribleLayer7InstanceRelationsResponse> DescribleLayer7InstanceRelationsWithOptionsAsync(DescribleLayer7InstanceRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainList))
            {
                query["DomainList"] = request.DomainList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribleLayer7InstanceRelations",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribleLayer7InstanceRelationsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribleLayer7InstanceRelationsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribleLayer7InstanceRelationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribleLayer7InstanceRelationsResponse
        /// </returns>
        public DescribleLayer7InstanceRelationsResponse DescribleLayer7InstanceRelations(DescribleLayer7InstanceRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribleLayer7InstanceRelationsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribleLayer7InstanceRelationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribleLayer7InstanceRelationsResponse
        /// </returns>
        public async Task<DescribleLayer7InstanceRelationsResponse> DescribleLayer7InstanceRelationsAsync(DescribleLayer7InstanceRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribleLayer7InstanceRelationsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DisableLayer7CCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableLayer7CCResponse
        /// </returns>
        public DisableLayer7CCResponse DisableLayer7CCWithOptions(DisableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableLayer7CC",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DisableLayer7CCResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableLayer7CCResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DisableLayer7CCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableLayer7CCResponse
        /// </returns>
        public async Task<DisableLayer7CCResponse> DisableLayer7CCWithOptionsAsync(DisableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableLayer7CC",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DisableLayer7CCResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableLayer7CCResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DisableLayer7CCRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableLayer7CCResponse
        /// </returns>
        public DisableLayer7CCResponse DisableLayer7CC(DisableLayer7CCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableLayer7CCWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DisableLayer7CCRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableLayer7CCResponse
        /// </returns>
        public async Task<DisableLayer7CCResponse> DisableLayer7CCAsync(DisableLayer7CCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableLayer7CCWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DisableLayer7CCRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableLayer7CCRuleResponse
        /// </returns>
        public DisableLayer7CCRuleResponse DisableLayer7CCRuleWithOptions(DisableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableLayer7CCRule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DisableLayer7CCRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableLayer7CCRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DisableLayer7CCRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableLayer7CCRuleResponse
        /// </returns>
        public async Task<DisableLayer7CCRuleResponse> DisableLayer7CCRuleWithOptionsAsync(DisableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableLayer7CCRule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DisableLayer7CCRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableLayer7CCRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DisableLayer7CCRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableLayer7CCRuleResponse
        /// </returns>
        public DisableLayer7CCRuleResponse DisableLayer7CCRule(DisableLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableLayer7CCRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DisableLayer7CCRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableLayer7CCRuleResponse
        /// </returns>
        public async Task<DisableLayer7CCRuleResponse> DisableLayer7CCRuleAsync(DisableLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableLayer7CCRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EmptySlsLogstoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EmptySlsLogstoreResponse
        /// </returns>
        public EmptySlsLogstoreResponse EmptySlsLogstoreWithOptions(EmptySlsLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EmptySlsLogstore",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EmptySlsLogstoreResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EmptySlsLogstoreResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// EmptySlsLogstoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EmptySlsLogstoreResponse
        /// </returns>
        public async Task<EmptySlsLogstoreResponse> EmptySlsLogstoreWithOptionsAsync(EmptySlsLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EmptySlsLogstore",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EmptySlsLogstoreResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EmptySlsLogstoreResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// EmptySlsLogstoreRequest
        /// </param>
        /// 
        /// <returns>
        /// EmptySlsLogstoreResponse
        /// </returns>
        public EmptySlsLogstoreResponse EmptySlsLogstore(EmptySlsLogstoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EmptySlsLogstoreWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EmptySlsLogstoreRequest
        /// </param>
        /// 
        /// <returns>
        /// EmptySlsLogstoreResponse
        /// </returns>
        public async Task<EmptySlsLogstoreResponse> EmptySlsLogstoreAsync(EmptySlsLogstoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EmptySlsLogstoreWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EnableLayer7CCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableLayer7CCResponse
        /// </returns>
        public EnableLayer7CCResponse EnableLayer7CCWithOptions(EnableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableLayer7CC",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EnableLayer7CCResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableLayer7CCResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// EnableLayer7CCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableLayer7CCResponse
        /// </returns>
        public async Task<EnableLayer7CCResponse> EnableLayer7CCWithOptionsAsync(EnableLayer7CCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableLayer7CC",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EnableLayer7CCResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableLayer7CCResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// EnableLayer7CCRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableLayer7CCResponse
        /// </returns>
        public EnableLayer7CCResponse EnableLayer7CC(EnableLayer7CCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableLayer7CCWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EnableLayer7CCRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableLayer7CCResponse
        /// </returns>
        public async Task<EnableLayer7CCResponse> EnableLayer7CCAsync(EnableLayer7CCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableLayer7CCWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EnableLayer7CCRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableLayer7CCRuleResponse
        /// </returns>
        public EnableLayer7CCRuleResponse EnableLayer7CCRuleWithOptions(EnableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableLayer7CCRule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EnableLayer7CCRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableLayer7CCRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// EnableLayer7CCRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableLayer7CCRuleResponse
        /// </returns>
        public async Task<EnableLayer7CCRuleResponse> EnableLayer7CCRuleWithOptionsAsync(EnableLayer7CCRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableLayer7CCRule",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EnableLayer7CCRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableLayer7CCRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// EnableLayer7CCRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableLayer7CCRuleResponse
        /// </returns>
        public EnableLayer7CCRuleResponse EnableLayer7CCRule(EnableLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableLayer7CCRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EnableLayer7CCRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableLayer7CCRuleResponse
        /// </returns>
        public async Task<EnableLayer7CCRuleResponse> EnableLayer7CCRuleAsync(EnableLayer7CCRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableLayer7CCRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTaskResponse
        /// </returns>
        public ListAsyncTaskResponse ListAsyncTaskWithOptions(ListAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAsyncTask",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListAsyncTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAsyncTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTaskResponse
        /// </returns>
        public async Task<ListAsyncTaskResponse> ListAsyncTaskWithOptionsAsync(ListAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAsyncTask",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAsyncTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTaskResponse
        /// </returns>
        public ListAsyncTaskResponse ListAsyncTask(ListAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAsyncTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTaskResponse
        /// </returns>
        public async Task<ListAsyncTaskResponse> ListAsyncTaskAsync(ListAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAsyncTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListLayer7CustomPortsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLayer7CustomPortsResponse
        /// </returns>
        public ListLayer7CustomPortsResponse ListLayer7CustomPortsWithOptions(ListLayer7CustomPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayer7CustomPorts",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListLayer7CustomPortsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListLayer7CustomPortsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListLayer7CustomPortsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLayer7CustomPortsResponse
        /// </returns>
        public async Task<ListLayer7CustomPortsResponse> ListLayer7CustomPortsWithOptionsAsync(ListLayer7CustomPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayer7CustomPorts",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListLayer7CustomPortsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListLayer7CustomPortsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListLayer7CustomPortsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLayer7CustomPortsResponse
        /// </returns>
        public ListLayer7CustomPortsResponse ListLayer7CustomPorts(ListLayer7CustomPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLayer7CustomPortsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListLayer7CustomPortsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLayer7CustomPortsResponse
        /// </returns>
        public async Task<ListLayer7CustomPortsResponse> ListLayer7CustomPortsAsync(ListLayer7CustomPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLayer7CustomPortsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTagKeysResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagKeysResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTagKeysResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagKeysResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListValueAddedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListValueAddedResponse
        /// </returns>
        public ListValueAddedResponse ListValueAddedWithOptions(ListValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListValueAdded",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListValueAddedResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListValueAddedResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListValueAddedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListValueAddedResponse
        /// </returns>
        public async Task<ListValueAddedResponse> ListValueAddedWithOptionsAsync(ListValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListValueAdded",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListValueAddedResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListValueAddedResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ListValueAddedRequest
        /// </param>
        /// 
        /// <returns>
        /// ListValueAddedResponse
        /// </returns>
        public ListValueAddedResponse ListValueAdded(ListValueAddedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListValueAddedWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListValueAddedRequest
        /// </param>
        /// 
        /// <returns>
        /// ListValueAddedResponse
        /// </returns>
        public async Task<ListValueAddedResponse> ListValueAddedAsync(ListValueAddedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListValueAddedWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyElasticBandWidthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticBandWidthResponse
        /// </returns>
        public ModifyElasticBandWidthResponse ModifyElasticBandWidthWithOptions(ModifyElasticBandWidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticBandwidth))
            {
                query["ElasticBandwidth"] = request.ElasticBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyElasticBandWidth",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyElasticBandWidthResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyElasticBandWidthResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ModifyElasticBandWidthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticBandWidthResponse
        /// </returns>
        public async Task<ModifyElasticBandWidthResponse> ModifyElasticBandWidthWithOptionsAsync(ModifyElasticBandWidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticBandwidth))
            {
                query["ElasticBandwidth"] = request.ElasticBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyElasticBandWidth",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyElasticBandWidthResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyElasticBandWidthResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ModifyElasticBandWidthRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticBandWidthResponse
        /// </returns>
        public ModifyElasticBandWidthResponse ModifyElasticBandWidth(ModifyElasticBandWidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyElasticBandWidthWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyElasticBandWidthRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticBandWidthResponse
        /// </returns>
        public async Task<ModifyElasticBandWidthResponse> ModifyElasticBandWidthAsync(ModifyElasticBandWidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyElasticBandWidthWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyFullLogTtlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFullLogTtlResponse
        /// </returns>
        public ModifyFullLogTtlResponse ModifyFullLogTtlWithOptions(ModifyFullLogTtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFullLogTtl",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyFullLogTtlResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyFullLogTtlResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ModifyFullLogTtlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFullLogTtlResponse
        /// </returns>
        public async Task<ModifyFullLogTtlResponse> ModifyFullLogTtlWithOptionsAsync(ModifyFullLogTtlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFullLogTtl",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyFullLogTtlResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyFullLogTtlResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ModifyFullLogTtlRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFullLogTtlResponse
        /// </returns>
        public ModifyFullLogTtlResponse ModifyFullLogTtl(ModifyFullLogTtlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFullLogTtlWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyFullLogTtlRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFullLogTtlResponse
        /// </returns>
        public async Task<ModifyFullLogTtlResponse> ModifyFullLogTtlAsync(ModifyFullLogTtlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFullLogTtlWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyInstanceRemarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceRemarkResponse
        /// </returns>
        public ModifyInstanceRemarkResponse ModifyInstanceRemarkWithOptions(ModifyInstanceRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceRemark",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyInstanceRemarkResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyInstanceRemarkResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ModifyInstanceRemarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceRemarkResponse
        /// </returns>
        public async Task<ModifyInstanceRemarkResponse> ModifyInstanceRemarkWithOptionsAsync(ModifyInstanceRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceRemark",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyInstanceRemarkResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyInstanceRemarkResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ModifyInstanceRemarkRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceRemarkResponse
        /// </returns>
        public ModifyInstanceRemarkResponse ModifyInstanceRemark(ModifyInstanceRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceRemarkWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyInstanceRemarkRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceRemarkResponse
        /// </returns>
        public async Task<ModifyInstanceRemarkResponse> ModifyInstanceRemarkAsync(ModifyInstanceRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceRemarkWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// OpenDomainSlsConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenDomainSlsConfigResponse
        /// </returns>
        public OpenDomainSlsConfigResponse OpenDomainSlsConfigWithOptions(OpenDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDomainSlsConfig",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<OpenDomainSlsConfigResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OpenDomainSlsConfigResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// OpenDomainSlsConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenDomainSlsConfigResponse
        /// </returns>
        public async Task<OpenDomainSlsConfigResponse> OpenDomainSlsConfigWithOptionsAsync(OpenDomainSlsConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDomainSlsConfig",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<OpenDomainSlsConfigResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OpenDomainSlsConfigResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// OpenDomainSlsConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenDomainSlsConfigResponse
        /// </returns>
        public OpenDomainSlsConfigResponse OpenDomainSlsConfig(OpenDomainSlsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenDomainSlsConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// OpenDomainSlsConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenDomainSlsConfigResponse
        /// </returns>
        public async Task<OpenDomainSlsConfigResponse> OpenDomainSlsConfigAsync(OpenDomainSlsConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenDomainSlsConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstance",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ReleaseInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReleaseInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstance",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ReleaseInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReleaseInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public ReleaseInstanceResponse ReleaseInstance(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public async Task<ReleaseInstanceResponse> ReleaseInstanceAsync(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ReleaseValueAddedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseValueAddedResponse
        /// </returns>
        public ReleaseValueAddedResponse ReleaseValueAddedWithOptions(ReleaseValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseValueAdded",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ReleaseValueAddedResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReleaseValueAddedResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ReleaseValueAddedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseValueAddedResponse
        /// </returns>
        public async Task<ReleaseValueAddedResponse> ReleaseValueAddedWithOptionsAsync(ReleaseValueAddedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseValueAdded",
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ReleaseValueAddedResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReleaseValueAddedResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ReleaseValueAddedRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseValueAddedResponse
        /// </returns>
        public ReleaseValueAddedResponse ReleaseValueAdded(ReleaseValueAddedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseValueAddedWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ReleaseValueAddedRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseValueAddedResponse
        /// </returns>
        public async Task<ReleaseValueAddedResponse> ReleaseValueAddedAsync(ReleaseValueAddedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseValueAddedWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<TagResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<TagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UntagResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Version = "2017-12-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UntagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

    }
}
