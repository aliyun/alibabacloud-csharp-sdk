// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cas20200407.Models;

namespace AlibabaCloud.SDK.Cas20200407
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "cas.aliyuncs.com"},
                {"ap-northeast-2-pop", "cas.aliyuncs.com"},
                {"ap-southeast-3", "cas.aliyuncs.com"},
                {"ap-southeast-5", "cas.aliyuncs.com"},
                {"cn-beijing", "cas.aliyuncs.com"},
                {"cn-beijing-finance-1", "cas.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cas.aliyuncs.com"},
                {"cn-beijing-gov-1", "cas.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cas.aliyuncs.com"},
                {"cn-chengdu", "cas.aliyuncs.com"},
                {"cn-edge-1", "cas.aliyuncs.com"},
                {"cn-fujian", "cas.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cas.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cas.aliyuncs.com"},
                {"cn-hangzhou-finance", "cas.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cas.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cas.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cas.aliyuncs.com"},
                {"cn-hongkong", "cas.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cas.aliyuncs.com"},
                {"cn-huhehaote", "cas.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "cas.aliyuncs.com"},
                {"cn-north-2-gov-1", "cas.aliyuncs.com"},
                {"cn-qingdao", "cas.aliyuncs.com"},
                {"cn-qingdao-nebula", "cas.aliyuncs.com"},
                {"cn-shanghai", "cas.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cas.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cas.aliyuncs.com"},
                {"cn-shanghai-finance-1", "cas.aliyuncs.com"},
                {"cn-shanghai-inner", "cas.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cas.aliyuncs.com"},
                {"cn-shenzhen", "cas.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cas.aliyuncs.com"},
                {"cn-shenzhen-inner", "cas.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cas.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cas.aliyuncs.com"},
                {"cn-wuhan", "cas.aliyuncs.com"},
                {"cn-wulanchabu", "cas.aliyuncs.com"},
                {"cn-yushanfang", "cas.aliyuncs.com"},
                {"cn-zhangbei", "cas.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "cas.aliyuncs.com"},
                {"cn-zhangjiakou", "cas.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "cas.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "cas.aliyuncs.com"},
                {"eu-west-1", "cas.aliyuncs.com"},
                {"eu-west-1-oxs", "cas.aliyuncs.com"},
                {"rus-west-1-pop", "cas.aliyuncs.com"},
                {"us-east-1", "cas.aliyuncs.com"},
                {"us-west-1", "cas.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary You can call the CancelCertificateForPackageRequest operation to cancel a certificate application order and revoke the issued certificate in the order. You can call this operation only when the certificate application order is in the **issued** state.
         * >  You can call the [DescribeCertificateState](https://help.aliyun.com/document_detail/164111.html) operation to query the status of a certificate application order. If the value of the **Type** response parameter is **certificate**, the certificate is issued.
         * If a certificate is revoked within 30 calendar days after the issuance date, the consumed certificate quota is returned to you. Otherwise, the consumed certificate quota is not returned.
         *
         * @description Revokes an issued certificate and cancels the application order of the certificate.
         *
         * @param request CancelCertificateForPackageRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelCertificateForPackageRequestResponse
         */
        public CancelCertificateForPackageRequestResponse CancelCertificateForPackageRequestWithOptions(CancelCertificateForPackageRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelCertificateForPackageRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCertificateForPackageRequestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the CancelCertificateForPackageRequest operation to cancel a certificate application order and revoke the issued certificate in the order. You can call this operation only when the certificate application order is in the **issued** state.
         * >  You can call the [DescribeCertificateState](https://help.aliyun.com/document_detail/164111.html) operation to query the status of a certificate application order. If the value of the **Type** response parameter is **certificate**, the certificate is issued.
         * If a certificate is revoked within 30 calendar days after the issuance date, the consumed certificate quota is returned to you. Otherwise, the consumed certificate quota is not returned.
         *
         * @description Revokes an issued certificate and cancels the application order of the certificate.
         *
         * @param request CancelCertificateForPackageRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelCertificateForPackageRequestResponse
         */
        public async Task<CancelCertificateForPackageRequestResponse> CancelCertificateForPackageRequestWithOptionsAsync(CancelCertificateForPackageRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelCertificateForPackageRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCertificateForPackageRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the CancelCertificateForPackageRequest operation to cancel a certificate application order and revoke the issued certificate in the order. You can call this operation only when the certificate application order is in the **issued** state.
         * >  You can call the [DescribeCertificateState](https://help.aliyun.com/document_detail/164111.html) operation to query the status of a certificate application order. If the value of the **Type** response parameter is **certificate**, the certificate is issued.
         * If a certificate is revoked within 30 calendar days after the issuance date, the consumed certificate quota is returned to you. Otherwise, the consumed certificate quota is not returned.
         *
         * @description Revokes an issued certificate and cancels the application order of the certificate.
         *
         * @param request CancelCertificateForPackageRequestRequest
         * @return CancelCertificateForPackageRequestResponse
         */
        public CancelCertificateForPackageRequestResponse CancelCertificateForPackageRequest(CancelCertificateForPackageRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelCertificateForPackageRequestWithOptions(request, runtime);
        }

        /**
         * @summary You can call the CancelCertificateForPackageRequest operation to cancel a certificate application order and revoke the issued certificate in the order. You can call this operation only when the certificate application order is in the **issued** state.
         * >  You can call the [DescribeCertificateState](https://help.aliyun.com/document_detail/164111.html) operation to query the status of a certificate application order. If the value of the **Type** response parameter is **certificate**, the certificate is issued.
         * If a certificate is revoked within 30 calendar days after the issuance date, the consumed certificate quota is returned to you. Otherwise, the consumed certificate quota is not returned.
         *
         * @description Revokes an issued certificate and cancels the application order of the certificate.
         *
         * @param request CancelCertificateForPackageRequestRequest
         * @return CancelCertificateForPackageRequestResponse
         */
        public async Task<CancelCertificateForPackageRequestResponse> CancelCertificateForPackageRequestAsync(CancelCertificateForPackageRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelCertificateForPackageRequestWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels a certificate application order that is in the pending validation or being reviewed state.
         *
         * @description You can call the CancelOrderRequest operation to cancel a certificate application order only in the following scenarios:
         * *   The order is in the **pending validation** state. You have submitted a certificate application but the verification of the domain name ownership is not complete.
         * *   The order is in the **being reviewed** state. You have submitted a certificate application and the verification of the domain name ownership is complete, but the certificate authority (CA) does not complete the review of the certificate application.
         * After a certificate application order is canceled, the status of the order changes to the **pending application** state. In this case, you can call the [DeleteCertificateRequest](https://help.aliyun.com/document_detail/164109.html) operation to delete the certificate application order. Then, the consumed certificate quota is returned to you.
         *
         * @param request CancelOrderRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelOrderRequestResponse
         */
        public CancelOrderRequestResponse CancelOrderRequestWithOptions(CancelOrderRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelOrderRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderRequestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels a certificate application order that is in the pending validation or being reviewed state.
         *
         * @description You can call the CancelOrderRequest operation to cancel a certificate application order only in the following scenarios:
         * *   The order is in the **pending validation** state. You have submitted a certificate application but the verification of the domain name ownership is not complete.
         * *   The order is in the **being reviewed** state. You have submitted a certificate application and the verification of the domain name ownership is complete, but the certificate authority (CA) does not complete the review of the certificate application.
         * After a certificate application order is canceled, the status of the order changes to the **pending application** state. In this case, you can call the [DeleteCertificateRequest](https://help.aliyun.com/document_detail/164109.html) operation to delete the certificate application order. Then, the consumed certificate quota is returned to you.
         *
         * @param request CancelOrderRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelOrderRequestResponse
         */
        public async Task<CancelOrderRequestResponse> CancelOrderRequestWithOptionsAsync(CancelOrderRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelOrderRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels a certificate application order that is in the pending validation or being reviewed state.
         *
         * @description You can call the CancelOrderRequest operation to cancel a certificate application order only in the following scenarios:
         * *   The order is in the **pending validation** state. You have submitted a certificate application but the verification of the domain name ownership is not complete.
         * *   The order is in the **being reviewed** state. You have submitted a certificate application and the verification of the domain name ownership is complete, but the certificate authority (CA) does not complete the review of the certificate application.
         * After a certificate application order is canceled, the status of the order changes to the **pending application** state. In this case, you can call the [DeleteCertificateRequest](https://help.aliyun.com/document_detail/164109.html) operation to delete the certificate application order. Then, the consumed certificate quota is returned to you.
         *
         * @param request CancelOrderRequestRequest
         * @return CancelOrderRequestResponse
         */
        public CancelOrderRequestResponse CancelOrderRequest(CancelOrderRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOrderRequestWithOptions(request, runtime);
        }

        /**
         * @summary Cancels a certificate application order that is in the pending validation or being reviewed state.
         *
         * @description You can call the CancelOrderRequest operation to cancel a certificate application order only in the following scenarios:
         * *   The order is in the **pending validation** state. You have submitted a certificate application but the verification of the domain name ownership is not complete.
         * *   The order is in the **being reviewed** state. You have submitted a certificate application and the verification of the domain name ownership is complete, but the certificate authority (CA) does not complete the review of the certificate application.
         * After a certificate application order is canceled, the status of the order changes to the **pending application** state. In this case, you can call the [DeleteCertificateRequest](https://help.aliyun.com/document_detail/164109.html) operation to delete the certificate application order. Then, the consumed certificate quota is returned to you.
         *
         * @param request CancelOrderRequestRequest
         * @return CancelOrderRequestResponse
         */
        public async Task<CancelOrderRequestResponse> CancelOrderRequestAsync(CancelOrderRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOrderRequestWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Submits a certificate application.
         *
         * @description *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/455800.html) operation to query the usage of certificate resource plans of specified specifications, including the total number of certificate resource plans that you purchase, the number of certificate applications that are submitted, and the number of certificates that are issued.
         * *   After you call this operation to submit a certificate application and the certificate is issued, the certificate quota provided by the resource plan that you purchased is consumed. When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate that you want to apply for.
         * *   After you call this operation to submit a certificate application, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to obtain the information that is required to complete the verification of the domain name ownership, and complete the verification. If you use the DNS verification method, you must complete the verification in the management platform of the domain name. If you use the file verification method, you must complete the verification in the DNS server. Then, the certificate application order will be reviewed by the certificate authority (CA).
         *
         * @param request CreateCertificateForPackageRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateForPackageRequestResponse
         */
        public CreateCertificateForPackageRequestResponse CreateCertificateForPackageRequestWithOptions(CreateCertificateForPackageRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateType))
            {
                query["ValidateType"] = request.ValidateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificateForPackageRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateForPackageRequestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Submits a certificate application.
         *
         * @description *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/455800.html) operation to query the usage of certificate resource plans of specified specifications, including the total number of certificate resource plans that you purchase, the number of certificate applications that are submitted, and the number of certificates that are issued.
         * *   After you call this operation to submit a certificate application and the certificate is issued, the certificate quota provided by the resource plan that you purchased is consumed. When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate that you want to apply for.
         * *   After you call this operation to submit a certificate application, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to obtain the information that is required to complete the verification of the domain name ownership, and complete the verification. If you use the DNS verification method, you must complete the verification in the management platform of the domain name. If you use the file verification method, you must complete the verification in the DNS server. Then, the certificate application order will be reviewed by the certificate authority (CA).
         *
         * @param request CreateCertificateForPackageRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateForPackageRequestResponse
         */
        public async Task<CreateCertificateForPackageRequestResponse> CreateCertificateForPackageRequestWithOptionsAsync(CreateCertificateForPackageRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateType))
            {
                query["ValidateType"] = request.ValidateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificateForPackageRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateForPackageRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Submits a certificate application.
         *
         * @description *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/455800.html) operation to query the usage of certificate resource plans of specified specifications, including the total number of certificate resource plans that you purchase, the number of certificate applications that are submitted, and the number of certificates that are issued.
         * *   After you call this operation to submit a certificate application and the certificate is issued, the certificate quota provided by the resource plan that you purchased is consumed. When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate that you want to apply for.
         * *   After you call this operation to submit a certificate application, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to obtain the information that is required to complete the verification of the domain name ownership, and complete the verification. If you use the DNS verification method, you must complete the verification in the management platform of the domain name. If you use the file verification method, you must complete the verification in the DNS server. Then, the certificate application order will be reviewed by the certificate authority (CA).
         *
         * @param request CreateCertificateForPackageRequestRequest
         * @return CreateCertificateForPackageRequestResponse
         */
        public CreateCertificateForPackageRequestResponse CreateCertificateForPackageRequest(CreateCertificateForPackageRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertificateForPackageRequestWithOptions(request, runtime);
        }

        /**
         * @summary Submits a certificate application.
         *
         * @description *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/455800.html) operation to query the usage of certificate resource plans of specified specifications, including the total number of certificate resource plans that you purchase, the number of certificate applications that are submitted, and the number of certificates that are issued.
         * *   After you call this operation to submit a certificate application and the certificate is issued, the certificate quota provided by the resource plan that you purchased is consumed. When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate that you want to apply for.
         * *   After you call this operation to submit a certificate application, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to obtain the information that is required to complete the verification of the domain name ownership, and complete the verification. If you use the DNS verification method, you must complete the verification in the management platform of the domain name. If you use the file verification method, you must complete the verification in the DNS server. Then, the certificate application order will be reviewed by the certificate authority (CA).
         *
         * @param request CreateCertificateForPackageRequestRequest
         * @return CreateCertificateForPackageRequestResponse
         */
        public async Task<CreateCertificateForPackageRequestResponse> CreateCertificateForPackageRequestAsync(CreateCertificateForPackageRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertificateForPackageRequestWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Purchases, applies for, and issues a domain validated (DV) certificate by using extended certificate services.
         *
         * @description *   You can call this operation to apply for only DV certificates. If you want to apply for an organization validated (OV) or extended validation (EV) certificate, we recommend that you call the [CreateCertificateForPackageRequest](https://help.aliyun.com/document_detail/455296.html) operation. This operation allows you to apply for certificates of all specifications and specify the method to generate a certificate signing request (CSR) file.
         * *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/455803.html) operation to query the usage of certificate resource plans of specified specifications, including the total number of purchased certificate resource plans of the specified specifications, the number of times that certificate applications have been submitted, and the number of times that certificates have been issued.
         * *   When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate.
         * *   After you call this operation to submit a certificate application, Certificate Management Service automatically creates a CSR file for your application and consumes the certificate quota in the certificate resource plans of the specified specifications that you purchased. After you call this operation, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to obtain the information that is required to complete domain name verification, and manually complete the verification. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on your DNS server. Then, the certificate authority (CA) will review your certificate application.
         *
         * @param request CreateCertificateRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateRequestResponse
         */
        public CreateCertificateRequestResponse CreateCertificateRequestWithOptions(CreateCertificateRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateType))
            {
                query["ValidateType"] = request.ValidateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificateRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateRequestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Purchases, applies for, and issues a domain validated (DV) certificate by using extended certificate services.
         *
         * @description *   You can call this operation to apply for only DV certificates. If you want to apply for an organization validated (OV) or extended validation (EV) certificate, we recommend that you call the [CreateCertificateForPackageRequest](https://help.aliyun.com/document_detail/455296.html) operation. This operation allows you to apply for certificates of all specifications and specify the method to generate a certificate signing request (CSR) file.
         * *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/455803.html) operation to query the usage of certificate resource plans of specified specifications, including the total number of purchased certificate resource plans of the specified specifications, the number of times that certificate applications have been submitted, and the number of times that certificates have been issued.
         * *   When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate.
         * *   After you call this operation to submit a certificate application, Certificate Management Service automatically creates a CSR file for your application and consumes the certificate quota in the certificate resource plans of the specified specifications that you purchased. After you call this operation, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to obtain the information that is required to complete domain name verification, and manually complete the verification. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on your DNS server. Then, the certificate authority (CA) will review your certificate application.
         *
         * @param request CreateCertificateRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateRequestResponse
         */
        public async Task<CreateCertificateRequestResponse> CreateCertificateRequestWithOptionsAsync(CreateCertificateRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateType))
            {
                query["ValidateType"] = request.ValidateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificateRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Purchases, applies for, and issues a domain validated (DV) certificate by using extended certificate services.
         *
         * @description *   You can call this operation to apply for only DV certificates. If you want to apply for an organization validated (OV) or extended validation (EV) certificate, we recommend that you call the [CreateCertificateForPackageRequest](https://help.aliyun.com/document_detail/455296.html) operation. This operation allows you to apply for certificates of all specifications and specify the method to generate a certificate signing request (CSR) file.
         * *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/455803.html) operation to query the usage of certificate resource plans of specified specifications, including the total number of purchased certificate resource plans of the specified specifications, the number of times that certificate applications have been submitted, and the number of times that certificates have been issued.
         * *   When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate.
         * *   After you call this operation to submit a certificate application, Certificate Management Service automatically creates a CSR file for your application and consumes the certificate quota in the certificate resource plans of the specified specifications that you purchased. After you call this operation, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to obtain the information that is required to complete domain name verification, and manually complete the verification. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on your DNS server. Then, the certificate authority (CA) will review your certificate application.
         *
         * @param request CreateCertificateRequestRequest
         * @return CreateCertificateRequestResponse
         */
        public CreateCertificateRequestResponse CreateCertificateRequest(CreateCertificateRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertificateRequestWithOptions(request, runtime);
        }

        /**
         * @summary Purchases, applies for, and issues a domain validated (DV) certificate by using extended certificate services.
         *
         * @description *   You can call this operation to apply for only DV certificates. If you want to apply for an organization validated (OV) or extended validation (EV) certificate, we recommend that you call the [CreateCertificateForPackageRequest](https://help.aliyun.com/document_detail/455296.html) operation. This operation allows you to apply for certificates of all specifications and specify the method to generate a certificate signing request (CSR) file.
         * *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/455803.html) operation to query the usage of certificate resource plans of specified specifications, including the total number of purchased certificate resource plans of the specified specifications, the number of times that certificate applications have been submitted, and the number of times that certificates have been issued.
         * *   When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate.
         * *   After you call this operation to submit a certificate application, Certificate Management Service automatically creates a CSR file for your application and consumes the certificate quota in the certificate resource plans of the specified specifications that you purchased. After you call this operation, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to obtain the information that is required to complete domain name verification, and manually complete the verification. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on your DNS server. Then, the certificate authority (CA) will review your certificate application.
         *
         * @param request CreateCertificateRequestRequest
         * @return CreateCertificateRequestResponse
         */
        public async Task<CreateCertificateRequestResponse> CreateCertificateRequestAsync(CreateCertificateRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertificateRequestWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Purchases, applies for, and issues a domain validated (DV) certificate by using a custom certificate signing request (CSR) file. You can use extended certificate services to purchase and apply for a DV certificate with a few clicks.
         *
         * @description *   You can call the CreateCertificateWithCsrRequest operation to apply only for DV certificates. We recommend that you call the [CreateCertificateForPackageRequest](https://help.aliyun.com/document_detail/455296.html) operation to submit a certificate application. This operation allows you to apply for certificates of all specifications and specify the method to generate a CSR file.
         * *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/164110.html) operation to query the usage of certificate resource plans of specified specifications. The usage information includes the total number of purchased certificate resource plans of the specified specifications, the number of times that certificate applications are submitted, and the number of times that certificates are issued.
         * *   When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate.
         * *   After you call this operation to submit a certificate application, the certificate quota of the required specifications that you purchased is consumed. After you call this operation, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/164111.html) operation to obtain the information that is required to complete domain name verification, and manually complete the verification. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on your DNS server. The certificate authority (CA) starts to review your certificate application only after the domain name verification is complete.
         *
         * @param request CreateCertificateWithCsrRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateWithCsrRequestResponse
         */
        public CreateCertificateWithCsrRequestResponse CreateCertificateWithCsrRequestWithOptions(CreateCertificateWithCsrRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateType))
            {
                query["ValidateType"] = request.ValidateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificateWithCsrRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateWithCsrRequestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Purchases, applies for, and issues a domain validated (DV) certificate by using a custom certificate signing request (CSR) file. You can use extended certificate services to purchase and apply for a DV certificate with a few clicks.
         *
         * @description *   You can call the CreateCertificateWithCsrRequest operation to apply only for DV certificates. We recommend that you call the [CreateCertificateForPackageRequest](https://help.aliyun.com/document_detail/455296.html) operation to submit a certificate application. This operation allows you to apply for certificates of all specifications and specify the method to generate a CSR file.
         * *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/164110.html) operation to query the usage of certificate resource plans of specified specifications. The usage information includes the total number of purchased certificate resource plans of the specified specifications, the number of times that certificate applications are submitted, and the number of times that certificates are issued.
         * *   When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate.
         * *   After you call this operation to submit a certificate application, the certificate quota of the required specifications that you purchased is consumed. After you call this operation, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/164111.html) operation to obtain the information that is required to complete domain name verification, and manually complete the verification. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on your DNS server. The certificate authority (CA) starts to review your certificate application only after the domain name verification is complete.
         *
         * @param request CreateCertificateWithCsrRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateWithCsrRequestResponse
         */
        public async Task<CreateCertificateWithCsrRequestResponse> CreateCertificateWithCsrRequestWithOptionsAsync(CreateCertificateWithCsrRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateType))
            {
                query["ValidateType"] = request.ValidateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificateWithCsrRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateWithCsrRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Purchases, applies for, and issues a domain validated (DV) certificate by using a custom certificate signing request (CSR) file. You can use extended certificate services to purchase and apply for a DV certificate with a few clicks.
         *
         * @description *   You can call the CreateCertificateWithCsrRequest operation to apply only for DV certificates. We recommend that you call the [CreateCertificateForPackageRequest](https://help.aliyun.com/document_detail/455296.html) operation to submit a certificate application. This operation allows you to apply for certificates of all specifications and specify the method to generate a CSR file.
         * *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/164110.html) operation to query the usage of certificate resource plans of specified specifications. The usage information includes the total number of purchased certificate resource plans of the specified specifications, the number of times that certificate applications are submitted, and the number of times that certificates are issued.
         * *   When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate.
         * *   After you call this operation to submit a certificate application, the certificate quota of the required specifications that you purchased is consumed. After you call this operation, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/164111.html) operation to obtain the information that is required to complete domain name verification, and manually complete the verification. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on your DNS server. The certificate authority (CA) starts to review your certificate application only after the domain name verification is complete.
         *
         * @param request CreateCertificateWithCsrRequestRequest
         * @return CreateCertificateWithCsrRequestResponse
         */
        public CreateCertificateWithCsrRequestResponse CreateCertificateWithCsrRequest(CreateCertificateWithCsrRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertificateWithCsrRequestWithOptions(request, runtime);
        }

        /**
         * @summary Purchases, applies for, and issues a domain validated (DV) certificate by using a custom certificate signing request (CSR) file. You can use extended certificate services to purchase and apply for a DV certificate with a few clicks.
         *
         * @description *   You can call the CreateCertificateWithCsrRequest operation to apply only for DV certificates. We recommend that you call the [CreateCertificateForPackageRequest](https://help.aliyun.com/document_detail/455296.html) operation to submit a certificate application. This operation allows you to apply for certificates of all specifications and specify the method to generate a CSR file.
         * *   Before you call this operation, make sure that you have purchased a certificate resource plan of the required specifications. For more information about how to purchase a certificate resource plan, see [Purchase a certificate resource plan](https://help.aliyun.com/document_detail/28542.html). You can call the [DescribePackageState](https://help.aliyun.com/document_detail/164110.html) operation to query the usage of certificate resource plans of specified specifications. The usage information includes the total number of purchased certificate resource plans of the specified specifications, the number of times that certificate applications are submitted, and the number of times that certificates are issued.
         * *   When you call this operation, you can use the **ProductCode** parameter to specify the specifications of the certificate.
         * *   After you call this operation to submit a certificate application, the certificate quota of the required specifications that you purchased is consumed. After you call this operation, you also need to call the [DescribeCertificateState](https://help.aliyun.com/document_detail/164111.html) operation to obtain the information that is required to complete domain name verification, and manually complete the verification. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on your DNS server. The certificate authority (CA) starts to review your certificate application only after the domain name verification is complete.
         *
         * @param request CreateCertificateWithCsrRequestRequest
         * @return CreateCertificateWithCsrRequestResponse
         */
        public async Task<CreateCertificateWithCsrRequestResponse> CreateCertificateWithCsrRequestAsync(CreateCertificateWithCsrRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertificateWithCsrRequestWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateCsrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCsrResponse
         */
        public CreateCsrResponse CreateCsrWithOptions(CreateCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonName))
            {
                query["CommonName"] = request.CommonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                query["CorpName"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                query["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySize))
            {
                query["KeySize"] = request.KeySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locality))
            {
                query["Locality"] = request.Locality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sans))
            {
                query["Sans"] = request.Sans;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCsr",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCsrResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateCsrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCsrResponse
         */
        public async Task<CreateCsrResponse> CreateCsrWithOptionsAsync(CreateCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonName))
            {
                query["CommonName"] = request.CommonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                query["CorpName"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                query["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySize))
            {
                query["KeySize"] = request.KeySize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locality))
            {
                query["Locality"] = request.Locality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sans))
            {
                query["Sans"] = request.Sans;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCsr",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCsrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateCsrRequest
         * @return CreateCsrResponse
         */
        public CreateCsrResponse CreateCsr(CreateCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCsrWithOptions(request, runtime);
        }

        /**
         * @param request CreateCsrRequest
         * @return CreateCsrResponse
         */
        public async Task<CreateCsrResponse> CreateCsrAsync(CreateCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCsrWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建部署任务
         *
         * @param request CreateDeploymentJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeploymentJobResponse
         */
        public CreateDeploymentJobResponse CreateDeploymentJobWithOptions(CreateDeploymentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactIds))
            {
                query["ContactIds"] = request.ContactIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeploymentJob",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建部署任务
         *
         * @param request CreateDeploymentJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeploymentJobResponse
         */
        public async Task<CreateDeploymentJobResponse> CreateDeploymentJobWithOptionsAsync(CreateDeploymentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactIds))
            {
                query["ContactIds"] = request.ContactIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeploymentJob",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建部署任务
         *
         * @param request CreateDeploymentJobRequest
         * @return CreateDeploymentJobResponse
         */
        public CreateDeploymentJobResponse CreateDeploymentJob(CreateDeploymentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeploymentJobWithOptions(request, runtime);
        }

        /**
         * @summary 创建部署任务
         *
         * @param request CreateDeploymentJobRequest
         * @return CreateDeploymentJobResponse
         */
        public async Task<CreateDeploymentJobResponse> CreateDeploymentJobAsync(CreateDeploymentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeploymentJobWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateWHClientCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWHClientCertificateResponse
         */
        public CreateWHClientCertificateResponse CreateWHClientCertificateWithOptions(CreateWHClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AfterTime))
            {
                query["AfterTime"] = request.AfterTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeforeTime))
            {
                query["BeforeTime"] = request.BeforeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonName))
            {
                query["CommonName"] = request.CommonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Immediately))
            {
                query["Immediately"] = request.Immediately;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locality))
            {
                query["Locality"] = request.Locality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Months))
            {
                query["Months"] = request.Months;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationUnit))
            {
                query["OrganizationUnit"] = request.OrganizationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentIdentifier))
            {
                query["ParentIdentifier"] = request.ParentIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SanType))
            {
                query["SanType"] = request.SanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SanValue))
            {
                query["SanValue"] = request.SanValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Years))
            {
                query["Years"] = request.Years;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWHClientCertificate",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWHClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateWHClientCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWHClientCertificateResponse
         */
        public async Task<CreateWHClientCertificateResponse> CreateWHClientCertificateWithOptionsAsync(CreateWHClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AfterTime))
            {
                query["AfterTime"] = request.AfterTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeforeTime))
            {
                query["BeforeTime"] = request.BeforeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonName))
            {
                query["CommonName"] = request.CommonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Immediately))
            {
                query["Immediately"] = request.Immediately;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locality))
            {
                query["Locality"] = request.Locality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Months))
            {
                query["Months"] = request.Months;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationUnit))
            {
                query["OrganizationUnit"] = request.OrganizationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentIdentifier))
            {
                query["ParentIdentifier"] = request.ParentIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SanType))
            {
                query["SanType"] = request.SanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SanValue))
            {
                query["SanValue"] = request.SanValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Years))
            {
                query["Years"] = request.Years;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWHClientCertificate",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWHClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateWHClientCertificateRequest
         * @return CreateWHClientCertificateResponse
         */
        public CreateWHClientCertificateResponse CreateWHClientCertificate(CreateWHClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWHClientCertificateWithOptions(request, runtime);
        }

        /**
         * @param request CreateWHClientCertificateRequest
         * @return CreateWHClientCertificateResponse
         */
        public async Task<CreateWHClientCertificateResponse> CreateWHClientCertificateAsync(CreateWHClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWHClientCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DecryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecryptResponse
         */
        public DecryptResponse DecryptWithOptions(DecryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Decrypt",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecryptResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DecryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecryptResponse
         */
        public async Task<DecryptResponse> DecryptWithOptionsAsync(DecryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Decrypt",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DecryptRequest
         * @return DecryptResponse
         */
        public DecryptResponse Decrypt(DecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecryptWithOptions(request, runtime);
        }

        /**
         * @param request DecryptRequest
         * @return DecryptResponse
         */
        public async Task<DecryptResponse> DecryptAsync(DecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecryptWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an order in which the application for a domain validated (DV) certificate failed.
         *
         * @description You can call this operation to delete a certificate application order only in the following scenarios:
         * *   The status of the order is review failed. You have called the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html)  operation to query the status of the certificate application order and the value of the **Type** parameter is **verify_fail**.
         * *   The status of the order is **pending application**. You have called the [CancelOrderRequest](https://help.aliyun.com/document_detail/455299.html) operation to cancel a certificate application order whose status is pending review or being reviewed. The status of the certificate application order that is canceled in this case changes to **pending application**.
         *
         * @param request DeleteCertificateRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCertificateRequestResponse
         */
        public DeleteCertificateRequestResponse DeleteCertificateRequestWithOptions(DeleteCertificateRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteCertificateRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCertificateRequestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an order in which the application for a domain validated (DV) certificate failed.
         *
         * @description You can call this operation to delete a certificate application order only in the following scenarios:
         * *   The status of the order is review failed. You have called the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html)  operation to query the status of the certificate application order and the value of the **Type** parameter is **verify_fail**.
         * *   The status of the order is **pending application**. You have called the [CancelOrderRequest](https://help.aliyun.com/document_detail/455299.html) operation to cancel a certificate application order whose status is pending review or being reviewed. The status of the certificate application order that is canceled in this case changes to **pending application**.
         *
         * @param request DeleteCertificateRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCertificateRequestResponse
         */
        public async Task<DeleteCertificateRequestResponse> DeleteCertificateRequestWithOptionsAsync(DeleteCertificateRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteCertificateRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCertificateRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an order in which the application for a domain validated (DV) certificate failed.
         *
         * @description You can call this operation to delete a certificate application order only in the following scenarios:
         * *   The status of the order is review failed. You have called the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html)  operation to query the status of the certificate application order and the value of the **Type** parameter is **verify_fail**.
         * *   The status of the order is **pending application**. You have called the [CancelOrderRequest](https://help.aliyun.com/document_detail/455299.html) operation to cancel a certificate application order whose status is pending review or being reviewed. The status of the certificate application order that is canceled in this case changes to **pending application**.
         *
         * @param request DeleteCertificateRequestRequest
         * @return DeleteCertificateRequestResponse
         */
        public DeleteCertificateRequestResponse DeleteCertificateRequest(DeleteCertificateRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCertificateRequestWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an order in which the application for a domain validated (DV) certificate failed.
         *
         * @description You can call this operation to delete a certificate application order only in the following scenarios:
         * *   The status of the order is review failed. You have called the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html)  operation to query the status of the certificate application order and the value of the **Type** parameter is **verify_fail**.
         * *   The status of the order is **pending application**. You have called the [CancelOrderRequest](https://help.aliyun.com/document_detail/455299.html) operation to cancel a certificate application order whose status is pending review or being reviewed. The status of the certificate application order that is canceled in this case changes to **pending application**.
         *
         * @param request DeleteCertificateRequestRequest
         * @return DeleteCertificateRequestResponse
         */
        public async Task<DeleteCertificateRequestResponse> DeleteCertificateRequestAsync(DeleteCertificateRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCertificateRequestWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteCsrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCsrResponse
         */
        public DeleteCsrResponse DeleteCsrWithOptions(DeleteCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsrId))
            {
                query["CsrId"] = request.CsrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCsr",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCsrResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteCsrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCsrResponse
         */
        public async Task<DeleteCsrResponse> DeleteCsrWithOptionsAsync(DeleteCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsrId))
            {
                query["CsrId"] = request.CsrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCsr",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCsrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteCsrRequest
         * @return DeleteCsrResponse
         */
        public DeleteCsrResponse DeleteCsr(DeleteCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCsrWithOptions(request, runtime);
        }

        /**
         * @param request DeleteCsrRequest
         * @return DeleteCsrResponse
         */
        public async Task<DeleteCsrResponse> DeleteCsrAsync(DeleteCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCsrWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除部署任务
         *
         * @param request DeleteDeploymentJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeploymentJobResponse
         */
        public DeleteDeploymentJobResponse DeleteDeploymentJobWithOptions(DeleteDeploymentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeploymentJob",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除部署任务
         *
         * @param request DeleteDeploymentJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeploymentJobResponse
         */
        public async Task<DeleteDeploymentJobResponse> DeleteDeploymentJobWithOptionsAsync(DeleteDeploymentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeploymentJob",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除部署任务
         *
         * @param request DeleteDeploymentJobRequest
         * @return DeleteDeploymentJobResponse
         */
        public DeleteDeploymentJobResponse DeleteDeploymentJob(DeleteDeploymentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeploymentJobWithOptions(request, runtime);
        }

        /**
         * @summary 删除部署任务
         *
         * @param request DeleteDeploymentJobRequest
         * @return DeleteDeploymentJobResponse
         */
        public async Task<DeleteDeploymentJobResponse> DeleteDeploymentJobAsync(DeleteDeploymentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeploymentJobWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeletePCACertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePCACertResponse
         */
        public DeletePCACertResponse DeletePCACertWithOptions(DeletePCACertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePCACert",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePCACertResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeletePCACertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePCACertResponse
         */
        public async Task<DeletePCACertResponse> DeletePCACertWithOptionsAsync(DeletePCACertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePCACert",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePCACertResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeletePCACertRequest
         * @return DeletePCACertResponse
         */
        public DeletePCACertResponse DeletePCACert(DeletePCACertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePCACertWithOptions(request, runtime);
        }

        /**
         * @param request DeletePCACertRequest
         * @return DeletePCACertResponse
         */
        public async Task<DeletePCACertResponse> DeletePCACertAsync(DeletePCACertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePCACertWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an expired or uploaded certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteUserCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserCertificateResponse
         */
        public DeleteUserCertificateResponse DeleteUserCertificateWithOptions(DeleteUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserCertificate",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an expired or uploaded certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteUserCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserCertificateResponse
         */
        public async Task<DeleteUserCertificateResponse> DeleteUserCertificateWithOptionsAsync(DeleteUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserCertificate",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an expired or uploaded certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteUserCertificateRequest
         * @return DeleteUserCertificateResponse
         */
        public DeleteUserCertificateResponse DeleteUserCertificate(DeleteUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserCertificateWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an expired or uploaded certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteUserCertificateRequest
         * @return DeleteUserCertificateResponse
         */
        public async Task<DeleteUserCertificateResponse> DeleteUserCertificateAsync(DeleteUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除部署任务worker
         *
         * @param request DeleteWorkerResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkerResourceResponse
         */
        public DeleteWorkerResourceResponse DeleteWorkerResourceWithOptions(DeleteWorkerResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerId))
            {
                query["WorkerId"] = request.WorkerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkerResource",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkerResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除部署任务worker
         *
         * @param request DeleteWorkerResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkerResourceResponse
         */
        public async Task<DeleteWorkerResourceResponse> DeleteWorkerResourceWithOptionsAsync(DeleteWorkerResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerId))
            {
                query["WorkerId"] = request.WorkerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkerResource",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkerResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除部署任务worker
         *
         * @param request DeleteWorkerResourceRequest
         * @return DeleteWorkerResourceResponse
         */
        public DeleteWorkerResourceResponse DeleteWorkerResource(DeleteWorkerResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWorkerResourceWithOptions(request, runtime);
        }

        /**
         * @summary 删除部署任务worker
         *
         * @param request DeleteWorkerResourceRequest
         * @return DeleteWorkerResourceResponse
         */
        public async Task<DeleteWorkerResourceResponse> DeleteWorkerResourceAsync(DeleteWorkerResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWorkerResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status of a specified certificate application order.
         *
         * @description If you do not complete the verification of the domain name ownership after you submit a certificate application, you can call this operation to obtain the information that is required to complete the verification. You can complete the verification of the domain name ownership based on the data returned. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on the DNS server.
         * The certificate authority (CA) reviews your certificate application only after you complete the verification of the domain name ownership. After the CA approves your certificate application, the CA issues the certificate. If a certificate is issued, you can call this operation to obtain the CA certificate and private key of the certificate.
         *
         * @param request DescribeCertificateStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertificateStateResponse
         */
        public DescribeCertificateStateResponse DescribeCertificateStateWithOptions(DescribeCertificateStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCertificateState",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertificateStateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a specified certificate application order.
         *
         * @description If you do not complete the verification of the domain name ownership after you submit a certificate application, you can call this operation to obtain the information that is required to complete the verification. You can complete the verification of the domain name ownership based on the data returned. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on the DNS server.
         * The certificate authority (CA) reviews your certificate application only after you complete the verification of the domain name ownership. After the CA approves your certificate application, the CA issues the certificate. If a certificate is issued, you can call this operation to obtain the CA certificate and private key of the certificate.
         *
         * @param request DescribeCertificateStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertificateStateResponse
         */
        public async Task<DescribeCertificateStateResponse> DescribeCertificateStateWithOptionsAsync(DescribeCertificateStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCertificateState",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertificateStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a specified certificate application order.
         *
         * @description If you do not complete the verification of the domain name ownership after you submit a certificate application, you can call this operation to obtain the information that is required to complete the verification. You can complete the verification of the domain name ownership based on the data returned. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on the DNS server.
         * The certificate authority (CA) reviews your certificate application only after you complete the verification of the domain name ownership. After the CA approves your certificate application, the CA issues the certificate. If a certificate is issued, you can call this operation to obtain the CA certificate and private key of the certificate.
         *
         * @param request DescribeCertificateStateRequest
         * @return DescribeCertificateStateResponse
         */
        public DescribeCertificateStateResponse DescribeCertificateState(DescribeCertificateStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificateStateWithOptions(request, runtime);
        }

        /**
         * @summary Queries the status of a specified certificate application order.
         *
         * @description If you do not complete the verification of the domain name ownership after you submit a certificate application, you can call this operation to obtain the information that is required to complete the verification. You can complete the verification of the domain name ownership based on the data returned. If you use the DNS verification method, you must complete the verification on the management platform of the domain name. If you use the file verification method, you must complete the verification on the DNS server.
         * The certificate authority (CA) reviews your certificate application only after you complete the verification of the domain name ownership. After the CA approves your certificate application, the CA issues the certificate. If a certificate is issued, you can call this operation to obtain the CA certificate and private key of the certificate.
         *
         * @param request DescribeCertificateStateRequest
         * @return DescribeCertificateStateResponse
         */
        public async Task<DescribeCertificateStateResponse> DescribeCertificateStateAsync(DescribeCertificateStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificateStateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 云产品分组-获取用户资源计数 
         *
         * @param request DescribeCloudResourceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCloudResourceStatusResponse
         */
        public DescribeCloudResourceStatusResponse DescribeCloudResourceStatusWithOptions(DescribeCloudResourceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudResourceStatus",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudResourceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 云产品分组-获取用户资源计数 
         *
         * @param request DescribeCloudResourceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCloudResourceStatusResponse
         */
        public async Task<DescribeCloudResourceStatusResponse> DescribeCloudResourceStatusWithOptionsAsync(DescribeCloudResourceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudResourceStatus",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudResourceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 云产品分组-获取用户资源计数 
         *
         * @param request DescribeCloudResourceStatusRequest
         * @return DescribeCloudResourceStatusResponse
         */
        public DescribeCloudResourceStatusResponse DescribeCloudResourceStatus(DescribeCloudResourceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudResourceStatusWithOptions(request, runtime);
        }

        /**
         * @summary 云产品分组-获取用户资源计数 
         *
         * @param request DescribeCloudResourceStatusRequest
         * @return DescribeCloudResourceStatusResponse
         */
        public async Task<DescribeCloudResourceStatusResponse> DescribeCloudResourceStatusAsync(DescribeCloudResourceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudResourceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取部署任务详情
         *
         * @param request DescribeDeploymentJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeploymentJobResponse
         */
        public DescribeDeploymentJobResponse DescribeDeploymentJobWithOptions(DescribeDeploymentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeploymentJob",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeploymentJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取部署任务详情
         *
         * @param request DescribeDeploymentJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeploymentJobResponse
         */
        public async Task<DescribeDeploymentJobResponse> DescribeDeploymentJobWithOptionsAsync(DescribeDeploymentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeploymentJob",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeploymentJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取部署任务详情
         *
         * @param request DescribeDeploymentJobRequest
         * @return DescribeDeploymentJobResponse
         */
        public DescribeDeploymentJobResponse DescribeDeploymentJob(DescribeDeploymentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeploymentJobWithOptions(request, runtime);
        }

        /**
         * @summary 获取部署任务详情
         *
         * @param request DescribeDeploymentJobRequest
         * @return DescribeDeploymentJobResponse
         */
        public async Task<DescribeDeploymentJobResponse> DescribeDeploymentJobAsync(DescribeDeploymentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeploymentJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询任务状态
         *
         * @param request DescribeDeploymentJobStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeploymentJobStatusResponse
         */
        public DescribeDeploymentJobStatusResponse DescribeDeploymentJobStatusWithOptions(DescribeDeploymentJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeploymentJobStatus",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeploymentJobStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询任务状态
         *
         * @param request DescribeDeploymentJobStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeploymentJobStatusResponse
         */
        public async Task<DescribeDeploymentJobStatusResponse> DescribeDeploymentJobStatusWithOptionsAsync(DescribeDeploymentJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeploymentJobStatus",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeploymentJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询任务状态
         *
         * @param request DescribeDeploymentJobStatusRequest
         * @return DescribeDeploymentJobStatusResponse
         */
        public DescribeDeploymentJobStatusResponse DescribeDeploymentJobStatus(DescribeDeploymentJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeploymentJobStatusWithOptions(request, runtime);
        }

        /**
         * @summary 查询任务状态
         *
         * @param request DescribeDeploymentJobStatusRequest
         * @return DescribeDeploymentJobStatusResponse
         */
        public async Task<DescribeDeploymentJobStatusResponse> DescribeDeploymentJobStatusAsync(DescribeDeploymentJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeploymentJobStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the number and usage of purchased domain validated (DV) certificates.
         *
         * @param request DescribePackageStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePackageStateResponse
         */
        public DescribePackageStateResponse DescribePackageStateWithOptions(DescribePackageStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePackageState",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePackageStateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the number and usage of purchased domain validated (DV) certificates.
         *
         * @param request DescribePackageStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePackageStateResponse
         */
        public async Task<DescribePackageStateResponse> DescribePackageStateWithOptionsAsync(DescribePackageStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePackageState",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePackageStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the number and usage of purchased domain validated (DV) certificates.
         *
         * @param request DescribePackageStateRequest
         * @return DescribePackageStateResponse
         */
        public DescribePackageStateResponse DescribePackageState(DescribePackageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackageStateWithOptions(request, runtime);
        }

        /**
         * @summary Queries the number and usage of purchased domain validated (DV) certificates.
         *
         * @param request DescribePackageStateRequest
         * @return DescribePackageStateResponse
         */
        public async Task<DescribePackageStateResponse> DescribePackageStateAsync(DescribePackageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackageStateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request EncryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EncryptResponse
         */
        public EncryptResponse EncryptWithOptions(EncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plaintext))
            {
                query["Plaintext"] = request.Plaintext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Encrypt",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EncryptResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request EncryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EncryptResponse
         */
        public async Task<EncryptResponse> EncryptWithOptionsAsync(EncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plaintext))
            {
                query["Plaintext"] = request.Plaintext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Encrypt",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EncryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request EncryptRequest
         * @return EncryptResponse
         */
        public EncryptResponse Encrypt(EncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EncryptWithOptions(request, runtime);
        }

        /**
         * @param request EncryptRequest
         * @return EncryptResponse
         */
        public async Task<EncryptResponse> EncryptAsync(EncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EncryptWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetCertWarehouseQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCertWarehouseQuotaResponse
         */
        public GetCertWarehouseQuotaResponse GetCertWarehouseQuotaWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCertWarehouseQuota",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCertWarehouseQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetCertWarehouseQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCertWarehouseQuotaResponse
         */
        public async Task<GetCertWarehouseQuotaResponse> GetCertWarehouseQuotaWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCertWarehouseQuota",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCertWarehouseQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return GetCertWarehouseQuotaResponse
         */
        public GetCertWarehouseQuotaResponse GetCertWarehouseQuota()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCertWarehouseQuotaWithOptions(runtime);
        }

        /**
         * @return GetCertWarehouseQuotaResponse
         */
        public async Task<GetCertWarehouseQuotaResponse> GetCertWarehouseQuotaAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCertWarehouseQuotaWithOptionsAsync(runtime);
        }

        /**
         * @param request GetCsrDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCsrDetailResponse
         */
        public GetCsrDetailResponse GetCsrDetailWithOptions(GetCsrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsrId))
            {
                query["CsrId"] = request.CsrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCsrDetail",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCsrDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetCsrDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCsrDetailResponse
         */
        public async Task<GetCsrDetailResponse> GetCsrDetailWithOptionsAsync(GetCsrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsrId))
            {
                query["CsrId"] = request.CsrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCsrDetail",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCsrDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetCsrDetailRequest
         * @return GetCsrDetailResponse
         */
        public GetCsrDetailResponse GetCsrDetail(GetCsrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCsrDetailWithOptions(request, runtime);
        }

        /**
         * @param request GetCsrDetailRequest
         * @return GetCsrDetailResponse
         */
        public async Task<GetCsrDetailResponse> GetCsrDetailAsync(GetCsrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCsrDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetUserCertificateDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserCertificateDetailResponse
         */
        public GetUserCertificateDetailResponse GetUserCertificateDetailWithOptions(GetUserCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertFilter))
            {
                query["CertFilter"] = request.CertFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserCertificateDetail",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserCertificateDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetUserCertificateDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserCertificateDetailResponse
         */
        public async Task<GetUserCertificateDetailResponse> GetUserCertificateDetailWithOptionsAsync(GetUserCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertFilter))
            {
                query["CertFilter"] = request.CertFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserCertificateDetail",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserCertificateDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetUserCertificateDetailRequest
         * @return GetUserCertificateDetailResponse
         */
        public GetUserCertificateDetailResponse GetUserCertificateDetail(GetUserCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserCertificateDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request GetUserCertificateDetailRequest
         * @return GetUserCertificateDetailResponse
         */
        public async Task<GetUserCertificateDetailResponse> GetUserCertificateDetailAsync(GetUserCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserCertificateDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the certificates in a certificate repository.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListCertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCertResponse
         */
        public ListCertResponse ListCertWithOptions(ListCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarehouseId))
            {
                query["WarehouseId"] = request.WarehouseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCert",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCertResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the certificates in a certificate repository.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListCertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCertResponse
         */
        public async Task<ListCertResponse> ListCertWithOptionsAsync(ListCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarehouseId))
            {
                query["WarehouseId"] = request.WarehouseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCert",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCertResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the certificates in a certificate repository.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListCertRequest
         * @return ListCertResponse
         */
        public ListCertResponse ListCert(ListCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCertWithOptions(request, runtime);
        }

        /**
         * @summary Queries the certificates in a certificate repository.
         *
         * @description You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListCertRequest
         * @return ListCertResponse
         */
        public async Task<ListCertResponse> ListCertAsync(ListCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCertWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListCertWarehouseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCertWarehouseResponse
         */
        public ListCertWarehouseResponse ListCertWarehouseWithOptions(ListCertWarehouseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
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
                Action = "ListCertWarehouse",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCertWarehouseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListCertWarehouseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCertWarehouseResponse
         */
        public async Task<ListCertWarehouseResponse> ListCertWarehouseWithOptionsAsync(ListCertWarehouseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
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
                Action = "ListCertWarehouse",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCertWarehouseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListCertWarehouseRequest
         * @return ListCertWarehouseResponse
         */
        public ListCertWarehouseResponse ListCertWarehouse(ListCertWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCertWarehouseWithOptions(request, runtime);
        }

        /**
         * @param request ListCertWarehouseRequest
         * @return ListCertWarehouseResponse
         */
        public async Task<ListCertWarehouseResponse> ListCertWarehouseAsync(ListCertWarehouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCertWarehouseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 云授权ak查询
         *
         * @param request ListCloudAccessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCloudAccessResponse
         */
        public ListCloudAccessResponse ListCloudAccessWithOptions(ListCloudAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudName))
            {
                query["CloudName"] = request.CloudName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudAccess",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudAccessResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 云授权ak查询
         *
         * @param request ListCloudAccessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCloudAccessResponse
         */
        public async Task<ListCloudAccessResponse> ListCloudAccessWithOptionsAsync(ListCloudAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudName))
            {
                query["CloudName"] = request.CloudName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudAccess",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudAccessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 云授权ak查询
         *
         * @param request ListCloudAccessRequest
         * @return ListCloudAccessResponse
         */
        public ListCloudAccessResponse ListCloudAccess(ListCloudAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCloudAccessWithOptions(request, runtime);
        }

        /**
         * @summary 云授权ak查询
         *
         * @param request ListCloudAccessRequest
         * @return ListCloudAccessResponse
         */
        public async Task<ListCloudAccessResponse> ListCloudAccessAsync(ListCloudAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCloudAccessWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 可选择的资源-查询云资源列表
         *
         * @param request ListCloudResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCloudResourcesResponse
         */
        public ListCloudResourcesResponse ListCloudResourcesWithOptions(ListCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudName))
            {
                query["CloudName"] = request.CloudName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudProduct))
            {
                query["CloudProduct"] = request.CloudProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudResources",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 可选择的资源-查询云资源列表
         *
         * @param request ListCloudResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCloudResourcesResponse
         */
        public async Task<ListCloudResourcesResponse> ListCloudResourcesWithOptionsAsync(ListCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudName))
            {
                query["CloudName"] = request.CloudName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudProduct))
            {
                query["CloudProduct"] = request.CloudProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudResources",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 可选择的资源-查询云资源列表
         *
         * @param request ListCloudResourcesRequest
         * @return ListCloudResourcesResponse
         */
        public ListCloudResourcesResponse ListCloudResources(ListCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCloudResourcesWithOptions(request, runtime);
        }

        /**
         * @summary 可选择的资源-查询云资源列表
         *
         * @param request ListCloudResourcesRequest
         * @return ListCloudResourcesResponse
         */
        public async Task<ListCloudResourcesResponse> ListCloudResourcesAsync(ListCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCloudResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取联系人列表
         *
         * @param request ListContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListContactResponse
         */
        public ListContactResponse ListContactWithOptions(ListContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContact",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取联系人列表
         *
         * @param request ListContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListContactResponse
         */
        public async Task<ListContactResponse> ListContactWithOptionsAsync(ListContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContact",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取联系人列表
         *
         * @param request ListContactRequest
         * @return ListContactResponse
         */
        public ListContactResponse ListContact(ListContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContactWithOptions(request, runtime);
        }

        /**
         * @summary 获取联系人列表
         *
         * @param request ListContactRequest
         * @return ListContactResponse
         */
        public async Task<ListContactResponse> ListContactAsync(ListContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContactWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListCsrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCsrResponse
         */
        public ListCsrResponse ListCsrWithOptions(ListCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCsr",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCsrResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListCsrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCsrResponse
         */
        public async Task<ListCsrResponse> ListCsrWithOptionsAsync(ListCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCsr",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCsrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListCsrRequest
         * @return ListCsrResponse
         */
        public ListCsrResponse ListCsr(ListCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCsrWithOptions(request, runtime);
        }

        /**
         * @param request ListCsrRequest
         * @return ListCsrResponse
         */
        public async Task<ListCsrResponse> ListCsrAsync(ListCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCsrWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取部署任务列表
         *
         * @param request ListDeploymentJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentJobResponse
         */
        public ListDeploymentJobResponse ListDeploymentJobWithOptions(ListDeploymentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentJob",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取部署任务列表
         *
         * @param request ListDeploymentJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentJobResponse
         */
        public async Task<ListDeploymentJobResponse> ListDeploymentJobWithOptionsAsync(ListDeploymentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentJob",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取部署任务列表
         *
         * @param request ListDeploymentJobRequest
         * @return ListDeploymentJobResponse
         */
        public ListDeploymentJobResponse ListDeploymentJob(ListDeploymentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeploymentJobWithOptions(request, runtime);
        }

        /**
         * @summary 获取部署任务列表
         *
         * @param request ListDeploymentJobRequest
         * @return ListDeploymentJobResponse
         */
        public async Task<ListDeploymentJobResponse> ListDeploymentJobAsync(ListDeploymentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeploymentJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取部署任务的证书列表
         *
         * @param request ListDeploymentJobCertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentJobCertResponse
         */
        public ListDeploymentJobCertResponse ListDeploymentJobCertWithOptions(ListDeploymentJobCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentJobCert",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentJobCertResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取部署任务的证书列表
         *
         * @param request ListDeploymentJobCertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentJobCertResponse
         */
        public async Task<ListDeploymentJobCertResponse> ListDeploymentJobCertWithOptionsAsync(ListDeploymentJobCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentJobCert",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentJobCertResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取部署任务的证书列表
         *
         * @param request ListDeploymentJobCertRequest
         * @return ListDeploymentJobCertResponse
         */
        public ListDeploymentJobCertResponse ListDeploymentJobCert(ListDeploymentJobCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeploymentJobCertWithOptions(request, runtime);
        }

        /**
         * @summary 获取部署任务的证书列表
         *
         * @param request ListDeploymentJobCertRequest
         * @return ListDeploymentJobCertResponse
         */
        public async Task<ListDeploymentJobCertResponse> ListDeploymentJobCertAsync(ListDeploymentJobCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeploymentJobCertWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 部署任务的资源列表
         *
         * @param request ListDeploymentJobResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentJobResourceResponse
         */
        public ListDeploymentJobResourceResponse ListDeploymentJobResourceWithOptions(ListDeploymentJobResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentJobResource",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentJobResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 部署任务的资源列表
         *
         * @param request ListDeploymentJobResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeploymentJobResourceResponse
         */
        public async Task<ListDeploymentJobResourceResponse> ListDeploymentJobResourceWithOptionsAsync(ListDeploymentJobResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentJobResource",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentJobResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 部署任务的资源列表
         *
         * @param request ListDeploymentJobResourceRequest
         * @return ListDeploymentJobResourceResponse
         */
        public ListDeploymentJobResourceResponse ListDeploymentJobResource(ListDeploymentJobResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeploymentJobResourceWithOptions(request, runtime);
        }

        /**
         * @summary 部署任务的资源列表
         *
         * @param request ListDeploymentJobResourceRequest
         * @return ListDeploymentJobResourceResponse
         */
        public async Task<ListDeploymentJobResourceResponse> ListDeploymentJobResourceAsync(ListDeploymentJobResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeploymentJobResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the certificates or certificate orders of users.
         *
         * @description You can call the ListUserCertificateOrder operation to query the certificates or certificate orders of users. If you set OrderType to CERT or UPLOAD, certificates are returned. If you set OrderType to CPACK or BUY, certificate orders are returned.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListUserCertificateOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserCertificateOrderResponse
         */
        public ListUserCertificateOrderResponse ListUserCertificateOrderWithOptions(ListUserCertificateOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserCertificateOrder",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserCertificateOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the certificates or certificate orders of users.
         *
         * @description You can call the ListUserCertificateOrder operation to query the certificates or certificate orders of users. If you set OrderType to CERT or UPLOAD, certificates are returned. If you set OrderType to CPACK or BUY, certificate orders are returned.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListUserCertificateOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserCertificateOrderResponse
         */
        public async Task<ListUserCertificateOrderResponse> ListUserCertificateOrderWithOptionsAsync(ListUserCertificateOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserCertificateOrder",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserCertificateOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the certificates or certificate orders of users.
         *
         * @description You can call the ListUserCertificateOrder operation to query the certificates or certificate orders of users. If you set OrderType to CERT or UPLOAD, certificates are returned. If you set OrderType to CPACK or BUY, certificate orders are returned.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListUserCertificateOrderRequest
         * @return ListUserCertificateOrderResponse
         */
        public ListUserCertificateOrderResponse ListUserCertificateOrder(ListUserCertificateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserCertificateOrderWithOptions(request, runtime);
        }

        /**
         * @summary Queries the certificates or certificate orders of users.
         *
         * @description You can call the ListUserCertificateOrder operation to query the certificates or certificate orders of users. If you set OrderType to CERT or UPLOAD, certificates are returned. If you set OrderType to CPACK or BUY, certificate orders are returned.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ListUserCertificateOrderRequest
         * @return ListUserCertificateOrderResponse
         */
        public async Task<ListUserCertificateOrderResponse> ListUserCertificateOrderAsync(ListUserCertificateOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserCertificateOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询部署任务worker
         *
         * @param request ListWorkerResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkerResourceResponse
         */
        public ListWorkerResourceResponse ListWorkerResourceWithOptions(ListWorkerResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudProduct))
            {
                query["CloudProduct"] = request.CloudProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkerResource",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkerResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询部署任务worker
         *
         * @param request ListWorkerResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkerResourceResponse
         */
        public async Task<ListWorkerResourceResponse> ListWorkerResourceWithOptionsAsync(ListWorkerResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudProduct))
            {
                query["CloudProduct"] = request.CloudProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkerResource",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkerResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询部署任务worker
         *
         * @param request ListWorkerResourceRequest
         * @return ListWorkerResourceResponse
         */
        public ListWorkerResourceResponse ListWorkerResource(ListWorkerResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkerResourceWithOptions(request, runtime);
        }

        /**
         * @summary 查询部署任务worker
         *
         * @param request ListWorkerResourceRequest
         * @return ListWorkerResourceResponse
         */
        public async Task<ListWorkerResourceResponse> ListWorkerResourceAsync(ListWorkerResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkerResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Move Resource Group
         *
         * @param request MoveResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveResourceGroupResponse
         */
        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Move Resource Group
         *
         * @param request MoveResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveResourceGroupResponse
         */
        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Move Resource Group
         *
         * @param request MoveResourceGroupRequest
         * @return MoveResourceGroupResponse
         */
        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Move Resource Group
         *
         * @param request MoveResourceGroupRequest
         * @return MoveResourceGroupResponse
         */
        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Submits a renewal application for the certificate order of an issued certificate.
         *
         * @description You can call this operation to submit a renewal application for a certificate only when the order of the certificate is in the expiring state. After the renewal is complete, a new certificate order whose status is pending application is generated. You must submit a certificate application for the new certificate order and install the new certificate after the new certificate is issued.
         * > You can call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to query the status of a certificate application order. If the value of the **Type** response parameter is **certificate**, the certificate is issued.
         *
         * @param request RenewCertificateOrderForPackageRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewCertificateOrderForPackageRequestResponse
         */
        public RenewCertificateOrderForPackageRequestResponse RenewCertificateOrderForPackageRequestWithOptions(RenewCertificateOrderForPackageRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
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
                Action = "RenewCertificateOrderForPackageRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewCertificateOrderForPackageRequestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Submits a renewal application for the certificate order of an issued certificate.
         *
         * @description You can call this operation to submit a renewal application for a certificate only when the order of the certificate is in the expiring state. After the renewal is complete, a new certificate order whose status is pending application is generated. You must submit a certificate application for the new certificate order and install the new certificate after the new certificate is issued.
         * > You can call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to query the status of a certificate application order. If the value of the **Type** response parameter is **certificate**, the certificate is issued.
         *
         * @param request RenewCertificateOrderForPackageRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewCertificateOrderForPackageRequestResponse
         */
        public async Task<RenewCertificateOrderForPackageRequestResponse> RenewCertificateOrderForPackageRequestWithOptionsAsync(RenewCertificateOrderForPackageRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
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
                Action = "RenewCertificateOrderForPackageRequest",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewCertificateOrderForPackageRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Submits a renewal application for the certificate order of an issued certificate.
         *
         * @description You can call this operation to submit a renewal application for a certificate only when the order of the certificate is in the expiring state. After the renewal is complete, a new certificate order whose status is pending application is generated. You must submit a certificate application for the new certificate order and install the new certificate after the new certificate is issued.
         * > You can call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to query the status of a certificate application order. If the value of the **Type** response parameter is **certificate**, the certificate is issued.
         *
         * @param request RenewCertificateOrderForPackageRequestRequest
         * @return RenewCertificateOrderForPackageRequestResponse
         */
        public RenewCertificateOrderForPackageRequestResponse RenewCertificateOrderForPackageRequest(RenewCertificateOrderForPackageRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewCertificateOrderForPackageRequestWithOptions(request, runtime);
        }

        /**
         * @summary Submits a renewal application for the certificate order of an issued certificate.
         *
         * @description You can call this operation to submit a renewal application for a certificate only when the order of the certificate is in the expiring state. After the renewal is complete, a new certificate order whose status is pending application is generated. You must submit a certificate application for the new certificate order and install the new certificate after the new certificate is issued.
         * > You can call the [DescribeCertificateState](https://help.aliyun.com/document_detail/455800.html) operation to query the status of a certificate application order. If the value of the **Type** response parameter is **certificate**, the certificate is issued.
         *
         * @param request RenewCertificateOrderForPackageRequestRequest
         * @return RenewCertificateOrderForPackageRequestResponse
         */
        public async Task<RenewCertificateOrderForPackageRequestResponse> RenewCertificateOrderForPackageRequestAsync(RenewCertificateOrderForPackageRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewCertificateOrderForPackageRequestWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RevokeWHClientCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeWHClientCertificateResponse
         */
        public RevokeWHClientCertificateResponse RevokeWHClientCertificateWithOptions(RevokeWHClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeWHClientCertificate",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeWHClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RevokeWHClientCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeWHClientCertificateResponse
         */
        public async Task<RevokeWHClientCertificateResponse> RevokeWHClientCertificateWithOptionsAsync(RevokeWHClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeWHClientCertificate",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeWHClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RevokeWHClientCertificateRequest
         * @return RevokeWHClientCertificateResponse
         */
        public RevokeWHClientCertificateResponse RevokeWHClientCertificate(RevokeWHClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeWHClientCertificateWithOptions(request, runtime);
        }

        /**
         * @param request RevokeWHClientCertificateRequest
         * @return RevokeWHClientCertificateResponse
         */
        public async Task<RevokeWHClientCertificateResponse> RevokeWHClientCertificateAsync(RevokeWHClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeWHClientCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SignRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SignResponse
         */
        public SignResponse SignWithOptions(SignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SigningAlgorithm))
            {
                query["SigningAlgorithm"] = request.SigningAlgorithm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Sign",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SignRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SignResponse
         */
        public async Task<SignResponse> SignWithOptionsAsync(SignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SigningAlgorithm))
            {
                query["SigningAlgorithm"] = request.SigningAlgorithm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Sign",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SignRequest
         * @return SignResponse
         */
        public SignResponse Sign(SignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SignWithOptions(request, runtime);
        }

        /**
         * @param request SignRequest
         * @return SignResponse
         */
        public async Task<SignResponse> SignAsync(SignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SignWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateCsrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCsrResponse
         */
        public UpdateCsrResponse UpdateCsrWithOptions(UpdateCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsrId))
            {
                query["CsrId"] = request.CsrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCsr",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCsrResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateCsrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCsrResponse
         */
        public async Task<UpdateCsrResponse> UpdateCsrWithOptionsAsync(UpdateCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsrId))
            {
                query["CsrId"] = request.CsrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCsr",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCsrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateCsrRequest
         * @return UpdateCsrResponse
         */
        public UpdateCsrResponse UpdateCsr(UpdateCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCsrWithOptions(request, runtime);
        }

        /**
         * @param request UpdateCsrRequest
         * @return UpdateCsrResponse
         */
        public async Task<UpdateCsrResponse> UpdateCsrAsync(UpdateCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCsrWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新部署任务
         *
         * @param request UpdateDeploymentJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeploymentJobResponse
         */
        public UpdateDeploymentJobResponse UpdateDeploymentJobWithOptions(UpdateDeploymentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactIds))
            {
                query["ContactIds"] = request.ContactIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentJob",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新部署任务
         *
         * @param request UpdateDeploymentJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeploymentJobResponse
         */
        public async Task<UpdateDeploymentJobResponse> UpdateDeploymentJobWithOptionsAsync(UpdateDeploymentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactIds))
            {
                query["ContactIds"] = request.ContactIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentJob",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新部署任务
         *
         * @param request UpdateDeploymentJobRequest
         * @return UpdateDeploymentJobResponse
         */
        public UpdateDeploymentJobResponse UpdateDeploymentJob(UpdateDeploymentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeploymentJobWithOptions(request, runtime);
        }

        /**
         * @summary 更新部署任务
         *
         * @param request UpdateDeploymentJobRequest
         * @return UpdateDeploymentJobResponse
         */
        public async Task<UpdateDeploymentJobResponse> UpdateDeploymentJobAsync(UpdateDeploymentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeploymentJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新任务部署任务状态
         *
         * @param request UpdateDeploymentJobStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeploymentJobStatusResponse
         */
        public UpdateDeploymentJobStatusResponse UpdateDeploymentJobStatusWithOptions(UpdateDeploymentJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentJobStatus",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentJobStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新任务部署任务状态
         *
         * @param request UpdateDeploymentJobStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeploymentJobStatusResponse
         */
        public async Task<UpdateDeploymentJobStatusResponse> UpdateDeploymentJobStatusWithOptionsAsync(UpdateDeploymentJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentJobStatus",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务部署任务状态
         *
         * @param request UpdateDeploymentJobStatusRequest
         * @return UpdateDeploymentJobStatusResponse
         */
        public UpdateDeploymentJobStatusResponse UpdateDeploymentJobStatus(UpdateDeploymentJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeploymentJobStatusWithOptions(request, runtime);
        }

        /**
         * @summary 更新任务部署任务状态
         *
         * @param request UpdateDeploymentJobStatusRequest
         * @return UpdateDeploymentJobStatusResponse
         */
        public async Task<UpdateDeploymentJobStatusResponse> UpdateDeploymentJobStatusAsync(UpdateDeploymentJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeploymentJobStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新部署任务worker状态
         *
         * @param request UpdateWorkerResourceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkerResourceStatusResponse
         */
        public UpdateWorkerResourceStatusResponse UpdateWorkerResourceStatusWithOptions(UpdateWorkerResourceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerId))
            {
                query["WorkerId"] = request.WorkerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkerResourceStatus",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkerResourceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新部署任务worker状态
         *
         * @param request UpdateWorkerResourceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkerResourceStatusResponse
         */
        public async Task<UpdateWorkerResourceStatusResponse> UpdateWorkerResourceStatusWithOptionsAsync(UpdateWorkerResourceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerId))
            {
                query["WorkerId"] = request.WorkerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkerResourceStatus",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkerResourceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新部署任务worker状态
         *
         * @param request UpdateWorkerResourceStatusRequest
         * @return UpdateWorkerResourceStatusResponse
         */
        public UpdateWorkerResourceStatusResponse UpdateWorkerResourceStatus(UpdateWorkerResourceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkerResourceStatusWithOptions(request, runtime);
        }

        /**
         * @summary 更新部署任务worker状态
         *
         * @param request UpdateWorkerResourceStatusRequest
         * @return UpdateWorkerResourceStatusResponse
         */
        public async Task<UpdateWorkerResourceStatusResponse> UpdateWorkerResourceStatusAsync(UpdateWorkerResourceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkerResourceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UploadCsrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadCsrResponse
         */
        public UploadCsrResponse UploadCsrWithOptions(UploadCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadCsr",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadCsrResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UploadCsrRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadCsrResponse
         */
        public async Task<UploadCsrResponse> UploadCsrWithOptionsAsync(UploadCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadCsr",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadCsrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UploadCsrRequest
         * @return UploadCsrResponse
         */
        public UploadCsrResponse UploadCsr(UploadCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadCsrWithOptions(request, runtime);
        }

        /**
         * @param request UploadCsrRequest
         * @return UploadCsrResponse
         */
        public async Task<UploadCsrResponse> UploadCsrAsync(UploadCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadCsrWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The private key of the certificate.
         *
         * @description The unique identifier of the certificate.
         *
         * @param request UploadPCACertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadPCACertResponse
         */
        public UploadPCACertResponse UploadPCACertWithOptions(UploadPCACertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cert))
            {
                query["Cert"] = request.Cert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarehouseId))
            {
                query["WarehouseId"] = request.WarehouseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadPCACert",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadPCACertResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The private key of the certificate.
         *
         * @description The unique identifier of the certificate.
         *
         * @param request UploadPCACertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadPCACertResponse
         */
        public async Task<UploadPCACertResponse> UploadPCACertWithOptionsAsync(UploadPCACertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cert))
            {
                query["Cert"] = request.Cert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarehouseId))
            {
                query["WarehouseId"] = request.WarehouseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadPCACert",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadPCACertResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The private key of the certificate.
         *
         * @description The unique identifier of the certificate.
         *
         * @param request UploadPCACertRequest
         * @return UploadPCACertResponse
         */
        public UploadPCACertResponse UploadPCACert(UploadPCACertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadPCACertWithOptions(request, runtime);
        }

        /**
         * @summary The private key of the certificate.
         *
         * @description The unique identifier of the certificate.
         *
         * @param request UploadPCACertRequest
         * @return UploadPCACertResponse
         */
        public async Task<UploadPCACertResponse> UploadPCACertAsync(UploadPCACertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadPCACertWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Uploads a certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UploadUserCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadUserCertificateResponse
         */
        public UploadUserCertificateResponse UploadUserCertificateWithOptions(UploadUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cert))
            {
                query["Cert"] = request.Cert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptCert))
            {
                query["EncryptCert"] = request.EncryptCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptPrivateKey))
            {
                query["EncryptPrivateKey"] = request.EncryptPrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignCert))
            {
                query["SignCert"] = request.SignCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignPrivateKey))
            {
                query["SignPrivateKey"] = request.SignPrivateKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadUserCertificate",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadUserCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Uploads a certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UploadUserCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadUserCertificateResponse
         */
        public async Task<UploadUserCertificateResponse> UploadUserCertificateWithOptionsAsync(UploadUserCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cert))
            {
                query["Cert"] = request.Cert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptCert))
            {
                query["EncryptCert"] = request.EncryptCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptPrivateKey))
            {
                query["EncryptPrivateKey"] = request.EncryptPrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignCert))
            {
                query["SignCert"] = request.SignCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignPrivateKey))
            {
                query["SignPrivateKey"] = request.SignPrivateKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadUserCertificate",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadUserCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Uploads a certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UploadUserCertificateRequest
         * @return UploadUserCertificateResponse
         */
        public UploadUserCertificateResponse UploadUserCertificate(UploadUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadUserCertificateWithOptions(request, runtime);
        }

        /**
         * @summary Uploads a certificate.
         *
         * @description You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request UploadUserCertificateRequest
         * @return UploadUserCertificateResponse
         */
        public async Task<UploadUserCertificateResponse> UploadUserCertificateAsync(UploadUserCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadUserCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request VerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyResponse
         */
        public VerifyResponse VerifyWithOptions(VerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureValue))
            {
                query["SignatureValue"] = request.SignatureValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SigningAlgorithm))
            {
                query["SigningAlgorithm"] = request.SigningAlgorithm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Verify",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request VerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyResponse
         */
        public async Task<VerifyResponse> VerifyWithOptionsAsync(VerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureValue))
            {
                query["SignatureValue"] = request.SignatureValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SigningAlgorithm))
            {
                query["SigningAlgorithm"] = request.SigningAlgorithm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Verify",
                Version = "2020-04-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request VerifyRequest
         * @return VerifyResponse
         */
        public VerifyResponse Verify(VerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyWithOptions(request, runtime);
        }

        /**
         * @param request VerifyRequest
         * @return VerifyResponse
         */
        public async Task<VerifyResponse> VerifyAsync(VerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyWithOptionsAsync(request, runtime);
        }

    }
}
