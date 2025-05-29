// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.BailianModelOnChip20240816.Models;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("bailianmodelonchip", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建渠道签约申请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChannelSignRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChannelSignResponse
        /// </returns>
        public CreateChannelSignResponse CreateChannelSignWithOptions(CreateChannelSignRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelName))
            {
                body["channelName"] = request.ChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChannelSign",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/channel/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChannelSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建渠道签约申请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChannelSignRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChannelSignResponse
        /// </returns>
        public async Task<CreateChannelSignResponse> CreateChannelSignWithOptionsAsync(CreateChannelSignRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelName))
            {
                body["channelName"] = request.ChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChannelSign",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/channel/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChannelSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建渠道签约申请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChannelSignRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChannelSignResponse
        /// </returns>
        public CreateChannelSignResponse CreateChannelSign(CreateChannelSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateChannelSignWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建渠道签约申请</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChannelSignRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChannelSignResponse
        /// </returns>
        public async Task<CreateChannelSignResponse> CreateChannelSignAsync(CreateChannelSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateChannelSignWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProductResponse
        /// </returns>
        public CreateProductResponse CreateProductWithOptions(CreateProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Euid))
            {
                body["euid"] = request.Euid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProduct",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/product/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProductResponse
        /// </returns>
        public async Task<CreateProductResponse> CreateProductWithOptionsAsync(CreateProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Euid))
            {
                body["euid"] = request.Euid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProduct",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/product/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProductResponse
        /// </returns>
        public CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProductWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProductResponse
        /// </returns>
        public async Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProductWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProductResponse
        /// </returns>
        public DeleteProductResponse DeleteProductWithOptions(DeleteProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProduct",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/product/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProductRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProductResponse
        /// </returns>
        public async Task<DeleteProductResponse> DeleteProductWithOptionsAsync(DeleteProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProduct",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/product/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProductRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProductResponse
        /// </returns>
        public DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProductWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProductRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProductResponse
        /// </returns>
        public async Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProductWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceRegisterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeviceRegisterResponse
        /// </returns>
        public DeviceRegisterResponse DeviceRegisterWithOptions(DeviceRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTime))
            {
                query["requestTime"] = request.RequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nonce))
            {
                body["nonce"] = request.Nonce;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceRegister",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceRegisterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceRegisterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeviceRegisterResponse
        /// </returns>
        public async Task<DeviceRegisterResponse> DeviceRegisterWithOptionsAsync(DeviceRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTime))
            {
                query["requestTime"] = request.RequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nonce))
            {
                body["nonce"] = request.Nonce;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceRegister",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceRegisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeviceRegisterResponse
        /// </returns>
        public DeviceRegisterResponse DeviceRegister(DeviceRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeviceRegisterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeviceRegisterResponse
        /// </returns>
        public async Task<DeviceRegisterResponse> DeviceRegisterAsync(DeviceRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeviceRegisterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询渠道签约申请</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChannelSignResponse
        /// </returns>
        public GetChannelSignResponse GetChannelSignWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChannelSign",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/channel/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChannelSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询渠道签约申请</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChannelSignResponse
        /// </returns>
        public async Task<GetChannelSignResponse> GetChannelSignWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChannelSign",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/channel/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChannelSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询渠道签约申请</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetChannelSignResponse
        /// </returns>
        public GetChannelSignResponse GetChannelSign()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetChannelSignWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询渠道签约申请</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetChannelSignResponse
        /// </returns>
        public async Task<GetChannelSignResponse> GetChannelSignAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetChannelSignWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取额度信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaInfoResponse
        /// </returns>
        public GetQuotaInfoResponse GetQuotaInfoWithOptions(GetQuotaInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                body["recordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaInfo",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/quota/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取额度信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaInfoResponse
        /// </returns>
        public async Task<GetQuotaInfoResponse> GetQuotaInfoWithOptionsAsync(GetQuotaInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                body["recordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaInfo",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/quota/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取额度信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaInfoResponse
        /// </returns>
        public GetQuotaInfoResponse GetQuotaInfo(GetQuotaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQuotaInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取额度信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaInfoResponse
        /// </returns>
        public async Task<GetQuotaInfoResponse> GetQuotaInfoAsync(GetQuotaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQuotaInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关校验Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public GetTokenResponse GetTokenWithOptions(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nonce))
            {
                body["nonce"] = request.Nonce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTime))
            {
                body["requestTime"] = request.RequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenKey))
            {
                body["tokenKey"] = request.TokenKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenType))
            {
                body["tokenType"] = request.TokenType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/auth/v1/token/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关校验Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public async Task<GetTokenResponse> GetTokenWithOptionsAsync(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nonce))
            {
                body["nonce"] = request.Nonce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTime))
            {
                body["requestTime"] = request.RequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenKey))
            {
                body["tokenKey"] = request.TokenKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenType))
            {
                body["tokenType"] = request.TokenType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/auth/v1/token/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关校验Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public GetTokenResponse GetToken(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关校验Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public async Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型应用请求</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// HalfLLMAppCallRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMAppCallResponse
        /// </returns>
        public HalfLLMAppCallResponse HalfLLMAppCallWithOptions(HalfLLMAppCallRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HalfLLMAppCallShrinkRequest request = new HalfLLMAppCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BizParam))
            {
                request.BizParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BizParam, "bizParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModelTypeList))
            {
                request.ModelTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModelTypeList, "modelTypeList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizParamShrink))
            {
                body["bizParam"] = request.BizParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypeListShrink))
            {
                body["modelTypeList"] = request.ModelTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HalfLLMAppCall",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/half/llm/app/call",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HalfLLMAppCallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型应用请求</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// HalfLLMAppCallRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMAppCallResponse
        /// </returns>
        public async Task<HalfLLMAppCallResponse> HalfLLMAppCallWithOptionsAsync(HalfLLMAppCallRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HalfLLMAppCallShrinkRequest request = new HalfLLMAppCallShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BizParam))
            {
                request.BizParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BizParam, "bizParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModelTypeList))
            {
                request.ModelTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModelTypeList, "modelTypeList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizParamShrink))
            {
                body["bizParam"] = request.BizParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypeListShrink))
            {
                body["modelTypeList"] = request.ModelTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HalfLLMAppCall",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/half/llm/app/call",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HalfLLMAppCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型应用请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMAppCallRequest
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMAppCallResponse
        /// </returns>
        public HalfLLMAppCallResponse HalfLLMAppCall(HalfLLMAppCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return HalfLLMAppCallWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型应用请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMAppCallRequest
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMAppCallResponse
        /// </returns>
        public async Task<HalfLLMAppCallResponse> HalfLLMAppCallAsync(HalfLLMAppCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await HalfLLMAppCallWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型流式文本对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMChatResponse
        /// </returns>
        public HalfLLMChatResponse HalfLLMChatWithOptions(HalfLLMChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSearch))
            {
                body["enableSearch"] = request.EnableSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputText))
            {
                body["inputText"] = request.InputText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HalfLLMChat",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/half/llm/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HalfLLMChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型流式文本对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMChatResponse
        /// </returns>
        public async Task<HalfLLMChatResponse> HalfLLMChatWithOptionsAsync(HalfLLMChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSearch))
            {
                body["enableSearch"] = request.EnableSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputText))
            {
                body["inputText"] = request.InputText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HalfLLMChat",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/half/llm/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HalfLLMChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型流式文本对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMChatRequest
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMChatResponse
        /// </returns>
        public HalfLLMChatResponse HalfLLMChat(HalfLLMChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return HalfLLMChatWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型流式文本对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMChatRequest
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMChatResponse
        /// </returns>
        public async Task<HalfLLMChatResponse> HalfLLMChatAsync(HalfLLMChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await HalfLLMChatWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型文本合成语音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMImageChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMImageChatResponse
        /// </returns>
        public HalfLLMImageChatResponse HalfLLMImageChatWithOptions(HalfLLMImageChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSearch))
            {
                body["enableSearch"] = request.EnableSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputText))
            {
                body["inputText"] = request.InputText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HalfLLMImageChat",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/half/llm/image/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HalfLLMImageChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型文本合成语音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMImageChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMImageChatResponse
        /// </returns>
        public async Task<HalfLLMImageChatResponse> HalfLLMImageChatWithOptionsAsync(HalfLLMImageChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSearch))
            {
                body["enableSearch"] = request.EnableSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputText))
            {
                body["inputText"] = request.InputText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HalfLLMImageChat",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/half/llm/image/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HalfLLMImageChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型文本合成语音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMImageChatRequest
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMImageChatResponse
        /// </returns>
        public HalfLLMImageChatResponse HalfLLMImageChat(HalfLLMImageChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return HalfLLMImageChatWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型文本合成语音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMImageChatRequest
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMImageChatResponse
        /// </returns>
        public async Task<HalfLLMImageChatResponse> HalfLLMImageChatAsync(HalfLLMImageChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await HalfLLMImageChatWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型图片识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMImageOcrRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMImageOcrResponse
        /// </returns>
        public HalfLLMImageOcrResponse HalfLLMImageOcrWithOptions(HalfLLMImageOcrRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HalfLLMImageOcr",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/half/llm/image/ocr",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HalfLLMImageOcrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型图片识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMImageOcrRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMImageOcrResponse
        /// </returns>
        public async Task<HalfLLMImageOcrResponse> HalfLLMImageOcrWithOptionsAsync(HalfLLMImageOcrRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HalfLLMImageOcr",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/half/llm/image/ocr",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HalfLLMImageOcrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型图片识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMImageOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMImageOcrResponse
        /// </returns>
        public HalfLLMImageOcrResponse HalfLLMImageOcr(HalfLLMImageOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return HalfLLMImageOcrWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型图片识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMImageOcrRequest
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMImageOcrResponse
        /// </returns>
        public async Task<HalfLLMImageOcrResponse> HalfLLMImageOcrAsync(HalfLLMImageOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await HalfLLMImageOcrWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型文本合成语音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMTTSChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMTTSChatResponse
        /// </returns>
        public HalfLLMTTSChatResponse HalfLLMTTSChatWithOptions(HalfLLMTTSChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSearch))
            {
                body["enableSearch"] = request.EnableSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PitchRate))
            {
                body["pitchRate"] = request.PitchRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleRate))
            {
                body["sampleRate"] = request.SampleRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                body["speechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voice))
            {
                body["voice"] = request.Voice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                body["volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HalfLLMTTSChat",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/half/llm/tts/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HalfLLMTTSChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型文本合成语音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMTTSChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMTTSChatResponse
        /// </returns>
        public async Task<HalfLLMTTSChatResponse> HalfLLMTTSChatWithOptionsAsync(HalfLLMTTSChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSearch))
            {
                body["enableSearch"] = request.EnableSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                body["format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PitchRate))
            {
                body["pitchRate"] = request.PitchRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleRate))
            {
                body["sampleRate"] = request.SampleRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeechRate))
            {
                body["speechRate"] = request.SpeechRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Voice))
            {
                body["voice"] = request.Voice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                body["volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HalfLLMTTSChat",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/half/llm/tts/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HalfLLMTTSChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型文本合成语音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMTTSChatRequest
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMTTSChatResponse
        /// </returns>
        public HalfLLMTTSChatResponse HalfLLMTTSChat(HalfLLMTTSChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return HalfLLMTTSChatWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>半托管大模型文本合成语音</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HalfLLMTTSChatRequest
        /// </param>
        /// 
        /// <returns>
        /// HalfLLMTTSChatResponse
        /// </returns>
        public async Task<HalfLLMTTSChatResponse> HalfLLMTTSChatAsync(HalfLLMTTSChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await HalfLLMTTSChatWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备列表分页查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicePageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicePageResponse
        /// </returns>
        public QueryDevicePageResponse QueryDevicePageWithOptions(QueryDevicePageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableStatus))
            {
                body["disableStatus"] = request.DisableStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicePage",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/page",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备列表分页查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicePageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicePageResponse
        /// </returns>
        public async Task<QueryDevicePageResponse> QueryDevicePageWithOptionsAsync(QueryDevicePageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableStatus))
            {
                body["disableStatus"] = request.DisableStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicePage",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/page",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备列表分页查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicePageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicePageResponse
        /// </returns>
        public QueryDevicePageResponse QueryDevicePage(QueryDevicePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryDevicePageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备列表分页查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDevicePageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDevicePageResponse
        /// </returns>
        public async Task<QueryDevicePageResponse> QueryDevicePageAsync(QueryDevicePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryDevicePageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProductPageResponse
        /// </returns>
        public QueryProductPageResponse QueryProductPageWithOptions(QueryProductPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProductPage",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/product/page",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProductPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProductPageResponse
        /// </returns>
        public async Task<QueryProductPageResponse> QueryProductPageWithOptionsAsync(QueryProductPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProductPage",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/product/page",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProductPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProductPageResponse
        /// </returns>
        public QueryProductPageResponse QueryProductPage(QueryProductPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryProductPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProductPageResponse
        /// </returns>
        public async Task<QueryProductPageResponse> QueryProductPageAsync(QueryProductPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryProductPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询产品额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductQuotaPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProductQuotaPageResponse
        /// </returns>
        public QueryProductQuotaPageResponse QueryProductQuotaPageWithOptions(QueryProductQuotaPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseTimeEnd))
            {
                body["purchaseTimeEnd"] = request.PurchaseTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseTimeStart))
            {
                body["purchaseTimeStart"] = request.PurchaseTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseType))
            {
                body["purchaseType"] = request.PurchaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProductQuotaPage",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/product/quotaPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProductQuotaPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询产品额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductQuotaPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProductQuotaPageResponse
        /// </returns>
        public async Task<QueryProductQuotaPageResponse> QueryProductQuotaPageWithOptionsAsync(QueryProductQuotaPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseTimeEnd))
            {
                body["purchaseTimeEnd"] = request.PurchaseTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseTimeStart))
            {
                body["purchaseTimeStart"] = request.PurchaseTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseType))
            {
                body["purchaseType"] = request.PurchaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProductQuotaPage",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/product/quotaPage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProductQuotaPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询产品额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductQuotaPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProductQuotaPageResponse
        /// </returns>
        public QueryProductQuotaPageResponse QueryProductQuotaPage(QueryProductQuotaPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryProductQuotaPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询产品额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductQuotaPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProductQuotaPageResponse
        /// </returns>
        public async Task<QueryProductQuotaPageResponse> QueryProductQuotaPageAsync(QueryProductQuotaPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryProductQuotaPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询token使用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTokenUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTokenUsageResponse
        /// </returns>
        public QueryTokenUsageResponse QueryTokenUsageWithOptions(QueryTokenUsageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTokenUsage",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/token/usage/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTokenUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询token使用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTokenUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTokenUsageResponse
        /// </returns>
        public async Task<QueryTokenUsageResponse> QueryTokenUsageWithOptionsAsync(QueryTokenUsageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTokenUsage",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/token/usage/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTokenUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询token使用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTokenUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTokenUsageResponse
        /// </returns>
        public QueryTokenUsageResponse QueryTokenUsage(QueryTokenUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryTokenUsageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询token使用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTokenUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTokenUsageResponse
        /// </returns>
        public async Task<QueryTokenUsageResponse> QueryTokenUsageAsync(QueryTokenUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryTokenUsageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销渠道签约申请</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeChannelSignResponse
        /// </returns>
        public RevokeChannelSignResponse RevokeChannelSignWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeChannelSign",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/channel/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeChannelSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销渠道签约申请</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeChannelSignResponse
        /// </returns>
        public async Task<RevokeChannelSignResponse> RevokeChannelSignWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeChannelSign",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/channel/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeChannelSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销渠道签约申请</para>
        /// </summary>
        /// 
        /// <returns>
        /// RevokeChannelSignResponse
        /// </returns>
        public RevokeChannelSignResponse RevokeChannelSign()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeChannelSignWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>撤销渠道签约申请</para>
        /// </summary>
        /// 
        /// <returns>
        /// RevokeChannelSignResponse
        /// </returns>
        public async Task<RevokeChannelSignResponse> RevokeChannelSignAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeChannelSignWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeviceStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeviceStatusResponse
        /// </returns>
        public UpdateDeviceStatusResponse UpdateDeviceStatusWithOptions(UpdateDeviceStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeviceStatus",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/update/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeviceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeviceStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeviceStatusResponse
        /// </returns>
        public async Task<UpdateDeviceStatusResponse> UpdateDeviceStatusWithOptionsAsync(UpdateDeviceStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeviceStatus",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/update/status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeviceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeviceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeviceStatusResponse
        /// </returns>
        public UpdateDeviceStatusResponse UpdateDeviceStatus(UpdateDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDeviceStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeviceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeviceStatusResponse
        /// </returns>
        public async Task<UpdateDeviceStatusResponse> UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDeviceStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改图片模型额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateImageQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateImageQuotaResponse
        /// </returns>
        public UpdateImageQuotaResponse UpdateImageQuotaWithOptions(UpdateImageQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationType))
            {
                body["durationType"] = request.DurationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCount))
            {
                body["imageCount"] = request.ImageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseCount))
            {
                body["licenseCount"] = request.LicenseCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["packageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseType))
            {
                body["purchaseType"] = request.PurchaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                body["recordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettlementAmount))
            {
                body["settlementAmount"] = request.SettlementAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateImageQuota",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/quota/update/image",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改图片模型额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateImageQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateImageQuotaResponse
        /// </returns>
        public async Task<UpdateImageQuotaResponse> UpdateImageQuotaWithOptionsAsync(UpdateImageQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationType))
            {
                body["durationType"] = request.DurationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCount))
            {
                body["imageCount"] = request.ImageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseCount))
            {
                body["licenseCount"] = request.LicenseCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["packageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseType))
            {
                body["purchaseType"] = request.PurchaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                body["recordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettlementAmount))
            {
                body["settlementAmount"] = request.SettlementAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateImageQuota",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/quota/update/image",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改图片模型额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateImageQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateImageQuotaResponse
        /// </returns>
        public UpdateImageQuotaResponse UpdateImageQuota(UpdateImageQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateImageQuotaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改图片模型额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateImageQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateImageQuotaResponse
        /// </returns>
        public async Task<UpdateImageQuotaResponse> UpdateImageQuotaAsync(UpdateImageQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateImageQuotaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaResponse
        /// </returns>
        public UpdateQuotaResponse UpdateQuotaWithOptions(UpdateQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationType))
            {
                body["durationType"] = request.DurationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseCount))
            {
                body["licenseCount"] = request.LicenseCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxQps))
            {
                body["maxQps"] = request.MaxQps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["packageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseType))
            {
                body["purchaseType"] = request.PurchaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                body["recordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettlementAmount))
            {
                body["settlementAmount"] = request.SettlementAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenNumber))
            {
                body["tokenNumber"] = request.TokenNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuota",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/quota/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaResponse
        /// </returns>
        public async Task<UpdateQuotaResponse> UpdateQuotaWithOptionsAsync(UpdateQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationType))
            {
                body["durationType"] = request.DurationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseCount))
            {
                body["licenseCount"] = request.LicenseCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxQps))
            {
                body["maxQps"] = request.MaxQps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["packageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                body["productKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseType))
            {
                body["purchaseType"] = request.PurchaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                body["recordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettlementAmount))
            {
                body["settlementAmount"] = request.SettlementAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenNumber))
            {
                body["tokenNumber"] = request.TokenNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuota",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/quota/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaResponse
        /// </returns>
        public UpdateQuotaResponse UpdateQuota(UpdateQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateQuotaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaResponse
        /// </returns>
        public async Task<UpdateQuotaResponse> UpdateQuotaAsync(UpdateQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateQuotaWithOptionsAsync(request, headers, runtime);
        }

    }
}
