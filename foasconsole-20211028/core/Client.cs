// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Foasconsole20211028.Models;

namespace AlibabaCloud.SDK.Foasconsole20211028
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "foasconsole.cn-qingdao.aliyuncs.com"},
                {"cn-wulanchabu", "foasconsole.cn-wulanchabu.aliyuncs.com"},
                {"cn-beijing", "foasconsole.cn-beijing.aliyuncs.com"},
                {"cn-shanghai", "foasconsole.cn-shanghai.aliyuncs.com"},
                {"cn-hongkong", "foasconsole.cn-hongkong.aliyuncs.com"},
                {"cn-zhangjiakou", "foasconsole.cn-zhangjiakou.aliyuncs.com"},
                {"cn-shenzhen", "foasconsole.cn-shenzhen.aliyuncs.com"},
                {"ap-northeast-1", "foasconsole.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-1", "foasconsole.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "foasconsole.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "foasconsole.ap-southeast-5.aliyuncs.com"},
                {"cn-hangzhou", "foasconsole.cn-hangzhou.aliyuncs.com"},
                {"us-east-1", "foasconsole.us-east-1.aliyuncs.com"},
                {"eu-west-1", "foasconsole.eu-west-1.aliyuncs.com"},
                {"us-west-1", "foasconsole.us-west-1.aliyuncs.com"},
                {"eu-central-1", "foasconsole.eu-central-1.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "foasconsole.cn-shenzhen-finance-1.aliyuncs.com"},
                {"cn-shanghai-finance-1", "foasconsole.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-north-2-gov-1", "foasconsole.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("foasconsole", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Converts a subscription instance to a hybrid billing instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this API, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/hybrid-pricing">pricing</a> of hybrid billing for Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ConvertHybridInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertHybridInstanceResponse
        /// </returns>
        public ConvertHybridInstanceResponse ConvertHybridInstanceWithOptions(ConvertHybridInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConvertHybridInstanceShrinkRequest request = new ConvertHybridInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                query["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertHybridInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertHybridInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a subscription instance to a hybrid billing instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this API, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/hybrid-pricing">pricing</a> of hybrid billing for Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ConvertHybridInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertHybridInstanceResponse
        /// </returns>
        public async Task<ConvertHybridInstanceResponse> ConvertHybridInstanceWithOptionsAsync(ConvertHybridInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConvertHybridInstanceShrinkRequest request = new ConvertHybridInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                query["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertHybridInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertHybridInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a subscription instance to a hybrid billing instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this API, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/hybrid-pricing">pricing</a> of hybrid billing for Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertHybridInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertHybridInstanceResponse
        /// </returns>
        public ConvertHybridInstanceResponse ConvertHybridInstance(ConvertHybridInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertHybridInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a subscription instance to a hybrid billing instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this API, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/hybrid-pricing">pricing</a> of hybrid billing for Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertHybridInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertHybridInstanceResponse
        /// </returns>
        public async Task<ConvertHybridInstanceResponse> ConvertHybridInstanceAsync(ConvertHybridInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertHybridInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a pay-as-you-go workspace to a subscription workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/switch-from-pay-as-you-go-to-subscription">pricing</a> of fully managed Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ConvertInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertInstanceResponse
        /// </returns>
        public ConvertInstanceResponse ConvertInstanceWithOptions(ConvertInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConvertInstanceShrinkRequest request = new ConvertInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NamespaceResourceSpecs))
            {
                request.NamespaceResourceSpecsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NamespaceResourceSpecs, "NamespaceResourceSpecs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRenew))
            {
                body["IsAutoRenew"] = request.IsAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceResourceSpecsShrink))
            {
                body["NamespaceResourceSpecs"] = request.NamespaceResourceSpecsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a pay-as-you-go workspace to a subscription workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/switch-from-pay-as-you-go-to-subscription">pricing</a> of fully managed Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ConvertInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertInstanceResponse
        /// </returns>
        public async Task<ConvertInstanceResponse> ConvertInstanceWithOptionsAsync(ConvertInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConvertInstanceShrinkRequest request = new ConvertInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NamespaceResourceSpecs))
            {
                request.NamespaceResourceSpecsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NamespaceResourceSpecs, "NamespaceResourceSpecs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRenew))
            {
                body["IsAutoRenew"] = request.IsAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceResourceSpecsShrink))
            {
                body["NamespaceResourceSpecs"] = request.NamespaceResourceSpecsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a pay-as-you-go workspace to a subscription workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/switch-from-pay-as-you-go-to-subscription">pricing</a> of fully managed Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertInstanceResponse
        /// </returns>
        public ConvertInstanceResponse ConvertInstance(ConvertInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a pay-as-you-go workspace to a subscription workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/switch-from-pay-as-you-go-to-subscription">pricing</a> of fully managed Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertInstanceResponse
        /// </returns>
        public async Task<ConvertInstanceResponse> ConvertInstanceAsync(ConvertInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a subscription instance to pay-as-you-go.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, make sure that you fully understand the <a href="https://www.alibabacloud.com/help/en/flink/product-overview/switch-from-subscription-to-pay-as-you-go">billing methods and pricing</a> of Alibaba Cloud Realtime Compute for Apache Flink.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertPrepayInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertPrepayInstanceResponse
        /// </returns>
        public ConvertPrepayInstanceResponse ConvertPrepayInstanceWithOptions(ConvertPrepayInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertPrepayInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertPrepayInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a subscription instance to pay-as-you-go.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, make sure that you fully understand the <a href="https://www.alibabacloud.com/help/en/flink/product-overview/switch-from-subscription-to-pay-as-you-go">billing methods and pricing</a> of Alibaba Cloud Realtime Compute for Apache Flink.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertPrepayInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertPrepayInstanceResponse
        /// </returns>
        public async Task<ConvertPrepayInstanceResponse> ConvertPrepayInstanceWithOptionsAsync(ConvertPrepayInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertPrepayInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertPrepayInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a subscription instance to pay-as-you-go.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, make sure that you fully understand the <a href="https://www.alibabacloud.com/help/en/flink/product-overview/switch-from-subscription-to-pay-as-you-go">billing methods and pricing</a> of Alibaba Cloud Realtime Compute for Apache Flink.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertPrepayInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertPrepayInstanceResponse
        /// </returns>
        public ConvertPrepayInstanceResponse ConvertPrepayInstance(ConvertPrepayInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertPrepayInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a subscription instance to pay-as-you-go.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, make sure that you fully understand the <a href="https://www.alibabacloud.com/help/en/flink/product-overview/switch-from-subscription-to-pay-as-you-go">billing methods and pricing</a> of Alibaba Cloud Realtime Compute for Apache Flink.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertPrepayInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertPrepayInstanceResponse
        /// </returns>
        public async Task<ConvertPrepayInstanceResponse> ConvertPrepayInstanceAsync(ConvertPrepayInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertPrepayInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subscription or pay-as-you-go fully managed Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/billing-overview">pricing</a> of fully managed Flink before you call this operation.</em>*</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateInstanceShrinkRequest request = new CreateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Storage))
            {
                request.StorageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Storage, "Storage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchitectureType))
            {
                body["ArchitectureType"] = request.ArchitectureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorType))
            {
                body["MonitorType"] = request.MonitorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageShrink))
            {
                body["Storage"] = request.StorageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                body["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                body["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subscription or pay-as-you-go fully managed Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/billing-overview">pricing</a> of fully managed Flink before you call this operation.</em>*</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateInstanceShrinkRequest request = new CreateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Storage))
            {
                request.StorageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Storage, "Storage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchitectureType))
            {
                body["ArchitectureType"] = request.ArchitectureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorType))
            {
                body["MonitorType"] = request.MonitorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageShrink))
            {
                body["Storage"] = request.StorageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                body["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                body["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subscription or pay-as-you-go fully managed Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/billing-overview">pricing</a> of fully managed Flink before you call this operation.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subscription or pay-as-you-go fully managed Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/billing-overview">pricing</a> of fully managed Flink before you call this operation.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace in a fully managed Flink instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public CreateNamespaceResponse CreateNamespaceWithOptions(CreateNamespaceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNamespaceShrinkRequest request = new CreateNamespaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace in a fully managed Flink instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(CreateNamespaceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNamespaceShrinkRequest request = new CreateNamespaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace in a fully managed Flink instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace in a fully managed Flink instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/refund-policy">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/refund-policy">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/refund-policy">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases a pay-as-you-go Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/refund-policy">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a project workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public DeleteNamespaceResponse DeleteNamespaceWithOptions(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a project workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespaceWithOptionsAsync(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a project workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a project workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more fully managed Flink workspaces.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeInstancesShrinkRequest request = new DescribeInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more fully managed Flink workspaces.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeInstancesShrinkRequest request = new DescribeInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of one or more fully managed Flink workspaces.</para>
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
        /// <para>Queries the details of one or more fully managed Flink workspaces.</para>
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
        /// <para>Queries the namespace information of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeNamespacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public DescribeNamespacesResponse DescribeNamespacesWithOptions(DescribeNamespacesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeNamespacesShrinkRequest request = new DescribeNamespacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaces",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the namespace information of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeNamespacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public async Task<DescribeNamespacesResponse> DescribeNamespacesWithOptionsAsync(DescribeNamespacesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeNamespacesShrinkRequest request = new DescribeNamespacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaces",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the namespace information of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespacesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public DescribeNamespacesResponse DescribeNamespaces(DescribeNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNamespacesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the namespace information of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespacesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public async Task<DescribeNamespacesResponse> DescribeNamespacesAsync(DescribeNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNamespacesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about regions that support purchases of fully managed Flink.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedRegionsResponse
        /// </returns>
        public DescribeSupportedRegionsResponse DescribeSupportedRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupportedRegions",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupportedRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about regions that support purchases of fully managed Flink.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedRegionsResponse
        /// </returns>
        public async Task<DescribeSupportedRegionsResponse> DescribeSupportedRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupportedRegions",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupportedRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about regions that support purchases of fully managed Flink.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeSupportedRegionsResponse
        /// </returns>
        public DescribeSupportedRegionsResponse DescribeSupportedRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSupportedRegionsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about regions that support purchases of fully managed Flink.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeSupportedRegionsResponse
        /// </returns>
        public async Task<DescribeSupportedRegionsResponse> DescribeSupportedRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSupportedRegionsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about zones that are available for purchase.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSupportedZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedZonesResponse
        /// </returns>
        public DescribeSupportedZonesResponse DescribeSupportedZonesWithOptions(DescribeSupportedZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupportedZones",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupportedZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about zones that are available for purchase.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSupportedZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedZonesResponse
        /// </returns>
        public async Task<DescribeSupportedZonesResponse> DescribeSupportedZonesWithOptionsAsync(DescribeSupportedZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupportedZones",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupportedZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about zones that are available for purchase.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSupportedZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedZonesResponse
        /// </returns>
        public DescribeSupportedZonesResponse DescribeSupportedZones(DescribeSupportedZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSupportedZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about zones that are available for purchase.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSupportedZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSupportedZonesResponse
        /// </returns>
        public async Task<DescribeSupportedZonesResponse> DescribeSupportedZonesAsync(DescribeSupportedZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSupportedZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource tags. You can query tag keys by tag values, query tag values by tag keys, or retrieve all tag information used in your Flink fully managed workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource tags. You can query tag keys by tag values, query tag values by tag keys, or retrieve all tag information used in your Flink fully managed workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource tags. You can query tag keys by tag values, query tag values by tag keys, or retrieve all tag information used in your Flink fully managed workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource tags. You can query tag keys by tag values, query tag values by tag keys, or retrieve all tag information used in your Flink fully managed workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maximum pay-as-you-go resource limit for a hybrid billing instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/en/flink/user-guide/reconfigure-resources#task-2507532">billing methods</a> and pricing of Realtime Compute for Apache Flink before you call this operation.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyElasticResourceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticResourceSpecResponse
        /// </returns>
        public ModifyElasticResourceSpecResponse ModifyElasticResourceSpecWithOptions(ModifyElasticResourceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyElasticResourceSpecShrinkRequest request = new ModifyElasticResourceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyElasticResourceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyElasticResourceSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maximum pay-as-you-go resource limit for a hybrid billing instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/en/flink/user-guide/reconfigure-resources#task-2507532">billing methods</a> and pricing of Realtime Compute for Apache Flink before you call this operation.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyElasticResourceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticResourceSpecResponse
        /// </returns>
        public async Task<ModifyElasticResourceSpecResponse> ModifyElasticResourceSpecWithOptionsAsync(ModifyElasticResourceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyElasticResourceSpecShrinkRequest request = new ModifyElasticResourceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyElasticResourceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyElasticResourceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maximum pay-as-you-go resource limit for a hybrid billing instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/en/flink/user-guide/reconfigure-resources#task-2507532">billing methods</a> and pricing of Realtime Compute for Apache Flink before you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyElasticResourceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticResourceSpecResponse
        /// </returns>
        public ModifyElasticResourceSpecResponse ModifyElasticResourceSpec(ModifyElasticResourceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyElasticResourceSpecWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maximum pay-as-you-go resource limit for a hybrid billing instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/en/flink/user-guide/reconfigure-resources#task-2507532">billing methods</a> and pricing of Realtime Compute for Apache Flink before you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyElasticResourceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticResourceSpecResponse
        /// </returns>
        public async Task<ModifyElasticResourceSpecResponse> ModifyElasticResourceSpecAsync(ModifyElasticResourceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyElasticResourceSpecWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up or scales down the resources of a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/en/flink/user-guide/reconfigure-resources#task-2507532">billing methods</a> and pricing of Realtime Compute for Apache Flink before you call this operation.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstanceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceSpecResponse
        /// </returns>
        public ModifyInstanceSpecResponse ModifyInstanceSpecWithOptions(ModifyInstanceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstanceSpecShrinkRequest request = new ModifyInstanceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up or scales down the resources of a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/en/flink/user-guide/reconfigure-resources#task-2507532">billing methods</a> and pricing of Realtime Compute for Apache Flink before you call this operation.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstanceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceSpecResponse
        /// </returns>
        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpecWithOptionsAsync(ModifyInstanceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstanceSpecShrinkRequest request = new ModifyInstanceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up or scales down the resources of a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/en/flink/user-guide/reconfigure-resources#task-2507532">billing methods</a> and pricing of Realtime Compute for Apache Flink before you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceSpecResponse
        /// </returns>
        public ModifyInstanceSpecResponse ModifyInstanceSpec(ModifyInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceSpecWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up or scales down the resources of a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/en/flink/user-guide/reconfigure-resources#task-2507532">billing methods</a> and pricing of Realtime Compute for Apache Flink before you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceSpecResponse
        /// </returns>
        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpecAsync(ModifyInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceSpecWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyInstanceVswitch is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the vSwitches available to a Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, make sure that you fully understand the restrictions on <a href="https://www.alibabacloud.com/help/en/flink/user-guide/modify-a-vswitch">modifying vSwitches</a> in Realtime Compute for Apache Flink.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstanceVswitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceVswitchResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyInstanceVswitch is deprecated")]
        // Deprecated
        public ModifyInstanceVswitchResponse ModifyInstanceVswitchWithOptions(ModifyInstanceVswitchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstanceVswitchShrinkRequest request = new ModifyInstanceVswitchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                body["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceVswitch",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceVswitchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyInstanceVswitch is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the vSwitches available to a Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, make sure that you fully understand the restrictions on <a href="https://www.alibabacloud.com/help/en/flink/user-guide/modify-a-vswitch">modifying vSwitches</a> in Realtime Compute for Apache Flink.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstanceVswitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceVswitchResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyInstanceVswitch is deprecated")]
        // Deprecated
        public async Task<ModifyInstanceVswitchResponse> ModifyInstanceVswitchWithOptionsAsync(ModifyInstanceVswitchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstanceVswitchShrinkRequest request = new ModifyInstanceVswitchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                body["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceVswitch",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceVswitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyInstanceVswitch is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the vSwitches available to a Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, make sure that you fully understand the restrictions on <a href="https://www.alibabacloud.com/help/en/flink/user-guide/modify-a-vswitch">modifying vSwitches</a> in Realtime Compute for Apache Flink.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceVswitchRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceVswitchResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyInstanceVswitch is deprecated")]
        // Deprecated
        public ModifyInstanceVswitchResponse ModifyInstanceVswitch(ModifyInstanceVswitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceVswitchWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyInstanceVswitch is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the vSwitches available to a Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, make sure that you fully understand the restrictions on <a href="https://www.alibabacloud.com/help/en/flink/user-guide/modify-a-vswitch">modifying vSwitches</a> in Realtime Compute for Apache Flink.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceVswitchRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceVswitchResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyInstanceVswitch is deprecated")]
        // Deprecated
        public async Task<ModifyInstanceVswitchResponse> ModifyInstanceVswitchAsync(ModifyInstanceVswitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceVswitchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource configurations of a project namespace in a pay-as-you-go, subscription, or hybrid billing workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>When calling this operation, note the following: - The order status must be normal, that is, OrderType=NORMAL. - When decreasing the quota, the specified resource specification quantity cannot be less than the quantity already in use. For details about the project resource specifications before and after the change, call <a href="https://help.aliyun.com/document_detail/323441.html">DescribeNamespaces</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyNamespaceSpecV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNamespaceSpecV2Response
        /// </returns>
        public ModifyNamespaceSpecV2Response ModifyNamespaceSpecV2WithOptions(ModifyNamespaceSpecV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyNamespaceSpecV2ShrinkRequest request = new ModifyNamespaceSpecV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ElasticResourceSpec))
            {
                request.ElasticResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ElasticResourceSpec, "ElasticResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GuaranteedResourceSpec))
            {
                request.GuaranteedResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GuaranteedResourceSpec, "GuaranteedResourceSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                query["Ha"] = request.Ha;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticResourceSpecShrink))
            {
                body["ElasticResourceSpec"] = request.ElasticResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuaranteedResourceSpecShrink))
            {
                body["GuaranteedResourceSpec"] = request.GuaranteedResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNamespaceSpecV2",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNamespaceSpecV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource configurations of a project namespace in a pay-as-you-go, subscription, or hybrid billing workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>When calling this operation, note the following: - The order status must be normal, that is, OrderType=NORMAL. - When decreasing the quota, the specified resource specification quantity cannot be less than the quantity already in use. For details about the project resource specifications before and after the change, call <a href="https://help.aliyun.com/document_detail/323441.html">DescribeNamespaces</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyNamespaceSpecV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNamespaceSpecV2Response
        /// </returns>
        public async Task<ModifyNamespaceSpecV2Response> ModifyNamespaceSpecV2WithOptionsAsync(ModifyNamespaceSpecV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyNamespaceSpecV2ShrinkRequest request = new ModifyNamespaceSpecV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ElasticResourceSpec))
            {
                request.ElasticResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ElasticResourceSpec, "ElasticResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GuaranteedResourceSpec))
            {
                request.GuaranteedResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GuaranteedResourceSpec, "GuaranteedResourceSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                query["Ha"] = request.Ha;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticResourceSpecShrink))
            {
                body["ElasticResourceSpec"] = request.ElasticResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuaranteedResourceSpecShrink))
            {
                body["GuaranteedResourceSpec"] = request.GuaranteedResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNamespaceSpecV2",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNamespaceSpecV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource configurations of a project namespace in a pay-as-you-go, subscription, or hybrid billing workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>When calling this operation, note the following: - The order status must be normal, that is, OrderType=NORMAL. - When decreasing the quota, the specified resource specification quantity cannot be less than the quantity already in use. For details about the project resource specifications before and after the change, call <a href="https://help.aliyun.com/document_detail/323441.html">DescribeNamespaces</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNamespaceSpecV2Request
        /// </param>
        /// 
        /// <returns>
        /// ModifyNamespaceSpecV2Response
        /// </returns>
        public ModifyNamespaceSpecV2Response ModifyNamespaceSpecV2(ModifyNamespaceSpecV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNamespaceSpecV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource configurations of a project namespace in a pay-as-you-go, subscription, or hybrid billing workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>When calling this operation, note the following: - The order status must be normal, that is, OrderType=NORMAL. - When decreasing the quota, the specified resource specification quantity cannot be less than the quantity already in use. For details about the project resource specifications before and after the change, call <a href="https://help.aliyun.com/document_detail/323441.html">DescribeNamespaces</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNamespaceSpecV2Request
        /// </param>
        /// 
        /// <returns>
        /// ModifyNamespaceSpecV2Response
        /// </returns>
        public async Task<ModifyNamespaceSpecV2Response> ModifyNamespaceSpecV2Async(ModifyNamespaceSpecV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNamespaceSpecV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the compute resource specifications of a subscription Realtime Compute for Apache Flink instance. If the new specifications are smaller than the current specifications, a scale-in operation is performed. If the new specifications are larger than the current specifications, a scale-out operation is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/subscription">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyPrepayInstanceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayInstanceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.")]
        // Deprecated
        public ModifyPrepayInstanceSpecResponse ModifyPrepayInstanceSpecWithOptions(ModifyPrepayInstanceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPrepayInstanceSpecShrinkRequest request = new ModifyPrepayInstanceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaZoneId))
            {
                body["HaZoneId"] = request.HaZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPrepayInstanceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPrepayInstanceSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the compute resource specifications of a subscription Realtime Compute for Apache Flink instance. If the new specifications are smaller than the current specifications, a scale-in operation is performed. If the new specifications are larger than the current specifications, a scale-out operation is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/subscription">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyPrepayInstanceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayInstanceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.")]
        // Deprecated
        public async Task<ModifyPrepayInstanceSpecResponse> ModifyPrepayInstanceSpecWithOptionsAsync(ModifyPrepayInstanceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPrepayInstanceSpecShrinkRequest request = new ModifyPrepayInstanceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaZoneId))
            {
                body["HaZoneId"] = request.HaZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPrepayInstanceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPrepayInstanceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the compute resource specifications of a subscription Realtime Compute for Apache Flink instance. If the new specifications are smaller than the current specifications, a scale-in operation is performed. If the new specifications are larger than the current specifications, a scale-out operation is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/subscription">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPrepayInstanceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayInstanceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.")]
        // Deprecated
        public ModifyPrepayInstanceSpecResponse ModifyPrepayInstanceSpec(ModifyPrepayInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPrepayInstanceSpecWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the compute resource specifications of a subscription Realtime Compute for Apache Flink instance. If the new specifications are smaller than the current specifications, a scale-in operation is performed. If the new specifications are larger than the current specifications, a scale-out operation is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/subscription">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPrepayInstanceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayInstanceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayInstanceSpec is deprecated, please use foasconsole::2021-10-28::ModifyInstanceSpec instead.")]
        // Deprecated
        public async Task<ModifyPrepayInstanceSpecResponse> ModifyPrepayInstanceSpecAsync(ModifyPrepayInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPrepayInstanceSpecWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the specifications of a namespace in a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyPrepayNamespaceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayNamespaceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.")]
        // Deprecated
        public ModifyPrepayNamespaceSpecResponse ModifyPrepayNamespaceSpecWithOptions(ModifyPrepayNamespaceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPrepayNamespaceSpecShrinkRequest request = new ModifyPrepayNamespaceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPrepayNamespaceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPrepayNamespaceSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the specifications of a namespace in a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyPrepayNamespaceSpecRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayNamespaceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.")]
        // Deprecated
        public async Task<ModifyPrepayNamespaceSpecResponse> ModifyPrepayNamespaceSpecWithOptionsAsync(ModifyPrepayNamespaceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPrepayNamespaceSpecShrinkRequest request = new ModifyPrepayNamespaceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPrepayNamespaceSpec",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPrepayNamespaceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the specifications of a namespace in a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPrepayNamespaceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayNamespaceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.")]
        // Deprecated
        public ModifyPrepayNamespaceSpecResponse ModifyPrepayNamespaceSpec(ModifyPrepayNamespaceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPrepayNamespaceSpecWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the specifications of a namespace in a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPrepayNamespaceSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPrepayNamespaceSpecResponse
        /// </returns>
        [Obsolete("OpenAPI ModifyPrepayNamespaceSpec is deprecated, please use foasconsole::2021-10-28::ModifyNamespaceSpec instead.")]
        // Deprecated
        public async Task<ModifyPrepayNamespaceSpecResponse> ModifyPrepayNamespaceSpecAsync(ModifyPrepayNamespaceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPrepayNamespaceSpecWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price for converting a pay-as-you-go instance to a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryConvertInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertInstancePriceResponse
        /// </returns>
        public QueryConvertInstancePriceResponse QueryConvertInstancePriceWithOptions(QueryConvertInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryConvertInstancePriceShrinkRequest request = new QueryConvertInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NamespaceResourceSpecs))
            {
                request.NamespaceResourceSpecsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NamespaceResourceSpecs, "NamespaceResourceSpecs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRenew))
            {
                body["IsAutoRenew"] = request.IsAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceResourceSpecsShrink))
            {
                body["NamespaceResourceSpecs"] = request.NamespaceResourceSpecsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConvertInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConvertInstancePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price for converting a pay-as-you-go instance to a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryConvertInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertInstancePriceResponse
        /// </returns>
        public async Task<QueryConvertInstancePriceResponse> QueryConvertInstancePriceWithOptionsAsync(QueryConvertInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryConvertInstancePriceShrinkRequest request = new QueryConvertInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NamespaceResourceSpecs))
            {
                request.NamespaceResourceSpecsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NamespaceResourceSpecs, "NamespaceResourceSpecs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoRenew))
            {
                body["IsAutoRenew"] = request.IsAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceResourceSpecsShrink))
            {
                body["NamespaceResourceSpecs"] = request.NamespaceResourceSpecsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConvertInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConvertInstancePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price for converting a pay-as-you-go instance to a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConvertInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertInstancePriceResponse
        /// </returns>
        public QueryConvertInstancePriceResponse QueryConvertInstancePrice(QueryConvertInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConvertInstancePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price for converting a pay-as-you-go instance to a subscription instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConvertInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertInstancePriceResponse
        /// </returns>
        public async Task<QueryConvertInstancePriceResponse> QueryConvertInstancePriceAsync(QueryConvertInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConvertInstancePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the estimated refund amount after converting your Flink instance from subscription to pay-as-you-go. After the conversion, your usage is metered hourly and bills are generated accordingly.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConvertPrepayInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertPrepayInstancePriceResponse
        /// </returns>
        public QueryConvertPrepayInstancePriceResponse QueryConvertPrepayInstancePriceWithOptions(QueryConvertPrepayInstancePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConvertPrepayInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConvertPrepayInstancePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the estimated refund amount after converting your Flink instance from subscription to pay-as-you-go. After the conversion, your usage is metered hourly and bills are generated accordingly.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConvertPrepayInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertPrepayInstancePriceResponse
        /// </returns>
        public async Task<QueryConvertPrepayInstancePriceResponse> QueryConvertPrepayInstancePriceWithOptionsAsync(QueryConvertPrepayInstancePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryConvertPrepayInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConvertPrepayInstancePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the estimated refund amount after converting your Flink instance from subscription to pay-as-you-go. After the conversion, your usage is metered hourly and bills are generated accordingly.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConvertPrepayInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertPrepayInstancePriceResponse
        /// </returns>
        public QueryConvertPrepayInstancePriceResponse QueryConvertPrepayInstancePrice(QueryConvertPrepayInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConvertPrepayInstancePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the estimated refund amount after converting your Flink instance from subscription to pay-as-you-go. After the conversion, your usage is metered hourly and bills are generated accordingly.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConvertPrepayInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConvertPrepayInstancePriceResponse
        /// </returns>
        public async Task<QueryConvertPrepayInstancePriceResponse> QueryConvertPrepayInstancePriceAsync(QueryConvertPrepayInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConvertPrepayInstancePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the price of a workspace for the current account.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryCreateInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateInstancePriceResponse
        /// </returns>
        public QueryCreateInstancePriceResponse QueryCreateInstancePriceWithOptions(QueryCreateInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCreateInstancePriceShrinkRequest request = new QueryCreateInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Storage))
            {
                request.StorageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Storage, "Storage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchitectureType))
            {
                body["ArchitectureType"] = request.ArchitectureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageShrink))
            {
                body["Storage"] = request.StorageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                body["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCreateInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCreateInstancePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the price of a workspace for the current account.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryCreateInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateInstancePriceResponse
        /// </returns>
        public async Task<QueryCreateInstancePriceResponse> QueryCreateInstancePriceWithOptionsAsync(QueryCreateInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCreateInstancePriceShrinkRequest request = new QueryCreateInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Storage))
            {
                request.StorageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Storage, "Storage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitchIds))
            {
                request.VSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitchIds, "VSwitchIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchitectureType))
            {
                body["ArchitectureType"] = request.ArchitectureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["Extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageShrink))
            {
                body["Storage"] = request.StorageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdsShrink))
            {
                body["VSwitchIds"] = request.VSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCreateInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCreateInstancePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the price of a workspace for the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateInstancePriceResponse
        /// </returns>
        public QueryCreateInstancePriceResponse QueryCreateInstancePrice(QueryCreateInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCreateInstancePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the price of a workspace for the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCreateInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCreateInstancePriceResponse
        /// </returns>
        public async Task<QueryCreateInstancePriceResponse> QueryCreateInstancePriceAsync(QueryCreateInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCreateInstancePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price for upgrading or downgrading an instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryModifyInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyInstancePriceResponse
        /// </returns>
        public QueryModifyInstancePriceResponse QueryModifyInstancePriceWithOptions(QueryModifyInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryModifyInstancePriceShrinkRequest request = new QueryModifyInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyInstancePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price for upgrading or downgrading an instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryModifyInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyInstancePriceResponse
        /// </returns>
        public async Task<QueryModifyInstancePriceResponse> QueryModifyInstancePriceWithOptionsAsync(QueryModifyInstancePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryModifyInstancePriceShrinkRequest request = new QueryModifyInstancePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaResourceSpec))
            {
                request.HaResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaResourceSpec, "HaResourceSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HaVSwitchIds))
            {
                request.HaVSwitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HaVSwitchIds, "HaVSwitchIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceSpec))
            {
                request.ResourceSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceSpec, "ResourceSpec", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ha))
            {
                body["Ha"] = request.Ha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaResourceSpecShrink))
            {
                body["HaResourceSpec"] = request.HaResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaVSwitchIdsShrink))
            {
                body["HaVSwitchIds"] = request.HaVSwitchIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSpecShrink))
            {
                body["ResourceSpec"] = request.ResourceSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryModifyInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryModifyInstancePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price for upgrading or downgrading an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyInstancePriceResponse
        /// </returns>
        public QueryModifyInstancePriceResponse QueryModifyInstancePrice(QueryModifyInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryModifyInstancePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price for upgrading or downgrading an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryModifyInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryModifyInstancePriceResponse
        /// </returns>
        public async Task<QueryModifyInstancePriceResponse> QueryModifyInstancePriceAsync(QueryModifyInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryModifyInstancePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal price of a subscription workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewInstancePriceResponse
        /// </returns>
        public QueryRenewInstancePriceResponse QueryRenewInstancePriceWithOptions(QueryRenewInstancePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRenewInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRenewInstancePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal price of a subscription workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewInstancePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewInstancePriceResponse
        /// </returns>
        public async Task<QueryRenewInstancePriceResponse> QueryRenewInstancePriceWithOptionsAsync(QueryRenewInstancePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRenewInstancePrice",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRenewInstancePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal price of a subscription workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewInstancePriceResponse
        /// </returns>
        public QueryRenewInstancePriceResponse QueryRenewInstancePrice(QueryRenewInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRenewInstancePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal price of a subscription workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRenewInstancePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRenewInstancePriceResponse
        /// </returns>
        public async Task<QueryRenewInstancePriceResponse> QueryRenewInstancePriceAsync(QueryRenewInstancePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRenewInstancePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a subscription Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/renewal-policy">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a subscription Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/renewal-policy">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                body["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionCode))
            {
                body["PromotionCode"] = request.PromotionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotionCode))
            {
                body["UsePromotionCode"] = request.UsePromotionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a subscription Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/renewal-policy">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a subscription Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/flink/product-overview/renewal-policy">pricing</a> of Realtime Compute for Apache Flink.</em>*</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call this API to add tags to resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call this API to add tags to resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call this API to add tags to resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call this API to add tags to resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes resource tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes resource tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-10-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes resource tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes resource tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

    }
}
