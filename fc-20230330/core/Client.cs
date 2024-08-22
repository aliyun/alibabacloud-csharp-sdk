// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.FC20230330.Models;

namespace AlibabaCloud.SDK.FC20230330
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("fc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 创建函数别名。
         *
         * @param request CreateAliasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAliasResponse
         */
        public CreateAliasResponse CreateAliasWithOptions(string functionName, CreateAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlias",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/aliases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建函数别名。
         *
         * @param request CreateAliasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAliasResponse
         */
        public async Task<CreateAliasResponse> CreateAliasWithOptionsAsync(string functionName, CreateAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlias",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/aliases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建函数别名。
         *
         * @param request CreateAliasRequest
         * @return CreateAliasResponse
         */
        public CreateAliasResponse CreateAlias(string functionName, CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAliasWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary 创建函数别名。
         *
         * @param request CreateAliasRequest
         * @return CreateAliasResponse
         */
        public async Task<CreateAliasResponse> CreateAliasAsync(string functionName, CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAliasWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Creates a custom domain name.
         *
         * @description If you wish to access applications or functions created in Function Compute via a fixed domain name in a production environment, or if you need to address the forced download behavior when accessing HTTP triggers, you can achieve this by binding a custom domain to your application or function.
         *
         * @param request CreateCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomDomainResponse
         */
        public CreateCustomDomainResponse CreateCustomDomainWithOptions(CreateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomDomain",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/custom-domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a custom domain name.
         *
         * @description If you wish to access applications or functions created in Function Compute via a fixed domain name in a production environment, or if you need to address the forced download behavior when accessing HTTP triggers, you can achieve this by binding a custom domain to your application or function.
         *
         * @param request CreateCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomDomainResponse
         */
        public async Task<CreateCustomDomainResponse> CreateCustomDomainWithOptionsAsync(CreateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomDomain",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/custom-domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a custom domain name.
         *
         * @description If you wish to access applications or functions created in Function Compute via a fixed domain name in a production environment, or if you need to address the forced download behavior when accessing HTTP triggers, you can achieve this by binding a custom domain to your application or function.
         *
         * @param request CreateCustomDomainRequest
         * @return CreateCustomDomainResponse
         */
        public CreateCustomDomainResponse CreateCustomDomain(CreateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCustomDomainWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a custom domain name.
         *
         * @description If you wish to access applications or functions created in Function Compute via a fixed domain name in a production environment, or if you need to address the forced download behavior when accessing HTTP triggers, you can achieve this by binding a custom domain to your application or function.
         *
         * @param request CreateCustomDomainRequest
         * @return CreateCustomDomainResponse
         */
        public async Task<CreateCustomDomainResponse> CreateCustomDomainAsync(CreateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCustomDomainWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a function.
         *
         * @description In Function Compute, a function serves as the smallest unit of resource scheduling and execution, typically referring to a piece of code written by users that can execute independently in response to specific events or requests.
         *
         * @param request CreateFunctionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFunctionResponse
         */
        public CreateFunctionResponse CreateFunctionWithOptions(CreateFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunction",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a function.
         *
         * @description In Function Compute, a function serves as the smallest unit of resource scheduling and execution, typically referring to a piece of code written by users that can execute independently in response to specific events or requests.
         *
         * @param request CreateFunctionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFunctionResponse
         */
        public async Task<CreateFunctionResponse> CreateFunctionWithOptionsAsync(CreateFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunction",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a function.
         *
         * @description In Function Compute, a function serves as the smallest unit of resource scheduling and execution, typically referring to a piece of code written by users that can execute independently in response to specific events or requests.
         *
         * @param request CreateFunctionRequest
         * @return CreateFunctionResponse
         */
        public CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFunctionWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a function.
         *
         * @description In Function Compute, a function serves as the smallest unit of resource scheduling and execution, typically referring to a piece of code written by users that can execute independently in response to specific events or requests.
         *
         * @param request CreateFunctionRequest
         * @return CreateFunctionResponse
         */
        public async Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFunctionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建层版本。
         *
         * @param request CreateLayerVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLayerVersionResponse
         */
        public CreateLayerVersionResponse CreateLayerVersionWithOptions(string layerName, CreateLayerVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLayerVersion",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLayerVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建层版本。
         *
         * @param request CreateLayerVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLayerVersionResponse
         */
        public async Task<CreateLayerVersionResponse> CreateLayerVersionWithOptionsAsync(string layerName, CreateLayerVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLayerVersion",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLayerVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建层版本。
         *
         * @param request CreateLayerVersionRequest
         * @return CreateLayerVersionResponse
         */
        public CreateLayerVersionResponse CreateLayerVersion(string layerName, CreateLayerVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLayerVersionWithOptions(layerName, request, headers, runtime);
        }

        /**
         * @summary 创建层版本。
         *
         * @param request CreateLayerVersionRequest
         * @return CreateLayerVersionResponse
         */
        public async Task<CreateLayerVersionResponse> CreateLayerVersionAsync(string layerName, CreateLayerVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLayerVersionWithOptionsAsync(layerName, request, headers, runtime);
        }

        /**
         * @summary 创建函数触发器。
         *
         * @param request CreateTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTriggerResponse
         */
        public CreateTriggerResponse CreateTriggerWithOptions(string functionName, CreateTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrigger",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建函数触发器。
         *
         * @param request CreateTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTriggerResponse
         */
        public async Task<CreateTriggerResponse> CreateTriggerWithOptionsAsync(string functionName, CreateTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrigger",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建函数触发器。
         *
         * @param request CreateTriggerRequest
         * @return CreateTriggerResponse
         */
        public CreateTriggerResponse CreateTrigger(string functionName, CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTriggerWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary 创建函数触发器。
         *
         * @param request CreateTriggerRequest
         * @return CreateTriggerResponse
         */
        public async Task<CreateTriggerResponse> CreateTriggerAsync(string functionName, CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTriggerWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Creates a VPC connection.
         *
         * @param request CreateVpcBindingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVpcBindingResponse
         */
        public CreateVpcBindingResponse CreateVpcBindingWithOptions(string functionName, CreateVpcBindingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcBinding",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/vpc-bindings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateVpcBindingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a VPC connection.
         *
         * @param request CreateVpcBindingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVpcBindingResponse
         */
        public async Task<CreateVpcBindingResponse> CreateVpcBindingWithOptionsAsync(string functionName, CreateVpcBindingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcBinding",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/vpc-bindings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateVpcBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a VPC connection.
         *
         * @param request CreateVpcBindingRequest
         * @return CreateVpcBindingResponse
         */
        public CreateVpcBindingResponse CreateVpcBinding(string functionName, CreateVpcBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVpcBindingWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Creates a VPC connection.
         *
         * @param request CreateVpcBindingRequest
         * @return CreateVpcBindingResponse
         */
        public async Task<CreateVpcBindingResponse> CreateVpcBindingAsync(string functionName, CreateVpcBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVpcBindingWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Deletes an alias.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAliasResponse
         */
        public DeleteAliasResponse DeleteAliasWithOptions(string functionName, string aliasName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlias",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an alias.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAliasResponse
         */
        public async Task<DeleteAliasResponse> DeleteAliasWithOptionsAsync(string functionName, string aliasName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlias",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an alias.
         *
         * @return DeleteAliasResponse
         */
        public DeleteAliasResponse DeleteAlias(string functionName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAliasWithOptions(functionName, aliasName, headers, runtime);
        }

        /**
         * @summary Deletes an alias.
         *
         * @return DeleteAliasResponse
         */
        public async Task<DeleteAliasResponse> DeleteAliasAsync(string functionName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAliasWithOptionsAsync(functionName, aliasName, headers, runtime);
        }

        /**
         * @summary Deletes an asynchronous invocation configuration.
         *
         * @param request DeleteAsyncInvokeConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAsyncInvokeConfigResponse
         */
        public DeleteAsyncInvokeConfigResponse DeleteAsyncInvokeConfigWithOptions(string functionName, DeleteAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAsyncInvokeConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAsyncInvokeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an asynchronous invocation configuration.
         *
         * @param request DeleteAsyncInvokeConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAsyncInvokeConfigResponse
         */
        public async Task<DeleteAsyncInvokeConfigResponse> DeleteAsyncInvokeConfigWithOptionsAsync(string functionName, DeleteAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAsyncInvokeConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAsyncInvokeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an asynchronous invocation configuration.
         *
         * @param request DeleteAsyncInvokeConfigRequest
         * @return DeleteAsyncInvokeConfigResponse
         */
        public DeleteAsyncInvokeConfigResponse DeleteAsyncInvokeConfig(string functionName, DeleteAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAsyncInvokeConfigWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Deletes an asynchronous invocation configuration.
         *
         * @param request DeleteAsyncInvokeConfigRequest
         * @return DeleteAsyncInvokeConfigResponse
         */
        public async Task<DeleteAsyncInvokeConfigResponse> DeleteAsyncInvokeConfigAsync(string functionName, DeleteAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAsyncInvokeConfigWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Deletes a concurrency configuration.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConcurrencyConfigResponse
         */
        public DeleteConcurrencyConfigResponse DeleteConcurrencyConfigWithOptions(string functionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConcurrencyConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/concurrency",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteConcurrencyConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a concurrency configuration.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConcurrencyConfigResponse
         */
        public async Task<DeleteConcurrencyConfigResponse> DeleteConcurrencyConfigWithOptionsAsync(string functionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConcurrencyConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/concurrency",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteConcurrencyConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a concurrency configuration.
         *
         * @return DeleteConcurrencyConfigResponse
         */
        public DeleteConcurrencyConfigResponse DeleteConcurrencyConfig(string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConcurrencyConfigWithOptions(functionName, headers, runtime);
        }

        /**
         * @summary Deletes a concurrency configuration.
         *
         * @return DeleteConcurrencyConfigResponse
         */
        public async Task<DeleteConcurrencyConfigResponse> DeleteConcurrencyConfigAsync(string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConcurrencyConfigWithOptionsAsync(functionName, headers, runtime);
        }

        /**
         * @summary Deletes a custom domain name.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomDomainResponse
         */
        public DeleteCustomDomainResponse DeleteCustomDomainWithOptions(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomDomain",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a custom domain name.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomDomainResponse
         */
        public async Task<DeleteCustomDomainResponse> DeleteCustomDomainWithOptionsAsync(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomDomain",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a custom domain name.
         *
         * @return DeleteCustomDomainResponse
         */
        public DeleteCustomDomainResponse DeleteCustomDomain(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCustomDomainWithOptions(domainName, headers, runtime);
        }

        /**
         * @summary Deletes a custom domain name.
         *
         * @return DeleteCustomDomainResponse
         */
        public async Task<DeleteCustomDomainResponse> DeleteCustomDomainAsync(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCustomDomainWithOptionsAsync(domainName, headers, runtime);
        }

        /**
         * @summary Deletes a function.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFunctionResponse
         */
        public DeleteFunctionResponse DeleteFunctionWithOptions(string functionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunction",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFunctionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a function.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFunctionResponse
         */
        public async Task<DeleteFunctionResponse> DeleteFunctionWithOptionsAsync(string functionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunction",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a function.
         *
         * @return DeleteFunctionResponse
         */
        public DeleteFunctionResponse DeleteFunction(string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFunctionWithOptions(functionName, headers, runtime);
        }

        /**
         * @summary Deletes a function.
         *
         * @return DeleteFunctionResponse
         */
        public async Task<DeleteFunctionResponse> DeleteFunctionAsync(string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFunctionWithOptionsAsync(functionName, headers, runtime);
        }

        /**
         * @summary Deletes a function version.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFunctionVersionResponse
         */
        public DeleteFunctionVersionResponse DeleteFunctionVersionWithOptions(string functionName, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionVersion",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFunctionVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a function version.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFunctionVersionResponse
         */
        public async Task<DeleteFunctionVersionResponse> DeleteFunctionVersionWithOptionsAsync(string functionName, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionVersion",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteFunctionVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a function version.
         *
         * @return DeleteFunctionVersionResponse
         */
        public DeleteFunctionVersionResponse DeleteFunctionVersion(string functionName, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFunctionVersionWithOptions(functionName, versionId, headers, runtime);
        }

        /**
         * @summary Deletes a function version.
         *
         * @return DeleteFunctionVersionResponse
         */
        public async Task<DeleteFunctionVersionResponse> DeleteFunctionVersionAsync(string functionName, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFunctionVersionWithOptionsAsync(functionName, versionId, headers, runtime);
        }

        /**
         * @summary Deletes a layer version.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLayerVersionResponse
         */
        public DeleteLayerVersionResponse DeleteLayerVersionWithOptions(string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayerVersion",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteLayerVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a layer version.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLayerVersionResponse
         */
        public async Task<DeleteLayerVersionResponse> DeleteLayerVersionWithOptionsAsync(string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayerVersion",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteLayerVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a layer version.
         *
         * @return DeleteLayerVersionResponse
         */
        public DeleteLayerVersionResponse DeleteLayerVersion(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLayerVersionWithOptions(layerName, version, headers, runtime);
        }

        /**
         * @summary Deletes a layer version.
         *
         * @return DeleteLayerVersionResponse
         */
        public async Task<DeleteLayerVersionResponse> DeleteLayerVersionAsync(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLayerVersionWithOptionsAsync(layerName, version, headers, runtime);
        }

        /**
         * @summary Deletes a provisioned configuration.
         *
         * @param request DeleteProvisionConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProvisionConfigResponse
         */
        public DeleteProvisionConfigResponse DeleteProvisionConfigWithOptions(string functionName, DeleteProvisionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProvisionConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/provision-config",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteProvisionConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a provisioned configuration.
         *
         * @param request DeleteProvisionConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProvisionConfigResponse
         */
        public async Task<DeleteProvisionConfigResponse> DeleteProvisionConfigWithOptionsAsync(string functionName, DeleteProvisionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProvisionConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/provision-config",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteProvisionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a provisioned configuration.
         *
         * @param request DeleteProvisionConfigRequest
         * @return DeleteProvisionConfigResponse
         */
        public DeleteProvisionConfigResponse DeleteProvisionConfig(string functionName, DeleteProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProvisionConfigWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Deletes a provisioned configuration.
         *
         * @param request DeleteProvisionConfigRequest
         * @return DeleteProvisionConfigResponse
         */
        public async Task<DeleteProvisionConfigResponse> DeleteProvisionConfigAsync(string functionName, DeleteProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProvisionConfigWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Deletes a trigger.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTriggerResponse
         */
        public DeleteTriggerResponse DeleteTriggerWithOptions(string functionName, string triggerName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrigger",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a trigger.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTriggerResponse
         */
        public async Task<DeleteTriggerResponse> DeleteTriggerWithOptionsAsync(string functionName, string triggerName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrigger",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a trigger.
         *
         * @return DeleteTriggerResponse
         */
        public DeleteTriggerResponse DeleteTrigger(string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTriggerWithOptions(functionName, triggerName, headers, runtime);
        }

        /**
         * @summary Deletes a trigger.
         *
         * @return DeleteTriggerResponse
         */
        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTriggerWithOptionsAsync(functionName, triggerName, headers, runtime);
        }

        /**
         * @summary Deletes an access control policy from a specified policy group for a VPC firewall.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVpcBindingResponse
         */
        public DeleteVpcBindingResponse DeleteVpcBindingWithOptions(string functionName, string vpcId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcBinding",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/vpc-bindings/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(vpcId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteVpcBindingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control policy from a specified policy group for a VPC firewall.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVpcBindingResponse
         */
        public async Task<DeleteVpcBindingResponse> DeleteVpcBindingWithOptionsAsync(string functionName, string vpcId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcBinding",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/vpc-bindings/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(vpcId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteVpcBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control policy from a specified policy group for a VPC firewall.
         *
         * @return DeleteVpcBindingResponse
         */
        public DeleteVpcBindingResponse DeleteVpcBinding(string functionName, string vpcId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVpcBindingWithOptions(functionName, vpcId, headers, runtime);
        }

        /**
         * @summary Deletes an access control policy from a specified policy group for a VPC firewall.
         *
         * @return DeleteVpcBindingResponse
         */
        public async Task<DeleteVpcBindingResponse> DeleteVpcBindingAsync(string functionName, string vpcId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVpcBindingWithOptionsAsync(functionName, vpcId, headers, runtime);
        }

        /**
         * @summary Queries information about an alias.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAliasResponse
         */
        public GetAliasResponse GetAliasWithOptions(string functionName, string aliasName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlias",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries information about an alias.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAliasResponse
         */
        public async Task<GetAliasResponse> GetAliasWithOptionsAsync(string functionName, string aliasName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlias",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries information about an alias.
         *
         * @return GetAliasResponse
         */
        public GetAliasResponse GetAlias(string functionName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAliasWithOptions(functionName, aliasName, headers, runtime);
        }

        /**
         * @summary Queries information about an alias.
         *
         * @return GetAliasResponse
         */
        public async Task<GetAliasResponse> GetAliasAsync(string functionName, string aliasName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAliasWithOptionsAsync(functionName, aliasName, headers, runtime);
        }

        /**
         * @summary Gets asynchronous invocation configurations of a function.
         *
         * @param request GetAsyncInvokeConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsyncInvokeConfigResponse
         */
        public GetAsyncInvokeConfigResponse GetAsyncInvokeConfigWithOptions(string functionName, GetAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncInvokeConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncInvokeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Gets asynchronous invocation configurations of a function.
         *
         * @param request GetAsyncInvokeConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsyncInvokeConfigResponse
         */
        public async Task<GetAsyncInvokeConfigResponse> GetAsyncInvokeConfigWithOptionsAsync(string functionName, GetAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncInvokeConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncInvokeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Gets asynchronous invocation configurations of a function.
         *
         * @param request GetAsyncInvokeConfigRequest
         * @return GetAsyncInvokeConfigResponse
         */
        public GetAsyncInvokeConfigResponse GetAsyncInvokeConfig(string functionName, GetAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAsyncInvokeConfigWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Gets asynchronous invocation configurations of a function.
         *
         * @param request GetAsyncInvokeConfigRequest
         * @return GetAsyncInvokeConfigResponse
         */
        public async Task<GetAsyncInvokeConfigResponse> GetAsyncInvokeConfigAsync(string functionName, GetAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAsyncInvokeConfigWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries the information about an asynchronous task.
         *
         * @param request GetAsyncTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsyncTaskResponse
         */
        public GetAsyncTaskResponse GetAsyncTaskWithOptions(string functionName, string taskId, GetAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncTask",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an asynchronous task.
         *
         * @param request GetAsyncTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsyncTaskResponse
         */
        public async Task<GetAsyncTaskResponse> GetAsyncTaskWithOptionsAsync(string functionName, string taskId, GetAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncTask",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an asynchronous task.
         *
         * @param request GetAsyncTaskRequest
         * @return GetAsyncTaskResponse
         */
        public GetAsyncTaskResponse GetAsyncTask(string functionName, string taskId, GetAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAsyncTaskWithOptions(functionName, taskId, request, headers, runtime);
        }

        /**
         * @summary Queries the information about an asynchronous task.
         *
         * @param request GetAsyncTaskRequest
         * @return GetAsyncTaskResponse
         */
        public async Task<GetAsyncTaskResponse> GetAsyncTaskAsync(string functionName, string taskId, GetAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAsyncTaskWithOptionsAsync(functionName, taskId, request, headers, runtime);
        }

        /**
         * @summary Obtains a concurrency configuration.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConcurrencyConfigResponse
         */
        public GetConcurrencyConfigResponse GetConcurrencyConfigWithOptions(string functionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConcurrencyConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/concurrency",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConcurrencyConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains a concurrency configuration.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConcurrencyConfigResponse
         */
        public async Task<GetConcurrencyConfigResponse> GetConcurrencyConfigWithOptionsAsync(string functionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConcurrencyConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/concurrency",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConcurrencyConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains a concurrency configuration.
         *
         * @return GetConcurrencyConfigResponse
         */
        public GetConcurrencyConfigResponse GetConcurrencyConfig(string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConcurrencyConfigWithOptions(functionName, headers, runtime);
        }

        /**
         * @summary Obtains a concurrency configuration.
         *
         * @return GetConcurrencyConfigResponse
         */
        public async Task<GetConcurrencyConfigResponse> GetConcurrencyConfigAsync(string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConcurrencyConfigWithOptionsAsync(functionName, headers, runtime);
        }

        /**
         * @summary Queries information about a custom domain name.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomDomainResponse
         */
        public GetCustomDomainResponse GetCustomDomainWithOptions(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomDomain",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries information about a custom domain name.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomDomainResponse
         */
        public async Task<GetCustomDomainResponse> GetCustomDomainWithOptionsAsync(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomDomain",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries information about a custom domain name.
         *
         * @return GetCustomDomainResponse
         */
        public GetCustomDomainResponse GetCustomDomain(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCustomDomainWithOptions(domainName, headers, runtime);
        }

        /**
         * @summary Queries information about a custom domain name.
         *
         * @return GetCustomDomainResponse
         */
        public async Task<GetCustomDomainResponse> GetCustomDomainAsync(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCustomDomainWithOptionsAsync(domainName, headers, runtime);
        }

        /**
         * @summary Queries information about a function.
         *
         * @param request GetFunctionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFunctionResponse
         */
        public GetFunctionResponse GetFunctionWithOptions(string functionName, GetFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunction",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries information about a function.
         *
         * @param request GetFunctionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFunctionResponse
         */
        public async Task<GetFunctionResponse> GetFunctionWithOptionsAsync(string functionName, GetFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunction",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries information about a function.
         *
         * @param request GetFunctionRequest
         * @return GetFunctionResponse
         */
        public GetFunctionResponse GetFunction(string functionName, GetFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries information about a function.
         *
         * @param request GetFunctionRequest
         * @return GetFunctionResponse
         */
        public async Task<GetFunctionResponse> GetFunctionAsync(string functionName, GetFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries a code package of a function.
         *
         * @param request GetFunctionCodeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFunctionCodeResponse
         */
        public GetFunctionCodeResponse GetFunctionCodeWithOptions(string functionName, GetFunctionCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionCode",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/code",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a code package of a function.
         *
         * @param request GetFunctionCodeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFunctionCodeResponse
         */
        public async Task<GetFunctionCodeResponse> GetFunctionCodeWithOptionsAsync(string functionName, GetFunctionCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionCode",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/code",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a code package of a function.
         *
         * @param request GetFunctionCodeRequest
         * @return GetFunctionCodeResponse
         */
        public GetFunctionCodeResponse GetFunctionCode(string functionName, GetFunctionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionCodeWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries a code package of a function.
         *
         * @param request GetFunctionCodeRequest
         * @return GetFunctionCodeResponse
         */
        public async Task<GetFunctionCodeResponse> GetFunctionCodeAsync(string functionName, GetFunctionCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionCodeWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries versions of a layer.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLayerVersionResponse
         */
        public GetLayerVersionResponse GetLayerVersionWithOptions(string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLayerVersion",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLayerVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries versions of a layer.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLayerVersionResponse
         */
        public async Task<GetLayerVersionResponse> GetLayerVersionWithOptionsAsync(string layerName, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLayerVersion",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLayerVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries versions of a layer.
         *
         * @return GetLayerVersionResponse
         */
        public GetLayerVersionResponse GetLayerVersion(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLayerVersionWithOptions(layerName, version, headers, runtime);
        }

        /**
         * @summary Queries versions of a layer.
         *
         * @return GetLayerVersionResponse
         */
        public async Task<GetLayerVersionResponse> GetLayerVersionAsync(string layerName, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLayerVersionWithOptionsAsync(layerName, version, headers, runtime);
        }

        /**
         * @summary Obtain version information of a layer by using ARNs.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLayerVersionByArnResponse
         */
        public GetLayerVersionByArnResponse GetLayerVersionByArnWithOptions(string arn, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLayerVersionByArn",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layerarn/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(arn),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLayerVersionByArnResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtain version information of a layer by using ARNs.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLayerVersionByArnResponse
         */
        public async Task<GetLayerVersionByArnResponse> GetLayerVersionByArnWithOptionsAsync(string arn, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLayerVersionByArn",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layerarn/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(arn),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLayerVersionByArnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtain version information of a layer by using ARNs.
         *
         * @return GetLayerVersionByArnResponse
         */
        public GetLayerVersionByArnResponse GetLayerVersionByArn(string arn)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLayerVersionByArnWithOptions(arn, headers, runtime);
        }

        /**
         * @summary Obtain version information of a layer by using ARNs.
         *
         * @return GetLayerVersionByArnResponse
         */
        public async Task<GetLayerVersionByArnResponse> GetLayerVersionByArnAsync(string arn)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLayerVersionByArnWithOptionsAsync(arn, headers, runtime);
        }

        /**
         * @summary Queries provisioned configurations.
         *
         * @param request GetProvisionConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProvisionConfigResponse
         */
        public GetProvisionConfigResponse GetProvisionConfigWithOptions(string functionName, GetProvisionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProvisionConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/provision-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProvisionConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries provisioned configurations.
         *
         * @param request GetProvisionConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProvisionConfigResponse
         */
        public async Task<GetProvisionConfigResponse> GetProvisionConfigWithOptionsAsync(string functionName, GetProvisionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProvisionConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/provision-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProvisionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries provisioned configurations.
         *
         * @param request GetProvisionConfigRequest
         * @return GetProvisionConfigResponse
         */
        public GetProvisionConfigResponse GetProvisionConfig(string functionName, GetProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProvisionConfigWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries provisioned configurations.
         *
         * @param request GetProvisionConfigRequest
         * @return GetProvisionConfigResponse
         */
        public async Task<GetProvisionConfigResponse> GetProvisionConfigAsync(string functionName, GetProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProvisionConfigWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries information about a trigger.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTriggerResponse
         */
        public GetTriggerResponse GetTriggerWithOptions(string functionName, string triggerName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrigger",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries information about a trigger.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTriggerResponse
         */
        public async Task<GetTriggerResponse> GetTriggerWithOptionsAsync(string functionName, string triggerName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrigger",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries information about a trigger.
         *
         * @return GetTriggerResponse
         */
        public GetTriggerResponse GetTrigger(string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTriggerWithOptions(functionName, triggerName, headers, runtime);
        }

        /**
         * @summary Queries information about a trigger.
         *
         * @return GetTriggerResponse
         */
        public async Task<GetTriggerResponse> GetTriggerAsync(string functionName, string triggerName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTriggerWithOptionsAsync(functionName, triggerName, headers, runtime);
        }

        /**
         * @summary Invokes a function.
         *
         * @param request InvokeFunctionRequest
         * @param headers InvokeFunctionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvokeFunctionResponse
         */
        public InvokeFunctionResponse InvokeFunctionWithOptions(string functionName, InvokeFunctionRequest request, InvokeFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAsyncTaskId))
            {
                realHeaders["x-fc-async-task-id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAsyncTaskId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["x-fc-invocation-type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcInvocationType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["x-fc-log-type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcLogType);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeFunction",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/invocations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "binary",
            };
            InvokeFunctionResponse res = new InvokeFunctionResponse();
            Dictionary<string, object> tmp = AlibabaCloud.TeaUtil.Common.AssertAsMap(CallApi(params_, req, runtime));
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("body")))
            {
                Stream respBody = AlibabaCloud.TeaUtil.Common.AssertAsReadable(tmp.Get("body"));
                res.Body = respBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("headers")))
            {
                Dictionary<string, object> respHeaders = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmp.Get("headers"));
                res.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(respHeaders);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("statusCode")))
            {
                int? statusCode = AlibabaCloud.TeaUtil.Common.AssertAsInteger(tmp.Get("statusCode"));
                res.StatusCode = statusCode;
            }
            return res;
        }

        /**
         * @summary Invokes a function.
         *
         * @param request InvokeFunctionRequest
         * @param headers InvokeFunctionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvokeFunctionResponse
         */
        public async Task<InvokeFunctionResponse> InvokeFunctionWithOptionsAsync(string functionName, InvokeFunctionRequest request, InvokeFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcAsyncTaskId))
            {
                realHeaders["x-fc-async-task-id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcAsyncTaskId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcInvocationType))
            {
                realHeaders["x-fc-invocation-type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcInvocationType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XFcLogType))
            {
                realHeaders["x-fc-log-type"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XFcLogType);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeFunction",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/invocations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "binary",
            };
            InvokeFunctionResponse res = new InvokeFunctionResponse();
            Dictionary<string, object> tmp = AlibabaCloud.TeaUtil.Common.AssertAsMap(await CallApiAsync(params_, req, runtime));
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("body")))
            {
                Stream respBody = AlibabaCloud.TeaUtil.Common.AssertAsReadable(tmp.Get("body"));
                res.Body = respBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("headers")))
            {
                Dictionary<string, object> respHeaders = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmp.Get("headers"));
                res.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(respHeaders);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("statusCode")))
            {
                int? statusCode = AlibabaCloud.TeaUtil.Common.AssertAsInteger(tmp.Get("statusCode"));
                res.StatusCode = statusCode;
            }
            return res;
        }

        /**
         * @summary Invokes a function.
         *
         * @param request InvokeFunctionRequest
         * @return InvokeFunctionResponse
         */
        public InvokeFunctionResponse InvokeFunction(string functionName, InvokeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeFunctionHeaders headers = new InvokeFunctionHeaders();
            return InvokeFunctionWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Invokes a function.
         *
         * @param request InvokeFunctionRequest
         * @return InvokeFunctionResponse
         */
        public async Task<InvokeFunctionResponse> InvokeFunctionAsync(string functionName, InvokeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvokeFunctionHeaders headers = new InvokeFunctionHeaders();
            return await InvokeFunctionWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries aliases.
         *
         * @param request ListAliasesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAliasesResponse
         */
        public ListAliasesResponse ListAliasesWithOptions(string functionName, ListAliasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliases",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/aliases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries aliases.
         *
         * @param request ListAliasesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAliasesResponse
         */
        public async Task<ListAliasesResponse> ListAliasesWithOptionsAsync(string functionName, ListAliasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliases",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/aliases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries aliases.
         *
         * @param request ListAliasesRequest
         * @return ListAliasesResponse
         */
        public ListAliasesResponse ListAliases(string functionName, ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAliasesWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries aliases.
         *
         * @param request ListAliasesRequest
         * @return ListAliasesResponse
         */
        public async Task<ListAliasesResponse> ListAliasesAsync(string functionName, ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAliasesWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries all asynchronous configurations of a function.
         *
         * @param request ListAsyncInvokeConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAsyncInvokeConfigsResponse
         */
        public ListAsyncInvokeConfigsResponse ListAsyncInvokeConfigsWithOptions(ListAsyncInvokeConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["functionName"] = request.FunctionName;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAsyncInvokeConfigs",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/async-invoke-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsyncInvokeConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all asynchronous configurations of a function.
         *
         * @param request ListAsyncInvokeConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAsyncInvokeConfigsResponse
         */
        public async Task<ListAsyncInvokeConfigsResponse> ListAsyncInvokeConfigsWithOptionsAsync(ListAsyncInvokeConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["functionName"] = request.FunctionName;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAsyncInvokeConfigs",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/async-invoke-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsyncInvokeConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all asynchronous configurations of a function.
         *
         * @param request ListAsyncInvokeConfigsRequest
         * @return ListAsyncInvokeConfigsResponse
         */
        public ListAsyncInvokeConfigsResponse ListAsyncInvokeConfigs(ListAsyncInvokeConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAsyncInvokeConfigsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries all asynchronous configurations of a function.
         *
         * @param request ListAsyncInvokeConfigsRequest
         * @return ListAsyncInvokeConfigsResponse
         */
        public async Task<ListAsyncInvokeConfigsResponse> ListAsyncInvokeConfigsAsync(ListAsyncInvokeConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAsyncInvokeConfigsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Lists asynchronous tasks.
         *
         * @param request ListAsyncTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAsyncTasksResponse
         */
        public ListAsyncTasksResponse ListAsyncTasksWithOptions(string functionName, ListAsyncTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePayload))
            {
                query["includePayload"] = request.IncludePayload;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAsyncTasks",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsyncTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Lists asynchronous tasks.
         *
         * @param request ListAsyncTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAsyncTasksResponse
         */
        public async Task<ListAsyncTasksResponse> ListAsyncTasksWithOptionsAsync(string functionName, ListAsyncTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePayload))
            {
                query["includePayload"] = request.IncludePayload;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAsyncTasks",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsyncTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Lists asynchronous tasks.
         *
         * @param request ListAsyncTasksRequest
         * @return ListAsyncTasksResponse
         */
        public ListAsyncTasksResponse ListAsyncTasks(string functionName, ListAsyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAsyncTasksWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Lists asynchronous tasks.
         *
         * @param request ListAsyncTasksRequest
         * @return ListAsyncTasksResponse
         */
        public async Task<ListAsyncTasksResponse> ListAsyncTasksAsync(string functionName, ListAsyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAsyncTasksWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary 列出函数并发度配置。
         *
         * @param request ListConcurrencyConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConcurrencyConfigsResponse
         */
        public ListConcurrencyConfigsResponse ListConcurrencyConfigsWithOptions(ListConcurrencyConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["functionName"] = request.FunctionName;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConcurrencyConfigs",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/concurrency-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConcurrencyConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列出函数并发度配置。
         *
         * @param request ListConcurrencyConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConcurrencyConfigsResponse
         */
        public async Task<ListConcurrencyConfigsResponse> ListConcurrencyConfigsWithOptionsAsync(ListConcurrencyConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["functionName"] = request.FunctionName;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConcurrencyConfigs",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/concurrency-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConcurrencyConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列出函数并发度配置。
         *
         * @param request ListConcurrencyConfigsRequest
         * @return ListConcurrencyConfigsResponse
         */
        public ListConcurrencyConfigsResponse ListConcurrencyConfigs(ListConcurrencyConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConcurrencyConfigsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列出函数并发度配置。
         *
         * @param request ListConcurrencyConfigsRequest
         * @return ListConcurrencyConfigsResponse
         */
        public async Task<ListConcurrencyConfigsResponse> ListConcurrencyConfigsAsync(ListConcurrencyConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConcurrencyConfigsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries custom domain names.
         *
         * @param request ListCustomDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomDomainsResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomDomains",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/custom-domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries custom domain names.
         *
         * @param request ListCustomDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomDomainsResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomDomains",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/custom-domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries custom domain names.
         *
         * @param request ListCustomDomainsRequest
         * @return ListCustomDomainsResponse
         */
        public ListCustomDomainsResponse ListCustomDomains(ListCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCustomDomainsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries custom domain names.
         *
         * @param request ListCustomDomainsRequest
         * @return ListCustomDomainsResponse
         */
        public async Task<ListCustomDomainsResponse> ListCustomDomainsAsync(ListCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCustomDomainsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries versions of a function.
         *
         * @param request ListFunctionVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFunctionVersionsResponse
         */
        public ListFunctionVersionsResponse ListFunctionVersionsWithOptions(string functionName, ListFunctionVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionVersions",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionVersionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries versions of a function.
         *
         * @param request ListFunctionVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFunctionVersionsResponse
         */
        public async Task<ListFunctionVersionsResponse> ListFunctionVersionsWithOptionsAsync(string functionName, ListFunctionVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionVersions",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries versions of a function.
         *
         * @param request ListFunctionVersionsRequest
         * @return ListFunctionVersionsResponse
         */
        public ListFunctionVersionsResponse ListFunctionVersions(string functionName, ListFunctionVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionVersionsWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries versions of a function.
         *
         * @param request ListFunctionVersionsRequest
         * @return ListFunctionVersionsResponse
         */
        public async Task<ListFunctionVersionsResponse> ListFunctionVersionsAsync(string functionName, ListFunctionVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionVersionsWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary 列出函数。
         *
         * @param request ListFunctionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFunctionsResponse
         */
        public ListFunctionsResponse ListFunctionsWithOptions(ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FcVersion))
            {
                query["fcVersion"] = request.FcVersion;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列出函数。
         *
         * @param request ListFunctionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFunctionsResponse
         */
        public async Task<ListFunctionsResponse> ListFunctionsWithOptionsAsync(ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FcVersion))
            {
                query["fcVersion"] = request.FcVersion;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列出函数。
         *
         * @param request ListFunctionsRequest
         * @return ListFunctionsResponse
         */
        public ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列出函数。
         *
         * @param request ListFunctionsRequest
         * @return ListFunctionsResponse
         */
        public async Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a list of function instances.
         *
         * @param request ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(string functionName, ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAllActive))
            {
                query["withAllActive"] = request.WithAllActive;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of function instances.
         *
         * @param request ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(string functionName, ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAllActive))
            {
                query["withAllActive"] = request.WithAllActive;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of function instances.
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstances(string functionName, ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries a list of function instances.
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesAsync(string functionName, ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Gets a list of layer versions.
         *
         * @param request ListLayerVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLayerVersionsResponse
         */
        public ListLayerVersionsResponse ListLayerVersionsWithOptions(string layerName, ListLayerVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayerVersions",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayerVersionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Gets a list of layer versions.
         *
         * @param request ListLayerVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLayerVersionsResponse
         */
        public async Task<ListLayerVersionsResponse> ListLayerVersionsWithOptionsAsync(string layerName, ListLayerVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayerVersions",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayerVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Gets a list of layer versions.
         *
         * @param request ListLayerVersionsRequest
         * @return ListLayerVersionsResponse
         */
        public ListLayerVersionsResponse ListLayerVersions(string layerName, ListLayerVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLayerVersionsWithOptions(layerName, request, headers, runtime);
        }

        /**
         * @summary Gets a list of layer versions.
         *
         * @param request ListLayerVersionsRequest
         * @return ListLayerVersionsResponse
         */
        public async Task<ListLayerVersionsResponse> ListLayerVersionsAsync(string layerName, ListLayerVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLayerVersionsWithOptionsAsync(layerName, request, headers, runtime);
        }

        /**
         * @summary Gets a list of layers.
         *
         * @param request ListLayersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLayersResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Official))
            {
                query["official"] = request.Official;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Public))
            {
                query["public"] = request.Public;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayers",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Gets a list of layers.
         *
         * @param request ListLayersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLayersResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Official))
            {
                query["official"] = request.Official;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Public))
            {
                query["public"] = request.Public;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayers",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Gets a list of layers.
         *
         * @param request ListLayersRequest
         * @return ListLayersResponse
         */
        public ListLayersResponse ListLayers(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLayersWithOptions(request, headers, runtime);
        }

        /**
         * @summary Gets a list of layers.
         *
         * @param request ListLayersRequest
         * @return ListLayersResponse
         */
        public async Task<ListLayersResponse> ListLayersAsync(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLayersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a list of provisioned configurations.
         *
         * @param request ListProvisionConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProvisionConfigsResponse
         */
        public ListProvisionConfigsResponse ListProvisionConfigsWithOptions(ListProvisionConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["functionName"] = request.FunctionName;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProvisionConfigs",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/provision-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProvisionConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of provisioned configurations.
         *
         * @param request ListProvisionConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProvisionConfigsResponse
         */
        public async Task<ListProvisionConfigsResponse> ListProvisionConfigsWithOptionsAsync(ListProvisionConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["functionName"] = request.FunctionName;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProvisionConfigs",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/provision-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProvisionConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of provisioned configurations.
         *
         * @param request ListProvisionConfigsRequest
         * @return ListProvisionConfigsResponse
         */
        public ListProvisionConfigsResponse ListProvisionConfigs(ListProvisionConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProvisionConfigsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of provisioned configurations.
         *
         * @param request ListProvisionConfigsRequest
         * @return ListProvisionConfigsResponse
         */
        public async Task<ListProvisionConfigsResponse> ListProvisionConfigsAsync(ListProvisionConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProvisionConfigsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Lists all tagged resources.
         *
         * @param tmpReq ListTagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "ResourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["ResourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tags-v2",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Lists all tagged resources.
         *
         * @param tmpReq ListTagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "ResourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["ResourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tags-v2",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Lists all tagged resources.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Lists all tagged resources.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the triggers of a function.
         *
         * @param request ListTriggersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTriggersResponse
         */
        public ListTriggersResponse ListTriggersWithOptions(string functionName, ListTriggersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTriggers",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTriggersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the triggers of a function.
         *
         * @param request ListTriggersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTriggersResponse
         */
        public async Task<ListTriggersResponse> ListTriggersWithOptionsAsync(string functionName, ListTriggersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTriggers",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTriggersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the triggers of a function.
         *
         * @param request ListTriggersRequest
         * @return ListTriggersResponse
         */
        public ListTriggersResponse ListTriggers(string functionName, ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTriggersWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries the triggers of a function.
         *
         * @param request ListTriggersRequest
         * @return ListTriggersResponse
         */
        public async Task<ListTriggersResponse> ListTriggersAsync(string functionName, ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTriggersWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Queries a list of existing VPC connections.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVpcBindingsResponse
         */
        public ListVpcBindingsResponse ListVpcBindingsWithOptions(string functionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcBindings",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/vpc-bindings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcBindingsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of existing VPC connections.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVpcBindingsResponse
         */
        public async Task<ListVpcBindingsResponse> ListVpcBindingsWithOptionsAsync(string functionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcBindings",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/vpc-bindings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcBindingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of existing VPC connections.
         *
         * @return ListVpcBindingsResponse
         */
        public ListVpcBindingsResponse ListVpcBindings(string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVpcBindingsWithOptions(functionName, headers, runtime);
        }

        /**
         * @summary Queries a list of existing VPC connections.
         *
         * @return ListVpcBindingsResponse
         */
        public async Task<ListVpcBindingsResponse> ListVpcBindingsAsync(string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVpcBindingsWithOptionsAsync(functionName, headers, runtime);
        }

        /**
         * @summary Publishes a function version.
         *
         * @param request PublishFunctionVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishFunctionVersionResponse
         */
        public PublishFunctionVersionResponse PublishFunctionVersionWithOptions(string functionName, PublishFunctionVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishFunctionVersion",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFunctionVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Publishes a function version.
         *
         * @param request PublishFunctionVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishFunctionVersionResponse
         */
        public async Task<PublishFunctionVersionResponse> PublishFunctionVersionWithOptionsAsync(string functionName, PublishFunctionVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishFunctionVersion",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFunctionVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Publishes a function version.
         *
         * @param request PublishFunctionVersionRequest
         * @return PublishFunctionVersionResponse
         */
        public PublishFunctionVersionResponse PublishFunctionVersion(string functionName, PublishFunctionVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishFunctionVersionWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Publishes a function version.
         *
         * @param request PublishFunctionVersionRequest
         * @return PublishFunctionVersionResponse
         */
        public async Task<PublishFunctionVersionResponse> PublishFunctionVersionAsync(string functionName, PublishFunctionVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishFunctionVersionWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Creates or modifies an asynchronous invocation configuration for a function.
         *
         * @param request PutAsyncInvokeConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutAsyncInvokeConfigResponse
         */
        public PutAsyncInvokeConfigResponse PutAsyncInvokeConfigWithOptions(string functionName, PutAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutAsyncInvokeConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutAsyncInvokeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates or modifies an asynchronous invocation configuration for a function.
         *
         * @param request PutAsyncInvokeConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutAsyncInvokeConfigResponse
         */
        public async Task<PutAsyncInvokeConfigResponse> PutAsyncInvokeConfigWithOptionsAsync(string functionName, PutAsyncInvokeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutAsyncInvokeConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-invoke-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutAsyncInvokeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates or modifies an asynchronous invocation configuration for a function.
         *
         * @param request PutAsyncInvokeConfigRequest
         * @return PutAsyncInvokeConfigResponse
         */
        public PutAsyncInvokeConfigResponse PutAsyncInvokeConfig(string functionName, PutAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutAsyncInvokeConfigWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Creates or modifies an asynchronous invocation configuration for a function.
         *
         * @param request PutAsyncInvokeConfigRequest
         * @return PutAsyncInvokeConfigResponse
         */
        public async Task<PutAsyncInvokeConfigResponse> PutAsyncInvokeConfigAsync(string functionName, PutAsyncInvokeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutAsyncInvokeConfigWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Configures concurrency of a function.
         *
         * @param request PutConcurrencyConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutConcurrencyConfigResponse
         */
        public PutConcurrencyConfigResponse PutConcurrencyConfigWithOptions(string functionName, PutConcurrencyConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutConcurrencyConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/concurrency",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutConcurrencyConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Configures concurrency of a function.
         *
         * @param request PutConcurrencyConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutConcurrencyConfigResponse
         */
        public async Task<PutConcurrencyConfigResponse> PutConcurrencyConfigWithOptionsAsync(string functionName, PutConcurrencyConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutConcurrencyConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/concurrency",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutConcurrencyConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Configures concurrency of a function.
         *
         * @param request PutConcurrencyConfigRequest
         * @return PutConcurrencyConfigResponse
         */
        public PutConcurrencyConfigResponse PutConcurrencyConfig(string functionName, PutConcurrencyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutConcurrencyConfigWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Configures concurrency of a function.
         *
         * @param request PutConcurrencyConfigRequest
         * @return PutConcurrencyConfigResponse
         */
        public async Task<PutConcurrencyConfigResponse> PutConcurrencyConfigAsync(string functionName, PutConcurrencyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutConcurrencyConfigWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Modifies permissions of a layer.
         *
         * @param request PutLayerACLRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutLayerACLResponse
         */
        public PutLayerACLResponse PutLayerACLWithOptions(string layerName, PutLayerACLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acl))
            {
                query["acl"] = request.Acl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Public))
            {
                query["public"] = request.Public;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutLayerACL",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/acl",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutLayerACLResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies permissions of a layer.
         *
         * @param request PutLayerACLRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutLayerACLResponse
         */
        public async Task<PutLayerACLResponse> PutLayerACLWithOptionsAsync(string layerName, PutLayerACLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Acl))
            {
                query["acl"] = request.Acl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Public))
            {
                query["public"] = request.Public;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutLayerACL",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(layerName) + "/acl",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutLayerACLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies permissions of a layer.
         *
         * @param request PutLayerACLRequest
         * @return PutLayerACLResponse
         */
        public PutLayerACLResponse PutLayerACL(string layerName, PutLayerACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutLayerACLWithOptions(layerName, request, headers, runtime);
        }

        /**
         * @summary Modifies permissions of a layer.
         *
         * @param request PutLayerACLRequest
         * @return PutLayerACLResponse
         */
        public async Task<PutLayerACLResponse> PutLayerACLAsync(string layerName, PutLayerACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutLayerACLWithOptionsAsync(layerName, request, headers, runtime);
        }

        /**
         * @summary Creates provisioned configurations.
         *
         * @param request PutProvisionConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutProvisionConfigResponse
         */
        public PutProvisionConfigResponse PutProvisionConfigWithOptions(string functionName, PutProvisionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProvisionConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/provision-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProvisionConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates provisioned configurations.
         *
         * @param request PutProvisionConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutProvisionConfigResponse
         */
        public async Task<PutProvisionConfigResponse> PutProvisionConfigWithOptionsAsync(string functionName, PutProvisionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qualifier))
            {
                query["qualifier"] = request.Qualifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProvisionConfig",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/provision-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProvisionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates provisioned configurations.
         *
         * @param request PutProvisionConfigRequest
         * @return PutProvisionConfigResponse
         */
        public PutProvisionConfigResponse PutProvisionConfig(string functionName, PutProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutProvisionConfigWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Creates provisioned configurations.
         *
         * @param request PutProvisionConfigRequest
         * @return PutProvisionConfigResponse
         */
        public async Task<PutProvisionConfigResponse> PutProvisionConfigAsync(string functionName, PutProvisionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutProvisionConfigWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Stops an asynchronous task.
         *
         * @param request StopAsyncTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAsyncTaskResponse
         */
        public StopAsyncTaskResponse StopAsyncTaskWithOptions(string functionName, string taskId, StopAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAsyncTask",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopAsyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Stops an asynchronous task.
         *
         * @param request StopAsyncTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAsyncTaskResponse
         */
        public async Task<StopAsyncTaskResponse> StopAsyncTaskWithOptionsAsync(string functionName, string taskId, StopAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAsyncTask",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/async-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Stops an asynchronous task.
         *
         * @param request StopAsyncTaskRequest
         * @return StopAsyncTaskResponse
         */
        public StopAsyncTaskResponse StopAsyncTask(string functionName, string taskId, StopAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopAsyncTaskWithOptions(functionName, taskId, request, headers, runtime);
        }

        /**
         * @summary Stops an asynchronous task.
         *
         * @param request StopAsyncTaskRequest
         * @return StopAsyncTaskResponse
         */
        public async Task<StopAsyncTaskResponse> StopAsyncTaskAsync(string functionName, string taskId, StopAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopAsyncTaskWithOptionsAsync(functionName, taskId, request, headers, runtime);
        }

        /**
         * @summary Adds tags to a resource.
         *
         * @description Tags are used to identify resources. Tags allow you to categorize, search for, and aggregate resources that have the same characteristics from different dimensions. This facilitates resource management. For more information, see [Tag overview](https://help.aliyun.com/document_detail/156983.html).
         *
         * @param request TagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tags-v2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds tags to a resource.
         *
         * @description Tags are used to identify resources. Tags allow you to categorize, search for, and aggregate resources that have the same characteristics from different dimensions. This facilitates resource management. For more information, see [Tag overview](https://help.aliyun.com/document_detail/156983.html).
         *
         * @param request TagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tags-v2",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds tags to a resource.
         *
         * @description Tags are used to identify resources. Tags allow you to categorize, search for, and aggregate resources that have the same characteristics from different dimensions. This facilitates resource management. For more information, see [Tag overview](https://help.aliyun.com/document_detail/156983.html).
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Adds tags to a resource.
         *
         * @description Tags are used to identify resources. Tags allow you to categorize, search for, and aggregate resources that have the same characteristics from different dimensions. This facilitates resource management. For more information, see [Tag overview](https://help.aliyun.com/document_detail/156983.html).
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Removes tags from a resource.
         *
         * @param tmpReq UntagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "ResourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKey))
            {
                request.TagKeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKey, "TagKey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["ResourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyShrink))
            {
                query["TagKey"] = request.TagKeyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tags-v2",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes tags from a resource.
         *
         * @param tmpReq UntagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "ResourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKey))
            {
                request.TagKeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKey, "TagKey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["ResourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyShrink))
            {
                query["TagKey"] = request.TagKeyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tags-v2",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes tags from a resource.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Removes tags from a resource.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Updates an alias.
         *
         * @param request UpdateAliasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAliasResponse
         */
        public UpdateAliasResponse UpdateAliasWithOptions(string functionName, string aliasName, UpdateAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlias",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates an alias.
         *
         * @param request UpdateAliasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAliasResponse
         */
        public async Task<UpdateAliasResponse> UpdateAliasWithOptionsAsync(string functionName, string aliasName, UpdateAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlias",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(aliasName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates an alias.
         *
         * @param request UpdateAliasRequest
         * @return UpdateAliasResponse
         */
        public UpdateAliasResponse UpdateAlias(string functionName, string aliasName, UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAliasWithOptions(functionName, aliasName, request, headers, runtime);
        }

        /**
         * @summary Updates an alias.
         *
         * @param request UpdateAliasRequest
         * @return UpdateAliasResponse
         */
        public async Task<UpdateAliasResponse> UpdateAliasAsync(string functionName, string aliasName, UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAliasWithOptionsAsync(functionName, aliasName, request, headers, runtime);
        }

        /**
         * @summary Update a custom domain name.
         *
         * @param request UpdateCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomDomainResponse
         */
        public UpdateCustomDomainResponse UpdateCustomDomainWithOptions(string domainName, UpdateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomDomain",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Update a custom domain name.
         *
         * @param request UpdateCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomDomainResponse
         */
        public async Task<UpdateCustomDomainResponse> UpdateCustomDomainWithOptionsAsync(string domainName, UpdateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomDomain",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Update a custom domain name.
         *
         * @param request UpdateCustomDomainRequest
         * @return UpdateCustomDomainResponse
         */
        public UpdateCustomDomainResponse UpdateCustomDomain(string domainName, UpdateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCustomDomainWithOptions(domainName, request, headers, runtime);
        }

        /**
         * @summary Update a custom domain name.
         *
         * @param request UpdateCustomDomainRequest
         * @return UpdateCustomDomainResponse
         */
        public async Task<UpdateCustomDomainResponse> UpdateCustomDomainAsync(string domainName, UpdateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCustomDomainWithOptionsAsync(domainName, request, headers, runtime);
        }

        /**
         * @summary Updates the information about a function.
         *
         * @param request UpdateFunctionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFunctionResponse
         */
        public UpdateFunctionResponse UpdateFunctionWithOptions(string functionName, UpdateFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFunction",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the information about a function.
         *
         * @param request UpdateFunctionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFunctionResponse
         */
        public async Task<UpdateFunctionResponse> UpdateFunctionWithOptionsAsync(string functionName, UpdateFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFunction",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the information about a function.
         *
         * @param request UpdateFunctionRequest
         * @return UpdateFunctionResponse
         */
        public UpdateFunctionResponse UpdateFunction(string functionName, UpdateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFunctionWithOptions(functionName, request, headers, runtime);
        }

        /**
         * @summary Updates the information about a function.
         *
         * @param request UpdateFunctionRequest
         * @return UpdateFunctionResponse
         */
        public async Task<UpdateFunctionResponse> UpdateFunctionAsync(string functionName, UpdateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFunctionWithOptionsAsync(functionName, request, headers, runtime);
        }

        /**
         * @summary Modifies a trigger.
         *
         * @param request UpdateTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTriggerResponse
         */
        public UpdateTriggerResponse UpdateTriggerWithOptions(string functionName, string triggerName, UpdateTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrigger",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a trigger.
         *
         * @param request UpdateTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTriggerResponse
         */
        public async Task<UpdateTriggerResponse> UpdateTriggerWithOptionsAsync(string functionName, string triggerName, UpdateTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrigger",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(triggerName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a trigger.
         *
         * @param request UpdateTriggerRequest
         * @return UpdateTriggerResponse
         */
        public UpdateTriggerResponse UpdateTrigger(string functionName, string triggerName, UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTriggerWithOptions(functionName, triggerName, request, headers, runtime);
        }

        /**
         * @summary Modifies a trigger.
         *
         * @param request UpdateTriggerRequest
         * @return UpdateTriggerResponse
         */
        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(string functionName, string triggerName, UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTriggerWithOptionsAsync(functionName, triggerName, request, headers, runtime);
        }

    }
}
