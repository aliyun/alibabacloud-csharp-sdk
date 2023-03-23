// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cas20200630.Models;

namespace AlibabaCloud.SDK.Cas20200630
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
                {"ap-southeast-1", "cas.aliyuncs.com"},
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
                {"cn-yushanfang", "cas.aliyuncs.com"},
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
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue client certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateClientCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateClientCertificateResponse
         */
        public CreateClientCertificateResponse CreateClientCertificateWithOptions(CreateClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateClientCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue client certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateClientCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateClientCertificateResponse
         */
        public async Task<CreateClientCertificateResponse> CreateClientCertificateWithOptionsAsync(CreateClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateClientCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue client certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateClientCertificateRequest
          * @return CreateClientCertificateResponse
         */
        public CreateClientCertificateResponse CreateClientCertificate(CreateClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientCertificateWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue client certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateClientCertificateRequest
          * @return CreateClientCertificateResponse
         */
        public async Task<CreateClientCertificateResponse> CreateClientCertificateAsync(CreateClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue client certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateClientCertificateWithCsrRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateClientCertificateWithCsrResponse
         */
        public CreateClientCertificateWithCsrResponse CreateClientCertificateWithCsrWithOptions(CreateClientCertificateWithCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr1))
            {
                query["Csr1"] = request.Csr1;
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
                Action = "CreateClientCertificateWithCsr",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientCertificateWithCsrResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue client certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateClientCertificateWithCsrRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateClientCertificateWithCsrResponse
         */
        public async Task<CreateClientCertificateWithCsrResponse> CreateClientCertificateWithCsrWithOptionsAsync(CreateClientCertificateWithCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr1))
            {
                query["Csr1"] = request.Csr1;
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
                Action = "CreateClientCertificateWithCsr",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientCertificateWithCsrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue client certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateClientCertificateWithCsrRequest
          * @return CreateClientCertificateWithCsrResponse
         */
        public CreateClientCertificateWithCsrResponse CreateClientCertificateWithCsr(CreateClientCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientCertificateWithCsrWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue client certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateClientCertificateWithCsrRequest
          * @return CreateClientCertificateWithCsrResponse
         */
        public async Task<CreateClientCertificateWithCsrResponse> CreateClientCertificateWithCsrAsync(CreateClientCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientCertificateWithCsrWithOptionsAsync(request, runtime);
        }

        public CreateCustomCertificateResponse CreateCustomCertificateWithOptions(CreateCustomCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiPassthrough))
            {
                query["ApiPassthrough"] = request.ApiPassthrough;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Immediately))
            {
                query["Immediately"] = request.Immediately;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentIdentifier))
            {
                query["ParentIdentifier"] = request.ParentIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Validity))
            {
                query["Validity"] = request.Validity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCustomCertificateResponse> CreateCustomCertificateWithOptionsAsync(CreateCustomCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiPassthrough))
            {
                query["ApiPassthrough"] = request.ApiPassthrough;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Immediately))
            {
                query["Immediately"] = request.Immediately;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentIdentifier))
            {
                query["ParentIdentifier"] = request.ParentIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Validity))
            {
                query["Validity"] = request.Validity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCustomCertificateResponse CreateCustomCertificate(CreateCustomCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomCertificateWithOptions(request, runtime);
        }

        public async Task<CreateCustomCertificateResponse> CreateCustomCertificateAsync(CreateCustomCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * After a client certificate or a server certificate is revoked, the client or the server on which the certificate is installed cannot establish HTTPS connections with other devices.
          * After a client certificate or a server certificate is revoked, you can call the [DeleteClientCertificate](~~330880~~) operation to permanently delete the certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateRevokeClientCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRevokeClientCertificateResponse
         */
        public CreateRevokeClientCertificateResponse CreateRevokeClientCertificateWithOptions(CreateRevokeClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateRevokeClientCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRevokeClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * After a client certificate or a server certificate is revoked, the client or the server on which the certificate is installed cannot establish HTTPS connections with other devices.
          * After a client certificate or a server certificate is revoked, you can call the [DeleteClientCertificate](~~330880~~) operation to permanently delete the certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateRevokeClientCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRevokeClientCertificateResponse
         */
        public async Task<CreateRevokeClientCertificateResponse> CreateRevokeClientCertificateWithOptionsAsync(CreateRevokeClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateRevokeClientCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRevokeClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * After a client certificate or a server certificate is revoked, the client or the server on which the certificate is installed cannot establish HTTPS connections with other devices.
          * After a client certificate or a server certificate is revoked, you can call the [DeleteClientCertificate](~~330880~~) operation to permanently delete the certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateRevokeClientCertificateRequest
          * @return CreateRevokeClientCertificateResponse
         */
        public CreateRevokeClientCertificateResponse CreateRevokeClientCertificate(CreateRevokeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRevokeClientCertificateWithOptions(request, runtime);
        }

        /**
          * After a client certificate or a server certificate is revoked, the client or the server on which the certificate is installed cannot establish HTTPS connections with other devices.
          * After a client certificate or a server certificate is revoked, you can call the [DeleteClientCertificate](~~330880~~) operation to permanently delete the certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateRevokeClientCertificateRequest
          * @return CreateRevokeClientCertificateResponse
         */
        public async Task<CreateRevokeClientCertificateResponse> CreateRevokeClientCertificateAsync(CreateRevokeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRevokeClientCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * You can call the CreateRootCACertificate operation to create a self-signed root CA certificate. A root CA certificate is the trust anchor in a chain of trust for private certificates that are used within an enterprise. You must create a root CA certificate before you can use the root CA certificate to issue intermediate CA certificates. Then, you can use the intermediate CA certificates to issue client certificates and server certificates.
          * Before you call this operation, make sure that you have purchased a private root CA instance by using the [Certificate Management Service console](https://yundun.console.aliyun.com/?p=cas#/pca/rootlist). For more information, see [Create a private CA](~~208553~~).
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateRootCACertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRootCACertificateResponse
         */
        public CreateRootCACertificateResponse CreateRootCACertificateWithOptions(CreateRootCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locality))
            {
                query["Locality"] = request.Locality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationUnit))
            {
                query["OrganizationUnit"] = request.OrganizationUnit;
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
                Action = "CreateRootCACertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRootCACertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the CreateRootCACertificate operation to create a self-signed root CA certificate. A root CA certificate is the trust anchor in a chain of trust for private certificates that are used within an enterprise. You must create a root CA certificate before you can use the root CA certificate to issue intermediate CA certificates. Then, you can use the intermediate CA certificates to issue client certificates and server certificates.
          * Before you call this operation, make sure that you have purchased a private root CA instance by using the [Certificate Management Service console](https://yundun.console.aliyun.com/?p=cas#/pca/rootlist). For more information, see [Create a private CA](~~208553~~).
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateRootCACertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRootCACertificateResponse
         */
        public async Task<CreateRootCACertificateResponse> CreateRootCACertificateWithOptionsAsync(CreateRootCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locality))
            {
                query["Locality"] = request.Locality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationUnit))
            {
                query["OrganizationUnit"] = request.OrganizationUnit;
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
                Action = "CreateRootCACertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRootCACertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the CreateRootCACertificate operation to create a self-signed root CA certificate. A root CA certificate is the trust anchor in a chain of trust for private certificates that are used within an enterprise. You must create a root CA certificate before you can use the root CA certificate to issue intermediate CA certificates. Then, you can use the intermediate CA certificates to issue client certificates and server certificates.
          * Before you call this operation, make sure that you have purchased a private root CA instance by using the [Certificate Management Service console](https://yundun.console.aliyun.com/?p=cas#/pca/rootlist). For more information, see [Create a private CA](~~208553~~).
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateRootCACertificateRequest
          * @return CreateRootCACertificateResponse
         */
        public CreateRootCACertificateResponse CreateRootCACertificate(CreateRootCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRootCACertificateWithOptions(request, runtime);
        }

        /**
          * You can call the CreateRootCACertificate operation to create a self-signed root CA certificate. A root CA certificate is the trust anchor in a chain of trust for private certificates that are used within an enterprise. You must create a root CA certificate before you can use the root CA certificate to issue intermediate CA certificates. Then, you can use the intermediate CA certificates to issue client certificates and server certificates.
          * Before you call this operation, make sure that you have purchased a private root CA instance by using the [Certificate Management Service console](https://yundun.console.aliyun.com/?p=cas#/pca/rootlist). For more information, see [Create a private CA](~~208553~~).
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateRootCACertificateRequest
          * @return CreateRootCACertificateResponse
         */
        public async Task<CreateRootCACertificateResponse> CreateRootCACertificateAsync(CreateRootCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRootCACertificateWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue server certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateServerCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateServerCertificateResponse
         */
        public CreateServerCertificateResponse CreateServerCertificateWithOptions(CreateServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
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
                Action = "CreateServerCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue server certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateServerCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateServerCertificateResponse
         */
        public async Task<CreateServerCertificateResponse> CreateServerCertificateWithOptionsAsync(CreateServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
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
                Action = "CreateServerCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue server certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateServerCertificateRequest
          * @return CreateServerCertificateResponse
         */
        public CreateServerCertificateResponse CreateServerCertificate(CreateServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServerCertificateWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue server certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateServerCertificateRequest
          * @return CreateServerCertificateResponse
         */
        public async Task<CreateServerCertificateResponse> CreateServerCertificateAsync(CreateServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServerCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue server certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateServerCertificateWithCsrRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateServerCertificateWithCsrResponse
         */
        public CreateServerCertificateWithCsrResponse CreateServerCertificateWithCsrWithOptions(CreateServerCertificateWithCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr1))
            {
                query["Csr1"] = request.Csr1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
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
                Action = "CreateServerCertificateWithCsr",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerCertificateWithCsrResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue server certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateServerCertificateWithCsrRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateServerCertificateWithCsrResponse
         */
        public async Task<CreateServerCertificateWithCsrResponse> CreateServerCertificateWithCsrWithOptionsAsync(CreateServerCertificateWithCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr1))
            {
                query["Csr1"] = request.Csr1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
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
                Action = "CreateServerCertificateWithCsr",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerCertificateWithCsrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue server certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateServerCertificateWithCsrRequest
          * @return CreateServerCertificateWithCsrResponse
         */
        public CreateServerCertificateWithCsrResponse CreateServerCertificateWithCsr(CreateServerCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServerCertificateWithCsrWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you have created a root certificate authority (CA) certificate by calling the [CreateRootCACertificate](~~328093~~) operation and an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation. Only intermediate CA certificates can be used to issue server certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateServerCertificateWithCsrRequest
          * @return CreateServerCertificateWithCsrResponse
         */
        public async Task<CreateServerCertificateWithCsrResponse> CreateServerCertificateWithCsrAsync(CreateServerCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServerCertificateWithCsrWithOptionsAsync(request, runtime);
        }

        /**
          * You can call the CreateSubCACertificate operation to issue an intermediate CA certificate by using an existing root CA certificate. Intermediate CA certificates can be used to issue client certificates and server certificates.
          * Before you call this operation, make sure that you have created a root CA certificate by calling the [CreateRootCACertificate](~~328093~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateSubCACertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSubCACertificateResponse
         */
        public CreateSubCACertificateResponse CreateSubCACertificateWithOptions(CreateSubCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedKeyUsages))
            {
                query["ExtendedKeyUsages"] = request.ExtendedKeyUsages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locality))
            {
                query["Locality"] = request.Locality;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathLenConstraint))
            {
                query["PathLenConstraint"] = request.PathLenConstraint;
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
                Action = "CreateSubCACertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubCACertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the CreateSubCACertificate operation to issue an intermediate CA certificate by using an existing root CA certificate. Intermediate CA certificates can be used to issue client certificates and server certificates.
          * Before you call this operation, make sure that you have created a root CA certificate by calling the [CreateRootCACertificate](~~328093~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateSubCACertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSubCACertificateResponse
         */
        public async Task<CreateSubCACertificateResponse> CreateSubCACertificateWithOptionsAsync(CreateSubCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedKeyUsages))
            {
                query["ExtendedKeyUsages"] = request.ExtendedKeyUsages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locality))
            {
                query["Locality"] = request.Locality;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathLenConstraint))
            {
                query["PathLenConstraint"] = request.PathLenConstraint;
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
                Action = "CreateSubCACertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubCACertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the CreateSubCACertificate operation to issue an intermediate CA certificate by using an existing root CA certificate. Intermediate CA certificates can be used to issue client certificates and server certificates.
          * Before you call this operation, make sure that you have created a root CA certificate by calling the [CreateRootCACertificate](~~328093~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateSubCACertificateRequest
          * @return CreateSubCACertificateResponse
         */
        public CreateSubCACertificateResponse CreateSubCACertificate(CreateSubCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubCACertificateWithOptions(request, runtime);
        }

        /**
          * You can call the CreateSubCACertificate operation to issue an intermediate CA certificate by using an existing root CA certificate. Intermediate CA certificates can be used to issue client certificates and server certificates.
          * Before you call this operation, make sure that you have created a root CA certificate by calling the [CreateRootCACertificate](~~328093~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request CreateSubCACertificateRequest
          * @return CreateSubCACertificateResponse
         */
        public async Task<CreateSubCACertificateResponse> CreateSubCACertificateAsync(CreateSubCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubCACertificateWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, you must call the [CreateRevokeClientCertificate](~~330876~~) operation to revoke a client certificate or a server certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DeleteClientCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteClientCertificateResponse
         */
        public DeleteClientCertificateResponse DeleteClientCertificateWithOptions(DeleteClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteClientCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must call the [CreateRevokeClientCertificate](~~330876~~) operation to revoke a client certificate or a server certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DeleteClientCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteClientCertificateResponse
         */
        public async Task<DeleteClientCertificateResponse> DeleteClientCertificateWithOptionsAsync(DeleteClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteClientCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, you must call the [CreateRevokeClientCertificate](~~330876~~) operation to revoke a client certificate or a server certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DeleteClientCertificateRequest
          * @return DeleteClientCertificateResponse
         */
        public DeleteClientCertificateResponse DeleteClientCertificate(DeleteClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientCertificateWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, you must call the [CreateRevokeClientCertificate](~~330876~~) operation to revoke a client certificate or a server certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DeleteClientCertificateRequest
          * @return DeleteClientCertificateResponse
         */
        public async Task<DeleteClientCertificateResponse> DeleteClientCertificateAsync(DeleteClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * You can call the DescribeCACertificate operation to query the details about a root CA certificate or an intermediate CA certificate by using the unique identifier of the root CA certificate or intermediate CA certificate. The details include the serial number, user information, and content of a CA certificate.
          * Before you call this operation, make sure that you have created a root CA by calling the [CreateRootCACertificate](~~328093~~) operation or an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCACertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCACertificateResponse
         */
        public DescribeCACertificateResponse DescribeCACertificateWithOptions(DescribeCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCACertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the DescribeCACertificate operation to query the details about a root CA certificate or an intermediate CA certificate by using the unique identifier of the root CA certificate or intermediate CA certificate. The details include the serial number, user information, and content of a CA certificate.
          * Before you call this operation, make sure that you have created a root CA by calling the [CreateRootCACertificate](~~328093~~) operation or an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCACertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCACertificateResponse
         */
        public async Task<DescribeCACertificateResponse> DescribeCACertificateWithOptionsAsync(DescribeCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCACertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the DescribeCACertificate operation to query the details about a root CA certificate or an intermediate CA certificate by using the unique identifier of the root CA certificate or intermediate CA certificate. The details include the serial number, user information, and content of a CA certificate.
          * Before you call this operation, make sure that you have created a root CA by calling the [CreateRootCACertificate](~~328093~~) operation or an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCACertificateRequest
          * @return DescribeCACertificateResponse
         */
        public DescribeCACertificateResponse DescribeCACertificate(DescribeCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificateWithOptions(request, runtime);
        }

        /**
          * You can call the DescribeCACertificate operation to query the details about a root CA certificate or an intermediate CA certificate by using the unique identifier of the root CA certificate or intermediate CA certificate. The details include the serial number, user information, and content of a CA certificate.
          * Before you call this operation, make sure that you have created a root CA by calling the [CreateRootCACertificate](~~328093~~) operation or an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCACertificateRequest
          * @return DescribeCACertificateResponse
         */
        public async Task<DescribeCACertificateResponse> DescribeCACertificateAsync(DescribeCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificateWithOptionsAsync(request, runtime);
        }

        /**
          * You can call the DescribeCACertificateCount operation to query the number of created CA certificates, which includes root CA certificates and intermediate CA certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCACertificateCountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCACertificateCountResponse
         */
        public DescribeCACertificateCountResponse DescribeCACertificateCountWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCACertificateCount",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateCountResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the DescribeCACertificateCount operation to query the number of created CA certificates, which includes root CA certificates and intermediate CA certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCACertificateCountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCACertificateCountResponse
         */
        public async Task<DescribeCACertificateCountResponse> DescribeCACertificateCountWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCACertificateCount",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the DescribeCACertificateCount operation to query the number of created CA certificates, which includes root CA certificates and intermediate CA certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @return DescribeCACertificateCountResponse
         */
        public DescribeCACertificateCountResponse DescribeCACertificateCount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificateCountWithOptions(runtime);
        }

        /**
          * You can call the DescribeCACertificateCount operation to query the number of created CA certificates, which includes root CA certificates and intermediate CA certificates.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @return DescribeCACertificateCountResponse
         */
        public async Task<DescribeCACertificateCountResponse> DescribeCACertificateCountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificateCountWithOptionsAsync(runtime);
        }

        /**
          * You can call the DescribeCACertificateList operation to perform a paged query of the details about all CA certificates that you create. The details include the unique identifier, serial number, user information, and content of each root CA certificate or intermediate CA certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCACertificateListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCACertificateListResponse
         */
        public DescribeCACertificateListResponse DescribeCACertificateListWithOptions(DescribeCACertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "DescribeCACertificateList",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the DescribeCACertificateList operation to perform a paged query of the details about all CA certificates that you create. The details include the unique identifier, serial number, user information, and content of each root CA certificate or intermediate CA certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCACertificateListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCACertificateListResponse
         */
        public async Task<DescribeCACertificateListResponse> DescribeCACertificateListWithOptionsAsync(DescribeCACertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "DescribeCACertificateList",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the DescribeCACertificateList operation to perform a paged query of the details about all CA certificates that you create. The details include the unique identifier, serial number, user information, and content of each root CA certificate or intermediate CA certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCACertificateListRequest
          * @return DescribeCACertificateListResponse
         */
        public DescribeCACertificateListResponse DescribeCACertificateList(DescribeCACertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificateListWithOptions(request, runtime);
        }

        /**
          * You can call the DescribeCACertificateList operation to perform a paged query of the details about all CA certificates that you create. The details include the unique identifier, serial number, user information, and content of each root CA certificate or intermediate CA certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCACertificateListRequest
          * @return DescribeCACertificateListResponse
         */
        public async Task<DescribeCACertificateListResponse> DescribeCACertificateListAsync(DescribeCACertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificateListWithOptionsAsync(request, runtime);
        }

        /**
          * ## Usage notes
          * You can call the DescribeCertificatePrivateKey operation to obtain the encrypted private key of a client certificate or a server certificate. The certificate is issued based on a system-generated certificate signing request (CSR). Before you call this operation, make sure that you have issued a client certificate or a server certificate by calling the following operation:
          * *   [CreateClientCertificate](~~330873~~)
          * *   [CreateServerCertificate](~~330877~~)
          * To ensure the security of private key transmission, the DescribeCertificatePrivateKey operation encrypts the private key by using the private key password that you specify and returns the encrypted private key. The private key password is an string that is used to encrypt the private key. After you obtain the encrypted private key of the certificate, you can use the following methods to decrypt the private key:
          * *   If the encryption algorithm of the certificate is RSA, you must run the `openssl rsa -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [OpenSSL](https://www.openssl.org/source/) or [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * *   If the encryption algorithm of the certificate is ECC, you must run the `openssl ec -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [OpenSSL](https://www.openssl.org/source/) or [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * *   If the encryption algorithm of the certificate is SM2, you must run the `openssl ec -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * >  You can call the [DescribeClientCertificate](~~329929~~) operation to query the encryption algorithm type of a client certificate or a server certificate.
          * ## Limits
          * You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCertificatePrivateKeyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCertificatePrivateKeyResponse
         */
        public DescribeCertificatePrivateKeyResponse DescribeCertificatePrivateKeyWithOptions(DescribeCertificatePrivateKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedCode))
            {
                query["EncryptedCode"] = request.EncryptedCode;
            }
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
                Action = "DescribeCertificatePrivateKey",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertificatePrivateKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Usage notes
          * You can call the DescribeCertificatePrivateKey operation to obtain the encrypted private key of a client certificate or a server certificate. The certificate is issued based on a system-generated certificate signing request (CSR). Before you call this operation, make sure that you have issued a client certificate or a server certificate by calling the following operation:
          * *   [CreateClientCertificate](~~330873~~)
          * *   [CreateServerCertificate](~~330877~~)
          * To ensure the security of private key transmission, the DescribeCertificatePrivateKey operation encrypts the private key by using the private key password that you specify and returns the encrypted private key. The private key password is an string that is used to encrypt the private key. After you obtain the encrypted private key of the certificate, you can use the following methods to decrypt the private key:
          * *   If the encryption algorithm of the certificate is RSA, you must run the `openssl rsa -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [OpenSSL](https://www.openssl.org/source/) or [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * *   If the encryption algorithm of the certificate is ECC, you must run the `openssl ec -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [OpenSSL](https://www.openssl.org/source/) or [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * *   If the encryption algorithm of the certificate is SM2, you must run the `openssl ec -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * >  You can call the [DescribeClientCertificate](~~329929~~) operation to query the encryption algorithm type of a client certificate or a server certificate.
          * ## Limits
          * You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCertificatePrivateKeyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeCertificatePrivateKeyResponse
         */
        public async Task<DescribeCertificatePrivateKeyResponse> DescribeCertificatePrivateKeyWithOptionsAsync(DescribeCertificatePrivateKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedCode))
            {
                query["EncryptedCode"] = request.EncryptedCode;
            }
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
                Action = "DescribeCertificatePrivateKey",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertificatePrivateKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Usage notes
          * You can call the DescribeCertificatePrivateKey operation to obtain the encrypted private key of a client certificate or a server certificate. The certificate is issued based on a system-generated certificate signing request (CSR). Before you call this operation, make sure that you have issued a client certificate or a server certificate by calling the following operation:
          * *   [CreateClientCertificate](~~330873~~)
          * *   [CreateServerCertificate](~~330877~~)
          * To ensure the security of private key transmission, the DescribeCertificatePrivateKey operation encrypts the private key by using the private key password that you specify and returns the encrypted private key. The private key password is an string that is used to encrypt the private key. After you obtain the encrypted private key of the certificate, you can use the following methods to decrypt the private key:
          * *   If the encryption algorithm of the certificate is RSA, you must run the `openssl rsa -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [OpenSSL](https://www.openssl.org/source/) or [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * *   If the encryption algorithm of the certificate is ECC, you must run the `openssl ec -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [OpenSSL](https://www.openssl.org/source/) or [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * *   If the encryption algorithm of the certificate is SM2, you must run the `openssl ec -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * >  You can call the [DescribeClientCertificate](~~329929~~) operation to query the encryption algorithm type of a client certificate or a server certificate.
          * ## Limits
          * You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCertificatePrivateKeyRequest
          * @return DescribeCertificatePrivateKeyResponse
         */
        public DescribeCertificatePrivateKeyResponse DescribeCertificatePrivateKey(DescribeCertificatePrivateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificatePrivateKeyWithOptions(request, runtime);
        }

        /**
          * ## Usage notes
          * You can call the DescribeCertificatePrivateKey operation to obtain the encrypted private key of a client certificate or a server certificate. The certificate is issued based on a system-generated certificate signing request (CSR). Before you call this operation, make sure that you have issued a client certificate or a server certificate by calling the following operation:
          * *   [CreateClientCertificate](~~330873~~)
          * *   [CreateServerCertificate](~~330877~~)
          * To ensure the security of private key transmission, the DescribeCertificatePrivateKey operation encrypts the private key by using the private key password that you specify and returns the encrypted private key. The private key password is an string that is used to encrypt the private key. After you obtain the encrypted private key of the certificate, you can use the following methods to decrypt the private key:
          * *   If the encryption algorithm of the certificate is RSA, you must run the `openssl rsa -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [OpenSSL](https://www.openssl.org/source/) or [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * *   If the encryption algorithm of the certificate is ECC, you must run the `openssl ec -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [OpenSSL](https://www.openssl.org/source/) or [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * *   If the encryption algorithm of the certificate is SM2, you must run the `openssl ec -in <Encrypted private key file> -passin pass:<Private key password> -out <Decrypted private key file>` command in the computer on which [BabaSSL](https://github.com/BabaSSL/BabaSSL) is installed.
          * >  You can call the [DescribeClientCertificate](~~329929~~) operation to query the encryption algorithm type of a client certificate or a server certificate.
          * ## Limits
          * You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeCertificatePrivateKeyRequest
          * @return DescribeCertificatePrivateKeyResponse
         */
        public async Task<DescribeCertificatePrivateKeyResponse> DescribeCertificatePrivateKeyAsync(DescribeCertificatePrivateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificatePrivateKeyWithOptionsAsync(request, runtime);
        }

        /**
          * You can call the DescribeClientCertificate operation to query the details about a client certificate or a server certificate by using the unique identifier of the certificate. The details include the serial number, user information, content, and status of each certificate.
          * Before you call this operation, make sure that you have created a client certificate or a server certificate.
          * For more information about how to call an operation to create a client certificate, see the following topics:
          * *   [CreateClientCertificate](~~330873~~)
          * *   [CreateClientCertificateWithCsr](~~330875~~)
          * For more information about how to call an operation to create a server certificate, see the following topics:
          * *   [CreateServerCertificate](~~330877~~)
          * *   [CreateServerCertificateWithCsr](~~330878~~)
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeClientCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeClientCertificateResponse
         */
        public DescribeClientCertificateResponse DescribeClientCertificateWithOptions(DescribeClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeClientCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the DescribeClientCertificate operation to query the details about a client certificate or a server certificate by using the unique identifier of the certificate. The details include the serial number, user information, content, and status of each certificate.
          * Before you call this operation, make sure that you have created a client certificate or a server certificate.
          * For more information about how to call an operation to create a client certificate, see the following topics:
          * *   [CreateClientCertificate](~~330873~~)
          * *   [CreateClientCertificateWithCsr](~~330875~~)
          * For more information about how to call an operation to create a server certificate, see the following topics:
          * *   [CreateServerCertificate](~~330877~~)
          * *   [CreateServerCertificateWithCsr](~~330878~~)
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeClientCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeClientCertificateResponse
         */
        public async Task<DescribeClientCertificateResponse> DescribeClientCertificateWithOptionsAsync(DescribeClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeClientCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the DescribeClientCertificate operation to query the details about a client certificate or a server certificate by using the unique identifier of the certificate. The details include the serial number, user information, content, and status of each certificate.
          * Before you call this operation, make sure that you have created a client certificate or a server certificate.
          * For more information about how to call an operation to create a client certificate, see the following topics:
          * *   [CreateClientCertificate](~~330873~~)
          * *   [CreateClientCertificateWithCsr](~~330875~~)
          * For more information about how to call an operation to create a server certificate, see the following topics:
          * *   [CreateServerCertificate](~~330877~~)
          * *   [CreateServerCertificateWithCsr](~~330878~~)
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeClientCertificateRequest
          * @return DescribeClientCertificateResponse
         */
        public DescribeClientCertificateResponse DescribeClientCertificate(DescribeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientCertificateWithOptions(request, runtime);
        }

        /**
          * You can call the DescribeClientCertificate operation to query the details about a client certificate or a server certificate by using the unique identifier of the certificate. The details include the serial number, user information, content, and status of each certificate.
          * Before you call this operation, make sure that you have created a client certificate or a server certificate.
          * For more information about how to call an operation to create a client certificate, see the following topics:
          * *   [CreateClientCertificate](~~330873~~)
          * *   [CreateClientCertificateWithCsr](~~330875~~)
          * For more information about how to call an operation to create a server certificate, see the following topics:
          * *   [CreateServerCertificate](~~330877~~)
          * *   [CreateServerCertificateWithCsr](~~330878~~)
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeClientCertificateRequest
          * @return DescribeClientCertificateResponse
         */
        public async Task<DescribeClientCertificateResponse> DescribeClientCertificateAsync(DescribeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * You can call the DescribeClientCertificateStatus operation to query the status information about multiple client certificates or server certificates at a time by using the unique identifiers of the certificates. For example, you can check whether a certificate is revoked.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeClientCertificateStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeClientCertificateStatusResponse
         */
        public DescribeClientCertificateStatusResponse DescribeClientCertificateStatusWithOptions(DescribeClientCertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeClientCertificateStatus",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the DescribeClientCertificateStatus operation to query the status information about multiple client certificates or server certificates at a time by using the unique identifiers of the certificates. For example, you can check whether a certificate is revoked.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeClientCertificateStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeClientCertificateStatusResponse
         */
        public async Task<DescribeClientCertificateStatusResponse> DescribeClientCertificateStatusWithOptionsAsync(DescribeClientCertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeClientCertificateStatus",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the DescribeClientCertificateStatus operation to query the status information about multiple client certificates or server certificates at a time by using the unique identifiers of the certificates. For example, you can check whether a certificate is revoked.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeClientCertificateStatusRequest
          * @return DescribeClientCertificateStatusResponse
         */
        public DescribeClientCertificateStatusResponse DescribeClientCertificateStatus(DescribeClientCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientCertificateStatusWithOptions(request, runtime);
        }

        /**
          * You can call the DescribeClientCertificateStatus operation to query the status information about multiple client certificates or server certificates at a time by using the unique identifiers of the certificates. For example, you can check whether a certificate is revoked.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request DescribeClientCertificateStatusRequest
          * @return DescribeClientCertificateStatusResponse
         */
        public async Task<DescribeClientCertificateStatusResponse> DescribeClientCertificateStatusAsync(DescribeClientCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientCertificateStatusWithOptionsAsync(request, runtime);
        }

        /**
          * You can call the GetCAInstanceStatus operation to query the status information about a private CA instance by using the ID of the instance. The instance is purchased by using the Certificate Management Service console. The status information includes the status of the private CA instance, the number of certificates that can be issued by using the private CA instance, and the number of issued certificates.
          * Before you call this operation, make sure that you have purchased a private CA by using the [Certificate Management Service console](https://yundun.console.aliyun.com/?p=cas#/pca/rootlist). For more information, see [Create a private CA](~~208553~~).
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetCAInstanceStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetCAInstanceStatusResponse
         */
        public GetCAInstanceStatusResponse GetCAInstanceStatusWithOptions(GetCAInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCAInstanceStatus",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCAInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the GetCAInstanceStatus operation to query the status information about a private CA instance by using the ID of the instance. The instance is purchased by using the Certificate Management Service console. The status information includes the status of the private CA instance, the number of certificates that can be issued by using the private CA instance, and the number of issued certificates.
          * Before you call this operation, make sure that you have purchased a private CA by using the [Certificate Management Service console](https://yundun.console.aliyun.com/?p=cas#/pca/rootlist). For more information, see [Create a private CA](~~208553~~).
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetCAInstanceStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetCAInstanceStatusResponse
         */
        public async Task<GetCAInstanceStatusResponse> GetCAInstanceStatusWithOptionsAsync(GetCAInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCAInstanceStatus",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCAInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the GetCAInstanceStatus operation to query the status information about a private CA instance by using the ID of the instance. The instance is purchased by using the Certificate Management Service console. The status information includes the status of the private CA instance, the number of certificates that can be issued by using the private CA instance, and the number of issued certificates.
          * Before you call this operation, make sure that you have purchased a private CA by using the [Certificate Management Service console](https://yundun.console.aliyun.com/?p=cas#/pca/rootlist). For more information, see [Create a private CA](~~208553~~).
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetCAInstanceStatusRequest
          * @return GetCAInstanceStatusResponse
         */
        public GetCAInstanceStatusResponse GetCAInstanceStatus(GetCAInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCAInstanceStatusWithOptions(request, runtime);
        }

        /**
          * You can call the GetCAInstanceStatus operation to query the status information about a private CA instance by using the ID of the instance. The instance is purchased by using the Certificate Management Service console. The status information includes the status of the private CA instance, the number of certificates that can be issued by using the private CA instance, and the number of issued certificates.
          * Before you call this operation, make sure that you have purchased a private CA by using the [Certificate Management Service console](https://yundun.console.aliyun.com/?p=cas#/pca/rootlist). For more information, see [Create a private CA](~~208553~~).
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request GetCAInstanceStatusRequest
          * @return GetCAInstanceStatusResponse
         */
        public async Task<GetCAInstanceStatusResponse> GetCAInstanceStatusAsync(GetCAInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCAInstanceStatusWithOptionsAsync(request, runtime);
        }

        /**
          * You can call the ListClientCertificate operation to perform a paged query of the details about all client certificates and server certificates that you create. The details include the unique identifier, serial number, user information, content, and status of each certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ListClientCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListClientCertificateResponse
         */
        public ListClientCertificateResponse ListClientCertificateWithOptions(ListClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "ListClientCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the ListClientCertificate operation to perform a paged query of the details about all client certificates and server certificates that you create. The details include the unique identifier, serial number, user information, content, and status of each certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ListClientCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListClientCertificateResponse
         */
        public async Task<ListClientCertificateResponse> ListClientCertificateWithOptionsAsync(ListClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "ListClientCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the ListClientCertificate operation to perform a paged query of the details about all client certificates and server certificates that you create. The details include the unique identifier, serial number, user information, content, and status of each certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ListClientCertificateRequest
          * @return ListClientCertificateResponse
         */
        public ListClientCertificateResponse ListClientCertificate(ListClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientCertificateWithOptions(request, runtime);
        }

        /**
          * You can call the ListClientCertificate operation to perform a paged query of the details about all client certificates and server certificates that you create. The details include the unique identifier, serial number, user information, content, and status of each certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ListClientCertificateRequest
          * @return ListClientCertificateResponse
         */
        public async Task<ListClientCertificateResponse> ListClientCertificateAsync(ListClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * You can call the ListRevokeCertificate operation to perform a paged query of the details about all revoked client certificates and server certificates. The details include the unique identifier, serial number, and revocation date of each certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ListRevokeCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRevokeCertificateResponse
         */
        public ListRevokeCertificateResponse ListRevokeCertificateWithOptions(ListRevokeCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "ListRevokeCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRevokeCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the ListRevokeCertificate operation to perform a paged query of the details about all revoked client certificates and server certificates. The details include the unique identifier, serial number, and revocation date of each certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ListRevokeCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRevokeCertificateResponse
         */
        public async Task<ListRevokeCertificateResponse> ListRevokeCertificateWithOptionsAsync(ListRevokeCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "ListRevokeCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRevokeCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the ListRevokeCertificate operation to perform a paged query of the details about all revoked client certificates and server certificates. The details include the unique identifier, serial number, and revocation date of each certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ListRevokeCertificateRequest
          * @return ListRevokeCertificateResponse
         */
        public ListRevokeCertificateResponse ListRevokeCertificate(ListRevokeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRevokeCertificateWithOptions(request, runtime);
        }

        /**
          * You can call the ListRevokeCertificate operation to perform a paged query of the details about all revoked client certificates and server certificates. The details include the unique identifier, serial number, and revocation date of each certificate.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request ListRevokeCertificateRequest
          * @return ListRevokeCertificateResponse
         */
        public async Task<ListRevokeCertificateResponse> ListRevokeCertificateAsync(ListRevokeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRevokeCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * After a CA certificate is created, the CA certificate is in the ISSUE state by default. You can call the UpdateCACertificateStatus operation to change the status of a CA certificate from ISSUE to REVOKE. If a CA certificate is in the ISSUE state, the CA certificate can be used to issue certificates. If a CA certificate is in the REVOKE state, the CA certificate cannot be used to issue certificates, and the certificates that are issued from the CA certificate become invalid.
          * Before you call this operation, make sure that you have created a root CA by calling the [CreateRootCACertificate](~~328093~~) operation or an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request UpdateCACertificateStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateCACertificateStatusResponse
         */
        public UpdateCACertificateStatusResponse UpdateCACertificateStatusWithOptions(UpdateCACertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
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
                Action = "UpdateCACertificateStatus",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCACertificateStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * After a CA certificate is created, the CA certificate is in the ISSUE state by default. You can call the UpdateCACertificateStatus operation to change the status of a CA certificate from ISSUE to REVOKE. If a CA certificate is in the ISSUE state, the CA certificate can be used to issue certificates. If a CA certificate is in the REVOKE state, the CA certificate cannot be used to issue certificates, and the certificates that are issued from the CA certificate become invalid.
          * Before you call this operation, make sure that you have created a root CA by calling the [CreateRootCACertificate](~~328093~~) operation or an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request UpdateCACertificateStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateCACertificateStatusResponse
         */
        public async Task<UpdateCACertificateStatusResponse> UpdateCACertificateStatusWithOptionsAsync(UpdateCACertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
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
                Action = "UpdateCACertificateStatus",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCACertificateStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * After a CA certificate is created, the CA certificate is in the ISSUE state by default. You can call the UpdateCACertificateStatus operation to change the status of a CA certificate from ISSUE to REVOKE. If a CA certificate is in the ISSUE state, the CA certificate can be used to issue certificates. If a CA certificate is in the REVOKE state, the CA certificate cannot be used to issue certificates, and the certificates that are issued from the CA certificate become invalid.
          * Before you call this operation, make sure that you have created a root CA by calling the [CreateRootCACertificate](~~328093~~) operation or an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request UpdateCACertificateStatusRequest
          * @return UpdateCACertificateStatusResponse
         */
        public UpdateCACertificateStatusResponse UpdateCACertificateStatus(UpdateCACertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCACertificateStatusWithOptions(request, runtime);
        }

        /**
          * After a CA certificate is created, the CA certificate is in the ISSUE state by default. You can call the UpdateCACertificateStatus operation to change the status of a CA certificate from ISSUE to REVOKE. If a CA certificate is in the ISSUE state, the CA certificate can be used to issue certificates. If a CA certificate is in the REVOKE state, the CA certificate cannot be used to issue certificates, and the certificates that are issued from the CA certificate become invalid.
          * Before you call this operation, make sure that you have created a root CA by calling the [CreateRootCACertificate](~~328093~~) operation or an intermediate CA certificate by calling the [CreateSubCACertificate](~~328094~~) operation.
          * ## Limits
          * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
          *
          * @param request UpdateCACertificateStatusRequest
          * @return UpdateCACertificateStatusResponse
         */
        public async Task<UpdateCACertificateStatusResponse> UpdateCACertificateStatusAsync(UpdateCACertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCACertificateStatusWithOptionsAsync(request, runtime);
        }

    }
}
