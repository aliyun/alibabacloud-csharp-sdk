// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Wuying_personal_pc20251111.Models;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("wuying-personal-pc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建桌面镜像</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDesktopImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDesktopImageResponse
        /// </returns>
        public CreateDesktopImageResponse CreateDesktopImageWithOptions(CreateDesktopImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDesktopImageShrinkRequest request = new CreateDesktopImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartUpFilePathList))
            {
                request.StartUpFilePathListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartUpFilePathList, "StartUpFilePathList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCleanUserData))
            {
                query["AutoCleanUserData"] = request.AutoCleanUserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStartUpConfig))
            {
                query["EnableStartUpConfig"] = request.EnableStartUpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                query["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartUpFilePathListShrink))
            {
                query["StartUpFilePathList"] = request.StartUpFilePathListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDesktopImage",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDesktopImageResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建桌面镜像</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDesktopImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDesktopImageResponse
        /// </returns>
        public async Task<CreateDesktopImageResponse> CreateDesktopImageWithOptionsAsync(CreateDesktopImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDesktopImageShrinkRequest request = new CreateDesktopImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartUpFilePathList))
            {
                request.StartUpFilePathListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartUpFilePathList, "StartUpFilePathList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCleanUserData))
            {
                query["AutoCleanUserData"] = request.AutoCleanUserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStartUpConfig))
            {
                query["EnableStartUpConfig"] = request.EnableStartUpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                query["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartUpFilePathListShrink))
            {
                query["StartUpFilePathList"] = request.StartUpFilePathListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDesktopImage",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDesktopImageResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建桌面镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDesktopImageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDesktopImageResponse
        /// </returns>
        public CreateDesktopImageResponse CreateDesktopImage(CreateDesktopImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDesktopImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建桌面镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDesktopImageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDesktopImageResponse
        /// </returns>
        public async Task<CreateDesktopImageResponse> CreateDesktopImageAsync(CreateDesktopImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDesktopImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下单套餐包和核时包</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrderResponse
        /// </returns>
        public CreateOrderResponse CreateOrderWithOptions(CreateOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOrderShrinkRequest request = new CreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DynamicProductParams))
            {
                request.DynamicProductParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DynamicProductParams, "DynamicProductParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicProductParamsShrink))
            {
                query["DynamicProductParams"] = request.DynamicProductParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderFrom))
            {
                query["OrderFrom"] = request.OrderFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrder",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下单套餐包和核时包</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrderResponse
        /// </returns>
        public async Task<CreateOrderResponse> CreateOrderWithOptionsAsync(CreateOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOrderShrinkRequest request = new CreateOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DynamicProductParams))
            {
                request.DynamicProductParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DynamicProductParams, "DynamicProductParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicProductParamsShrink))
            {
                query["DynamicProductParams"] = request.DynamicProductParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderFrom))
            {
                query["OrderFrom"] = request.OrderFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrder",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下单套餐包和核时包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrderResponse
        /// </returns>
        public CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下单套餐包和核时包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrderResponse
        /// </returns>
        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除云桌面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDesktopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDesktopResponse
        /// </returns>
        public DeleteDesktopResponse DeleteDesktopWithOptions(DeleteDesktopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDesktop",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDesktopResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除云桌面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDesktopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDesktopResponse
        /// </returns>
        public async Task<DeleteDesktopResponse> DeleteDesktopWithOptionsAsync(DeleteDesktopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDesktop",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDesktopResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除云桌面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDesktopRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDesktopResponse
        /// </returns>
        public DeleteDesktopResponse DeleteDesktop(DeleteDesktopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDesktopWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除云桌面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDesktopRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDesktopResponse
        /// </returns>
        public async Task<DeleteDesktopResponse> DeleteDesktopAsync(DeleteDesktopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDesktopWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除桌面镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDesktopImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDesktopImageResponse
        /// </returns>
        public DeleteDesktopImageResponse DeleteDesktopImageWithOptions(DeleteDesktopImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCleanImageCode))
            {
                query["IsCleanImageCode"] = request.IsCleanImageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDesktopImage",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDesktopImageResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除桌面镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDesktopImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDesktopImageResponse
        /// </returns>
        public async Task<DeleteDesktopImageResponse> DeleteDesktopImageWithOptionsAsync(DeleteDesktopImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCleanImageCode))
            {
                query["IsCleanImageCode"] = request.IsCleanImageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDesktopImage",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDesktopImageResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除桌面镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDesktopImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDesktopImageResponse
        /// </returns>
        public DeleteDesktopImageResponse DeleteDesktopImage(DeleteDesktopImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDesktopImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除桌面镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDesktopImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDesktopImageResponse
        /// </returns>
        public async Task<DeleteDesktopImageResponse> DeleteDesktopImageAsync(DeleteDesktopImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDesktopImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可变更的镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessibleImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessibleImagesResponse
        /// </returns>
        public DescribeAccessibleImagesResponse DescribeAccessibleImagesWithOptions(DescribeAccessibleImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizSource))
            {
                query["BizSource"] = request.BizSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopType))
            {
                query["DesktopType"] = request.DesktopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessibleImages",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessibleImagesResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可变更的镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessibleImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessibleImagesResponse
        /// </returns>
        public async Task<DescribeAccessibleImagesResponse> DescribeAccessibleImagesWithOptionsAsync(DescribeAccessibleImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizSource))
            {
                query["BizSource"] = request.BizSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopType))
            {
                query["DesktopType"] = request.DesktopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccessibleImages",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccessibleImagesResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可变更的镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessibleImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessibleImagesResponse
        /// </returns>
        public DescribeAccessibleImagesResponse DescribeAccessibleImages(DescribeAccessibleImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessibleImagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户可变更的镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAccessibleImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccessibleImagesResponse
        /// </returns>
        public async Task<DescribeAccessibleImagesResponse> DescribeAccessibleImagesAsync(DescribeAccessibleImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessibleImagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询核时包包列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCorePackageListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCorePackageListResponse
        /// </returns>
        public DescribeCorePackageListResponse DescribeCorePackageListWithOptions(DescribeCorePackageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDeductionInstances))
            {
                query["QueryDeductionInstances"] = request.QueryDeductionInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryScenario))
            {
                query["QueryScenario"] = request.QueryScenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCorePackageList",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCorePackageListResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询核时包包列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCorePackageListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCorePackageListResponse
        /// </returns>
        public async Task<DescribeCorePackageListResponse> DescribeCorePackageListWithOptionsAsync(DescribeCorePackageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDeductionInstances))
            {
                query["QueryDeductionInstances"] = request.QueryDeductionInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryScenario))
            {
                query["QueryScenario"] = request.QueryScenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCorePackageList",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCorePackageListResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询核时包包列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCorePackageListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCorePackageListResponse
        /// </returns>
        public DescribeCorePackageListResponse DescribeCorePackageList(DescribeCorePackageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCorePackageListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询核时包包列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCorePackageListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCorePackageListResponse
        /// </returns>
        public async Task<DescribeCorePackageListResponse> DescribeCorePackageListAsync(DescribeCorePackageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCorePackageListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>软终端分tab查询云桌面列表 &amp; 组织信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDesktopsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDesktopsResponse
        /// </returns>
        public DescribeDesktopsResponse DescribeDesktopsWithOptions(DescribeDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayType))
            {
                query["DisplayType"] = request.DisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDesktops",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDesktopsResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>软终端分tab查询云桌面列表 &amp; 组织信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDesktopsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDesktopsResponse
        /// </returns>
        public async Task<DescribeDesktopsResponse> DescribeDesktopsWithOptionsAsync(DescribeDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayType))
            {
                query["DisplayType"] = request.DisplayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDesktops",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDesktopsResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>软终端分tab查询云桌面列表 &amp; 组织信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDesktopsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDesktopsResponse
        /// </returns>
        public DescribeDesktopsResponse DescribeDesktops(DescribeDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDesktopsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>软终端分tab查询云桌面列表 &amp; 组织信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDesktopsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDesktopsResponse
        /// </returns>
        public async Task<DescribeDesktopsResponse> DescribeDesktopsAsync(DescribeDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDesktopsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据分享码查询镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageDetailResponse
        /// </returns>
        public DescribeImageDetailResponse DescribeImageDetailWithOptions(DescribeImageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareCode))
            {
                query["ShareCode"] = request.ShareCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageDetail",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageDetailResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据分享码查询镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageDetailResponse
        /// </returns>
        public async Task<DescribeImageDetailResponse> DescribeImageDetailWithOptionsAsync(DescribeImageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareCode))
            {
                query["ShareCode"] = request.ShareCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageDetail",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageDetailResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据分享码查询镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageDetailResponse
        /// </returns>
        public DescribeImageDetailResponse DescribeImageDetail(DescribeImageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据分享码查询镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageDetailResponse
        /// </returns>
        public async Task<DescribeImageDetailResponse> DescribeImageDetailAsync(DescribeImageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询套餐包订单列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribePackageOrdersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePackageOrdersResponse
        /// </returns>
        public DescribePackageOrdersResponse DescribePackageOrdersWithOptions(DescribePackageOrdersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePackageOrdersShrinkRequest request = new DescribePackageOrdersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DesktopIdList))
            {
                request.DesktopIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DesktopIdList, "DesktopIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderIdList))
            {
                request.OrderIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderIdList, "OrderIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderStatusList))
            {
                request.OrderStatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderStatusList, "OrderStatusList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProductTypeList))
            {
                request.ProductTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProductTypeList, "ProductTypeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIdList))
            {
                request.ResourceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIdList, "ResourceIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopIdListShrink))
            {
                query["DesktopIdList"] = request.DesktopIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIdListShrink))
            {
                query["OrderIdList"] = request.OrderIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatusListShrink))
            {
                query["OrderStatusList"] = request.OrderStatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductTypeListShrink))
            {
                query["ProductTypeList"] = request.ProductTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdListShrink))
            {
                query["ResourceIdList"] = request.ResourceIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePackageOrders",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePackageOrdersResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询套餐包订单列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribePackageOrdersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePackageOrdersResponse
        /// </returns>
        public async Task<DescribePackageOrdersResponse> DescribePackageOrdersWithOptionsAsync(DescribePackageOrdersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePackageOrdersShrinkRequest request = new DescribePackageOrdersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DesktopIdList))
            {
                request.DesktopIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DesktopIdList, "DesktopIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderIdList))
            {
                request.OrderIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderIdList, "OrderIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderStatusList))
            {
                request.OrderStatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderStatusList, "OrderStatusList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProductTypeList))
            {
                request.ProductTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProductTypeList, "ProductTypeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIdList))
            {
                request.ResourceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIdList, "ResourceIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopIdListShrink))
            {
                query["DesktopIdList"] = request.DesktopIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIdListShrink))
            {
                query["OrderIdList"] = request.OrderIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatusListShrink))
            {
                query["OrderStatusList"] = request.OrderStatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductTypeListShrink))
            {
                query["ProductTypeList"] = request.ProductTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdListShrink))
            {
                query["ResourceIdList"] = request.ResourceIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePackageOrders",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePackageOrdersResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询套餐包订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePackageOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePackageOrdersResponse
        /// </returns>
        public DescribePackageOrdersResponse DescribePackageOrders(DescribePackageOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackageOrdersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询套餐包订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePackageOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePackageOrdersResponse
        /// </returns>
        public async Task<DescribePackageOrdersResponse> DescribePackageOrdersAsync(DescribePackageOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackageOrdersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成无影工作站的场景url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateWuyingServerSceneUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateWuyingServerSceneUrlResponse
        /// </returns>
        public GenerateWuyingServerSceneUrlResponse GenerateWuyingServerSceneUrlWithOptions(GenerateWuyingServerSceneUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateWuyingServerSceneUrl",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateWuyingServerSceneUrlResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成无影工作站的场景url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateWuyingServerSceneUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateWuyingServerSceneUrlResponse
        /// </returns>
        public async Task<GenerateWuyingServerSceneUrlResponse> GenerateWuyingServerSceneUrlWithOptionsAsync(GenerateWuyingServerSceneUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginRegionId))
            {
                body["LoginRegionId"] = request.LoginRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                body["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WuyingServerId))
            {
                body["WuyingServerId"] = request.WuyingServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateWuyingServerSceneUrl",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateWuyingServerSceneUrlResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成无影工作站的场景url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateWuyingServerSceneUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateWuyingServerSceneUrlResponse
        /// </returns>
        public GenerateWuyingServerSceneUrlResponse GenerateWuyingServerSceneUrl(GenerateWuyingServerSceneUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateWuyingServerSceneUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成无影工作站的场景url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateWuyingServerSceneUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateWuyingServerSceneUrlResponse
        /// </returns>
        public async Task<GenerateWuyingServerSceneUrlResponse> GenerateWuyingServerSceneUrlAsync(GenerateWuyingServerSceneUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateWuyingServerSceneUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询展示商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductListResponse
        /// </returns>
        public GetProductListResponse GetProductListWithOptions(GetProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigVersion))
            {
                query["ConfigVersion"] = request.ConfigVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductList",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductListResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询展示商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductListResponse
        /// </returns>
        public async Task<GetProductListResponse> GetProductListWithOptionsAsync(GetProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigVersion))
            {
                query["ConfigVersion"] = request.ConfigVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductList",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductListResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询展示商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductListResponse
        /// </returns>
        public GetProductListResponse GetProductList(GetProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProductListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询展示商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductListResponse
        /// </returns>
        public async Task<GetProductListResponse> GetProductListAsync(GetProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProductListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public GetUserInfoResponse GetUserInfoWithOptions(GetUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInfo",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public async Task<GetUserInfoResponse> GetUserInfoWithOptionsAsync(GetUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInfo",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public GetUserInfoResponse GetUserInfo(GetUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public async Task<GetUserInfoResponse> GetUserInfoAsync(GetUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDesktopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDesktopResponse
        /// </returns>
        public StartDesktopResponse StartDesktopWithOptions(StartDesktopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDesktop",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDesktopResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDesktopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDesktopResponse
        /// </returns>
        public async Task<StartDesktopResponse> StartDesktopWithOptionsAsync(StartDesktopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDesktop",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDesktopResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDesktopRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDesktopResponse
        /// </returns>
        public StartDesktopResponse StartDesktop(StartDesktopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDesktopWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDesktopRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDesktopResponse
        /// </returns>
        public async Task<StartDesktopResponse> StartDesktopAsync(StartDesktopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDesktopWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDesktopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDesktopResponse
        /// </returns>
        public StopDesktopResponse StopDesktopWithOptions(StopDesktopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDesktop",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDesktopResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDesktopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDesktopResponse
        /// </returns>
        public async Task<StopDesktopResponse> StopDesktopWithOptionsAsync(StopDesktopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                query["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDesktop",
                Version = "2025-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDesktopResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDesktopRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDesktopResponse
        /// </returns>
        public StopDesktopResponse StopDesktop(StopDesktopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDesktopWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDesktopRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDesktopResponse
        /// </returns>
        public async Task<StopDesktopResponse> StopDesktopAsync(StopDesktopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDesktopWithOptionsAsync(request, runtime);
        }

    }
}
