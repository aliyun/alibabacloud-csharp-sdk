// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.IntelligentCreation20240118.Models;

namespace AlibabaCloud.SDK.IntelligentCreation20240118
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("intelligentcreation", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActualDeductResourceResponse ActualDeductResourceWithOptions(ActualDeductResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActualDeductResource",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/v1/digital-human/commands/actual-deduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActualDeductResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ActualDeductResourceResponse> ActualDeductResourceWithOptionsAsync(ActualDeductResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActualDeductResource",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/v1/digital-human/commands/actual-deduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActualDeductResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ActualDeductResourceResponse ActualDeductResource(ActualDeductResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ActualDeductResourceWithOptions(request, headers, runtime);
        }

        public async Task<ActualDeductResourceResponse> ActualDeductResourceAsync(ActualDeductResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ActualDeductResourceWithOptionsAsync(request, headers, runtime);
        }

        public ActualDeductResourcesResponse ActualDeductResourcesWithOptions(ActualDeductResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActualDeductResources",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/actualDeductResources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActualDeductResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ActualDeductResourcesResponse> ActualDeductResourcesWithOptionsAsync(ActualDeductResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActualDeductResources",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/actualDeductResources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActualDeductResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ActualDeductResourcesResponse ActualDeductResources(ActualDeductResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ActualDeductResourcesWithOptions(request, headers, runtime);
        }

        public async Task<ActualDeductResourcesResponse> ActualDeductResourcesAsync(ActualDeductResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ActualDeductResourcesWithOptionsAsync(request, headers, runtime);
        }

        public DirectDeductResourceResponse DirectDeductResourceWithOptions(DirectDeductResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DirectDeductResource",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/v1/digital-human/commands/direct-deduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DirectDeductResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DirectDeductResourceResponse> DirectDeductResourceWithOptionsAsync(DirectDeductResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DirectDeductResource",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/v1/digital-human/commands/direct-deduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DirectDeductResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DirectDeductResourceResponse DirectDeductResource(DirectDeductResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DirectDeductResourceWithOptions(request, headers, runtime);
        }

        public async Task<DirectDeductResourceResponse> DirectDeductResourceAsync(DirectDeductResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DirectDeductResourceWithOptionsAsync(request, headers, runtime);
        }

        public DirectDeductResourcesResponse DirectDeductResourcesWithOptions(DirectDeductResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DirectDeductResources",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/directDeductResources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DirectDeductResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DirectDeductResourcesResponse> DirectDeductResourcesWithOptionsAsync(DirectDeductResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DirectDeductResources",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/directDeductResources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DirectDeductResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DirectDeductResourcesResponse DirectDeductResources(DirectDeductResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DirectDeductResourcesWithOptions(request, headers, runtime);
        }

        public async Task<DirectDeductResourcesResponse> DirectDeductResourcesAsync(DirectDeductResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DirectDeductResourcesWithOptionsAsync(request, headers, runtime);
        }

        public ExpectDeductResourceResponse ExpectDeductResourceWithOptions(ExpectDeductResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExpectDeductResource",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/v1/digital-human/commands/expect-deduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpectDeductResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExpectDeductResourceResponse> ExpectDeductResourceWithOptionsAsync(ExpectDeductResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExpectDeductResource",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/v1/digital-human/commands/expect-deduct",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpectDeductResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExpectDeductResourceResponse ExpectDeductResource(ExpectDeductResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExpectDeductResourceWithOptions(request, headers, runtime);
        }

        public async Task<ExpectDeductResourceResponse> ExpectDeductResourceAsync(ExpectDeductResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExpectDeductResourceWithOptionsAsync(request, headers, runtime);
        }

        public ExpectDeductResourcesResponse ExpectDeductResourcesWithOptions(ExpectDeductResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExpectDeductResources",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/expectDeductResources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpectDeductResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExpectDeductResourcesResponse> ExpectDeductResourcesWithOptionsAsync(ExpectDeductResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExpectDeductResources",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/expectDeductResources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExpectDeductResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExpectDeductResourcesResponse ExpectDeductResources(ExpectDeductResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExpectDeductResourcesWithOptions(request, headers, runtime);
        }

        public async Task<ExpectDeductResourcesResponse> ExpectDeductResourcesAsync(ExpectDeductResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExpectDeductResourcesWithOptionsAsync(request, headers, runtime);
        }

        public GetRemainResourceResponse GetRemainResourceWithOptions(GetRemainResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubAccountId))
            {
                query["subAccountId"] = request.SubAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRemainResource",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/getRemainResource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRemainResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRemainResourceResponse> GetRemainResourceWithOptionsAsync(GetRemainResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubAccountId))
            {
                query["subAccountId"] = request.SubAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRemainResource",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/getRemainResource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRemainResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRemainResourceResponse GetRemainResource(GetRemainResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRemainResourceWithOptions(request, headers, runtime);
        }

        public async Task<GetRemainResourceResponse> GetRemainResourceAsync(GetRemainResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRemainResourceWithOptionsAsync(request, headers, runtime);
        }

    }
}
