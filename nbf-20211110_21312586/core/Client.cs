// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.NBF20211110_21312586.Models;

namespace AlibabaCloud.SDK.NBF20211110_21312586
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("nbf", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ApiTestResponse ApiTestWithOptions(ApiTestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestCmd))
            {
                query["testCmd"] = request.TestCmd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApiTest",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/apiTest",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<ApiTestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApiTestResponse> ApiTestWithOptionsAsync(ApiTestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestCmd))
            {
                query["testCmd"] = request.TestCmd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApiTest",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/apiTest",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<ApiTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApiTestResponse ApiTest(ApiTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApiTestWithOptions(request, headers, runtime);
        }

        public async Task<ApiTestResponse> ApiTestAsync(ApiTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApiTestWithOptionsAsync(request, headers, runtime);
        }

        public BuildSdkResponse BuildSdkWithOptions(BuildSdkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildCmd))
            {
                query["buildCmd"] = request.BuildCmd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BuildSdk",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/buildSdk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<BuildSdkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BuildSdkResponse> BuildSdkWithOptionsAsync(BuildSdkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildCmd))
            {
                query["buildCmd"] = request.BuildCmd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BuildSdk",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/buildSdk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<BuildSdkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BuildSdkResponse BuildSdk(BuildSdkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BuildSdkWithOptions(request, headers, runtime);
        }

        public async Task<BuildSdkResponse> BuildSdkAsync(BuildSdkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BuildSdkWithOptionsAsync(request, headers, runtime);
        }

        public CreateAndReleaseApiResponse CreateAndReleaseApiWithOptions(CreateAndReleaseApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatApiCmd))
            {
                query["creatApiCmd"] = request.CreatApiCmd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndReleaseApi",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/createAndReleaseApi",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<CreateAndReleaseApiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAndReleaseApiResponse> CreateAndReleaseApiWithOptionsAsync(CreateAndReleaseApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatApiCmd))
            {
                query["creatApiCmd"] = request.CreatApiCmd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndReleaseApi",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/createAndReleaseApi",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<CreateAndReleaseApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAndReleaseApiResponse CreateAndReleaseApi(CreateAndReleaseApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAndReleaseApiWithOptions(request, headers, runtime);
        }

        public async Task<CreateAndReleaseApiResponse> CreateAndReleaseApiAsync(CreateAndReleaseApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAndReleaseApiWithOptionsAsync(request, headers, runtime);
        }

        public CreateSdkVersionResponse CreateSdkVersionWithOptions(CreateSdkVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateSdkCmd))
            {
                query["createSdkCmd"] = request.CreateSdkCmd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSdkVersion",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/createSdkVersion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<CreateSdkVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSdkVersionResponse> CreateSdkVersionWithOptionsAsync(CreateSdkVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateSdkCmd))
            {
                query["createSdkCmd"] = request.CreateSdkCmd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSdkVersion",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/createSdkVersion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<CreateSdkVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSdkVersionResponse CreateSdkVersion(CreateSdkVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSdkVersionWithOptions(request, headers, runtime);
        }

        public async Task<CreateSdkVersionResponse> CreateSdkVersionAsync(CreateSdkVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSdkVersionWithOptionsAsync(request, headers, runtime);
        }

        public DeleteApiResponse DeleteApiWithOptions(DeleteApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiExternalId))
            {
                query["apiExternalId"] = request.ApiExternalId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApi",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/deleteApi",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<DeleteApiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteApiResponse> DeleteApiWithOptionsAsync(DeleteApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiExternalId))
            {
                query["apiExternalId"] = request.ApiExternalId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApi",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/deleteApi",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<DeleteApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteApiResponse DeleteApi(DeleteApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApiWithOptions(request, headers, runtime);
        }

        public async Task<DeleteApiResponse> DeleteApiAsync(DeleteApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApiWithOptionsAsync(request, headers, runtime);
        }

        public GetResultResponse GetResultWithOptions(GetResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResult",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/getResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResultResponse> GetResultWithOptionsAsync(GetResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResult",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/getResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResultResponse GetResult(GetResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResultWithOptions(request, headers, runtime);
        }

        public async Task<GetResultResponse> GetResultAsync(GetResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResultWithOptionsAsync(request, headers, runtime);
        }

        public OpenApiGenericProxyResponse OpenApiGenericProxyWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenApiGenericProxy",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/openApiGenericProxy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiGenericProxyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OpenApiGenericProxyResponse> OpenApiGenericProxyWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenApiGenericProxy",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/openApiGenericProxy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenApiGenericProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OpenApiGenericProxyResponse OpenApiGenericProxy()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenApiGenericProxyWithOptions(headers, runtime);
        }

        public async Task<OpenApiGenericProxyResponse> OpenApiGenericProxyAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenApiGenericProxyWithOptionsAsync(headers, runtime);
        }

        public PreCheckResponse PreCheckWithOptions(PreCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSchemaDTO))
            {
                query["apiSchemaDTO"] = request.ApiSchemaDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupVersionExtraInfo))
            {
                query["groupVersionExtraInfo"] = request.GroupVersionExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceExternalId))
            {
                query["namespaceExternalId"] = request.NamespaceExternalId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreCheck",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/preCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<PreCheckResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PreCheckResponse> PreCheckWithOptionsAsync(PreCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSchemaDTO))
            {
                query["apiSchemaDTO"] = request.ApiSchemaDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupVersionExtraInfo))
            {
                query["groupVersionExtraInfo"] = request.GroupVersionExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceExternalId))
            {
                query["namespaceExternalId"] = request.NamespaceExternalId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreCheck",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/preCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<PreCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PreCheckResponse PreCheck(PreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PreCheckWithOptions(request, headers, runtime);
        }

        public async Task<PreCheckResponse> PreCheckAsync(PreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PreCheckWithOptionsAsync(request, headers, runtime);
        }

        public PublishSdkResponse PublishSdkWithOptions(PublishSdkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishSdk",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/publishSdk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<PublishSdkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PublishSdkResponse> PublishSdkWithOptionsAsync(PublishSdkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishSdk",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/publishSdk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<PublishSdkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PublishSdkResponse PublishSdk(PublishSdkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishSdkWithOptions(request, headers, runtime);
        }

        public async Task<PublishSdkResponse> PublishSdkAsync(PublishSdkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishSdkWithOptionsAsync(request, headers, runtime);
        }

        public SerializeApiResponse SerializeApiWithOptions(SerializeApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSchemaDTO))
            {
                query["apiSchemaDTO"] = request.ApiSchemaDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SerializeApi",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/serializeApi",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<SerializeApiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SerializeApiResponse> SerializeApiWithOptionsAsync(SerializeApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSchemaDTO))
            {
                query["apiSchemaDTO"] = request.ApiSchemaDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SerializeApi",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/serializeApi",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<SerializeApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SerializeApiResponse SerializeApi(SerializeApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SerializeApiWithOptions(request, headers, runtime);
        }

        public async Task<SerializeApiResponse> SerializeApiAsync(SerializeApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SerializeApiWithOptionsAsync(request, headers, runtime);
        }

        public UpdateAndReleaseApiResponse UpdateAndReleaseApiWithOptions(UpdateAndReleaseApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateApiCmd))
            {
                query["updateApiCmd"] = request.UpdateApiCmd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAndReleaseApi",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/updateAndReleaseApi",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<UpdateAndReleaseApiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAndReleaseApiResponse> UpdateAndReleaseApiWithOptionsAsync(UpdateAndReleaseApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateApiCmd))
            {
                query["updateApiCmd"] = request.UpdateApiCmd;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAndReleaseApi",
                Version = "2021-11-10_21-31-25-86",
                Protocol = "HTTPS",
                Pathname = "/nbf_gateway_inner/1_0_0/updateAndReleaseApi",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<UpdateAndReleaseApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAndReleaseApiResponse UpdateAndReleaseApi(UpdateAndReleaseApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAndReleaseApiWithOptions(request, headers, runtime);
        }

        public async Task<UpdateAndReleaseApiResponse> UpdateAndReleaseApiAsync(UpdateAndReleaseApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAndReleaseApiWithOptionsAsync(request, headers, runtime);
        }

    }
}
