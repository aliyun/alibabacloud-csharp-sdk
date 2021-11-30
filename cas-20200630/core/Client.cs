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

        public CreateCertificateWithExtensionResponse CreateCertificateWithExtensionWithOptions(CreateCertificateWithExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AfterTime"] = request.AfterTime;
            query["AlgorithmKeySize"] = request.AlgorithmKeySize;
            query["AliasName"] = request.AliasName;
            query["AppendCrl"] = request.AppendCrl;
            query["BasicConstraintsCritical"] = request.BasicConstraintsCritical;
            query["BeforeTime"] = request.BeforeTime;
            query["CertType"] = request.CertType;
            query["CommonName"] = request.CommonName;
            query["CountryCode"] = request.CountryCode;
            query["CsrPemString"] = request.CsrPemString;
            query["Locality"] = request.Locality;
            query["Organization"] = request.Organization;
            query["OrganizationUnit"] = request.OrganizationUnit;
            query["ParentIdentifier"] = request.ParentIdentifier;
            query["Sans"] = request.Sans;
            query["State"] = request.State;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificateWithExtension",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateWithExtensionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCertificateWithExtensionResponse> CreateCertificateWithExtensionWithOptionsAsync(CreateCertificateWithExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AfterTime"] = request.AfterTime;
            query["AlgorithmKeySize"] = request.AlgorithmKeySize;
            query["AliasName"] = request.AliasName;
            query["AppendCrl"] = request.AppendCrl;
            query["BasicConstraintsCritical"] = request.BasicConstraintsCritical;
            query["BeforeTime"] = request.BeforeTime;
            query["CertType"] = request.CertType;
            query["CommonName"] = request.CommonName;
            query["CountryCode"] = request.CountryCode;
            query["CsrPemString"] = request.CsrPemString;
            query["Locality"] = request.Locality;
            query["Organization"] = request.Organization;
            query["OrganizationUnit"] = request.OrganizationUnit;
            query["ParentIdentifier"] = request.ParentIdentifier;
            query["Sans"] = request.Sans;
            query["State"] = request.State;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificateWithExtension",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCertificateWithExtensionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCertificateWithExtensionResponse CreateCertificateWithExtension(CreateCertificateWithExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertificateWithExtensionWithOptions(request, runtime);
        }

        public async Task<CreateCertificateWithExtensionResponse> CreateCertificateWithExtensionAsync(CreateCertificateWithExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertificateWithExtensionWithOptionsAsync(request, runtime);
        }

        public CreateClientCertificateResponse CreateClientCertificateWithOptions(CreateClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AfterTime"] = request.AfterTime;
            query["Algorithm"] = request.Algorithm;
            query["BeforeTime"] = request.BeforeTime;
            query["CommonName"] = request.CommonName;
            query["Days"] = request.Days;
            query["ParentIdentifier"] = request.ParentIdentifier;
            query["SanType"] = request.SanType;
            query["SanValue"] = request.SanValue;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateClientCertificateResponse> CreateClientCertificateWithOptionsAsync(CreateClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AfterTime"] = request.AfterTime;
            query["Algorithm"] = request.Algorithm;
            query["BeforeTime"] = request.BeforeTime;
            query["CommonName"] = request.CommonName;
            query["Days"] = request.Days;
            query["ParentIdentifier"] = request.ParentIdentifier;
            query["SanType"] = request.SanType;
            query["SanValue"] = request.SanValue;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateClientCertificateResponse CreateClientCertificate(CreateClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientCertificateWithOptions(request, runtime);
        }

        public async Task<CreateClientCertificateResponse> CreateClientCertificateAsync(CreateClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientCertificateWithOptionsAsync(request, runtime);
        }

        public CreateClientCertificateWithCsrResponse CreateClientCertificateWithCsrWithOptions(CreateClientCertificateWithCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AfterTime"] = request.AfterTime;
            query["BeforeTime"] = request.BeforeTime;
            query["Csr"] = request.Csr;
            query["Days"] = request.Days;
            query["ParentIdentifier"] = request.ParentIdentifier;
            query["SanType"] = request.SanType;
            query["SanValue"] = request.SanValue;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientCertificateWithCsrResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateClientCertificateWithCsrResponse> CreateClientCertificateWithCsrWithOptionsAsync(CreateClientCertificateWithCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AfterTime"] = request.AfterTime;
            query["BeforeTime"] = request.BeforeTime;
            query["Csr"] = request.Csr;
            query["Days"] = request.Days;
            query["ParentIdentifier"] = request.ParentIdentifier;
            query["SanType"] = request.SanType;
            query["SanValue"] = request.SanValue;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientCertificateWithCsrResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateClientCertificateWithCsrResponse CreateClientCertificateWithCsr(CreateClientCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientCertificateWithCsrWithOptions(request, runtime);
        }

        public async Task<CreateClientCertificateWithCsrResponse> CreateClientCertificateWithCsrAsync(CreateClientCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientCertificateWithCsrWithOptionsAsync(request, runtime);
        }

        public CreateRevokeClientCertificateResponse CreateRevokeClientCertificateWithOptions(CreateRevokeClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRevokeClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRevokeClientCertificateResponse> CreateRevokeClientCertificateWithOptionsAsync(CreateRevokeClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRevokeClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRevokeClientCertificateResponse CreateRevokeClientCertificate(CreateRevokeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRevokeClientCertificateWithOptions(request, runtime);
        }

        public async Task<CreateRevokeClientCertificateResponse> CreateRevokeClientCertificateAsync(CreateRevokeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRevokeClientCertificateWithOptionsAsync(request, runtime);
        }

        public CreateRootCACertificateResponse CreateRootCACertificateWithOptions(CreateRootCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Algorithm"] = request.Algorithm;
            query["CommonName"] = request.CommonName;
            query["CountryCode"] = request.CountryCode;
            query["Locality"] = request.Locality;
            query["Organization"] = request.Organization;
            query["OrganizationUnit"] = request.OrganizationUnit;
            query["State"] = request.State;
            query["Years"] = request.Years;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRootCACertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRootCACertificateResponse> CreateRootCACertificateWithOptionsAsync(CreateRootCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Algorithm"] = request.Algorithm;
            query["CommonName"] = request.CommonName;
            query["CountryCode"] = request.CountryCode;
            query["Locality"] = request.Locality;
            query["Organization"] = request.Organization;
            query["OrganizationUnit"] = request.OrganizationUnit;
            query["State"] = request.State;
            query["Years"] = request.Years;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRootCACertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRootCACertificateResponse CreateRootCACertificate(CreateRootCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRootCACertificateWithOptions(request, runtime);
        }

        public async Task<CreateRootCACertificateResponse> CreateRootCACertificateAsync(CreateRootCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRootCACertificateWithOptionsAsync(request, runtime);
        }

        public CreateServerCertificateResponse CreateServerCertificateWithOptions(CreateServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AfterTime"] = request.AfterTime;
            query["Algorithm"] = request.Algorithm;
            query["BeforeTime"] = request.BeforeTime;
            query["CommonName"] = request.CommonName;
            query["Days"] = request.Days;
            query["Domain"] = request.Domain;
            query["ParentIdentifier"] = request.ParentIdentifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateServerCertificateResponse> CreateServerCertificateWithOptionsAsync(CreateServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AfterTime"] = request.AfterTime;
            query["Algorithm"] = request.Algorithm;
            query["BeforeTime"] = request.BeforeTime;
            query["CommonName"] = request.CommonName;
            query["Days"] = request.Days;
            query["Domain"] = request.Domain;
            query["ParentIdentifier"] = request.ParentIdentifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateServerCertificateResponse CreateServerCertificate(CreateServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServerCertificateWithOptions(request, runtime);
        }

        public async Task<CreateServerCertificateResponse> CreateServerCertificateAsync(CreateServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServerCertificateWithOptionsAsync(request, runtime);
        }

        public CreateServerCertificateWithCsrResponse CreateServerCertificateWithCsrWithOptions(CreateServerCertificateWithCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AfterTime"] = request.AfterTime;
            query["BeforeTime"] = request.BeforeTime;
            query["Csr"] = request.Csr;
            query["Days"] = request.Days;
            query["Domain"] = request.Domain;
            query["ParentIdentifier"] = request.ParentIdentifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerCertificateWithCsrResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateServerCertificateWithCsrResponse> CreateServerCertificateWithCsrWithOptionsAsync(CreateServerCertificateWithCsrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AfterTime"] = request.AfterTime;
            query["BeforeTime"] = request.BeforeTime;
            query["Csr"] = request.Csr;
            query["Days"] = request.Days;
            query["Domain"] = request.Domain;
            query["ParentIdentifier"] = request.ParentIdentifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerCertificateWithCsrResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateServerCertificateWithCsrResponse CreateServerCertificateWithCsr(CreateServerCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServerCertificateWithCsrWithOptions(request, runtime);
        }

        public async Task<CreateServerCertificateWithCsrResponse> CreateServerCertificateWithCsrAsync(CreateServerCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServerCertificateWithCsrWithOptionsAsync(request, runtime);
        }

        public CreateSubCACertificateResponse CreateSubCACertificateWithOptions(CreateSubCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Algorithm"] = request.Algorithm;
            query["CommonName"] = request.CommonName;
            query["CountryCode"] = request.CountryCode;
            query["Locality"] = request.Locality;
            query["Organization"] = request.Organization;
            query["OrganizationUnit"] = request.OrganizationUnit;
            query["ParentIdentifier"] = request.ParentIdentifier;
            query["State"] = request.State;
            query["Years"] = request.Years;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubCACertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSubCACertificateResponse> CreateSubCACertificateWithOptionsAsync(CreateSubCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Algorithm"] = request.Algorithm;
            query["CommonName"] = request.CommonName;
            query["CountryCode"] = request.CountryCode;
            query["Locality"] = request.Locality;
            query["Organization"] = request.Organization;
            query["OrganizationUnit"] = request.OrganizationUnit;
            query["ParentIdentifier"] = request.ParentIdentifier;
            query["State"] = request.State;
            query["Years"] = request.Years;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubCACertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSubCACertificateResponse CreateSubCACertificate(CreateSubCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubCACertificateWithOptions(request, runtime);
        }

        public async Task<CreateSubCACertificateResponse> CreateSubCACertificateAsync(CreateSubCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubCACertificateWithOptionsAsync(request, runtime);
        }

        public DeleteClientCertificateResponse DeleteClientCertificateWithOptions(DeleteClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteClientCertificateResponse> DeleteClientCertificateWithOptionsAsync(DeleteClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteClientCertificateResponse DeleteClientCertificate(DeleteClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientCertificateWithOptions(request, runtime);
        }

        public async Task<DeleteClientCertificateResponse> DeleteClientCertificateAsync(DeleteClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientCertificateWithOptionsAsync(request, runtime);
        }

        public DescribeCACertificateResponse DescribeCACertificateWithOptions(DescribeCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCACertificateResponse> DescribeCACertificateWithOptionsAsync(DescribeCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCACertificateResponse DescribeCACertificate(DescribeCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificateWithOptions(request, runtime);
        }

        public async Task<DescribeCACertificateResponse> DescribeCACertificateAsync(DescribeCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificateWithOptionsAsync(request, runtime);
        }

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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateCountResponse>(CallApi(params_, req, runtime));
        }

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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCACertificateCountResponse DescribeCACertificateCount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificateCountWithOptions(runtime);
        }

        public async Task<DescribeCACertificateCountResponse> DescribeCACertificateCountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificateCountWithOptionsAsync(runtime);
        }

        public DescribeCACertificateListResponse DescribeCACertificateListWithOptions(DescribeCACertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["ShowSize"] = request.ShowSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCACertificateListResponse> DescribeCACertificateListWithOptionsAsync(DescribeCACertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["ShowSize"] = request.ShowSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCACertificateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCACertificateListResponse DescribeCACertificateList(DescribeCACertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificateListWithOptions(request, runtime);
        }

        public async Task<DescribeCACertificateListResponse> DescribeCACertificateListAsync(DescribeCACertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificateListWithOptionsAsync(request, runtime);
        }

        public DescribeCertificatePrivateKeyResponse DescribeCertificatePrivateKeyWithOptions(DescribeCertificatePrivateKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EncryptedCode"] = request.EncryptedCode;
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertificatePrivateKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCertificatePrivateKeyResponse> DescribeCertificatePrivateKeyWithOptionsAsync(DescribeCertificatePrivateKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EncryptedCode"] = request.EncryptedCode;
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertificatePrivateKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCertificatePrivateKeyResponse DescribeCertificatePrivateKey(DescribeCertificatePrivateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificatePrivateKeyWithOptions(request, runtime);
        }

        public async Task<DescribeCertificatePrivateKeyResponse> DescribeCertificatePrivateKeyAsync(DescribeCertificatePrivateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificatePrivateKeyWithOptionsAsync(request, runtime);
        }

        public DescribeClientCertificateResponse DescribeClientCertificateWithOptions(DescribeClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClientCertificateResponse> DescribeClientCertificateWithOptionsAsync(DescribeClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClientCertificateResponse DescribeClientCertificate(DescribeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientCertificateWithOptions(request, runtime);
        }

        public async Task<DescribeClientCertificateResponse> DescribeClientCertificateAsync(DescribeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientCertificateWithOptionsAsync(request, runtime);
        }

        public DescribeClientCertificateForSerialNumberResponse DescribeClientCertificateForSerialNumberWithOptions(DescribeClientCertificateForSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SerialNumber"] = request.SerialNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClientCertificateForSerialNumber",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateForSerialNumberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClientCertificateForSerialNumberResponse> DescribeClientCertificateForSerialNumberWithOptionsAsync(DescribeClientCertificateForSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SerialNumber"] = request.SerialNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClientCertificateForSerialNumber",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateForSerialNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClientCertificateForSerialNumberResponse DescribeClientCertificateForSerialNumber(DescribeClientCertificateForSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientCertificateForSerialNumberWithOptions(request, runtime);
        }

        public async Task<DescribeClientCertificateForSerialNumberResponse> DescribeClientCertificateForSerialNumberAsync(DescribeClientCertificateForSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientCertificateForSerialNumberWithOptionsAsync(request, runtime);
        }

        public DescribeClientCertificateStatusResponse DescribeClientCertificateStatusWithOptions(DescribeClientCertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClientCertificateStatusResponse> DescribeClientCertificateStatusWithOptionsAsync(DescribeClientCertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClientCertificateStatusResponse DescribeClientCertificateStatus(DescribeClientCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientCertificateStatusWithOptions(request, runtime);
        }

        public async Task<DescribeClientCertificateStatusResponse> DescribeClientCertificateStatusAsync(DescribeClientCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientCertificateStatusWithOptionsAsync(request, runtime);
        }

        public DescribeClientCertificateStatusForSerialNumberResponse DescribeClientCertificateStatusForSerialNumberWithOptions(DescribeClientCertificateStatusForSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SerialNumber"] = request.SerialNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClientCertificateStatusForSerialNumber",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateStatusForSerialNumberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClientCertificateStatusForSerialNumberResponse> DescribeClientCertificateStatusForSerialNumberWithOptionsAsync(DescribeClientCertificateStatusForSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SerialNumber"] = request.SerialNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClientCertificateStatusForSerialNumber",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateStatusForSerialNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClientCertificateStatusForSerialNumberResponse DescribeClientCertificateStatusForSerialNumber(DescribeClientCertificateStatusForSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientCertificateStatusForSerialNumberWithOptions(request, runtime);
        }

        public async Task<DescribeClientCertificateStatusForSerialNumberResponse> DescribeClientCertificateStatusForSerialNumberAsync(DescribeClientCertificateStatusForSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientCertificateStatusForSerialNumberWithOptionsAsync(request, runtime);
        }

        public GetCAInstanceStatusResponse GetCAInstanceStatusWithOptions(GetCAInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCAInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCAInstanceStatusResponse> GetCAInstanceStatusWithOptionsAsync(GetCAInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InstanceId"] = request.InstanceId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCAInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCAInstanceStatusResponse GetCAInstanceStatus(GetCAInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCAInstanceStatusWithOptions(request, runtime);
        }

        public async Task<GetCAInstanceStatusResponse> GetCAInstanceStatusAsync(GetCAInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCAInstanceStatusWithOptionsAsync(request, runtime);
        }

        public ListCACertificateLogResponse ListCACertificateLogWithOptions(ListCACertificateLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCACertificateLog",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCACertificateLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCACertificateLogResponse> ListCACertificateLogWithOptionsAsync(ListCACertificateLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCACertificateLog",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCACertificateLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCACertificateLogResponse ListCACertificateLog(ListCACertificateLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCACertificateLogWithOptions(request, runtime);
        }

        public async Task<ListCACertificateLogResponse> ListCACertificateLogAsync(ListCACertificateLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCACertificateLogWithOptionsAsync(request, runtime);
        }

        public ListClientCertificateResponse ListClientCertificateWithOptions(ListClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["ShowSize"] = request.ShowSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListClientCertificateResponse> ListClientCertificateWithOptionsAsync(ListClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["ShowSize"] = request.ShowSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListClientCertificateResponse ListClientCertificate(ListClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientCertificateWithOptions(request, runtime);
        }

        public async Task<ListClientCertificateResponse> ListClientCertificateAsync(ListClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientCertificateWithOptionsAsync(request, runtime);
        }

        public ListRevokeCertificateResponse ListRevokeCertificateWithOptions(ListRevokeCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["ShowSize"] = request.ShowSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRevokeCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRevokeCertificateResponse> ListRevokeCertificateWithOptionsAsync(ListRevokeCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurrentPage"] = request.CurrentPage;
            query["ShowSize"] = request.ShowSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRevokeCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRevokeCertificateResponse ListRevokeCertificate(ListRevokeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRevokeCertificateWithOptions(request, runtime);
        }

        public async Task<ListRevokeCertificateResponse> ListRevokeCertificateAsync(ListRevokeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRevokeCertificateWithOptionsAsync(request, runtime);
        }

        public UpdateCACertificateStatusResponse UpdateCACertificateStatusWithOptions(UpdateCACertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCACertificateStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateCACertificateStatusResponse> UpdateCACertificateStatusWithOptionsAsync(UpdateCACertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Identifier"] = request.Identifier;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCACertificateStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateCACertificateStatusResponse UpdateCACertificateStatus(UpdateCACertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCACertificateStatusWithOptions(request, runtime);
        }

        public async Task<UpdateCACertificateStatusResponse> UpdateCACertificateStatusAsync(UpdateCACertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCACertificateStatusWithOptionsAsync(request, runtime);
        }

    }
}
