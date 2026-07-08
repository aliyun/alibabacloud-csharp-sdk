// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dytnsapi20200217.Models;

namespace AlibabaCloud.SDK.Dytnsapi20200217
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"us-west-1", "dytnsapi.aliyuncs.com"},
                {"us-east-1", "dytnsapi.aliyuncs.com"},
                {"me-east-1", "dytnsapi.aliyuncs.com"},
                {"eu-west-1", "dytnsapi.aliyuncs.com"},
                {"eu-central-1", "dytnsapi.aliyuncs.com"},
                {"cn-zhangjiakou", "dytnsapi.aliyuncs.com"},
                {"cn-wulanchabu", "dytnsapi.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dytnsapi.aliyuncs.com"},
                {"cn-shenzhen", "dytnsapi.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dytnsapi.aliyuncs.com"},
                {"cn-shanghai", "dytnsapi.aliyuncs.com"},
                {"cn-qingdao", "dytnsapi.aliyuncs.com"},
                {"cn-huhehaote", "dytnsapi.aliyuncs.com"},
                {"cn-hongkong", "dytnsapi.aliyuncs.com"},
                {"cn-hangzhou-finance", "dytnsapi.aliyuncs.com"},
                {"cn-hangzhou", "dytnsapi.aliyuncs.com"},
                {"cn-chengdu", "dytnsapi.aliyuncs.com"},
                {"cn-beijing-finance-1", "dytnsapi.aliyuncs.com"},
                {"cn-beijing", "dytnsapi.aliyuncs.com"},
                {"ap-southeast-5", "dytnsapi.aliyuncs.com"},
                {"ap-southeast-3", "dytnsapi.aliyuncs.com"},
                {"ap-southeast-1", "dytnsapi.aliyuncs.com"},
                {"ap-northeast-1", "dytnsapi.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dytnsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Three-element (name, ID card number, and ID card photo) verification. Used to compare whether the three pieces of information (the name and ID card number filled in by the user and the uploaded portrait photo) belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the Tag Square page, find the corresponding tag, click Apply to Activate, fill in the application materials, and use the tag after the application is approved.</description></item>
        /// <item><description>Before using this API, make sure that you have fully understood the <a href="https://help.aliyun.com/document_detail/154751.html">Cell Phone Number Service pricing</a>.</description></item>
        /// <item><description>Billing applies only when the API return value is Code=&quot;OK&quot;. Other return results are not billed.</description></item>
        /// <item><description>For the verifiable scope, see <a href="https://help.aliyun.com/document_detail/2844379.html">ID Card Three Elements Verification</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <list type="bullet">
        /// <item><description>The per-user QPS limit for this API is 200 calls per second. If you exceed the limit, API calls are throttled, which may affect your business. Call the API reasonably.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CertNoThreeElementVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertNoThreeElementVerificationResponse
        /// </returns>
        public CertNoThreeElementVerificationResponse CertNoThreeElementVerificationWithOptions(CertNoThreeElementVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                query["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertPicture))
            {
                query["CertPicture"] = request.CertPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertNoThreeElementVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CertNoThreeElementVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Three-element (name, ID card number, and ID card photo) verification. Used to compare whether the three pieces of information (the name and ID card number filled in by the user and the uploaded portrait photo) belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the Tag Square page, find the corresponding tag, click Apply to Activate, fill in the application materials, and use the tag after the application is approved.</description></item>
        /// <item><description>Before using this API, make sure that you have fully understood the <a href="https://help.aliyun.com/document_detail/154751.html">Cell Phone Number Service pricing</a>.</description></item>
        /// <item><description>Billing applies only when the API return value is Code=&quot;OK&quot;. Other return results are not billed.</description></item>
        /// <item><description>For the verifiable scope, see <a href="https://help.aliyun.com/document_detail/2844379.html">ID Card Three Elements Verification</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <list type="bullet">
        /// <item><description>The per-user QPS limit for this API is 200 calls per second. If you exceed the limit, API calls are throttled, which may affect your business. Call the API reasonably.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CertNoThreeElementVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertNoThreeElementVerificationResponse
        /// </returns>
        public async Task<CertNoThreeElementVerificationResponse> CertNoThreeElementVerificationWithOptionsAsync(CertNoThreeElementVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                query["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertPicture))
            {
                query["CertPicture"] = request.CertPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertNoThreeElementVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CertNoThreeElementVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Three-element (name, ID card number, and ID card photo) verification. Used to compare whether the three pieces of information (the name and ID card number filled in by the user and the uploaded portrait photo) belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the Tag Square page, find the corresponding tag, click Apply to Activate, fill in the application materials, and use the tag after the application is approved.</description></item>
        /// <item><description>Before using this API, make sure that you have fully understood the <a href="https://help.aliyun.com/document_detail/154751.html">Cell Phone Number Service pricing</a>.</description></item>
        /// <item><description>Billing applies only when the API return value is Code=&quot;OK&quot;. Other return results are not billed.</description></item>
        /// <item><description>For the verifiable scope, see <a href="https://help.aliyun.com/document_detail/2844379.html">ID Card Three Elements Verification</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <list type="bullet">
        /// <item><description>The per-user QPS limit for this API is 200 calls per second. If you exceed the limit, API calls are throttled, which may affect your business. Call the API reasonably.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CertNoThreeElementVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CertNoThreeElementVerificationResponse
        /// </returns>
        public CertNoThreeElementVerificationResponse CertNoThreeElementVerification(CertNoThreeElementVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertNoThreeElementVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Three-element (name, ID card number, and ID card photo) verification. Used to compare whether the three pieces of information (the name and ID card number filled in by the user and the uploaded portrait photo) belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the Tag Square page, find the corresponding tag, click Apply to Activate, fill in the application materials, and use the tag after the application is approved.</description></item>
        /// <item><description>Before using this API, make sure that you have fully understood the <a href="https://help.aliyun.com/document_detail/154751.html">Cell Phone Number Service pricing</a>.</description></item>
        /// <item><description>Billing applies only when the API return value is Code=&quot;OK&quot;. Other return results are not billed.</description></item>
        /// <item><description>For the verifiable scope, see <a href="https://help.aliyun.com/document_detail/2844379.html">ID Card Three Elements Verification</a>.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <list type="bullet">
        /// <item><description>The per-user QPS limit for this API is 200 calls per second. If you exceed the limit, API calls are throttled, which may affect your business. Call the API reasonably.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CertNoThreeElementVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CertNoThreeElementVerificationResponse
        /// </returns>
        public async Task<CertNoThreeElementVerificationResponse> CertNoThreeElementVerificationAsync(CertNoThreeElementVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertNoThreeElementVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-element (name and ID card number) verification. Used to verify whether the name and ID card number entered by a user belong to the same person.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this operation, make sure that you have fully understood the pricing of Cell Phone Number Service.</description></item>
        /// <item><description>Before using this operation, log on to the Cell Phone Number Service console. On the Tag Marketplace page, find the desired tag, click Apply to Activate, and fill in the application information. You can use the operation only after your application is approved.</description></item>
        /// <item><description>The operation is charged when the response contains Code=&quot;OK&quot; and IsConsistent != 2. Other response results are not charged.</description></item>
        /// </list>
        /// <h2>QPS Limit</h2>
        /// <para>The per-user QPS limit of this operation is 200 calls per second. If the limit is exceeded, the API calls are throttled, which may affect your business. Call the operation properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CertNoTwoElementVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertNoTwoElementVerificationResponse
        /// </returns>
        public CertNoTwoElementVerificationResponse CertNoTwoElementVerificationWithOptions(CertNoTwoElementVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                query["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertNoTwoElementVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CertNoTwoElementVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-element (name and ID card number) verification. Used to verify whether the name and ID card number entered by a user belong to the same person.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this operation, make sure that you have fully understood the pricing of Cell Phone Number Service.</description></item>
        /// <item><description>Before using this operation, log on to the Cell Phone Number Service console. On the Tag Marketplace page, find the desired tag, click Apply to Activate, and fill in the application information. You can use the operation only after your application is approved.</description></item>
        /// <item><description>The operation is charged when the response contains Code=&quot;OK&quot; and IsConsistent != 2. Other response results are not charged.</description></item>
        /// </list>
        /// <h2>QPS Limit</h2>
        /// <para>The per-user QPS limit of this operation is 200 calls per second. If the limit is exceeded, the API calls are throttled, which may affect your business. Call the operation properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CertNoTwoElementVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertNoTwoElementVerificationResponse
        /// </returns>
        public async Task<CertNoTwoElementVerificationResponse> CertNoTwoElementVerificationWithOptionsAsync(CertNoTwoElementVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertNo))
            {
                query["CertNo"] = request.CertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertNoTwoElementVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CertNoTwoElementVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-element (name and ID card number) verification. Used to verify whether the name and ID card number entered by a user belong to the same person.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this operation, make sure that you have fully understood the pricing of Cell Phone Number Service.</description></item>
        /// <item><description>Before using this operation, log on to the Cell Phone Number Service console. On the Tag Marketplace page, find the desired tag, click Apply to Activate, and fill in the application information. You can use the operation only after your application is approved.</description></item>
        /// <item><description>The operation is charged when the response contains Code=&quot;OK&quot; and IsConsistent != 2. Other response results are not charged.</description></item>
        /// </list>
        /// <h2>QPS Limit</h2>
        /// <para>The per-user QPS limit of this operation is 200 calls per second. If the limit is exceeded, the API calls are throttled, which may affect your business. Call the operation properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CertNoTwoElementVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CertNoTwoElementVerificationResponse
        /// </returns>
        public CertNoTwoElementVerificationResponse CertNoTwoElementVerification(CertNoTwoElementVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertNoTwoElementVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-element (name and ID card number) verification. Used to verify whether the name and ID card number entered by a user belong to the same person.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this operation, make sure that you have fully understood the pricing of Cell Phone Number Service.</description></item>
        /// <item><description>Before using this operation, log on to the Cell Phone Number Service console. On the Tag Marketplace page, find the desired tag, click Apply to Activate, and fill in the application information. You can use the operation only after your application is approved.</description></item>
        /// <item><description>The operation is charged when the response contains Code=&quot;OK&quot; and IsConsistent != 2. Other response results are not charged.</description></item>
        /// </list>
        /// <h2>QPS Limit</h2>
        /// <para>The per-user QPS limit of this operation is 200 calls per second. If the limit is exceeded, the API calls are throttled, which may affect your business. Call the operation properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CertNoTwoElementVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CertNoTwoElementVerificationResponse
        /// </returns>
        public async Task<CertNoTwoElementVerificationResponse> CertNoTwoElementVerificationAsync(CertNoTwoElementVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertNoTwoElementVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the enterprise name, enterprise certificate number, enterprise legal person name, and enterprise legal person ID card number. All four items must be consistent and the enterprise\&quot;s operating status must be active for verification to pass.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you fully understand the billing method and prices of the Enterprise Four-Element Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Product Billing</a>.</description></item>
        /// <item><description>Billing applies when VerifyResult returns true/false and ReasonCode is 0, 1, or 2 in the response. Billing does not apply in other cases.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply to Activate</b>, and submit your application. You can use the API after the application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the API appropriately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyFourElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompanyFourElementsVerificationResponse
        /// </returns>
        public CompanyFourElementsVerificationResponse CompanyFourElementsVerificationWithOptions(CompanyFourElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertName))
            {
                query["EpCertName"] = request.EpCertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertNo))
            {
                query["EpCertNo"] = request.EpCertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertName))
            {
                query["LegalPersonCertName"] = request.LegalPersonCertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertNo))
            {
                query["LegalPersonCertNo"] = request.LegalPersonCertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompanyFourElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompanyFourElementsVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the enterprise name, enterprise certificate number, enterprise legal person name, and enterprise legal person ID card number. All four items must be consistent and the enterprise\&quot;s operating status must be active for verification to pass.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you fully understand the billing method and prices of the Enterprise Four-Element Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Product Billing</a>.</description></item>
        /// <item><description>Billing applies when VerifyResult returns true/false and ReasonCode is 0, 1, or 2 in the response. Billing does not apply in other cases.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply to Activate</b>, and submit your application. You can use the API after the application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the API appropriately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyFourElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompanyFourElementsVerificationResponse
        /// </returns>
        public async Task<CompanyFourElementsVerificationResponse> CompanyFourElementsVerificationWithOptionsAsync(CompanyFourElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertName))
            {
                query["EpCertName"] = request.EpCertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertNo))
            {
                query["EpCertNo"] = request.EpCertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertName))
            {
                query["LegalPersonCertName"] = request.LegalPersonCertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertNo))
            {
                query["LegalPersonCertNo"] = request.LegalPersonCertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompanyFourElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompanyFourElementsVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the enterprise name, enterprise certificate number, enterprise legal person name, and enterprise legal person ID card number. All four items must be consistent and the enterprise\&quot;s operating status must be active for verification to pass.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you fully understand the billing method and prices of the Enterprise Four-Element Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Product Billing</a>.</description></item>
        /// <item><description>Billing applies when VerifyResult returns true/false and ReasonCode is 0, 1, or 2 in the response. Billing does not apply in other cases.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply to Activate</b>, and submit your application. You can use the API after the application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the API appropriately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyFourElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CompanyFourElementsVerificationResponse
        /// </returns>
        public CompanyFourElementsVerificationResponse CompanyFourElementsVerification(CompanyFourElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompanyFourElementsVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the enterprise name, enterprise certificate number, enterprise legal person name, and enterprise legal person ID card number. All four items must be consistent and the enterprise\&quot;s operating status must be active for verification to pass.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you fully understand the billing method and prices of the Enterprise Four-Element Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Product Billing</a>.</description></item>
        /// <item><description>Billing applies when VerifyResult returns true/false and ReasonCode is 0, 1, or 2 in the response. Billing does not apply in other cases.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply to Activate</b>, and submit your application. You can use the API after the application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the API appropriately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyFourElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CompanyFourElementsVerificationResponse
        /// </returns>
        public async Task<CompanyFourElementsVerificationResponse> CompanyFourElementsVerificationAsync(CompanyFourElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompanyFourElementsVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to verify a company name, company certificate number, and the name of the company\&quot;s legal representative. Verification passes only when all three are consistent and the company\&quot;s operating status is in business.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you have fully understood the billing method and pricing of the Three-Element Company Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</description></item>
        /// <item><description>In the returned result, charges apply when VerifyResult is true/false and ReasonCode is 0/1/2. No charges apply in other cases.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use the API after the application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. Requests that exceed this limit are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyThreeElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompanyThreeElementsVerificationResponse
        /// </returns>
        public CompanyThreeElementsVerificationResponse CompanyThreeElementsVerificationWithOptions(CompanyThreeElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertName))
            {
                query["EpCertName"] = request.EpCertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertNo))
            {
                query["EpCertNo"] = request.EpCertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertName))
            {
                query["LegalPersonCertName"] = request.LegalPersonCertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompanyThreeElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompanyThreeElementsVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to verify a company name, company certificate number, and the name of the company\&quot;s legal representative. Verification passes only when all three are consistent and the company\&quot;s operating status is in business.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you have fully understood the billing method and pricing of the Three-Element Company Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</description></item>
        /// <item><description>In the returned result, charges apply when VerifyResult is true/false and ReasonCode is 0/1/2. No charges apply in other cases.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use the API after the application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. Requests that exceed this limit are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyThreeElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompanyThreeElementsVerificationResponse
        /// </returns>
        public async Task<CompanyThreeElementsVerificationResponse> CompanyThreeElementsVerificationWithOptionsAsync(CompanyThreeElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertName))
            {
                query["EpCertName"] = request.EpCertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertNo))
            {
                query["EpCertNo"] = request.EpCertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertName))
            {
                query["LegalPersonCertName"] = request.LegalPersonCertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompanyThreeElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompanyThreeElementsVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to verify a company name, company certificate number, and the name of the company\&quot;s legal representative. Verification passes only when all three are consistent and the company\&quot;s operating status is in business.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you have fully understood the billing method and pricing of the Three-Element Company Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</description></item>
        /// <item><description>In the returned result, charges apply when VerifyResult is true/false and ReasonCode is 0/1/2. No charges apply in other cases.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use the API after the application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. Requests that exceed this limit are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyThreeElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CompanyThreeElementsVerificationResponse
        /// </returns>
        public CompanyThreeElementsVerificationResponse CompanyThreeElementsVerification(CompanyThreeElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompanyThreeElementsVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to verify a company name, company certificate number, and the name of the company\&quot;s legal representative. Verification passes only when all three are consistent and the company\&quot;s operating status is in business.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you have fully understood the billing method and pricing of the Three-Element Company Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</description></item>
        /// <item><description>In the returned result, charges apply when VerifyResult is true/false and ReasonCode is 0/1/2. No charges apply in other cases.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use the API after the application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. Requests that exceed this limit are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyThreeElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CompanyThreeElementsVerificationResponse
        /// </returns>
        public async Task<CompanyThreeElementsVerificationResponse> CompanyThreeElementsVerificationAsync(CompanyThreeElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompanyThreeElementsVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to verify the enterprise name and enterprise certificate number. The name and certificate must be fully consistent, and the enterprise must be in operating status for the verification to pass.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you fully understand the billing methods and pricing of the Enterprise Two-Element Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Product billing</a>.</description></item>
        /// <item><description>Billing applies when Code=OK and ReasonCode=0/1/3 in the returned result. Other cases are not billed.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, find the corresponding tag on the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, click <b>Apply to Activate</b>, and fill in the application materials. After the application is approved, you can use the API.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The single-user QPS limit for this API is 200 times/second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyTwoElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompanyTwoElementsVerificationResponse
        /// </returns>
        public CompanyTwoElementsVerificationResponse CompanyTwoElementsVerificationWithOptions(CompanyTwoElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertName))
            {
                query["EpCertName"] = request.EpCertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertNo))
            {
                query["EpCertNo"] = request.EpCertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompanyTwoElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompanyTwoElementsVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to verify the enterprise name and enterprise certificate number. The name and certificate must be fully consistent, and the enterprise must be in operating status for the verification to pass.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you fully understand the billing methods and pricing of the Enterprise Two-Element Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Product billing</a>.</description></item>
        /// <item><description>Billing applies when Code=OK and ReasonCode=0/1/3 in the returned result. Other cases are not billed.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, find the corresponding tag on the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, click <b>Apply to Activate</b>, and fill in the application materials. After the application is approved, you can use the API.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The single-user QPS limit for this API is 200 times/second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyTwoElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompanyTwoElementsVerificationResponse
        /// </returns>
        public async Task<CompanyTwoElementsVerificationResponse> CompanyTwoElementsVerificationWithOptionsAsync(CompanyTwoElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertName))
            {
                query["EpCertName"] = request.EpCertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EpCertNo))
            {
                query["EpCertNo"] = request.EpCertNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompanyTwoElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompanyTwoElementsVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to verify the enterprise name and enterprise certificate number. The name and certificate must be fully consistent, and the enterprise must be in operating status for the verification to pass.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you fully understand the billing methods and pricing of the Enterprise Two-Element Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Product billing</a>.</description></item>
        /// <item><description>Billing applies when Code=OK and ReasonCode=0/1/3 in the returned result. Other cases are not billed.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, find the corresponding tag on the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, click <b>Apply to Activate</b>, and fill in the application materials. After the application is approved, you can use the API.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The single-user QPS limit for this API is 200 times/second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyTwoElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CompanyTwoElementsVerificationResponse
        /// </returns>
        public CompanyTwoElementsVerificationResponse CompanyTwoElementsVerification(CompanyTwoElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompanyTwoElementsVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Used to verify the enterprise name and enterprise certificate number. The name and certificate must be fully consistent, and the enterprise must be in operating status for the verification to pass.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you fully understand the billing methods and pricing of the Enterprise Two-Element Verification product. For billing details, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Product billing</a>.</description></item>
        /// <item><description>Billing applies when Code=OK and ReasonCode=0/1/3 in the returned result. Other cases are not billed.</description></item>
        /// <item><description>Before you use this API, log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC&lang=zh">Cell Phone Number Service console</a>, find the corresponding tag on the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, click <b>Apply to Activate</b>, and fill in the application materials. After the application is approved, you can use the API.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The single-user QPS limit for this API is 200 times/second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CompanyTwoElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CompanyTwoElementsVerificationResponse
        /// </returns>
        public async Task<CompanyTwoElementsVerificationResponse> CompanyTwoElementsVerificationAsync(CompanyTwoElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompanyTwoElementsVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Make sure you have activated Phone Number Identity Service before calling this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactsResponse
        /// </returns>
        public DeleteContactsResponse DeleteContactsWithOptions(DeleteContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContacts",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Make sure you have activated Phone Number Identity Service before calling this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactsResponse
        /// </returns>
        public async Task<DeleteContactsResponse> DeleteContactsWithOptionsAsync(DeleteContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContacts",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Make sure you have activated Phone Number Identity Service before calling this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactsResponse
        /// </returns>
        public DeleteContactsResponse DeleteContacts(DeleteContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContactsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Make sure you have activated Phone Number Identity Service before calling this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactsResponse
        /// </returns>
        public async Task<DeleteContactsResponse> DeleteContactsAsync(DeleteContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContactsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Predicts whether a phone number is invalid by using AI algorithms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>本接口用于验证号码是否为空号。发起调用该接口验证号码请求时，系统会根据验证次数计费，标准价为0.01元/次。<b>请确保在使用该接口前，已充分了解本产品的收费方式和价格。</b></description></item>
        /// <item><description>当返回结果中：Code=&quot;OK&quot; 且 Status != UNKNOWN 时计费，其他情况不计费。 </description></item>
        /// <item><description>由于本产品通过AI算法预测手机号的空号概率，所以无法做到100%准确。当前评估的准确率和召回率约为95%左右。<b>调用时请注意差别</b>。</description></item>
        /// <item><description>使用本接口前，请登录号码百科控制台，在<a href="https://dytns.console.aliyun.com/analysis/square">标签广场</a>页面，找到对应的标签，单击<b>申请开通</b>，填写申请资料，审批通过后即可使用。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为100次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// <h3>授权信息</h3>
        /// <para>默认仅限阿里云账号使用本接口，RAM用户只有在被授予了相关API操作权限后方可使用。具体请参见<a href="https://help.aliyun.com/document_detail/154006.html">为RAM用户授权</a>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeEmptyNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmptyNumberResponse
        /// </returns>
        public DescribeEmptyNumberResponse DescribeEmptyNumberWithOptions(DescribeEmptyNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEmptyNumber",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEmptyNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Predicts whether a phone number is invalid by using AI algorithms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>本接口用于验证号码是否为空号。发起调用该接口验证号码请求时，系统会根据验证次数计费，标准价为0.01元/次。<b>请确保在使用该接口前，已充分了解本产品的收费方式和价格。</b></description></item>
        /// <item><description>当返回结果中：Code=&quot;OK&quot; 且 Status != UNKNOWN 时计费，其他情况不计费。 </description></item>
        /// <item><description>由于本产品通过AI算法预测手机号的空号概率，所以无法做到100%准确。当前评估的准确率和召回率约为95%左右。<b>调用时请注意差别</b>。</description></item>
        /// <item><description>使用本接口前，请登录号码百科控制台，在<a href="https://dytns.console.aliyun.com/analysis/square">标签广场</a>页面，找到对应的标签，单击<b>申请开通</b>，填写申请资料，审批通过后即可使用。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为100次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// <h3>授权信息</h3>
        /// <para>默认仅限阿里云账号使用本接口，RAM用户只有在被授予了相关API操作权限后方可使用。具体请参见<a href="https://help.aliyun.com/document_detail/154006.html">为RAM用户授权</a>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeEmptyNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmptyNumberResponse
        /// </returns>
        public async Task<DescribeEmptyNumberResponse> DescribeEmptyNumberWithOptionsAsync(DescribeEmptyNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEmptyNumber",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEmptyNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Predicts whether a phone number is invalid by using AI algorithms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>本接口用于验证号码是否为空号。发起调用该接口验证号码请求时，系统会根据验证次数计费，标准价为0.01元/次。<b>请确保在使用该接口前，已充分了解本产品的收费方式和价格。</b></description></item>
        /// <item><description>当返回结果中：Code=&quot;OK&quot; 且 Status != UNKNOWN 时计费，其他情况不计费。 </description></item>
        /// <item><description>由于本产品通过AI算法预测手机号的空号概率，所以无法做到100%准确。当前评估的准确率和召回率约为95%左右。<b>调用时请注意差别</b>。</description></item>
        /// <item><description>使用本接口前，请登录号码百科控制台，在<a href="https://dytns.console.aliyun.com/analysis/square">标签广场</a>页面，找到对应的标签，单击<b>申请开通</b>，填写申请资料，审批通过后即可使用。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为100次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// <h3>授权信息</h3>
        /// <para>默认仅限阿里云账号使用本接口，RAM用户只有在被授予了相关API操作权限后方可使用。具体请参见<a href="https://help.aliyun.com/document_detail/154006.html">为RAM用户授权</a>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeEmptyNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmptyNumberResponse
        /// </returns>
        public DescribeEmptyNumberResponse DescribeEmptyNumber(DescribeEmptyNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEmptyNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Predicts whether a phone number is invalid by using AI algorithms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>本接口用于验证号码是否为空号。发起调用该接口验证号码请求时，系统会根据验证次数计费，标准价为0.01元/次。<b>请确保在使用该接口前，已充分了解本产品的收费方式和价格。</b></description></item>
        /// <item><description>当返回结果中：Code=&quot;OK&quot; 且 Status != UNKNOWN 时计费，其他情况不计费。 </description></item>
        /// <item><description>由于本产品通过AI算法预测手机号的空号概率，所以无法做到100%准确。当前评估的准确率和召回率约为95%左右。<b>调用时请注意差别</b>。</description></item>
        /// <item><description>使用本接口前，请登录号码百科控制台，在<a href="https://dytns.console.aliyun.com/analysis/square">标签广场</a>页面，找到对应的标签，单击<b>申请开通</b>，填写申请资料，审批通过后即可使用。</description></item>
        /// </list>
        /// <h3>QPS限制</h3>
        /// <para>本接口的单用户QPS限制为100次/秒。超过限制，API调用会被限流，这可能会影响您的业务，请合理调用。</para>
        /// <h3>授权信息</h3>
        /// <para>默认仅限阿里云账号使用本接口，RAM用户只有在被授予了相关API操作权限后方可使用。具体请参见<a href="https://help.aliyun.com/document_detail/154006.html">为RAM用户授权</a>。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeEmptyNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmptyNumberResponse
        /// </returns>
        public async Task<DescribeEmptyNumberResponse> DescribeEmptyNumberAsync(DescribeEmptyNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEmptyNumberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属地查询v2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMobileOperatorAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMobileOperatorAttributeResponse
        /// </returns>
        public DescribeMobileOperatorAttributeResponse DescribeMobileOperatorAttributeWithOptions(DescribeMobileOperatorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMobileOperatorAttribute",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMobileOperatorAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属地查询v2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMobileOperatorAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMobileOperatorAttributeResponse
        /// </returns>
        public async Task<DescribeMobileOperatorAttributeResponse> DescribeMobileOperatorAttributeWithOptionsAsync(DescribeMobileOperatorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMobileOperatorAttribute",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMobileOperatorAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属地查询v2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMobileOperatorAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMobileOperatorAttributeResponse
        /// </returns>
        public DescribeMobileOperatorAttributeResponse DescribeMobileOperatorAttribute(DescribeMobileOperatorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMobileOperatorAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属地查询v2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMobileOperatorAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMobileOperatorAttributeResponse
        /// </returns>
        public async Task<DescribeMobileOperatorAttributeResponse> DescribeMobileOperatorAttributeAsync(DescribeMobileOperatorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMobileOperatorAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the result returned by phone number analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, log on to the Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply to Activate</b>, fill in the application materials, and then use the API after the application is approved.</description></item>
        /// <item><description>Before you use this API, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Phone Number Service.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit of this API is 1,000 calls per second per user. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls properly.</para>
        /// <h3>Authorization information</h3>
        /// <para>By default, only Alibaba Cloud accounts can use this API. RAM users can use this API only after they are granted the related API operation permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Authorize a RAM user</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisResponse
        /// </returns>
        public DescribePhoneNumberAnalysisResponse DescribePhoneNumberAnalysisWithOptions(DescribePhoneNumberAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberType))
            {
                query["NumberType"] = request.NumberType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberAnalysis",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the result returned by phone number analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, log on to the Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply to Activate</b>, fill in the application materials, and then use the API after the application is approved.</description></item>
        /// <item><description>Before you use this API, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Phone Number Service.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit of this API is 1,000 calls per second per user. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls properly.</para>
        /// <h3>Authorization information</h3>
        /// <para>By default, only Alibaba Cloud accounts can use this API. RAM users can use this API only after they are granted the related API operation permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Authorize a RAM user</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisResponse
        /// </returns>
        public async Task<DescribePhoneNumberAnalysisResponse> DescribePhoneNumberAnalysisWithOptionsAsync(DescribePhoneNumberAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberType))
            {
                query["NumberType"] = request.NumberType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberAnalysis",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the result returned by phone number analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, log on to the Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply to Activate</b>, fill in the application materials, and then use the API after the application is approved.</description></item>
        /// <item><description>Before you use this API, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Phone Number Service.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit of this API is 1,000 calls per second per user. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls properly.</para>
        /// <h3>Authorization information</h3>
        /// <para>By default, only Alibaba Cloud accounts can use this API. RAM users can use this API only after they are granted the related API operation permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Authorize a RAM user</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisResponse
        /// </returns>
        public DescribePhoneNumberAnalysisResponse DescribePhoneNumberAnalysis(DescribePhoneNumberAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the result returned by phone number analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, log on to the Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply to Activate</b>, fill in the application materials, and then use the API after the application is approved.</description></item>
        /// <item><description>Before you use this API, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Phone Number Service.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit of this API is 1,000 calls per second per user. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls properly.</para>
        /// <h3>Authorization information</h3>
        /// <para>By default, only Alibaba Cloud accounts can use this API. RAM users can use this API only after they are granted the related API operation permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Authorize a RAM user</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisResponse
        /// </returns>
        public async Task<DescribePhoneNumberAnalysisResponse> DescribePhoneNumberAnalysisAsync(DescribePhoneNumberAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the phone number analysis result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, log on to the Cell Phone Number Service console, go to the Tag Square page, find the corresponding tag, click Apply to activate, and fill in the application materials. You can use the operation after the application is approved.
        /// Make sure that you fully understand the billing of the Cell Phone Number Service before you use this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisAIRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisAIResponse
        /// </returns>
        public DescribePhoneNumberAnalysisAIResponse DescribePhoneNumberAnalysisAIWithOptions(DescribePhoneNumberAnalysisAIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                query["ModelConfig"] = request.ModelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberAnalysisAI",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberAnalysisAIResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the phone number analysis result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, log on to the Cell Phone Number Service console, go to the Tag Square page, find the corresponding tag, click Apply to activate, and fill in the application materials. You can use the operation after the application is approved.
        /// Make sure that you fully understand the billing of the Cell Phone Number Service before you use this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisAIRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisAIResponse
        /// </returns>
        public async Task<DescribePhoneNumberAnalysisAIResponse> DescribePhoneNumberAnalysisAIWithOptionsAsync(DescribePhoneNumberAnalysisAIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                query["ModelConfig"] = request.ModelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberAnalysisAI",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberAnalysisAIResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the phone number analysis result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, log on to the Cell Phone Number Service console, go to the Tag Square page, find the corresponding tag, click Apply to activate, and fill in the application materials. You can use the operation after the application is approved.
        /// Make sure that you fully understand the billing of the Cell Phone Number Service before you use this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisAIRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisAIResponse
        /// </returns>
        public DescribePhoneNumberAnalysisAIResponse DescribePhoneNumberAnalysisAI(DescribePhoneNumberAnalysisAIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberAnalysisAIWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the phone number analysis result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before using this operation, log on to the Cell Phone Number Service console, go to the Tag Square page, find the corresponding tag, click Apply to activate, and fill in the application materials. You can use the operation after the application is approved.
        /// Make sure that you fully understand the billing of the Cell Phone Number Service before you use this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisAIRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisAIResponse
        /// </returns>
        public async Task<DescribePhoneNumberAnalysisAIResponse> DescribePhoneNumberAnalysisAIAsync(DescribePhoneNumberAnalysisAIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberAnalysisAIWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码分析服务pai供应商批量查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisPaiRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisPaiResponse
        /// </returns>
        public DescribePhoneNumberAnalysisPaiResponse DescribePhoneNumberAnalysisPaiWithOptions(DescribePhoneNumberAnalysisPaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                query["ModelConfig"] = request.ModelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberAnalysisPai",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberAnalysisPaiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码分析服务pai供应商批量查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisPaiRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisPaiResponse
        /// </returns>
        public async Task<DescribePhoneNumberAnalysisPaiResponse> DescribePhoneNumberAnalysisPaiWithOptionsAsync(DescribePhoneNumberAnalysisPaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelConfig))
            {
                query["ModelConfig"] = request.ModelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberAnalysisPai",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberAnalysisPaiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码分析服务pai供应商批量查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisPaiRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisPaiResponse
        /// </returns>
        public DescribePhoneNumberAnalysisPaiResponse DescribePhoneNumberAnalysisPai(DescribePhoneNumberAnalysisPaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberAnalysisPaiWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码分析服务pai供应商批量查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisPaiRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisPaiResponse
        /// </returns>
        public async Task<DescribePhoneNumberAnalysisPaiResponse> DescribePhoneNumberAnalysisPaiAsync(DescribePhoneNumberAnalysisPaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberAnalysisPaiWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>泛行业人群筛选</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisTransparentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisTransparentResponse
        /// </returns>
        public DescribePhoneNumberAnalysisTransparentResponse DescribePhoneNumberAnalysisTransparentWithOptions(DescribePhoneNumberAnalysisTransparentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberType))
            {
                query["NumberType"] = request.NumberType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberAnalysisTransparent",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberAnalysisTransparentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>泛行业人群筛选</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisTransparentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisTransparentResponse
        /// </returns>
        public async Task<DescribePhoneNumberAnalysisTransparentResponse> DescribePhoneNumberAnalysisTransparentWithOptionsAsync(DescribePhoneNumberAnalysisTransparentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberType))
            {
                query["NumberType"] = request.NumberType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberAnalysisTransparent",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberAnalysisTransparentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>泛行业人群筛选</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisTransparentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisTransparentResponse
        /// </returns>
        public DescribePhoneNumberAnalysisTransparentResponse DescribePhoneNumberAnalysisTransparent(DescribePhoneNumberAnalysisTransparentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberAnalysisTransparentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>泛行业人群筛选</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAnalysisTransparentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAnalysisTransparentResponse
        /// </returns>
        public async Task<DescribePhoneNumberAnalysisTransparentResponse> DescribePhoneNumberAnalysisTransparentAsync(DescribePhoneNumberAnalysisTransparentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberAnalysisTransparentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribePhoneNumberAttribute is deprecated, please use Dytnsapi::2020-02-17::DescribePhoneNumberOperatorAttribute instead.
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAttributeResponse
        /// </returns>
        [Obsolete("OpenAPI DescribePhoneNumberAttribute is deprecated, please use Dytnsapi::2020-02-17::DescribePhoneNumberOperatorAttribute instead.")]
        // Deprecated
        public DescribePhoneNumberAttributeResponse DescribePhoneNumberAttributeWithOptions(DescribePhoneNumberAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberAttribute",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribePhoneNumberAttribute is deprecated, please use Dytnsapi::2020-02-17::DescribePhoneNumberOperatorAttribute instead.
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAttributeResponse
        /// </returns>
        [Obsolete("OpenAPI DescribePhoneNumberAttribute is deprecated, please use Dytnsapi::2020-02-17::DescribePhoneNumberOperatorAttribute instead.")]
        // Deprecated
        public async Task<DescribePhoneNumberAttributeResponse> DescribePhoneNumberAttributeWithOptionsAsync(DescribePhoneNumberAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberAttribute",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribePhoneNumberAttribute is deprecated, please use Dytnsapi::2020-02-17::DescribePhoneNumberOperatorAttribute instead.
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAttributeResponse
        /// </returns>
        [Obsolete("OpenAPI DescribePhoneNumberAttribute is deprecated, please use Dytnsapi::2020-02-17::DescribePhoneNumberOperatorAttribute instead.")]
        // Deprecated
        public DescribePhoneNumberAttributeResponse DescribePhoneNumberAttribute(DescribePhoneNumberAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberAttributeWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribePhoneNumberAttribute is deprecated, please use Dytnsapi::2020-02-17::DescribePhoneNumberOperatorAttribute instead.
        /// 
        /// <param name="request">
        /// DescribePhoneNumberAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberAttributeResponse
        /// </returns>
        [Obsolete("OpenAPI DescribePhoneNumberAttribute is deprecated, please use Dytnsapi::2020-02-17::DescribePhoneNumberOperatorAttribute instead.")]
        // Deprecated
        public async Task<DescribePhoneNumberAttributeResponse> DescribePhoneNumberAttributeAsync(DescribePhoneNumberAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the duration for which a mobile user has been registered on the carrier\&quot;s network.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, fill in the application materials, and use the API after the application is approved.</description></item>
        /// <item><description>Make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">product pricing</a> of Cell Phone Number Service before using this API.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOnlineTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOnlineTimeResponse
        /// </returns>
        public DescribePhoneNumberOnlineTimeResponse DescribePhoneNumberOnlineTimeWithOptions(DescribePhoneNumberOnlineTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberOnlineTime",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberOnlineTimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the duration for which a mobile user has been registered on the carrier\&quot;s network.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, fill in the application materials, and use the API after the application is approved.</description></item>
        /// <item><description>Make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">product pricing</a> of Cell Phone Number Service before using this API.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOnlineTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOnlineTimeResponse
        /// </returns>
        public async Task<DescribePhoneNumberOnlineTimeResponse> DescribePhoneNumberOnlineTimeWithOptionsAsync(DescribePhoneNumberOnlineTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberOnlineTime",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberOnlineTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the duration for which a mobile user has been registered on the carrier\&quot;s network.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, fill in the application materials, and use the API after the application is approved.</description></item>
        /// <item><description>Make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">product pricing</a> of Cell Phone Number Service before using this API.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOnlineTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOnlineTimeResponse
        /// </returns>
        public DescribePhoneNumberOnlineTimeResponse DescribePhoneNumberOnlineTime(DescribePhoneNumberOnlineTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberOnlineTimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the duration for which a mobile user has been registered on the carrier\&quot;s network.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, fill in the application materials, and use the API after the application is approved.</description></item>
        /// <item><description>Make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">product pricing</a> of Cell Phone Number Service before using this API.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOnlineTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOnlineTimeResponse
        /// </returns>
        public async Task<DescribePhoneNumberOnlineTimeResponse> DescribePhoneNumberOnlineTimeAsync(DescribePhoneNumberOnlineTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberOnlineTimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the carrier information of a phone number, including the province, city, basic carrier (China Mobile, China Unicom, China Telecom, or China Broadnet), mobile virtual network operator (such as Alibaba Cloud Communication), whether the number has been ported, and the number segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can use this API. RAM users can use this API only after they are granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>This API is used to obtain the current carrier, location, and number portability information of a phone number. The API supports queries for <b>plaintext</b>, <b>MD5</b>, and <b>SHA256</b> encrypted phone numbers.</description></item>
        /// <item><description>Before you use this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use the API after your application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this API is 2,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeResponse
        /// </returns>
        public DescribePhoneNumberOperatorAttributeResponse DescribePhoneNumberOperatorAttributeWithOptions(DescribePhoneNumberOperatorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultCount))
            {
                query["ResultCount"] = request.ResultCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberOperatorAttribute",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberOperatorAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the carrier information of a phone number, including the province, city, basic carrier (China Mobile, China Unicom, China Telecom, or China Broadnet), mobile virtual network operator (such as Alibaba Cloud Communication), whether the number has been ported, and the number segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can use this API. RAM users can use this API only after they are granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>This API is used to obtain the current carrier, location, and number portability information of a phone number. The API supports queries for <b>plaintext</b>, <b>MD5</b>, and <b>SHA256</b> encrypted phone numbers.</description></item>
        /// <item><description>Before you use this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use the API after your application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this API is 2,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeResponse
        /// </returns>
        public async Task<DescribePhoneNumberOperatorAttributeResponse> DescribePhoneNumberOperatorAttributeWithOptionsAsync(DescribePhoneNumberOperatorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultCount))
            {
                query["ResultCount"] = request.ResultCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberOperatorAttribute",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberOperatorAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the carrier information of a phone number, including the province, city, basic carrier (China Mobile, China Unicom, China Telecom, or China Broadnet), mobile virtual network operator (such as Alibaba Cloud Communication), whether the number has been ported, and the number segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can use this API. RAM users can use this API only after they are granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>This API is used to obtain the current carrier, location, and number portability information of a phone number. The API supports queries for <b>plaintext</b>, <b>MD5</b>, and <b>SHA256</b> encrypted phone numbers.</description></item>
        /// <item><description>Before you use this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use the API after your application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this API is 2,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeResponse
        /// </returns>
        public DescribePhoneNumberOperatorAttributeResponse DescribePhoneNumberOperatorAttribute(DescribePhoneNumberOperatorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberOperatorAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the carrier information of a phone number, including the province, city, basic carrier (China Mobile, China Unicom, China Telecom, or China Broadnet), mobile virtual network operator (such as Alibaba Cloud Communication), whether the number has been ported, and the number segment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can use this API. RAM users can use this API only after they are granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>This API is used to obtain the current carrier, location, and number portability information of a phone number. The API supports queries for <b>plaintext</b>, <b>MD5</b>, and <b>SHA256</b> encrypted phone numbers.</description></item>
        /// <item><description>Before you use this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use the API after your application is approved.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this API is 2,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Make calls reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeResponse
        /// </returns>
        public async Task<DescribePhoneNumberOperatorAttributeResponse> DescribePhoneNumberOperatorAttributeAsync(DescribePhoneNumberOperatorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberOperatorAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属服务(包年包月客户专用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeAnnualRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeAnnualResponse
        /// </returns>
        public DescribePhoneNumberOperatorAttributeAnnualResponse DescribePhoneNumberOperatorAttributeAnnualWithOptions(DescribePhoneNumberOperatorAttributeAnnualRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberOperatorAttributeAnnual",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberOperatorAttributeAnnualResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属服务(包年包月客户专用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeAnnualRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeAnnualResponse
        /// </returns>
        public async Task<DescribePhoneNumberOperatorAttributeAnnualResponse> DescribePhoneNumberOperatorAttributeAnnualWithOptionsAsync(DescribePhoneNumberOperatorAttributeAnnualRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberOperatorAttributeAnnual",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberOperatorAttributeAnnualResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属服务(包年包月客户专用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeAnnualRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeAnnualResponse
        /// </returns>
        public DescribePhoneNumberOperatorAttributeAnnualResponse DescribePhoneNumberOperatorAttributeAnnual(DescribePhoneNumberOperatorAttributeAnnualRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberOperatorAttributeAnnualWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属服务(包年包月客户专用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeAnnualRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeAnnualResponse
        /// </returns>
        public async Task<DescribePhoneNumberOperatorAttributeAnnualResponse> DescribePhoneNumberOperatorAttributeAnnualAsync(DescribePhoneNumberOperatorAttributeAnnualRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberOperatorAttributeAnnualWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属服务(包年包月客户专用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeAnnualUseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeAnnualUseResponse
        /// </returns>
        public DescribePhoneNumberOperatorAttributeAnnualUseResponse DescribePhoneNumberOperatorAttributeAnnualUseWithOptions(DescribePhoneNumberOperatorAttributeAnnualUseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberOperatorAttributeAnnualUse",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberOperatorAttributeAnnualUseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属服务(包年包月客户专用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeAnnualUseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeAnnualUseResponse
        /// </returns>
        public async Task<DescribePhoneNumberOperatorAttributeAnnualUseResponse> DescribePhoneNumberOperatorAttributeAnnualUseWithOptionsAsync(DescribePhoneNumberOperatorAttributeAnnualUseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberOperatorAttributeAnnualUse",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberOperatorAttributeAnnualUseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属服务(包年包月客户专用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeAnnualUseRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeAnnualUseResponse
        /// </returns>
        public DescribePhoneNumberOperatorAttributeAnnualUseResponse DescribePhoneNumberOperatorAttributeAnnualUse(DescribePhoneNumberOperatorAttributeAnnualUseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberOperatorAttributeAnnualUseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>号码归属服务(包年包月客户专用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberOperatorAttributeAnnualUseRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberOperatorAttributeAnnualUseResponse
        /// </returns>
        public async Task<DescribePhoneNumberOperatorAttributeAnnualUseResponse> DescribePhoneNumberOperatorAttributeAnnualUseAsync(DescribePhoneNumberOperatorAttributeAnnualUseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberOperatorAttributeAnnualUseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>风险用户评分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberRiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberRiskResponse
        /// </returns>
        public DescribePhoneNumberRiskResponse DescribePhoneNumberRiskWithOptions(DescribePhoneNumberRiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberRisk",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberRiskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>风险用户评分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberRiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberRiskResponse
        /// </returns>
        public async Task<DescribePhoneNumberRiskResponse> DescribePhoneNumberRiskWithOptionsAsync(DescribePhoneNumberRiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneNumberRisk",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneNumberRiskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>风险用户评分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberRiskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberRiskResponse
        /// </returns>
        public DescribePhoneNumberRiskResponse DescribePhoneNumberRisk(DescribePhoneNumberRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberRiskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>风险用户评分</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePhoneNumberRiskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneNumberRiskResponse
        /// </returns>
        public async Task<DescribePhoneNumberRiskResponse> DescribePhoneNumberRiskAsync(DescribePhoneNumberRiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberRiskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Quickly verify in a single request if a mobile phone number is a carrier\&quot;s secondary number assignment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure you understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> for Phone Number Verification Service.</description></item>
        /// <item><description>You are charged only when the API response returns <c>Code=&quot;OK&quot;</c> and <c>VerifyResult</c> is not <c>0</c>. No charge is incurred in any other case.</description></item>
        /// <item><description>Before you use this API, log in to the Phone Number Verification Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the tag you need, click <b>Request Activation</b>, and complete the application form. You can use the API once your application is approved.</description></item>
        /// </list>
        /// <h2>QPS limits</h2>
        /// <para>The QPS limit is 100 per user. If you exceed this limit, the system throttles your API calls, which may affect your business. Plan your API calls accordingly.</para>
        /// <h2>Authorization</h2>
        /// <para>By default, only an Alibaba Cloud account can call this API. A RAM user must be granted the required permissions to call the API. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneTwiceTelVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneTwiceTelVerifyResponse
        /// </returns>
        public DescribePhoneTwiceTelVerifyResponse DescribePhoneTwiceTelVerifyWithOptions(DescribePhoneTwiceTelVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneTwiceTelVerify",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneTwiceTelVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Quickly verify in a single request if a mobile phone number is a carrier\&quot;s secondary number assignment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure you understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> for Phone Number Verification Service.</description></item>
        /// <item><description>You are charged only when the API response returns <c>Code=&quot;OK&quot;</c> and <c>VerifyResult</c> is not <c>0</c>. No charge is incurred in any other case.</description></item>
        /// <item><description>Before you use this API, log in to the Phone Number Verification Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the tag you need, click <b>Request Activation</b>, and complete the application form. You can use the API once your application is approved.</description></item>
        /// </list>
        /// <h2>QPS limits</h2>
        /// <para>The QPS limit is 100 per user. If you exceed this limit, the system throttles your API calls, which may affect your business. Plan your API calls accordingly.</para>
        /// <h2>Authorization</h2>
        /// <para>By default, only an Alibaba Cloud account can call this API. A RAM user must be granted the required permissions to call the API. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneTwiceTelVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneTwiceTelVerifyResponse
        /// </returns>
        public async Task<DescribePhoneTwiceTelVerifyResponse> DescribePhoneTwiceTelVerifyWithOptionsAsync(DescribePhoneTwiceTelVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePhoneTwiceTelVerify",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePhoneTwiceTelVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Quickly verify in a single request if a mobile phone number is a carrier\&quot;s secondary number assignment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure you understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> for Phone Number Verification Service.</description></item>
        /// <item><description>You are charged only when the API response returns <c>Code=&quot;OK&quot;</c> and <c>VerifyResult</c> is not <c>0</c>. No charge is incurred in any other case.</description></item>
        /// <item><description>Before you use this API, log in to the Phone Number Verification Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the tag you need, click <b>Request Activation</b>, and complete the application form. You can use the API once your application is approved.</description></item>
        /// </list>
        /// <h2>QPS limits</h2>
        /// <para>The QPS limit is 100 per user. If you exceed this limit, the system throttles your API calls, which may affect your business. Plan your API calls accordingly.</para>
        /// <h2>Authorization</h2>
        /// <para>By default, only an Alibaba Cloud account can call this API. A RAM user must be granted the required permissions to call the API. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneTwiceTelVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneTwiceTelVerifyResponse
        /// </returns>
        public DescribePhoneTwiceTelVerifyResponse DescribePhoneTwiceTelVerify(DescribePhoneTwiceTelVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneTwiceTelVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Quickly verify in a single request if a mobile phone number is a carrier\&quot;s secondary number assignment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you use this API, make sure you understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> for Phone Number Verification Service.</description></item>
        /// <item><description>You are charged only when the API response returns <c>Code=&quot;OK&quot;</c> and <c>VerifyResult</c> is not <c>0</c>. No charge is incurred in any other case.</description></item>
        /// <item><description>Before you use this API, log in to the Phone Number Verification Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the tag you need, click <b>Request Activation</b>, and complete the application form. You can use the API once your application is approved.</description></item>
        /// </list>
        /// <h2>QPS limits</h2>
        /// <para>The QPS limit is 100 per user. If you exceed this limit, the system throttles your API calls, which may affect your business. Plan your API calls accordingly.</para>
        /// <h2>Authorization</h2>
        /// <para>By default, only an Alibaba Cloud account can call this API. A RAM user must be granted the required permissions to call the API. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePhoneTwiceTelVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePhoneTwiceTelVerifyResponse
        /// </returns>
        public async Task<DescribePhoneTwiceTelVerifyResponse> DescribePhoneTwiceTelVerifyAsync(DescribePhoneTwiceTelVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneTwiceTelVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API only provides the signing functionality for acquiring an authorization token during UAID retrieval from the three-network operators.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API provides only the <b>signing function for obtaining an authorization token</b> as part of the UAID retrieval process for China\&quot;s three major operators.</para>
        /// <list type="bullet">
        /// <item><description>To generate the other parameters required to obtain the authorization token, refer to the respective operator\&quot;s documentation.</description></item>
        /// <item><description>To request the authorization token, refer to the respective operator\&quot;s documentation. Note that the request must be sent from the user\&quot;s mobile device over a cellular network.</description></item>
        /// <item><description>After obtaining the authorization token, call the <a href="~~UAIDVerification~~">UAIDVerification</a> API to complete the UAID retrieval.</description></item>
        /// </list>
        /// <h3>How to request an authorization token</h3>
        /// <remarks>
        /// <para>Notice: 
        /// When you request an authorization token, the client or H5 page must be connected to a cellular network.</para>
        /// </remarks>
        /// <h4>China Mobile (CM)</h4>
        /// <para>Protocol: HTTPS + application/json
        /// Method: POST
        /// URL: https\://msg.cmpassport.com/h5/getMobile</para>
        /// <h5>Request parameters</h5>
        /// <para>Request example:
        /// <c>{ &quot;traceId&quot;: &quot;mfawsxtcmyplwzpayzzvdvbsowxmkynr&quot;, &quot;appId&quot;: &quot;300011580392&quot;, &quot;sign&quot;: &quot;2c61b3c58ffbeed97461e31be4fd931a&quot;, &quot;msgId&quot;: &quot;redbyxsdetddwaaffajcwwapspykftzx&quot;, &quot;expandParams&quot;: &quot;&quot;, &quot;businessType&quot;: &quot;3&quot;, &quot;version&quot;: &quot;1.0&quot;, &quot;timestamp&quot;: &quot;20201125101540980&quot; }</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>version</c>: Use <c>1.0</c>.</description></item>
        /// <item><description><c>timestamp</c>: The request timestamp, with millisecond precision. This value and its format must match the <c>Time</c> input parameter for this API.</description></item>
        /// <item><description><c>appId</c>: Use <c>300011580392</c>.</description></item>
        /// <item><description><c>businessType</c>: Use <c>3</c>.</description></item>
        /// <item><description><c>traceId</c>: The trace ID. This value must match this API\&quot;s <c>OutId</c> input parameter.</description></item>
        /// <item><description><c>sign</c>: Obtained by calling this API.</description></item>
        /// <item><description><c>msgId</c>: A unique message identifier.</description></item>
        /// </list>
        /// <h5>Response parameters</h5>
        /// <para>Response example:
        /// <c>{ &quot;header&quot;: { &quot;appId&quot;: &quot;300011580392&quot;, &quot;msgId&quot;: &quot;redbyxsdetddwaaffajcwwapspykftzx&quot;, &quot;timestamp&quot;: &quot;20201125101607932&quot; }, &quot;body&quot;: { &quot;resultCode&quot;: &quot;103000&quot;, &quot;expandParams&quot;: &quot;&quot;, &quot;resultDesc&quot;: &quot;成功&quot;, &quot;token&quot;: &quot;H5HTTPS4187AE9743AFCB14F8D99B9D65ED9E01&quot; } }</c>
        /// Retrieve the <c>token</c> from the response <c>body</c>.</para>
        /// <h4>China Unicom (CU)</h4>
        /// <para>Obtain the token in two steps.</para>
        /// <h5>Step 1: Obtain the authurl</h5>
        /// <para>Send a request to the portal server to get the authentication server address (<c>authurl</c>).
        /// Protocol: HTTPS + application/json
        /// Method: GET
        /// URL: https\://nisportal.10010.com:9001/api</para>
        /// <h6>Request parameters</h6>
        /// <para>Request examples:
        /// JSON request: <c>?appid=1554778161153</c>
        /// JSONP request: <c>?appid=1554778161153&amp;callback=callbackFunction</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appid</c>: Use 1554778161153.</description></item>
        /// <item><description><c>callback</c>: The name of the JSONP callback function. This parameter is required only for JSONP requests.</description></item>
        /// </list>
        /// <h6>Response parameters</h6>
        /// <para>Response examples:
        /// JSON response:
        /// <c>{&quot;authurl&quot;: &quot;https://enrichgw.10010.com/d93222629f52ec79&quot;}</c>
        /// JSONP response:
        /// <c>callbackFunction({&quot;authurl&quot;:&quot;https://enrichgw.10010.com/d93222629f52ec79&quot;})</c>
        /// Retrieve the <c>authurl</c> from the response.</para>
        /// <h5>Step 2: Obtain the token</h5>
        /// <para>Protocol: HTTPS + application/json
        /// Method: GET
        /// URL: The authurl from Step 1, with /api appended.
        /// Request URL example: <c>https://enrichgw.10010.com/d93222629f52ec79/api</c></para>
        /// <h6>Request parameters</h6>
        /// <para>Request examples:
        /// JSON request: <c>?appid=1554778161153</c>
        /// JSONP request: <c>?appid=1554778161153&amp;callback=callbackFunction</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appid</c>: Use 1554778161153.</description></item>
        /// <item><description><c>callback</c>: The name of the JSONP callback function. This parameter is required only for JSONP requests.</description></item>
        /// </list>
        /// <h6>Response parameters</h6>
        /// <para>Response examples:
        /// JSON response:
        /// <c>{ &quot;province&quot;: &quot;1&quot;, &quot;code&quot;: &quot;7nHS1nggx2WP613750206700RN6oiRN1&quot; }</c>
        /// JSONP response:
        /// <c>callbackFunction({&quot;province&quot;:&quot;1&quot;,&quot;code&quot;:&quot;7nHS3Dnkd1BS701851092400RN6oiRN1&quot;})</c>
        /// Retrieve the <c>code</c> from the response.</para>
        /// <h4>China Telecom (CT)</h4>
        /// <para>Protocol: HTTPS + application/x-www-form-urlencoded;charset=UTF-8
        /// Method: GET
        /// URL: https\://id6.me/gw/preuniq.do</para>
        /// <h5>Request parameters</h5>
        /// <para>Request example:
        /// <c>?clientType=30100&amp;appId=9390188202&amp;format=json&amp;sign=D63C166FA19E1996EF********09C6A5397C10B4&amp;paramKey=1D7C25EB8B0B8B4CB3CF8DC60628F6549********786B0AF1FEF93FA1335057A35BF5F0B39A3867EAA9BE14B3898********8B01DE34965060445B6E1F66401D714650E4AB161CD6DCF4A72********3B856F22A192B8B0C39D7A55B961062E68C89C928894F119B25********7C548355FE9DB82852EB93C939F2200B48CD17&amp;paramStr=140********95AF8E138B94754CB4CF83BA6FB********52B258BFDFD38BF233&amp;version=1.1</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appId</c>: Use <c>9390188202</c>.</description></item>
        /// <item><description><c>clientType</c>: The client type. This value must match the <c>ClientType</c> input parameter for this API.</description></item>
        /// <item><description><c>format</c>: Use <c>json</c> or <c>jsonp</c>.</description></item>
        /// <item><description><c>version</c>: Use <c>1.1</c>.</description></item>
        /// <item><description><c>sign</c>: Obtained by calling this API.</description></item>
        /// <item><description><c>paramKey</c>: The ciphertext of key A. Key A is a 16-character random string generated by the client. To generate paramKey, encrypt key A using the RSA algorithm and the China Telecom public key. The padding mode is <c>RSA/ECB/PKCS1Padding</c>. Download the <a href="https://id.189.cn/source/files/API.pem">China Telecom RSA public key</a>.</description></item>
        /// <item><description><c>paramStr</c>: The ciphertext of a parameter string. This string contains <c>timeStamp</c> (a Unix timestamp with millisecond precision, for example <c>1697791988302</c>, that corresponds to the value of the <c>Time</c> parameter of this API) and <c>callback</c> (the name of the JSONP callback function, required only when <c>format</c> is set to <c>jsonp</c>). To generate <c>paramStr</c>, encrypt the string using AES with key A. The padding mode is <c>AES/CBC/PKCS5Padding</c>, and the initialization vector is <c>0000000000000000</c>.</description></item>
        /// </list>
        /// <h5>Response parameters</h5>
        /// <para>Response example:
        /// <c>callback?result=10000&amp;msg=success&amp;data=a35336711c70456cb883f4f224e9a259</c>
        /// The <c>data</c> parameter contains the ciphertext of the business result. To get the result, decrypt the data value using key A, the <c>AES/CBC/PKCS5Padding</c> mode, and an initialization vector of <c>0000000000000000</c>.
        /// Decrypted business result example:
        /// <c>{&quot;accessCode&quot;: &quot;H5HTTPS4187AE9743AFCB14F8D99B9D65ED9E01&quot;}</c>
        /// Retrieve the <c>accessCode</c> from the decrypted result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUAIDApplyTokenSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUAIDApplyTokenSignResponse
        /// </returns>
        public GetUAIDApplyTokenSignResponse GetUAIDApplyTokenSignWithOptions(GetUAIDApplyTokenSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                query["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamKey))
            {
                query["ParamKey"] = request.ParamKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamStr))
            {
                query["ParamStr"] = request.ParamStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUAIDApplyTokenSign",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUAIDApplyTokenSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API only provides the signing functionality for acquiring an authorization token during UAID retrieval from the three-network operators.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API provides only the <b>signing function for obtaining an authorization token</b> as part of the UAID retrieval process for China\&quot;s three major operators.</para>
        /// <list type="bullet">
        /// <item><description>To generate the other parameters required to obtain the authorization token, refer to the respective operator\&quot;s documentation.</description></item>
        /// <item><description>To request the authorization token, refer to the respective operator\&quot;s documentation. Note that the request must be sent from the user\&quot;s mobile device over a cellular network.</description></item>
        /// <item><description>After obtaining the authorization token, call the <a href="~~UAIDVerification~~">UAIDVerification</a> API to complete the UAID retrieval.</description></item>
        /// </list>
        /// <h3>How to request an authorization token</h3>
        /// <remarks>
        /// <para>Notice: 
        /// When you request an authorization token, the client or H5 page must be connected to a cellular network.</para>
        /// </remarks>
        /// <h4>China Mobile (CM)</h4>
        /// <para>Protocol: HTTPS + application/json
        /// Method: POST
        /// URL: https\://msg.cmpassport.com/h5/getMobile</para>
        /// <h5>Request parameters</h5>
        /// <para>Request example:
        /// <c>{ &quot;traceId&quot;: &quot;mfawsxtcmyplwzpayzzvdvbsowxmkynr&quot;, &quot;appId&quot;: &quot;300011580392&quot;, &quot;sign&quot;: &quot;2c61b3c58ffbeed97461e31be4fd931a&quot;, &quot;msgId&quot;: &quot;redbyxsdetddwaaffajcwwapspykftzx&quot;, &quot;expandParams&quot;: &quot;&quot;, &quot;businessType&quot;: &quot;3&quot;, &quot;version&quot;: &quot;1.0&quot;, &quot;timestamp&quot;: &quot;20201125101540980&quot; }</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>version</c>: Use <c>1.0</c>.</description></item>
        /// <item><description><c>timestamp</c>: The request timestamp, with millisecond precision. This value and its format must match the <c>Time</c> input parameter for this API.</description></item>
        /// <item><description><c>appId</c>: Use <c>300011580392</c>.</description></item>
        /// <item><description><c>businessType</c>: Use <c>3</c>.</description></item>
        /// <item><description><c>traceId</c>: The trace ID. This value must match this API\&quot;s <c>OutId</c> input parameter.</description></item>
        /// <item><description><c>sign</c>: Obtained by calling this API.</description></item>
        /// <item><description><c>msgId</c>: A unique message identifier.</description></item>
        /// </list>
        /// <h5>Response parameters</h5>
        /// <para>Response example:
        /// <c>{ &quot;header&quot;: { &quot;appId&quot;: &quot;300011580392&quot;, &quot;msgId&quot;: &quot;redbyxsdetddwaaffajcwwapspykftzx&quot;, &quot;timestamp&quot;: &quot;20201125101607932&quot; }, &quot;body&quot;: { &quot;resultCode&quot;: &quot;103000&quot;, &quot;expandParams&quot;: &quot;&quot;, &quot;resultDesc&quot;: &quot;成功&quot;, &quot;token&quot;: &quot;H5HTTPS4187AE9743AFCB14F8D99B9D65ED9E01&quot; } }</c>
        /// Retrieve the <c>token</c> from the response <c>body</c>.</para>
        /// <h4>China Unicom (CU)</h4>
        /// <para>Obtain the token in two steps.</para>
        /// <h5>Step 1: Obtain the authurl</h5>
        /// <para>Send a request to the portal server to get the authentication server address (<c>authurl</c>).
        /// Protocol: HTTPS + application/json
        /// Method: GET
        /// URL: https\://nisportal.10010.com:9001/api</para>
        /// <h6>Request parameters</h6>
        /// <para>Request examples:
        /// JSON request: <c>?appid=1554778161153</c>
        /// JSONP request: <c>?appid=1554778161153&amp;callback=callbackFunction</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appid</c>: Use 1554778161153.</description></item>
        /// <item><description><c>callback</c>: The name of the JSONP callback function. This parameter is required only for JSONP requests.</description></item>
        /// </list>
        /// <h6>Response parameters</h6>
        /// <para>Response examples:
        /// JSON response:
        /// <c>{&quot;authurl&quot;: &quot;https://enrichgw.10010.com/d93222629f52ec79&quot;}</c>
        /// JSONP response:
        /// <c>callbackFunction({&quot;authurl&quot;:&quot;https://enrichgw.10010.com/d93222629f52ec79&quot;})</c>
        /// Retrieve the <c>authurl</c> from the response.</para>
        /// <h5>Step 2: Obtain the token</h5>
        /// <para>Protocol: HTTPS + application/json
        /// Method: GET
        /// URL: The authurl from Step 1, with /api appended.
        /// Request URL example: <c>https://enrichgw.10010.com/d93222629f52ec79/api</c></para>
        /// <h6>Request parameters</h6>
        /// <para>Request examples:
        /// JSON request: <c>?appid=1554778161153</c>
        /// JSONP request: <c>?appid=1554778161153&amp;callback=callbackFunction</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appid</c>: Use 1554778161153.</description></item>
        /// <item><description><c>callback</c>: The name of the JSONP callback function. This parameter is required only for JSONP requests.</description></item>
        /// </list>
        /// <h6>Response parameters</h6>
        /// <para>Response examples:
        /// JSON response:
        /// <c>{ &quot;province&quot;: &quot;1&quot;, &quot;code&quot;: &quot;7nHS1nggx2WP613750206700RN6oiRN1&quot; }</c>
        /// JSONP response:
        /// <c>callbackFunction({&quot;province&quot;:&quot;1&quot;,&quot;code&quot;:&quot;7nHS3Dnkd1BS701851092400RN6oiRN1&quot;})</c>
        /// Retrieve the <c>code</c> from the response.</para>
        /// <h4>China Telecom (CT)</h4>
        /// <para>Protocol: HTTPS + application/x-www-form-urlencoded;charset=UTF-8
        /// Method: GET
        /// URL: https\://id6.me/gw/preuniq.do</para>
        /// <h5>Request parameters</h5>
        /// <para>Request example:
        /// <c>?clientType=30100&amp;appId=9390188202&amp;format=json&amp;sign=D63C166FA19E1996EF********09C6A5397C10B4&amp;paramKey=1D7C25EB8B0B8B4CB3CF8DC60628F6549********786B0AF1FEF93FA1335057A35BF5F0B39A3867EAA9BE14B3898********8B01DE34965060445B6E1F66401D714650E4AB161CD6DCF4A72********3B856F22A192B8B0C39D7A55B961062E68C89C928894F119B25********7C548355FE9DB82852EB93C939F2200B48CD17&amp;paramStr=140********95AF8E138B94754CB4CF83BA6FB********52B258BFDFD38BF233&amp;version=1.1</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appId</c>: Use <c>9390188202</c>.</description></item>
        /// <item><description><c>clientType</c>: The client type. This value must match the <c>ClientType</c> input parameter for this API.</description></item>
        /// <item><description><c>format</c>: Use <c>json</c> or <c>jsonp</c>.</description></item>
        /// <item><description><c>version</c>: Use <c>1.1</c>.</description></item>
        /// <item><description><c>sign</c>: Obtained by calling this API.</description></item>
        /// <item><description><c>paramKey</c>: The ciphertext of key A. Key A is a 16-character random string generated by the client. To generate paramKey, encrypt key A using the RSA algorithm and the China Telecom public key. The padding mode is <c>RSA/ECB/PKCS1Padding</c>. Download the <a href="https://id.189.cn/source/files/API.pem">China Telecom RSA public key</a>.</description></item>
        /// <item><description><c>paramStr</c>: The ciphertext of a parameter string. This string contains <c>timeStamp</c> (a Unix timestamp with millisecond precision, for example <c>1697791988302</c>, that corresponds to the value of the <c>Time</c> parameter of this API) and <c>callback</c> (the name of the JSONP callback function, required only when <c>format</c> is set to <c>jsonp</c>). To generate <c>paramStr</c>, encrypt the string using AES with key A. The padding mode is <c>AES/CBC/PKCS5Padding</c>, and the initialization vector is <c>0000000000000000</c>.</description></item>
        /// </list>
        /// <h5>Response parameters</h5>
        /// <para>Response example:
        /// <c>callback?result=10000&amp;msg=success&amp;data=a35336711c70456cb883f4f224e9a259</c>
        /// The <c>data</c> parameter contains the ciphertext of the business result. To get the result, decrypt the data value using key A, the <c>AES/CBC/PKCS5Padding</c> mode, and an initialization vector of <c>0000000000000000</c>.
        /// Decrypted business result example:
        /// <c>{&quot;accessCode&quot;: &quot;H5HTTPS4187AE9743AFCB14F8D99B9D65ED9E01&quot;}</c>
        /// Retrieve the <c>accessCode</c> from the decrypted result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUAIDApplyTokenSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUAIDApplyTokenSignResponse
        /// </returns>
        public async Task<GetUAIDApplyTokenSignResponse> GetUAIDApplyTokenSignWithOptionsAsync(GetUAIDApplyTokenSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                query["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamKey))
            {
                query["ParamKey"] = request.ParamKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamStr))
            {
                query["ParamStr"] = request.ParamStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUAIDApplyTokenSign",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUAIDApplyTokenSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API only provides the signing functionality for acquiring an authorization token during UAID retrieval from the three-network operators.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API provides only the <b>signing function for obtaining an authorization token</b> as part of the UAID retrieval process for China\&quot;s three major operators.</para>
        /// <list type="bullet">
        /// <item><description>To generate the other parameters required to obtain the authorization token, refer to the respective operator\&quot;s documentation.</description></item>
        /// <item><description>To request the authorization token, refer to the respective operator\&quot;s documentation. Note that the request must be sent from the user\&quot;s mobile device over a cellular network.</description></item>
        /// <item><description>After obtaining the authorization token, call the <a href="~~UAIDVerification~~">UAIDVerification</a> API to complete the UAID retrieval.</description></item>
        /// </list>
        /// <h3>How to request an authorization token</h3>
        /// <remarks>
        /// <para>Notice: 
        /// When you request an authorization token, the client or H5 page must be connected to a cellular network.</para>
        /// </remarks>
        /// <h4>China Mobile (CM)</h4>
        /// <para>Protocol: HTTPS + application/json
        /// Method: POST
        /// URL: https\://msg.cmpassport.com/h5/getMobile</para>
        /// <h5>Request parameters</h5>
        /// <para>Request example:
        /// <c>{ &quot;traceId&quot;: &quot;mfawsxtcmyplwzpayzzvdvbsowxmkynr&quot;, &quot;appId&quot;: &quot;300011580392&quot;, &quot;sign&quot;: &quot;2c61b3c58ffbeed97461e31be4fd931a&quot;, &quot;msgId&quot;: &quot;redbyxsdetddwaaffajcwwapspykftzx&quot;, &quot;expandParams&quot;: &quot;&quot;, &quot;businessType&quot;: &quot;3&quot;, &quot;version&quot;: &quot;1.0&quot;, &quot;timestamp&quot;: &quot;20201125101540980&quot; }</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>version</c>: Use <c>1.0</c>.</description></item>
        /// <item><description><c>timestamp</c>: The request timestamp, with millisecond precision. This value and its format must match the <c>Time</c> input parameter for this API.</description></item>
        /// <item><description><c>appId</c>: Use <c>300011580392</c>.</description></item>
        /// <item><description><c>businessType</c>: Use <c>3</c>.</description></item>
        /// <item><description><c>traceId</c>: The trace ID. This value must match this API\&quot;s <c>OutId</c> input parameter.</description></item>
        /// <item><description><c>sign</c>: Obtained by calling this API.</description></item>
        /// <item><description><c>msgId</c>: A unique message identifier.</description></item>
        /// </list>
        /// <h5>Response parameters</h5>
        /// <para>Response example:
        /// <c>{ &quot;header&quot;: { &quot;appId&quot;: &quot;300011580392&quot;, &quot;msgId&quot;: &quot;redbyxsdetddwaaffajcwwapspykftzx&quot;, &quot;timestamp&quot;: &quot;20201125101607932&quot; }, &quot;body&quot;: { &quot;resultCode&quot;: &quot;103000&quot;, &quot;expandParams&quot;: &quot;&quot;, &quot;resultDesc&quot;: &quot;成功&quot;, &quot;token&quot;: &quot;H5HTTPS4187AE9743AFCB14F8D99B9D65ED9E01&quot; } }</c>
        /// Retrieve the <c>token</c> from the response <c>body</c>.</para>
        /// <h4>China Unicom (CU)</h4>
        /// <para>Obtain the token in two steps.</para>
        /// <h5>Step 1: Obtain the authurl</h5>
        /// <para>Send a request to the portal server to get the authentication server address (<c>authurl</c>).
        /// Protocol: HTTPS + application/json
        /// Method: GET
        /// URL: https\://nisportal.10010.com:9001/api</para>
        /// <h6>Request parameters</h6>
        /// <para>Request examples:
        /// JSON request: <c>?appid=1554778161153</c>
        /// JSONP request: <c>?appid=1554778161153&amp;callback=callbackFunction</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appid</c>: Use 1554778161153.</description></item>
        /// <item><description><c>callback</c>: The name of the JSONP callback function. This parameter is required only for JSONP requests.</description></item>
        /// </list>
        /// <h6>Response parameters</h6>
        /// <para>Response examples:
        /// JSON response:
        /// <c>{&quot;authurl&quot;: &quot;https://enrichgw.10010.com/d93222629f52ec79&quot;}</c>
        /// JSONP response:
        /// <c>callbackFunction({&quot;authurl&quot;:&quot;https://enrichgw.10010.com/d93222629f52ec79&quot;})</c>
        /// Retrieve the <c>authurl</c> from the response.</para>
        /// <h5>Step 2: Obtain the token</h5>
        /// <para>Protocol: HTTPS + application/json
        /// Method: GET
        /// URL: The authurl from Step 1, with /api appended.
        /// Request URL example: <c>https://enrichgw.10010.com/d93222629f52ec79/api</c></para>
        /// <h6>Request parameters</h6>
        /// <para>Request examples:
        /// JSON request: <c>?appid=1554778161153</c>
        /// JSONP request: <c>?appid=1554778161153&amp;callback=callbackFunction</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appid</c>: Use 1554778161153.</description></item>
        /// <item><description><c>callback</c>: The name of the JSONP callback function. This parameter is required only for JSONP requests.</description></item>
        /// </list>
        /// <h6>Response parameters</h6>
        /// <para>Response examples:
        /// JSON response:
        /// <c>{ &quot;province&quot;: &quot;1&quot;, &quot;code&quot;: &quot;7nHS1nggx2WP613750206700RN6oiRN1&quot; }</c>
        /// JSONP response:
        /// <c>callbackFunction({&quot;province&quot;:&quot;1&quot;,&quot;code&quot;:&quot;7nHS3Dnkd1BS701851092400RN6oiRN1&quot;})</c>
        /// Retrieve the <c>code</c> from the response.</para>
        /// <h4>China Telecom (CT)</h4>
        /// <para>Protocol: HTTPS + application/x-www-form-urlencoded;charset=UTF-8
        /// Method: GET
        /// URL: https\://id6.me/gw/preuniq.do</para>
        /// <h5>Request parameters</h5>
        /// <para>Request example:
        /// <c>?clientType=30100&amp;appId=9390188202&amp;format=json&amp;sign=D63C166FA19E1996EF********09C6A5397C10B4&amp;paramKey=1D7C25EB8B0B8B4CB3CF8DC60628F6549********786B0AF1FEF93FA1335057A35BF5F0B39A3867EAA9BE14B3898********8B01DE34965060445B6E1F66401D714650E4AB161CD6DCF4A72********3B856F22A192B8B0C39D7A55B961062E68C89C928894F119B25********7C548355FE9DB82852EB93C939F2200B48CD17&amp;paramStr=140********95AF8E138B94754CB4CF83BA6FB********52B258BFDFD38BF233&amp;version=1.1</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appId</c>: Use <c>9390188202</c>.</description></item>
        /// <item><description><c>clientType</c>: The client type. This value must match the <c>ClientType</c> input parameter for this API.</description></item>
        /// <item><description><c>format</c>: Use <c>json</c> or <c>jsonp</c>.</description></item>
        /// <item><description><c>version</c>: Use <c>1.1</c>.</description></item>
        /// <item><description><c>sign</c>: Obtained by calling this API.</description></item>
        /// <item><description><c>paramKey</c>: The ciphertext of key A. Key A is a 16-character random string generated by the client. To generate paramKey, encrypt key A using the RSA algorithm and the China Telecom public key. The padding mode is <c>RSA/ECB/PKCS1Padding</c>. Download the <a href="https://id.189.cn/source/files/API.pem">China Telecom RSA public key</a>.</description></item>
        /// <item><description><c>paramStr</c>: The ciphertext of a parameter string. This string contains <c>timeStamp</c> (a Unix timestamp with millisecond precision, for example <c>1697791988302</c>, that corresponds to the value of the <c>Time</c> parameter of this API) and <c>callback</c> (the name of the JSONP callback function, required only when <c>format</c> is set to <c>jsonp</c>). To generate <c>paramStr</c>, encrypt the string using AES with key A. The padding mode is <c>AES/CBC/PKCS5Padding</c>, and the initialization vector is <c>0000000000000000</c>.</description></item>
        /// </list>
        /// <h5>Response parameters</h5>
        /// <para>Response example:
        /// <c>callback?result=10000&amp;msg=success&amp;data=a35336711c70456cb883f4f224e9a259</c>
        /// The <c>data</c> parameter contains the ciphertext of the business result. To get the result, decrypt the data value using key A, the <c>AES/CBC/PKCS5Padding</c> mode, and an initialization vector of <c>0000000000000000</c>.
        /// Decrypted business result example:
        /// <c>{&quot;accessCode&quot;: &quot;H5HTTPS4187AE9743AFCB14F8D99B9D65ED9E01&quot;}</c>
        /// Retrieve the <c>accessCode</c> from the decrypted result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUAIDApplyTokenSignRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUAIDApplyTokenSignResponse
        /// </returns>
        public GetUAIDApplyTokenSignResponse GetUAIDApplyTokenSign(GetUAIDApplyTokenSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUAIDApplyTokenSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API only provides the signing functionality for acquiring an authorization token during UAID retrieval from the three-network operators.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API provides only the <b>signing function for obtaining an authorization token</b> as part of the UAID retrieval process for China\&quot;s three major operators.</para>
        /// <list type="bullet">
        /// <item><description>To generate the other parameters required to obtain the authorization token, refer to the respective operator\&quot;s documentation.</description></item>
        /// <item><description>To request the authorization token, refer to the respective operator\&quot;s documentation. Note that the request must be sent from the user\&quot;s mobile device over a cellular network.</description></item>
        /// <item><description>After obtaining the authorization token, call the <a href="~~UAIDVerification~~">UAIDVerification</a> API to complete the UAID retrieval.</description></item>
        /// </list>
        /// <h3>How to request an authorization token</h3>
        /// <remarks>
        /// <para>Notice: 
        /// When you request an authorization token, the client or H5 page must be connected to a cellular network.</para>
        /// </remarks>
        /// <h4>China Mobile (CM)</h4>
        /// <para>Protocol: HTTPS + application/json
        /// Method: POST
        /// URL: https\://msg.cmpassport.com/h5/getMobile</para>
        /// <h5>Request parameters</h5>
        /// <para>Request example:
        /// <c>{ &quot;traceId&quot;: &quot;mfawsxtcmyplwzpayzzvdvbsowxmkynr&quot;, &quot;appId&quot;: &quot;300011580392&quot;, &quot;sign&quot;: &quot;2c61b3c58ffbeed97461e31be4fd931a&quot;, &quot;msgId&quot;: &quot;redbyxsdetddwaaffajcwwapspykftzx&quot;, &quot;expandParams&quot;: &quot;&quot;, &quot;businessType&quot;: &quot;3&quot;, &quot;version&quot;: &quot;1.0&quot;, &quot;timestamp&quot;: &quot;20201125101540980&quot; }</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>version</c>: Use <c>1.0</c>.</description></item>
        /// <item><description><c>timestamp</c>: The request timestamp, with millisecond precision. This value and its format must match the <c>Time</c> input parameter for this API.</description></item>
        /// <item><description><c>appId</c>: Use <c>300011580392</c>.</description></item>
        /// <item><description><c>businessType</c>: Use <c>3</c>.</description></item>
        /// <item><description><c>traceId</c>: The trace ID. This value must match this API\&quot;s <c>OutId</c> input parameter.</description></item>
        /// <item><description><c>sign</c>: Obtained by calling this API.</description></item>
        /// <item><description><c>msgId</c>: A unique message identifier.</description></item>
        /// </list>
        /// <h5>Response parameters</h5>
        /// <para>Response example:
        /// <c>{ &quot;header&quot;: { &quot;appId&quot;: &quot;300011580392&quot;, &quot;msgId&quot;: &quot;redbyxsdetddwaaffajcwwapspykftzx&quot;, &quot;timestamp&quot;: &quot;20201125101607932&quot; }, &quot;body&quot;: { &quot;resultCode&quot;: &quot;103000&quot;, &quot;expandParams&quot;: &quot;&quot;, &quot;resultDesc&quot;: &quot;成功&quot;, &quot;token&quot;: &quot;H5HTTPS4187AE9743AFCB14F8D99B9D65ED9E01&quot; } }</c>
        /// Retrieve the <c>token</c> from the response <c>body</c>.</para>
        /// <h4>China Unicom (CU)</h4>
        /// <para>Obtain the token in two steps.</para>
        /// <h5>Step 1: Obtain the authurl</h5>
        /// <para>Send a request to the portal server to get the authentication server address (<c>authurl</c>).
        /// Protocol: HTTPS + application/json
        /// Method: GET
        /// URL: https\://nisportal.10010.com:9001/api</para>
        /// <h6>Request parameters</h6>
        /// <para>Request examples:
        /// JSON request: <c>?appid=1554778161153</c>
        /// JSONP request: <c>?appid=1554778161153&amp;callback=callbackFunction</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appid</c>: Use 1554778161153.</description></item>
        /// <item><description><c>callback</c>: The name of the JSONP callback function. This parameter is required only for JSONP requests.</description></item>
        /// </list>
        /// <h6>Response parameters</h6>
        /// <para>Response examples:
        /// JSON response:
        /// <c>{&quot;authurl&quot;: &quot;https://enrichgw.10010.com/d93222629f52ec79&quot;}</c>
        /// JSONP response:
        /// <c>callbackFunction({&quot;authurl&quot;:&quot;https://enrichgw.10010.com/d93222629f52ec79&quot;})</c>
        /// Retrieve the <c>authurl</c> from the response.</para>
        /// <h5>Step 2: Obtain the token</h5>
        /// <para>Protocol: HTTPS + application/json
        /// Method: GET
        /// URL: The authurl from Step 1, with /api appended.
        /// Request URL example: <c>https://enrichgw.10010.com/d93222629f52ec79/api</c></para>
        /// <h6>Request parameters</h6>
        /// <para>Request examples:
        /// JSON request: <c>?appid=1554778161153</c>
        /// JSONP request: <c>?appid=1554778161153&amp;callback=callbackFunction</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appid</c>: Use 1554778161153.</description></item>
        /// <item><description><c>callback</c>: The name of the JSONP callback function. This parameter is required only for JSONP requests.</description></item>
        /// </list>
        /// <h6>Response parameters</h6>
        /// <para>Response examples:
        /// JSON response:
        /// <c>{ &quot;province&quot;: &quot;1&quot;, &quot;code&quot;: &quot;7nHS1nggx2WP613750206700RN6oiRN1&quot; }</c>
        /// JSONP response:
        /// <c>callbackFunction({&quot;province&quot;:&quot;1&quot;,&quot;code&quot;:&quot;7nHS3Dnkd1BS701851092400RN6oiRN1&quot;})</c>
        /// Retrieve the <c>code</c> from the response.</para>
        /// <h4>China Telecom (CT)</h4>
        /// <para>Protocol: HTTPS + application/x-www-form-urlencoded;charset=UTF-8
        /// Method: GET
        /// URL: https\://id6.me/gw/preuniq.do</para>
        /// <h5>Request parameters</h5>
        /// <para>Request example:
        /// <c>?clientType=30100&amp;appId=9390188202&amp;format=json&amp;sign=D63C166FA19E1996EF********09C6A5397C10B4&amp;paramKey=1D7C25EB8B0B8B4CB3CF8DC60628F6549********786B0AF1FEF93FA1335057A35BF5F0B39A3867EAA9BE14B3898********8B01DE34965060445B6E1F66401D714650E4AB161CD6DCF4A72********3B856F22A192B8B0C39D7A55B961062E68C89C928894F119B25********7C548355FE9DB82852EB93C939F2200B48CD17&amp;paramStr=140********95AF8E138B94754CB4CF83BA6FB********52B258BFDFD38BF233&amp;version=1.1</c>
        /// Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><c>appId</c>: Use <c>9390188202</c>.</description></item>
        /// <item><description><c>clientType</c>: The client type. This value must match the <c>ClientType</c> input parameter for this API.</description></item>
        /// <item><description><c>format</c>: Use <c>json</c> or <c>jsonp</c>.</description></item>
        /// <item><description><c>version</c>: Use <c>1.1</c>.</description></item>
        /// <item><description><c>sign</c>: Obtained by calling this API.</description></item>
        /// <item><description><c>paramKey</c>: The ciphertext of key A. Key A is a 16-character random string generated by the client. To generate paramKey, encrypt key A using the RSA algorithm and the China Telecom public key. The padding mode is <c>RSA/ECB/PKCS1Padding</c>. Download the <a href="https://id.189.cn/source/files/API.pem">China Telecom RSA public key</a>.</description></item>
        /// <item><description><c>paramStr</c>: The ciphertext of a parameter string. This string contains <c>timeStamp</c> (a Unix timestamp with millisecond precision, for example <c>1697791988302</c>, that corresponds to the value of the <c>Time</c> parameter of this API) and <c>callback</c> (the name of the JSONP callback function, required only when <c>format</c> is set to <c>jsonp</c>). To generate <c>paramStr</c>, encrypt the string using AES with key A. The padding mode is <c>AES/CBC/PKCS5Padding</c>, and the initialization vector is <c>0000000000000000</c>.</description></item>
        /// </list>
        /// <h5>Response parameters</h5>
        /// <para>Response example:
        /// <c>callback?result=10000&amp;msg=success&amp;data=a35336711c70456cb883f4f224e9a259</c>
        /// The <c>data</c> parameter contains the ciphertext of the business result. To get the result, decrypt the data value using key A, the <c>AES/CBC/PKCS5Padding</c> mode, and an initialization vector of <c>0000000000000000</c>.
        /// Decrypted business result example:
        /// <c>{&quot;accessCode&quot;: &quot;H5HTTPS4187AE9743AFCB14F8D99B9D65ED9E01&quot;}</c>
        /// Retrieve the <c>accessCode</c> from the decrypted result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUAIDApplyTokenSignRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUAIDApplyTokenSignResponse
        /// </returns>
        public async Task<GetUAIDApplyTokenSignResponse> GetUAIDApplyTokenSignAsync(GetUAIDApplyTokenSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUAIDApplyTokenSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取号码采集服务申请Token所需的签名字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUAIDConversionSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUAIDConversionSignResponse
        /// </returns>
        public GetUAIDConversionSignResponse GetUAIDConversionSignWithOptions(GetUAIDConversionSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                query["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamKey))
            {
                query["ParamKey"] = request.ParamKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamStr))
            {
                query["ParamStr"] = request.ParamStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUAIDConversionSign",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUAIDConversionSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取号码采集服务申请Token所需的签名字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUAIDConversionSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUAIDConversionSignResponse
        /// </returns>
        public async Task<GetUAIDConversionSignResponse> GetUAIDConversionSignWithOptionsAsync(GetUAIDConversionSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Format))
            {
                query["Format"] = request.Format;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamKey))
            {
                query["ParamKey"] = request.ParamKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamStr))
            {
                query["ParamStr"] = request.ParamStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUAIDConversionSign",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUAIDConversionSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取号码采集服务申请Token所需的签名字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUAIDConversionSignRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUAIDConversionSignResponse
        /// </returns>
        public GetUAIDConversionSignResponse GetUAIDConversionSign(GetUAIDConversionSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUAIDConversionSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取号码采集服务申请Token所需的签名字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUAIDConversionSignRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUAIDConversionSignResponse
        /// </returns>
        public async Task<GetUAIDConversionSignResponse> GetUAIDConversionSignAsync(GetUAIDConversionSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUAIDConversionSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies whether a name, phone number, and ID number belonged to the same user at a specific point in time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Before you use this API, ensure you understand its <a href="https://help.aliyun.com/zh/cpns/product-overview/pricing-of-cpns">pricing</a>.</description></item>
        /// <item><description>Before you use this API, log on to the Phone Number Intelligence console and apply for the required tag on the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page.</description></item>
        /// <item><description>You are charged for a call only when the response returns <c>Code=\\&quot;OK\\&quot;</c> and <c>IsConsistent != 0</c>. No charges are incurred for any other results.</description></item>
        /// <item><description>Verification of China Broadcasting Network numbers (numbers with the 192 prefix) is not supported. If you provide a number with the 192 prefix, an HTTP 400 error is returned.</description></item>
        /// <item><description>Due to number portability, the actual carrier may differ from the current carrier of record. You can use the <c>Carrier</c> parameter to route the query to a specific carrier.</description></item>
        /// <item><description>The queries per second (QPS) limit per user is 200. Requests that exceed this limit are throttled.</description></item>
        /// <item><description>In the authorization information, the action is <c>dytns:HistoryThreeElementsVerification</c>, the access level is Read, and the resource type is All Resources.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// HistoryThreeElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HistoryThreeElementsVerificationResponse
        /// </returns>
        public HistoryThreeElementsVerificationResponse HistoryThreeElementsVerificationWithOptions(HistoryThreeElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertCode))
            {
                query["CertCode"] = request.CertCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationTime))
            {
                query["VerificationTime"] = request.VerificationTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HistoryThreeElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HistoryThreeElementsVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies whether a name, phone number, and ID number belonged to the same user at a specific point in time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Before you use this API, ensure you understand its <a href="https://help.aliyun.com/zh/cpns/product-overview/pricing-of-cpns">pricing</a>.</description></item>
        /// <item><description>Before you use this API, log on to the Phone Number Intelligence console and apply for the required tag on the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page.</description></item>
        /// <item><description>You are charged for a call only when the response returns <c>Code=\\&quot;OK\\&quot;</c> and <c>IsConsistent != 0</c>. No charges are incurred for any other results.</description></item>
        /// <item><description>Verification of China Broadcasting Network numbers (numbers with the 192 prefix) is not supported. If you provide a number with the 192 prefix, an HTTP 400 error is returned.</description></item>
        /// <item><description>Due to number portability, the actual carrier may differ from the current carrier of record. You can use the <c>Carrier</c> parameter to route the query to a specific carrier.</description></item>
        /// <item><description>The queries per second (QPS) limit per user is 200. Requests that exceed this limit are throttled.</description></item>
        /// <item><description>In the authorization information, the action is <c>dytns:HistoryThreeElementsVerification</c>, the access level is Read, and the resource type is All Resources.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// HistoryThreeElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HistoryThreeElementsVerificationResponse
        /// </returns>
        public async Task<HistoryThreeElementsVerificationResponse> HistoryThreeElementsVerificationWithOptionsAsync(HistoryThreeElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertCode))
            {
                query["CertCode"] = request.CertCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationTime))
            {
                query["VerificationTime"] = request.VerificationTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HistoryThreeElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HistoryThreeElementsVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies whether a name, phone number, and ID number belonged to the same user at a specific point in time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Before you use this API, ensure you understand its <a href="https://help.aliyun.com/zh/cpns/product-overview/pricing-of-cpns">pricing</a>.</description></item>
        /// <item><description>Before you use this API, log on to the Phone Number Intelligence console and apply for the required tag on the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page.</description></item>
        /// <item><description>You are charged for a call only when the response returns <c>Code=\\&quot;OK\\&quot;</c> and <c>IsConsistent != 0</c>. No charges are incurred for any other results.</description></item>
        /// <item><description>Verification of China Broadcasting Network numbers (numbers with the 192 prefix) is not supported. If you provide a number with the 192 prefix, an HTTP 400 error is returned.</description></item>
        /// <item><description>Due to number portability, the actual carrier may differ from the current carrier of record. You can use the <c>Carrier</c> parameter to route the query to a specific carrier.</description></item>
        /// <item><description>The queries per second (QPS) limit per user is 200. Requests that exceed this limit are throttled.</description></item>
        /// <item><description>In the authorization information, the action is <c>dytns:HistoryThreeElementsVerification</c>, the access level is Read, and the resource type is All Resources.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// HistoryThreeElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// HistoryThreeElementsVerificationResponse
        /// </returns>
        public HistoryThreeElementsVerificationResponse HistoryThreeElementsVerification(HistoryThreeElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HistoryThreeElementsVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies whether a name, phone number, and ID number belonged to the same user at a specific point in time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>Before you use this API, ensure you understand its <a href="https://help.aliyun.com/zh/cpns/product-overview/pricing-of-cpns">pricing</a>.</description></item>
        /// <item><description>Before you use this API, log on to the Phone Number Intelligence console and apply for the required tag on the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page.</description></item>
        /// <item><description>You are charged for a call only when the response returns <c>Code=\\&quot;OK\\&quot;</c> and <c>IsConsistent != 0</c>. No charges are incurred for any other results.</description></item>
        /// <item><description>Verification of China Broadcasting Network numbers (numbers with the 192 prefix) is not supported. If you provide a number with the 192 prefix, an HTTP 400 error is returned.</description></item>
        /// <item><description>Due to number portability, the actual carrier may differ from the current carrier of record. You can use the <c>Carrier</c> parameter to route the query to a specific carrier.</description></item>
        /// <item><description>The queries per second (QPS) limit per user is 200. Requests that exceed this limit are throttled.</description></item>
        /// <item><description>In the authorization information, the action is <c>dytns:HistoryThreeElementsVerification</c>, the access level is Read, and the resource type is All Resources.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// HistoryThreeElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// HistoryThreeElementsVerificationResponse
        /// </returns>
        public async Task<HistoryThreeElementsVerificationResponse> HistoryThreeElementsVerificationAsync(HistoryThreeElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HistoryThreeElementsVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs invalid phone number filtering operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use this operation after the application is approved.</para>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 1,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InvalidPhoneNumberFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvalidPhoneNumberFilterResponse
        /// </returns>
        public InvalidPhoneNumberFilterResponse InvalidPhoneNumberFilterWithOptions(InvalidPhoneNumberFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvalidPhoneNumberFilter",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvalidPhoneNumberFilterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs invalid phone number filtering operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use this operation after the application is approved.</para>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 1,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InvalidPhoneNumberFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvalidPhoneNumberFilterResponse
        /// </returns>
        public async Task<InvalidPhoneNumberFilterResponse> InvalidPhoneNumberFilterWithOptionsAsync(InvalidPhoneNumberFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvalidPhoneNumberFilter",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvalidPhoneNumberFilterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs invalid phone number filtering operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use this operation after the application is approved.</para>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 1,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InvalidPhoneNumberFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// InvalidPhoneNumberFilterResponse
        /// </returns>
        public InvalidPhoneNumberFilterResponse InvalidPhoneNumberFilter(InvalidPhoneNumberFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvalidPhoneNumberFilterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs invalid phone number filtering operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and submit the application materials. You can use this operation after the application is approved.</para>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this operation is 1,000 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InvalidPhoneNumberFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// InvalidPhoneNumberFilterResponse
        /// </returns>
        public async Task<InvalidPhoneNumberFilterResponse> InvalidPhoneNumberFilterAsync(InvalidPhoneNumberFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvalidPhoneNumberFilterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the alert contacts for Number Encyclopedia.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, ensure that you have activated Number Encyclopedia.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContactsResponse
        /// </returns>
        public ListContactsResponse ListContactsWithOptions(ListContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContacts",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the alert contacts for Number Encyclopedia.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, ensure that you have activated Number Encyclopedia.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContactsResponse
        /// </returns>
        public async Task<ListContactsResponse> ListContactsWithOptionsAsync(ListContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContacts",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the alert contacts for Number Encyclopedia.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, ensure that you have activated Number Encyclopedia.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContactsResponse
        /// </returns>
        public ListContactsResponse ListContacts(ListContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContactsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the alert contacts for Number Encyclopedia.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, ensure that you have activated Number Encyclopedia.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContactsResponse
        /// </returns>
        public async Task<ListContactsResponse> ListContactsAsync(ListContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContactsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// PhoneNumberConvertServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberConvertServiceResponse
        /// </returns>
        public PhoneNumberConvertServiceResponse PhoneNumberConvertServiceWithOptions(PhoneNumberConvertServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberConvertService",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberConvertServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// PhoneNumberConvertServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberConvertServiceResponse
        /// </returns>
        public async Task<PhoneNumberConvertServiceResponse> PhoneNumberConvertServiceWithOptionsAsync(PhoneNumberConvertServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberConvertService",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberConvertServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PhoneNumberConvertServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberConvertServiceResponse
        /// </returns>
        public PhoneNumberConvertServiceResponse PhoneNumberConvertService(PhoneNumberConvertServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PhoneNumberConvertServiceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PhoneNumberConvertServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberConvertServiceResponse
        /// </returns>
        public async Task<PhoneNumberConvertServiceResponse> PhoneNumberConvertServiceAsync(PhoneNumberConvertServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PhoneNumberConvertServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts an original phone number into a virtual phone number that starts with 140. By integrating with Alibaba Cloud communication services, you can use the encrypted 140 phone number to initiate voice calls, achieving the effect of a virtual phone number call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and fill in the application materials. You can use this API after the application is approved.</para>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this API is 1,000 calls per second. If the number of API calls exceeds the limit, the calls will be throttled, which may affect your business. Call the API properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberEncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberEncryptResponse
        /// </returns>
        public PhoneNumberEncryptResponse PhoneNumberEncryptWithOptions(PhoneNumberEncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberEncrypt",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberEncryptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts an original phone number into a virtual phone number that starts with 140. By integrating with Alibaba Cloud communication services, you can use the encrypted 140 phone number to initiate voice calls, achieving the effect of a virtual phone number call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and fill in the application materials. You can use this API after the application is approved.</para>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this API is 1,000 calls per second. If the number of API calls exceeds the limit, the calls will be throttled, which may affect your business. Call the API properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberEncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberEncryptResponse
        /// </returns>
        public async Task<PhoneNumberEncryptResponse> PhoneNumberEncryptWithOptionsAsync(PhoneNumberEncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberEncrypt",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberEncryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts an original phone number into a virtual phone number that starts with 140. By integrating with Alibaba Cloud communication services, you can use the encrypted 140 phone number to initiate voice calls, achieving the effect of a virtual phone number call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and fill in the application materials. You can use this API after the application is approved.</para>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this API is 1,000 calls per second. If the number of API calls exceeds the limit, the calls will be throttled, which may affect your business. Call the API properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberEncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberEncryptResponse
        /// </returns>
        public PhoneNumberEncryptResponse PhoneNumberEncrypt(PhoneNumberEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PhoneNumberEncryptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts an original phone number into a virtual phone number that starts with 140. By integrating with Alibaba Cloud communication services, you can use the encrypted 140 phone number to initiate voice calls, achieving the effect of a virtual phone number call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the corresponding tag, click <b>Apply for Activation</b>, and fill in the application materials. You can use this API after the application is approved.</para>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this API is 1,000 calls per second. If the number of API calls exceeds the limit, the calls will be throttled, which may affect your business. Call the API properly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberEncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberEncryptResponse
        /// </returns>
        public async Task<PhoneNumberEncryptResponse> PhoneNumberEncryptAsync(PhoneNumberEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PhoneNumberEncryptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time network status of a mobile phone number, such as active, shutdown, or non-existent. You can query numbers that are in plaintext or hashed using MD5 or SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you use this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user can call this operation only after receiving the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you use this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the required tag, click <b>Apply</b>, and then submit the required information. You can use this operation once your application is approved.</description></item>
        /// <item><description>The phone number status query feature supports numbers from China Telecom, China Unicom, and China Mobile. This feature does not support numbers from China Broadnet. If you call this operation to query a China Broadnet number, the API returns the error code <c>OperatorLimit</c>, which indicates that the query is prohibited by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This operation has a queries per second (QPS) limit of 300 per user. If you exceed this limit, your API calls are throttled, which may affect your services. We recommend that you call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForAccountResponse
        /// </returns>
        public PhoneNumberStatusForAccountResponse PhoneNumberStatusForAccountWithOptions(PhoneNumberStatusForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberStatusForAccount",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time network status of a mobile phone number, such as active, shutdown, or non-existent. You can query numbers that are in plaintext or hashed using MD5 or SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you use this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user can call this operation only after receiving the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you use this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the required tag, click <b>Apply</b>, and then submit the required information. You can use this operation once your application is approved.</description></item>
        /// <item><description>The phone number status query feature supports numbers from China Telecom, China Unicom, and China Mobile. This feature does not support numbers from China Broadnet. If you call this operation to query a China Broadnet number, the API returns the error code <c>OperatorLimit</c>, which indicates that the query is prohibited by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This operation has a queries per second (QPS) limit of 300 per user. If you exceed this limit, your API calls are throttled, which may affect your services. We recommend that you call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForAccountResponse
        /// </returns>
        public async Task<PhoneNumberStatusForAccountResponse> PhoneNumberStatusForAccountWithOptionsAsync(PhoneNumberStatusForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberStatusForAccount",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time network status of a mobile phone number, such as active, shutdown, or non-existent. You can query numbers that are in plaintext or hashed using MD5 or SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you use this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user can call this operation only after receiving the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you use this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the required tag, click <b>Apply</b>, and then submit the required information. You can use this operation once your application is approved.</description></item>
        /// <item><description>The phone number status query feature supports numbers from China Telecom, China Unicom, and China Mobile. This feature does not support numbers from China Broadnet. If you call this operation to query a China Broadnet number, the API returns the error code <c>OperatorLimit</c>, which indicates that the query is prohibited by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This operation has a queries per second (QPS) limit of 300 per user. If you exceed this limit, your API calls are throttled, which may affect your services. We recommend that you call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForAccountResponse
        /// </returns>
        public PhoneNumberStatusForAccountResponse PhoneNumberStatusForAccount(PhoneNumberStatusForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PhoneNumberStatusForAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time network status of a mobile phone number, such as active, shutdown, or non-existent. You can query numbers that are in plaintext or hashed using MD5 or SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you use this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user can call this operation only after receiving the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you use this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Plaza</a> page, find the required tag, click <b>Apply</b>, and then submit the required information. You can use this operation once your application is approved.</description></item>
        /// <item><description>The phone number status query feature supports numbers from China Telecom, China Unicom, and China Mobile. This feature does not support numbers from China Broadnet. If you call this operation to query a China Broadnet number, the API returns the error code <c>OperatorLimit</c>, which indicates that the query is prohibited by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This operation has a queries per second (QPS) limit of 300 per user. If you exceed this limit, your API calls are throttled, which may affect your services. We recommend that you call this operation at a reasonable frequency.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForAccountResponse
        /// </returns>
        public async Task<PhoneNumberStatusForAccountResponse> PhoneNumberStatusForAccountAsync(PhoneNumberStatusForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PhoneNumberStatusForAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time status of a mobile phone number to determine whether it is in service, suspended, or non-existent. This operation supports queries for plaintext numbers or numbers encrypted with MD5 or SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user must be granted the required permissions before calling this operation. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before calling this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Apply</b>, and submit your application. You can use the operation after your application is approved.</description></item>
        /// <item><description>The number status query feature supports numbers from China Telecom, China Unicom, and China Mobile, but does not support numbers from China Broadnet. If you call this operation to query the status of a China Broadnet number, the <c>OperatorLimit</c> error code is returned, which indicates that the query is prohibited by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The queries per second (QPS) limit for each user is 300. API calls that exceed this limit are throttled. To avoid business disruptions, plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForPublicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForPublicResponse
        /// </returns>
        public PhoneNumberStatusForPublicResponse PhoneNumberStatusForPublicWithOptions(PhoneNumberStatusForPublicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberStatusForPublic",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForPublicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time status of a mobile phone number to determine whether it is in service, suspended, or non-existent. This operation supports queries for plaintext numbers or numbers encrypted with MD5 or SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user must be granted the required permissions before calling this operation. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before calling this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Apply</b>, and submit your application. You can use the operation after your application is approved.</description></item>
        /// <item><description>The number status query feature supports numbers from China Telecom, China Unicom, and China Mobile, but does not support numbers from China Broadnet. If you call this operation to query the status of a China Broadnet number, the <c>OperatorLimit</c> error code is returned, which indicates that the query is prohibited by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The queries per second (QPS) limit for each user is 300. API calls that exceed this limit are throttled. To avoid business disruptions, plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForPublicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForPublicResponse
        /// </returns>
        public async Task<PhoneNumberStatusForPublicResponse> PhoneNumberStatusForPublicWithOptionsAsync(PhoneNumberStatusForPublicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberStatusForPublic",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForPublicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time status of a mobile phone number to determine whether it is in service, suspended, or non-existent. This operation supports queries for plaintext numbers or numbers encrypted with MD5 or SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user must be granted the required permissions before calling this operation. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before calling this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Apply</b>, and submit your application. You can use the operation after your application is approved.</description></item>
        /// <item><description>The number status query feature supports numbers from China Telecom, China Unicom, and China Mobile, but does not support numbers from China Broadnet. If you call this operation to query the status of a China Broadnet number, the <c>OperatorLimit</c> error code is returned, which indicates that the query is prohibited by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The queries per second (QPS) limit for each user is 300. API calls that exceed this limit are throttled. To avoid business disruptions, plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForPublicRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForPublicResponse
        /// </returns>
        public PhoneNumberStatusForPublicResponse PhoneNumberStatusForPublic(PhoneNumberStatusForPublicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PhoneNumberStatusForPublicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time status of a mobile phone number to determine whether it is in service, suspended, or non-existent. This operation supports queries for plaintext numbers or numbers encrypted with MD5 or SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user must be granted the required permissions before calling this operation. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before calling this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Apply</b>, and submit your application. You can use the operation after your application is approved.</description></item>
        /// <item><description>The number status query feature supports numbers from China Telecom, China Unicom, and China Mobile, but does not support numbers from China Broadnet. If you call this operation to query the status of a China Broadnet number, the <c>OperatorLimit</c> error code is returned, which indicates that the query is prohibited by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The queries per second (QPS) limit for each user is 300. API calls that exceed this limit are throttled. To avoid business disruptions, plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForPublicRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForPublicResponse
        /// </returns>
        public async Task<PhoneNumberStatusForPublicResponse> PhoneNumberStatusForPublicAsync(PhoneNumberStatusForPublicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PhoneNumberStatusForPublicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time status of a mobile phone number, such as normal, suspended, or not in service. This operation supports queries for phone numbers that are in plaintext or encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before calling this operation, ensure you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. To allow a RAM user to call this operation, you must first grant the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Request Activation</b>, and then submit your application. You can call this operation only after your application is approved.</description></item>
        /// <item><description>This operation supports phone numbers from China Telecom, China Unicom, and China Mobile. Numbers from China Broadnet are not supported. If you call this operation to query a China Broadnet number, the API returns the error code <c>OperatorLimit</c> and an error message indicating that the query is restricted by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this operation is 300 queries per second (QPS) per user. The system throttles calls that exceed this limit, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForRealRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForRealResponse
        /// </returns>
        public PhoneNumberStatusForRealResponse PhoneNumberStatusForRealWithOptions(PhoneNumberStatusForRealRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberStatusForReal",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForRealResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time status of a mobile phone number, such as normal, suspended, or not in service. This operation supports queries for phone numbers that are in plaintext or encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before calling this operation, ensure you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. To allow a RAM user to call this operation, you must first grant the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Request Activation</b>, and then submit your application. You can call this operation only after your application is approved.</description></item>
        /// <item><description>This operation supports phone numbers from China Telecom, China Unicom, and China Mobile. Numbers from China Broadnet are not supported. If you call this operation to query a China Broadnet number, the API returns the error code <c>OperatorLimit</c> and an error message indicating that the query is restricted by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this operation is 300 queries per second (QPS) per user. The system throttles calls that exceed this limit, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForRealRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForRealResponse
        /// </returns>
        public async Task<PhoneNumberStatusForRealResponse> PhoneNumberStatusForRealWithOptionsAsync(PhoneNumberStatusForRealRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberStatusForReal",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForRealResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time status of a mobile phone number, such as normal, suspended, or not in service. This operation supports queries for phone numbers that are in plaintext or encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before calling this operation, ensure you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. To allow a RAM user to call this operation, you must first grant the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Request Activation</b>, and then submit your application. You can call this operation only after your application is approved.</description></item>
        /// <item><description>This operation supports phone numbers from China Telecom, China Unicom, and China Mobile. Numbers from China Broadnet are not supported. If you call this operation to query a China Broadnet number, the API returns the error code <c>OperatorLimit</c> and an error message indicating that the query is restricted by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this operation is 300 queries per second (QPS) per user. The system throttles calls that exceed this limit, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForRealRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForRealResponse
        /// </returns>
        public PhoneNumberStatusForRealResponse PhoneNumberStatusForReal(PhoneNumberStatusForRealRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PhoneNumberStatusForRealWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time status of a mobile phone number, such as normal, suspended, or not in service. This operation supports queries for phone numbers that are in plaintext or encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before calling this operation, ensure you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Intelligence.</b></description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. To allow a RAM user to call this operation, you must first grant the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, log on to the Phone Number Intelligence console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Request Activation</b>, and then submit your application. You can call this operation only after your application is approved.</description></item>
        /// <item><description>This operation supports phone numbers from China Telecom, China Unicom, and China Mobile. Numbers from China Broadnet are not supported. If you call this operation to query a China Broadnet number, the API returns the error code <c>OperatorLimit</c> and an error message indicating that the query is restricted by the carrier.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for this operation is 300 queries per second (QPS) per user. The system throttles calls that exceed this limit, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForRealRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForRealResponse
        /// </returns>
        public async Task<PhoneNumberStatusForRealResponse> PhoneNumberStatusForRealAsync(PhoneNumberStatusForRealRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PhoneNumberStatusForRealWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time network status of a phone number, such as active, shutdown, or non-existent. This operation supports queries for numbers in plaintext or numbers encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you call this operation, make sure you understand the <a href="https://help.aliyun.com/document_detail/154751.html">Product Pricing</a> of Phone Number Pedia</b>.</description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user can call this operation only after being granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>Before calling this operation, log on to the Phone Number Pedia console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Request Activation</b>, and then complete the application form. You can use this operation only after your application is approved.</description></item>
        /// <item><description>This feature supports phone numbers from China Telecom, China Unicom, and China Mobile, but does not support phone numbers from China Broadnet. If you call this operation to query the status of a China Broadnet number, the <c>OperatorLimit</c> error code and the &quot;The number is limited by the operator.&quot; message are returned.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This operation is limited to 300 queries per second (QPS) for each user. Calls that exceed this limit are throttled, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForSmsResponse
        /// </returns>
        public PhoneNumberStatusForSmsResponse PhoneNumberStatusForSmsWithOptions(PhoneNumberStatusForSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberStatusForSms",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForSmsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time network status of a phone number, such as active, shutdown, or non-existent. This operation supports queries for numbers in plaintext or numbers encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you call this operation, make sure you understand the <a href="https://help.aliyun.com/document_detail/154751.html">Product Pricing</a> of Phone Number Pedia</b>.</description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user can call this operation only after being granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>Before calling this operation, log on to the Phone Number Pedia console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Request Activation</b>, and then complete the application form. You can use this operation only after your application is approved.</description></item>
        /// <item><description>This feature supports phone numbers from China Telecom, China Unicom, and China Mobile, but does not support phone numbers from China Broadnet. If you call this operation to query the status of a China Broadnet number, the <c>OperatorLimit</c> error code and the &quot;The number is limited by the operator.&quot; message are returned.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This operation is limited to 300 queries per second (QPS) for each user. Calls that exceed this limit are throttled, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForSmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForSmsResponse
        /// </returns>
        public async Task<PhoneNumberStatusForSmsResponse> PhoneNumberStatusForSmsWithOptionsAsync(PhoneNumberStatusForSmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberStatusForSms",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForSmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time network status of a phone number, such as active, shutdown, or non-existent. This operation supports queries for numbers in plaintext or numbers encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you call this operation, make sure you understand the <a href="https://help.aliyun.com/document_detail/154751.html">Product Pricing</a> of Phone Number Pedia</b>.</description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user can call this operation only after being granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>Before calling this operation, log on to the Phone Number Pedia console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Request Activation</b>, and then complete the application form. You can use this operation only after your application is approved.</description></item>
        /// <item><description>This feature supports phone numbers from China Telecom, China Unicom, and China Mobile, but does not support phone numbers from China Broadnet. If you call this operation to query the status of a China Broadnet number, the <c>OperatorLimit</c> error code and the &quot;The number is limited by the operator.&quot; message are returned.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This operation is limited to 300 queries per second (QPS) for each user. Calls that exceed this limit are throttled, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForSmsResponse
        /// </returns>
        public PhoneNumberStatusForSmsResponse PhoneNumberStatusForSms(PhoneNumberStatusForSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PhoneNumberStatusForSmsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the real-time network status of a phone number, such as active, shutdown, or non-existent. This operation supports queries for numbers in plaintext or numbers encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you call this operation, make sure you understand the <a href="https://help.aliyun.com/document_detail/154751.html">Product Pricing</a> of Phone Number Pedia</b>.</description></item>
        /// <item><description>By default, only an Alibaba Cloud account can call this operation. A RAM user can call this operation only after being granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>Before calling this operation, log on to the Phone Number Pedia console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Request Activation</b>, and then complete the application form. You can use this operation only after your application is approved.</description></item>
        /// <item><description>This feature supports phone numbers from China Telecom, China Unicom, and China Mobile, but does not support phone numbers from China Broadnet. If you call this operation to query the status of a China Broadnet number, the <c>OperatorLimit</c> error code and the &quot;The number is limited by the operator.&quot; message are returned.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>This operation is limited to 300 queries per second (QPS) for each user. Calls that exceed this limit are throttled, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForSmsRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForSmsResponse
        /// </returns>
        public async Task<PhoneNumberStatusForSmsResponse> PhoneNumberStatusForSmsAsync(PhoneNumberStatusForSmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PhoneNumberStatusForSmsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time network status of a mobile phone number, such as normal, shutdown, or non-existent. This operation supports queries for numbers in plaintext and numbers encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you use this API, make sure that you understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Encyclopedia</b>.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can call this API. To allow a RAM user to do so, you must grant them the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you use this API, log in to the Phone Number Encyclopedia console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Apply for Access</b>, and then complete the application form. You can call this API after your application is approved.</description></item>
        /// <item><description>This feature supports phone numbers from China Telecom, China Unicom, and China Mobile, but not from China Broadnet. If you query a China Broadnet number, the <c>OperatorLimit</c> error code and an error message are returned: The number is limited by the operator.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 300 queries per second. If you exceed this limit, the system throttles your API calls, which may impact your business. To avoid interruptions, call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForVoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForVoiceResponse
        /// </returns>
        public PhoneNumberStatusForVoiceResponse PhoneNumberStatusForVoiceWithOptions(PhoneNumberStatusForVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberStatusForVoice",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForVoiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time network status of a mobile phone number, such as normal, shutdown, or non-existent. This operation supports queries for numbers in plaintext and numbers encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you use this API, make sure that you understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Encyclopedia</b>.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can call this API. To allow a RAM user to do so, you must grant them the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you use this API, log in to the Phone Number Encyclopedia console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Apply for Access</b>, and then complete the application form. You can call this API after your application is approved.</description></item>
        /// <item><description>This feature supports phone numbers from China Telecom, China Unicom, and China Mobile, but not from China Broadnet. If you query a China Broadnet number, the <c>OperatorLimit</c> error code and an error message are returned: The number is limited by the operator.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 300 queries per second. If you exceed this limit, the system throttles your API calls, which may impact your business. To avoid interruptions, call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForVoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForVoiceResponse
        /// </returns>
        public async Task<PhoneNumberStatusForVoiceResponse> PhoneNumberStatusForVoiceWithOptionsAsync(PhoneNumberStatusForVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PhoneNumberStatusForVoice",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForVoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time network status of a mobile phone number, such as normal, shutdown, or non-existent. This operation supports queries for numbers in plaintext and numbers encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you use this API, make sure that you understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Encyclopedia</b>.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can call this API. To allow a RAM user to do so, you must grant them the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you use this API, log in to the Phone Number Encyclopedia console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Apply for Access</b>, and then complete the application form. You can call this API after your application is approved.</description></item>
        /// <item><description>This feature supports phone numbers from China Telecom, China Unicom, and China Mobile, but not from China Broadnet. If you query a China Broadnet number, the <c>OperatorLimit</c> error code and an error message are returned: The number is limited by the operator.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 300 queries per second. If you exceed this limit, the system throttles your API calls, which may impact your business. To avoid interruptions, call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForVoiceResponse
        /// </returns>
        public PhoneNumberStatusForVoiceResponse PhoneNumberStatusForVoice(PhoneNumberStatusForVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PhoneNumberStatusForVoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time network status of a mobile phone number, such as normal, shutdown, or non-existent. This operation supports queries for numbers in plaintext and numbers encrypted by using MD5, SHA256, or SM3.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Before you use this API, make sure that you understand the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Phone Number Encyclopedia</b>.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can call this API. To allow a RAM user to do so, you must grant them the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you use this API, log in to the Phone Number Encyclopedia console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the required tag, click <b>Apply for Access</b>, and then complete the application form. You can call this API after your application is approved.</description></item>
        /// <item><description>This feature supports phone numbers from China Telecom, China Unicom, and China Mobile, but not from China Broadnet. If you query a China Broadnet number, the <c>OperatorLimit</c> error code and an error message are returned: The number is limited by the operator.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit for a single user is 300 queries per second. If you exceed this limit, the system throttles your API calls, which may impact your business. To avoid interruptions, call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForVoiceResponse
        /// </returns>
        public async Task<PhoneNumberStatusForVoiceResponse> PhoneNumberStatusForVoiceAsync(PhoneNumberStatusForVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PhoneNumberStatusForVoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available authorization codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableAuthCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableAuthCodeResponse
        /// </returns>
        public QueryAvailableAuthCodeResponse QueryAvailableAuthCodeWithOptions(QueryAvailableAuthCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvailableAuthCode",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvailableAuthCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available authorization codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableAuthCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableAuthCodeResponse
        /// </returns>
        public async Task<QueryAvailableAuthCodeResponse> QueryAvailableAuthCodeWithOptionsAsync(QueryAvailableAuthCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvailableAuthCode",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvailableAuthCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available authorization codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableAuthCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableAuthCodeResponse
        /// </returns>
        public QueryAvailableAuthCodeResponse QueryAvailableAuthCode(QueryAvailableAuthCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAvailableAuthCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available authorization codes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableAuthCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableAuthCodeResponse
        /// </returns>
        public async Task<QueryAvailableAuthCodeResponse> QueryAvailableAuthCodeAsync(QueryAvailableAuthCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAvailableAuthCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries package type information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPackageTypeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPackageTypeInfoResponse
        /// </returns>
        public QueryPackageTypeInfoResponse QueryPackageTypeInfoWithOptions(QueryPackageTypeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPackageTypeInfo",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPackageTypeInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries package type information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPackageTypeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPackageTypeInfoResponse
        /// </returns>
        public async Task<QueryPackageTypeInfoResponse> QueryPackageTypeInfoWithOptionsAsync(QueryPackageTypeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPackageTypeInfo",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPackageTypeInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries package type information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPackageTypeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPackageTypeInfoResponse
        /// </returns>
        public QueryPackageTypeInfoResponse QueryPackageTypeInfo(QueryPackageTypeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPackageTypeInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries package type information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPackageTypeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPackageTypeInfoResponse
        /// </returns>
        public async Task<QueryPackageTypeInfoResponse> QueryPackageTypeInfoAsync(QueryPackageTypeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPackageTypeInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在网时长专用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPhoneNumberOnlineTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneNumberOnlineTimeResponse
        /// </returns>
        public QueryPhoneNumberOnlineTimeResponse QueryPhoneNumberOnlineTimeWithOptions(QueryPhoneNumberOnlineTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPhoneNumberOnlineTime",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPhoneNumberOnlineTimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在网时长专用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPhoneNumberOnlineTimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneNumberOnlineTimeResponse
        /// </returns>
        public async Task<QueryPhoneNumberOnlineTimeResponse> QueryPhoneNumberOnlineTimeWithOptionsAsync(QueryPhoneNumberOnlineTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPhoneNumberOnlineTime",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPhoneNumberOnlineTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在网时长专用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPhoneNumberOnlineTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneNumberOnlineTimeResponse
        /// </returns>
        public QueryPhoneNumberOnlineTimeResponse QueryPhoneNumberOnlineTime(QueryPhoneNumberOnlineTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPhoneNumberOnlineTimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在网时长专用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPhoneNumberOnlineTimeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneNumberOnlineTimeResponse
        /// </returns>
        public async Task<QueryPhoneNumberOnlineTimeResponse> QueryPhoneNumberOnlineTimeAsync(QueryPhoneNumberOnlineTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPhoneNumberOnlineTimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二次号携号转网号码查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPhoneTwiceTelVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneTwiceTelVerifyResponse
        /// </returns>
        public QueryPhoneTwiceTelVerifyResponse QueryPhoneTwiceTelVerifyWithOptions(QueryPhoneTwiceTelVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPhoneTwiceTelVerify",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPhoneTwiceTelVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二次号携号转网号码查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPhoneTwiceTelVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneTwiceTelVerifyResponse
        /// </returns>
        public async Task<QueryPhoneTwiceTelVerifyResponse> QueryPhoneTwiceTelVerifyWithOptionsAsync(QueryPhoneTwiceTelVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPhoneTwiceTelVerify",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPhoneTwiceTelVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二次号携号转网号码查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPhoneTwiceTelVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneTwiceTelVerifyResponse
        /// </returns>
        public QueryPhoneTwiceTelVerifyResponse QueryPhoneTwiceTelVerify(QueryPhoneTwiceTelVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPhoneTwiceTelVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>二次号携号转网号码查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPhoneTwiceTelVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPhoneTwiceTelVerifyResponse
        /// </returns>
        public async Task<QueryPhoneTwiceTelVerifyResponse> QueryPhoneTwiceTelVerifyAsync(QueryPhoneTwiceTelVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPhoneTwiceTelVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag application rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagApplyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTagApplyRuleResponse
        /// </returns>
        public QueryTagApplyRuleResponse QueryTagApplyRuleWithOptions(QueryTagApplyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTagApplyRule",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagApplyRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag application rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagApplyRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTagApplyRuleResponse
        /// </returns>
        public async Task<QueryTagApplyRuleResponse> QueryTagApplyRuleWithOptionsAsync(QueryTagApplyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTagApplyRule",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagApplyRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag application rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagApplyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTagApplyRuleResponse
        /// </returns>
        public QueryTagApplyRuleResponse QueryTagApplyRule(QueryTagApplyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTagApplyRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag application rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagApplyRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTagApplyRuleResponse
        /// </returns>
        public async Task<QueryTagApplyRuleResponse> QueryTagApplyRuleAsync(QueryTagApplyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTagApplyRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagInfoBySelectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTagInfoBySelectionResponse
        /// </returns>
        public QueryTagInfoBySelectionResponse QueryTagInfoBySelectionWithOptions(QueryTagInfoBySelectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryId))
            {
                query["IndustryId"] = request.IndustryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTagInfoBySelection",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagInfoBySelectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagInfoBySelectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTagInfoBySelectionResponse
        /// </returns>
        public async Task<QueryTagInfoBySelectionResponse> QueryTagInfoBySelectionWithOptionsAsync(QueryTagInfoBySelectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryId))
            {
                query["IndustryId"] = request.IndustryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTagInfoBySelection",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagInfoBySelectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagInfoBySelectionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTagInfoBySelectionResponse
        /// </returns>
        public QueryTagInfoBySelectionResponse QueryTagInfoBySelection(QueryTagInfoBySelectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTagInfoBySelectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tag information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagInfoBySelectionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTagInfoBySelectionResponse
        /// </returns>
        public async Task<QueryTagInfoBySelectionResponse> QueryTagInfoBySelectionAsync(QueryTagInfoBySelectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTagInfoBySelectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag list by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagListPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTagListPageResponse
        /// </returns>
        public QueryTagListPageResponse QueryTagListPageWithOptions(QueryTagListPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTagListPage",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagListPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag list by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagListPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTagListPageResponse
        /// </returns>
        public async Task<QueryTagListPageResponse> QueryTagListPageWithOptionsAsync(QueryTagListPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTagListPage",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagListPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag list by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagListPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTagListPageResponse
        /// </returns>
        public QueryTagListPageResponse QueryTagListPage(QueryTagListPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTagListPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag list by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTagListPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTagListPageResponse
        /// </returns>
        public async Task<QueryTagListPageResponse> QueryTagListPageAsync(QueryTagListPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTagListPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of offline tasks.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskListResponse
        /// </returns>
        public QueryTaskListResponse QueryTaskListWithOptions(QueryTaskListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTaskListShrinkRequest request = new QueryTaskListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Result))
            {
                request.ResultShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Result, "Result", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskType))
            {
                request.TaskTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskType, "TaskType", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultShrink))
            {
                query["Result"] = request.ResultShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTypeShrink))
            {
                query["TaskType"] = request.TaskTypeShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskList",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of offline tasks.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskListResponse
        /// </returns>
        public async Task<QueryTaskListResponse> QueryTaskListWithOptionsAsync(QueryTaskListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryTaskListShrinkRequest request = new QueryTaskListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Result))
            {
                request.ResultShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Result, "Result", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskType))
            {
                request.TaskTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskType, "TaskType", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultShrink))
            {
                query["Result"] = request.ResultShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTypeShrink))
            {
                query["TaskType"] = request.TaskTypeShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskList",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of offline tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskListResponse
        /// </returns>
        public QueryTaskListResponse QueryTaskList(QueryTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of offline tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskListResponse
        /// </returns>
        public async Task<QueryTaskListResponse> QueryTaskListAsync(QueryTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries usage statistics by tag ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUsageStatisticsByTagIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUsageStatisticsByTagIdResponse
        /// </returns>
        public QueryUsageStatisticsByTagIdResponse QueryUsageStatisticsByTagIdWithOptions(QueryUsageStatisticsByTagIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUsageStatisticsByTagId",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUsageStatisticsByTagIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries usage statistics by tag ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUsageStatisticsByTagIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUsageStatisticsByTagIdResponse
        /// </returns>
        public async Task<QueryUsageStatisticsByTagIdResponse> QueryUsageStatisticsByTagIdWithOptionsAsync(QueryUsageStatisticsByTagIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUsageStatisticsByTagId",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUsageStatisticsByTagIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries usage statistics by tag ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUsageStatisticsByTagIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUsageStatisticsByTagIdResponse
        /// </returns>
        public QueryUsageStatisticsByTagIdResponse QueryUsageStatisticsByTagId(QueryUsageStatisticsByTagIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUsageStatisticsByTagIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries usage statistics by tag ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUsageStatisticsByTagIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUsageStatisticsByTagIdResponse
        /// </returns>
        public async Task<QueryUsageStatisticsByTagIdResponse> QueryUsageStatisticsByTagIdAsync(QueryUsageStatisticsByTagIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUsageStatisticsByTagIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, ensure you have activated Phone Number Intelligence.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveContactsResponse
        /// </returns>
        public SaveContactsResponse SaveContactsWithOptions(SaveContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                query["ContactPhone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailStatus))
            {
                query["MailStatus"] = request.MailStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenStatusWarning))
            {
                query["OpenStatusWarning"] = request.OpenStatusWarning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpentAttributionWarning))
            {
                query["OpentAttributionWarning"] = request.OpentAttributionWarning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneStatus))
            {
                query["PhoneStatus"] = request.PhoneStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContacts",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContactsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, ensure you have activated Phone Number Intelligence.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveContactsResponse
        /// </returns>
        public async Task<SaveContactsResponse> SaveContactsWithOptionsAsync(SaveContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                query["ContactPhone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailStatus))
            {
                query["MailStatus"] = request.MailStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenStatusWarning))
            {
                query["OpenStatusWarning"] = request.OpenStatusWarning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpentAttributionWarning))
            {
                query["OpentAttributionWarning"] = request.OpentAttributionWarning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneStatus))
            {
                query["PhoneStatus"] = request.PhoneStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContacts",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, ensure you have activated Phone Number Intelligence.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveContactsResponse
        /// </returns>
        public SaveContactsResponse SaveContacts(SaveContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveContactsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, ensure you have activated Phone Number Intelligence.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveContactsResponse
        /// </returns>
        public async Task<SaveContactsResponse> SaveContactsAsync(SaveContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveContactsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verification of three elements (name, mobile phone number, and ID card number). Used to verify whether the name, mobile phone number, and ID card number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this API, make sure that you have fully understood the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>Before you call this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, fill in the application materials, and call the API after the application is approved.</description></item>
        /// <item><description>Billing applies when the API returns Code=\&quot;OK\&quot; and IsConsistent != 2. Other return results are not billed.</description></item>
        /// <item><description>The verification of virtual carrier numbers is not supported. Virtual carrier numbers refer to numbers that start with 170, 171, 162, or 165.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the API in a reasonable manner.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ThreeElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ThreeElementsVerificationResponse
        /// </returns>
        public ThreeElementsVerificationResponse ThreeElementsVerificationWithOptions(ThreeElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertCode))
            {
                query["CertCode"] = request.CertCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ThreeElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ThreeElementsVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verification of three elements (name, mobile phone number, and ID card number). Used to verify whether the name, mobile phone number, and ID card number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this API, make sure that you have fully understood the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>Before you call this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, fill in the application materials, and call the API after the application is approved.</description></item>
        /// <item><description>Billing applies when the API returns Code=\&quot;OK\&quot; and IsConsistent != 2. Other return results are not billed.</description></item>
        /// <item><description>The verification of virtual carrier numbers is not supported. Virtual carrier numbers refer to numbers that start with 170, 171, 162, or 165.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the API in a reasonable manner.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ThreeElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ThreeElementsVerificationResponse
        /// </returns>
        public async Task<ThreeElementsVerificationResponse> ThreeElementsVerificationWithOptionsAsync(ThreeElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertCode))
            {
                query["CertCode"] = request.CertCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ThreeElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ThreeElementsVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verification of three elements (name, mobile phone number, and ID card number). Used to verify whether the name, mobile phone number, and ID card number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this API, make sure that you have fully understood the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>Before you call this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, fill in the application materials, and call the API after the application is approved.</description></item>
        /// <item><description>Billing applies when the API returns Code=\&quot;OK\&quot; and IsConsistent != 2. Other return results are not billed.</description></item>
        /// <item><description>The verification of virtual carrier numbers is not supported. Virtual carrier numbers refer to numbers that start with 170, 171, 162, or 165.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the API in a reasonable manner.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ThreeElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ThreeElementsVerificationResponse
        /// </returns>
        public ThreeElementsVerificationResponse ThreeElementsVerification(ThreeElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ThreeElementsVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verification of three elements (name, mobile phone number, and ID card number). Used to verify whether the name, mobile phone number, and ID card number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this API, make sure that you have fully understood the <a href="https://help.aliyun.com/document_detail/154751.html">pricing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>Before you call this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply for Activation</b>, fill in the application materials, and call the API after the application is approved.</description></item>
        /// <item><description>Billing applies when the API returns Code=\&quot;OK\&quot; and IsConsistent != 2. Other return results are not billed.</description></item>
        /// <item><description>The verification of virtual carrier numbers is not supported. Virtual carrier numbers refer to numbers that start with 170, 171, 162, or 165.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The QPS limit per user for this API is 200 calls per second. If the limit is exceeded, API calls are throttled, which may affect your business. Call the API in a reasonable manner.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ThreeElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ThreeElementsVerificationResponse
        /// </returns>
        public async Task<ThreeElementsVerificationResponse> ThreeElementsVerificationAsync(ThreeElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ThreeElementsVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-element (name and phone number) verification. Used to compare whether the name and phone number entered by the user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, ensure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">product pricing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply to Enable</b>, fill in the application materials, and use it after the approval.</description></item>
        /// <item><description>Billing is applied when the API returns Code=&quot;OK&quot; and IsConsistent != 2. Other return results are not billed.</description></item>
        /// <item><description>MVNO number verification is not supported. MVNO numbers refer to numbers starting with 170, 171, 162, and 165.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this API is 200 times/second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TwoElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TwoElementsVerificationResponse
        /// </returns>
        public TwoElementsVerificationResponse TwoElementsVerificationWithOptions(TwoElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TwoElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TwoElementsVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-element (name and phone number) verification. Used to compare whether the name and phone number entered by the user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, ensure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">product pricing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply to Enable</b>, fill in the application materials, and use it after the approval.</description></item>
        /// <item><description>Billing is applied when the API returns Code=&quot;OK&quot; and IsConsistent != 2. Other return results are not billed.</description></item>
        /// <item><description>MVNO number verification is not supported. MVNO numbers refer to numbers starting with 170, 171, 162, and 165.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this API is 200 times/second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TwoElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TwoElementsVerificationResponse
        /// </returns>
        public async Task<TwoElementsVerificationResponse> TwoElementsVerificationWithOptionsAsync(TwoElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TwoElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TwoElementsVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-element (name and phone number) verification. Used to compare whether the name and phone number entered by the user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, ensure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">product pricing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply to Enable</b>, fill in the application materials, and use it after the approval.</description></item>
        /// <item><description>Billing is applied when the API returns Code=&quot;OK&quot; and IsConsistent != 2. Other return results are not billed.</description></item>
        /// <item><description>MVNO number verification is not supported. MVNO numbers refer to numbers starting with 170, 171, 162, and 165.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this API is 200 times/second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TwoElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// TwoElementsVerificationResponse
        /// </returns>
        public TwoElementsVerificationResponse TwoElementsVerification(TwoElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TwoElementsVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Two-element (name and phone number) verification. Used to compare whether the name and phone number entered by the user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before using this API, ensure that you fully understand the <a href="https://help.aliyun.com/document_detail/154751.html">product pricing</a> of Cell Phone Number Service.</description></item>
        /// <item><description>Before using this API, log on to the Cell Phone Number Service console, go to the <a href="https://dytns.console.aliyun.com/analysis/square">Tag Square</a> page, find the corresponding tag, click <b>Apply to Enable</b>, fill in the application materials, and use it after the approval.</description></item>
        /// <item><description>Billing is applied when the API returns Code=&quot;OK&quot; and IsConsistent != 2. Other return results are not billed.</description></item>
        /// <item><description>MVNO number verification is not supported. MVNO numbers refer to numbers starting with 170, 171, 162, and 165.</description></item>
        /// </list>
        /// <h3>QPS limit</h3>
        /// <para>The per-user QPS limit of this API is 200 times/second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API reasonably.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TwoElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// TwoElementsVerificationResponse
        /// </returns>
        public async Task<TwoElementsVerificationResponse> TwoElementsVerificationAsync(TwoElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TwoElementsVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UAID采集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UAIDCollectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UAIDCollectionResponse
        /// </returns>
        public UAIDCollectionResponse UAIDCollectionWithOptions(UAIDCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGrantId))
            {
                query["UserGrantId"] = request.UserGrantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UAIDCollection",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UAIDCollectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UAID采集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UAIDCollectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UAIDCollectionResponse
        /// </returns>
        public async Task<UAIDCollectionResponse> UAIDCollectionWithOptionsAsync(UAIDCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGrantId))
            {
                query["UserGrantId"] = request.UserGrantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UAIDCollection",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UAIDCollectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UAID采集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UAIDCollectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UAIDCollectionResponse
        /// </returns>
        public UAIDCollectionResponse UAIDCollection(UAIDCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UAIDCollectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UAID采集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UAIDCollectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UAIDCollectionResponse
        /// </returns>
        public async Task<UAIDCollectionResponse> UAIDCollectionAsync(UAIDCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UAIDCollectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>uaid号码转换服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UAIDConversionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UAIDConversionResponse
        /// </returns>
        public UAIDConversionResponse UAIDConversionWithOptions(UAIDConversionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UaidList))
            {
                query["UaidList"] = request.UaidList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UAIDConversion",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UAIDConversionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>uaid号码转换服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UAIDConversionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UAIDConversionResponse
        /// </returns>
        public async Task<UAIDConversionResponse> UAIDConversionWithOptionsAsync(UAIDConversionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UaidList))
            {
                query["UaidList"] = request.UaidList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UAIDConversion",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UAIDConversionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>uaid号码转换服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UAIDConversionRequest
        /// </param>
        /// 
        /// <returns>
        /// UAIDConversionResponse
        /// </returns>
        public UAIDConversionResponse UAIDConversion(UAIDConversionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UAIDConversionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>uaid号码转换服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UAIDConversionRequest
        /// </param>
        /// 
        /// <returns>
        /// UAIDConversionResponse
        /// </returns>
        public async Task<UAIDConversionResponse> UAIDConversionAsync(UAIDConversionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UAIDConversionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a UAID based on the carrier authorization token.
        /// For information about how to obtain the authorization token and its signature, see the GetUAIDApplyTokenSign API documentation.
        /// A UAID is 64 characters in length. The first 32 characters describe the device information, and the last 32 characters describe the phone number information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this API, make sure that you have fully understood the billing method and <a href="https://www.aliyun.com/price/product#/dytns/detail/dytns_penqbag_public_cn">pricing</a> of Cell Phone Number Service.<br>Obtains a UAID based on the carrier authorization token.<br>For information about how to obtain the authorization token and its signature, see the GetUAIDApplyTokenSign API documentation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UAIDVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UAIDVerificationResponse
        /// </returns>
        public UAIDVerificationResponse UAIDVerificationWithOptions(UAIDVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGrantId))
            {
                query["UserGrantId"] = request.UserGrantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UAIDVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UAIDVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a UAID based on the carrier authorization token.
        /// For information about how to obtain the authorization token and its signature, see the GetUAIDApplyTokenSign API documentation.
        /// A UAID is 64 characters in length. The first 32 characters describe the device information, and the last 32 characters describe the phone number information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this API, make sure that you have fully understood the billing method and <a href="https://www.aliyun.com/price/product#/dytns/detail/dytns_penqbag_public_cn">pricing</a> of Cell Phone Number Service.<br>Obtains a UAID based on the carrier authorization token.<br>For information about how to obtain the authorization token and its signature, see the GetUAIDApplyTokenSign API documentation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UAIDVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UAIDVerificationResponse
        /// </returns>
        public async Task<UAIDVerificationResponse> UAIDVerificationWithOptionsAsync(UAIDVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Carrier))
            {
                query["Carrier"] = request.Carrier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGrantId))
            {
                query["UserGrantId"] = request.UserGrantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UAIDVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UAIDVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a UAID based on the carrier authorization token.
        /// For information about how to obtain the authorization token and its signature, see the GetUAIDApplyTokenSign API documentation.
        /// A UAID is 64 characters in length. The first 32 characters describe the device information, and the last 32 characters describe the phone number information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this API, make sure that you have fully understood the billing method and <a href="https://www.aliyun.com/price/product#/dytns/detail/dytns_penqbag_public_cn">pricing</a> of Cell Phone Number Service.<br>Obtains a UAID based on the carrier authorization token.<br>For information about how to obtain the authorization token and its signature, see the GetUAIDApplyTokenSign API documentation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UAIDVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// UAIDVerificationResponse
        /// </returns>
        public UAIDVerificationResponse UAIDVerification(UAIDVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UAIDVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a UAID based on the carrier authorization token.
        /// For information about how to obtain the authorization token and its signature, see the GetUAIDApplyTokenSign API documentation.
        /// A UAID is 64 characters in length. The first 32 characters describe the device information, and the last 32 characters describe the phone number information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this API, make sure that you have fully understood the billing method and <a href="https://www.aliyun.com/price/product#/dytns/detail/dytns_penqbag_public_cn">pricing</a> of Cell Phone Number Service.<br>Obtains a UAID based on the carrier authorization token.<br>For information about how to obtain the authorization token and its signature, see the GetUAIDApplyTokenSign API documentation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UAIDVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// UAIDVerificationResponse
        /// </returns>
        public async Task<UAIDVerificationResponse> UAIDVerificationAsync(UAIDVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UAIDVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Ensure that you have activated the Phone Number Information Service before calling this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactsResponse
        /// </returns>
        public UpdateContactsResponse UpdateContactsWithOptions(UpdateContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                query["ContactPhone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailStatus))
            {
                query["MailStatus"] = request.MailStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenStatusWarning))
            {
                query["OpenStatusWarning"] = request.OpenStatusWarning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpentAttributionWarning))
            {
                query["OpentAttributionWarning"] = request.OpentAttributionWarning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneStatus))
            {
                query["PhoneStatus"] = request.PhoneStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContacts",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContactsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Ensure that you have activated the Phone Number Information Service before calling this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactsResponse
        /// </returns>
        public async Task<UpdateContactsResponse> UpdateContactsWithOptionsAsync(UpdateContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactEmail))
            {
                query["ContactEmail"] = request.ContactEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhone))
            {
                query["ContactPhone"] = request.ContactPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MailStatus))
            {
                query["MailStatus"] = request.MailStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenStatusWarning))
            {
                query["OpenStatusWarning"] = request.OpenStatusWarning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpentAttributionWarning))
            {
                query["OpentAttributionWarning"] = request.OpentAttributionWarning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneStatus))
            {
                query["PhoneStatus"] = request.PhoneStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContacts",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Ensure that you have activated the Phone Number Information Service before calling this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactsResponse
        /// </returns>
        public UpdateContactsResponse UpdateContacts(UpdateContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContactsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an alert contact.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Ensure that you have activated the Phone Number Information Service before calling this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContactsResponse
        /// </returns>
        public async Task<UpdateContactsResponse> UpdateContactsAsync(UpdateContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContactsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>虚商三要素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VirtualThreeElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VirtualThreeElementsVerificationResponse
        /// </returns>
        public VirtualThreeElementsVerificationResponse VirtualThreeElementsVerificationWithOptions(VirtualThreeElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertCode))
            {
                query["CertCode"] = request.CertCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VirtualThreeElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VirtualThreeElementsVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>虚商三要素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VirtualThreeElementsVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VirtualThreeElementsVerificationResponse
        /// </returns>
        public async Task<VirtualThreeElementsVerificationResponse> VirtualThreeElementsVerificationWithOptionsAsync(VirtualThreeElementsVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertCode))
            {
                query["CertCode"] = request.CertCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputNumber))
            {
                query["InputNumber"] = request.InputNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VirtualThreeElementsVerification",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VirtualThreeElementsVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>虚商三要素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VirtualThreeElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// VirtualThreeElementsVerificationResponse
        /// </returns>
        public VirtualThreeElementsVerificationResponse VirtualThreeElementsVerification(VirtualThreeElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VirtualThreeElementsVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>虚商三要素</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VirtualThreeElementsVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// VirtualThreeElementsVerificationResponse
        /// </returns>
        public async Task<VirtualThreeElementsVerificationResponse> VirtualThreeElementsVerificationAsync(VirtualThreeElementsVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VirtualThreeElementsVerificationWithOptionsAsync(request, runtime);
        }

    }
}
