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

        public CopywritingQAResponse CopywritingQAWithOptions(CopywritingQARequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CopywritingQAShrinkRequest request = new CopywritingQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Histories))
            {
                request.HistoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Histories, "histories", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.History))
            {
                request.HistoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.History, "history", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoriesShrink))
            {
                query["histories"] = request.HistoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryShrink))
            {
                query["history"] = request.HistoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                query["question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                query["stream"] = request.Stream;
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
                Action = "CopywritingQA",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/copywritingQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopywritingQAResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CopywritingQAResponse> CopywritingQAWithOptionsAsync(CopywritingQARequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CopywritingQAShrinkRequest request = new CopywritingQAShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Histories))
            {
                request.HistoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Histories, "histories", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.History))
            {
                request.HistoryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.History, "history", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoriesShrink))
            {
                query["histories"] = request.HistoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HistoryShrink))
            {
                query["history"] = request.HistoryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                query["question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                query["stream"] = request.Stream;
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
                Action = "CopywritingQA",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/copywritingQA",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopywritingQAResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CopywritingQAResponse CopywritingQA(CopywritingQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CopywritingQAWithOptions(request, headers, runtime);
        }

        public async Task<CopywritingQAResponse> CopywritingQAAsync(CopywritingQARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CopywritingQAWithOptionsAsync(request, headers, runtime);
        }

        public CopywritingQAV1Response CopywritingQAV1WithOptions(CopywritingQAV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopywritingQAV1",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/copywritingQAV1",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopywritingQAV1Response>(CallApi(params_, req, runtime));
        }

        public async Task<CopywritingQAV1Response> CopywritingQAV1WithOptionsAsync(CopywritingQAV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopywritingQAV1",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/copywritingQAV1",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopywritingQAV1Response>(await CallApiAsync(params_, req, runtime));
        }

        public CopywritingQAV1Response CopywritingQAV1(CopywritingQAV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CopywritingQAV1WithOptions(request, headers, runtime);
        }

        public async Task<CopywritingQAV1Response> CopywritingQAV1Async(CopywritingQAV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CopywritingQAV1WithOptionsAsync(request, headers, runtime);
        }

        public DeleteDigitalVideoResponse DeleteDigitalVideoWithOptions(DeleteDigitalVideoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                body["videoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDigitalVideo",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/videos",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDigitalVideoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDigitalVideoResponse> DeleteDigitalVideoWithOptionsAsync(DeleteDigitalVideoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                body["videoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDigitalVideo",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/videos",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDigitalVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDigitalVideoResponse DeleteDigitalVideo(DeleteDigitalVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDigitalVideoWithOptions(request, headers, runtime);
        }

        public async Task<DeleteDigitalVideoResponse> DeleteDigitalVideoAsync(DeleteDigitalVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDigitalVideoWithOptionsAsync(request, headers, runtime);
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

        public SubmitBulletQuestionsResponse SubmitBulletQuestionsWithOptions(SubmitBulletQuestionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitBulletQuestionsShrinkRequest request = new SubmitBulletQuestionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Questions))
            {
                request.QuestionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Questions, "questions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionsShrink))
            {
                query["questions"] = request.QuestionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                query["roomId"] = request.RoomId;
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
                Action = "SubmitBulletQuestions",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/submitBulletQuestions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitBulletQuestionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitBulletQuestionsResponse> SubmitBulletQuestionsWithOptionsAsync(SubmitBulletQuestionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitBulletQuestionsShrinkRequest request = new SubmitBulletQuestionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Questions))
            {
                request.QuestionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Questions, "questions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionsShrink))
            {
                query["questions"] = request.QuestionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                query["roomId"] = request.RoomId;
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
                Action = "SubmitBulletQuestions",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/submitBulletQuestions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitBulletQuestionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitBulletQuestionsResponse SubmitBulletQuestions(SubmitBulletQuestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitBulletQuestionsWithOptions(request, headers, runtime);
        }

        public async Task<SubmitBulletQuestionsResponse> SubmitBulletQuestionsAsync(SubmitBulletQuestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitBulletQuestionsWithOptionsAsync(request, headers, runtime);
        }

        public SubmitBulletQuestionsV1Response SubmitBulletQuestionsV1WithOptions(SubmitBulletQuestionsV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitBulletQuestionsV1",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/submitBulletQuestionsV1",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitBulletQuestionsV1Response>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitBulletQuestionsV1Response> SubmitBulletQuestionsV1WithOptionsAsync(SubmitBulletQuestionsV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitBulletQuestionsV1",
                Version = "2024-01-18",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/commands/submitBulletQuestionsV1",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitBulletQuestionsV1Response>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitBulletQuestionsV1Response SubmitBulletQuestionsV1(SubmitBulletQuestionsV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitBulletQuestionsV1WithOptions(request, headers, runtime);
        }

        public async Task<SubmitBulletQuestionsV1Response> SubmitBulletQuestionsV1Async(SubmitBulletQuestionsV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitBulletQuestionsV1WithOptionsAsync(request, headers, runtime);
        }

    }
}
