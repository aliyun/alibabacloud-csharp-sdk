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
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "agentretailvision.cn-beijing.aliyuncs.com"},
            };
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
        /// <para>Generates a composite image for single-item multi-image or multi-item scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When <c>groupType=1</c>, <c>platformItemIdList</c> must contain only one element.</description></item>
        /// <item><description>When <c>groupType=2</c>, <c>platformItemIdList</c> can contain 1 to 10 elements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GenerateGroupImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateGroupImageResponse
        /// </returns>
        public GenerateGroupImageResponse GenerateGroupImageWithOptions(GenerateGroupImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateGroupImageShrinkRequest request = new GenerateGroupImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlatformItemIdList))
            {
                request.PlatformItemIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlatformItemIdList, "PlatformItemIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackSecret))
            {
                query["CallbackSecret"] = request.CallbackSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformItemIdListShrink))
            {
                query["PlatformItemIdList"] = request.PlatformItemIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateGroupImage",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateGroupImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a composite image for single-item multi-image or multi-item scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When <c>groupType=1</c>, <c>platformItemIdList</c> must contain only one element.</description></item>
        /// <item><description>When <c>groupType=2</c>, <c>platformItemIdList</c> can contain 1 to 10 elements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GenerateGroupImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateGroupImageResponse
        /// </returns>
        public async Task<GenerateGroupImageResponse> GenerateGroupImageWithOptionsAsync(GenerateGroupImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateGroupImageShrinkRequest request = new GenerateGroupImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlatformItemIdList))
            {
                request.PlatformItemIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlatformItemIdList, "PlatformItemIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackSecret))
            {
                query["CallbackSecret"] = request.CallbackSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                query["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformItemIdListShrink))
            {
                query["PlatformItemIdList"] = request.PlatformItemIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateGroupImage",
                Version = "2026-05-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateGroupImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a composite image for single-item multi-image or multi-item scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When <c>groupType=1</c>, <c>platformItemIdList</c> must contain only one element.</description></item>
        /// <item><description>When <c>groupType=2</c>, <c>platformItemIdList</c> can contain 1 to 10 elements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateGroupImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateGroupImageResponse
        /// </returns>
        public GenerateGroupImageResponse GenerateGroupImage(GenerateGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateGroupImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a composite image for single-item multi-image or multi-item scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When <c>groupType=1</c>, <c>platformItemIdList</c> must contain only one element.</description></item>
        /// <item><description>When <c>groupType=2</c>, <c>platformItemIdList</c> can contain 1 to 10 elements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateGroupImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateGroupImageResponse
        /// </returns>
        public async Task<GenerateGroupImageResponse> GenerateGroupImageAsync(GenerateGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateGroupImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds product information. After a successful import, the platform returns a globally unique platform_item_id for subsequent updates and recognition result association.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation is used to add product information.</description></item>
        /// <item><description>After you import products to the product library, they are stored in Alibaba Cloud OSS for direct recall and retrieval by the product recognition API.</description></item>
        /// <item><description>You must provide at least one main image URL, and the <c>item_unique_id</c> must be unique within the same business party.</description></item>
        /// <item><description>You can optionally provide multi-angle views and extra images to improve recognition accuracy.</description></item>
        /// <item><description>The <c>device_id</c> field can be used to establish an association between a device and product vectors, but it is not required.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Adds product information. After a successful import, the platform returns a globally unique platform_item_id for subsequent updates and recognition result association.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation is used to add product information.</description></item>
        /// <item><description>After you import products to the product library, they are stored in Alibaba Cloud OSS for direct recall and retrieval by the product recognition API.</description></item>
        /// <item><description>You must provide at least one main image URL, and the <c>item_unique_id</c> must be unique within the same business party.</description></item>
        /// <item><description>You can optionally provide multi-angle views and extra images to improve recognition accuracy.</description></item>
        /// <item><description>The <c>device_id</c> field can be used to establish an association between a device and product vectors, but it is not required.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Adds product information. After a successful import, the platform returns a globally unique platform_item_id for subsequent updates and recognition result association.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation is used to add product information.</description></item>
        /// <item><description>After you import products to the product library, they are stored in Alibaba Cloud OSS for direct recall and retrieval by the product recognition API.</description></item>
        /// <item><description>You must provide at least one main image URL, and the <c>item_unique_id</c> must be unique within the same business party.</description></item>
        /// <item><description>You can optionally provide multi-angle views and extra images to improve recognition accuracy.</description></item>
        /// <item><description>The <c>device_id</c> field can be used to establish an association between a device and product vectors, but it is not required.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Adds product information. After a successful import, the platform returns a globally unique platform_item_id for subsequent updates and recognition result association.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation is used to add product information.</description></item>
        /// <item><description>After you import products to the product library, they are stored in Alibaba Cloud OSS for direct recall and retrieval by the product recognition API.</description></item>
        /// <item><description>You must provide at least one main image URL, and the <c>item_unique_id</c> must be unique within the same business party.</description></item>
        /// <item><description>You can optionally provide multi-angle views and extra images to improve recognition accuracy.</description></item>
        /// <item><description>The <c>device_id</c> field can be used to establish an association between a device and product vectors, but it is not required.</description></item>
        /// </list>
        /// </description>
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
        /// <para>At least one result retrieval method must be integrated: webhook callback or task status query. Both methods can be used simultaneously.
        ///     •	If the user chooses the webhook callback method, the receiving endpoint must be prepared in advance and implemented according to the following request and response parameters.
        ///     •	After the recognition task is completed, the platform will push the results to the business party based on the callback URL bound to the task.</para>
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
        /// <para>At least one result retrieval method must be integrated: webhook callback or task status query. Both methods can be used simultaneously.
        ///     •	If the user chooses the webhook callback method, the receiving endpoint must be prepared in advance and implemented according to the following request and response parameters.
        ///     •	After the recognition task is completed, the platform will push the results to the business party based on the callback URL bound to the task.</para>
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
        /// <para>At least one result retrieval method must be integrated: webhook callback or task status query. Both methods can be used simultaneously.
        ///     •	If the user chooses the webhook callback method, the receiving endpoint must be prepared in advance and implemented according to the following request and response parameters.
        ///     •	After the recognition task is completed, the platform will push the results to the business party based on the callback URL bound to the task.</para>
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
        /// <para>At least one result retrieval method must be integrated: webhook callback or task status query. Both methods can be used simultaneously.
        ///     •	If the user chooses the webhook callback method, the receiving endpoint must be prepared in advance and implemented according to the following request and response parameters.
        ///     •	After the recognition task is completed, the platform will push the results to the business party based on the callback URL bound to the task.</para>
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
        /// <para>Used for intelligent recognition scenarios. Requires uploading the OSS address of shopping videos. The platform creates an asynchronous recognition task and immediately returns a task_id. Notifications are sent via webhook, and the results need to be actively retrieved through the query API.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <list type="bullet">
        /// <item><description>The user must provide <c>caller_uid</c> and <c>order_unique_id</c> as required parameters.</description></item>
        /// <item><description>The <c>video_urls</c> parameter supports video files in mp4, avi, mov, and mkv formats, with a size limit of 100 MB, a duration of no more than 3 minutes, a resolution between 480p and 1080p, and specific aspect ratio requirements.</description></item>
        /// <item><description>At least one of <c>device_id</c> or <c>candidate_items</c> must be provided to specify the recognition scope. If both are provided, the system first filters by the device product library and then further filters based on the candidate items list.</description></item>
        /// <item><description>Optionally, the user can specify a <c>callback_url</c> to receive notifications of the recognition results. If not provided, the pre-registered default webhook address is used.</description></item>
        /// <item><description>If a request is submitted repeatedly with the same <c>order_unique_id</c>, the system directly returns the previously existing task status.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Used for intelligent recognition scenarios. Requires uploading the OSS address of shopping videos. The platform creates an asynchronous recognition task and immediately returns a task_id. Notifications are sent via webhook, and the results need to be actively retrieved through the query API.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <list type="bullet">
        /// <item><description>The user must provide <c>caller_uid</c> and <c>order_unique_id</c> as required parameters.</description></item>
        /// <item><description>The <c>video_urls</c> parameter supports video files in mp4, avi, mov, and mkv formats, with a size limit of 100 MB, a duration of no more than 3 minutes, a resolution between 480p and 1080p, and specific aspect ratio requirements.</description></item>
        /// <item><description>At least one of <c>device_id</c> or <c>candidate_items</c> must be provided to specify the recognition scope. If both are provided, the system first filters by the device product library and then further filters based on the candidate items list.</description></item>
        /// <item><description>Optionally, the user can specify a <c>callback_url</c> to receive notifications of the recognition results. If not provided, the pre-registered default webhook address is used.</description></item>
        /// <item><description>If a request is submitted repeatedly with the same <c>order_unique_id</c>, the system directly returns the previously existing task status.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Used for intelligent recognition scenarios. Requires uploading the OSS address of shopping videos. The platform creates an asynchronous recognition task and immediately returns a task_id. Notifications are sent via webhook, and the results need to be actively retrieved through the query API.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <list type="bullet">
        /// <item><description>The user must provide <c>caller_uid</c> and <c>order_unique_id</c> as required parameters.</description></item>
        /// <item><description>The <c>video_urls</c> parameter supports video files in mp4, avi, mov, and mkv formats, with a size limit of 100 MB, a duration of no more than 3 minutes, a resolution between 480p and 1080p, and specific aspect ratio requirements.</description></item>
        /// <item><description>At least one of <c>device_id</c> or <c>candidate_items</c> must be provided to specify the recognition scope. If both are provided, the system first filters by the device product library and then further filters based on the candidate items list.</description></item>
        /// <item><description>Optionally, the user can specify a <c>callback_url</c> to receive notifications of the recognition results. If not provided, the pre-registered default webhook address is used.</description></item>
        /// <item><description>If a request is submitted repeatedly with the same <c>order_unique_id</c>, the system directly returns the previously existing task status.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Used for intelligent recognition scenarios. Requires uploading the OSS address of shopping videos. The platform creates an asynchronous recognition task and immediately returns a task_id. Notifications are sent via webhook, and the results need to be actively retrieved through the query API.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <list type="bullet">
        /// <item><description>The user must provide <c>caller_uid</c> and <c>order_unique_id</c> as required parameters.</description></item>
        /// <item><description>The <c>video_urls</c> parameter supports video files in mp4, avi, mov, and mkv formats, with a size limit of 100 MB, a duration of no more than 3 minutes, a resolution between 480p and 1080p, and specific aspect ratio requirements.</description></item>
        /// <item><description>At least one of <c>device_id</c> or <c>candidate_items</c> must be provided to specify the recognition scope. If both are provided, the system first filters by the device product library and then further filters based on the candidate items list.</description></item>
        /// <item><description>Optionally, the user can specify a <c>callback_url</c> to receive notifications of the recognition results. If not provided, the pre-registered default webhook address is used.</description></item>
        /// <item><description>If a request is submitted repeatedly with the same <c>order_unique_id</c>, the system directly returns the previously existing task status.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Registers or updates the default webhook callback URL.</para>
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
        /// <para>Registers or updates the default webhook callback URL.</para>
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
        /// <para>Registers or updates the default webhook callback URL.</para>
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
        /// <para>Registers or updates the default webhook callback URL.</para>
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
        /// <para>Updates the information of an existing item on the platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>The platform_item_id parameter is used as the primary identifier for the update.</description></item>
        /// <item><description>If both platform_item_id and item_unique_id are specified, they must point to the same item.</description></item>
        /// <item><description>The item title (image_title) and the list of main image URLs (main_image) are required. The main_image parameter must contain at least one image.</description></item>
        /// <item><description>Optional parameters include the multi-angle image list (multi_view_images), the list of additional image URLs (extra_images), and the device ID (device_id).</description></item>
        /// <item><description>In multi_view_images, each object must contain the image OSS address (url) and the shooting angle (angle). Valid values of angle: top view (up), bottom view (down), left view (left), right view (right), front view (front), and back view (back).</description></item>
        /// </list>
        /// </description>
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
        /// <para>Updates the information of an existing item on the platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>The platform_item_id parameter is used as the primary identifier for the update.</description></item>
        /// <item><description>If both platform_item_id and item_unique_id are specified, they must point to the same item.</description></item>
        /// <item><description>The item title (image_title) and the list of main image URLs (main_image) are required. The main_image parameter must contain at least one image.</description></item>
        /// <item><description>Optional parameters include the multi-angle image list (multi_view_images), the list of additional image URLs (extra_images), and the device ID (device_id).</description></item>
        /// <item><description>In multi_view_images, each object must contain the image OSS address (url) and the shooting angle (angle). Valid values of angle: top view (up), bottom view (down), left view (left), right view (right), front view (front), and back view (back).</description></item>
        /// </list>
        /// </description>
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
        /// <para>Updates the information of an existing item on the platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>The platform_item_id parameter is used as the primary identifier for the update.</description></item>
        /// <item><description>If both platform_item_id and item_unique_id are specified, they must point to the same item.</description></item>
        /// <item><description>The item title (image_title) and the list of main image URLs (main_image) are required. The main_image parameter must contain at least one image.</description></item>
        /// <item><description>Optional parameters include the multi-angle image list (multi_view_images), the list of additional image URLs (extra_images), and the device ID (device_id).</description></item>
        /// <item><description>In multi_view_images, each object must contain the image OSS address (url) and the shooting angle (angle). Valid values of angle: top view (up), bottom view (down), left view (left), right view (right), front view (front), and back view (back).</description></item>
        /// </list>
        /// </description>
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
        /// <para>Updates the information of an existing item on the platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>The platform_item_id parameter is used as the primary identifier for the update.</description></item>
        /// <item><description>If both platform_item_id and item_unique_id are specified, they must point to the same item.</description></item>
        /// <item><description>The item title (image_title) and the list of main image URLs (main_image) are required. The main_image parameter must contain at least one image.</description></item>
        /// <item><description>Optional parameters include the multi-angle image list (multi_view_images), the list of additional image URLs (extra_images), and the device ID (device_id).</description></item>
        /// <item><description>In multi_view_images, each object must contain the image OSS address (url) and the shooting angle (angle). Valid values of angle: top view (up), bottom view (down), left view (left), right view (right), front view (front), and back view (back).</description></item>
        /// </list>
        /// </description>
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
