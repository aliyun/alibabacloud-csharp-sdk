// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.XgipPop20220520.Models;

namespace AlibabaCloud.SDK.XgipPop20220520
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("xgippop", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>订购qos云产品服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderQosProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrderQosProductResponse
        /// </returns>
        public OrderQosProductResponse OrderQosProductWithOptions(OrderQosProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provice))
            {
                query["Provice"] = request.Provice;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                body["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IPv6))
            {
                body["IPv6"] = request.IPv6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpType))
            {
                body["IpType"] = request.IpType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNumber))
            {
                body["MobileNumber"] = request.MobileNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpv4))
            {
                body["PrivateIpv4"] = request.PrivateIpv4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIpv4))
            {
                body["PublicIpv4"] = request.PublicIpv4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosRequestId))
            {
                body["QosRequestId"] = request.QosRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIpList))
            {
                body["TargetIpList"] = request.TargetIpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitNum))
            {
                body["UnitNum"] = request.UnitNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrderQosProduct",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrderQosProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订购qos云产品服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderQosProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrderQosProductResponse
        /// </returns>
        public async Task<OrderQosProductResponse> OrderQosProductWithOptionsAsync(OrderQosProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provice))
            {
                query["Provice"] = request.Provice;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                body["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                body["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IPv6))
            {
                body["IPv6"] = request.IPv6;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpType))
            {
                body["IpType"] = request.IpType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNumber))
            {
                body["MobileNumber"] = request.MobileNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpv4))
            {
                body["PrivateIpv4"] = request.PrivateIpv4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIpv4))
            {
                body["PublicIpv4"] = request.PublicIpv4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosRequestId))
            {
                body["QosRequestId"] = request.QosRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIpList))
            {
                body["TargetIpList"] = request.TargetIpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitNum))
            {
                body["UnitNum"] = request.UnitNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrderQosProduct",
                Version = "2022-05-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrderQosProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订购qos云产品服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderQosProductRequest
        /// </param>
        /// 
        /// <returns>
        /// OrderQosProductResponse
        /// </returns>
        public OrderQosProductResponse OrderQosProduct(OrderQosProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OrderQosProductWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订购qos云产品服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderQosProductRequest
        /// </param>
        /// 
        /// <returns>
        /// OrderQosProductResponse
        /// </returns>
        public async Task<OrderQosProductResponse> OrderQosProductAsync(OrderQosProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OrderQosProductWithOptionsAsync(request, runtime);
        }

    }
}
