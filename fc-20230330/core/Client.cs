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
          * 创建函数别名
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
          * 创建函数别名
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
          * 创建函数别名
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
          * 创建函数别名
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
          * 创建自定义域名
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
          * 创建自定义域名
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
          * 创建自定义域名
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
          * 创建自定义域名
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
          * 创建函数
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
          * 创建函数
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
          * 创建函数
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
          * 创建函数
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
          * 创建层版本
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
          * 创建层版本
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
          * 创建层版本
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
          * 创建层版本
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
          * 创建函数触发器
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
          * 创建函数触发器
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
          * 创建函数触发器
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
          * 创建函数触发器
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
          * 创建VPC绑定
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
          * 创建VPC绑定
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
          * 创建VPC绑定
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
          * 创建VPC绑定
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
          * 删除函数别名
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
          * 删除函数别名
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
          * 删除函数别名
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
          * 删除函数别名
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
          * 删除函数异步调用配置
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
          * 删除函数异步调用配置
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
          * 删除函数异步调用配置
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
          * 删除函数异步调用配置
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
          * 删除函数并发度配置
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
          * 删除函数并发度配置
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
          * 删除函数并发度配置
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
          * 删除函数并发度配置
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
          * 删除自定义域名
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
          * 删除自定义域名
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
          * 删除自定义域名
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
          * 删除自定义域名
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
          * 删除函数
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
          * 删除函数
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
          * 删除函数
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
          * 删除函数
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
          * 删除函数版本
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
          * 删除函数版本
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
          * 删除函数版本
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
          * 删除函数版本
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
          * 删除层版本
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
          * 删除层版本
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
          * 删除层版本
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
          * 删除层版本
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
          * 删除函数预留配置
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
          * 删除函数预留配置
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
          * 删除函数预留配置
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
          * 删除函数预留配置
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
          * 删除函数触发器
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
          * 删除函数触发器
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
          * 删除函数触发器
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
          * 删除函数触发器
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
          * 删除VPC绑定
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
          * 删除VPC绑定
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
          * 删除VPC绑定
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
          * 删除VPC绑定
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
          * 获取函数别名信息
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
          * 获取函数别名信息
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
          * 获取函数别名信息
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
          * 获取函数别名信息
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
          * 获取函数异步调用配置
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
          * 获取函数异步调用配置
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
          * 获取函数异步调用配置
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
          * 获取函数异步调用配置
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
          * 获取函数并发度配置
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
          * 获取函数并发度配置
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
          * 获取函数并发度配置
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
          * 获取函数并发度配置
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
          * 获取自定义域名
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
          * 获取自定义域名
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
          * 获取自定义域名
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
          * 获取自定义域名
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
          * 获取函数信息
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
          * 获取函数信息
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
          * 获取函数信息
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
          * 获取函数信息
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
          * 获取函数代码
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
          * 获取函数代码
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
          * 获取函数代码
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
          * 获取函数代码
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
          * 获取层版本
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
          * 获取层版本
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
          * 获取层版本
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
          * 获取层版本
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
          * 根据资源标识获取层版本
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
          * 根据资源标识获取层版本
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
          * 根据资源标识获取层版本
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
          * 根据资源标识获取层版本
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
          * 获取函数预留配置
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
          * 获取函数预留配置
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
          * 获取函数预留配置
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
          * 获取函数预留配置
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
          * 获取资源标签
          *
          * @param request GetResourceTagsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceTagsResponse
         */
        public GetResourceTagsResponse GetResourceTagsWithOptions(GetResourceTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arn))
            {
                query["arn"] = request.Arn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceTags",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * 获取资源标签
          *
          * @param request GetResourceTagsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceTagsResponse
         */
        public async Task<GetResourceTagsResponse> GetResourceTagsWithOptionsAsync(GetResourceTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arn))
            {
                query["arn"] = request.Arn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceTags",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * 获取资源标签
          *
          * @param request GetResourceTagsRequest
          * @return GetResourceTagsResponse
         */
        public GetResourceTagsResponse GetResourceTags(GetResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceTagsWithOptions(request, headers, runtime);
        }

        /**
          * 获取资源标签
          *
          * @param request GetResourceTagsRequest
          * @return GetResourceTagsResponse
         */
        public async Task<GetResourceTagsResponse> GetResourceTagsAsync(GetResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceTagsWithOptionsAsync(request, headers, runtime);
        }

        /**
          * 获取函数触发器
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
          * 获取函数触发器
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
          * 获取函数触发器
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
          * 获取函数触发器
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
          * 调用函数
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
          * 调用函数
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
          * 调用函数
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
          * 调用函数
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
          * 列出函数别名
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
          * 列出函数别名
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
          * 列出函数别名
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
          * 列出函数别名
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
          * 列出函数异步调用配置
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
          * 列出函数异步调用配置
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
          * 列出函数异步调用配置
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
          * 列出函数异步调用配置
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
          * 列出函数并发度配置
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
          * 列出函数并发度配置
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
          * 列出函数并发度配置
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
          * 列出函数并发度配置
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
          * 列出自定义域名
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
          * 列出自定义域名
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
          * 列出自定义域名
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
          * 列出自定义域名
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
          * 列出函数版本
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
          * 列出函数版本
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
          * 列出函数版本
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
          * 列出函数版本
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
          * 列出函数
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
          * 列出函数
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
          * 列出函数
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
          * 列出函数
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
          * 列出函数实例
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
          * 列出函数实例
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
          * 列出函数实例
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
          * 列出函数实例
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
          * 列出层版本
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
          * 列出层版本
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
          * 列出层版本
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
          * 列出层版本
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
          * 列出层
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
          * 列出层
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
          * 列出层
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
          * 列出层
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
          * 列出函数预留配置
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
          * 列出函数预留配置
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
          * 列出函数预留配置
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
          * 列出函数预留配置
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
          * 列出具有标签的资源
          *
          * @param request ListTaggedResourcesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTaggedResourcesResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaggedResources",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaggedResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * 列出具有标签的资源
          *
          * @param request ListTaggedResourcesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTaggedResourcesResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaggedResources",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaggedResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * 列出具有标签的资源
          *
          * @param request ListTaggedResourcesRequest
          * @return ListTaggedResourcesResponse
         */
        public ListTaggedResourcesResponse ListTaggedResources(ListTaggedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTaggedResourcesWithOptions(request, headers, runtime);
        }

        /**
          * 列出具有标签的资源
          *
          * @param request ListTaggedResourcesRequest
          * @return ListTaggedResourcesResponse
         */
        public async Task<ListTaggedResourcesResponse> ListTaggedResourcesAsync(ListTaggedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTaggedResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
          * 列出函数触发器
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
          * 列出函数触发器
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
          * 列出函数触发器
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
          * 列出函数触发器
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
          * 列出VPC绑定配置
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
          * 列出VPC绑定配置
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
          * 列出VPC绑定配置
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
          * 列出VPC绑定配置
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
          * 发布函数版本
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
          * 发布函数版本
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
          * 发布函数版本
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
          * 发布函数版本
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
          * 设置函数异步调用配置
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
          * 设置函数异步调用配置
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
          * 设置函数异步调用配置
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
          * 设置函数异步调用配置
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
          * 设置函数并发度配置
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
          * 设置函数并发度配置
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
          * 设置函数并发度配置
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
          * 设置函数并发度配置
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
          * 设置层的访问权限
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
          * 设置层的访问权限
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
          * 设置层的访问权限
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
          * 设置层的访问权限
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
          * 设置函数预留配置
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
          * 设置函数预留配置
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
          * 设置函数预留配置
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
          * 设置函数预留配置
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
          * 设置资源标签
          *
          * @param request TagResourceRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return TagResourceResponse
         */
        public TagResourceResponse TagResourceWithOptions(TagResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResource",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<TagResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * 设置资源标签
          *
          * @param request TagResourceRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return TagResourceResponse
         */
        public async Task<TagResourceResponse> TagResourceWithOptionsAsync(TagResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResource",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<TagResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * 设置资源标签
          *
          * @param request TagResourceRequest
          * @return TagResourceResponse
         */
        public TagResourceResponse TagResource(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourceWithOptions(request, headers, runtime);
        }

        /**
          * 设置资源标签
          *
          * @param request TagResourceRequest
          * @return TagResourceResponse
         */
        public async Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourceWithOptionsAsync(request, headers, runtime);
        }

        /**
          * 删除资源标签
          *
          * @param request UntagResourceRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UntagResourceResponse
         */
        public UntagResourceResponse UntagResourceWithOptions(UntagResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arn))
            {
                query["arn"] = request.Arn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["tagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResource",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tag",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UntagResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * 删除资源标签
          *
          * @param request UntagResourceRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UntagResourceResponse
         */
        public async Task<UntagResourceResponse> UntagResourceWithOptionsAsync(UntagResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arn))
            {
                query["arn"] = request.Arn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["tagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResource",
                Version = "2023-03-30",
                Protocol = "HTTPS",
                Pathname = "/2023-03-30/tag",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UntagResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * 删除资源标签
          *
          * @param request UntagResourceRequest
          * @return UntagResourceResponse
         */
        public UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourceWithOptions(request, headers, runtime);
        }

        /**
          * 删除资源标签
          *
          * @param request UntagResourceRequest
          * @return UntagResourceResponse
         */
        public async Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourceWithOptionsAsync(request, headers, runtime);
        }

        /**
          * 更新函数别名
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
          * 更新函数别名
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
          * 更新函数别名
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
          * 更新函数别名
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
          * 更新自定义域名
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
          * 更新自定义域名
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
          * 更新自定义域名
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
          * 更新自定义域名
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
          * 更新函数
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
          * 更新函数
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
          * 更新函数
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
          * 更新函数
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
          * 更新函数触发器
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
          * 更新函数触发器
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
          * 更新函数触发器
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
          * 更新函数触发器
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
