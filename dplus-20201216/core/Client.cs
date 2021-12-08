// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dplus20201216.Models;

namespace AlibabaCloud.SDK.Dplus20201216
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dplus", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateImageAmazonTaskResponse CreateImageAmazonTaskWithOptions(CreateImageAmazonTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateImageAmazonTaskShrinkRequest request = new CreateImageAmazonTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImgUrlList))
            {
                request.ImgUrlListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImgUrlList, "ImgUrlList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TextList))
            {
                request.TextListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TextList, "TextList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Gif"] = request.Gif;
            query["ImgUrlList"] = request.ImgUrlListShrink;
            query["TemplateMode"] = request.TemplateMode;
            query["TextList"] = request.TextListShrink;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageAmazonTask",
                Version = "2020-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageAmazonTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateImageAmazonTaskResponse> CreateImageAmazonTaskWithOptionsAsync(CreateImageAmazonTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateImageAmazonTaskShrinkRequest request = new CreateImageAmazonTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImgUrlList))
            {
                request.ImgUrlListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImgUrlList, "ImgUrlList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TextList))
            {
                request.TextListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TextList, "TextList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Gif"] = request.Gif;
            query["ImgUrlList"] = request.ImgUrlListShrink;
            query["TemplateMode"] = request.TemplateMode;
            query["TextList"] = request.TextListShrink;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageAmazonTask",
                Version = "2020-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageAmazonTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateImageAmazonTaskResponse CreateImageAmazonTask(CreateImageAmazonTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageAmazonTaskWithOptions(request, runtime);
        }

        public async Task<CreateImageAmazonTaskResponse> CreateImageAmazonTaskAsync(CreateImageAmazonTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageAmazonTaskWithOptionsAsync(request, runtime);
        }

        public GetTaskResultResponse GetTaskResultWithOptions(GetTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskResult",
                Version = "2020-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTaskResultResponse> GetTaskResultWithOptionsAsync(GetTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskResult",
                Version = "2020-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTaskResultResponse GetTaskResult(GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskResultWithOptions(request, runtime);
        }

        public async Task<GetTaskResultResponse> GetTaskResultAsync(GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskResultWithOptionsAsync(request, runtime);
        }

        public GetTaskStatusResponse GetTaskStatusWithOptions(GetTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatus",
                Version = "2020-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTaskStatusResponse> GetTaskStatusWithOptionsAsync(GetTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatus",
                Version = "2020-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTaskStatusResponse GetTaskStatus(GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskStatusWithOptions(request, runtime);
        }

        public async Task<GetTaskStatusResponse> GetTaskStatusAsync(GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskStatusWithOptionsAsync(request, runtime);
        }

    }
}
