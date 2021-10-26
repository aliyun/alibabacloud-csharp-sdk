// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.FC_Open20210406.Models;

namespace AlibabaCloud.SDK.FC_Open20210406
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "account-id.ap-northeast-1.fc.aliyuncs.com"},
                {"ap-south-1", "account-id.ap-south-1.fc.aliyuncs.com"},
                {"ap-southeast-1", "account-id.ap-southeast-1.fc.aliyuncs.com"},
                {"ap-southeast-2", "account-id.ap-southeast-2.fc.aliyuncs.com"},
                {"ap-southeast-3", "account-id.ap-southeast-3.fc.aliyuncs.com"},
                {"ap-southeast-5", "account-id.ap-southeast-5.fc.aliyuncs.com"},
                {"cn-beijing", "account-id.cn-beijing.fc.aliyuncs.com"},
                {"cn-chengdu", "account-id.cn-chengdu.fc.aliyuncs.com"},
                {"cn-hangzhou", "account-id.cn-hangzhou.fc.aliyuncs.com"},
                {"cn-hangzhou-finance", "account-id.cn-hangzhou-finance.fc.aliyuncs.com"},
                {"cn-hongkong", "account-id.cn-hongkong.fc.aliyuncs.com"},
                {"cn-huhehaote", "account-id.cn-huhehaote.fc.aliyuncs.com"},
                {"cn-north-2-gov-1", "account-id.cn-north-2-gov-1.fc.aliyuncs.com"},
                {"cn-qingdao", "account-id.cn-qingdao.fc.aliyuncs.com"},
                {"cn-shanghai", "account-id.cn-shanghai.fc.aliyuncs.com"},
                {"cn-shenzhen", "account-id.cn-shenzhen.fc.aliyuncs.com"},
                {"cn-zhangjiakou", "account-id.cn-zhangjiakou.fc.aliyuncs.com"},
                {"eu-central-1", "account-id.eu-central-1.fc.aliyuncs.com"},
                {"eu-west-1", "account-id.eu-west-1.fc.aliyuncs.com"},
                {"us-east-1", "account-id.us-east-1.fc.aliyuncs.com"},
                {"us-west-1", "account-id.us-west-1.fc.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("fc-open", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateAliasResponse CreateAlias(string serviceName, CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAliasWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<CreateAliasResponse> CreateAliasAsync(string serviceName, CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAliasWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public CreateAliasResponse CreateAliasWithOptions(string serviceName, CreateAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalVersionWeight))
            {
                body["additionalVersionWeight"] = request.AdditionalVersionWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                body["aliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateAliasResponse>(DoROARequest("CreateAlias", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/aliases", "json", req, runtime));
        }

        public async Task<CreateAliasResponse> CreateAliasWithOptionsAsync(string serviceName, CreateAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalVersionWeight))
            {
                body["additionalVersionWeight"] = request.AdditionalVersionWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                body["aliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["versionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateAliasResponse>(await DoROARequestAsync("CreateAlias", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/aliases", "json", req, runtime));
        }

        public CreateCustomDomainResponse CreateCustomDomain(CreateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCustomDomainWithOptions(request, headers, runtime);
        }

        public async Task<CreateCustomDomainResponse> CreateCustomDomainAsync(CreateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCustomDomainWithOptionsAsync(request, headers, runtime);
        }

        public CreateCustomDomainResponse CreateCustomDomainWithOptions(CreateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertConfig.ToMap()))
            {
                body["certConfig"] = request.CertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteConfig.ToMap()))
            {
                body["routeConfig"] = request.RouteConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateCustomDomainResponse>(DoROARequest("CreateCustomDomain", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/custom-domains", "json", req, runtime));
        }

        public async Task<CreateCustomDomainResponse> CreateCustomDomainWithOptionsAsync(CreateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertConfig.ToMap()))
            {
                body["certConfig"] = request.CertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteConfig.ToMap()))
            {
                body["routeConfig"] = request.RouteConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateCustomDomainResponse>(await DoROARequestAsync("CreateCustomDomain", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/custom-domains", "json", req, runtime));
        }

        public CreateFunctionResponse CreateFunction(string serviceName, CreateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFunctionHeaders headers = new CreateFunctionHeaders();
            return CreateFunctionWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<CreateFunctionResponse> CreateFunctionAsync(string serviceName, CreateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFunctionHeaders headers = new CreateFunctionHeaders();
            return await CreateFunctionWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public CreateFunctionResponse CreateFunctionWithOptions(string serviceName, CreateFunctionRequest request, CreateFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaPort))
            {
                body["caPort"] = request.CaPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code.ToMap()))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomContainerConfig.ToMap()))
            {
                body["customContainerConfig"] = request.CustomContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["environmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                body["functionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                body["handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitializationTimeout))
            {
                body["initializationTimeout"] = request.InitializationTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Initializer))
            {
                body["initializer"] = request.Initializer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceConcurrency))
            {
                body["instanceConcurrency"] = request.InstanceConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLifecycleConfig.ToMap()))
            {
                body["instanceLifecycleConfig"] = request.InstanceLifecycleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layers))
            {
                body["layers"] = request.Layers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemorySize))
            {
                body["memorySize"] = request.MemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["x-fc-code-checksum"] = headers.XFcCodeChecksum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateFunctionResponse>(DoROARequest("CreateFunction", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/functions", "json", req, runtime));
        }

        public async Task<CreateFunctionResponse> CreateFunctionWithOptionsAsync(string serviceName, CreateFunctionRequest request, CreateFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaPort))
            {
                body["caPort"] = request.CaPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code.ToMap()))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomContainerConfig.ToMap()))
            {
                body["customContainerConfig"] = request.CustomContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["environmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                body["functionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                body["handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitializationTimeout))
            {
                body["initializationTimeout"] = request.InitializationTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Initializer))
            {
                body["initializer"] = request.Initializer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceConcurrency))
            {
                body["instanceConcurrency"] = request.InstanceConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLifecycleConfig.ToMap()))
            {
                body["instanceLifecycleConfig"] = request.InstanceLifecycleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layers))
            {
                body["layers"] = request.Layers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemorySize))
            {
                body["memorySize"] = request.MemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["x-fc-code-checksum"] = headers.XFcCodeChecksum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateFunctionResponse>(await DoROARequestAsync("CreateFunction", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/functions", "json", req, runtime));
        }

        public CreateLayerVersionResponse CreateLayerVersion(string layerName, CreateLayerVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLayerVersionWithOptions(layerName, request, headers, runtime);
        }

        public async Task<CreateLayerVersionResponse> CreateLayerVersionAsync(string layerName, CreateLayerVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLayerVersionWithOptionsAsync(layerName, request, headers, runtime);
        }

        public CreateLayerVersionResponse CreateLayerVersionWithOptions(string layerName, CreateLayerVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code.ToMap()))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompatibleRuntime))
            {
                body["compatibleRuntime"] = request.CompatibleRuntime;
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
            return TeaModel.ToObject<CreateLayerVersionResponse>(DoROARequest("CreateLayerVersion", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/layers/" + layerName + "/versions", "json", req, runtime));
        }

        public async Task<CreateLayerVersionResponse> CreateLayerVersionWithOptionsAsync(string layerName, CreateLayerVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code.ToMap()))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompatibleRuntime))
            {
                body["compatibleRuntime"] = request.CompatibleRuntime;
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
            return TeaModel.ToObject<CreateLayerVersionResponse>(await DoROARequestAsync("CreateLayerVersion", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/layers/" + layerName + "/versions", "json", req, runtime));
        }

        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceWithOptions(request, headers, runtime);
        }

        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceWithOptionsAsync(request, headers, runtime);
        }

        public CreateServiceResponse CreateServiceWithOptions(CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetAccess))
            {
                body["internetAccess"] = request.InternetAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogConfig.ToMap()))
            {
                body["logConfig"] = request.LogConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfig.ToMap()))
            {
                body["nasConfig"] = request.NasConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingConfig.ToMap()))
            {
                body["tracingConfig"] = request.TracingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcConfig.ToMap()))
            {
                body["vpcConfig"] = request.VpcConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateServiceResponse>(DoROARequest("CreateService", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services", "json", req, runtime));
        }

        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetAccess))
            {
                body["internetAccess"] = request.InternetAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogConfig.ToMap()))
            {
                body["logConfig"] = request.LogConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfig.ToMap()))
            {
                body["nasConfig"] = request.NasConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["serviceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingConfig.ToMap()))
            {
                body["tracingConfig"] = request.TracingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcConfig.ToMap()))
            {
                body["vpcConfig"] = request.VpcConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateServiceResponse>(await DoROARequestAsync("CreateService", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services", "json", req, runtime));
        }

        public CreateTriggerResponse CreateTrigger(string serviceName, string functionName, CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTriggerWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<CreateTriggerResponse> CreateTriggerAsync(string serviceName, string functionName, CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTriggerWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public CreateTriggerResponse CreateTriggerWithOptions(string serviceName, string functionName, CreateTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationRole))
            {
                body["invocationRole"] = request.InvocationRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["sourceArn"] = request.SourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerName))
            {
                body["triggerName"] = request.TriggerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                body["triggerType"] = request.TriggerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateTriggerResponse>(DoROARequest("CreateTrigger", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/triggers", "json", req, runtime));
        }

        public async Task<CreateTriggerResponse> CreateTriggerWithOptionsAsync(string serviceName, string functionName, CreateTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationRole))
            {
                body["invocationRole"] = request.InvocationRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["sourceArn"] = request.SourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerName))
            {
                body["triggerName"] = request.TriggerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                body["triggerType"] = request.TriggerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateTriggerResponse>(await DoROARequestAsync("CreateTrigger", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/triggers", "json", req, runtime));
        }

        public CreateVpcBindingResponse CreateVpcBinding(string serviceName, CreateVpcBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVpcBindingWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<CreateVpcBindingResponse> CreateVpcBindingAsync(string serviceName, CreateVpcBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVpcBindingWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public CreateVpcBindingResponse CreateVpcBindingWithOptions(string serviceName, CreateVpcBindingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateVpcBindingResponse>(DoROARequest("CreateVpcBinding", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/bindings", "none", req, runtime));
        }

        public async Task<CreateVpcBindingResponse> CreateVpcBindingWithOptionsAsync(string serviceName, CreateVpcBindingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateVpcBindingResponse>(await DoROARequestAsync("CreateVpcBinding", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/bindings", "none", req, runtime));
        }

        public DeleteAliasResponse DeleteAlias(string serviceName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAliasHeaders headers = new DeleteAliasHeaders();
            return DeleteAliasWithOptions(serviceName, aliasName, headers, runtime);
        }

        public async Task<DeleteAliasResponse> DeleteAliasAsync(string serviceName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAliasHeaders headers = new DeleteAliasHeaders();
            return await DeleteAliasWithOptionsAsync(serviceName, aliasName, headers, runtime);
        }

        public DeleteAliasResponse DeleteAliasWithOptions(string serviceName, string aliasName, DeleteAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            aliasName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteAliasResponse>(DoROARequest("DeleteAlias", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/aliases/" + aliasName, "none", req, runtime));
        }

        public async Task<DeleteAliasResponse> DeleteAliasWithOptionsAsync(string serviceName, string aliasName, DeleteAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            aliasName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteAliasResponse>(await DoROARequestAsync("DeleteAlias", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/aliases/" + aliasName, "none", req, runtime));
        }

        public DeleteCustomDomainResponse DeleteCustomDomain(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCustomDomainWithOptions(domainName, headers, runtime);
        }

        public async Task<DeleteCustomDomainResponse> DeleteCustomDomainAsync(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCustomDomainWithOptionsAsync(domainName, headers, runtime);
        }

        public DeleteCustomDomainResponse DeleteCustomDomainWithOptions(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            domainName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteCustomDomainResponse>(DoROARequest("DeleteCustomDomain", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/custom-domains/" + domainName, "none", req, runtime));
        }

        public async Task<DeleteCustomDomainResponse> DeleteCustomDomainWithOptionsAsync(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            domainName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteCustomDomainResponse>(await DoROARequestAsync("DeleteCustomDomain", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/custom-domains/" + domainName, "none", req, runtime));
        }

        public DeleteFunctionResponse DeleteFunction(string serviceName, string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFunctionHeaders headers = new DeleteFunctionHeaders();
            return DeleteFunctionWithOptions(serviceName, functionName, headers, runtime);
        }

        public async Task<DeleteFunctionResponse> DeleteFunctionAsync(string serviceName, string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFunctionHeaders headers = new DeleteFunctionHeaders();
            return await DeleteFunctionWithOptionsAsync(serviceName, functionName, headers, runtime);
        }

        public DeleteFunctionResponse DeleteFunctionWithOptions(string serviceName, string functionName, DeleteFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteFunctionResponse>(DoROARequest("DeleteFunction", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName, "none", req, runtime));
        }

        public async Task<DeleteFunctionResponse> DeleteFunctionWithOptionsAsync(string serviceName, string functionName, DeleteFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteFunctionResponse>(await DoROARequestAsync("DeleteFunction", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName, "none", req, runtime));
        }

        public DeleteFunctionAsyncInvokeConfigResponse DeleteFunctionAsyncInvokeConfig(string serviceName, string functionName, DeleteFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFunctionAsyncInvokeConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<DeleteFunctionAsyncInvokeConfigResponse> DeleteFunctionAsyncInvokeConfigAsync(string serviceName, string functionName, DeleteFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFunctionAsyncInvokeConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public DeleteFunctionAsyncInvokeConfigResponse DeleteFunctionAsyncInvokeConfigWithOptions(string serviceName, string functionName, DeleteFunctionAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFunctionAsyncInvokeConfigResponse>(DoROARequest("DeleteFunctionAsyncInvokeConfig", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/async-invoke-config", "none", req, runtime));
        }

        public async Task<DeleteFunctionAsyncInvokeConfigResponse> DeleteFunctionAsyncInvokeConfigWithOptionsAsync(string serviceName, string functionName, DeleteFunctionAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFunctionAsyncInvokeConfigResponse>(await DoROARequestAsync("DeleteFunctionAsyncInvokeConfig", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/async-invoke-config", "none", req, runtime));
        }

        public DeleteFunctionOnDemandConfigResponse DeleteFunctionOnDemandConfig(string serviceName, string functionName, DeleteFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFunctionOnDemandConfigHeaders headers = new DeleteFunctionOnDemandConfigHeaders();
            return DeleteFunctionOnDemandConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<DeleteFunctionOnDemandConfigResponse> DeleteFunctionOnDemandConfigAsync(string serviceName, string functionName, DeleteFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFunctionOnDemandConfigHeaders headers = new DeleteFunctionOnDemandConfigHeaders();
            return await DeleteFunctionOnDemandConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public DeleteFunctionOnDemandConfigResponse DeleteFunctionOnDemandConfigWithOptions(string serviceName, string functionName, DeleteFunctionOnDemandConfigRequest request, DeleteFunctionOnDemandConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFunctionOnDemandConfigResponse>(DoROARequest("DeleteFunctionOnDemandConfig", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/on-demand-config", "none", req, runtime));
        }

        public async Task<DeleteFunctionOnDemandConfigResponse> DeleteFunctionOnDemandConfigWithOptionsAsync(string serviceName, string functionName, DeleteFunctionOnDemandConfigRequest request, DeleteFunctionOnDemandConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFunctionOnDemandConfigResponse>(await DoROARequestAsync("DeleteFunctionOnDemandConfig", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/on-demand-config", "none", req, runtime));
        }

        public DeleteLayerVersionResponse DeleteLayerVersion(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLayerVersionWithOptions(layerName, version, headers, runtime);
        }

        public async Task<DeleteLayerVersionResponse> DeleteLayerVersionAsync(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLayerVersionWithOptionsAsync(layerName, version, headers, runtime);
        }

        public DeleteLayerVersionResponse DeleteLayerVersionWithOptions(string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteLayerVersionResponse>(DoROARequest("DeleteLayerVersion", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/layers/" + layerName + "/versions/" + version, "none", req, runtime));
        }

        public async Task<DeleteLayerVersionResponse> DeleteLayerVersionWithOptionsAsync(string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteLayerVersionResponse>(await DoROARequestAsync("DeleteLayerVersion", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/layers/" + layerName + "/versions/" + version, "none", req, runtime));
        }

        public DeleteServiceResponse DeleteService(string serviceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteServiceHeaders headers = new DeleteServiceHeaders();
            return DeleteServiceWithOptions(serviceName, headers, runtime);
        }

        public async Task<DeleteServiceResponse> DeleteServiceAsync(string serviceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteServiceHeaders headers = new DeleteServiceHeaders();
            return await DeleteServiceWithOptionsAsync(serviceName, headers, runtime);
        }

        public DeleteServiceResponse DeleteServiceWithOptions(string serviceName, DeleteServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteServiceResponse>(DoROARequest("DeleteService", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName, "none", req, runtime));
        }

        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(string serviceName, DeleteServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await DoROARequestAsync("DeleteService", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName, "none", req, runtime));
        }

        public DeleteServiceVersionResponse DeleteServiceVersion(string serviceName, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceVersionWithOptions(serviceName, versionId, headers, runtime);
        }

        public async Task<DeleteServiceVersionResponse> DeleteServiceVersionAsync(string serviceName, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceVersionWithOptionsAsync(serviceName, versionId, headers, runtime);
        }

        public DeleteServiceVersionResponse DeleteServiceVersionWithOptions(string serviceName, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            versionId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteServiceVersionResponse>(DoROARequest("DeleteServiceVersion", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/versions/" + versionId, "none", req, runtime));
        }

        public async Task<DeleteServiceVersionResponse> DeleteServiceVersionWithOptionsAsync(string serviceName, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            versionId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteServiceVersionResponse>(await DoROARequestAsync("DeleteServiceVersion", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/versions/" + versionId, "none", req, runtime));
        }

        public DeleteTriggerResponse DeleteTrigger(string serviceName, string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTriggerHeaders headers = new DeleteTriggerHeaders();
            return DeleteTriggerWithOptions(serviceName, functionName, triggerName, headers, runtime);
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(string serviceName, string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTriggerHeaders headers = new DeleteTriggerHeaders();
            return await DeleteTriggerWithOptionsAsync(serviceName, functionName, triggerName, headers, runtime);
        }

        public DeleteTriggerResponse DeleteTriggerWithOptions(string serviceName, string functionName, string triggerName, DeleteTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            triggerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(DoROARequest("DeleteTrigger", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/triggers/" + triggerName, "none", req, runtime));
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerWithOptionsAsync(string serviceName, string functionName, string triggerName, DeleteTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            triggerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(await DoROARequestAsync("DeleteTrigger", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/triggers/" + triggerName, "none", req, runtime));
        }

        public DeleteVpcBindingResponse DeleteVpcBinding(string serviceName, string vpcId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVpcBindingWithOptions(serviceName, vpcId, headers, runtime);
        }

        public async Task<DeleteVpcBindingResponse> DeleteVpcBindingAsync(string serviceName, string vpcId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVpcBindingWithOptionsAsync(serviceName, vpcId, headers, runtime);
        }

        public DeleteVpcBindingResponse DeleteVpcBindingWithOptions(string serviceName, string vpcId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            vpcId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(vpcId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteVpcBindingResponse>(DoROARequest("DeleteVpcBinding", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/bindings/" + vpcId, "none", req, runtime));
        }

        public async Task<DeleteVpcBindingResponse> DeleteVpcBindingWithOptionsAsync(string serviceName, string vpcId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            vpcId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(vpcId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteVpcBindingResponse>(await DoROARequestAsync("DeleteVpcBinding", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/bindings/" + vpcId, "none", req, runtime));
        }

        public DeregisterEventSourceResponse DeregisterEventSource(string serviceName, string functionName, string sourceArn, DeregisterEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeregisterEventSourceWithOptions(serviceName, functionName, sourceArn, request, headers, runtime);
        }

        public async Task<DeregisterEventSourceResponse> DeregisterEventSourceAsync(string serviceName, string functionName, string sourceArn, DeregisterEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeregisterEventSourceWithOptionsAsync(serviceName, functionName, sourceArn, request, headers, runtime);
        }

        public DeregisterEventSourceResponse DeregisterEventSourceWithOptions(string serviceName, string functionName, string sourceArn, DeregisterEventSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            sourceArn = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceArn);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeregisterEventSourceResponse>(DoROARequest("DeregisterEventSource", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/event-sources/" + sourceArn, "none", req, runtime));
        }

        public async Task<DeregisterEventSourceResponse> DeregisterEventSourceWithOptionsAsync(string serviceName, string functionName, string sourceArn, DeregisterEventSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            sourceArn = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceArn);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeregisterEventSourceResponse>(await DoROARequestAsync("DeregisterEventSource", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/event-sources/" + sourceArn, "none", req, runtime));
        }

        public GetAccountSettingsResponse GetAccountSettings()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAccountSettingsWithOptions(headers, runtime);
        }

        public async Task<GetAccountSettingsResponse> GetAccountSettingsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAccountSettingsWithOptionsAsync(headers, runtime);
        }

        public GetAccountSettingsResponse GetAccountSettingsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetAccountSettingsResponse>(DoROARequest("GetAccountSettings", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/account-settings", "json", req, runtime));
        }

        public async Task<GetAccountSettingsResponse> GetAccountSettingsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetAccountSettingsResponse>(await DoROARequestAsync("GetAccountSettings", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/account-settings", "json", req, runtime));
        }

        public GetAliasResponse GetAlias(string serviceName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAliasWithOptions(serviceName, aliasName, headers, runtime);
        }

        public async Task<GetAliasResponse> GetAliasAsync(string serviceName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAliasWithOptionsAsync(serviceName, aliasName, headers, runtime);
        }

        public GetAliasResponse GetAliasWithOptions(string serviceName, string aliasName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            aliasName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetAliasResponse>(DoROARequest("GetAlias", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/aliases/" + aliasName, "json", req, runtime));
        }

        public async Task<GetAliasResponse> GetAliasWithOptionsAsync(string serviceName, string aliasName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            aliasName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetAliasResponse>(await DoROARequestAsync("GetAlias", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/aliases/" + aliasName, "json", req, runtime));
        }

        public GetCustomDomainResponse GetCustomDomain(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCustomDomainWithOptions(domainName, headers, runtime);
        }

        public async Task<GetCustomDomainResponse> GetCustomDomainAsync(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCustomDomainWithOptionsAsync(domainName, headers, runtime);
        }

        public GetCustomDomainResponse GetCustomDomainWithOptions(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            domainName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetCustomDomainResponse>(DoROARequest("GetCustomDomain", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/custom-domains/" + domainName, "json", req, runtime));
        }

        public async Task<GetCustomDomainResponse> GetCustomDomainWithOptionsAsync(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            domainName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetCustomDomainResponse>(await DoROARequestAsync("GetCustomDomain", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/custom-domains/" + domainName, "json", req, runtime));
        }

        public GetFunctionResponse GetFunction(string serviceName, string functionName, GetFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<GetFunctionResponse> GetFunctionAsync(string serviceName, string functionName, GetFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public GetFunctionResponse GetFunctionWithOptions(string serviceName, string functionName, GetFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFunctionResponse>(DoROARequest("GetFunction", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName, "json", req, runtime));
        }

        public async Task<GetFunctionResponse> GetFunctionWithOptionsAsync(string serviceName, string functionName, GetFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFunctionResponse>(await DoROARequestAsync("GetFunction", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName, "json", req, runtime));
        }

        public GetFunctionAsyncInvokeConfigResponse GetFunctionAsyncInvokeConfig(string serviceName, string functionName, GetFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionAsyncInvokeConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<GetFunctionAsyncInvokeConfigResponse> GetFunctionAsyncInvokeConfigAsync(string serviceName, string functionName, GetFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionAsyncInvokeConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public GetFunctionAsyncInvokeConfigResponse GetFunctionAsyncInvokeConfigWithOptions(string serviceName, string functionName, GetFunctionAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFunctionAsyncInvokeConfigResponse>(DoROARequest("GetFunctionAsyncInvokeConfig", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/async-invoke-config", "json", req, runtime));
        }

        public async Task<GetFunctionAsyncInvokeConfigResponse> GetFunctionAsyncInvokeConfigWithOptionsAsync(string serviceName, string functionName, GetFunctionAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFunctionAsyncInvokeConfigResponse>(await DoROARequestAsync("GetFunctionAsyncInvokeConfig", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/async-invoke-config", "json", req, runtime));
        }

        public GetFunctionCodeResponse GetFunctionCode(string serviceName, string functionName, GetFunctionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionCodeWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<GetFunctionCodeResponse> GetFunctionCodeAsync(string serviceName, string functionName, GetFunctionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionCodeWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public GetFunctionCodeResponse GetFunctionCodeWithOptions(string serviceName, string functionName, GetFunctionCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFunctionCodeResponse>(DoROARequest("GetFunctionCode", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/code", "json", req, runtime));
        }

        public async Task<GetFunctionCodeResponse> GetFunctionCodeWithOptionsAsync(string serviceName, string functionName, GetFunctionCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFunctionCodeResponse>(await DoROARequestAsync("GetFunctionCode", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/code", "json", req, runtime));
        }

        public GetFunctionOnDemandConfigResponse GetFunctionOnDemandConfig(string serviceName, string functionName, GetFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionOnDemandConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<GetFunctionOnDemandConfigResponse> GetFunctionOnDemandConfigAsync(string serviceName, string functionName, GetFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionOnDemandConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public GetFunctionOnDemandConfigResponse GetFunctionOnDemandConfigWithOptions(string serviceName, string functionName, GetFunctionOnDemandConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFunctionOnDemandConfigResponse>(DoROARequest("GetFunctionOnDemandConfig", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/on-demand-config", "json", req, runtime));
        }

        public async Task<GetFunctionOnDemandConfigResponse> GetFunctionOnDemandConfigWithOptionsAsync(string serviceName, string functionName, GetFunctionOnDemandConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFunctionOnDemandConfigResponse>(await DoROARequestAsync("GetFunctionOnDemandConfig", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/on-demand-config", "json", req, runtime));
        }

        public GetLayerVersionResponse GetLayerVersion(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLayerVersionWithOptions(layerName, version, headers, runtime);
        }

        public async Task<GetLayerVersionResponse> GetLayerVersionAsync(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLayerVersionWithOptionsAsync(layerName, version, headers, runtime);
        }

        public GetLayerVersionResponse GetLayerVersionWithOptions(string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetLayerVersionResponse>(DoROARequest("GetLayerVersion", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/layers/" + layerName + "/versions/" + version, "json", req, runtime));
        }

        public async Task<GetLayerVersionResponse> GetLayerVersionWithOptionsAsync(string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetLayerVersionResponse>(await DoROARequestAsync("GetLayerVersion", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/layers/" + layerName + "/versions/" + version, "json", req, runtime));
        }

        public GetLayerVersionByArnResponse GetLayerVersionByArn(string arn)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLayerVersionByArnWithOptions(arn, headers, runtime);
        }

        public async Task<GetLayerVersionByArnResponse> GetLayerVersionByArnAsync(string arn)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLayerVersionByArnWithOptionsAsync(arn, headers, runtime);
        }

        public GetLayerVersionByArnResponse GetLayerVersionByArnWithOptions(string arn, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            arn = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(arn);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetLayerVersionByArnResponse>(DoROARequest("GetLayerVersionByArn", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/layerarn/" + arn, "json", req, runtime));
        }

        public async Task<GetLayerVersionByArnResponse> GetLayerVersionByArnWithOptionsAsync(string arn, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            arn = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(arn);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetLayerVersionByArnResponse>(await DoROARequestAsync("GetLayerVersionByArn", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/layerarn/" + arn, "json", req, runtime));
        }

        public GetProvisionConfigResponse GetProvisionConfig(string serviceName, string functionName, GetProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProvisionConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<GetProvisionConfigResponse> GetProvisionConfigAsync(string serviceName, string functionName, GetProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProvisionConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public GetProvisionConfigResponse GetProvisionConfigWithOptions(string serviceName, string functionName, GetProvisionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetProvisionConfigResponse>(DoROARequest("GetProvisionConfig", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/provision-config", "json", req, runtime));
        }

        public async Task<GetProvisionConfigResponse> GetProvisionConfigWithOptionsAsync(string serviceName, string functionName, GetProvisionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetProvisionConfigResponse>(await DoROARequestAsync("GetProvisionConfig", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/provision-config", "json", req, runtime));
        }

        public GetResourceTagsResponse GetResourceTags(GetResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceTagsWithOptions(request, headers, runtime);
        }

        public async Task<GetResourceTagsResponse> GetResourceTagsAsync(GetResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceTagsWithOptionsAsync(request, headers, runtime);
        }

        public GetResourceTagsResponse GetResourceTagsWithOptions(GetResourceTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                query["resourceArn"] = request.ResourceArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetResourceTagsResponse>(DoROARequest("GetResourceTags", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/tag", "json", req, runtime));
        }

        public async Task<GetResourceTagsResponse> GetResourceTagsWithOptionsAsync(GetResourceTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                query["resourceArn"] = request.ResourceArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetResourceTagsResponse>(await DoROARequestAsync("GetResourceTags", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/tag", "json", req, runtime));
        }

        public GetServiceResponse GetService(string serviceName, GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<GetServiceResponse> GetServiceAsync(string serviceName, GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public GetServiceResponse GetServiceWithOptions(string serviceName, GetServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetServiceResponse>(DoROARequest("GetService", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName, "json", req, runtime));
        }

        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(string serviceName, GetServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetServiceResponse>(await DoROARequestAsync("GetService", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName, "json", req, runtime));
        }

        public GetStatefulAsyncInvocationResponse GetStatefulAsyncInvocation(string serviceName, string functionName, string invocationId, GetStatefulAsyncInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetStatefulAsyncInvocationWithOptions(serviceName, functionName, invocationId, request, headers, runtime);
        }

        public async Task<GetStatefulAsyncInvocationResponse> GetStatefulAsyncInvocationAsync(string serviceName, string functionName, string invocationId, GetStatefulAsyncInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetStatefulAsyncInvocationWithOptionsAsync(serviceName, functionName, invocationId, request, headers, runtime);
        }

        public GetStatefulAsyncInvocationResponse GetStatefulAsyncInvocationWithOptions(string serviceName, string functionName, string invocationId, GetStatefulAsyncInvocationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            invocationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(invocationId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetStatefulAsyncInvocationResponse>(DoROARequest("GetStatefulAsyncInvocation", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/stateful-async-invocations/" + invocationId, "json", req, runtime));
        }

        public async Task<GetStatefulAsyncInvocationResponse> GetStatefulAsyncInvocationWithOptionsAsync(string serviceName, string functionName, string invocationId, GetStatefulAsyncInvocationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            invocationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(invocationId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetStatefulAsyncInvocationResponse>(await DoROARequestAsync("GetStatefulAsyncInvocation", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/stateful-async-invocations/" + invocationId, "json", req, runtime));
        }

        public GetTriggerResponse GetTrigger(string serviceName, string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTriggerWithOptions(serviceName, functionName, triggerName, headers, runtime);
        }

        public async Task<GetTriggerResponse> GetTriggerAsync(string serviceName, string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTriggerWithOptionsAsync(serviceName, functionName, triggerName, headers, runtime);
        }

        public GetTriggerResponse GetTriggerWithOptions(string serviceName, string functionName, string triggerName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            triggerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetTriggerResponse>(DoROARequest("GetTrigger", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/triggers/" + triggerName, "json", req, runtime));
        }

        public async Task<GetTriggerResponse> GetTriggerWithOptionsAsync(string serviceName, string functionName, string triggerName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            triggerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetTriggerResponse>(await DoROARequestAsync("GetTrigger", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/triggers/" + triggerName, "json", req, runtime));
        }

        public InvokeFunctionResponse InvokeFunction(string serviceName, string functionName, InvokeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeFunctionHeaders headers = new InvokeFunctionHeaders();
            return InvokeFunctionWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<InvokeFunctionResponse> InvokeFunctionAsync(string serviceName, string functionName, InvokeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeFunctionHeaders headers = new InvokeFunctionHeaders();
            return await InvokeFunctionWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public InvokeFunctionResponse InvokeFunctionWithOptions(string serviceName, string functionName, InvokeFunctionRequest request, InvokeFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = headers.XFcAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["x-fc-invocation-type"] = headers.XFcInvocationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["x-fc-log-type"] = headers.XFcLogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcStatefulAsyncInvocationId))
            {
                realHeaders["x-fc-stateful-async-invocation-id"] = headers.XFcStatefulAsyncInvocationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            return TeaModel.ToObject<InvokeFunctionResponse>(DoROARequest("InvokeFunction", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/invocations", "byte", req, runtime));
        }

        public async Task<InvokeFunctionResponse> InvokeFunctionWithOptionsAsync(string serviceName, string functionName, InvokeFunctionRequest request, InvokeFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = headers.XFcAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["x-fc-invocation-type"] = headers.XFcInvocationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["x-fc-log-type"] = headers.XFcLogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcStatefulAsyncInvocationId))
            {
                realHeaders["x-fc-stateful-async-invocation-id"] = headers.XFcStatefulAsyncInvocationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            return TeaModel.ToObject<InvokeFunctionResponse>(await DoROARequestAsync("InvokeFunction", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/invocations", "byte", req, runtime));
        }

        public ListAliasesResponse ListAliases(string serviceName, ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAliasesWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<ListAliasesResponse> ListAliasesAsync(string serviceName, ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAliasesWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public ListAliasesResponse ListAliasesWithOptions(string serviceName, ListAliasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAliasesResponse>(DoROARequest("ListAliases", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/aliases", "json", req, runtime));
        }

        public async Task<ListAliasesResponse> ListAliasesWithOptionsAsync(string serviceName, ListAliasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAliasesResponse>(await DoROARequestAsync("ListAliases", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/aliases", "json", req, runtime));
        }

        public ListCustomDomainsResponse ListCustomDomains(ListCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCustomDomainsWithOptions(request, headers, runtime);
        }

        public async Task<ListCustomDomainsResponse> ListCustomDomainsAsync(ListCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCustomDomainsWithOptionsAsync(request, headers, runtime);
        }

        public ListCustomDomainsResponse ListCustomDomainsWithOptions(ListCustomDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListCustomDomainsResponse>(DoROARequest("ListCustomDomains", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/custom-domains", "json", req, runtime));
        }

        public async Task<ListCustomDomainsResponse> ListCustomDomainsWithOptionsAsync(ListCustomDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListCustomDomainsResponse>(await DoROARequestAsync("ListCustomDomains", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/custom-domains", "json", req, runtime));
        }

        public ListEventSourcesResponse ListEventSources(string serviceName, string functionName, ListEventSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEventSourcesWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<ListEventSourcesResponse> ListEventSourcesAsync(string serviceName, string functionName, ListEventSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEventSourcesWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public ListEventSourcesResponse ListEventSourcesWithOptions(string serviceName, string functionName, ListEventSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListEventSourcesResponse>(DoROARequest("ListEventSources", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/event-sources", "json", req, runtime));
        }

        public async Task<ListEventSourcesResponse> ListEventSourcesWithOptionsAsync(string serviceName, string functionName, ListEventSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListEventSourcesResponse>(await DoROARequestAsync("ListEventSources", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/event-sources", "json", req, runtime));
        }

        public ListFunctionAsyncInvokeConfigsResponse ListFunctionAsyncInvokeConfigs(string serviceName, string functionName, ListFunctionAsyncInvokeConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionAsyncInvokeConfigsWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<ListFunctionAsyncInvokeConfigsResponse> ListFunctionAsyncInvokeConfigsAsync(string serviceName, string functionName, ListFunctionAsyncInvokeConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionAsyncInvokeConfigsWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public ListFunctionAsyncInvokeConfigsResponse ListFunctionAsyncInvokeConfigsWithOptions(string serviceName, string functionName, ListFunctionAsyncInvokeConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListFunctionAsyncInvokeConfigsResponse>(DoROARequest("ListFunctionAsyncInvokeConfigs", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/async-invoke-configs", "json", req, runtime));
        }

        public async Task<ListFunctionAsyncInvokeConfigsResponse> ListFunctionAsyncInvokeConfigsWithOptionsAsync(string serviceName, string functionName, ListFunctionAsyncInvokeConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListFunctionAsyncInvokeConfigsResponse>(await DoROARequestAsync("ListFunctionAsyncInvokeConfigs", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/async-invoke-configs", "json", req, runtime));
        }

        public ListFunctionsResponse ListFunctions(string serviceName, ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionsWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<ListFunctionsResponse> ListFunctionsAsync(string serviceName, ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionsWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public ListFunctionsResponse ListFunctionsWithOptions(string serviceName, ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListFunctionsResponse>(DoROARequest("ListFunctions", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions", "json", req, runtime));
        }

        public async Task<ListFunctionsResponse> ListFunctionsWithOptionsAsync(string serviceName, ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListFunctionsResponse>(await DoROARequestAsync("ListFunctions", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions", "json", req, runtime));
        }

        public ListLayerVersionsResponse ListLayerVersions(string layerName, ListLayerVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLayerVersionsWithOptions(layerName, request, headers, runtime);
        }

        public async Task<ListLayerVersionsResponse> ListLayerVersionsAsync(string layerName, ListLayerVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLayerVersionsWithOptionsAsync(layerName, request, headers, runtime);
        }

        public ListLayerVersionsResponse ListLayerVersionsWithOptions(string layerName, ListLayerVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartVersion))
            {
                query["startVersion"] = request.StartVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLayerVersionsResponse>(DoROARequest("ListLayerVersions", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/layers/" + layerName + "/versions", "json", req, runtime));
        }

        public async Task<ListLayerVersionsResponse> ListLayerVersionsWithOptionsAsync(string layerName, ListLayerVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartVersion))
            {
                query["startVersion"] = request.StartVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLayerVersionsResponse>(await DoROARequestAsync("ListLayerVersions", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/layers/" + layerName + "/versions", "json", req, runtime));
        }

        public ListLayersResponse ListLayers(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLayersWithOptions(request, headers, runtime);
        }

        public async Task<ListLayersResponse> ListLayersAsync(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLayersWithOptionsAsync(request, headers, runtime);
        }

        public ListLayersResponse ListLayersWithOptions(ListLayersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLayersResponse>(DoROARequest("ListLayers", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/layers", "json", req, runtime));
        }

        public async Task<ListLayersResponse> ListLayersWithOptionsAsync(ListLayersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLayersResponse>(await DoROARequestAsync("ListLayers", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/layers", "json", req, runtime));
        }

        public ListOnDemandConfigsResponse ListOnDemandConfigs(ListOnDemandConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOnDemandConfigsWithOptions(request, headers, runtime);
        }

        public async Task<ListOnDemandConfigsResponse> ListOnDemandConfigsAsync(ListOnDemandConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOnDemandConfigsWithOptionsAsync(request, headers, runtime);
        }

        public ListOnDemandConfigsResponse ListOnDemandConfigsWithOptions(ListOnDemandConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListOnDemandConfigsResponse>(DoROARequest("ListOnDemandConfigs", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/on-demand-configs", "json", req, runtime));
        }

        public async Task<ListOnDemandConfigsResponse> ListOnDemandConfigsWithOptionsAsync(ListOnDemandConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListOnDemandConfigsResponse>(await DoROARequestAsync("ListOnDemandConfigs", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/on-demand-configs", "json", req, runtime));
        }

        public ListProvisionConfigsResponse ListProvisionConfigs(ListProvisionConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProvisionConfigsWithOptions(request, headers, runtime);
        }

        public async Task<ListProvisionConfigsResponse> ListProvisionConfigsAsync(ListProvisionConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProvisionConfigsWithOptionsAsync(request, headers, runtime);
        }

        public ListProvisionConfigsResponse ListProvisionConfigsWithOptions(ListProvisionConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListProvisionConfigsResponse>(DoROARequest("ListProvisionConfigs", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/provision-configs", "json", req, runtime));
        }

        public async Task<ListProvisionConfigsResponse> ListProvisionConfigsWithOptionsAsync(ListProvisionConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["serviceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListProvisionConfigsResponse>(await DoROARequestAsync("ListProvisionConfigs", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/provision-configs", "json", req, runtime));
        }

        public ListReservedCapacitiesResponse ListReservedCapacities(ListReservedCapacitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListReservedCapacitiesWithOptions(request, headers, runtime);
        }

        public async Task<ListReservedCapacitiesResponse> ListReservedCapacitiesAsync(ListReservedCapacitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListReservedCapacitiesWithOptionsAsync(request, headers, runtime);
        }

        public ListReservedCapacitiesResponse ListReservedCapacitiesWithOptions(ListReservedCapacitiesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListReservedCapacitiesResponse>(DoROARequest("ListReservedCapacities", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/reserved-capacities", "json", req, runtime));
        }

        public async Task<ListReservedCapacitiesResponse> ListReservedCapacitiesWithOptionsAsync(ListReservedCapacitiesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListReservedCapacitiesResponse>(await DoROARequestAsync("ListReservedCapacities", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/reserved-capacities", "json", req, runtime));
        }

        public ListServiceVersionsResponse ListServiceVersions(string serviceName, ListServiceVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceVersionsWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<ListServiceVersionsResponse> ListServiceVersionsAsync(string serviceName, ListServiceVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceVersionsWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public ListServiceVersionsResponse ListServiceVersionsWithOptions(string serviceName, ListServiceVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListServiceVersionsResponse>(DoROARequest("ListServiceVersions", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/versions", "json", req, runtime));
        }

        public async Task<ListServiceVersionsResponse> ListServiceVersionsWithOptionsAsync(string serviceName, ListServiceVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListServiceVersionsResponse>(await DoROARequestAsync("ListServiceVersions", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/versions", "json", req, runtime));
        }

        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServicesWithOptions(request, headers, runtime);
        }

        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServicesWithOptionsAsync(request, headers, runtime);
        }

        public ListServicesResponse ListServicesWithOptions(ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListServicesResponse>(DoROARequest("ListServices", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services", "json", req, runtime));
        }

        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListServicesResponse>(await DoROARequestAsync("ListServices", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services", "json", req, runtime));
        }

        public ListStatefulAsyncInvocationsResponse ListStatefulAsyncInvocations(string serviceName, string functionName, ListStatefulAsyncInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListStatefulAsyncInvocationsWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<ListStatefulAsyncInvocationsResponse> ListStatefulAsyncInvocationsAsync(string serviceName, string functionName, ListStatefulAsyncInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListStatefulAsyncInvocationsWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public ListStatefulAsyncInvocationsResponse ListStatefulAsyncInvocationsWithOptions(string serviceName, string functionName, ListStatefulAsyncInvocationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePayload))
            {
                query["includePayload"] = request.IncludePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationIdPrefix))
            {
                query["invocationIdPrefix"] = request.InvocationIdPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrderByTime))
            {
                query["sortOrderByTime"] = request.SortOrderByTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartedTimeBegin))
            {
                query["startedTimeBegin"] = request.StartedTimeBegin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartedTimeEnd))
            {
                query["startedTimeEnd"] = request.StartedTimeEnd;
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
            return TeaModel.ToObject<ListStatefulAsyncInvocationsResponse>(DoROARequest("ListStatefulAsyncInvocations", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/stateful-async-invocations", "json", req, runtime));
        }

        public async Task<ListStatefulAsyncInvocationsResponse> ListStatefulAsyncInvocationsWithOptionsAsync(string serviceName, string functionName, ListStatefulAsyncInvocationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePayload))
            {
                query["includePayload"] = request.IncludePayload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationIdPrefix))
            {
                query["invocationIdPrefix"] = request.InvocationIdPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrderByTime))
            {
                query["sortOrderByTime"] = request.SortOrderByTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartedTimeBegin))
            {
                query["startedTimeBegin"] = request.StartedTimeBegin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartedTimeEnd))
            {
                query["startedTimeEnd"] = request.StartedTimeEnd;
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
            return TeaModel.ToObject<ListStatefulAsyncInvocationsResponse>(await DoROARequestAsync("ListStatefulAsyncInvocations", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/stateful-async-invocations", "json", req, runtime));
        }

        public ListTaggedResourcesResponse ListTaggedResources(ListTaggedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTaggedResourcesWithOptions(request, headers, runtime);
        }

        public async Task<ListTaggedResourcesResponse> ListTaggedResourcesAsync(ListTaggedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTaggedResourcesWithOptionsAsync(request, headers, runtime);
        }

        public ListTaggedResourcesResponse ListTaggedResourcesWithOptions(ListTaggedResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTaggedResourcesResponse>(DoROARequest("ListTaggedResources", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/tags", "json", req, runtime));
        }

        public async Task<ListTaggedResourcesResponse> ListTaggedResourcesWithOptionsAsync(ListTaggedResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTaggedResourcesResponse>(await DoROARequestAsync("ListTaggedResources", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/tags", "json", req, runtime));
        }

        public ListTriggersResponse ListTriggers(string serviceName, string functionName, ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTriggersWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<ListTriggersResponse> ListTriggersAsync(string serviceName, string functionName, ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTriggersWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public ListTriggersResponse ListTriggersWithOptions(string serviceName, string functionName, ListTriggersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTriggersResponse>(DoROARequest("ListTriggers", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/triggers", "json", req, runtime));
        }

        public async Task<ListTriggersResponse> ListTriggersWithOptionsAsync(string serviceName, string functionName, ListTriggersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartKey))
            {
                query["startKey"] = request.StartKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTriggersResponse>(await DoROARequestAsync("ListTriggers", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/triggers", "json", req, runtime));
        }

        public ListVpcBindingsResponse ListVpcBindings(string serviceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVpcBindingsWithOptions(serviceName, headers, runtime);
        }

        public async Task<ListVpcBindingsResponse> ListVpcBindingsAsync(string serviceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVpcBindingsWithOptionsAsync(serviceName, headers, runtime);
        }

        public ListVpcBindingsResponse ListVpcBindingsWithOptions(string serviceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListVpcBindingsResponse>(DoROARequest("ListVpcBindings", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/bindings", "json", req, runtime));
        }

        public async Task<ListVpcBindingsResponse> ListVpcBindingsWithOptionsAsync(string serviceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListVpcBindingsResponse>(await DoROARequestAsync("ListVpcBindings", "2021-04-06", "HTTPS", "GET", "AK", "/2021-04-06/services/" + serviceName + "/bindings", "json", req, runtime));
        }

        public PermanentDeleteLayerVersionResponse PermanentDeleteLayerVersion(string userID, string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PermanentDeleteLayerVersionWithOptions(userID, layerName, version, headers, runtime);
        }

        public async Task<PermanentDeleteLayerVersionResponse> PermanentDeleteLayerVersionAsync(string userID, string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PermanentDeleteLayerVersionWithOptionsAsync(userID, layerName, version, headers, runtime);
        }

        public PermanentDeleteLayerVersionResponse PermanentDeleteLayerVersionWithOptions(string userID, string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userID = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userID);
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PermanentDeleteLayerVersionResponse>(DoROARequest("PermanentDeleteLayerVersion", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/adminlayers/" + userID + "/" + layerName + "/versions/" + version, "none", req, runtime));
        }

        public async Task<PermanentDeleteLayerVersionResponse> PermanentDeleteLayerVersionWithOptionsAsync(string userID, string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userID = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userID);
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PermanentDeleteLayerVersionResponse>(await DoROARequestAsync("PermanentDeleteLayerVersion", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/adminlayers/" + userID + "/" + layerName + "/versions/" + version, "none", req, runtime));
        }

        public PublishLayerAsPublicResponse PublishLayerAsPublic(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishLayerAsPublicWithOptions(layerName, version, headers, runtime);
        }

        public async Task<PublishLayerAsPublicResponse> PublishLayerAsPublicAsync(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishLayerAsPublicWithOptionsAsync(layerName, version, headers, runtime);
        }

        public PublishLayerAsPublicResponse PublishLayerAsPublicWithOptions(string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PublishLayerAsPublicResponse>(DoROARequest("PublishLayerAsPublic", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/layers/" + layerName + "/versions/" + version, "none", req, runtime));
        }

        public async Task<PublishLayerAsPublicResponse> PublishLayerAsPublicWithOptionsAsync(string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            layerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PublishLayerAsPublicResponse>(await DoROARequestAsync("PublishLayerAsPublic", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/layers/" + layerName + "/versions/" + version, "none", req, runtime));
        }

        public PublishServiceVersionResponse PublishServiceVersion(string serviceName, PublishServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishServiceVersionHeaders headers = new PublishServiceVersionHeaders();
            return PublishServiceVersionWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<PublishServiceVersionResponse> PublishServiceVersionAsync(string serviceName, PublishServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishServiceVersionHeaders headers = new PublishServiceVersionHeaders();
            return await PublishServiceVersionWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public PublishServiceVersionResponse PublishServiceVersionWithOptions(string serviceName, PublishServiceVersionRequest request, PublishServiceVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PublishServiceVersionResponse>(DoROARequest("PublishServiceVersion", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/versions", "json", req, runtime));
        }

        public async Task<PublishServiceVersionResponse> PublishServiceVersionWithOptionsAsync(string serviceName, PublishServiceVersionRequest request, PublishServiceVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PublishServiceVersionResponse>(await DoROARequestAsync("PublishServiceVersion", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/versions", "json", req, runtime));
        }

        public PutFunctionAsyncInvokeConfigResponse PutFunctionAsyncInvokeConfig(string serviceName, string functionName, PutFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutFunctionAsyncInvokeConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<PutFunctionAsyncInvokeConfigResponse> PutFunctionAsyncInvokeConfigAsync(string serviceName, string functionName, PutFunctionAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutFunctionAsyncInvokeConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public PutFunctionAsyncInvokeConfigResponse PutFunctionAsyncInvokeConfigWithOptions(string serviceName, string functionName, PutFunctionAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationConfig.ToMap()))
            {
                body["destinationConfig"] = request.DestinationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAsyncEventAgeInSeconds))
            {
                body["maxAsyncEventAgeInSeconds"] = request.MaxAsyncEventAgeInSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAsyncRetryAttempts))
            {
                body["maxAsyncRetryAttempts"] = request.MaxAsyncRetryAttempts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatefulInvocation))
            {
                body["statefulInvocation"] = request.StatefulInvocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PutFunctionAsyncInvokeConfigResponse>(DoROARequest("PutFunctionAsyncInvokeConfig", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/async-invoke-config", "json", req, runtime));
        }

        public async Task<PutFunctionAsyncInvokeConfigResponse> PutFunctionAsyncInvokeConfigWithOptionsAsync(string serviceName, string functionName, PutFunctionAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationConfig.ToMap()))
            {
                body["destinationConfig"] = request.DestinationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAsyncEventAgeInSeconds))
            {
                body["maxAsyncEventAgeInSeconds"] = request.MaxAsyncEventAgeInSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAsyncRetryAttempts))
            {
                body["maxAsyncRetryAttempts"] = request.MaxAsyncRetryAttempts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatefulInvocation))
            {
                body["statefulInvocation"] = request.StatefulInvocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PutFunctionAsyncInvokeConfigResponse>(await DoROARequestAsync("PutFunctionAsyncInvokeConfig", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/async-invoke-config", "json", req, runtime));
        }

        public PutFunctionOnDemandConfigResponse PutFunctionOnDemandConfig(string serviceName, string functionName, PutFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutFunctionOnDemandConfigHeaders headers = new PutFunctionOnDemandConfigHeaders();
            return PutFunctionOnDemandConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<PutFunctionOnDemandConfigResponse> PutFunctionOnDemandConfigAsync(string serviceName, string functionName, PutFunctionOnDemandConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PutFunctionOnDemandConfigHeaders headers = new PutFunctionOnDemandConfigHeaders();
            return await PutFunctionOnDemandConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public PutFunctionOnDemandConfigResponse PutFunctionOnDemandConfigWithOptions(string serviceName, string functionName, PutFunctionOnDemandConfigRequest request, PutFunctionOnDemandConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumInstanceCount))
            {
                body["maximumInstanceCount"] = request.MaximumInstanceCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PutFunctionOnDemandConfigResponse>(DoROARequest("PutFunctionOnDemandConfig", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/on-demand-config", "json", req, runtime));
        }

        public async Task<PutFunctionOnDemandConfigResponse> PutFunctionOnDemandConfigWithOptionsAsync(string serviceName, string functionName, PutFunctionOnDemandConfigRequest request, PutFunctionOnDemandConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumInstanceCount))
            {
                body["maximumInstanceCount"] = request.MaximumInstanceCount;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PutFunctionOnDemandConfigResponse>(await DoROARequestAsync("PutFunctionOnDemandConfig", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/on-demand-config", "json", req, runtime));
        }

        public PutProvisionConfigResponse PutProvisionConfig(string serviceName, string functionName, PutProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutProvisionConfigWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<PutProvisionConfigResponse> PutProvisionConfigAsync(string serviceName, string functionName, PutProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutProvisionConfigWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public PutProvisionConfigResponse PutProvisionConfigWithOptions(string serviceName, string functionName, PutProvisionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledActions))
            {
                body["scheduledActions"] = request.ScheduledActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTrackingPolicies))
            {
                body["targetTrackingPolicies"] = request.TargetTrackingPolicies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PutProvisionConfigResponse>(DoROARequest("PutProvisionConfig", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/provision-config", "json", req, runtime));
        }

        public async Task<PutProvisionConfigResponse> PutProvisionConfigWithOptionsAsync(string serviceName, string functionName, PutProvisionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledActions))
            {
                body["scheduledActions"] = request.ScheduledActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTrackingPolicies))
            {
                body["targetTrackingPolicies"] = request.TargetTrackingPolicies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PutProvisionConfigResponse>(await DoROARequestAsync("PutProvisionConfig", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/provision-config", "json", req, runtime));
        }

        public RegisterEventSourceResponse RegisterEventSource(string serviceName, string functionName, RegisterEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RegisterEventSourceWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<RegisterEventSourceResponse> RegisterEventSourceAsync(string serviceName, string functionName, RegisterEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RegisterEventSourceWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public RegisterEventSourceResponse RegisterEventSourceWithOptions(string serviceName, string functionName, RegisterEventSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["sourceArn"] = request.SourceArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RegisterEventSourceResponse>(DoROARequest("RegisterEventSource", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/event-sources", "json", req, runtime));
        }

        public async Task<RegisterEventSourceResponse> RegisterEventSourceWithOptionsAsync(string serviceName, string functionName, RegisterEventSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["sourceArn"] = request.SourceArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<RegisterEventSourceResponse>(await DoROARequestAsync("RegisterEventSource", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/event-sources", "json", req, runtime));
        }

        public StopStatefulAsyncInvocationResponse StopStatefulAsyncInvocation(string serviceName, string functionName, string invocationId, StopStatefulAsyncInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopStatefulAsyncInvocationWithOptions(serviceName, functionName, invocationId, request, headers, runtime);
        }

        public async Task<StopStatefulAsyncInvocationResponse> StopStatefulAsyncInvocationAsync(string serviceName, string functionName, string invocationId, StopStatefulAsyncInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopStatefulAsyncInvocationWithOptionsAsync(serviceName, functionName, invocationId, request, headers, runtime);
        }

        public StopStatefulAsyncInvocationResponse StopStatefulAsyncInvocationWithOptions(string serviceName, string functionName, string invocationId, StopStatefulAsyncInvocationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            invocationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(invocationId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<StopStatefulAsyncInvocationResponse>(DoROARequest("StopStatefulAsyncInvocation", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/stateful-async-invocations/" + invocationId, "none", req, runtime));
        }

        public async Task<StopStatefulAsyncInvocationResponse> StopStatefulAsyncInvocationWithOptionsAsync(string serviceName, string functionName, string invocationId, StopStatefulAsyncInvocationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            invocationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(invocationId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<StopStatefulAsyncInvocationResponse>(await DoROARequestAsync("StopStatefulAsyncInvocation", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/stateful-async-invocations/" + invocationId, "none", req, runtime));
        }

        public TagResourceResponse TagResource(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourceWithOptions(request, headers, runtime);
        }

        public async Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourceWithOptionsAsync(request, headers, runtime);
        }

        public TagResourceResponse TagResourceWithOptions(TagResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["resourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<TagResourceResponse>(DoROARequest("TagResource", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/tag", "none", req, runtime));
        }

        public async Task<TagResourceResponse> TagResourceWithOptionsAsync(TagResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["resourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<TagResourceResponse>(await DoROARequestAsync("TagResource", "2021-04-06", "HTTPS", "POST", "AK", "/2021-04-06/tag", "none", req, runtime));
        }

        public UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourceWithOptions(request, headers, runtime);
        }

        public async Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourceWithOptionsAsync(request, headers, runtime);
        }

        public UntagResourceResponse UntagResourceWithOptions(UntagResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["resourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                body["tagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UntagResourceResponse>(DoROARequest("UntagResource", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/tag", "none", req, runtime));
        }

        public async Task<UntagResourceResponse> UntagResourceWithOptionsAsync(UntagResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["resourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                body["tagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UntagResourceResponse>(await DoROARequestAsync("UntagResource", "2021-04-06", "HTTPS", "DELETE", "AK", "/2021-04-06/tag", "none", req, runtime));
        }

        public UpdateAliasResponse UpdateAlias(string serviceName, string aliasName, UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAliasHeaders headers = new UpdateAliasHeaders();
            return UpdateAliasWithOptions(serviceName, aliasName, request, headers, runtime);
        }

        public async Task<UpdateAliasResponse> UpdateAliasAsync(string serviceName, string aliasName, UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAliasHeaders headers = new UpdateAliasHeaders();
            return await UpdateAliasWithOptionsAsync(serviceName, aliasName, request, headers, runtime);
        }

        public UpdateAliasResponse UpdateAliasWithOptions(string serviceName, string aliasName, UpdateAliasRequest request, UpdateAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            aliasName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalVersionWeight))
            {
                body["additionalVersionWeight"] = request.AdditionalVersionWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["versionId"] = request.VersionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateAliasResponse>(DoROARequest("UpdateAlias", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/aliases/" + aliasName, "json", req, runtime));
        }

        public async Task<UpdateAliasResponse> UpdateAliasWithOptionsAsync(string serviceName, string aliasName, UpdateAliasRequest request, UpdateAliasHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            aliasName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalVersionWeight))
            {
                body["additionalVersionWeight"] = request.AdditionalVersionWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["versionId"] = request.VersionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateAliasResponse>(await DoROARequestAsync("UpdateAlias", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/aliases/" + aliasName, "json", req, runtime));
        }

        public UpdateCustomDomainResponse UpdateCustomDomain(string domainName, UpdateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCustomDomainWithOptions(domainName, request, headers, runtime);
        }

        public async Task<UpdateCustomDomainResponse> UpdateCustomDomainAsync(string domainName, UpdateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCustomDomainWithOptionsAsync(domainName, request, headers, runtime);
        }

        public UpdateCustomDomainResponse UpdateCustomDomainWithOptions(string domainName, UpdateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            domainName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertConfig.ToMap()))
            {
                body["certConfig"] = request.CertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteConfig.ToMap()))
            {
                body["routeConfig"] = request.RouteConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateCustomDomainResponse>(DoROARequest("UpdateCustomDomain", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/custom-domains/" + domainName, "json", req, runtime));
        }

        public async Task<UpdateCustomDomainResponse> UpdateCustomDomainWithOptionsAsync(string domainName, UpdateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            domainName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertConfig.ToMap()))
            {
                body["certConfig"] = request.CertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteConfig.ToMap()))
            {
                body["routeConfig"] = request.RouteConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateCustomDomainResponse>(await DoROARequestAsync("UpdateCustomDomain", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/custom-domains/" + domainName, "json", req, runtime));
        }

        public UpdateFunctionResponse UpdateFunction(string serviceName, string functionName, UpdateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFunctionHeaders headers = new UpdateFunctionHeaders();
            return UpdateFunctionWithOptions(serviceName, functionName, request, headers, runtime);
        }

        public async Task<UpdateFunctionResponse> UpdateFunctionAsync(string serviceName, string functionName, UpdateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFunctionHeaders headers = new UpdateFunctionHeaders();
            return await UpdateFunctionWithOptionsAsync(serviceName, functionName, request, headers, runtime);
        }

        public UpdateFunctionResponse UpdateFunctionWithOptions(string serviceName, string functionName, UpdateFunctionRequest request, UpdateFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceConcurrency))
            {
                body["InstanceConcurrency"] = request.InstanceConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaPort))
            {
                body["caPort"] = request.CaPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code.ToMap()))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomContainerConfig.ToMap()))
            {
                body["customContainerConfig"] = request.CustomContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["environmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                body["handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitializationTimeout))
            {
                body["initializationTimeout"] = request.InitializationTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Initializer))
            {
                body["initializer"] = request.Initializer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLifecycleConfig.ToMap()))
            {
                body["instanceLifecycleConfig"] = request.InstanceLifecycleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layers))
            {
                body["layers"] = request.Layers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemorySize))
            {
                body["memorySize"] = request.MemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = headers.XFcAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["x-fc-code-checksum"] = headers.XFcCodeChecksum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateFunctionResponse>(DoROARequest("UpdateFunction", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName, "json", req, runtime));
        }

        public async Task<UpdateFunctionResponse> UpdateFunctionWithOptionsAsync(string serviceName, string functionName, UpdateFunctionRequest request, UpdateFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceConcurrency))
            {
                body["InstanceConcurrency"] = request.InstanceConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaPort))
            {
                body["caPort"] = request.CaPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code.ToMap()))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomContainerConfig.ToMap()))
            {
                body["customContainerConfig"] = request.CustomContainerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentVariables))
            {
                body["environmentVariables"] = request.EnvironmentVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Handler))
            {
                body["handler"] = request.Handler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitializationTimeout))
            {
                body["initializationTimeout"] = request.InitializationTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Initializer))
            {
                body["initializer"] = request.Initializer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceLifecycleConfig.ToMap()))
            {
                body["instanceLifecycleConfig"] = request.InstanceLifecycleConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["instanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layers))
            {
                body["layers"] = request.Layers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemorySize))
            {
                body["memorySize"] = request.MemorySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = headers.XFcAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcCodeChecksum))
            {
                realHeaders["x-fc-code-checksum"] = headers.XFcCodeChecksum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateFunctionResponse>(await DoROARequestAsync("UpdateFunction", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName, "json", req, runtime));
        }

        public UpdateServiceResponse UpdateService(string serviceName, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateServiceHeaders headers = new UpdateServiceHeaders();
            return UpdateServiceWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<UpdateServiceResponse> UpdateServiceAsync(string serviceName, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateServiceHeaders headers = new UpdateServiceHeaders();
            return await UpdateServiceWithOptionsAsync(serviceName, request, headers, runtime);
        }

        public UpdateServiceResponse UpdateServiceWithOptions(string serviceName, UpdateServiceRequest request, UpdateServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetAccess))
            {
                body["internetAccess"] = request.InternetAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogConfig.ToMap()))
            {
                body["logConfig"] = request.LogConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfig.ToMap()))
            {
                body["nasConfig"] = request.NasConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingConfig.ToMap()))
            {
                body["tracingConfig"] = request.TracingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcConfig.ToMap()))
            {
                body["vpcConfig"] = request.VpcConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = headers.XFcAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateServiceResponse>(DoROARequest("UpdateService", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName, "json", req, runtime));
        }

        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(string serviceName, UpdateServiceRequest request, UpdateServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetAccess))
            {
                body["internetAccess"] = request.InternetAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogConfig.ToMap()))
            {
                body["logConfig"] = request.LogConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfig.ToMap()))
            {
                body["nasConfig"] = request.NasConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingConfig.ToMap()))
            {
                body["tracingConfig"] = request.TracingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcConfig.ToMap()))
            {
                body["vpcConfig"] = request.VpcConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = headers.XFcAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await DoROARequestAsync("UpdateService", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName, "json", req, runtime));
        }

        public UpdateTriggerResponse UpdateTrigger(string serviceName, string functionName, string triggerName, UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
            return UpdateTriggerWithOptions(serviceName, functionName, triggerName, request, headers, runtime);
        }

        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(string serviceName, string functionName, string triggerName, UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
            return await UpdateTriggerWithOptionsAsync(serviceName, functionName, triggerName, request, headers, runtime);
        }

        public UpdateTriggerResponse UpdateTriggerWithOptions(string serviceName, string functionName, string triggerName, UpdateTriggerRequest request, UpdateTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            triggerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationRole))
            {
                body["invocationRole"] = request.InvocationRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = headers.XFcAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(DoROARequest("UpdateTrigger", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/triggers/" + triggerName, "json", req, runtime));
        }

        public async Task<UpdateTriggerResponse> UpdateTriggerWithOptionsAsync(string serviceName, string functionName, string triggerName, UpdateTriggerRequest request, UpdateTriggerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            serviceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceName);
            functionName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName);
            triggerName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationRole))
            {
                body["invocationRole"] = request.InvocationRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                body["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.IfMatch))
            {
                realHeaders["If-Match"] = headers.IfMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAccountId))
            {
                realHeaders["X-Fc-Account-Id"] = headers.XFcAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(await DoROARequestAsync("UpdateTrigger", "2021-04-06", "HTTPS", "PUT", "AK", "/2021-04-06/services/" + serviceName + "/functions/" + functionName + "/triggers/" + triggerName, "json", req, runtime));
        }

    }
}
