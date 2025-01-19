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
            this._endpointRule = "central";
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
        /// <para>身份证三要素</para>
        /// </summary>
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
        /// <para>身份证三要素</para>
        /// </summary>
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
        /// <para>身份证三要素</para>
        /// </summary>
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
        /// <para>身份证三要素</para>
        /// </summary>
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
        /// <para>身份证二要素认证</para>
        /// </summary>
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
        /// <para>身份证二要素认证</para>
        /// </summary>
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
        /// <para>身份证二要素认证</para>
        /// </summary>
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
        /// <para>身份证二要素认证</para>
        /// </summary>
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
        /// <para>Verifies whether the enterprise name, the business license number, and the name and ID card of the legal representative belong to the same enterprise. The verification is successful only when the preceding four elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to four-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0, 1, or 2.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name, the business license number, and the name and ID card of the legal representative belong to the same enterprise. The verification is successful only when the preceding four elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to four-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0, 1, or 2.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name, the business license number, and the name and ID card of the legal representative belong to the same enterprise. The verification is successful only when the preceding four elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to four-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0, 1, or 2.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name, the business license number, and the name and ID card of the legal representative belong to the same enterprise. The verification is successful only when the preceding four elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to four-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0, 1, or 2.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name, the business license number, and the name of the legal representative belong to the same enterprise. The verification is successful only when the three elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to three-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0, 1, or 2.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name, the business license number, and the name of the legal representative belong to the same enterprise. The verification is successful only when the three elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to three-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0, 1, or 2.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name, the business license number, and the name of the legal representative belong to the same enterprise. The verification is successful only when the three elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to three-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0, 1, or 2.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name, the business license number, and the name of the legal representative belong to the same enterprise. The verification is successful only when the three elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to three-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0, 1, or 2.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name and the business license number belong to the same enterprise. The verification is successful only when the two elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to two-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0 or 1.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name and the business license number belong to the same enterprise. The verification is successful only when the two elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to two-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0 or 1.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name and the business license number belong to the same enterprise. The verification is successful only when the two elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to two-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0 or 1.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether the enterprise name and the business license number belong to the same enterprise. The verification is successful only when the two elements belong to the same enterprise and the business status of the enterprise is Active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the billing of services related to two-element verification for enterprises. For more information, see <a href="https://help.aliyun.com/document_detail/154751.html?spm=a2c4g.154007.0.0.3edd7eb6E90YT4">Billing</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of VerifyResult is true or false and the value of ReasonCode is 0 or 1.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the <a href="https://account.aliyun.com/login/login.htm?oauth_callback=https%3A%2F%2Fdytns.console.aliyun.com%2Foverview%3Fspm%3Da2c4g.608385.0.0.79847f8b3awqUC%5C&lang=zh">Cell Phone Number Service console</a>. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Predicts whether a phone number is a nonexistent number by using AI algorithms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation to verify whether a phone number is a nonexistent number. When you call this operation to verify a number, the system charges you CNY 0.01 per verification based on the number of verifications. <b>Before you call this operation, make sure that you are familiar with the billing of Cell Phone Number Service.</b></para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of Code is OK and the value of Status is not UNKNOWN.</description></item>
        /// <item><description>The prediction is not strictly accurate because Cell Phone Number Service predicts the nonexistent number probability by using AI algorithms. The accuracy rate of the prediction and the recall rate of empty numbers are about 95%. <b>Pay attention to this point when you call this operation</b>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h3><a href="#"></a>Authorization information</h3>
        /// <para>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</para>
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
        /// <para>Predicts whether a phone number is a nonexistent number by using AI algorithms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation to verify whether a phone number is a nonexistent number. When you call this operation to verify a number, the system charges you CNY 0.01 per verification based on the number of verifications. <b>Before you call this operation, make sure that you are familiar with the billing of Cell Phone Number Service.</b></para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of Code is OK and the value of Status is not UNKNOWN.</description></item>
        /// <item><description>The prediction is not strictly accurate because Cell Phone Number Service predicts the nonexistent number probability by using AI algorithms. The accuracy rate of the prediction and the recall rate of empty numbers are about 95%. <b>Pay attention to this point when you call this operation</b>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h3><a href="#"></a>Authorization information</h3>
        /// <para>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</para>
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
        /// <para>Predicts whether a phone number is a nonexistent number by using AI algorithms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation to verify whether a phone number is a nonexistent number. When you call this operation to verify a number, the system charges you CNY 0.01 per verification based on the number of verifications. <b>Before you call this operation, make sure that you are familiar with the billing of Cell Phone Number Service.</b></para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of Code is OK and the value of Status is not UNKNOWN.</description></item>
        /// <item><description>The prediction is not strictly accurate because Cell Phone Number Service predicts the nonexistent number probability by using AI algorithms. The accuracy rate of the prediction and the recall rate of empty numbers are about 95%. <b>Pay attention to this point when you call this operation</b>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h3><a href="#"></a>Authorization information</h3>
        /// <para>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</para>
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
        /// <para>Predicts whether a phone number is a nonexistent number by using AI algorithms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation to verify whether a phone number is a nonexistent number. When you call this operation to verify a number, the system charges you CNY 0.01 per verification based on the number of verifications. <b>Before you call this operation, make sure that you are familiar with the billing of Cell Phone Number Service.</b></para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of Code is OK and the value of Status is not UNKNOWN.</description></item>
        /// <item><description>The prediction is not strictly accurate because Cell Phone Number Service predicts the nonexistent number probability by using AI algorithms. The accuracy rate of the prediction and the recall rate of empty numbers are about 95%. <b>Pay attention to this point when you call this operation</b>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h3><a href="#"></a>Authorization information</h3>
        /// <para>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</para>
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
        /// <para>号码分析实时查询蚂蚁</para>
        /// </summary>
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
        /// <para>号码分析实时查询蚂蚁</para>
        /// </summary>
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
        /// <para>号码分析实时查询蚂蚁</para>
        /// </summary>
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
        /// <para>号码分析实时查询蚂蚁</para>
        /// </summary>
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
        /// <para>Obtains the analysis results of a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the Labels page, find the label that you want to use, click Activate Now, enter the required information, and then submit your application. After your application is approved, you can use the label. Before you call this operation, make sure that you are familiar with the billing of Cell Phone Number Service.</para>
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
        /// <para>Obtains the analysis results of a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the Labels page, find the label that you want to use, click Activate Now, enter the required information, and then submit your application. After your application is approved, you can use the label. Before you call this operation, make sure that you are familiar with the billing of Cell Phone Number Service.</para>
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
        /// <para>Obtains the analysis results of a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the Labels page, find the label that you want to use, click Activate Now, enter the required information, and then submit your application. After your application is approved, you can use the label. Before you call this operation, make sure that you are familiar with the billing of Cell Phone Number Service.</para>
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
        /// <para>Obtains the analysis results of a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the Labels page, find the label that you want to use, click Activate Now, enter the required information, and then submit your application. After your application is approved, you can use the label. Before you call this operation, make sure that you are familiar with the billing of Cell Phone Number Service.</para>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the carrier, registration location, and mobile number portability information of a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 2,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the carrier, registration location, and mobile number portability information of a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 2,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the carrier, registration location, and mobile number portability information of a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 2,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the carrier, registration location, and mobile number portability information of a phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 2,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
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
        /// <para>Queries the usage period of a phone number of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the usage period of a phone number of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the usage period of a phone number of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the usage period of a phone number of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the attribute information about a phone number, including the registration province, registration city, basic carrier (such as China Mobile, China Unicom, China Telecom, or China Broadnet), reseller of mobile communications services (such as Alibaba Communications), mobile number portability, and the number segment to which the phone number belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>You can call this operation to obtain the carrier, registration location, and mobile number portability information about a phone number. You can query phone numbers in <b>plaintext</b> and phone numbers that are encrypted by using <b>MD5</b> and <b>SHA256</b>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Queries the attribute information about a phone number, including the registration province, registration city, basic carrier (such as China Mobile, China Unicom, China Telecom, or China Broadnet), reseller of mobile communications services (such as Alibaba Communications), mobile number portability, and the number segment to which the phone number belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>You can call this operation to obtain the carrier, registration location, and mobile number portability information about a phone number. You can query phone numbers in <b>plaintext</b> and phone numbers that are encrypted by using <b>MD5</b> and <b>SHA256</b>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Queries the attribute information about a phone number, including the registration province, registration city, basic carrier (such as China Mobile, China Unicom, China Telecom, or China Broadnet), reseller of mobile communications services (such as Alibaba Communications), mobile number portability, and the number segment to which the phone number belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>You can call this operation to obtain the carrier, registration location, and mobile number portability information about a phone number. You can query phone numbers in <b>plaintext</b> and phone numbers that are encrypted by using <b>MD5</b> and <b>SHA256</b>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Queries the attribute information about a phone number, including the registration province, registration city, basic carrier (such as China Mobile, China Unicom, China Telecom, or China Broadnet), reseller of mobile communications services (such as Alibaba Communications), mobile number portability, and the number segment to which the phone number belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154008.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>You can call this operation to obtain the carrier, registration location, and mobile number portability information about a phone number. You can query phone numbers in <b>plaintext</b> and phone numbers that are encrypted by using <b>MD5</b> and <b>SHA256</b>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
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
        /// <para>Verifies whether a phone number is a reassigned phone number by calling this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>You are charged for phone number verifications only if the value of Code is OK and the value of VerifyResult is not 0.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h2><a href="#qps"></a>QPS limits</h2>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h2><a href="#"></a>Authorization information</h2>
        /// <para>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</para>
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
        /// <para>Verifies whether a phone number is a reassigned phone number by calling this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>You are charged for phone number verifications only if the value of Code is OK and the value of VerifyResult is not 0.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h2><a href="#qps"></a>QPS limits</h2>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h2><a href="#"></a>Authorization information</h2>
        /// <para>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</para>
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
        /// <para>Verifies whether a phone number is a reassigned phone number by calling this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>You are charged for phone number verifications only if the value of Code is OK and the value of VerifyResult is not 0.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h2><a href="#qps"></a>QPS limits</h2>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h2><a href="#"></a>Authorization information</h2>
        /// <para>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</para>
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
        /// <para>Verifies whether a phone number is a reassigned phone number by calling this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>You are charged for phone number verifications only if the value of Code is OK and the value of VerifyResult is not 0.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h2><a href="#qps"></a>QPS limits</h2>
        /// <para>You can call this operation up to 100 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// <h2><a href="#"></a>Authorization information</h2>
        /// <para>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</para>
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
        /// <para>获取UAID申请Token所需的签名字段</para>
        /// </summary>
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
        /// <para>获取UAID申请Token所需的签名字段</para>
        /// </summary>
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
        /// <para>获取UAID申请Token所需的签名字段</para>
        /// </summary>
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
        /// <para>获取UAID申请Token所需的签名字段</para>
        /// </summary>
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
        /// <para>Filters invalid phone numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Filters invalid phone numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Filters invalid phone numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Filters invalid phone numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Encrypts the original phone number into a virtual number that starts with 140. Cell Phone Number Service integrates the communications services provided by Alibaba Cloud. This allows you to initiate a call by using a virtual number that starts with 140.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Encrypts the original phone number into a virtual number that starts with 140. Cell Phone Number Service integrates the communications services provided by Alibaba Cloud. This allows you to initiate a call by using a virtual number that starts with 140.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Encrypts the original phone number into a virtual number that starts with 140. Cell Phone Number Service integrates the communications services provided by Alibaba Cloud. This allows you to initiate a call by using a virtual number that starts with 140.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Encrypts the original phone number into a virtual number that starts with 140. Cell Phone Number Service integrates the communications services provided by Alibaba Cloud. This allows you to initiate a call by using a virtual number that starts with 140.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</para>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the status of a virtual phone number. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of Code is OK and the value of IsPrivacyNumber is true or false.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForVirtualRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForVirtualResponse
        /// </returns>
        public PhoneNumberStatusForVirtualResponse PhoneNumberStatusForVirtualWithOptions(PhoneNumberStatusForVirtualRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "PhoneNumberStatusForVirtual",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForVirtualResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a virtual phone number. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of Code is OK and the value of IsPrivacyNumber is true or false.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForVirtualRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForVirtualResponse
        /// </returns>
        public async Task<PhoneNumberStatusForVirtualResponse> PhoneNumberStatusForVirtualWithOptionsAsync(PhoneNumberStatusForVirtualRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "PhoneNumberStatusForVirtual",
                Version = "2020-02-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PhoneNumberStatusForVirtualResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a virtual phone number. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of Code is OK and the value of IsPrivacyNumber is true or false.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForVirtualRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForVirtualResponse
        /// </returns>
        public PhoneNumberStatusForVirtualResponse PhoneNumberStatusForVirtual(PhoneNumberStatusForVirtualRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PhoneNumberStatusForVirtualWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a virtual phone number. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>You are charged only if the value of Code is OK and the value of IsPrivacyNumber is true or false.</description></item>
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PhoneNumberStatusForVirtualRequest
        /// </param>
        /// 
        /// <returns>
        /// PhoneNumberStatusForVirtualResponse
        /// </returns>
        public async Task<PhoneNumberStatusForVirtualResponse> PhoneNumberStatusForVirtualAsync(PhoneNumberStatusForVirtualRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PhoneNumberStatusForVirtualWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries the real-time service state of a phone number. The state includes NORMAL, SHUTDOWN, and NOT_EXIST. You can choose an encryption method for your phone number query, including plaintext, MD5, and SHA256.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>By default, only Alibaba Cloud accounts can call this operation. RAM users can call this operation only after the RAM users are granted the related permissions. For more information, see <a href="https://help.aliyun.com/document_detail/154006.html">Grant permissions to RAM users</a>.</description></item>
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 300 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Queries information about tags.</para>
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
        /// <para>Queries information about tags.</para>
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
        /// <para>Queries information about tags.</para>
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
        /// <para>Queries information about tags.</para>
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
        /// <para>Queries a list of tags by page.</para>
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
        /// <para>Queries a list of tags by page.</para>
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
        /// <para>Queries a list of tags by page.</para>
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
        /// <para>Queries a list of tags by page.</para>
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
        /// <para>Queries the usage statistics based on tag IDs.</para>
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
        /// <para>Queries the usage statistics based on tag IDs.</para>
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
        /// <para>Queries the usage statistics based on tag IDs.</para>
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
        /// <para>Queries the usage statistics based on tag IDs.</para>
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
        /// <para>Verifies whether the name, phone number, and ID card number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// <item><description>You are charged only if the value of Code is OK and the value of IsConsistent is not 2.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Verifies whether the name, phone number, and ID card number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// <item><description>You are charged only if the value of Code is OK and the value of IsConsistent is not 2.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Verifies whether the name, phone number, and ID card number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// <item><description>You are charged only if the value of Code is OK and the value of IsConsistent is not 2.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Verifies whether the name, phone number, and ID card number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// <item><description>You are charged only if the value of Code is OK and the value of IsConsistent is not 2.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Verifies whether the name and phone number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// <item><description>You are charged only if the value of Code is OK and the value of IsConsistent is not 2.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Verifies whether the name and phone number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// <item><description>You are charged only if the value of Code is OK and the value of IsConsistent is not 2.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Verifies whether the name and phone number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// <item><description>You are charged only if the value of Code is OK and the value of IsConsistent is not 2.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>Verifies whether the name and phone number entered by a user belong to the same user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/154751.html">billing</a> of Cell Phone Number Service.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, perform the following operations: Log on to the Cell Phone Number Service console. On the <a href="https://dytns.console.aliyun.com/analysis/square">Labels</a> page, find the label that you want to use, click <b>Activate Now</b>, enter the required information, and then submit your application. After your application is approved, you can use the label.</description></item>
        /// <item><description>You are charged only if the value of Code is OK and the value of IsConsistent is not 2.</description></item>
        /// </list>
        /// <h3><a href="#qps"></a>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
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
        /// <para>获取UAID</para>
        /// </summary>
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
        /// <para>获取UAID</para>
        /// </summary>
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
        /// <para>获取UAID</para>
        /// </summary>
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
        /// <para>获取UAID</para>
        /// </summary>
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

    }
}
