// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Market20151101.Models;

namespace AlibabaCloud.SDK.Market20151101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "market.aliyuncs.com"},
                {"ap-northeast-1", "market.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "market.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "market.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "market.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "market.ap-southeast-1.aliyuncs.com"},
                {"cn-beijing", "market.aliyuncs.com"},
                {"cn-chengdu", "market.aliyuncs.com"},
                {"cn-hongkong", "market.aliyuncs.com"},
                {"cn-huhehaote", "market.aliyuncs.com"},
                {"cn-qingdao", "market.aliyuncs.com"},
                {"cn-shanghai", "market.aliyuncs.com"},
                {"cn-shenzhen", "market.aliyuncs.com"},
                {"cn-zhangjiakou", "market.aliyuncs.com"},
                {"eu-central-1", "market.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "market.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "market.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "market.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "market.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "market.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "market.aliyuncs.com"},
                {"cn-shanghai-finance-1", "market.aliyuncs.com"},
                {"cn-north-2-gov-1", "market.aliyuncs.com"},
                {"ap-southeast-1", "market.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("market", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Activates an authorization code by calling ActivateLicense.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public ActivateLicenseResponse ActivateLicenseWithOptions(ActivateLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identification))
            {
                query["Identification"] = request.Identification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseCode))
            {
                query["LicenseCode"] = request.LicenseCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateLicense",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateLicenseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates an authorization code by calling ActivateLicense.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public async Task<ActivateLicenseResponse> ActivateLicenseWithOptionsAsync(ActivateLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identification))
            {
                query["Identification"] = request.Identification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseCode))
            {
                query["LicenseCode"] = request.LicenseCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateLicense",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates an authorization code by calling ActivateLicense.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public ActivateLicenseResponse ActivateLicense(ActivateLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates an authorization code by calling ActivateLicense.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public async Task<ActivateLicenseResponse> ActivateLicenseAsync(ActivateLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets auto-renewal.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AutoRenewInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AutoRenewInstanceResponse
        /// </returns>
        public AutoRenewInstanceResponse AutoRenewInstanceWithOptions(AutoRenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewCycle))
            {
                body["AutoRenewCycle"] = request.AutoRenewCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewDuration))
            {
                body["AutoRenewDuration"] = request.AutoRenewDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBizId))
            {
                body["OrderBizId"] = request.OrderBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AutoRenewInstance",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AutoRenewInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets auto-renewal.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AutoRenewInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AutoRenewInstanceResponse
        /// </returns>
        public async Task<AutoRenewInstanceResponse> AutoRenewInstanceWithOptionsAsync(AutoRenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewCycle))
            {
                body["AutoRenewCycle"] = request.AutoRenewCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewDuration))
            {
                body["AutoRenewDuration"] = request.AutoRenewDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBizId))
            {
                body["OrderBizId"] = request.OrderBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AutoRenewInstance",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AutoRenewInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets auto-renewal.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AutoRenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// AutoRenewInstanceResponse
        /// </returns>
        public AutoRenewInstanceResponse AutoRenewInstance(AutoRenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AutoRenewInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets auto-renewal.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AutoRenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// AutoRenewInstanceResponse
        /// </returns>
        public async Task<AutoRenewInstanceResponse> AutoRenewInstanceAsync(AutoRenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AutoRenewInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms that the merchant has received and processed a notification message. After this call, the message will no longer be returned in subsequent queries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Confirms the receipt of a subscription notification failure message.</para>
        /// <list type="bullet">
        /// <item><description>After a successful call, the message will no longer be returned in subsequent queries. The platform considers that the merchant has correctly processed the message.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfirmNotificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmNotificationResponse
        /// </returns>
        public ConfirmNotificationResponse ConfirmNotificationWithOptions(ConfirmNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationRequestId))
            {
                query["NotificationRequestId"] = request.NotificationRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmNotification",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmNotificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms that the merchant has received and processed a notification message. After this call, the message will no longer be returned in subsequent queries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Confirms the receipt of a subscription notification failure message.</para>
        /// <list type="bullet">
        /// <item><description>After a successful call, the message will no longer be returned in subsequent queries. The platform considers that the merchant has correctly processed the message.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfirmNotificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmNotificationResponse
        /// </returns>
        public async Task<ConfirmNotificationResponse> ConfirmNotificationWithOptionsAsync(ConfirmNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationRequestId))
            {
                query["NotificationRequestId"] = request.NotificationRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmNotification",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmNotificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms that the merchant has received and processed a notification message. After this call, the message will no longer be returned in subsequent queries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Confirms the receipt of a subscription notification failure message.</para>
        /// <list type="bullet">
        /// <item><description>After a successful call, the message will no longer be returned in subsequent queries. The platform considers that the merchant has correctly processed the message.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfirmNotificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmNotificationResponse
        /// </returns>
        public ConfirmNotificationResponse ConfirmNotification(ConfirmNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmNotificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms that the merchant has received and processed a notification message. After this call, the message will no longer be returned in subsequent queries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Confirms the receipt of a subscription notification failure message.</para>
        /// <list type="bullet">
        /// <item><description>After a successful call, the message will no longer be returned in subsequent queries. The platform considers that the merchant has correctly processed the message.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfirmNotificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmNotificationResponse
        /// </returns>
        public async Task<ConfirmNotificationResponse> ConfirmNotificationAsync(ConfirmNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmNotificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the CreateOrder operation to create an order.
        /// Before calling this operation, make sure that you fully understand the billing method and pricing of Alibaba Cloud Marketplace products.
        /// To create an order for a commercial image, refer to <a href="https://help.aliyun.com/document_detail/25499.html">CreateInstance</a>.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, make sure that you fully understand the billing method and <a href="https://market.aliyun.com/">pricing</a> of Alibaba Cloud Marketplace products.
        /// To create an order for a commercial image, refer to <a href="https://help.aliyun.com/document_detail/25499.html">CreateInstance</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrderResponse
        /// </returns>
        public CreateOrderResponse CreateOrderWithOptions(CreateOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commodity))
            {
                query["Commodity"] = request.Commodity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderSouce))
            {
                query["OrderSouce"] = request.OrderSouce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrder",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the CreateOrder operation to create an order.
        /// Before calling this operation, make sure that you fully understand the billing method and pricing of Alibaba Cloud Marketplace products.
        /// To create an order for a commercial image, refer to <a href="https://help.aliyun.com/document_detail/25499.html">CreateInstance</a>.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, make sure that you fully understand the billing method and <a href="https://market.aliyun.com/">pricing</a> of Alibaba Cloud Marketplace products.
        /// To create an order for a commercial image, refer to <a href="https://help.aliyun.com/document_detail/25499.html">CreateInstance</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrderResponse
        /// </returns>
        public async Task<CreateOrderResponse> CreateOrderWithOptionsAsync(CreateOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commodity))
            {
                query["Commodity"] = request.Commodity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderSouce))
            {
                query["OrderSouce"] = request.OrderSouce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrder",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the CreateOrder operation to create an order.
        /// Before calling this operation, make sure that you fully understand the billing method and pricing of Alibaba Cloud Marketplace products.
        /// To create an order for a commercial image, refer to <a href="https://help.aliyun.com/document_detail/25499.html">CreateInstance</a>.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, make sure that you fully understand the billing method and <a href="https://market.aliyun.com/">pricing</a> of Alibaba Cloud Marketplace products.
        /// To create an order for a commercial image, refer to <a href="https://help.aliyun.com/document_detail/25499.html">CreateInstance</a>.</para>
        /// </description>
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
        /// <para>Calls the CreateOrder operation to create an order.
        /// Before calling this operation, make sure that you fully understand the billing method and pricing of Alibaba Cloud Marketplace products.
        /// To create an order for a commercial image, refer to <a href="https://help.aliyun.com/document_detail/25499.html">CreateInstance</a>.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, make sure that you fully understand the billing method and <a href="https://market.aliyun.com/">pricing</a> of Alibaba Cloud Marketplace products.
        /// To create an order for a commercial image, refer to <a href="https://help.aliyun.com/document_detail/25499.html">CreateInstance</a>.</para>
        /// </description>
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
        /// <para>Query cross-account role authorization information, including the authorized user\&quot;s Alibaba Cloud account UID, name, authorization time, and authorized role name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CrossAccountVerifyTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CrossAccountVerifyTokenResponse
        /// </returns>
        public CrossAccountVerifyTokenResponse CrossAccountVerifyTokenWithOptions(CrossAccountVerifyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CrossAccountVerifyToken",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CrossAccountVerifyTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query cross-account role authorization information, including the authorized user\&quot;s Alibaba Cloud account UID, name, authorization time, and authorized role name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CrossAccountVerifyTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CrossAccountVerifyTokenResponse
        /// </returns>
        public async Task<CrossAccountVerifyTokenResponse> CrossAccountVerifyTokenWithOptionsAsync(CrossAccountVerifyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CrossAccountVerifyToken",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CrossAccountVerifyTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query cross-account role authorization information, including the authorized user\&quot;s Alibaba Cloud account UID, name, authorization time, and authorized role name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CrossAccountVerifyTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CrossAccountVerifyTokenResponse
        /// </returns>
        public CrossAccountVerifyTokenResponse CrossAccountVerifyToken(CrossAccountVerifyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CrossAccountVerifyTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query cross-account role authorization information, including the authorized user\&quot;s Alibaba Cloud account UID, name, authorization time, and authorized role name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CrossAccountVerifyTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CrossAccountVerifyTokenResponse
        /// </returns>
        public async Task<CrossAccountVerifyTokenResponse> CrossAccountVerifyTokenAsync(CrossAccountVerifyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CrossAccountVerifyTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the API quota data of a user, including the remaining quota, total quota, and usage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><b>Note: This operation supports both Alibaba Cloud accounts and RAM users to retrieve API remaining quota, total quota, and usage information.</b>.</h3>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeApiMeteringRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApiMeteringResponse
        /// </returns>
        public DescribeApiMeteringResponse DescribeApiMeteringWithOptions(DescribeApiMeteringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApiMetering",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApiMeteringResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the API quota data of a user, including the remaining quota, total quota, and usage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><b>Note: This operation supports both Alibaba Cloud accounts and RAM users to retrieve API remaining quota, total quota, and usage information.</b>.</h3>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeApiMeteringRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApiMeteringResponse
        /// </returns>
        public async Task<DescribeApiMeteringResponse> DescribeApiMeteringWithOptionsAsync(DescribeApiMeteringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApiMetering",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApiMeteringResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the API quota data of a user, including the remaining quota, total quota, and usage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><b>Note: This operation supports both Alibaba Cloud accounts and RAM users to retrieve API remaining quota, total quota, and usage information.</b>.</h3>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeApiMeteringRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApiMeteringResponse
        /// </returns>
        public DescribeApiMeteringResponse DescribeApiMetering(DescribeApiMeteringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiMeteringWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the API quota data of a user, including the remaining quota, total quota, and usage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><b>Note: This operation supports both Alibaba Cloud accounts and RAM users to retrieve API remaining quota, total quota, and usage information.</b>.</h3>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeApiMeteringRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApiMeteringResponse
        /// </returns>
        public async Task<DescribeApiMeteringResponse> DescribeApiMeteringAsync(DescribeApiMeteringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiMeteringWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeCurrentNodeInfo to retrieve the process information of the current node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCurrentNodeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCurrentNodeInfoResponse
        /// </returns>
        public DescribeCurrentNodeInfoResponse DescribeCurrentNodeInfoWithOptions(DescribeCurrentNodeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCurrentNodeInfo",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCurrentNodeInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeCurrentNodeInfo to retrieve the process information of the current node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCurrentNodeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCurrentNodeInfoResponse
        /// </returns>
        public async Task<DescribeCurrentNodeInfoResponse> DescribeCurrentNodeInfoWithOptionsAsync(DescribeCurrentNodeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCurrentNodeInfo",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCurrentNodeInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeCurrentNodeInfo to retrieve the process information of the current node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCurrentNodeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCurrentNodeInfoResponse
        /// </returns>
        public DescribeCurrentNodeInfoResponse DescribeCurrentNodeInfo(DescribeCurrentNodeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCurrentNodeInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeCurrentNodeInfo to retrieve the process information of the current node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCurrentNodeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCurrentNodeInfoResponse
        /// </returns>
        public async Task<DescribeCurrentNodeInfoResponse> DescribeCurrentNodeInfoAsync(DescribeCurrentNodeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCurrentNodeInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of promotional products with detailed information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call this operation by using a promotion service provider account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDistributionProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistributionProductsResponse
        /// </returns>
        public DescribeDistributionProductsResponse DescribeDistributionProductsWithOptions(DescribeDistributionProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDistributionProducts",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDistributionProductsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of promotional products with detailed information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call this operation by using a promotion service provider account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDistributionProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistributionProductsResponse
        /// </returns>
        public async Task<DescribeDistributionProductsResponse> DescribeDistributionProductsWithOptionsAsync(DescribeDistributionProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDistributionProducts",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDistributionProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of promotional products with detailed information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call this operation by using a promotion service provider account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDistributionProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistributionProductsResponse
        /// </returns>
        public DescribeDistributionProductsResponse DescribeDistributionProducts(DescribeDistributionProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDistributionProductsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of promotional products with detailed information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call this operation by using a promotion service provider account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDistributionProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistributionProductsResponse
        /// </returns>
        public async Task<DescribeDistributionProductsResponse> DescribeDistributionProductsAsync(DescribeDistributionProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDistributionProductsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves promotion links for promoted products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call this operation by using a promotion service provider account. Calls from non-promotion service provider accounts will fail.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribeDistributionProductsLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistributionProductsLinkResponse
        /// </returns>
        public DescribeDistributionProductsLinkResponse DescribeDistributionProductsLinkWithOptions(DescribeDistributionProductsLinkRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeDistributionProductsLinkShrinkRequest request = new DescribeDistributionProductsLinkShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Codes))
            {
                request.CodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Codes, "Codes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodesShrink))
            {
                query["Codes"] = request.CodesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDistributionProductsLink",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDistributionProductsLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves promotion links for promoted products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call this operation by using a promotion service provider account. Calls from non-promotion service provider accounts will fail.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribeDistributionProductsLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistributionProductsLinkResponse
        /// </returns>
        public async Task<DescribeDistributionProductsLinkResponse> DescribeDistributionProductsLinkWithOptionsAsync(DescribeDistributionProductsLinkRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeDistributionProductsLinkShrinkRequest request = new DescribeDistributionProductsLinkShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Codes))
            {
                request.CodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Codes, "Codes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodesShrink))
            {
                query["Codes"] = request.CodesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDistributionProductsLink",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDistributionProductsLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves promotion links for promoted products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call this operation by using a promotion service provider account. Calls from non-promotion service provider accounts will fail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDistributionProductsLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistributionProductsLinkResponse
        /// </returns>
        public DescribeDistributionProductsLinkResponse DescribeDistributionProductsLink(DescribeDistributionProductsLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDistributionProductsLinkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves promotion links for promoted products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call this operation by using a promotion service provider account. Calls from non-promotion service provider accounts will fail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDistributionProductsLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistributionProductsLinkResponse
        /// </returns>
        public async Task<DescribeDistributionProductsLinkResponse> DescribeDistributionProductsLinkAsync(DescribeDistributionProductsLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDistributionProductsLinkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of failed subscription notifications. After Alibaba Cloud Marketplace fails to call a service provider\&quot;s message SPI, the service provider can use this operation to proactively query the failed notification information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the information about failed subscription notifications for a service provider.</para>
        /// <list type="bullet">
        /// <item><description>If no unconfirmed failed notifications exist, TotalCount returns 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFailedNotificationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFailedNotificationsResponse
        /// </returns>
        public DescribeFailedNotificationsResponse DescribeFailedNotificationsWithOptions(DescribeFailedNotificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFailedNotifications",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFailedNotificationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of failed subscription notifications. After Alibaba Cloud Marketplace fails to call a service provider\&quot;s message SPI, the service provider can use this operation to proactively query the failed notification information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the information about failed subscription notifications for a service provider.</para>
        /// <list type="bullet">
        /// <item><description>If no unconfirmed failed notifications exist, TotalCount returns 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFailedNotificationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFailedNotificationsResponse
        /// </returns>
        public async Task<DescribeFailedNotificationsResponse> DescribeFailedNotificationsWithOptionsAsync(DescribeFailedNotificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFailedNotifications",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFailedNotificationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of failed subscription notifications. After Alibaba Cloud Marketplace fails to call a service provider\&quot;s message SPI, the service provider can use this operation to proactively query the failed notification information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the information about failed subscription notifications for a service provider.</para>
        /// <list type="bullet">
        /// <item><description>If no unconfirmed failed notifications exist, TotalCount returns 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFailedNotificationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFailedNotificationsResponse
        /// </returns>
        public DescribeFailedNotificationsResponse DescribeFailedNotifications(DescribeFailedNotificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFailedNotificationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of failed subscription notifications. After Alibaba Cloud Marketplace fails to call a service provider\&quot;s message SPI, the service provider can use this operation to proactively query the failed notification information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the information about failed subscription notifications for a service provider.</para>
        /// <list type="bullet">
        /// <item><description>If no unconfirmed failed notifications exist, TotalCount returns 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFailedNotificationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFailedNotificationsResponse
        /// </returns>
        public async Task<DescribeFailedNotificationsResponse> DescribeFailedNotificationsAsync(DescribeFailedNotificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFailedNotificationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商侧查询镜像实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageInstanceForIsvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageInstanceForIsvResponse
        /// </returns>
        public DescribeImageInstanceForIsvResponse DescribeImageInstanceForIsvWithOptions(DescribeImageInstanceForIsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPk))
            {
                query["CustomerPk"] = request.CustomerPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceId))
            {
                query["EcsInstanceId"] = request.EcsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageInstanceForIsv",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageInstanceForIsvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商侧查询镜像实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageInstanceForIsvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageInstanceForIsvResponse
        /// </returns>
        public async Task<DescribeImageInstanceForIsvResponse> DescribeImageInstanceForIsvWithOptionsAsync(DescribeImageInstanceForIsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerPk))
            {
                query["CustomerPk"] = request.CustomerPk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceId))
            {
                query["EcsInstanceId"] = request.EcsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageInstanceForIsv",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageInstanceForIsvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商侧查询镜像实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageInstanceForIsvRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageInstanceForIsvResponse
        /// </returns>
        public DescribeImageInstanceForIsvResponse DescribeImageInstanceForIsv(DescribeImageInstanceForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageInstanceForIsvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商侧查询镜像实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageInstanceForIsvRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageInstanceForIsvResponse
        /// </returns>
        public async Task<DescribeImageInstanceForIsvResponse> DescribeImageInstanceForIsvAsync(DescribeImageInstanceForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageInstanceForIsvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the DescribeInstance operation to query instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the DescribeInstance operation to query instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the DescribeInstance operation to query instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the DescribeInstance operation to query instance information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instance information from the service provider side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceForIsvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceForIsvResponse
        /// </returns>
        public DescribeInstanceForIsvResponse DescribeInstanceForIsvWithOptions(DescribeInstanceForIsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceForIsv",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceForIsvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instance information from the service provider side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceForIsvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceForIsvResponse
        /// </returns>
        public async Task<DescribeInstanceForIsvResponse> DescribeInstanceForIsvWithOptionsAsync(DescribeInstanceForIsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceForIsv",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceForIsvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instance information from the service provider side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceForIsvRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceForIsvResponse
        /// </returns>
        public DescribeInstanceForIsvResponse DescribeInstanceForIsv(DescribeInstanceForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceForIsvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instance information from the service provider side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceForIsvRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceForIsvResponse
        /// </returns>
        public async Task<DescribeInstanceForIsvResponse> DescribeInstanceForIsvAsync(DescribeInstanceForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceForIsvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of services purchased by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Codes))
            {
                query["Codes"] = request.Codes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExceptCodes))
            {
                query["ExceptCodes"] = request.ExceptCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of services purchased by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Codes))
            {
                query["Codes"] = request.Codes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExceptCodes))
            {
                query["ExceptCodes"] = request.ExceptCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of services purchased by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of services purchased by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the invoice information of a supplier store in Alibaba Cloud Marketplace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries business information based on an authorization code. The system first verifies whether the authorization code is valid.</para>
        /// <list type="bullet">
        /// <item><description>If the authorization code is invalid, an error message is returned.</description></item>
        /// <item><description>If the authorization code is valid, the authorization information is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvoiceForIsvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvoiceForIsvResponse
        /// </returns>
        public DescribeInvoiceForIsvResponse DescribeInvoiceForIsvWithOptions(DescribeInvoiceForIsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceId))
            {
                query["InvoiceId"] = request.InvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInvoiceForIsv",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInvoiceForIsvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the invoice information of a supplier store in Alibaba Cloud Marketplace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries business information based on an authorization code. The system first verifies whether the authorization code is valid.</para>
        /// <list type="bullet">
        /// <item><description>If the authorization code is invalid, an error message is returned.</description></item>
        /// <item><description>If the authorization code is valid, the authorization information is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvoiceForIsvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvoiceForIsvResponse
        /// </returns>
        public async Task<DescribeInvoiceForIsvResponse> DescribeInvoiceForIsvWithOptionsAsync(DescribeInvoiceForIsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceId))
            {
                query["InvoiceId"] = request.InvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInvoiceForIsv",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInvoiceForIsvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the invoice information of a supplier store in Alibaba Cloud Marketplace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries business information based on an authorization code. The system first verifies whether the authorization code is valid.</para>
        /// <list type="bullet">
        /// <item><description>If the authorization code is invalid, an error message is returned.</description></item>
        /// <item><description>If the authorization code is valid, the authorization information is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvoiceForIsvRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvoiceForIsvResponse
        /// </returns>
        public DescribeInvoiceForIsvResponse DescribeInvoiceForIsv(DescribeInvoiceForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvoiceForIsvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the invoice information of a supplier store in Alibaba Cloud Marketplace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries business information based on an authorization code. The system first verifies whether the authorization code is valid.</para>
        /// <list type="bullet">
        /// <item><description>If the authorization code is invalid, an error message is returned.</description></item>
        /// <item><description>If the authorization code is valid, the authorization information is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvoiceForIsvRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvoiceForIsvResponse
        /// </returns>
        public async Task<DescribeInvoiceForIsvResponse> DescribeInvoiceForIsvAsync(DescribeInvoiceForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvoiceForIsvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeLicense to query license information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLicenseResponse
        /// </returns>
        public DescribeLicenseResponse DescribeLicenseWithOptions(DescribeLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseCode))
            {
                query["LicenseCode"] = request.LicenseCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLicense",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLicenseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeLicense to query license information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLicenseResponse
        /// </returns>
        public async Task<DescribeLicenseResponse> DescribeLicenseWithOptionsAsync(DescribeLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseCode))
            {
                query["LicenseCode"] = request.LicenseCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLicense",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeLicense to query license information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLicenseResponse
        /// </returns>
        public DescribeLicenseResponse DescribeLicense(DescribeLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLicenseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeLicense to query license information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLicenseResponse
        /// </returns>
        public async Task<DescribeLicenseResponse> DescribeLicenseAsync(DescribeLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOrderResponse
        /// </returns>
        public DescribeOrderResponse DescribeOrderWithOptions(DescribeOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOrder",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOrderResponse
        /// </returns>
        public async Task<DescribeOrderResponse> DescribeOrderWithOptionsAsync(DescribeOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOrder",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOrderResponse
        /// </returns>
        public DescribeOrderResponse DescribeOrder(DescribeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOrderResponse
        /// </returns>
        public async Task<DescribeOrderResponse> DescribeOrderAsync(DescribeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries order details from the service provider side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOrderForIsvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOrderForIsvResponse
        /// </returns>
        public DescribeOrderForIsvResponse DescribeOrderForIsvWithOptions(DescribeOrderForIsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOrderForIsv",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOrderForIsvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries order details from the service provider side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOrderForIsvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOrderForIsvResponse
        /// </returns>
        public async Task<DescribeOrderForIsvResponse> DescribeOrderForIsvWithOptionsAsync(DescribeOrderForIsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOrderForIsv",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOrderForIsvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries order details from the service provider side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOrderForIsvRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOrderForIsvResponse
        /// </returns>
        public DescribeOrderForIsvResponse DescribeOrderForIsv(DescribeOrderForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOrderForIsvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries order details from the service provider side.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOrderForIsvRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOrderForIsvResponse
        /// </returns>
        public async Task<DescribeOrderForIsvResponse> DescribeOrderForIsvAsync(DescribeOrderForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOrderForIsvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribePrice to query the price information of the corresponding product.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePriceResponse
        /// </returns>
        public DescribePriceResponse DescribePriceWithOptions(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commodity))
            {
                query["Commodity"] = request.Commodity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePrice",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribePrice to query the price information of the corresponding product.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePriceResponse
        /// </returns>
        public async Task<DescribePriceResponse> DescribePriceWithOptionsAsync(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Commodity))
            {
                query["Commodity"] = request.Commodity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePrice",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribePrice to query the price information of the corresponding product.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePriceResponse
        /// </returns>
        public DescribePriceResponse DescribePrice(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribePrice to query the price information of the corresponding product.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePriceResponse
        /// </returns>
        public async Task<DescribePriceResponse> DescribePriceAsync(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified product by calling DescribeProduct.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductResponse
        /// </returns>
        public DescribeProductResponse DescribeProductWithOptions(DescribeProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDraft))
            {
                query["QueryDraft"] = request.QueryDraft;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProduct",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified product by calling DescribeProduct.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductResponse
        /// </returns>
        public async Task<DescribeProductResponse> DescribeProductWithOptionsAsync(DescribeProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDraft))
            {
                query["QueryDraft"] = request.QueryDraft;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProduct",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified product by calling DescribeProduct.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProductRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductResponse
        /// </returns>
        public DescribeProductResponse DescribeProduct(DescribeProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified product by calling DescribeProduct.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProductRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductResponse
        /// </returns>
        public async Task<DescribeProductResponse> DescribeProductAsync(DescribeProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of products that meet the specified conditions along with their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductsResponse
        /// </returns>
        public DescribeProductsResponse DescribeProductsWithOptions(DescribeProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchTerm))
            {
                query["SearchTerm"] = request.SearchTerm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProducts",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of products that meet the specified conditions along with their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProductsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductsResponse
        /// </returns>
        public async Task<DescribeProductsResponse> DescribeProductsWithOptionsAsync(DescribeProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchTerm))
            {
                query["SearchTerm"] = request.SearchTerm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProducts",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of products that meet the specified conditions along with their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductsResponse
        /// </returns>
        public DescribeProductsResponse DescribeProducts(DescribeProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of products that meet the specified conditions along with their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductsResponse
        /// </returns>
        public async Task<DescribeProductsResponse> DescribeProductsAsync(DescribeProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectAttachments to retrieve the list of project attachments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectAttachmentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectAttachmentsResponse
        /// </returns>
        public DescribeProjectAttachmentsResponse DescribeProjectAttachmentsWithOptions(DescribeProjectAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectAttachments",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectAttachmentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectAttachments to retrieve the list of project attachments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectAttachmentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectAttachmentsResponse
        /// </returns>
        public async Task<DescribeProjectAttachmentsResponse> DescribeProjectAttachmentsWithOptionsAsync(DescribeProjectAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectAttachments",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectAttachmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectAttachments to retrieve the list of project attachments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectAttachmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectAttachmentsResponse
        /// </returns>
        public DescribeProjectAttachmentsResponse DescribeProjectAttachments(DescribeProjectAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectAttachmentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectAttachments to retrieve the list of project attachments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectAttachmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectAttachmentsResponse
        /// </returns>
        public async Task<DescribeProjectAttachmentsResponse> DescribeProjectAttachmentsAsync(DescribeProjectAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectAttachmentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectInfo to query project information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectInfoResponse
        /// </returns>
        public DescribeProjectInfoResponse DescribeProjectInfoWithOptions(DescribeProjectInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectInfo",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectInfo to query project information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectInfoResponse
        /// </returns>
        public async Task<DescribeProjectInfoResponse> DescribeProjectInfoWithOptionsAsync(DescribeProjectInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectInfo",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectInfo to query project information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectInfoResponse
        /// </returns>
        public DescribeProjectInfoResponse DescribeProjectInfo(DescribeProjectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectInfo to query project information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectInfoResponse
        /// </returns>
        public async Task<DescribeProjectInfoResponse> DescribeProjectInfoAsync(DescribeProjectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectMessages to retrieve the list of project workflow messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectMessagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectMessagesResponse
        /// </returns>
        public DescribeProjectMessagesResponse DescribeProjectMessagesWithOptions(DescribeProjectMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectMessages",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectMessagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectMessages to retrieve the list of project workflow messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectMessagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectMessagesResponse
        /// </returns>
        public async Task<DescribeProjectMessagesResponse> DescribeProjectMessagesWithOptionsAsync(DescribeProjectMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectMessages",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectMessagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectMessages to retrieve the list of project workflow messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectMessagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectMessagesResponse
        /// </returns>
        public DescribeProjectMessagesResponse DescribeProjectMessages(DescribeProjectMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectMessagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectMessages to retrieve the list of project workflow messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectMessagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectMessagesResponse
        /// </returns>
        public async Task<DescribeProjectMessagesResponse> DescribeProjectMessagesAsync(DescribeProjectMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectMessagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of project flow nodes by calling DescribeProjectNodes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProjectNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectNodesResponse
        /// </returns>
        public DescribeProjectNodesResponse DescribeProjectNodesWithOptions(DescribeProjectNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectNodes",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of project flow nodes by calling DescribeProjectNodes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProjectNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectNodesResponse
        /// </returns>
        public async Task<DescribeProjectNodesResponse> DescribeProjectNodesWithOptionsAsync(DescribeProjectNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectNodes",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of project flow nodes by calling DescribeProjectNodes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProjectNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectNodesResponse
        /// </returns>
        public DescribeProjectNodesResponse DescribeProjectNodes(DescribeProjectNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of project flow nodes by calling DescribeProjectNodes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProjectNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectNodesResponse
        /// </returns>
        public async Task<DescribeProjectNodesResponse> DescribeProjectNodesAsync(DescribeProjectNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectOperateLogs to retrieve the operation logs of a project flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProjectOperateLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectOperateLogsResponse
        /// </returns>
        public DescribeProjectOperateLogsResponse DescribeProjectOperateLogsWithOptions(DescribeProjectOperateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectOperateLogs",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectOperateLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectOperateLogs to retrieve the operation logs of a project flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProjectOperateLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectOperateLogsResponse
        /// </returns>
        public async Task<DescribeProjectOperateLogsResponse> DescribeProjectOperateLogsWithOptionsAsync(DescribeProjectOperateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectOperateLogs",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectOperateLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectOperateLogs to retrieve the operation logs of a project flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProjectOperateLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectOperateLogsResponse
        /// </returns>
        public DescribeProjectOperateLogsResponse DescribeProjectOperateLogs(DescribeProjectOperateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectOperateLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls DescribeProjectOperateLogs to retrieve the operation logs of a project flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProjectOperateLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectOperateLogsResponse
        /// </returns>
        public async Task<DescribeProjectOperateLogsResponse> DescribeProjectOperateLogsAsync(DescribeProjectOperateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectOperateLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Completes the current process by calling FinishCurrentProjectNode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FinishCurrentProjectNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FinishCurrentProjectNodeResponse
        /// </returns>
        public FinishCurrentProjectNodeResponse FinishCurrentProjectNodeWithOptions(FinishCurrentProjectNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateForm))
            {
                query["TemplateForm"] = request.TemplateForm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishCurrentProjectNode",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishCurrentProjectNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Completes the current process by calling FinishCurrentProjectNode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FinishCurrentProjectNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FinishCurrentProjectNodeResponse
        /// </returns>
        public async Task<FinishCurrentProjectNodeResponse> FinishCurrentProjectNodeWithOptionsAsync(FinishCurrentProjectNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateForm))
            {
                query["TemplateForm"] = request.TemplateForm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishCurrentProjectNode",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishCurrentProjectNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Completes the current process by calling FinishCurrentProjectNode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FinishCurrentProjectNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// FinishCurrentProjectNodeResponse
        /// </returns>
        public FinishCurrentProjectNodeResponse FinishCurrentProjectNode(FinishCurrentProjectNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FinishCurrentProjectNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Completes the current process by calling FinishCurrentProjectNode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// FinishCurrentProjectNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// FinishCurrentProjectNodeResponse
        /// </returns>
        public async Task<FinishCurrentProjectNodeResponse> FinishCurrentProjectNodeAsync(FinishCurrentProjectNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FinishCurrentProjectNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Processes invoice acceptance requests.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries information about failed subscription notifications for merchants.</para>
        /// <list type="bullet">
        /// <item><description>If no unconfirmed notification failure information exists, TotalCount returns 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInvoiceForIsvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInvoiceForIsvResponse
        /// </returns>
        public ModifyInvoiceForIsvResponse ModifyInvoiceForIsvWithOptions(ModifyInvoiceForIsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckNotice))
            {
                query["CheckNotice"] = request.CheckNotice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElectronUrl))
            {
                query["ElectronUrl"] = request.ElectronUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceId))
            {
                query["InvoiceId"] = request.InvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
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
                Action = "ModifyInvoiceForIsv",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInvoiceForIsvResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Processes invoice acceptance requests.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries information about failed subscription notifications for merchants.</para>
        /// <list type="bullet">
        /// <item><description>If no unconfirmed notification failure information exists, TotalCount returns 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInvoiceForIsvRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInvoiceForIsvResponse
        /// </returns>
        public async Task<ModifyInvoiceForIsvResponse> ModifyInvoiceForIsvWithOptionsAsync(ModifyInvoiceForIsvRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckNotice))
            {
                query["CheckNotice"] = request.CheckNotice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElectronUrl))
            {
                query["ElectronUrl"] = request.ElectronUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceId))
            {
                query["InvoiceId"] = request.InvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
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
                Action = "ModifyInvoiceForIsv",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInvoiceForIsvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Processes invoice acceptance requests.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries information about failed subscription notifications for merchants.</para>
        /// <list type="bullet">
        /// <item><description>If no unconfirmed notification failure information exists, TotalCount returns 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInvoiceForIsvRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInvoiceForIsvResponse
        /// </returns>
        public ModifyInvoiceForIsvResponse ModifyInvoiceForIsv(ModifyInvoiceForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInvoiceForIsvWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Processes invoice acceptance requests.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries information about failed subscription notifications for merchants.</para>
        /// <list type="bullet">
        /// <item><description>If no unconfirmed notification failure information exists, TotalCount returns 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInvoiceForIsvRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInvoiceForIsvResponse
        /// </returns>
        public async Task<ModifyInvoiceForIsvResponse> ModifyInvoiceForIsvAsync(ModifyInvoiceForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInvoiceForIsvWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls PauseProject to pause a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseProjectResponse
        /// </returns>
        public PauseProjectResponse PauseProjectWithOptions(PauseProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseProject",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls PauseProject to pause a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseProjectResponse
        /// </returns>
        public async Task<PauseProjectResponse> PauseProjectWithOptionsAsync(PauseProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseProject",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls PauseProject to pause a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// PauseProjectResponse
        /// </returns>
        public PauseProjectResponse PauseProject(PauseProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PauseProjectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls PauseProject to pause a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// PauseProjectResponse
        /// </returns>
        public async Task<PauseProjectResponse> PauseProjectAsync(PauseProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PauseProjectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call PushMeteringData to push metering data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Encoding and Format Requirements</h3>
        /// <list type="bullet">
        /// <item><description>All request parameters must be URLEncoded.</description></item>
        /// <item><description>The Metering field in the parameters must strictly follow the format in the example in this document. It has been found that many submissions are not valid JSON. Please verify the format with a JSON formatting tool before submission, otherwise the API call will fail.</description></item>
        /// </list>
        /// <h3>Request Frequency and Single Write Volume Limits</h3>
        /// <list type="bullet">
        /// <item><description>For hourly/daily metering: Cloud Marketplace limits requests for each InstanceId to once per 60 seconds, and each request supports writing up to 100 metering data entries.</description></item>
        /// <item><description>For real-time metering (for large model usage scenarios): Cloud Marketplace has no frequency limit for each InstanceId, and each request supports writing up to 10 metering data entries.</description></item>
        /// </list>
        /// <h3>Batch Push Limits for Metering Data</h3>
        /// <list type="bullet">
        /// <item><description>Cross-product InstanceId batch pushing is not supported. When batch pushing, ensure all InstanceIds belong to the same product.</description></item>
        /// <item><description>When batch pushing metering data, the &quot;InstanceId&quot; attribute must belong to instances generated by the same product. Pushing instances from multiple products simultaneously is currently not supported.</description></item>
        /// </list>
        /// <h3>Time Requirements for Metering Data Push</h3>
        /// <list type="bullet">
        /// <item><description>For products billed by the hour, the billing deadline is the next hour, and metering data must be pushed on time. For example, if the metering data is for 8:10-08:20, it must be pushed before 9:59, otherwise billing will not occur. The rule for daily billing is similar: the previous day\&quot;s data must be pushed before 1:59 of the next day, otherwise the metering push will return an error and billing will not occur.</description></item>
        /// <item><description>For products billed by the minute, real-time pushed data is aggregated by the minute and billed by the minute.</description></item>
        /// <item><description>If the product is set to real-time billing, StartTime and EndTime can have any time span, but EndTime must be greater than StartTime.</description></item>
        /// <item><description>If the product is set to non-real-time billing (i.e., hourly, daily, etc.), the interval between StartTime and EndTime must be greater than 5 minutes.</description></item>
        /// </list>
        /// <h3>Timeliness of Pushing and Billing</h3>
        /// <list type="bullet">
        /// <item><description>If the instance status has expired, metering data pushed after the instance expiration will not be billed. For example, if the instance expired at 2025-07-09 12:20:00, metering data pushed for the period 2025-07-09 13:00:00-2025-07-09 14:00:00 will not be billed. Metering data for the period 2025-07-09 12:00:00-2025-07-09 13:00:00 can still be billed normally.</description></item>
        /// <item><description>After pushing metering data, billing does not occur immediately. For hourly billing, bills are generated in the next time interval. For example, for hourly billing, the bill for 8:00-9:00 is generated after 10:00. For daily billing, bills are generated the next day. After billing, customers can view the bills in <a href="https://billing-cost.console.aliyun.com/finance/expense-report/expense-detail-by-instance">Alibaba Cloud Bill Details</a>.</description></item>
        /// </list>
        /// <h3>Amount Rounding to Zero</h3>
        /// <list type="bullet">
        /// <item><description>If the bill amount is too small and the single bill amount is less than 0.01 CNY, the bill amount on the buyer\&quot;s side will be 0. For example, if the product unit price is 0.001 CNY/count and is billed by the minute with 9 uses per minute, the bill amount per minute is 0. If billed by the hour and the single hourly bill amount is less than 0.01, the buyer\&quot;s bill amount will be 0. The probability of minute-level billing amounts being rounded to zero may be higher than that of hourly billing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMeteringDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushMeteringDataResponse
        /// </returns>
        public PushMeteringDataResponse PushMeteringDataWithOptions(PushMeteringDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metering))
            {
                query["Metering"] = request.Metering;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMeteringData",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMeteringDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call PushMeteringData to push metering data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Encoding and Format Requirements</h3>
        /// <list type="bullet">
        /// <item><description>All request parameters must be URLEncoded.</description></item>
        /// <item><description>The Metering field in the parameters must strictly follow the format in the example in this document. It has been found that many submissions are not valid JSON. Please verify the format with a JSON formatting tool before submission, otherwise the API call will fail.</description></item>
        /// </list>
        /// <h3>Request Frequency and Single Write Volume Limits</h3>
        /// <list type="bullet">
        /// <item><description>For hourly/daily metering: Cloud Marketplace limits requests for each InstanceId to once per 60 seconds, and each request supports writing up to 100 metering data entries.</description></item>
        /// <item><description>For real-time metering (for large model usage scenarios): Cloud Marketplace has no frequency limit for each InstanceId, and each request supports writing up to 10 metering data entries.</description></item>
        /// </list>
        /// <h3>Batch Push Limits for Metering Data</h3>
        /// <list type="bullet">
        /// <item><description>Cross-product InstanceId batch pushing is not supported. When batch pushing, ensure all InstanceIds belong to the same product.</description></item>
        /// <item><description>When batch pushing metering data, the &quot;InstanceId&quot; attribute must belong to instances generated by the same product. Pushing instances from multiple products simultaneously is currently not supported.</description></item>
        /// </list>
        /// <h3>Time Requirements for Metering Data Push</h3>
        /// <list type="bullet">
        /// <item><description>For products billed by the hour, the billing deadline is the next hour, and metering data must be pushed on time. For example, if the metering data is for 8:10-08:20, it must be pushed before 9:59, otherwise billing will not occur. The rule for daily billing is similar: the previous day\&quot;s data must be pushed before 1:59 of the next day, otherwise the metering push will return an error and billing will not occur.</description></item>
        /// <item><description>For products billed by the minute, real-time pushed data is aggregated by the minute and billed by the minute.</description></item>
        /// <item><description>If the product is set to real-time billing, StartTime and EndTime can have any time span, but EndTime must be greater than StartTime.</description></item>
        /// <item><description>If the product is set to non-real-time billing (i.e., hourly, daily, etc.), the interval between StartTime and EndTime must be greater than 5 minutes.</description></item>
        /// </list>
        /// <h3>Timeliness of Pushing and Billing</h3>
        /// <list type="bullet">
        /// <item><description>If the instance status has expired, metering data pushed after the instance expiration will not be billed. For example, if the instance expired at 2025-07-09 12:20:00, metering data pushed for the period 2025-07-09 13:00:00-2025-07-09 14:00:00 will not be billed. Metering data for the period 2025-07-09 12:00:00-2025-07-09 13:00:00 can still be billed normally.</description></item>
        /// <item><description>After pushing metering data, billing does not occur immediately. For hourly billing, bills are generated in the next time interval. For example, for hourly billing, the bill for 8:00-9:00 is generated after 10:00. For daily billing, bills are generated the next day. After billing, customers can view the bills in <a href="https://billing-cost.console.aliyun.com/finance/expense-report/expense-detail-by-instance">Alibaba Cloud Bill Details</a>.</description></item>
        /// </list>
        /// <h3>Amount Rounding to Zero</h3>
        /// <list type="bullet">
        /// <item><description>If the bill amount is too small and the single bill amount is less than 0.01 CNY, the bill amount on the buyer\&quot;s side will be 0. For example, if the product unit price is 0.001 CNY/count and is billed by the minute with 9 uses per minute, the bill amount per minute is 0. If billed by the hour and the single hourly bill amount is less than 0.01, the buyer\&quot;s bill amount will be 0. The probability of minute-level billing amounts being rounded to zero may be higher than that of hourly billing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMeteringDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushMeteringDataResponse
        /// </returns>
        public async Task<PushMeteringDataResponse> PushMeteringDataWithOptionsAsync(PushMeteringDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metering))
            {
                query["Metering"] = request.Metering;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMeteringData",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMeteringDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call PushMeteringData to push metering data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Encoding and Format Requirements</h3>
        /// <list type="bullet">
        /// <item><description>All request parameters must be URLEncoded.</description></item>
        /// <item><description>The Metering field in the parameters must strictly follow the format in the example in this document. It has been found that many submissions are not valid JSON. Please verify the format with a JSON formatting tool before submission, otherwise the API call will fail.</description></item>
        /// </list>
        /// <h3>Request Frequency and Single Write Volume Limits</h3>
        /// <list type="bullet">
        /// <item><description>For hourly/daily metering: Cloud Marketplace limits requests for each InstanceId to once per 60 seconds, and each request supports writing up to 100 metering data entries.</description></item>
        /// <item><description>For real-time metering (for large model usage scenarios): Cloud Marketplace has no frequency limit for each InstanceId, and each request supports writing up to 10 metering data entries.</description></item>
        /// </list>
        /// <h3>Batch Push Limits for Metering Data</h3>
        /// <list type="bullet">
        /// <item><description>Cross-product InstanceId batch pushing is not supported. When batch pushing, ensure all InstanceIds belong to the same product.</description></item>
        /// <item><description>When batch pushing metering data, the &quot;InstanceId&quot; attribute must belong to instances generated by the same product. Pushing instances from multiple products simultaneously is currently not supported.</description></item>
        /// </list>
        /// <h3>Time Requirements for Metering Data Push</h3>
        /// <list type="bullet">
        /// <item><description>For products billed by the hour, the billing deadline is the next hour, and metering data must be pushed on time. For example, if the metering data is for 8:10-08:20, it must be pushed before 9:59, otherwise billing will not occur. The rule for daily billing is similar: the previous day\&quot;s data must be pushed before 1:59 of the next day, otherwise the metering push will return an error and billing will not occur.</description></item>
        /// <item><description>For products billed by the minute, real-time pushed data is aggregated by the minute and billed by the minute.</description></item>
        /// <item><description>If the product is set to real-time billing, StartTime and EndTime can have any time span, but EndTime must be greater than StartTime.</description></item>
        /// <item><description>If the product is set to non-real-time billing (i.e., hourly, daily, etc.), the interval between StartTime and EndTime must be greater than 5 minutes.</description></item>
        /// </list>
        /// <h3>Timeliness of Pushing and Billing</h3>
        /// <list type="bullet">
        /// <item><description>If the instance status has expired, metering data pushed after the instance expiration will not be billed. For example, if the instance expired at 2025-07-09 12:20:00, metering data pushed for the period 2025-07-09 13:00:00-2025-07-09 14:00:00 will not be billed. Metering data for the period 2025-07-09 12:00:00-2025-07-09 13:00:00 can still be billed normally.</description></item>
        /// <item><description>After pushing metering data, billing does not occur immediately. For hourly billing, bills are generated in the next time interval. For example, for hourly billing, the bill for 8:00-9:00 is generated after 10:00. For daily billing, bills are generated the next day. After billing, customers can view the bills in <a href="https://billing-cost.console.aliyun.com/finance/expense-report/expense-detail-by-instance">Alibaba Cloud Bill Details</a>.</description></item>
        /// </list>
        /// <h3>Amount Rounding to Zero</h3>
        /// <list type="bullet">
        /// <item><description>If the bill amount is too small and the single bill amount is less than 0.01 CNY, the bill amount on the buyer\&quot;s side will be 0. For example, if the product unit price is 0.001 CNY/count and is billed by the minute with 9 uses per minute, the bill amount per minute is 0. If billed by the hour and the single hourly bill amount is less than 0.01, the buyer\&quot;s bill amount will be 0. The probability of minute-level billing amounts being rounded to zero may be higher than that of hourly billing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMeteringDataRequest
        /// </param>
        /// 
        /// <returns>
        /// PushMeteringDataResponse
        /// </returns>
        public PushMeteringDataResponse PushMeteringData(PushMeteringDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMeteringDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call PushMeteringData to push metering data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Encoding and Format Requirements</h3>
        /// <list type="bullet">
        /// <item><description>All request parameters must be URLEncoded.</description></item>
        /// <item><description>The Metering field in the parameters must strictly follow the format in the example in this document. It has been found that many submissions are not valid JSON. Please verify the format with a JSON formatting tool before submission, otherwise the API call will fail.</description></item>
        /// </list>
        /// <h3>Request Frequency and Single Write Volume Limits</h3>
        /// <list type="bullet">
        /// <item><description>For hourly/daily metering: Cloud Marketplace limits requests for each InstanceId to once per 60 seconds, and each request supports writing up to 100 metering data entries.</description></item>
        /// <item><description>For real-time metering (for large model usage scenarios): Cloud Marketplace has no frequency limit for each InstanceId, and each request supports writing up to 10 metering data entries.</description></item>
        /// </list>
        /// <h3>Batch Push Limits for Metering Data</h3>
        /// <list type="bullet">
        /// <item><description>Cross-product InstanceId batch pushing is not supported. When batch pushing, ensure all InstanceIds belong to the same product.</description></item>
        /// <item><description>When batch pushing metering data, the &quot;InstanceId&quot; attribute must belong to instances generated by the same product. Pushing instances from multiple products simultaneously is currently not supported.</description></item>
        /// </list>
        /// <h3>Time Requirements for Metering Data Push</h3>
        /// <list type="bullet">
        /// <item><description>For products billed by the hour, the billing deadline is the next hour, and metering data must be pushed on time. For example, if the metering data is for 8:10-08:20, it must be pushed before 9:59, otherwise billing will not occur. The rule for daily billing is similar: the previous day\&quot;s data must be pushed before 1:59 of the next day, otherwise the metering push will return an error and billing will not occur.</description></item>
        /// <item><description>For products billed by the minute, real-time pushed data is aggregated by the minute and billed by the minute.</description></item>
        /// <item><description>If the product is set to real-time billing, StartTime and EndTime can have any time span, but EndTime must be greater than StartTime.</description></item>
        /// <item><description>If the product is set to non-real-time billing (i.e., hourly, daily, etc.), the interval between StartTime and EndTime must be greater than 5 minutes.</description></item>
        /// </list>
        /// <h3>Timeliness of Pushing and Billing</h3>
        /// <list type="bullet">
        /// <item><description>If the instance status has expired, metering data pushed after the instance expiration will not be billed. For example, if the instance expired at 2025-07-09 12:20:00, metering data pushed for the period 2025-07-09 13:00:00-2025-07-09 14:00:00 will not be billed. Metering data for the period 2025-07-09 12:00:00-2025-07-09 13:00:00 can still be billed normally.</description></item>
        /// <item><description>After pushing metering data, billing does not occur immediately. For hourly billing, bills are generated in the next time interval. For example, for hourly billing, the bill for 8:00-9:00 is generated after 10:00. For daily billing, bills are generated the next day. After billing, customers can view the bills in <a href="https://billing-cost.console.aliyun.com/finance/expense-report/expense-detail-by-instance">Alibaba Cloud Bill Details</a>.</description></item>
        /// </list>
        /// <h3>Amount Rounding to Zero</h3>
        /// <list type="bullet">
        /// <item><description>If the bill amount is too small and the single bill amount is less than 0.01 CNY, the bill amount on the buyer\&quot;s side will be 0. For example, if the product unit price is 0.001 CNY/count and is billed by the minute with 9 uses per minute, the bill amount per minute is 0. If billed by the hour and the single hourly bill amount is less than 0.01, the buyer\&quot;s bill amount will be 0. The probability of minute-level billing amounts being rounded to zero may be higher than that of hourly billing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PushMeteringDataRequest
        /// </param>
        /// 
        /// <returns>
        /// PushMeteringDataResponse
        /// </returns>
        public async Task<PushMeteringDataResponse> PushMeteringDataAsync(PushMeteringDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMeteringDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes usage deduction for a prepaid per-use product to Alibaba Cloud Marketplace on behalf of a service provider.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation applies to prepaid per-use products. Service providers can call this operation to push usage deductions to Alibaba Cloud Marketplace.</description></item>
        /// <item><description>The operation uses a forced update mode that directly deducts the specified number of uses. The caller must determine whether the user\&quot;s usage exceeds the quota.</description></item>
        /// <item><description>All request parameters must be URL-encoded.</description></item>
        /// <item><description>Use the <c>ClientToken</c> parameter for idempotency control. The same <c>ClientToken</c> cannot be submitted more than once within 24 hours.</description></item>
        /// <item><description>Retries for the same deduction operation must use the same <c>ClientToken</c>. Use a new <c>ClientToken</c> for new business operations.</description></item>
        /// <item><description>If the previous request succeeded (even if no response was received due to a gateway timeout), retrying with the same <c>ClientToken</c> returns a success response idempotently without duplicate deductions.</description></item>
        /// <item><description>If the result of the previous request is undetermined (in PROCESSING state), retrying with the same <c>ClientToken</c> returns a <c>DuplicateClientToken</c> error. Retry later or contact Alibaba Cloud Marketplace to confirm the push status.</description></item>
        /// <item><description>Only one operation can be executed at a time for the same <c>InstanceId</c>. Concurrent requests return a <c>Throttling</c> error. Retry later.</description></item>
        /// <item><description>You can run this operation in <a href="https://api.aliyun.com/#product=Market&api=PushTimesUsage&type=RPC&version=2015-11-01">OpenAPI Explorer</a> without calculating signatures.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PushTimesUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushTimesUsageResponse
        /// </returns>
        public PushTimesUsageResponse PushTimesUsageWithOptions(PushTimesUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adjust))
            {
                query["Adjust"] = request.Adjust;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustDate))
            {
                query["AdjustDate"] = request.AdjustDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mark))
            {
                query["Mark"] = request.Mark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Times))
            {
                query["Times"] = request.Times;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushTimesUsage",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushTimesUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes usage deduction for a prepaid per-use product to Alibaba Cloud Marketplace on behalf of a service provider.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation applies to prepaid per-use products. Service providers can call this operation to push usage deductions to Alibaba Cloud Marketplace.</description></item>
        /// <item><description>The operation uses a forced update mode that directly deducts the specified number of uses. The caller must determine whether the user\&quot;s usage exceeds the quota.</description></item>
        /// <item><description>All request parameters must be URL-encoded.</description></item>
        /// <item><description>Use the <c>ClientToken</c> parameter for idempotency control. The same <c>ClientToken</c> cannot be submitted more than once within 24 hours.</description></item>
        /// <item><description>Retries for the same deduction operation must use the same <c>ClientToken</c>. Use a new <c>ClientToken</c> for new business operations.</description></item>
        /// <item><description>If the previous request succeeded (even if no response was received due to a gateway timeout), retrying with the same <c>ClientToken</c> returns a success response idempotently without duplicate deductions.</description></item>
        /// <item><description>If the result of the previous request is undetermined (in PROCESSING state), retrying with the same <c>ClientToken</c> returns a <c>DuplicateClientToken</c> error. Retry later or contact Alibaba Cloud Marketplace to confirm the push status.</description></item>
        /// <item><description>Only one operation can be executed at a time for the same <c>InstanceId</c>. Concurrent requests return a <c>Throttling</c> error. Retry later.</description></item>
        /// <item><description>You can run this operation in <a href="https://api.aliyun.com/#product=Market&api=PushTimesUsage&type=RPC&version=2015-11-01">OpenAPI Explorer</a> without calculating signatures.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PushTimesUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushTimesUsageResponse
        /// </returns>
        public async Task<PushTimesUsageResponse> PushTimesUsageWithOptionsAsync(PushTimesUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Adjust))
            {
                query["Adjust"] = request.Adjust;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustDate))
            {
                query["AdjustDate"] = request.AdjustDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mark))
            {
                query["Mark"] = request.Mark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Times))
            {
                query["Times"] = request.Times;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushTimesUsage",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushTimesUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes usage deduction for a prepaid per-use product to Alibaba Cloud Marketplace on behalf of a service provider.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation applies to prepaid per-use products. Service providers can call this operation to push usage deductions to Alibaba Cloud Marketplace.</description></item>
        /// <item><description>The operation uses a forced update mode that directly deducts the specified number of uses. The caller must determine whether the user\&quot;s usage exceeds the quota.</description></item>
        /// <item><description>All request parameters must be URL-encoded.</description></item>
        /// <item><description>Use the <c>ClientToken</c> parameter for idempotency control. The same <c>ClientToken</c> cannot be submitted more than once within 24 hours.</description></item>
        /// <item><description>Retries for the same deduction operation must use the same <c>ClientToken</c>. Use a new <c>ClientToken</c> for new business operations.</description></item>
        /// <item><description>If the previous request succeeded (even if no response was received due to a gateway timeout), retrying with the same <c>ClientToken</c> returns a success response idempotently without duplicate deductions.</description></item>
        /// <item><description>If the result of the previous request is undetermined (in PROCESSING state), retrying with the same <c>ClientToken</c> returns a <c>DuplicateClientToken</c> error. Retry later or contact Alibaba Cloud Marketplace to confirm the push status.</description></item>
        /// <item><description>Only one operation can be executed at a time for the same <c>InstanceId</c>. Concurrent requests return a <c>Throttling</c> error. Retry later.</description></item>
        /// <item><description>You can run this operation in <a href="https://api.aliyun.com/#product=Market&api=PushTimesUsage&type=RPC&version=2015-11-01">OpenAPI Explorer</a> without calculating signatures.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PushTimesUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushTimesUsageResponse
        /// </returns>
        public PushTimesUsageResponse PushTimesUsage(PushTimesUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushTimesUsageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pushes usage deduction for a prepaid per-use product to Alibaba Cloud Marketplace on behalf of a service provider.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation applies to prepaid per-use products. Service providers can call this operation to push usage deductions to Alibaba Cloud Marketplace.</description></item>
        /// <item><description>The operation uses a forced update mode that directly deducts the specified number of uses. The caller must determine whether the user\&quot;s usage exceeds the quota.</description></item>
        /// <item><description>All request parameters must be URL-encoded.</description></item>
        /// <item><description>Use the <c>ClientToken</c> parameter for idempotency control. The same <c>ClientToken</c> cannot be submitted more than once within 24 hours.</description></item>
        /// <item><description>Retries for the same deduction operation must use the same <c>ClientToken</c>. Use a new <c>ClientToken</c> for new business operations.</description></item>
        /// <item><description>If the previous request succeeded (even if no response was received due to a gateway timeout), retrying with the same <c>ClientToken</c> returns a success response idempotently without duplicate deductions.</description></item>
        /// <item><description>If the result of the previous request is undetermined (in PROCESSING state), retrying with the same <c>ClientToken</c> returns a <c>DuplicateClientToken</c> error. Retry later or contact Alibaba Cloud Marketplace to confirm the push status.</description></item>
        /// <item><description>Only one operation can be executed at a time for the same <c>InstanceId</c>. Concurrent requests return a <c>Throttling</c> error. Retry later.</description></item>
        /// <item><description>You can run this operation in <a href="https://api.aliyun.com/#product=Market&api=PushTimesUsage&type=RPC&version=2015-11-01">OpenAPI Explorer</a> without calculating signatures.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PushTimesUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushTimesUsageResponse
        /// </returns>
        public async Task<PushTimesUsageResponse> PushTimesUsageAsync(PushTimesUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushTimesUsageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls ResumeProject to resume a paused project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResumeProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeProjectResponse
        /// </returns>
        public ResumeProjectResponse ResumeProjectWithOptions(ResumeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeProject",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls ResumeProject to resume a paused project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResumeProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeProjectResponse
        /// </returns>
        public async Task<ResumeProjectResponse> ResumeProjectWithOptionsAsync(ResumeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeProject",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls ResumeProject to resume a paused project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResumeProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeProjectResponse
        /// </returns>
        public ResumeProjectResponse ResumeProject(ResumeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeProjectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls ResumeProject to resume a paused project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResumeProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeProjectResponse
        /// </returns>
        public async Task<ResumeProjectResponse> ResumeProjectAsync(ResumeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeProjectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a rejection of the current process node by calling RollbackCurrentProjectNode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RollbackCurrentProjectNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackCurrentProjectNodeResponse
        /// </returns>
        public RollbackCurrentProjectNodeResponse RollbackCurrentProjectNodeWithOptions(RollbackCurrentProjectNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackCurrentProjectNode",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackCurrentProjectNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a rejection of the current process node by calling RollbackCurrentProjectNode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RollbackCurrentProjectNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackCurrentProjectNodeResponse
        /// </returns>
        public async Task<RollbackCurrentProjectNodeResponse> RollbackCurrentProjectNodeWithOptionsAsync(RollbackCurrentProjectNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackCurrentProjectNode",
                Version = "2015-11-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackCurrentProjectNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a rejection of the current process node by calling RollbackCurrentProjectNode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RollbackCurrentProjectNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackCurrentProjectNodeResponse
        /// </returns>
        public RollbackCurrentProjectNodeResponse RollbackCurrentProjectNode(RollbackCurrentProjectNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackCurrentProjectNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a rejection of the current process node by calling RollbackCurrentProjectNode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>**.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RollbackCurrentProjectNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackCurrentProjectNodeResponse
        /// </returns>
        public async Task<RollbackCurrentProjectNodeResponse> RollbackCurrentProjectNodeAsync(RollbackCurrentProjectNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackCurrentProjectNodeWithOptionsAsync(request, runtime);
        }

    }
}
