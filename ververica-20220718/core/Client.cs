// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ververica20220718.Models;

namespace AlibabaCloud.SDK.Ververica20220718
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ververica", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Creates a deployment.
         *
         * @param request CreateDeploymentRequest
         * @param headers CreateDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeploymentResponse
         */
        public CreateDeploymentResponse CreateDeploymentWithOptions(string namespace_, CreateDeploymentRequest request, CreateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a deployment.
         *
         * @param request CreateDeploymentRequest
         * @param headers CreateDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeploymentResponse
         */
        public async Task<CreateDeploymentResponse> CreateDeploymentWithOptionsAsync(string namespace_, CreateDeploymentRequest request, CreateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a deployment.
         *
         * @param request CreateDeploymentRequest
         * @return CreateDeploymentResponse
         */
        public CreateDeploymentResponse CreateDeployment(string namespace_, CreateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentHeaders headers = new CreateDeploymentHeaders();
            return CreateDeploymentWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Creates a deployment.
         *
         * @param request CreateDeploymentRequest
         * @return CreateDeploymentResponse
         */
        public async Task<CreateDeploymentResponse> CreateDeploymentAsync(string namespace_, CreateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentHeaders headers = new CreateDeploymentHeaders();
            return await CreateDeploymentWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary create a deploymentDraft
         *
         * @param request CreateDeploymentDraftRequest
         * @param headers CreateDeploymentDraftHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeploymentDraftResponse
         */
        public CreateDeploymentDraftResponse CreateDeploymentDraftWithOptions(string namespace_, CreateDeploymentDraftRequest request, CreateDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentDraftResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary create a deploymentDraft
         *
         * @param request CreateDeploymentDraftRequest
         * @param headers CreateDeploymentDraftHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeploymentDraftResponse
         */
        public async Task<CreateDeploymentDraftResponse> CreateDeploymentDraftWithOptionsAsync(string namespace_, CreateDeploymentDraftRequest request, CreateDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary create a deploymentDraft
         *
         * @param request CreateDeploymentDraftRequest
         * @return CreateDeploymentDraftResponse
         */
        public CreateDeploymentDraftResponse CreateDeploymentDraft(string namespace_, CreateDeploymentDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentDraftHeaders headers = new CreateDeploymentDraftHeaders();
            return CreateDeploymentDraftWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary create a deploymentDraft
         *
         * @param request CreateDeploymentDraftRequest
         * @return CreateDeploymentDraftResponse
         */
        public async Task<CreateDeploymentDraftResponse> CreateDeploymentDraftAsync(string namespace_, CreateDeploymentDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentDraftHeaders headers = new CreateDeploymentDraftHeaders();
            return await CreateDeploymentDraftWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary create a folder
         *
         * @param request CreateFolderRequest
         * @param headers CreateFolderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFolderResponse
         */
        public CreateFolderResponse CreateFolderWithOptions(string namespace_, CreateFolderRequest request, CreateFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary create a folder
         *
         * @param request CreateFolderRequest
         * @param headers CreateFolderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFolderResponse
         */
        public async Task<CreateFolderResponse> CreateFolderWithOptionsAsync(string namespace_, CreateFolderRequest request, CreateFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary create a folder
         *
         * @param request CreateFolderRequest
         * @return CreateFolderResponse
         */
        public CreateFolderResponse CreateFolder(string namespace_, CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFolderHeaders headers = new CreateFolderHeaders();
            return CreateFolderWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary create a folder
         *
         * @param request CreateFolderRequest
         * @return CreateFolderResponse
         */
        public async Task<CreateFolderResponse> CreateFolderAsync(string namespace_, CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFolderHeaders headers = new CreateFolderHeaders();
            return await CreateFolderWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Adds a user to a namespace as a member and grants permissions to the user.
         *
         * @param request CreateMemberRequest
         * @param headers CreateMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMemberResponse
         */
        public CreateMemberResponse CreateMemberWithOptions(string namespace_, CreateMemberRequest request, CreateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a user to a namespace as a member and grants permissions to the user.
         *
         * @param request CreateMemberRequest
         * @param headers CreateMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMemberResponse
         */
        public async Task<CreateMemberResponse> CreateMemberWithOptionsAsync(string namespace_, CreateMemberRequest request, CreateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a user to a namespace as a member and grants permissions to the user.
         *
         * @param request CreateMemberRequest
         * @return CreateMemberResponse
         */
        public CreateMemberResponse CreateMember(string namespace_, CreateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMemberHeaders headers = new CreateMemberHeaders();
            return CreateMemberWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Adds a user to a namespace as a member and grants permissions to the user.
         *
         * @param request CreateMemberRequest
         * @return CreateMemberResponse
         */
        public async Task<CreateMemberResponse> CreateMemberAsync(string namespace_, CreateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMemberHeaders headers = new CreateMemberHeaders();
            return await CreateMemberWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Creates a savepoint.
         *
         * @param request CreateSavepointRequest
         * @param headers CreateSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSavepointResponse
         */
        public CreateSavepointResponse CreateSavepointWithOptions(string namespace_, CreateSavepointRequest request, CreateSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                body["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NativeFormat))
            {
                body["nativeFormat"] = request.NativeFormat;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSavepointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a savepoint.
         *
         * @param request CreateSavepointRequest
         * @param headers CreateSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSavepointResponse
         */
        public async Task<CreateSavepointResponse> CreateSavepointWithOptionsAsync(string namespace_, CreateSavepointRequest request, CreateSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                body["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NativeFormat))
            {
                body["nativeFormat"] = request.NativeFormat;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSavepointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a savepoint.
         *
         * @param request CreateSavepointRequest
         * @return CreateSavepointResponse
         */
        public CreateSavepointResponse CreateSavepoint(string namespace_, CreateSavepointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSavepointHeaders headers = new CreateSavepointHeaders();
            return CreateSavepointWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Creates a savepoint.
         *
         * @param request CreateSavepointRequest
         * @return CreateSavepointResponse
         */
        public async Task<CreateSavepointResponse> CreateSavepointAsync(string namespace_, CreateSavepointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSavepointHeaders headers = new CreateSavepointHeaders();
            return await CreateSavepointWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Parses all user-defined function (UDF) methods in your JAR or Python file and creates an artifact configuration for a UDF.
         *
         * @param request CreateUdfArtifactRequest
         * @param headers CreateUdfArtifactHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUdfArtifactResponse
         */
        public CreateUdfArtifactResponse CreateUdfArtifactWithOptions(string namespace_, CreateUdfArtifactRequest request, CreateUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUdfArtifactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Parses all user-defined function (UDF) methods in your JAR or Python file and creates an artifact configuration for a UDF.
         *
         * @param request CreateUdfArtifactRequest
         * @param headers CreateUdfArtifactHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUdfArtifactResponse
         */
        public async Task<CreateUdfArtifactResponse> CreateUdfArtifactWithOptionsAsync(string namespace_, CreateUdfArtifactRequest request, CreateUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUdfArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Parses all user-defined function (UDF) methods in your JAR or Python file and creates an artifact configuration for a UDF.
         *
         * @param request CreateUdfArtifactRequest
         * @return CreateUdfArtifactResponse
         */
        public CreateUdfArtifactResponse CreateUdfArtifact(string namespace_, CreateUdfArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUdfArtifactHeaders headers = new CreateUdfArtifactHeaders();
            return CreateUdfArtifactWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Parses all user-defined function (UDF) methods in your JAR or Python file and creates an artifact configuration for a UDF.
         *
         * @param request CreateUdfArtifactRequest
         * @return CreateUdfArtifactResponse
         */
        public async Task<CreateUdfArtifactResponse> CreateUdfArtifactAsync(string namespace_, CreateUdfArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUdfArtifactHeaders headers = new CreateUdfArtifactHeaders();
            return await CreateUdfArtifactWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Creates a variable.
         *
         * @param request CreateVariableRequest
         * @param headers CreateVariableHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVariableResponse
         */
        public CreateVariableResponse CreateVariableWithOptions(string namespace_, CreateVariableRequest request, CreateVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVariableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a variable.
         *
         * @param request CreateVariableRequest
         * @param headers CreateVariableHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVariableResponse
         */
        public async Task<CreateVariableResponse> CreateVariableWithOptionsAsync(string namespace_, CreateVariableRequest request, CreateVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVariableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a variable.
         *
         * @param request CreateVariableRequest
         * @return CreateVariableResponse
         */
        public CreateVariableResponse CreateVariable(string namespace_, CreateVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVariableHeaders headers = new CreateVariableHeaders();
            return CreateVariableWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Creates a variable.
         *
         * @param request CreateVariableRequest
         * @return CreateVariableResponse
         */
        public async Task<CreateVariableResponse> CreateVariableAsync(string namespace_, CreateVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVariableHeaders headers = new CreateVariableHeaders();
            return await CreateVariableWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Deletes a registered custom connector from a workspace.
         *
         * @param headers DeleteCustomConnectorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomConnectorResponse
         */
        public DeleteCustomConnectorResponse DeleteCustomConnectorWithOptions(string namespace_, string connectorName, DeleteCustomConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomConnector",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(connectorName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomConnectorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a registered custom connector from a workspace.
         *
         * @param headers DeleteCustomConnectorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomConnectorResponse
         */
        public async Task<DeleteCustomConnectorResponse> DeleteCustomConnectorWithOptionsAsync(string namespace_, string connectorName, DeleteCustomConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomConnector",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(connectorName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a registered custom connector from a workspace.
         *
         * @return DeleteCustomConnectorResponse
         */
        public DeleteCustomConnectorResponse DeleteCustomConnector(string namespace_, string connectorName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCustomConnectorHeaders headers = new DeleteCustomConnectorHeaders();
            return DeleteCustomConnectorWithOptions(namespace_, connectorName, headers, runtime);
        }

        /**
         * @summary Deletes a registered custom connector from a workspace.
         *
         * @return DeleteCustomConnectorResponse
         */
        public async Task<DeleteCustomConnectorResponse> DeleteCustomConnectorAsync(string namespace_, string connectorName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCustomConnectorHeaders headers = new DeleteCustomConnectorHeaders();
            return await DeleteCustomConnectorWithOptionsAsync(namespace_, connectorName, headers, runtime);
        }

        /**
         * @summary Deletes a deployment based on the deployment ID.
         *
         * @param headers DeleteDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeploymentResponse
         */
        public DeleteDeploymentResponse DeleteDeploymentWithOptions(string namespace_, string deploymentId, DeleteDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a deployment based on the deployment ID.
         *
         * @param headers DeleteDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeploymentResponse
         */
        public async Task<DeleteDeploymentResponse> DeleteDeploymentWithOptionsAsync(string namespace_, string deploymentId, DeleteDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a deployment based on the deployment ID.
         *
         * @return DeleteDeploymentResponse
         */
        public DeleteDeploymentResponse DeleteDeployment(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentHeaders headers = new DeleteDeploymentHeaders();
            return DeleteDeploymentWithOptions(namespace_, deploymentId, headers, runtime);
        }

        /**
         * @summary Deletes a deployment based on the deployment ID.
         *
         * @return DeleteDeploymentResponse
         */
        public async Task<DeleteDeploymentResponse> DeleteDeploymentAsync(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentHeaders headers = new DeleteDeploymentHeaders();
            return await DeleteDeploymentWithOptionsAsync(namespace_, deploymentId, headers, runtime);
        }

        /**
         * @summary delete a deploymentDraft
         *
         * @param headers DeleteDeploymentDraftHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeploymentDraftResponse
         */
        public DeleteDeploymentDraftResponse DeleteDeploymentDraftWithOptions(string namespace_, string deploymentDraftId, DeleteDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentDraftResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary delete a deploymentDraft
         *
         * @param headers DeleteDeploymentDraftHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeploymentDraftResponse
         */
        public async Task<DeleteDeploymentDraftResponse> DeleteDeploymentDraftWithOptionsAsync(string namespace_, string deploymentDraftId, DeleteDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary delete a deploymentDraft
         *
         * @return DeleteDeploymentDraftResponse
         */
        public DeleteDeploymentDraftResponse DeleteDeploymentDraft(string namespace_, string deploymentDraftId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentDraftHeaders headers = new DeleteDeploymentDraftHeaders();
            return DeleteDeploymentDraftWithOptions(namespace_, deploymentDraftId, headers, runtime);
        }

        /**
         * @summary delete a deploymentDraft
         *
         * @return DeleteDeploymentDraftResponse
         */
        public async Task<DeleteDeploymentDraftResponse> DeleteDeploymentDraftAsync(string namespace_, string deploymentDraftId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentDraftHeaders headers = new DeleteDeploymentDraftHeaders();
            return await DeleteDeploymentDraftWithOptionsAsync(namespace_, deploymentDraftId, headers, runtime);
        }

        /**
         * @summary delete a folder
         *
         * @param headers DeleteFolderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFolderResponse
         */
        public DeleteFolderResponse DeleteFolderWithOptions(string namespace_, string folderId, DeleteFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary delete a folder
         *
         * @param headers DeleteFolderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFolderResponse
         */
        public async Task<DeleteFolderResponse> DeleteFolderWithOptionsAsync(string namespace_, string folderId, DeleteFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary delete a folder
         *
         * @return DeleteFolderResponse
         */
        public DeleteFolderResponse DeleteFolder(string namespace_, string folderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFolderHeaders headers = new DeleteFolderHeaders();
            return DeleteFolderWithOptions(namespace_, folderId, headers, runtime);
        }

        /**
         * @summary delete a folder
         *
         * @return DeleteFolderResponse
         */
        public async Task<DeleteFolderResponse> DeleteFolderAsync(string namespace_, string folderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFolderHeaders headers = new DeleteFolderHeaders();
            return await DeleteFolderWithOptionsAsync(namespace_, folderId, headers, runtime);
        }

        /**
         * @summary Deletes the information about a job that is not in the running state in a deployment.
         *
         * @param headers DeleteJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobResponse
         */
        public DeleteJobResponse DeleteJobWithOptions(string namespace_, string jobId, DeleteJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes the information about a job that is not in the running state in a deployment.
         *
         * @param headers DeleteJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobResponse
         */
        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(string namespace_, string jobId, DeleteJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes the information about a job that is not in the running state in a deployment.
         *
         * @return DeleteJobResponse
         */
        public DeleteJobResponse DeleteJob(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteJobHeaders headers = new DeleteJobHeaders();
            return DeleteJobWithOptions(namespace_, jobId, headers, runtime);
        }

        /**
         * @summary Deletes the information about a job that is not in the running state in a deployment.
         *
         * @return DeleteJobResponse
         */
        public async Task<DeleteJobResponse> DeleteJobAsync(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteJobHeaders headers = new DeleteJobHeaders();
            return await DeleteJobWithOptionsAsync(namespace_, jobId, headers, runtime);
        }

        /**
         * @summary Revokes the permissions from a member.
         *
         * @param headers DeleteMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMemberResponse
         */
        public DeleteMemberResponse DeleteMemberWithOptions(string namespace_, string member, DeleteMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Revokes the permissions from a member.
         *
         * @param headers DeleteMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMemberResponse
         */
        public async Task<DeleteMemberResponse> DeleteMemberWithOptionsAsync(string namespace_, string member, DeleteMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Revokes the permissions from a member.
         *
         * @return DeleteMemberResponse
         */
        public DeleteMemberResponse DeleteMember(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMemberHeaders headers = new DeleteMemberHeaders();
            return DeleteMemberWithOptions(namespace_, member, headers, runtime);
        }

        /**
         * @summary Revokes the permissions from a member.
         *
         * @return DeleteMemberResponse
         */
        public async Task<DeleteMemberResponse> DeleteMemberAsync(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMemberHeaders headers = new DeleteMemberHeaders();
            return await DeleteMemberWithOptionsAsync(namespace_, member, headers, runtime);
        }

        /**
         * @summary Deletes a savepoint.
         *
         * @param headers DeleteSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSavepointResponse
         */
        public DeleteSavepointResponse DeleteSavepointWithOptions(string namespace_, string savepointId, DeleteSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSavepointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a savepoint.
         *
         * @param headers DeleteSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSavepointResponse
         */
        public async Task<DeleteSavepointResponse> DeleteSavepointWithOptionsAsync(string namespace_, string savepointId, DeleteSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSavepointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a savepoint.
         *
         * @return DeleteSavepointResponse
         */
        public DeleteSavepointResponse DeleteSavepoint(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSavepointHeaders headers = new DeleteSavepointHeaders();
            return DeleteSavepointWithOptions(namespace_, savepointId, headers, runtime);
        }

        /**
         * @summary Deletes a savepoint.
         *
         * @return DeleteSavepointResponse
         */
        public async Task<DeleteSavepointResponse> DeleteSavepointAsync(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSavepointHeaders headers = new DeleteSavepointHeaders();
            return await DeleteSavepointWithOptionsAsync(namespace_, savepointId, headers, runtime);
        }

        /**
         * @summary 删除UdfArtifact
         *
         * @param headers DeleteUdfArtifactHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUdfArtifactResponse
         */
        public DeleteUdfArtifactResponse DeleteUdfArtifactWithOptions(string namespace_, string udfArtifactName, DeleteUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(udfArtifactName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdfArtifactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除UdfArtifact
         *
         * @param headers DeleteUdfArtifactHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUdfArtifactResponse
         */
        public async Task<DeleteUdfArtifactResponse> DeleteUdfArtifactWithOptionsAsync(string namespace_, string udfArtifactName, DeleteUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(udfArtifactName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdfArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除UdfArtifact
         *
         * @return DeleteUdfArtifactResponse
         */
        public DeleteUdfArtifactResponse DeleteUdfArtifact(string namespace_, string udfArtifactName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUdfArtifactHeaders headers = new DeleteUdfArtifactHeaders();
            return DeleteUdfArtifactWithOptions(namespace_, udfArtifactName, headers, runtime);
        }

        /**
         * @summary 删除UdfArtifact
         *
         * @return DeleteUdfArtifactResponse
         */
        public async Task<DeleteUdfArtifactResponse> DeleteUdfArtifactAsync(string namespace_, string udfArtifactName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUdfArtifactHeaders headers = new DeleteUdfArtifactHeaders();
            return await DeleteUdfArtifactWithOptionsAsync(namespace_, udfArtifactName, headers, runtime);
        }

        /**
         * @summary Deletes an existing user-defined function (UDF) from a Realtime Compute for Apache Flink workspace.
         *
         * @param request DeleteUdfFunctionRequest
         * @param headers DeleteUdfFunctionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUdfFunctionResponse
         */
        public DeleteUdfFunctionResponse DeleteUdfFunctionWithOptions(string namespace_, string functionName, DeleteUdfFunctionRequest request, DeleteUdfFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                query["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdfFunction",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/function/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdfFunctionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an existing user-defined function (UDF) from a Realtime Compute for Apache Flink workspace.
         *
         * @param request DeleteUdfFunctionRequest
         * @param headers DeleteUdfFunctionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUdfFunctionResponse
         */
        public async Task<DeleteUdfFunctionResponse> DeleteUdfFunctionWithOptionsAsync(string namespace_, string functionName, DeleteUdfFunctionRequest request, DeleteUdfFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                query["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdfFunction",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/function/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdfFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an existing user-defined function (UDF) from a Realtime Compute for Apache Flink workspace.
         *
         * @param request DeleteUdfFunctionRequest
         * @return DeleteUdfFunctionResponse
         */
        public DeleteUdfFunctionResponse DeleteUdfFunction(string namespace_, string functionName, DeleteUdfFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUdfFunctionHeaders headers = new DeleteUdfFunctionHeaders();
            return DeleteUdfFunctionWithOptions(namespace_, functionName, request, headers, runtime);
        }

        /**
         * @summary Deletes an existing user-defined function (UDF) from a Realtime Compute for Apache Flink workspace.
         *
         * @param request DeleteUdfFunctionRequest
         * @return DeleteUdfFunctionResponse
         */
        public async Task<DeleteUdfFunctionResponse> DeleteUdfFunctionAsync(string namespace_, string functionName, DeleteUdfFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUdfFunctionHeaders headers = new DeleteUdfFunctionHeaders();
            return await DeleteUdfFunctionWithOptionsAsync(namespace_, functionName, request, headers, runtime);
        }

        /**
         * @summary Deletes a variable.
         *
         * @param headers DeleteVariableHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVariableResponse
         */
        public DeleteVariableResponse DeleteVariableWithOptions(string namespace_, string name, DeleteVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVariableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a variable.
         *
         * @param headers DeleteVariableHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVariableResponse
         */
        public async Task<DeleteVariableResponse> DeleteVariableWithOptionsAsync(string namespace_, string name, DeleteVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVariableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a variable.
         *
         * @return DeleteVariableResponse
         */
        public DeleteVariableResponse DeleteVariable(string namespace_, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteVariableHeaders headers = new DeleteVariableHeaders();
            return DeleteVariableWithOptions(namespace_, name, headers, runtime);
        }

        /**
         * @summary Deletes a variable.
         *
         * @return DeleteVariableResponse
         */
        public async Task<DeleteVariableResponse> DeleteVariableAsync(string namespace_, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteVariableHeaders headers = new DeleteVariableHeaders();
            return await DeleteVariableWithOptionsAsync(namespace_, name, headers, runtime);
        }

        /**
         * @summary deploy deploymentDraft async
         *
         * @param request DeployDeploymentDraftAsyncRequest
         * @param headers DeployDeploymentDraftAsyncHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployDeploymentDraftAsyncResponse
         */
        public DeployDeploymentDraftAsyncResponse DeployDeploymentDraftAsyncWithOptions(string namespace_, DeployDeploymentDraftAsyncRequest request, DeployDeploymentDraftAsyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployDeploymentDraftAsync",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/async-deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployDeploymentDraftAsyncResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary deploy deploymentDraft async
         *
         * @param request DeployDeploymentDraftAsyncRequest
         * @param headers DeployDeploymentDraftAsyncHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployDeploymentDraftAsyncResponse
         */
        public async Task<DeployDeploymentDraftAsyncResponse> DeployDeploymentDraftAsyncWithOptionsAsync(string namespace_, DeployDeploymentDraftAsyncRequest request, DeployDeploymentDraftAsyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployDeploymentDraftAsync",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/async-deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployDeploymentDraftAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary deploy deploymentDraft async
         *
         * @param request DeployDeploymentDraftAsyncRequest
         * @return DeployDeploymentDraftAsyncResponse
         */
        public DeployDeploymentDraftAsyncResponse DeployDeploymentDraftAsync(string namespace_, DeployDeploymentDraftAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeployDeploymentDraftAsyncHeaders headers = new DeployDeploymentDraftAsyncHeaders();
            return DeployDeploymentDraftAsyncWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary deploy deploymentDraft async
         *
         * @param request DeployDeploymentDraftAsyncRequest
         * @return DeployDeploymentDraftAsyncResponse
         */
        public async Task<DeployDeploymentDraftAsyncResponse> DeployDeploymentDraftAsyncAsync(string namespace_, DeployDeploymentDraftAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeployDeploymentDraftAsyncHeaders headers = new DeployDeploymentDraftAsyncHeaders();
            return await DeployDeploymentDraftAsyncWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 执行sql语句
         *
         * @param request ExecuteSqlStatementRequest
         * @param headers ExecuteSqlStatementHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteSqlStatementResponse
         */
        public ExecuteSqlStatementResponse ExecuteSqlStatementWithOptions(string namespace_, ExecuteSqlStatementRequest request, ExecuteSqlStatementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteSqlStatement",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-statement/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteSqlStatementResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 执行sql语句
         *
         * @param request ExecuteSqlStatementRequest
         * @param headers ExecuteSqlStatementHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteSqlStatementResponse
         */
        public async Task<ExecuteSqlStatementResponse> ExecuteSqlStatementWithOptionsAsync(string namespace_, ExecuteSqlStatementRequest request, ExecuteSqlStatementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteSqlStatement",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-statement/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteSqlStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 执行sql语句
         *
         * @param request ExecuteSqlStatementRequest
         * @return ExecuteSqlStatementResponse
         */
        public ExecuteSqlStatementResponse ExecuteSqlStatement(string namespace_, ExecuteSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteSqlStatementHeaders headers = new ExecuteSqlStatementHeaders();
            return ExecuteSqlStatementWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary 执行sql语句
         *
         * @param request ExecuteSqlStatementRequest
         * @return ExecuteSqlStatementResponse
         */
        public async Task<ExecuteSqlStatementResponse> ExecuteSqlStatementAsync(string namespace_, ExecuteSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteSqlStatementHeaders headers = new ExecuteSqlStatementHeaders();
            return await ExecuteSqlStatementWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Provides a Flink request proxy.
         *
         * @param request FlinkApiProxyRequest
         * @param headers FlinkApiProxyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FlinkApiProxyResponse
         */
        public FlinkApiProxyResponse FlinkApiProxyWithOptions(FlinkApiProxyRequest request, FlinkApiProxyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlinkApiPath))
            {
                query["flinkApiPath"] = request.FlinkApiPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlinkApiProxy",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/flink-ui/v2/proxy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlinkApiProxyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Provides a Flink request proxy.
         *
         * @param request FlinkApiProxyRequest
         * @param headers FlinkApiProxyHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FlinkApiProxyResponse
         */
        public async Task<FlinkApiProxyResponse> FlinkApiProxyWithOptionsAsync(FlinkApiProxyRequest request, FlinkApiProxyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlinkApiPath))
            {
                query["flinkApiPath"] = request.FlinkApiPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlinkApiProxy",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/flink-ui/v2/proxy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlinkApiProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Provides a Flink request proxy.
         *
         * @param request FlinkApiProxyRequest
         * @return FlinkApiProxyResponse
         */
        public FlinkApiProxyResponse FlinkApiProxy(FlinkApiProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlinkApiProxyHeaders headers = new FlinkApiProxyHeaders();
            return FlinkApiProxyWithOptions(request, headers, runtime);
        }

        /**
         * @summary Provides a Flink request proxy.
         *
         * @param request FlinkApiProxyRequest
         * @return FlinkApiProxyResponse
         */
        public async Task<FlinkApiProxyResponse> FlinkApiProxyAsync(FlinkApiProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlinkApiProxyHeaders headers = new FlinkApiProxyHeaders();
            return await FlinkApiProxyWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Submits a ticket that applies for asynchronous generation of the fine-grained resources. This operation returns the ID of the ticket for you to query the asynchronous generation result.
         *
         * @param request GenerateResourcePlanWithFlinkConfAsyncRequest
         * @param headers GenerateResourcePlanWithFlinkConfAsyncHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateResourcePlanWithFlinkConfAsyncResponse
         */
        public GenerateResourcePlanWithFlinkConfAsyncResponse GenerateResourcePlanWithFlinkConfAsyncWithOptions(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request, GenerateResourcePlanWithFlinkConfAsyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResourcePlanWithFlinkConfAsync",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/resource-plan%3AasyncGenerate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResourcePlanWithFlinkConfAsyncResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Submits a ticket that applies for asynchronous generation of the fine-grained resources. This operation returns the ID of the ticket for you to query the asynchronous generation result.
         *
         * @param request GenerateResourcePlanWithFlinkConfAsyncRequest
         * @param headers GenerateResourcePlanWithFlinkConfAsyncHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateResourcePlanWithFlinkConfAsyncResponse
         */
        public async Task<GenerateResourcePlanWithFlinkConfAsyncResponse> GenerateResourcePlanWithFlinkConfAsyncWithOptionsAsync(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request, GenerateResourcePlanWithFlinkConfAsyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResourcePlanWithFlinkConfAsync",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/resource-plan%3AasyncGenerate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResourcePlanWithFlinkConfAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Submits a ticket that applies for asynchronous generation of the fine-grained resources. This operation returns the ID of the ticket for you to query the asynchronous generation result.
         *
         * @param request GenerateResourcePlanWithFlinkConfAsyncRequest
         * @return GenerateResourcePlanWithFlinkConfAsyncResponse
         */
        public GenerateResourcePlanWithFlinkConfAsyncResponse GenerateResourcePlanWithFlinkConfAsync(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateResourcePlanWithFlinkConfAsyncHeaders headers = new GenerateResourcePlanWithFlinkConfAsyncHeaders();
            return GenerateResourcePlanWithFlinkConfAsyncWithOptions(namespace_, deploymentId, request, headers, runtime);
        }

        /**
         * @summary Submits a ticket that applies for asynchronous generation of the fine-grained resources. This operation returns the ID of the ticket for you to query the asynchronous generation result.
         *
         * @param request GenerateResourcePlanWithFlinkConfAsyncRequest
         * @return GenerateResourcePlanWithFlinkConfAsyncResponse
         */
        public async Task<GenerateResourcePlanWithFlinkConfAsyncResponse> GenerateResourcePlanWithFlinkConfAsyncAsync(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateResourcePlanWithFlinkConfAsyncHeaders headers = new GenerateResourcePlanWithFlinkConfAsyncHeaders();
            return await GenerateResourcePlanWithFlinkConfAsyncWithOptionsAsync(namespace_, deploymentId, request, headers, runtime);
        }

        /**
         * @summary 获取catalog
         *
         * @param request GetCatalogsRequest
         * @param headers GetCatalogsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCatalogsResponse
         */
        public GetCatalogsResponse GetCatalogsWithOptions(string namespace_, GetCatalogsRequest request, GetCatalogsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["catalogName"] = request.CatalogName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogs",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取catalog
         *
         * @param request GetCatalogsRequest
         * @param headers GetCatalogsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCatalogsResponse
         */
        public async Task<GetCatalogsResponse> GetCatalogsWithOptionsAsync(string namespace_, GetCatalogsRequest request, GetCatalogsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["catalogName"] = request.CatalogName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogs",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取catalog
         *
         * @param request GetCatalogsRequest
         * @return GetCatalogsResponse
         */
        public GetCatalogsResponse GetCatalogs(string namespace_, GetCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCatalogsHeaders headers = new GetCatalogsHeaders();
            return GetCatalogsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary 获取catalog
         *
         * @param request GetCatalogsRequest
         * @return GetCatalogsResponse
         */
        public async Task<GetCatalogsResponse> GetCatalogsAsync(string namespace_, GetCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCatalogsHeaders headers = new GetCatalogsHeaders();
            return await GetCatalogsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 获取database
         *
         * @param request GetDatabasesRequest
         * @param headers GetDatabasesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatabasesResponse
         */
        public GetDatabasesResponse GetDatabasesWithOptions(string namespace_, string catalogName, GetDatabasesRequest request, GetDatabasesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["databaseName"] = request.DatabaseName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabases",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogName) + "/databases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取database
         *
         * @param request GetDatabasesRequest
         * @param headers GetDatabasesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatabasesResponse
         */
        public async Task<GetDatabasesResponse> GetDatabasesWithOptionsAsync(string namespace_, string catalogName, GetDatabasesRequest request, GetDatabasesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["databaseName"] = request.DatabaseName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabases",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogName) + "/databases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取database
         *
         * @param request GetDatabasesRequest
         * @return GetDatabasesResponse
         */
        public GetDatabasesResponse GetDatabases(string namespace_, string catalogName, GetDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDatabasesHeaders headers = new GetDatabasesHeaders();
            return GetDatabasesWithOptions(namespace_, catalogName, request, headers, runtime);
        }

        /**
         * @summary 获取database
         *
         * @param request GetDatabasesRequest
         * @return GetDatabasesResponse
         */
        public async Task<GetDatabasesResponse> GetDatabasesAsync(string namespace_, string catalogName, GetDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDatabasesHeaders headers = new GetDatabasesHeaders();
            return await GetDatabasesWithOptionsAsync(namespace_, catalogName, request, headers, runtime);
        }

        /**
         * @summary get deploy deploymentDraft result
         *
         * @param headers GetDeployDeploymentDraftResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeployDeploymentDraftResultResponse
         */
        public GetDeployDeploymentDraftResultResponse GetDeployDeploymentDraftResultWithOptions(string namespace_, string ticketId, GetDeployDeploymentDraftResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployDeploymentDraftResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/tickets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ticketId) + "/async-deploy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeployDeploymentDraftResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get deploy deploymentDraft result
         *
         * @param headers GetDeployDeploymentDraftResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeployDeploymentDraftResultResponse
         */
        public async Task<GetDeployDeploymentDraftResultResponse> GetDeployDeploymentDraftResultWithOptionsAsync(string namespace_, string ticketId, GetDeployDeploymentDraftResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployDeploymentDraftResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/tickets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ticketId) + "/async-deploy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeployDeploymentDraftResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get deploy deploymentDraft result
         *
         * @return GetDeployDeploymentDraftResultResponse
         */
        public GetDeployDeploymentDraftResultResponse GetDeployDeploymentDraftResult(string namespace_, string ticketId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeployDeploymentDraftResultHeaders headers = new GetDeployDeploymentDraftResultHeaders();
            return GetDeployDeploymentDraftResultWithOptions(namespace_, ticketId, headers, runtime);
        }

        /**
         * @summary get deploy deploymentDraft result
         *
         * @return GetDeployDeploymentDraftResultResponse
         */
        public async Task<GetDeployDeploymentDraftResultResponse> GetDeployDeploymentDraftResultAsync(string namespace_, string ticketId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeployDeploymentDraftResultHeaders headers = new GetDeployDeploymentDraftResultHeaders();
            return await GetDeployDeploymentDraftResultWithOptionsAsync(namespace_, ticketId, headers, runtime);
        }

        /**
         * @summary Obtains the details of a deployment.
         *
         * @param headers GetDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeploymentResponse
         */
        public GetDeploymentResponse GetDeploymentWithOptions(string namespace_, string deploymentId, GetDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of a deployment.
         *
         * @param headers GetDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeploymentResponse
         */
        public async Task<GetDeploymentResponse> GetDeploymentWithOptionsAsync(string namespace_, string deploymentId, GetDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of a deployment.
         *
         * @return GetDeploymentResponse
         */
        public GetDeploymentResponse GetDeployment(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentHeaders headers = new GetDeploymentHeaders();
            return GetDeploymentWithOptions(namespace_, deploymentId, headers, runtime);
        }

        /**
         * @summary Obtains the details of a deployment.
         *
         * @return GetDeploymentResponse
         */
        public async Task<GetDeploymentResponse> GetDeploymentAsync(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentHeaders headers = new GetDeploymentHeaders();
            return await GetDeploymentWithOptionsAsync(namespace_, deploymentId, headers, runtime);
        }

        /**
         * @summary get a deploymentDraft
         *
         * @param headers GetDeploymentDraftHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeploymentDraftResponse
         */
        public GetDeploymentDraftResponse GetDeploymentDraftWithOptions(string namespace_, string deploymentDraftId, GetDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentDraftResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get a deploymentDraft
         *
         * @param headers GetDeploymentDraftHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeploymentDraftResponse
         */
        public async Task<GetDeploymentDraftResponse> GetDeploymentDraftWithOptionsAsync(string namespace_, string deploymentDraftId, GetDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get a deploymentDraft
         *
         * @return GetDeploymentDraftResponse
         */
        public GetDeploymentDraftResponse GetDeploymentDraft(string namespace_, string deploymentDraftId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentDraftHeaders headers = new GetDeploymentDraftHeaders();
            return GetDeploymentDraftWithOptions(namespace_, deploymentDraftId, headers, runtime);
        }

        /**
         * @summary get a deploymentDraft
         *
         * @return GetDeploymentDraftResponse
         */
        public async Task<GetDeploymentDraftResponse> GetDeploymentDraftAsync(string namespace_, string deploymentDraftId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentDraftHeaders headers = new GetDeploymentDraftHeaders();
            return await GetDeploymentDraftWithOptionsAsync(namespace_, deploymentDraftId, headers, runtime);
        }

        /**
         * @summary get deploymentDraft lock
         *
         * @param request GetDeploymentDraftLockRequest
         * @param headers GetDeploymentDraftLockHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeploymentDraftLockResponse
         */
        public GetDeploymentDraftLockResponse GetDeploymentDraftLockWithOptions(string namespace_, GetDeploymentDraftLockRequest request, GetDeploymentDraftLockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentDraftId))
            {
                query["deploymentDraftId"] = request.DeploymentDraftId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeploymentDraftLock",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/getLock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentDraftLockResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get deploymentDraft lock
         *
         * @param request GetDeploymentDraftLockRequest
         * @param headers GetDeploymentDraftLockHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeploymentDraftLockResponse
         */
        public async Task<GetDeploymentDraftLockResponse> GetDeploymentDraftLockWithOptionsAsync(string namespace_, GetDeploymentDraftLockRequest request, GetDeploymentDraftLockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentDraftId))
            {
                query["deploymentDraftId"] = request.DeploymentDraftId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeploymentDraftLock",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/getLock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentDraftLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get deploymentDraft lock
         *
         * @param request GetDeploymentDraftLockRequest
         * @return GetDeploymentDraftLockResponse
         */
        public GetDeploymentDraftLockResponse GetDeploymentDraftLock(string namespace_, GetDeploymentDraftLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentDraftLockHeaders headers = new GetDeploymentDraftLockHeaders();
            return GetDeploymentDraftLockWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary get deploymentDraft lock
         *
         * @param request GetDeploymentDraftLockRequest
         * @return GetDeploymentDraftLockResponse
         */
        public async Task<GetDeploymentDraftLockResponse> GetDeploymentDraftLockAsync(string namespace_, GetDeploymentDraftLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentDraftLockHeaders headers = new GetDeploymentDraftLockHeaders();
            return await GetDeploymentDraftLockWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary get a folder
         *
         * @param request GetFolderRequest
         * @param headers GetFolderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFolderResponse
         */
        public GetFolderResponse GetFolderWithOptions(string namespace_, GetFolderRequest request, GetFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["folderId"] = request.FolderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary get a folder
         *
         * @param request GetFolderRequest
         * @param headers GetFolderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFolderResponse
         */
        public async Task<GetFolderResponse> GetFolderWithOptionsAsync(string namespace_, GetFolderRequest request, GetFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["folderId"] = request.FolderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary get a folder
         *
         * @param request GetFolderRequest
         * @return GetFolderResponse
         */
        public GetFolderResponse GetFolder(string namespace_, GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFolderHeaders headers = new GetFolderHeaders();
            return GetFolderWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary get a folder
         *
         * @param request GetFolderRequest
         * @return GetFolderResponse
         */
        public async Task<GetFolderResponse> GetFolderAsync(string namespace_, GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFolderHeaders headers = new GetFolderHeaders();
            return await GetFolderWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Obtains the asynchronous generation result of fine-grained resources based on the ID of the ticket that applies for an asynchronous generation.
         *
         * @param headers GetGenerateResourcePlanResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGenerateResourcePlanResultResponse
         */
        public GetGenerateResourcePlanResultResponse GetGenerateResourcePlanResultWithOptions(string namespace_, string ticketId, GetGenerateResourcePlanResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGenerateResourcePlanResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/tickets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ticketId) + "/resource-plan%3AasyncGenerate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGenerateResourcePlanResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the asynchronous generation result of fine-grained resources based on the ID of the ticket that applies for an asynchronous generation.
         *
         * @param headers GetGenerateResourcePlanResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGenerateResourcePlanResultResponse
         */
        public async Task<GetGenerateResourcePlanResultResponse> GetGenerateResourcePlanResultWithOptionsAsync(string namespace_, string ticketId, GetGenerateResourcePlanResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGenerateResourcePlanResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/tickets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ticketId) + "/resource-plan%3AasyncGenerate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGenerateResourcePlanResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the asynchronous generation result of fine-grained resources based on the ID of the ticket that applies for an asynchronous generation.
         *
         * @return GetGenerateResourcePlanResultResponse
         */
        public GetGenerateResourcePlanResultResponse GetGenerateResourcePlanResult(string namespace_, string ticketId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGenerateResourcePlanResultHeaders headers = new GetGenerateResourcePlanResultHeaders();
            return GetGenerateResourcePlanResultWithOptions(namespace_, ticketId, headers, runtime);
        }

        /**
         * @summary Obtains the asynchronous generation result of fine-grained resources based on the ID of the ticket that applies for an asynchronous generation.
         *
         * @return GetGenerateResourcePlanResultResponse
         */
        public async Task<GetGenerateResourcePlanResultResponse> GetGenerateResourcePlanResultAsync(string namespace_, string ticketId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGenerateResourcePlanResultHeaders headers = new GetGenerateResourcePlanResultHeaders();
            return await GetGenerateResourcePlanResultWithOptionsAsync(namespace_, ticketId, headers, runtime);
        }

        /**
         * @summary 查询动态更新结果
         *
         * @param headers GetHotUpdateJobResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHotUpdateJobResultResponse
         */
        public GetHotUpdateJobResultResponse GetHotUpdateJobResultWithOptions(string namespace_, string jobHotUpdateId, GetHotUpdateJobResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotUpdateJobResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/hot-updates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobHotUpdateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotUpdateJobResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询动态更新结果
         *
         * @param headers GetHotUpdateJobResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHotUpdateJobResultResponse
         */
        public async Task<GetHotUpdateJobResultResponse> GetHotUpdateJobResultWithOptionsAsync(string namespace_, string jobHotUpdateId, GetHotUpdateJobResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotUpdateJobResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/hot-updates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobHotUpdateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotUpdateJobResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询动态更新结果
         *
         * @return GetHotUpdateJobResultResponse
         */
        public GetHotUpdateJobResultResponse GetHotUpdateJobResult(string namespace_, string jobHotUpdateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotUpdateJobResultHeaders headers = new GetHotUpdateJobResultHeaders();
            return GetHotUpdateJobResultWithOptions(namespace_, jobHotUpdateId, headers, runtime);
        }

        /**
         * @summary 查询动态更新结果
         *
         * @return GetHotUpdateJobResultResponse
         */
        public async Task<GetHotUpdateJobResultResponse> GetHotUpdateJobResultAsync(string namespace_, string jobHotUpdateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotUpdateJobResultHeaders headers = new GetHotUpdateJobResultHeaders();
            return await GetHotUpdateJobResultWithOptionsAsync(namespace_, jobHotUpdateId, headers, runtime);
        }

        /**
         * @summary Obtains the details of a job.
         *
         * @param headers GetJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobResponse
         */
        public GetJobResponse GetJobWithOptions(string namespace_, string jobId, GetJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of a job.
         *
         * @param headers GetJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobResponse
         */
        public async Task<GetJobResponse> GetJobWithOptionsAsync(string namespace_, string jobId, GetJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of a job.
         *
         * @return GetJobResponse
         */
        public GetJobResponse GetJob(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobHeaders headers = new GetJobHeaders();
            return GetJobWithOptions(namespace_, jobId, headers, runtime);
        }

        /**
         * @summary Obtains the details of a job.
         *
         * @return GetJobResponse
         */
        public async Task<GetJobResponse> GetJobAsync(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobHeaders headers = new GetJobHeaders();
            return await GetJobWithOptionsAsync(namespace_, jobId, headers, runtime);
        }

        /**
         * @summary Obtains the latest startup logs of a job.
         *
         * @param headers GetLatestJobStartLogHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLatestJobStartLogResponse
         */
        public GetLatestJobStartLogResponse GetLatestJobStartLogWithOptions(string namespace_, string deploymentId, GetLatestJobStartLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLatestJobStartLog",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/latest_jobmanager_start_log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLatestJobStartLogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the latest startup logs of a job.
         *
         * @param headers GetLatestJobStartLogHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLatestJobStartLogResponse
         */
        public async Task<GetLatestJobStartLogResponse> GetLatestJobStartLogWithOptionsAsync(string namespace_, string deploymentId, GetLatestJobStartLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLatestJobStartLog",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/latest_jobmanager_start_log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLatestJobStartLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the latest startup logs of a job.
         *
         * @return GetLatestJobStartLogResponse
         */
        public GetLatestJobStartLogResponse GetLatestJobStartLog(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLatestJobStartLogHeaders headers = new GetLatestJobStartLogHeaders();
            return GetLatestJobStartLogWithOptions(namespace_, deploymentId, headers, runtime);
        }

        /**
         * @summary Obtains the latest startup logs of a job.
         *
         * @return GetLatestJobStartLogResponse
         */
        public async Task<GetLatestJobStartLogResponse> GetLatestJobStartLogAsync(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLatestJobStartLogHeaders headers = new GetLatestJobStartLogHeaders();
            return await GetLatestJobStartLogWithOptionsAsync(namespace_, deploymentId, headers, runtime);
        }

        /**
         * @summary Obtains the lineage information of a deployment.
         *
         * @param request GetLineageInfoRequest
         * @param headers GetLineageInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLineageInfoResponse
         */
        public GetLineageInfoResponse GetLineageInfoWithOptions(GetLineageInfoRequest request, GetLineageInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLineageInfo",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/meta/v2/lineage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLineageInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the lineage information of a deployment.
         *
         * @param request GetLineageInfoRequest
         * @param headers GetLineageInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLineageInfoResponse
         */
        public async Task<GetLineageInfoResponse> GetLineageInfoWithOptionsAsync(GetLineageInfoRequest request, GetLineageInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLineageInfo",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/meta/v2/lineage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLineageInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the lineage information of a deployment.
         *
         * @param request GetLineageInfoRequest
         * @return GetLineageInfoResponse
         */
        public GetLineageInfoResponse GetLineageInfo(GetLineageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLineageInfoHeaders headers = new GetLineageInfoHeaders();
            return GetLineageInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary Obtains the lineage information of a deployment.
         *
         * @param request GetLineageInfoRequest
         * @return GetLineageInfoResponse
         */
        public async Task<GetLineageInfoResponse> GetLineageInfoAsync(GetLineageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLineageInfoHeaders headers = new GetLineageInfoHeaders();
            return await GetLineageInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the permissions of a member.
         *
         * @param headers GetMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMemberResponse
         */
        public GetMemberResponse GetMemberWithOptions(string namespace_, string member, GetMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the permissions of a member.
         *
         * @param headers GetMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMemberResponse
         */
        public async Task<GetMemberResponse> GetMemberWithOptionsAsync(string namespace_, string member, GetMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the permissions of a member.
         *
         * @return GetMemberResponse
         */
        public GetMemberResponse GetMember(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMemberHeaders headers = new GetMemberHeaders();
            return GetMemberWithOptions(namespace_, member, headers, runtime);
        }

        /**
         * @summary Queries the permissions of a member.
         *
         * @return GetMemberResponse
         */
        public async Task<GetMemberResponse> GetMemberAsync(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMemberHeaders headers = new GetMemberHeaders();
            return await GetMemberWithOptionsAsync(namespace_, member, headers, runtime);
        }

        /**
         * @summary Queries details of a savepoint and checkpoint.
         *
         * @param headers GetSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSavepointResponse
         */
        public GetSavepointResponse GetSavepointWithOptions(string namespace_, string savepointId, GetSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavepointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries details of a savepoint and checkpoint.
         *
         * @param headers GetSavepointHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSavepointResponse
         */
        public async Task<GetSavepointResponse> GetSavepointWithOptionsAsync(string namespace_, string savepointId, GetSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavepointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries details of a savepoint and checkpoint.
         *
         * @return GetSavepointResponse
         */
        public GetSavepointResponse GetSavepoint(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSavepointHeaders headers = new GetSavepointHeaders();
            return GetSavepointWithOptions(namespace_, savepointId, headers, runtime);
        }

        /**
         * @summary Queries details of a savepoint and checkpoint.
         *
         * @return GetSavepointResponse
         */
        public async Task<GetSavepointResponse> GetSavepointAsync(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSavepointHeaders headers = new GetSavepointHeaders();
            return await GetSavepointWithOptionsAsync(namespace_, savepointId, headers, runtime);
        }

        /**
         * @summary 获取table
         *
         * @param request GetTablesRequest
         * @param headers GetTablesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTablesResponse
         */
        public GetTablesResponse GetTablesWithOptions(string namespace_, string catalogName, string databaseName, GetTablesRequest request, GetTablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["tableName"] = request.TableName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTables",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogName) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(databaseName) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取table
         *
         * @param request GetTablesRequest
         * @param headers GetTablesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTablesResponse
         */
        public async Task<GetTablesResponse> GetTablesWithOptionsAsync(string namespace_, string catalogName, string databaseName, GetTablesRequest request, GetTablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["tableName"] = request.TableName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTables",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogName) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(databaseName) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取table
         *
         * @param request GetTablesRequest
         * @return GetTablesResponse
         */
        public GetTablesResponse GetTables(string namespace_, string catalogName, string databaseName, GetTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTablesHeaders headers = new GetTablesHeaders();
            return GetTablesWithOptions(namespace_, catalogName, databaseName, request, headers, runtime);
        }

        /**
         * @summary 获取table
         *
         * @param request GetTablesRequest
         * @return GetTablesResponse
         */
        public async Task<GetTablesResponse> GetTablesAsync(string namespace_, string catalogName, string databaseName, GetTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTablesHeaders headers = new GetTablesHeaders();
            return await GetTablesWithOptionsAsync(namespace_, catalogName, databaseName, request, headers, runtime);
        }

        /**
         * @summary Obtains the details of the JAR or Python file that corresponds to the user-defined function (UDF) that you upload and create.
         *
         * @param request GetUdfArtifactsRequest
         * @param headers GetUdfArtifactsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUdfArtifactsResponse
         */
        public GetUdfArtifactsResponse GetUdfArtifactsWithOptions(string namespace_, GetUdfArtifactsRequest request, GetUdfArtifactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUdfArtifacts",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUdfArtifactsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of the JAR or Python file that corresponds to the user-defined function (UDF) that you upload and create.
         *
         * @param request GetUdfArtifactsRequest
         * @param headers GetUdfArtifactsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUdfArtifactsResponse
         */
        public async Task<GetUdfArtifactsResponse> GetUdfArtifactsWithOptionsAsync(string namespace_, GetUdfArtifactsRequest request, GetUdfArtifactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUdfArtifacts",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUdfArtifactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of the JAR or Python file that corresponds to the user-defined function (UDF) that you upload and create.
         *
         * @param request GetUdfArtifactsRequest
         * @return GetUdfArtifactsResponse
         */
        public GetUdfArtifactsResponse GetUdfArtifacts(string namespace_, GetUdfArtifactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUdfArtifactsHeaders headers = new GetUdfArtifactsHeaders();
            return GetUdfArtifactsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Obtains the details of the JAR or Python file that corresponds to the user-defined function (UDF) that you upload and create.
         *
         * @param request GetUdfArtifactsRequest
         * @return GetUdfArtifactsResponse
         */
        public async Task<GetUdfArtifactsResponse> GetUdfArtifactsAsync(string namespace_, GetUdfArtifactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUdfArtifactsHeaders headers = new GetUdfArtifactsHeaders();
            return await GetUdfArtifactsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Dynamically updates parameters or resources of a deployment that is running.
         *
         * @param headers HotUpdateJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HotUpdateJobResponse
         */
        public HotUpdateJobResponse HotUpdateJobWithOptions(string namespace_, string jobId, HotUpdateJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotUpdateJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "%3AhotUpdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotUpdateJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Dynamically updates parameters or resources of a deployment that is running.
         *
         * @param headers HotUpdateJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HotUpdateJobResponse
         */
        public async Task<HotUpdateJobResponse> HotUpdateJobWithOptionsAsync(string namespace_, string jobId, HotUpdateJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotUpdateJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "%3AhotUpdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotUpdateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Dynamically updates parameters or resources of a deployment that is running.
         *
         * @return HotUpdateJobResponse
         */
        public HotUpdateJobResponse HotUpdateJob(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotUpdateJobHeaders headers = new HotUpdateJobHeaders();
            return HotUpdateJobWithOptions(namespace_, jobId, headers, runtime);
        }

        /**
         * @summary Dynamically updates parameters or resources of a deployment that is running.
         *
         * @return HotUpdateJobResponse
         */
        public async Task<HotUpdateJobResponse> HotUpdateJobAsync(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotUpdateJobHeaders headers = new HotUpdateJobHeaders();
            return await HotUpdateJobWithOptionsAsync(namespace_, jobId, headers, runtime);
        }

        /**
         * @summary Obtains a list of existing custom connectors.
         *
         * @param headers ListCustomConnectorsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomConnectorsResponse
         */
        public ListCustomConnectorsResponse ListCustomConnectorsWithOptions(string namespace_, ListCustomConnectorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomConnectors",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomConnectorsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of existing custom connectors.
         *
         * @param headers ListCustomConnectorsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomConnectorsResponse
         */
        public async Task<ListCustomConnectorsResponse> ListCustomConnectorsWithOptionsAsync(string namespace_, ListCustomConnectorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomConnectors",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomConnectorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of existing custom connectors.
         *
         * @return ListCustomConnectorsResponse
         */
        public ListCustomConnectorsResponse ListCustomConnectors(string namespace_)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCustomConnectorsHeaders headers = new ListCustomConnectorsHeaders();
            return ListCustomConnectorsWithOptions(namespace_, headers, runtime);
        }

        /**
         * @summary Obtains a list of existing custom connectors.
         *
         * @return ListCustomConnectorsResponse
         */
        public async Task<ListCustomConnectorsResponse> ListCustomConnectorsAsync(string namespace_)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCustomConnectorsHeaders headers = new ListCustomConnectorsHeaders();
            return await ListCustomConnectorsWithOptionsAsync(namespace_, headers, runtime);
        }

        /**
         * @summary list deploymentDrafts
         *
         * @param request ListDeploymentDraftsRequest
         * @param headers ListDeploymentDraftsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentDraftsResponse
         */
        public ListDeploymentDraftsResponse ListDeploymentDraftsWithOptions(string namespace_, ListDeploymentDraftsRequest request, ListDeploymentDraftsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentDrafts",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentDraftsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary list deploymentDrafts
         *
         * @param request ListDeploymentDraftsRequest
         * @param headers ListDeploymentDraftsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentDraftsResponse
         */
        public async Task<ListDeploymentDraftsResponse> ListDeploymentDraftsWithOptionsAsync(string namespace_, ListDeploymentDraftsRequest request, ListDeploymentDraftsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentDrafts",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentDraftsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary list deploymentDrafts
         *
         * @param request ListDeploymentDraftsRequest
         * @return ListDeploymentDraftsResponse
         */
        public ListDeploymentDraftsResponse ListDeploymentDrafts(string namespace_, ListDeploymentDraftsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentDraftsHeaders headers = new ListDeploymentDraftsHeaders();
            return ListDeploymentDraftsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary list deploymentDrafts
         *
         * @param request ListDeploymentDraftsRequest
         * @return ListDeploymentDraftsResponse
         */
        public async Task<ListDeploymentDraftsResponse> ListDeploymentDraftsAsync(string namespace_, ListDeploymentDraftsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentDraftsHeaders headers = new ListDeploymentDraftsHeaders();
            return await ListDeploymentDraftsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Obtains a list of clusters in which deployments can be deployed. The cluster can be a session cluster or a per-job cluster.
         *
         * @param request ListDeploymentTargetsRequest
         * @param headers ListDeploymentTargetsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentTargetsResponse
         */
        public ListDeploymentTargetsResponse ListDeploymentTargetsWithOptions(string namespace_, ListDeploymentTargetsRequest request, ListDeploymentTargetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentTargets",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentTargetsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of clusters in which deployments can be deployed. The cluster can be a session cluster or a per-job cluster.
         *
         * @param request ListDeploymentTargetsRequest
         * @param headers ListDeploymentTargetsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentTargetsResponse
         */
        public async Task<ListDeploymentTargetsResponse> ListDeploymentTargetsWithOptionsAsync(string namespace_, ListDeploymentTargetsRequest request, ListDeploymentTargetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentTargets",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of clusters in which deployments can be deployed. The cluster can be a session cluster or a per-job cluster.
         *
         * @param request ListDeploymentTargetsRequest
         * @return ListDeploymentTargetsResponse
         */
        public ListDeploymentTargetsResponse ListDeploymentTargets(string namespace_, ListDeploymentTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentTargetsHeaders headers = new ListDeploymentTargetsHeaders();
            return ListDeploymentTargetsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Obtains a list of clusters in which deployments can be deployed. The cluster can be a session cluster or a per-job cluster.
         *
         * @param request ListDeploymentTargetsRequest
         * @return ListDeploymentTargetsResponse
         */
        public async Task<ListDeploymentTargetsResponse> ListDeploymentTargetsAsync(string namespace_, ListDeploymentTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentTargetsHeaders headers = new ListDeploymentTargetsHeaders();
            return await ListDeploymentTargetsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Obtains information about all deployments.
         *
         * @param request ListDeploymentsRequest
         * @param headers ListDeploymentsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentsResponse
         */
        public ListDeploymentsResponse ListDeploymentsWithOptions(string namespace_, ListDeploymentsRequest request, ListDeploymentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                query["executionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKey))
            {
                query["labelKey"] = request.LabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelValueArray))
            {
                query["labelValueArray"] = request.LabelValueArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                query["modifier"] = request.Modifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeployments",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains information about all deployments.
         *
         * @param request ListDeploymentsRequest
         * @param headers ListDeploymentsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentsResponse
         */
        public async Task<ListDeploymentsResponse> ListDeploymentsWithOptionsAsync(string namespace_, ListDeploymentsRequest request, ListDeploymentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                query["executionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKey))
            {
                query["labelKey"] = request.LabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelValueArray))
            {
                query["labelValueArray"] = request.LabelValueArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                query["modifier"] = request.Modifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeployments",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains information about all deployments.
         *
         * @param request ListDeploymentsRequest
         * @return ListDeploymentsResponse
         */
        public ListDeploymentsResponse ListDeployments(string namespace_, ListDeploymentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentsHeaders headers = new ListDeploymentsHeaders();
            return ListDeploymentsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Obtains information about all deployments.
         *
         * @param request ListDeploymentsRequest
         * @return ListDeploymentsResponse
         */
        public async Task<ListDeploymentsResponse> ListDeploymentsAsync(string namespace_, ListDeploymentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentsHeaders headers = new ListDeploymentsHeaders();
            return await ListDeploymentsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary 列出有编辑权限的项目空间。
         *
         * @param request ListEditableNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEditableNamespaceResponse
         */
        public ListEditableNamespaceResponse ListEditableNamespaceWithOptions(ListEditableNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEditableNamespace",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/editable",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEditableNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列出有编辑权限的项目空间。
         *
         * @param request ListEditableNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEditableNamespaceResponse
         */
        public async Task<ListEditableNamespaceResponse> ListEditableNamespaceWithOptionsAsync(ListEditableNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEditableNamespace",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/editable",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEditableNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列出有编辑权限的项目空间。
         *
         * @param request ListEditableNamespaceRequest
         * @return ListEditableNamespaceResponse
         */
        public ListEditableNamespaceResponse ListEditableNamespace(ListEditableNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEditableNamespaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列出有编辑权限的项目空间。
         *
         * @param request ListEditableNamespaceRequest
         * @return ListEditableNamespaceResponse
         */
        public async Task<ListEditableNamespaceResponse> ListEditableNamespaceAsync(ListEditableNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEditableNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Obtains a list of engine versions that are supported by Realtime Compute for Apache Flink.
         *
         * @param headers ListEngineVersionMetadataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEngineVersionMetadataResponse
         */
        public ListEngineVersionMetadataResponse ListEngineVersionMetadataWithOptions(ListEngineVersionMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEngineVersionMetadata",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/engine-version-meta.json",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEngineVersionMetadataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of engine versions that are supported by Realtime Compute for Apache Flink.
         *
         * @param headers ListEngineVersionMetadataHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEngineVersionMetadataResponse
         */
        public async Task<ListEngineVersionMetadataResponse> ListEngineVersionMetadataWithOptionsAsync(ListEngineVersionMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEngineVersionMetadata",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/engine-version-meta.json",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEngineVersionMetadataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of engine versions that are supported by Realtime Compute for Apache Flink.
         *
         * @return ListEngineVersionMetadataResponse
         */
        public ListEngineVersionMetadataResponse ListEngineVersionMetadata()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEngineVersionMetadataHeaders headers = new ListEngineVersionMetadataHeaders();
            return ListEngineVersionMetadataWithOptions(headers, runtime);
        }

        /**
         * @summary Obtains a list of engine versions that are supported by Realtime Compute for Apache Flink.
         *
         * @return ListEngineVersionMetadataResponse
         */
        public async Task<ListEngineVersionMetadataResponse> ListEngineVersionMetadataAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEngineVersionMetadataHeaders headers = new ListEngineVersionMetadataHeaders();
            return await ListEngineVersionMetadataWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary Queries the information about all jobs in a deployment.
         *
         * @param request ListJobsRequest
         * @param headers ListJobsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobsResponse
         */
        public ListJobsResponse ListJobsWithOptions(string namespace_, ListJobsRequest request, ListJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortName))
            {
                query["sortName"] = request.SortName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about all jobs in a deployment.
         *
         * @param request ListJobsRequest
         * @param headers ListJobsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobsResponse
         */
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(string namespace_, ListJobsRequest request, ListJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortName))
            {
                query["sortName"] = request.SortName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about all jobs in a deployment.
         *
         * @param request ListJobsRequest
         * @return ListJobsResponse
         */
        public ListJobsResponse ListJobs(string namespace_, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJobsHeaders headers = new ListJobsHeaders();
            return ListJobsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Queries the information about all jobs in a deployment.
         *
         * @param request ListJobsRequest
         * @return ListJobsResponse
         */
        public async Task<ListJobsResponse> ListJobsAsync(string namespace_, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJobsHeaders headers = new ListJobsHeaders();
            return await ListJobsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Queries the mappings between the ID and permissions of a member in a specific namespace.
         *
         * @param request ListMembersRequest
         * @param headers ListMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMembersResponse
         */
        public ListMembersResponse ListMembersWithOptions(string namespace_, ListMembersRequest request, ListMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMembers",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMembersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the mappings between the ID and permissions of a member in a specific namespace.
         *
         * @param request ListMembersRequest
         * @param headers ListMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMembersResponse
         */
        public async Task<ListMembersResponse> ListMembersWithOptionsAsync(string namespace_, ListMembersRequest request, ListMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMembers",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the mappings between the ID and permissions of a member in a specific namespace.
         *
         * @param request ListMembersRequest
         * @return ListMembersResponse
         */
        public ListMembersResponse ListMembers(string namespace_, ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMembersHeaders headers = new ListMembersHeaders();
            return ListMembersWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Queries the mappings between the ID and permissions of a member in a specific namespace.
         *
         * @param request ListMembersRequest
         * @return ListMembersResponse
         */
        public async Task<ListMembersResponse> ListMembersAsync(string namespace_, ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMembersHeaders headers = new ListMembersHeaders();
            return await ListMembersWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Obtains a list of savepoints or checkpoints.
         *
         * @param request ListSavepointsRequest
         * @param headers ListSavepointsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSavepointsResponse
         */
        public ListSavepointsResponse ListSavepointsWithOptions(string namespace_, ListSavepointsRequest request, ListSavepointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSavepoints",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSavepointsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of savepoints or checkpoints.
         *
         * @param request ListSavepointsRequest
         * @param headers ListSavepointsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSavepointsResponse
         */
        public async Task<ListSavepointsResponse> ListSavepointsWithOptionsAsync(string namespace_, ListSavepointsRequest request, ListSavepointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSavepoints",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSavepointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of savepoints or checkpoints.
         *
         * @param request ListSavepointsRequest
         * @return ListSavepointsResponse
         */
        public ListSavepointsResponse ListSavepoints(string namespace_, ListSavepointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSavepointsHeaders headers = new ListSavepointsHeaders();
            return ListSavepointsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Obtains a list of savepoints or checkpoints.
         *
         * @param request ListSavepointsRequest
         * @return ListSavepointsResponse
         */
        public async Task<ListSavepointsResponse> ListSavepointsAsync(string namespace_, ListSavepointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSavepointsHeaders headers = new ListSavepointsHeaders();
            return await ListSavepointsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Obtains a list of variables.
         *
         * @param request ListVariablesRequest
         * @param headers ListVariablesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVariablesResponse
         */
        public ListVariablesResponse ListVariablesWithOptions(string namespace_, ListVariablesRequest request, ListVariablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVariables",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVariablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of variables.
         *
         * @param request ListVariablesRequest
         * @param headers ListVariablesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVariablesResponse
         */
        public async Task<ListVariablesResponse> ListVariablesWithOptionsAsync(string namespace_, ListVariablesRequest request, ListVariablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVariables",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVariablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains a list of variables.
         *
         * @param request ListVariablesRequest
         * @return ListVariablesResponse
         */
        public ListVariablesResponse ListVariables(string namespace_, ListVariablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVariablesHeaders headers = new ListVariablesHeaders();
            return ListVariablesWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Obtains a list of variables.
         *
         * @param request ListVariablesRequest
         * @return ListVariablesResponse
         */
        public async Task<ListVariablesResponse> ListVariablesAsync(string namespace_, ListVariablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVariablesHeaders headers = new ListVariablesHeaders();
            return await ListVariablesWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Registers a custom connector in a namespace. The registered custom connector can be used in SQL statements.
         *
         * @param request RegisterCustomConnectorRequest
         * @param headers RegisterCustomConnectorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterCustomConnectorResponse
         */
        public RegisterCustomConnectorResponse RegisterCustomConnectorWithOptions(string namespace_, RegisterCustomConnectorRequest request, RegisterCustomConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarUrl))
            {
                query["jarUrl"] = request.JarUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterCustomConnector",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors%3Aregister",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCustomConnectorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Registers a custom connector in a namespace. The registered custom connector can be used in SQL statements.
         *
         * @param request RegisterCustomConnectorRequest
         * @param headers RegisterCustomConnectorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterCustomConnectorResponse
         */
        public async Task<RegisterCustomConnectorResponse> RegisterCustomConnectorWithOptionsAsync(string namespace_, RegisterCustomConnectorRequest request, RegisterCustomConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarUrl))
            {
                query["jarUrl"] = request.JarUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterCustomConnector",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors%3Aregister",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCustomConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Registers a custom connector in a namespace. The registered custom connector can be used in SQL statements.
         *
         * @param request RegisterCustomConnectorRequest
         * @return RegisterCustomConnectorResponse
         */
        public RegisterCustomConnectorResponse RegisterCustomConnector(string namespace_, RegisterCustomConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCustomConnectorHeaders headers = new RegisterCustomConnectorHeaders();
            return RegisterCustomConnectorWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Registers a custom connector in a namespace. The registered custom connector can be used in SQL statements.
         *
         * @param request RegisterCustomConnectorRequest
         * @return RegisterCustomConnectorResponse
         */
        public async Task<RegisterCustomConnectorResponse> RegisterCustomConnectorAsync(string namespace_, RegisterCustomConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCustomConnectorHeaders headers = new RegisterCustomConnectorHeaders();
            return await RegisterCustomConnectorWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Registers specific or all of the user-defined functions (UDFs) that are parsed from the JAR files. The registered functions can be used in SQL statements.
         *
         * @param request RegisterUdfFunctionRequest
         * @param headers RegisterUdfFunctionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterUdfFunctionResponse
         */
        public RegisterUdfFunctionResponse RegisterUdfFunctionWithOptions(string namespace_, RegisterUdfFunctionRequest request, RegisterUdfFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                query["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["functionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterUdfFunction",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/function%3AregisterUdfFunction",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterUdfFunctionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Registers specific or all of the user-defined functions (UDFs) that are parsed from the JAR files. The registered functions can be used in SQL statements.
         *
         * @param request RegisterUdfFunctionRequest
         * @param headers RegisterUdfFunctionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterUdfFunctionResponse
         */
        public async Task<RegisterUdfFunctionResponse> RegisterUdfFunctionWithOptionsAsync(string namespace_, RegisterUdfFunctionRequest request, RegisterUdfFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                query["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["functionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterUdfFunction",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/function%3AregisterUdfFunction",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterUdfFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Registers specific or all of the user-defined functions (UDFs) that are parsed from the JAR files. The registered functions can be used in SQL statements.
         *
         * @param request RegisterUdfFunctionRequest
         * @return RegisterUdfFunctionResponse
         */
        public RegisterUdfFunctionResponse RegisterUdfFunction(string namespace_, RegisterUdfFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterUdfFunctionHeaders headers = new RegisterUdfFunctionHeaders();
            return RegisterUdfFunctionWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Registers specific or all of the user-defined functions (UDFs) that are parsed from the JAR files. The registered functions can be used in SQL statements.
         *
         * @param request RegisterUdfFunctionRequest
         * @return RegisterUdfFunctionResponse
         */
        public async Task<RegisterUdfFunctionResponse> RegisterUdfFunctionAsync(string namespace_, RegisterUdfFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterUdfFunctionHeaders headers = new RegisterUdfFunctionHeaders();
            return await RegisterUdfFunctionWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI StartJob is deprecated
         *
         * @summary Creates and starts a job.
         *
         * @param request StartJobRequest
         * @param headers StartJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartJobResponse
         */
        // Deprecated
        public StartJobResponse StartJobWithOptions(string namespace_, StartJobRequest request, StartJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI StartJob is deprecated
         *
         * @summary Creates and starts a job.
         *
         * @param request StartJobRequest
         * @param headers StartJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartJobResponse
         */
        // Deprecated
        public async Task<StartJobResponse> StartJobWithOptionsAsync(string namespace_, StartJobRequest request, StartJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI StartJob is deprecated
         *
         * @summary Creates and starts a job.
         *
         * @param request StartJobRequest
         * @return StartJobResponse
         */
        // Deprecated
        public StartJobResponse StartJob(string namespace_, StartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobHeaders headers = new StartJobHeaders();
            return StartJobWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI StartJob is deprecated
         *
         * @summary Creates and starts a job.
         *
         * @param request StartJobRequest
         * @return StartJobResponse
         */
        // Deprecated
        public async Task<StartJobResponse> StartJobAsync(string namespace_, StartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobHeaders headers = new StartJobHeaders();
            return await StartJobWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Starts a job.
         *
         * @param request StartJobWithParamsRequest
         * @param headers StartJobWithParamsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartJobWithParamsResponse
         */
        public StartJobWithParamsResponse StartJobWithParamsWithOptions(string namespace_, StartJobWithParamsRequest request, StartJobWithParamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJobWithParams",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs%3Astart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobWithParamsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Starts a job.
         *
         * @param request StartJobWithParamsRequest
         * @param headers StartJobWithParamsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartJobWithParamsResponse
         */
        public async Task<StartJobWithParamsResponse> StartJobWithParamsWithOptionsAsync(string namespace_, StartJobWithParamsRequest request, StartJobWithParamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJobWithParams",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs%3Astart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobWithParamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Starts a job.
         *
         * @param request StartJobWithParamsRequest
         * @return StartJobWithParamsResponse
         */
        public StartJobWithParamsResponse StartJobWithParams(string namespace_, StartJobWithParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobWithParamsHeaders headers = new StartJobWithParamsHeaders();
            return StartJobWithParamsWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Starts a job.
         *
         * @param request StartJobWithParamsRequest
         * @return StartJobWithParamsResponse
         */
        public async Task<StartJobWithParamsResponse> StartJobWithParamsAsync(string namespace_, StartJobWithParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobWithParamsHeaders headers = new StartJobWithParamsHeaders();
            return await StartJobWithParamsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Stops a job.
         *
         * @param request StopJobRequest
         * @param headers StopJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopJobResponse
         */
        public StopJobResponse StopJobWithOptions(string namespace_, string jobId, StopJobRequest request, StopJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "%3Astop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Stops a job.
         *
         * @param request StopJobRequest
         * @param headers StopJobHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopJobResponse
         */
        public async Task<StopJobResponse> StopJobWithOptionsAsync(string namespace_, string jobId, StopJobRequest request, StopJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "%3Astop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Stops a job.
         *
         * @param request StopJobRequest
         * @return StopJobResponse
         */
        public StopJobResponse StopJob(string namespace_, string jobId, StopJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopJobHeaders headers = new StopJobHeaders();
            return StopJobWithOptions(namespace_, jobId, request, headers, runtime);
        }

        /**
         * @summary Stops a job.
         *
         * @param request StopJobRequest
         * @return StopJobResponse
         */
        public async Task<StopJobResponse> StopJobAsync(string namespace_, string jobId, StopJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopJobHeaders headers = new StopJobHeaders();
            return await StopJobWithOptionsAsync(namespace_, jobId, request, headers, runtime);
        }

        /**
         * @summary Updates information about a deployment.
         *
         * @param request UpdateDeploymentRequest
         * @param headers UpdateDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeploymentResponse
         */
        public UpdateDeploymentResponse UpdateDeploymentWithOptions(string namespace_, string deploymentId, UpdateDeploymentRequest request, UpdateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates information about a deployment.
         *
         * @param request UpdateDeploymentRequest
         * @param headers UpdateDeploymentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeploymentResponse
         */
        public async Task<UpdateDeploymentResponse> UpdateDeploymentWithOptionsAsync(string namespace_, string deploymentId, UpdateDeploymentRequest request, UpdateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates information about a deployment.
         *
         * @param request UpdateDeploymentRequest
         * @return UpdateDeploymentResponse
         */
        public UpdateDeploymentResponse UpdateDeployment(string namespace_, string deploymentId, UpdateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentHeaders headers = new UpdateDeploymentHeaders();
            return UpdateDeploymentWithOptions(namespace_, deploymentId, request, headers, runtime);
        }

        /**
         * @summary Updates information about a deployment.
         *
         * @param request UpdateDeploymentRequest
         * @return UpdateDeploymentResponse
         */
        public async Task<UpdateDeploymentResponse> UpdateDeploymentAsync(string namespace_, string deploymentId, UpdateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentHeaders headers = new UpdateDeploymentHeaders();
            return await UpdateDeploymentWithOptionsAsync(namespace_, deploymentId, request, headers, runtime);
        }

        /**
         * @summary update a deploymentDraft
         *
         * @param request UpdateDeploymentDraftRequest
         * @param headers UpdateDeploymentDraftHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeploymentDraftResponse
         */
        public UpdateDeploymentDraftResponse UpdateDeploymentDraftWithOptions(string namespace_, string deploymentDraftId, UpdateDeploymentDraftRequest request, UpdateDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentDraftResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary update a deploymentDraft
         *
         * @param request UpdateDeploymentDraftRequest
         * @param headers UpdateDeploymentDraftHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeploymentDraftResponse
         */
        public async Task<UpdateDeploymentDraftResponse> UpdateDeploymentDraftWithOptionsAsync(string namespace_, string deploymentDraftId, UpdateDeploymentDraftRequest request, UpdateDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary update a deploymentDraft
         *
         * @param request UpdateDeploymentDraftRequest
         * @return UpdateDeploymentDraftResponse
         */
        public UpdateDeploymentDraftResponse UpdateDeploymentDraft(string namespace_, string deploymentDraftId, UpdateDeploymentDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentDraftHeaders headers = new UpdateDeploymentDraftHeaders();
            return UpdateDeploymentDraftWithOptions(namespace_, deploymentDraftId, request, headers, runtime);
        }

        /**
         * @summary update a deploymentDraft
         *
         * @param request UpdateDeploymentDraftRequest
         * @return UpdateDeploymentDraftResponse
         */
        public async Task<UpdateDeploymentDraftResponse> UpdateDeploymentDraftAsync(string namespace_, string deploymentDraftId, UpdateDeploymentDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentDraftHeaders headers = new UpdateDeploymentDraftHeaders();
            return await UpdateDeploymentDraftWithOptionsAsync(namespace_, deploymentDraftId, request, headers, runtime);
        }

        /**
         * @summary update a folder
         *
         * @param request UpdateFolderRequest
         * @param headers UpdateFolderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFolderResponse
         */
        public UpdateFolderResponse UpdateFolderWithOptions(string namespace_, string folderId, UpdateFolderRequest request, UpdateFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary update a folder
         *
         * @param request UpdateFolderRequest
         * @param headers UpdateFolderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFolderResponse
         */
        public async Task<UpdateFolderResponse> UpdateFolderWithOptionsAsync(string namespace_, string folderId, UpdateFolderRequest request, UpdateFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary update a folder
         *
         * @param request UpdateFolderRequest
         * @return UpdateFolderResponse
         */
        public UpdateFolderResponse UpdateFolder(string namespace_, string folderId, UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFolderHeaders headers = new UpdateFolderHeaders();
            return UpdateFolderWithOptions(namespace_, folderId, request, headers, runtime);
        }

        /**
         * @summary update a folder
         *
         * @param request UpdateFolderRequest
         * @return UpdateFolderResponse
         */
        public async Task<UpdateFolderResponse> UpdateFolderAsync(string namespace_, string folderId, UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFolderHeaders headers = new UpdateFolderHeaders();
            return await UpdateFolderWithOptionsAsync(namespace_, folderId, request, headers, runtime);
        }

        /**
         * @summary Updates the permissions of one or more members in a specific namespace.
         *
         * @param request UpdateMemberRequest
         * @param headers UpdateMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemberResponse
         */
        public UpdateMemberResponse UpdateMemberWithOptions(string namespace_, UpdateMemberRequest request, UpdateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemberResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the permissions of one or more members in a specific namespace.
         *
         * @param request UpdateMemberRequest
         * @param headers UpdateMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemberResponse
         */
        public async Task<UpdateMemberResponse> UpdateMemberWithOptionsAsync(string namespace_, UpdateMemberRequest request, UpdateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the permissions of one or more members in a specific namespace.
         *
         * @param request UpdateMemberRequest
         * @return UpdateMemberResponse
         */
        public UpdateMemberResponse UpdateMember(string namespace_, UpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberHeaders headers = new UpdateMemberHeaders();
            return UpdateMemberWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Updates the permissions of one or more members in a specific namespace.
         *
         * @param request UpdateMemberRequest
         * @return UpdateMemberResponse
         */
        public async Task<UpdateMemberResponse> UpdateMemberAsync(string namespace_, UpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberHeaders headers = new UpdateMemberHeaders();
            return await UpdateMemberWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /**
         * @summary Updates the JAR file of the user-defined function (UDF) that you create.
         *
         * @param request UpdateUdfArtifactRequest
         * @param headers UpdateUdfArtifactHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUdfArtifactResponse
         */
        public UpdateUdfArtifactResponse UpdateUdfArtifactWithOptions(string namespace_, string udfArtifactName, UpdateUdfArtifactRequest request, UpdateUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(udfArtifactName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUdfArtifactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the JAR file of the user-defined function (UDF) that you create.
         *
         * @param request UpdateUdfArtifactRequest
         * @param headers UpdateUdfArtifactHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUdfArtifactResponse
         */
        public async Task<UpdateUdfArtifactResponse> UpdateUdfArtifactWithOptionsAsync(string namespace_, string udfArtifactName, UpdateUdfArtifactRequest request, UpdateUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(udfArtifactName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUdfArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the JAR file of the user-defined function (UDF) that you create.
         *
         * @param request UpdateUdfArtifactRequest
         * @return UpdateUdfArtifactResponse
         */
        public UpdateUdfArtifactResponse UpdateUdfArtifact(string namespace_, string udfArtifactName, UpdateUdfArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUdfArtifactHeaders headers = new UpdateUdfArtifactHeaders();
            return UpdateUdfArtifactWithOptions(namespace_, udfArtifactName, request, headers, runtime);
        }

        /**
         * @summary Updates the JAR file of the user-defined function (UDF) that you create.
         *
         * @param request UpdateUdfArtifactRequest
         * @return UpdateUdfArtifactResponse
         */
        public async Task<UpdateUdfArtifactResponse> UpdateUdfArtifactAsync(string namespace_, string udfArtifactName, UpdateUdfArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUdfArtifactHeaders headers = new UpdateUdfArtifactHeaders();
            return await UpdateUdfArtifactWithOptionsAsync(namespace_, udfArtifactName, request, headers, runtime);
        }

        /**
         * @summary Verifies the code of an SQL deployment.
         *
         * @param request ValidateSqlStatementRequest
         * @param headers ValidateSqlStatementHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ValidateSqlStatementResponse
         */
        public ValidateSqlStatementResponse ValidateSqlStatementWithOptions(string namespace_, ValidateSqlStatementRequest request, ValidateSqlStatementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateSqlStatement",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-statement/validate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateSqlStatementResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Verifies the code of an SQL deployment.
         *
         * @param request ValidateSqlStatementRequest
         * @param headers ValidateSqlStatementHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ValidateSqlStatementResponse
         */
        public async Task<ValidateSqlStatementResponse> ValidateSqlStatementWithOptionsAsync(string namespace_, ValidateSqlStatementRequest request, ValidateSqlStatementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateSqlStatement",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-statement/validate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateSqlStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Verifies the code of an SQL deployment.
         *
         * @param request ValidateSqlStatementRequest
         * @return ValidateSqlStatementResponse
         */
        public ValidateSqlStatementResponse ValidateSqlStatement(string namespace_, ValidateSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateSqlStatementHeaders headers = new ValidateSqlStatementHeaders();
            return ValidateSqlStatementWithOptions(namespace_, request, headers, runtime);
        }

        /**
         * @summary Verifies the code of an SQL deployment.
         *
         * @param request ValidateSqlStatementRequest
         * @return ValidateSqlStatementResponse
         */
        public async Task<ValidateSqlStatementResponse> ValidateSqlStatementAsync(string namespace_, ValidateSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateSqlStatementHeaders headers = new ValidateSqlStatementHeaders();
            return await ValidateSqlStatementWithOptionsAsync(namespace_, request, headers, runtime);
        }

    }
}
