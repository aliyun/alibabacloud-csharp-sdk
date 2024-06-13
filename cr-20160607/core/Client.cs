// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cr20160607.Models;

namespace AlibabaCloud.SDK.Cr20160607
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CancelRepoBuildResponse CancelRepoBuild(string RepoNamespace, string RepoName, string BuildId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelRepoBuildWithOptions(RepoNamespace, RepoName, BuildId, headers, runtime);
        }

        public async Task<CancelRepoBuildResponse> CancelRepoBuildAsync(string RepoNamespace, string RepoName, string BuildId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelRepoBuildWithOptionsAsync(RepoNamespace, RepoName, BuildId, headers, runtime);
        }

        public CancelRepoBuildResponse CancelRepoBuildWithOptions(string RepoNamespace, string RepoName, string BuildId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            BuildId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(BuildId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRepoBuild",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/build/" + BuildId + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRepoBuildResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelRepoBuildResponse> CancelRepoBuildWithOptionsAsync(string RepoNamespace, string RepoName, string BuildId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            BuildId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(BuildId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRepoBuild",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/build/" + BuildId + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRepoBuildResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateNamespaceResponse CreateNamespace()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateNamespaceWithOptions(headers, runtime);
        }

        public async Task<CreateNamespaceResponse> CreateNamespaceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateNamespaceWithOptionsAsync(headers, runtime);
        }

        public CreateNamespaceResponse CreateNamespaceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/namespace",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/namespace",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRepoResponse CreateRepo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRepoWithOptions(headers, runtime);
        }

        public async Task<CreateRepoResponse> CreateRepoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRepoWithOptionsAsync(headers, runtime);
        }

        public CreateRepoResponse CreateRepoWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRepoResponse> CreateRepoWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRepoBuildRuleResponse CreateRepoBuildRule(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRepoBuildRuleWithOptions(RepoNamespace, RepoName, headers, runtime);
        }

        public async Task<CreateRepoBuildRuleResponse> CreateRepoBuildRuleAsync(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRepoBuildRuleWithOptionsAsync(RepoNamespace, RepoName, headers, runtime);
        }

        public CreateRepoBuildRuleResponse CreateRepoBuildRuleWithOptions(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoBuildRule",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/rules",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoBuildRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRepoBuildRuleResponse> CreateRepoBuildRuleWithOptionsAsync(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoBuildRule",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/rules",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoBuildRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRepoWebhookResponse CreateRepoWebhook(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRepoWebhookWithOptions(RepoNamespace, RepoName, headers, runtime);
        }

        public async Task<CreateRepoWebhookResponse> CreateRepoWebhookAsync(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRepoWebhookWithOptionsAsync(RepoNamespace, RepoName, headers, runtime);
        }

        public CreateRepoWebhookResponse CreateRepoWebhookWithOptions(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoWebhook",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/webhooks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoWebhookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRepoWebhookResponse> CreateRepoWebhookWithOptionsAsync(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoWebhook",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/webhooks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateUserInfoResponse CreateUserInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUserInfoWithOptions(headers, runtime);
        }

        public async Task<CreateUserInfoResponse> CreateUserInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUserInfoWithOptionsAsync(headers, runtime);
        }

        public CreateUserInfoResponse CreateUserInfoWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserInfo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/users",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateUserInfoResponse> CreateUserInfoWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserInfo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/users",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteImageResponse DeleteImage(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteImageWithOptions(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public async Task<DeleteImageResponse> DeleteImageAsync(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteImageWithOptionsAsync(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public DeleteImageResponse DeleteImageWithOptions(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImage",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImage",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteNamespaceResponse DeleteNamespace(string Namespace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteNamespaceWithOptions(Namespace, headers, runtime);
        }

        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(string Namespace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteNamespaceWithOptionsAsync(Namespace, headers, runtime);
        }

        public DeleteNamespaceResponse DeleteNamespaceWithOptions(string Namespace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Namespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Namespace);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/namespace/" + Namespace,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteNamespaceResponse> DeleteNamespaceWithOptionsAsync(string Namespace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Namespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Namespace);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/namespace/" + Namespace,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRepoResponse DeleteRepo(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepoWithOptions(RepoNamespace, RepoName, headers, runtime);
        }

        public async Task<DeleteRepoResponse> DeleteRepoAsync(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepoWithOptionsAsync(RepoNamespace, RepoName, headers, runtime);
        }

        public DeleteRepoResponse DeleteRepoWithOptions(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRepoResponse> DeleteRepoWithOptionsAsync(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRepoBuildRuleResponse DeleteRepoBuildRule(string RepoNamespace, string RepoName, string BuildRuleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepoBuildRuleWithOptions(RepoNamespace, RepoName, BuildRuleId, headers, runtime);
        }

        public async Task<DeleteRepoBuildRuleResponse> DeleteRepoBuildRuleAsync(string RepoNamespace, string RepoName, string BuildRuleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepoBuildRuleWithOptionsAsync(RepoNamespace, RepoName, BuildRuleId, headers, runtime);
        }

        public DeleteRepoBuildRuleResponse DeleteRepoBuildRuleWithOptions(string RepoNamespace, string RepoName, string BuildRuleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            BuildRuleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(BuildRuleId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepoBuildRule",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/rules/" + BuildRuleId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoBuildRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRepoBuildRuleResponse> DeleteRepoBuildRuleWithOptionsAsync(string RepoNamespace, string RepoName, string BuildRuleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            BuildRuleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(BuildRuleId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepoBuildRule",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/rules/" + BuildRuleId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoBuildRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRepoWebhookResponse DeleteRepoWebhook(string RepoNamespace, string RepoName, string WebhookId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepoWebhookWithOptions(RepoNamespace, RepoName, WebhookId, headers, runtime);
        }

        public async Task<DeleteRepoWebhookResponse> DeleteRepoWebhookAsync(string RepoNamespace, string RepoName, string WebhookId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepoWebhookWithOptionsAsync(RepoNamespace, RepoName, WebhookId, headers, runtime);
        }

        public DeleteRepoWebhookResponse DeleteRepoWebhookWithOptions(string RepoNamespace, string RepoName, string WebhookId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            WebhookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WebhookId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepoWebhook",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/webhooks/" + WebhookId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoWebhookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRepoWebhookResponse> DeleteRepoWebhookWithOptionsAsync(string RepoNamespace, string RepoName, string WebhookId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            WebhookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WebhookId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepoWebhook",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/webhooks/" + WebhookId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAuthorizationTokenResponse GetAuthorizationToken()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAuthorizationTokenWithOptions(headers, runtime);
        }

        public async Task<GetAuthorizationTokenResponse> GetAuthorizationTokenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAuthorizationTokenWithOptionsAsync(headers, runtime);
        }

        public GetAuthorizationTokenResponse GetAuthorizationTokenWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthorizationToken",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/tokens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthorizationTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAuthorizationTokenResponse> GetAuthorizationTokenWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthorizationToken",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/tokens",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthorizationTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetImageLayerResponse GetImageLayer(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetImageLayerWithOptions(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public async Task<GetImageLayerResponse> GetImageLayerAsync(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetImageLayerWithOptionsAsync(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public GetImageLayerResponse GetImageLayerWithOptions(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageLayer",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/layers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageLayerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetImageLayerResponse> GetImageLayerWithOptionsAsync(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageLayer",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/layers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetImageManifestResponse GetImageManifest(string RepoNamespace, string RepoName, string Tag, GetImageManifestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetImageManifestWithOptions(RepoNamespace, RepoName, Tag, request, headers, runtime);
        }

        public async Task<GetImageManifestResponse> GetImageManifestAsync(string RepoNamespace, string RepoName, string Tag, GetImageManifestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetImageManifestWithOptionsAsync(RepoNamespace, RepoName, Tag, request, headers, runtime);
        }

        public GetImageManifestResponse GetImageManifestWithOptions(string RepoNamespace, string RepoName, string Tag, GetImageManifestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaVersion))
            {
                query["SchemaVersion"] = request.SchemaVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageManifest",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/manifest",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageManifestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetImageManifestResponse> GetImageManifestWithOptionsAsync(string RepoNamespace, string RepoName, string Tag, GetImageManifestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaVersion))
            {
                query["SchemaVersion"] = request.SchemaVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageManifest",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/manifest",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageManifestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetNamespaceResponse GetNamespace(string Namespace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetNamespaceWithOptions(Namespace, headers, runtime);
        }

        public async Task<GetNamespaceResponse> GetNamespaceAsync(string Namespace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetNamespaceWithOptionsAsync(Namespace, headers, runtime);
        }

        public GetNamespaceResponse GetNamespaceWithOptions(string Namespace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Namespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Namespace);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNamespace",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/namespace/" + Namespace,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNamespaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetNamespaceResponse> GetNamespaceWithOptionsAsync(string Namespace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Namespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Namespace);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNamespace",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/namespace/" + Namespace,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetNamespaceListResponse GetNamespaceList(GetNamespaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetNamespaceListWithOptions(request, headers, runtime);
        }

        public async Task<GetNamespaceListResponse> GetNamespaceListAsync(GetNamespaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetNamespaceListWithOptionsAsync(request, headers, runtime);
        }

        public GetNamespaceListResponse GetNamespaceListWithOptions(GetNamespaceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorize))
            {
                query["Authorize"] = request.Authorize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNamespaceList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/namespace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNamespaceListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetNamespaceListResponse> GetNamespaceListWithOptionsAsync(GetNamespaceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorize))
            {
                query["Authorize"] = request.Authorize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNamespaceList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/namespace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNamespaceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRegionResponse GetRegion(GetRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRegionWithOptions(request, headers, runtime);
        }

        public async Task<GetRegionResponse> GetRegionAsync(GetRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRegionWithOptionsAsync(request, headers, runtime);
        }

        public GetRegionResponse GetRegionWithOptions(GetRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegion",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRegionResponse> GetRegionWithOptionsAsync(GetRegionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegion",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRegionListResponse GetRegionList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRegionListWithOptions(headers, runtime);
        }

        public async Task<GetRegionListResponse> GetRegionListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRegionListWithOptionsAsync(headers, runtime);
        }

        public GetRegionListResponse GetRegionListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegionList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegionListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRegionListResponse> GetRegionListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegionList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoResponse GetRepo(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoWithOptions(RepoNamespace, RepoName, headers, runtime);
        }

        public async Task<GetRepoResponse> GetRepoAsync(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoWithOptionsAsync(RepoNamespace, RepoName, headers, runtime);
        }

        public GetRepoResponse GetRepoWithOptions(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoResponse> GetRepoWithOptionsAsync(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoBuildListResponse GetRepoBuildList(string RepoNamespace, string RepoName, GetRepoBuildListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoBuildListWithOptions(RepoNamespace, RepoName, request, headers, runtime);
        }

        public async Task<GetRepoBuildListResponse> GetRepoBuildListAsync(string RepoNamespace, string RepoName, GetRepoBuildListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoBuildListWithOptionsAsync(RepoNamespace, RepoName, request, headers, runtime);
        }

        public GetRepoBuildListResponse GetRepoBuildListWithOptions(string RepoNamespace, string RepoName, GetRepoBuildListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoBuildList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/build",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoBuildListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoBuildListResponse> GetRepoBuildListWithOptionsAsync(string RepoNamespace, string RepoName, GetRepoBuildListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoBuildList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/build",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoBuildListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoBuildRuleListResponse GetRepoBuildRuleList(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoBuildRuleListWithOptions(RepoNamespace, RepoName, headers, runtime);
        }

        public async Task<GetRepoBuildRuleListResponse> GetRepoBuildRuleListAsync(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoBuildRuleListWithOptionsAsync(RepoNamespace, RepoName, headers, runtime);
        }

        public GetRepoBuildRuleListResponse GetRepoBuildRuleListWithOptions(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoBuildRuleList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoBuildRuleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoBuildRuleListResponse> GetRepoBuildRuleListWithOptionsAsync(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoBuildRuleList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoBuildRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoBuildStatusResponse GetRepoBuildStatus(string RepoNamespace, string RepoName, string BuildId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoBuildStatusWithOptions(RepoNamespace, RepoName, BuildId, headers, runtime);
        }

        public async Task<GetRepoBuildStatusResponse> GetRepoBuildStatusAsync(string RepoNamespace, string RepoName, string BuildId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoBuildStatusWithOptionsAsync(RepoNamespace, RepoName, BuildId, headers, runtime);
        }

        public GetRepoBuildStatusResponse GetRepoBuildStatusWithOptions(string RepoNamespace, string RepoName, string BuildId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            BuildId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(BuildId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoBuildStatus",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/build/" + BuildId + "/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoBuildStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoBuildStatusResponse> GetRepoBuildStatusWithOptionsAsync(string RepoNamespace, string RepoName, string BuildId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            BuildId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(BuildId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoBuildStatus",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/build/" + BuildId + "/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoBuildStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoListResponse GetRepoList(GetRepoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoListWithOptions(request, headers, runtime);
        }

        public async Task<GetRepoListResponse> GetRepoListAsync(GetRepoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoListWithOptionsAsync(request, headers, runtime);
        }

        public GetRepoListResponse GetRepoListWithOptions(GetRepoListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoListResponse> GetRepoListWithOptionsAsync(GetRepoListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoListByNamespaceResponse GetRepoListByNamespace(string RepoNamespace, GetRepoListByNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoListByNamespaceWithOptions(RepoNamespace, request, headers, runtime);
        }

        public async Task<GetRepoListByNamespaceResponse> GetRepoListByNamespaceAsync(string RepoNamespace, GetRepoListByNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoListByNamespaceWithOptionsAsync(RepoNamespace, request, headers, runtime);
        }

        public GetRepoListByNamespaceResponse GetRepoListByNamespaceWithOptions(string RepoNamespace, GetRepoListByNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoListByNamespace",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoListByNamespaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoListByNamespaceResponse> GetRepoListByNamespaceWithOptionsAsync(string RepoNamespace, GetRepoListByNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoListByNamespace",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoListByNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoTagResponse GetRepoTag(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoTagWithOptions(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public async Task<GetRepoTagResponse> GetRepoTagAsync(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoTagWithOptionsAsync(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public GetRepoTagResponse GetRepoTagWithOptions(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTag",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoTagResponse> GetRepoTagWithOptionsAsync(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTag",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoTagScanListResponse GetRepoTagScanList(string RepoNamespace, string RepoName, string Tag, GetRepoTagScanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoTagScanListWithOptions(RepoNamespace, RepoName, Tag, request, headers, runtime);
        }

        public async Task<GetRepoTagScanListResponse> GetRepoTagScanListAsync(string RepoNamespace, string RepoName, string Tag, GetRepoTagScanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoTagScanListWithOptionsAsync(RepoNamespace, RepoName, Tag, request, headers, runtime);
        }

        public GetRepoTagScanListResponse GetRepoTagScanListWithOptions(string RepoNamespace, string RepoName, string Tag, GetRepoTagScanListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTagScanList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/scanResult",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagScanListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoTagScanListResponse> GetRepoTagScanListWithOptionsAsync(string RepoNamespace, string RepoName, string Tag, GetRepoTagScanListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTagScanList",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/scanResult",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagScanListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoTagScanStatusResponse GetRepoTagScanStatus(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoTagScanStatusWithOptions(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public async Task<GetRepoTagScanStatusResponse> GetRepoTagScanStatusAsync(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoTagScanStatusWithOptionsAsync(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public GetRepoTagScanStatusResponse GetRepoTagScanStatusWithOptions(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTagScanStatus",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/scanStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagScanStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoTagScanStatusResponse> GetRepoTagScanStatusWithOptionsAsync(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTagScanStatus",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/scanStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagScanStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoTagScanSummaryResponse GetRepoTagScanSummary(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoTagScanSummaryWithOptions(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public async Task<GetRepoTagScanSummaryResponse> GetRepoTagScanSummaryAsync(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoTagScanSummaryWithOptionsAsync(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public GetRepoTagScanSummaryResponse GetRepoTagScanSummaryWithOptions(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTagScanSummary",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/scanCount",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagScanSummaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoTagScanSummaryResponse> GetRepoTagScanSummaryWithOptionsAsync(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTagScanSummary",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/scanCount",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagScanSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoTagsResponse GetRepoTags(string RepoNamespace, string RepoName, GetRepoTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoTagsWithOptions(RepoNamespace, RepoName, request, headers, runtime);
        }

        public async Task<GetRepoTagsResponse> GetRepoTagsAsync(string RepoNamespace, string RepoName, GetRepoTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoTagsWithOptionsAsync(RepoNamespace, RepoName, request, headers, runtime);
        }

        public GetRepoTagsResponse GetRepoTagsWithOptions(string RepoNamespace, string RepoName, GetRepoTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTags",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoTagsResponse> GetRepoTagsWithOptionsAsync(string RepoNamespace, string RepoName, GetRepoTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTags",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepoWebhookResponse GetRepoWebhook(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepoWebhookWithOptions(RepoNamespace, RepoName, headers, runtime);
        }

        public async Task<GetRepoWebhookResponse> GetRepoWebhookAsync(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepoWebhookWithOptionsAsync(RepoNamespace, RepoName, headers, runtime);
        }

        public GetRepoWebhookResponse GetRepoWebhookWithOptions(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoWebhook",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/webhooks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoWebhookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepoWebhookResponse> GetRepoWebhookWithOptionsAsync(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoWebhook",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/webhooks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResourceQuotaResponse GetResourceQuota(string ResourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceQuotaWithOptions(ResourceName, headers, runtime);
        }

        public async Task<GetResourceQuotaResponse> GetResourceQuotaAsync(string ResourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceQuotaWithOptionsAsync(ResourceName, headers, runtime);
        }

        public GetResourceQuotaResponse GetResourceQuotaWithOptions(string ResourceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ResourceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceQuota",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/resource/" + ResourceName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceQuotaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResourceQuotaResponse> GetResourceQuotaWithOptionsAsync(string ResourceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ResourceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceQuota",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/resource/" + ResourceName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartImageScanResponse StartImageScan(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartImageScanWithOptions(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public async Task<StartImageScanResponse> StartImageScanAsync(string RepoNamespace, string RepoName, string Tag)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartImageScanWithOptionsAsync(RepoNamespace, RepoName, Tag, headers, runtime);
        }

        public StartImageScanResponse StartImageScanWithOptions(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartImageScan",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/scan",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartImageScanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartImageScanResponse> StartImageScanWithOptionsAsync(string RepoNamespace, string RepoName, string Tag, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            Tag = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Tag);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartImageScan",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/tags/" + Tag + "/scan",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartImageScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartRepoBuildByRuleResponse StartRepoBuildByRule(string RepoNamespace, string RepoName, string BuildRuleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartRepoBuildByRuleWithOptions(RepoNamespace, RepoName, BuildRuleId, headers, runtime);
        }

        public async Task<StartRepoBuildByRuleResponse> StartRepoBuildByRuleAsync(string RepoNamespace, string RepoName, string BuildRuleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartRepoBuildByRuleWithOptionsAsync(RepoNamespace, RepoName, BuildRuleId, headers, runtime);
        }

        public StartRepoBuildByRuleResponse StartRepoBuildByRuleWithOptions(string RepoNamespace, string RepoName, string BuildRuleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            BuildRuleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(BuildRuleId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRepoBuildByRule",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/rules/" + BuildRuleId + "/build",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRepoBuildByRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartRepoBuildByRuleResponse> StartRepoBuildByRuleWithOptionsAsync(string RepoNamespace, string RepoName, string BuildRuleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            BuildRuleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(BuildRuleId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRepoBuildByRule",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/rules/" + BuildRuleId + "/build",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRepoBuildByRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateNamespaceResponse UpdateNamespace(string Namespace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateNamespaceWithOptions(Namespace, headers, runtime);
        }

        public async Task<UpdateNamespaceResponse> UpdateNamespaceAsync(string Namespace)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateNamespaceWithOptionsAsync(Namespace, headers, runtime);
        }

        public UpdateNamespaceResponse UpdateNamespaceWithOptions(string Namespace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Namespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Namespace);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/namespace/" + Namespace,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateNamespaceResponse> UpdateNamespaceWithOptionsAsync(string Namespace, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Namespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Namespace);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/namespace/" + Namespace,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRepoResponse UpdateRepo(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRepoWithOptions(RepoNamespace, RepoName, headers, runtime);
        }

        public async Task<UpdateRepoResponse> UpdateRepoAsync(string RepoNamespace, string RepoName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRepoWithOptionsAsync(RepoNamespace, RepoName, headers, runtime);
        }

        public UpdateRepoResponse UpdateRepoWithOptions(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRepoResponse> UpdateRepoWithOptionsAsync(string RepoNamespace, string RepoName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRepoBuildRuleResponse UpdateRepoBuildRule(string RepoNamespace, string RepoName, string BuildRuleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRepoBuildRuleWithOptions(RepoNamespace, RepoName, BuildRuleId, headers, runtime);
        }

        public async Task<UpdateRepoBuildRuleResponse> UpdateRepoBuildRuleAsync(string RepoNamespace, string RepoName, string BuildRuleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRepoBuildRuleWithOptionsAsync(RepoNamespace, RepoName, BuildRuleId, headers, runtime);
        }

        public UpdateRepoBuildRuleResponse UpdateRepoBuildRuleWithOptions(string RepoNamespace, string RepoName, string BuildRuleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            BuildRuleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(BuildRuleId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepoBuildRule",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/rules/" + BuildRuleId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoBuildRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRepoBuildRuleResponse> UpdateRepoBuildRuleWithOptionsAsync(string RepoNamespace, string RepoName, string BuildRuleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            BuildRuleId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(BuildRuleId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepoBuildRule",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/rules/" + BuildRuleId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoBuildRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRepoWebhookResponse UpdateRepoWebhook(string RepoNamespace, string RepoName, string WebhookId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRepoWebhookWithOptions(RepoNamespace, RepoName, WebhookId, headers, runtime);
        }

        public async Task<UpdateRepoWebhookResponse> UpdateRepoWebhookAsync(string RepoNamespace, string RepoName, string WebhookId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRepoWebhookWithOptionsAsync(RepoNamespace, RepoName, WebhookId, headers, runtime);
        }

        public UpdateRepoWebhookResponse UpdateRepoWebhookWithOptions(string RepoNamespace, string RepoName, string WebhookId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            WebhookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WebhookId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepoWebhook",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/webhooks/" + WebhookId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoWebhookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRepoWebhookResponse> UpdateRepoWebhookWithOptionsAsync(string RepoNamespace, string RepoName, string WebhookId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            RepoNamespace = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoNamespace);
            RepoName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RepoName);
            WebhookId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WebhookId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepoWebhook",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/repos/" + RepoNamespace + "/" + RepoName + "/webhooks/" + WebhookId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateUserInfoResponse UpdateUserInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserInfoWithOptions(headers, runtime);
        }

        public async Task<UpdateUserInfoResponse> UpdateUserInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserInfoWithOptionsAsync(headers, runtime);
        }

        public UpdateUserInfoResponse UpdateUserInfoWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserInfo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateUserInfoResponse> UpdateUserInfoWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserInfo",
                Version = "2016-06-07",
                Protocol = "HTTPS",
                Pathname = "/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
