// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AgentRetailVision20260506.Models;

namespace AlibabaCloud.SDK.AgentRetailVision20260506
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("agentretailvision", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商品导入</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ImportProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportProductsResponse
        /// </returns>
        public ImportProductsResponse ImportProductsWithOptions(ImportProductsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportProductsShrinkRequest request = new ImportProductsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtraImages))
            {
                request.ExtraImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtraImages, "ExtraImages", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MainImage))
            {
                request.MainImageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MainImage, "MainImage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MultiViewImages))
            {
                request.MultiViewImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MultiViewImages, "MultiViewImages", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraImagesShrink))
            {
                query["ExtraImages"] = request.ExtraImagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTitle))
            {
                query["ImageTitle"] = request.ImageTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemUniqueId))
            {
                query["ItemUniqueId"] = request.ItemUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainImageShrink))
            {
                query["MainImage"] = request.MainImageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiViewImagesShrink))
            {
                query["MultiViewImages"] = request.MultiViewImagesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportProducts",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportProductsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商品导入</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ImportProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportProductsResponse
        /// </returns>
        public async Task<ImportProductsResponse> ImportProductsWithOptionsAsync(ImportProductsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportProductsShrinkRequest request = new ImportProductsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtraImages))
            {
                request.ExtraImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtraImages, "ExtraImages", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MainImage))
            {
                request.MainImageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MainImage, "MainImage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MultiViewImages))
            {
                request.MultiViewImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MultiViewImages, "MultiViewImages", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraImagesShrink))
            {
                query["ExtraImages"] = request.ExtraImagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTitle))
            {
                query["ImageTitle"] = request.ImageTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemUniqueId))
            {
                query["ItemUniqueId"] = request.ItemUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainImageShrink))
            {
                query["MainImage"] = request.MainImageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiViewImagesShrink))
            {
                query["MultiViewImages"] = request.MultiViewImagesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportProducts",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商品导入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportProductsResponse
        /// </returns>
        public ImportProductsResponse ImportProducts(ImportProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportProductsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商品导入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportProductsResponse
        /// </returns>
        public async Task<ImportProductsResponse> ImportProductsAsync(ImportProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportProductsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecognitionResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRecognitionResultResponse
        /// </returns>
        public QueryRecognitionResultResponse QueryRecognitionResultWithOptions(QueryRecognitionResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderUniqueId))
            {
                query["OrderUniqueId"] = request.OrderUniqueId;
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
                Action = "QueryRecognitionResult",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecognitionResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecognitionResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRecognitionResultResponse
        /// </returns>
        public async Task<QueryRecognitionResultResponse> QueryRecognitionResultWithOptionsAsync(QueryRecognitionResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderUniqueId))
            {
                query["OrderUniqueId"] = request.OrderUniqueId;
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
                Action = "QueryRecognitionResult",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecognitionResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecognitionResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRecognitionResultResponse
        /// </returns>
        public QueryRecognitionResultResponse QueryRecognitionResult(QueryRecognitionResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecognitionResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecognitionResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRecognitionResultResponse
        /// </returns>
        public async Task<QueryRecognitionResultResponse> QueryRecognitionResultAsync(QueryRecognitionResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecognitionResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购物识别</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RecognizeOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeOrderResponse
        /// </returns>
        public RecognizeOrderResponse RecognizeOrderWithOptions(RecognizeOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeOrderShrinkRequest request = new RecognizeOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CandidateItems))
            {
                request.CandidateItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CandidateItems, "CandidateItems", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoUrls))
            {
                request.VideoUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoUrls, "VideoUrls", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CandidateItemsShrink))
            {
                query["CandidateItems"] = request.CandidateItemsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderUniqueId))
            {
                query["OrderUniqueId"] = request.OrderUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrlsShrink))
            {
                query["VideoUrls"] = request.VideoUrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeOrder",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购物识别</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RecognizeOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeOrderResponse
        /// </returns>
        public async Task<RecognizeOrderResponse> RecognizeOrderWithOptionsAsync(RecognizeOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeOrderShrinkRequest request = new RecognizeOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CandidateItems))
            {
                request.CandidateItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CandidateItems, "CandidateItems", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoUrls))
            {
                request.VideoUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoUrls, "VideoUrls", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CandidateItemsShrink))
            {
                query["CandidateItems"] = request.CandidateItemsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderUniqueId))
            {
                query["OrderUniqueId"] = request.OrderUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrlsShrink))
            {
                query["VideoUrls"] = request.VideoUrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeOrder",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购物识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeOrderResponse
        /// </returns>
        public RecognizeOrderResponse RecognizeOrder(RecognizeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购物识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeOrderResponse
        /// </returns>
        public async Task<RecognizeOrderResponse> RecognizeOrderAsync(RecognizeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Webhook注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterWebhookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterWebhookResponse
        /// </returns>
        public RegisterWebhookResponse RegisterWebhookWithOptions(RegisterWebhookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackSecret))
            {
                query["CallbackSecret"] = request.CallbackSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterWebhook",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterWebhookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Webhook注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterWebhookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterWebhookResponse
        /// </returns>
        public async Task<RegisterWebhookResponse> RegisterWebhookWithOptionsAsync(RegisterWebhookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackSecret))
            {
                query["CallbackSecret"] = request.CallbackSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterWebhook",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Webhook注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterWebhookRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterWebhookResponse
        /// </returns>
        public RegisterWebhookResponse RegisterWebhook(RegisterWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterWebhookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Webhook注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterWebhookRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterWebhookResponse
        /// </returns>
        public async Task<RegisterWebhookResponse> RegisterWebhookAsync(RegisterWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterWebhookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商品更新</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProductResponse
        /// </returns>
        public UpdateProductResponse UpdateProductWithOptions(UpdateProductRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateProductShrinkRequest request = new UpdateProductShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtraImages))
            {
                request.ExtraImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtraImages, "ExtraImages", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MainImage))
            {
                request.MainImageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MainImage, "MainImage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MultiViewImages))
            {
                request.MultiViewImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MultiViewImages, "MultiViewImages", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraImagesShrink))
            {
                query["ExtraImages"] = request.ExtraImagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTitle))
            {
                query["ImageTitle"] = request.ImageTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemUniqueId))
            {
                query["ItemUniqueId"] = request.ItemUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainImageShrink))
            {
                query["MainImage"] = request.MainImageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiViewImagesShrink))
            {
                query["MultiViewImages"] = request.MultiViewImagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformItemId))
            {
                query["PlatformItemId"] = request.PlatformItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProduct",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商品更新</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProductResponse
        /// </returns>
        public async Task<UpdateProductResponse> UpdateProductWithOptionsAsync(UpdateProductRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateProductShrinkRequest request = new UpdateProductShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtraImages))
            {
                request.ExtraImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtraImages, "ExtraImages", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MainImage))
            {
                request.MainImageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MainImage, "MainImage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MultiViewImages))
            {
                request.MultiViewImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MultiViewImages, "MultiViewImages", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraImagesShrink))
            {
                query["ExtraImages"] = request.ExtraImagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTitle))
            {
                query["ImageTitle"] = request.ImageTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemUniqueId))
            {
                query["ItemUniqueId"] = request.ItemUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainImageShrink))
            {
                query["MainImage"] = request.MainImageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiViewImagesShrink))
            {
                query["MultiViewImages"] = request.MultiViewImagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformItemId))
            {
                query["PlatformItemId"] = request.PlatformItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProduct",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商品更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProductRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProductResponse
        /// </returns>
        public UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProductWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>商品更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProductRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProductResponse
        /// </returns>
        public async Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProductWithOptionsAsync(request, runtime);
        }

    }
}
