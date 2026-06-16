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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns the certificate quota to a subordinate certificate authority (CA) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>QPS limit</h2>
        /// <para>This API operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, the system throttles your API calls, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignCertificateCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignCertificateCountResponse
        /// </returns>
        public AssignCertificateCountResponse AssignCertificateCountWithOptions(AssignCertificateCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertTotalCount))
            {
                query["CertTotalCount"] = request.CertTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignCertificateCount",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignCertificateCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns the certificate quota to a subordinate certificate authority (CA) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>QPS limit</h2>
        /// <para>This API operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, the system throttles your API calls, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignCertificateCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignCertificateCountResponse
        /// </returns>
        public async Task<AssignCertificateCountResponse> AssignCertificateCountWithOptionsAsync(AssignCertificateCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertTotalCount))
            {
                query["CertTotalCount"] = request.CertTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignCertificateCount",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignCertificateCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns the certificate quota to a subordinate certificate authority (CA) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>QPS limit</h2>
        /// <para>This API operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, the system throttles your API calls, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignCertificateCountRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignCertificateCountResponse
        /// </returns>
        public AssignCertificateCountResponse AssignCertificateCount(AssignCertificateCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignCertificateCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns the certificate quota to a subordinate certificate authority (CA) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>QPS limit</h2>
        /// <para>This API operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, the system throttles your API calls, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssignCertificateCountRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignCertificateCountResponse
        /// </returns>
        public async Task<AssignCertificateCountResponse> AssignCertificateCountAsync(AssignCertificateCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignCertificateCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a client certificate by using a system-generated certificate signing request (CSR). You must create a root CA certificate and a subordinate CA certificate before calling this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>. Only subordinate CA certificates can issue client certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. Calls that exceed this limit are throttled, which can impact your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientCertificateResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomIdentifier))
            {
                query["CustomIdentifier"] = request.CustomIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Years))
            {
                query["Years"] = request.Years;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a client certificate by using a system-generated certificate signing request (CSR). You must create a root CA certificate and a subordinate CA certificate before calling this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>. Only subordinate CA certificates can issue client certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. Calls that exceed this limit are throttled, which can impact your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientCertificateResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomIdentifier))
            {
                query["CustomIdentifier"] = request.CustomIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Years))
            {
                query["Years"] = request.Years;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a client certificate by using a system-generated certificate signing request (CSR). You must create a root CA certificate and a subordinate CA certificate before calling this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>. Only subordinate CA certificates can issue client certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. Calls that exceed this limit are throttled, which can impact your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientCertificateResponse
        /// </returns>
        public CreateClientCertificateResponse CreateClientCertificate(CreateClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a client certificate by using a system-generated certificate signing request (CSR). You must create a root CA certificate and a subordinate CA certificate before calling this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>. Only subordinate CA certificates can issue client certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. Calls that exceed this limit are throttled, which can impact your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientCertificateResponse
        /// </returns>
        public async Task<CreateClientCertificateResponse> CreateClientCertificateAsync(CreateClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a client certificate by using a custom certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>. Only subordinate CA certificates can issue client certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, the system throttles your API calls, which may affect your business. We recommend that you plan your calls to avoid being throttled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientCertificateWithCsrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientCertificateWithCsrResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomIdentifier))
            {
                query["CustomIdentifier"] = request.CustomIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a client certificate by using a custom certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>. Only subordinate CA certificates can issue client certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, the system throttles your API calls, which may affect your business. We recommend that you plan your calls to avoid being throttled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientCertificateWithCsrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientCertificateWithCsrResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomIdentifier))
            {
                query["CustomIdentifier"] = request.CustomIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a client certificate by using a custom certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>. Only subordinate CA certificates can issue client certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, the system throttles your API calls, which may affect your business. We recommend that you plan your calls to avoid being throttled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientCertificateWithCsrRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientCertificateWithCsrResponse
        /// </returns>
        public CreateClientCertificateWithCsrResponse CreateClientCertificateWithCsr(CreateClientCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientCertificateWithCsrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a client certificate by using a custom certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>. Only subordinate CA certificates can issue client certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, the system throttles your API calls, which may affect your business. We recommend that you plan your calls to avoid being throttled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientCertificateWithCsrRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientCertificateWithCsrResponse
        /// </returns>
        public async Task<CreateClientCertificateWithCsrResponse> CreateClientCertificateWithCsrAsync(CreateClientCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientCertificateWithCsrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a custom digital certificate with specified subject, subject alternative names (SANs), key usage, and extended key usage attributes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the certificate subject is retrieved from the Certificate Signing Request (CSR). If you specify a certificate subject, the subject from the CSR is ignored and the specified subject is used to issue the certificate.
        /// You must specify the key usage or extended key usage based on your scenario. The following examples show common scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Server-side authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: serverAuth</description></item>
        /// <item><description>Client authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: clientAuth</description></item>
        /// <item><description>mTLS mutual authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: serverAuth, clientAuth</description></item>
        /// <item><description>Email signing certificate
        /// Key usage: digitalSignature, contentCommitment
        /// Extended key usage: emailProtection
        /// Note: Compliance CAs are managed by third-party authorities and do not support this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomCertificateResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Immediately))
            {
                query["Immediately"] = request.Immediately;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentIdentifier))
            {
                query["ParentIdentifier"] = request.ParentIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Validity))
            {
                query["Validity"] = request.Validity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomIdentifier))
            {
                query["customIdentifier"] = request.CustomIdentifier;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a custom digital certificate with specified subject, subject alternative names (SANs), key usage, and extended key usage attributes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the certificate subject is retrieved from the Certificate Signing Request (CSR). If you specify a certificate subject, the subject from the CSR is ignored and the specified subject is used to issue the certificate.
        /// You must specify the key usage or extended key usage based on your scenario. The following examples show common scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Server-side authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: serverAuth</description></item>
        /// <item><description>Client authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: clientAuth</description></item>
        /// <item><description>mTLS mutual authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: serverAuth, clientAuth</description></item>
        /// <item><description>Email signing certificate
        /// Key usage: digitalSignature, contentCommitment
        /// Extended key usage: emailProtection
        /// Note: Compliance CAs are managed by third-party authorities and do not support this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomCertificateResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Immediately))
            {
                query["Immediately"] = request.Immediately;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentIdentifier))
            {
                query["ParentIdentifier"] = request.ParentIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Validity))
            {
                query["Validity"] = request.Validity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomIdentifier))
            {
                query["customIdentifier"] = request.CustomIdentifier;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a custom digital certificate with specified subject, subject alternative names (SANs), key usage, and extended key usage attributes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the certificate subject is retrieved from the Certificate Signing Request (CSR). If you specify a certificate subject, the subject from the CSR is ignored and the specified subject is used to issue the certificate.
        /// You must specify the key usage or extended key usage based on your scenario. The following examples show common scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Server-side authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: serverAuth</description></item>
        /// <item><description>Client authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: clientAuth</description></item>
        /// <item><description>mTLS mutual authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: serverAuth, clientAuth</description></item>
        /// <item><description>Email signing certificate
        /// Key usage: digitalSignature, contentCommitment
        /// Extended key usage: emailProtection
        /// Note: Compliance CAs are managed by third-party authorities and do not support this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomCertificateResponse
        /// </returns>
        public CreateCustomCertificateResponse CreateCustomCertificate(CreateCustomCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a custom digital certificate with specified subject, subject alternative names (SANs), key usage, and extended key usage attributes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the certificate subject is retrieved from the Certificate Signing Request (CSR). If you specify a certificate subject, the subject from the CSR is ignored and the specified subject is used to issue the certificate.
        /// You must specify the key usage or extended key usage based on your scenario. The following examples show common scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Server-side authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: serverAuth</description></item>
        /// <item><description>Client authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: clientAuth</description></item>
        /// <item><description>mTLS mutual authentication certificate
        /// Key usage: digitalSignature, keyEncipherment
        /// Extended key usage: serverAuth, clientAuth</description></item>
        /// <item><description>Email signing certificate
        /// Key usage: digitalSignature, contentCommitment
        /// Extended key usage: emailProtection
        /// Note: Compliance CAs are managed by third-party authorities and do not support this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomCertificateResponse
        /// </returns>
        public async Task<CreateCustomCertificateResponse> CreateCustomCertificateAsync(CreateCustomCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create and issue an external subordinate CA certificate using a CSR and API parameters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>Creates an external subordinate CA certificate from a certificate signing request (CSR) and optional API pass-through parameters.</description></item>
        /// <item><description>The required <c>InstanceId</c> parameter specifies the instance ID of the external subordinate CA.</description></item>
        /// <item><description>The <c>Csr</c> parameter must contain a valid certificate signing request.</description></item>
        /// <item><description>The <c>Validity</c> parameter specifies the certificate\&quot;s validity period and accepts values in either relative or absolute time formats.</description></item>
        /// <item><description>The <c>ApiPassthrough</c> parameter lets you override information in the CSR, such as subject information, or add certificate extensions.</description></item>
        /// <item><description>Note: For end-entity CA certificates, set the <c>pathLenConstraint</c> parameter to 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateExternalCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalCACertificateResponse
        /// </returns>
        public CreateExternalCACertificateResponse CreateExternalCACertificateWithOptions(CreateExternalCACertificateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateExternalCACertificateShrinkRequest request = new CreateExternalCACertificateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiPassthrough))
            {
                request.ApiPassthroughShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiPassthrough, "ApiPassthrough", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiPassthroughShrink))
            {
                query["ApiPassthrough"] = request.ApiPassthroughShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertMaxTime))
            {
                query["CertMaxTime"] = request.CertMaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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
                Action = "CreateExternalCACertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExternalCACertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create and issue an external subordinate CA certificate using a CSR and API parameters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>Creates an external subordinate CA certificate from a certificate signing request (CSR) and optional API pass-through parameters.</description></item>
        /// <item><description>The required <c>InstanceId</c> parameter specifies the instance ID of the external subordinate CA.</description></item>
        /// <item><description>The <c>Csr</c> parameter must contain a valid certificate signing request.</description></item>
        /// <item><description>The <c>Validity</c> parameter specifies the certificate\&quot;s validity period and accepts values in either relative or absolute time formats.</description></item>
        /// <item><description>The <c>ApiPassthrough</c> parameter lets you override information in the CSR, such as subject information, or add certificate extensions.</description></item>
        /// <item><description>Note: For end-entity CA certificates, set the <c>pathLenConstraint</c> parameter to 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateExternalCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalCACertificateResponse
        /// </returns>
        public async Task<CreateExternalCACertificateResponse> CreateExternalCACertificateWithOptionsAsync(CreateExternalCACertificateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateExternalCACertificateShrinkRequest request = new CreateExternalCACertificateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiPassthrough))
            {
                request.ApiPassthroughShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiPassthrough, "ApiPassthrough", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiPassthroughShrink))
            {
                query["ApiPassthrough"] = request.ApiPassthroughShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertMaxTime))
            {
                query["CertMaxTime"] = request.CertMaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Csr))
            {
                query["Csr"] = request.Csr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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
                Action = "CreateExternalCACertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExternalCACertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create and issue an external subordinate CA certificate using a CSR and API parameters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>Creates an external subordinate CA certificate from a certificate signing request (CSR) and optional API pass-through parameters.</description></item>
        /// <item><description>The required <c>InstanceId</c> parameter specifies the instance ID of the external subordinate CA.</description></item>
        /// <item><description>The <c>Csr</c> parameter must contain a valid certificate signing request.</description></item>
        /// <item><description>The <c>Validity</c> parameter specifies the certificate\&quot;s validity period and accepts values in either relative or absolute time formats.</description></item>
        /// <item><description>The <c>ApiPassthrough</c> parameter lets you override information in the CSR, such as subject information, or add certificate extensions.</description></item>
        /// <item><description>Note: For end-entity CA certificates, set the <c>pathLenConstraint</c> parameter to 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExternalCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalCACertificateResponse
        /// </returns>
        public CreateExternalCACertificateResponse CreateExternalCACertificate(CreateExternalCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExternalCACertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create and issue an external subordinate CA certificate using a CSR and API parameters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>Creates an external subordinate CA certificate from a certificate signing request (CSR) and optional API pass-through parameters.</description></item>
        /// <item><description>The required <c>InstanceId</c> parameter specifies the instance ID of the external subordinate CA.</description></item>
        /// <item><description>The <c>Csr</c> parameter must contain a valid certificate signing request.</description></item>
        /// <item><description>The <c>Validity</c> parameter specifies the certificate\&quot;s validity period and accepts values in either relative or absolute time formats.</description></item>
        /// <item><description>The <c>ApiPassthrough</c> parameter lets you override information in the CSR, such as subject information, or add certificate extensions.</description></item>
        /// <item><description>Note: For end-entity CA certificates, set the <c>pathLenConstraint</c> parameter to 0.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExternalCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalCACertificateResponse
        /// </returns>
        public async Task<CreateExternalCACertificateResponse> CreateExternalCACertificateAsync(CreateExternalCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExternalCACertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a client certificate or a server certificate issued by a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a client or server certificate is revoked, the client or server where the certificate is installed cannot establish HTTPS connections with other devices.
        /// After a client or server certificate is revoked, you can call <a href="https://help.aliyun.com/document_detail/465981.html">DeleteClientCertificate</a> to permanently delete the certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The limit on queries per second (QPS) for this operation is 10 per user. If you exceed this limit, API calls are throttled, which can affect your business. Plan your API calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRevokeClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRevokeClientCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a client certificate or a server certificate issued by a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a client or server certificate is revoked, the client or server where the certificate is installed cannot establish HTTPS connections with other devices.
        /// After a client or server certificate is revoked, you can call <a href="https://help.aliyun.com/document_detail/465981.html">DeleteClientCertificate</a> to permanently delete the certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The limit on queries per second (QPS) for this operation is 10 per user. If you exceed this limit, API calls are throttled, which can affect your business. Plan your API calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRevokeClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRevokeClientCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a client certificate or a server certificate issued by a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a client or server certificate is revoked, the client or server where the certificate is installed cannot establish HTTPS connections with other devices.
        /// After a client or server certificate is revoked, you can call <a href="https://help.aliyun.com/document_detail/465981.html">DeleteClientCertificate</a> to permanently delete the certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The limit on queries per second (QPS) for this operation is 10 per user. If you exceed this limit, API calls are throttled, which can affect your business. Plan your API calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRevokeClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRevokeClientCertificateResponse
        /// </returns>
        public CreateRevokeClientCertificateResponse CreateRevokeClientCertificate(CreateRevokeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRevokeClientCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a client certificate or a server certificate issued by a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a client or server certificate is revoked, the client or server where the certificate is installed cannot establish HTTPS connections with other devices.
        /// After a client or server certificate is revoked, you can call <a href="https://help.aliyun.com/document_detail/465981.html">DeleteClientCertificate</a> to permanently delete the certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The limit on queries per second (QPS) for this operation is 10 per user. If you exceed this limit, API calls are throttled, which can affect your business. Plan your API calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRevokeClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRevokeClientCertificateResponse
        /// </returns>
        public async Task<CreateRevokeClientCertificateResponse> CreateRevokeClientCertificateAsync(CreateRevokeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRevokeClientCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a root certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a self-signed root CA certificate. A root CA certificate is the starting point of a private trust chain within an enterprise. After you create a root CA certificate, you can use it to issue intermediate CA certificates. You can then use the intermediate CA certificates to issue client and server-side certificates.
        /// Before calling this operation, purchase a private root CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">SSL Certificate Service console</a>. Otherwise, the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. If you exceed the limit, API calls are throttled, which may affect your business. Call the API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRootCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRootCACertificateResponse
        /// </returns>
        public CreateRootCACertificateResponse CreateRootCACertificateWithOptions(CreateRootCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a root certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a self-signed root CA certificate. A root CA certificate is the starting point of a private trust chain within an enterprise. After you create a root CA certificate, you can use it to issue intermediate CA certificates. You can then use the intermediate CA certificates to issue client and server-side certificates.
        /// Before calling this operation, purchase a private root CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">SSL Certificate Service console</a>. Otherwise, the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. If you exceed the limit, API calls are throttled, which may affect your business. Call the API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRootCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRootCACertificateResponse
        /// </returns>
        public async Task<CreateRootCACertificateResponse> CreateRootCACertificateWithOptionsAsync(CreateRootCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a root certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a self-signed root CA certificate. A root CA certificate is the starting point of a private trust chain within an enterprise. After you create a root CA certificate, you can use it to issue intermediate CA certificates. You can then use the intermediate CA certificates to issue client and server-side certificates.
        /// Before calling this operation, purchase a private root CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">SSL Certificate Service console</a>. Otherwise, the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. If you exceed the limit, API calls are throttled, which may affect your business. Call the API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRootCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRootCACertificateResponse
        /// </returns>
        public CreateRootCACertificateResponse CreateRootCACertificate(CreateRootCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRootCACertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a root certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a self-signed root CA certificate. A root CA certificate is the starting point of a private trust chain within an enterprise. After you create a root CA certificate, you can use it to issue intermediate CA certificates. You can then use the intermediate CA certificates to issue client and server-side certificates.
        /// Before calling this operation, purchase a private root CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">SSL Certificate Service console</a>. Otherwise, the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. If you exceed the limit, API calls are throttled, which may affect your business. Call the API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRootCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRootCACertificateResponse
        /// </returns>
        public async Task<CreateRootCACertificateResponse> CreateRootCACertificateAsync(CreateRootCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRootCACertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a server certificate by using a system-generated certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> to create a root certificate authority (CA) certificate and <a href="https://help.aliyun.com/document_detail/465975.html">CreateSubCACertificate</a> to create a subordinate CA certificate. Only a subordinate CA certificate can issue a server certificate.</para>
        /// <h2>QPS limits</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed this limit, the system throttles your API calls, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServerCertificateResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomIdentifier))
            {
                query["CustomIdentifier"] = request.CustomIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a server certificate by using a system-generated certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> to create a root certificate authority (CA) certificate and <a href="https://help.aliyun.com/document_detail/465975.html">CreateSubCACertificate</a> to create a subordinate CA certificate. Only a subordinate CA certificate can issue a server certificate.</para>
        /// <h2>QPS limits</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed this limit, the system throttles your API calls, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServerCertificateResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomIdentifier))
            {
                query["CustomIdentifier"] = request.CustomIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a server certificate by using a system-generated certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> to create a root certificate authority (CA) certificate and <a href="https://help.aliyun.com/document_detail/465975.html">CreateSubCACertificate</a> to create a subordinate CA certificate. Only a subordinate CA certificate can issue a server certificate.</para>
        /// <h2>QPS limits</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed this limit, the system throttles your API calls, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServerCertificateResponse
        /// </returns>
        public CreateServerCertificateResponse CreateServerCertificate(CreateServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServerCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a server certificate by using a system-generated certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> to create a root certificate authority (CA) certificate and <a href="https://help.aliyun.com/document_detail/465975.html">CreateSubCACertificate</a> to create a subordinate CA certificate. Only a subordinate CA certificate can issue a server certificate.</para>
        /// <h2>QPS limits</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed this limit, the system throttles your API calls, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServerCertificateResponse
        /// </returns>
        public async Task<CreateServerCertificateResponse> CreateServerCertificateAsync(CreateServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServerCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a server certificate by using a custom certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> to create a root CA certificate and <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a> to create a subordinate CA certificate. Server-side certificates can be issued only by subordinate CA certificates.</para>
        /// <h2>Limits</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 requests per user. If you exceed this limit, rate limiting is triggered, which may affect your business. Call this operation only as needed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerCertificateWithCsrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServerCertificateWithCsrResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomIdentifier))
            {
                query["CustomIdentifier"] = request.CustomIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a server certificate by using a custom certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> to create a root CA certificate and <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a> to create a subordinate CA certificate. Server-side certificates can be issued only by subordinate CA certificates.</para>
        /// <h2>Limits</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 requests per user. If you exceed this limit, rate limiting is triggered, which may affect your business. Call this operation only as needed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerCertificateWithCsrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServerCertificateWithCsrResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomIdentifier))
            {
                query["CustomIdentifier"] = request.CustomIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a server certificate by using a custom certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> to create a root CA certificate and <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a> to create a subordinate CA certificate. Server-side certificates can be issued only by subordinate CA certificates.</para>
        /// <h2>Limits</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 requests per user. If you exceed this limit, rate limiting is triggered, which may affect your business. Call this operation only as needed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerCertificateWithCsrRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServerCertificateWithCsrResponse
        /// </returns>
        public CreateServerCertificateWithCsrResponse CreateServerCertificateWithCsr(CreateServerCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServerCertificateWithCsrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Issues a server certificate by using a custom certificate signing request (CSR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> to create a root CA certificate and <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a> to create a subordinate CA certificate. Server-side certificates can be issued only by subordinate CA certificates.</para>
        /// <h2>Limits</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 requests per user. If you exceed this limit, rate limiting is triggered, which may affect your business. Call this operation only as needed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServerCertificateWithCsrRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServerCertificateWithCsrResponse
        /// </returns>
        public async Task<CreateServerCertificateWithCsrResponse> CreateServerCertificateWithCsrAsync(CreateServerCertificateWithCsrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServerCertificateWithCsrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subordinate certificate authority (CA) certificate under an existing root CA.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation issues an intermediate CA certificate from an existing root CA certificate. You can use the intermediate CA certificate to issue client and server certificates.
        /// Before calling this operation, you must call the <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> operation to create a root CA certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per user. Calls that exceed this limit are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSubCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSubCACertificateResponse
        /// </returns>
        public CreateSubCACertificateResponse CreateSubCACertificateWithOptions(CreateSubCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertMaxTime))
            {
                query["CertMaxTime"] = request.CertMaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonName))
            {
                query["CommonName"] = request.CommonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrlDay))
            {
                query["CrlDay"] = request.CrlDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Years))
            {
                query["Years"] = request.Years;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subordinate certificate authority (CA) certificate under an existing root CA.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation issues an intermediate CA certificate from an existing root CA certificate. You can use the intermediate CA certificate to issue client and server certificates.
        /// Before calling this operation, you must call the <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> operation to create a root CA certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per user. Calls that exceed this limit are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSubCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSubCACertificateResponse
        /// </returns>
        public async Task<CreateSubCACertificateResponse> CreateSubCACertificateWithOptionsAsync(CreateSubCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertMaxTime))
            {
                query["CertMaxTime"] = request.CertMaxTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonName))
            {
                query["CommonName"] = request.CommonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryCode))
            {
                query["CountryCode"] = request.CountryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrlDay))
            {
                query["CrlDay"] = request.CrlDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrl))
            {
                query["EnableCrl"] = request.EnableCrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Years))
            {
                query["Years"] = request.Years;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subordinate certificate authority (CA) certificate under an existing root CA.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation issues an intermediate CA certificate from an existing root CA certificate. You can use the intermediate CA certificate to issue client and server certificates.
        /// Before calling this operation, you must call the <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> operation to create a root CA certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per user. Calls that exceed this limit are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSubCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSubCACertificateResponse
        /// </returns>
        public CreateSubCACertificateResponse CreateSubCACertificate(CreateSubCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubCACertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a subordinate certificate authority (CA) certificate under an existing root CA.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation issues an intermediate CA certificate from an existing root CA certificate. You can use the intermediate CA certificate to issue client and server certificates.
        /// Before calling this operation, you must call the <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> operation to create a root CA certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per user. Calls that exceed this limit are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSubCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSubCACertificateResponse
        /// </returns>
        public async Task<CreateSubCACertificateResponse> CreateSubCACertificateAsync(CreateSubCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubCACertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a revoked client certificate or server certificate. Only revoked certificates can be deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465972.html">CreateRevokeClientCertificate</a> to revoke the client or server-side certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation supports up to 10 queries per second (QPS) for each user. If you exceed the limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a revoked client certificate or server certificate. Only revoked certificates can be deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465972.html">CreateRevokeClientCertificate</a> to revoke the client or server-side certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation supports up to 10 queries per second (QPS) for each user. If you exceed the limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a revoked client certificate or server certificate. Only revoked certificates can be deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465972.html">CreateRevokeClientCertificate</a> to revoke the client or server-side certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation supports up to 10 queries per second (QPS) for each user. If you exceed the limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientCertificateResponse
        /// </returns>
        public DeleteClientCertificateResponse DeleteClientCertificate(DeleteClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a revoked client certificate or server certificate. Only revoked certificates can be deleted.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must call <a href="https://help.aliyun.com/document_detail/465972.html">CreateRevokeClientCertificate</a> to revoke the client or server-side certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation supports up to 10 queries per second (QPS) for each user. If you exceed the limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientCertificateResponse
        /// </returns>
        public async Task<DeleteClientCertificateResponse> DeleteClientCertificateAsync(DeleteClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of a root or subordinate CA certificate by its unique identifier. The details include the serial number, subject information, and certificate content.
        /// Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed the limit, API calls are throttled, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of a root or subordinate CA certificate by its unique identifier. The details include the serial number, subject information, and certificate content.
        /// Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed the limit, API calls are throttled, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of a root or subordinate CA certificate by its unique identifier. The details include the serial number, subject information, and certificate content.
        /// Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed the limit, API calls are throttled, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificateResponse
        /// </returns>
        public DescribeCACertificateResponse DescribeCACertificate(DescribeCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a certificate authority (CA) certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of a root or subordinate CA certificate by its unique identifier. The details include the serial number, subject information, and certificate content.
        /// Before you call this operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed the limit, API calls are throttled, which can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificateResponse
        /// </returns>
        public async Task<DescribeCACertificateResponse> DescribeCACertificateAsync(DescribeCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of certificate authority (CA) certificates that you created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the number of CA certificates that you have created, including root CA certificates and subordinate CA certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>Each user is limited to 10 queries per second (QPS) for this API operation. If you exceed the limit, your API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificateCountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of certificate authority (CA) certificates that you created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the number of CA certificates that you have created, including root CA certificates and subordinate CA certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>Each user is limited to 10 queries per second (QPS) for this API operation. If you exceed the limit, your API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificateCountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of certificate authority (CA) certificates that you created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the number of CA certificates that you have created, including root CA certificates and subordinate CA certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>Each user is limited to 10 queries per second (QPS) for this API operation. If you exceed the limit, your API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeCACertificateCountResponse
        /// </returns>
        public DescribeCACertificateCountResponse DescribeCACertificateCount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificateCountWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of certificate authority (CA) certificates that you created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the number of CA certificates that you have created, including root CA certificates and subordinate CA certificates.</para>
        /// <h2>QPS limit</h2>
        /// <para>Each user is limited to 10 queries per second (QPS) for this API operation. If you exceed the limit, your API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeCACertificateCountResponse
        /// </returns>
        public async Task<DescribeCACertificateCountResponse> DescribeCACertificateCountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificateCountWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all root and subordinate certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of all your root and intermediate CA certificates by page. The details include the unique identifier, serial number, subject information, and content of each certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 for each user. If you exceed the limit, API calls are throttled. This may affect your business. We recommend that you call this operation a reasonable number of times.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificateListResponse
        /// </returns>
        public DescribeCACertificateListResponse DescribeCACertificateListWithOptions(DescribeCACertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaStatus))
            {
                query["CaStatus"] = request.CaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuerType))
            {
                query["IssuerType"] = request.IssuerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidStatus))
            {
                query["ValidStatus"] = request.ValidStatus;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all root and subordinate certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of all your root and intermediate CA certificates by page. The details include the unique identifier, serial number, subject information, and content of each certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 for each user. If you exceed the limit, API calls are throttled. This may affect your business. We recommend that you call this operation a reasonable number of times.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificateListResponse
        /// </returns>
        public async Task<DescribeCACertificateListResponse> DescribeCACertificateListWithOptionsAsync(DescribeCACertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaStatus))
            {
                query["CaStatus"] = request.CaStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertType))
            {
                query["CertType"] = request.CertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuerType))
            {
                query["IssuerType"] = request.IssuerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidStatus))
            {
                query["ValidStatus"] = request.ValidStatus;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all root and subordinate certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of all your root and intermediate CA certificates by page. The details include the unique identifier, serial number, subject information, and content of each certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 for each user. If you exceed the limit, API calls are throttled. This may affect your business. We recommend that you call this operation a reasonable number of times.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificateListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificateListResponse
        /// </returns>
        public DescribeCACertificateListResponse DescribeCACertificateList(DescribeCACertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificateListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all root and subordinate certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of all your root and intermediate CA certificates by page. The details include the unique identifier, serial number, subject information, and content of each certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 for each user. If you exceed the limit, API calls are throttled. This may affect your business. We recommend that you call this operation a reasonable number of times.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCACertificateListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCACertificateListResponse
        /// </returns>
        public async Task<DescribeCACertificateListResponse> DescribeCACertificateListAsync(DescribeCACertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificateListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the encrypted private key of a client certificate or server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API applies only to certificates that are issued from a system-generated Certificate Signing Request (CSR). You can use this API to retrieve the encrypted private key of a client certificate or a server-side certificate. Before you call this API, you must have issued a client or server-side certificate by calling one of the following APIs:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/465967.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465975.html">CreateServerCertificate</a>
        /// To keep the private key secure during transmission, this API uses a password that you set to encrypt the private key. The API then returns the encrypted private key. After you retrieve the encrypted private key, you can decrypt it using one of the following methods:</description></item>
        /// <item><description>If the certificate uses the RSA encryption algorithm, run the <c>openssl rsa -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://www.openssl.org/source/">OpenSSL</a> or <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.</description></item>
        /// <item><description>If the certificate uses the ECC encryption algorithm, run the <c>openssl ec -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://www.openssl.org/source/">OpenSSL</a> or <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.</description></item>
        /// <item><description>If the certificate uses the SM2 encryption algorithm, run the <c>openssl ec -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.<remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/465985.html">DescribeClientCertificate</a> to query the encryption algorithm of the client or server-side certificate.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <h2>QPS limit</h2>
        /// <para>This API has a queries per second (QPS) limit of 10 for each user. If you exceed this limit, your API calls are throttled. Throttling can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCertificatePrivateKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCertificatePrivateKeyResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the encrypted private key of a client certificate or server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API applies only to certificates that are issued from a system-generated Certificate Signing Request (CSR). You can use this API to retrieve the encrypted private key of a client certificate or a server-side certificate. Before you call this API, you must have issued a client or server-side certificate by calling one of the following APIs:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/465967.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465975.html">CreateServerCertificate</a>
        /// To keep the private key secure during transmission, this API uses a password that you set to encrypt the private key. The API then returns the encrypted private key. After you retrieve the encrypted private key, you can decrypt it using one of the following methods:</description></item>
        /// <item><description>If the certificate uses the RSA encryption algorithm, run the <c>openssl rsa -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://www.openssl.org/source/">OpenSSL</a> or <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.</description></item>
        /// <item><description>If the certificate uses the ECC encryption algorithm, run the <c>openssl ec -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://www.openssl.org/source/">OpenSSL</a> or <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.</description></item>
        /// <item><description>If the certificate uses the SM2 encryption algorithm, run the <c>openssl ec -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.<remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/465985.html">DescribeClientCertificate</a> to query the encryption algorithm of the client or server-side certificate.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <h2>QPS limit</h2>
        /// <para>This API has a queries per second (QPS) limit of 10 for each user. If you exceed this limit, your API calls are throttled. Throttling can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCertificatePrivateKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCertificatePrivateKeyResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the encrypted private key of a client certificate or server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API applies only to certificates that are issued from a system-generated Certificate Signing Request (CSR). You can use this API to retrieve the encrypted private key of a client certificate or a server-side certificate. Before you call this API, you must have issued a client or server-side certificate by calling one of the following APIs:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/465967.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465975.html">CreateServerCertificate</a>
        /// To keep the private key secure during transmission, this API uses a password that you set to encrypt the private key. The API then returns the encrypted private key. After you retrieve the encrypted private key, you can decrypt it using one of the following methods:</description></item>
        /// <item><description>If the certificate uses the RSA encryption algorithm, run the <c>openssl rsa -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://www.openssl.org/source/">OpenSSL</a> or <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.</description></item>
        /// <item><description>If the certificate uses the ECC encryption algorithm, run the <c>openssl ec -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://www.openssl.org/source/">OpenSSL</a> or <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.</description></item>
        /// <item><description>If the certificate uses the SM2 encryption algorithm, run the <c>openssl ec -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.<remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/465985.html">DescribeClientCertificate</a> to query the encryption algorithm of the client or server-side certificate.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <h2>QPS limit</h2>
        /// <para>This API has a queries per second (QPS) limit of 10 for each user. If you exceed this limit, your API calls are throttled. Throttling can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCertificatePrivateKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCertificatePrivateKeyResponse
        /// </returns>
        public DescribeCertificatePrivateKeyResponse DescribeCertificatePrivateKey(DescribeCertificatePrivateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificatePrivateKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the encrypted private key of a client certificate or server certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API applies only to certificates that are issued from a system-generated Certificate Signing Request (CSR). You can use this API to retrieve the encrypted private key of a client certificate or a server-side certificate. Before you call this API, you must have issued a client or server-side certificate by calling one of the following APIs:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/465967.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465975.html">CreateServerCertificate</a>
        /// To keep the private key secure during transmission, this API uses a password that you set to encrypt the private key. The API then returns the encrypted private key. After you retrieve the encrypted private key, you can decrypt it using one of the following methods:</description></item>
        /// <item><description>If the certificate uses the RSA encryption algorithm, run the <c>openssl rsa -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://www.openssl.org/source/">OpenSSL</a> or <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.</description></item>
        /// <item><description>If the certificate uses the ECC encryption algorithm, run the <c>openssl ec -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://www.openssl.org/source/">OpenSSL</a> or <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.</description></item>
        /// <item><description>If the certificate uses the SM2 encryption algorithm, run the <c>openssl ec -in &lt;encrypted_private_key_file&gt; -passin pass:&lt;private_key_password&gt; -out &lt;decrypted_private_key_file&gt;</c> command to decrypt the private key. You must run this command on a computer that has <a href="https://github.com/BabaSSL/BabaSSL">BabaSSL</a> installed.<remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/465985.html">DescribeClientCertificate</a> to query the encryption algorithm of the client or server-side certificate.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <h2>QPS limit</h2>
        /// <para>This API has a queries per second (QPS) limit of 10 for each user. If you exceed this limit, your API calls are throttled. Throttling can affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCertificatePrivateKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCertificatePrivateKeyResponse
        /// </returns>
        public async Task<DescribeCertificatePrivateKeyResponse> DescribeCertificatePrivateKeyAsync(DescribeCertificatePrivateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificatePrivateKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a client certificate or server certificate by its unique identifier.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of a client certificate or a server-side certificate by its unique identifier. The details include the serial number, subject, content, and status of the certificate.
        /// Before you call this operation, you must create a client certificate or a server-side certificate.
        /// To create a client certificate by calling an API, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/465967.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465970.html">CreateClientCertificateWithCsr</a>
        /// To create a server-side certificate by calling an API, see the following topics:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465975.html">CreateServerCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465979.html">CreateServerCertificateWithCsr</a></description></item>
        /// </list>
        /// <h2>Limits</h2>
        /// <para>The queries per second (QPS) limit for this API call is 10 per user. If you exceed this limit, throttling is triggered, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a client certificate or server certificate by its unique identifier.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of a client certificate or a server-side certificate by its unique identifier. The details include the serial number, subject, content, and status of the certificate.
        /// Before you call this operation, you must create a client certificate or a server-side certificate.
        /// To create a client certificate by calling an API, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/465967.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465970.html">CreateClientCertificateWithCsr</a>
        /// To create a server-side certificate by calling an API, see the following topics:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465975.html">CreateServerCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465979.html">CreateServerCertificateWithCsr</a></description></item>
        /// </list>
        /// <h2>Limits</h2>
        /// <para>The queries per second (QPS) limit for this API call is 10 per user. If you exceed this limit, throttling is triggered, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a client certificate or server certificate by its unique identifier.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of a client certificate or a server-side certificate by its unique identifier. The details include the serial number, subject, content, and status of the certificate.
        /// Before you call this operation, you must create a client certificate or a server-side certificate.
        /// To create a client certificate by calling an API, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/465967.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465970.html">CreateClientCertificateWithCsr</a>
        /// To create a server-side certificate by calling an API, see the following topics:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465975.html">CreateServerCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465979.html">CreateServerCertificateWithCsr</a></description></item>
        /// </list>
        /// <h2>Limits</h2>
        /// <para>The queries per second (QPS) limit for this API call is 10 per user. If you exceed this limit, throttling is triggered, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateResponse
        /// </returns>
        public DescribeClientCertificateResponse DescribeClientCertificate(DescribeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a client certificate or server certificate by its unique identifier.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of a client certificate or a server-side certificate by its unique identifier. The details include the serial number, subject, content, and status of the certificate.
        /// Before you call this operation, you must create a client certificate or a server-side certificate.
        /// To create a client certificate by calling an API, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/465967.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465970.html">CreateClientCertificateWithCsr</a>
        /// To create a server-side certificate by calling an API, see the following topics:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465975.html">CreateServerCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/465979.html">CreateServerCertificateWithCsr</a></description></item>
        /// </list>
        /// <h2>Limits</h2>
        /// <para>The queries per second (QPS) limit for this API call is 10 per user. If you exceed this limit, throttling is triggered, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateResponse
        /// </returns>
        public async Task<DescribeClientCertificateResponse> DescribeClientCertificateAsync(DescribeClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeClientCertificateForSerialNumber is deprecated, please use cas::2020-06-30::DescribeClientCertificate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of multiple client or server certificates by serial number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Usage</h1>
        /// <para>Retrieves the details of multiple client or server certificates by serial number. The response includes each certificate\&quot;s serial number, subject information, content, and status.
        /// Before calling this operation, ensure you have created a client certificate or a server certificate.
        /// To create a client certificate, see:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/330873.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330875.html">CreateClientCertificateWithCsr</a>
        /// To create a server certificate, see:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330877.html">CreateServerCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330878.html">CreateServerCertificateWithCsr</a></description></item>
        /// </list>
        /// <h1>QPS limit</h1>
        /// <para>The QPS limit for this operation is 10 calls per second per account. Exceeding this limit triggers throttling, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateForSerialNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateForSerialNumberResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeClientCertificateForSerialNumber is deprecated, please use cas::2020-06-30::DescribeClientCertificate instead.")]
        // Deprecated
        public DescribeClientCertificateForSerialNumberResponse DescribeClientCertificateForSerialNumberWithOptions(DescribeClientCertificateForSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["SerialNumber"] = request.SerialNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateForSerialNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeClientCertificateForSerialNumber is deprecated, please use cas::2020-06-30::DescribeClientCertificate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of multiple client or server certificates by serial number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Usage</h1>
        /// <para>Retrieves the details of multiple client or server certificates by serial number. The response includes each certificate\&quot;s serial number, subject information, content, and status.
        /// Before calling this operation, ensure you have created a client certificate or a server certificate.
        /// To create a client certificate, see:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/330873.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330875.html">CreateClientCertificateWithCsr</a>
        /// To create a server certificate, see:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330877.html">CreateServerCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330878.html">CreateServerCertificateWithCsr</a></description></item>
        /// </list>
        /// <h1>QPS limit</h1>
        /// <para>The QPS limit for this operation is 10 calls per second per account. Exceeding this limit triggers throttling, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateForSerialNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateForSerialNumberResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeClientCertificateForSerialNumber is deprecated, please use cas::2020-06-30::DescribeClientCertificate instead.")]
        // Deprecated
        public async Task<DescribeClientCertificateForSerialNumberResponse> DescribeClientCertificateForSerialNumberWithOptionsAsync(DescribeClientCertificateForSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["SerialNumber"] = request.SerialNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateForSerialNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeClientCertificateForSerialNumber is deprecated, please use cas::2020-06-30::DescribeClientCertificate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of multiple client or server certificates by serial number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Usage</h1>
        /// <para>Retrieves the details of multiple client or server certificates by serial number. The response includes each certificate\&quot;s serial number, subject information, content, and status.
        /// Before calling this operation, ensure you have created a client certificate or a server certificate.
        /// To create a client certificate, see:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/330873.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330875.html">CreateClientCertificateWithCsr</a>
        /// To create a server certificate, see:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330877.html">CreateServerCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330878.html">CreateServerCertificateWithCsr</a></description></item>
        /// </list>
        /// <h1>QPS limit</h1>
        /// <para>The QPS limit for this operation is 10 calls per second per account. Exceeding this limit triggers throttling, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateForSerialNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateForSerialNumberResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeClientCertificateForSerialNumber is deprecated, please use cas::2020-06-30::DescribeClientCertificate instead.")]
        // Deprecated
        public DescribeClientCertificateForSerialNumberResponse DescribeClientCertificateForSerialNumber(DescribeClientCertificateForSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientCertificateForSerialNumberWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DescribeClientCertificateForSerialNumber is deprecated, please use cas::2020-06-30::DescribeClientCertificate instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of multiple client or server certificates by serial number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Usage</h1>
        /// <para>Retrieves the details of multiple client or server certificates by serial number. The response includes each certificate\&quot;s serial number, subject information, content, and status.
        /// Before calling this operation, ensure you have created a client certificate or a server certificate.
        /// To create a client certificate, see:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/330873.html">CreateClientCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330875.html">CreateClientCertificateWithCsr</a>
        /// To create a server certificate, see:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330877.html">CreateServerCertificate</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/330878.html">CreateServerCertificateWithCsr</a></description></item>
        /// </list>
        /// <h1>QPS limit</h1>
        /// <para>The QPS limit for this operation is 10 calls per second per account. Exceeding this limit triggers throttling, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateForSerialNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateForSerialNumberResponse
        /// </returns>
        [Obsolete("OpenAPI DescribeClientCertificateForSerialNumber is deprecated, please use cas::2020-06-30::DescribeClientCertificate instead.")]
        // Deprecated
        public async Task<DescribeClientCertificateForSerialNumberResponse> DescribeClientCertificateForSerialNumberAsync(DescribeClientCertificateForSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientCertificateForSerialNumberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a client certificate or server certificate by its unique identifier.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of multiple client or server-side certificates in a batch using their unique identifiers. For example, you can check whether a certificate is revoked.</para>
        /// <h2>QPS limits</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. API calls that exceed this limit are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a client certificate or server certificate by its unique identifier.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of multiple client or server-side certificates in a batch using their unique identifiers. For example, you can check whether a certificate is revoked.</para>
        /// <h2>QPS limits</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. API calls that exceed this limit are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a client certificate or server certificate by its unique identifier.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of multiple client or server-side certificates in a batch using their unique identifiers. For example, you can check whether a certificate is revoked.</para>
        /// <h2>QPS limits</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. API calls that exceed this limit are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateStatusResponse
        /// </returns>
        public DescribeClientCertificateStatusResponse DescribeClientCertificateStatus(DescribeClientCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientCertificateStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a client certificate or server certificate by its unique identifier.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of multiple client or server-side certificates in a batch using their unique identifiers. For example, you can check whether a certificate is revoked.</para>
        /// <h2>QPS limits</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. API calls that exceed this limit are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateStatusResponse
        /// </returns>
        public async Task<DescribeClientCertificateStatusResponse> DescribeClientCertificateStatusAsync(DescribeClientCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientCertificateStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of client and server-side certificates using their serial numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of one or more client or server certificates by their serial numbers. For example, you can check whether a certificate is revoked.</para>
        /// <h2>QPS limit</h2>
        /// <para>You can make up to 10 API calls per second per account. Exceeding this limit triggers throttling, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateStatusForSerialNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateStatusForSerialNumberResponse
        /// </returns>
        public DescribeClientCertificateStatusForSerialNumberResponse DescribeClientCertificateStatusForSerialNumberWithOptions(DescribeClientCertificateStatusForSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["SerialNumber"] = request.SerialNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateStatusForSerialNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of client and server-side certificates using their serial numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of one or more client or server certificates by their serial numbers. For example, you can check whether a certificate is revoked.</para>
        /// <h2>QPS limit</h2>
        /// <para>You can make up to 10 API calls per second per account. Exceeding this limit triggers throttling, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateStatusForSerialNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateStatusForSerialNumberResponse
        /// </returns>
        public async Task<DescribeClientCertificateStatusForSerialNumberResponse> DescribeClientCertificateStatusForSerialNumberWithOptionsAsync(DescribeClientCertificateStatusForSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["SerialNumber"] = request.SerialNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientCertificateStatusForSerialNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of client and server-side certificates using their serial numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of one or more client or server certificates by their serial numbers. For example, you can check whether a certificate is revoked.</para>
        /// <h2>QPS limit</h2>
        /// <para>You can make up to 10 API calls per second per account. Exceeding this limit triggers throttling, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateStatusForSerialNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateStatusForSerialNumberResponse
        /// </returns>
        public DescribeClientCertificateStatusForSerialNumberResponse DescribeClientCertificateStatusForSerialNumber(DescribeClientCertificateStatusForSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientCertificateStatusForSerialNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of client and server-side certificates using their serial numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of one or more client or server certificates by their serial numbers. For example, you can check whether a certificate is revoked.</para>
        /// <h2>QPS limit</h2>
        /// <para>You can make up to 10 API calls per second per account. Exceeding this limit triggers throttling, which can impact your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientCertificateStatusForSerialNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientCertificateStatusForSerialNumberResponse
        /// </returns>
        public async Task<DescribeClientCertificateStatusForSerialNumberResponse> DescribeClientCertificateStatusForSerialNumberAsync(DescribeClientCertificateStatusForSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientCertificateStatusForSerialNumberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns all your certification authority (CA) certificates. These include certificates generated by Private CA and imported external certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation performs a paged query to retrieve the details of all your CA certificates, including root and subordinate CA certificates. These details include the unique identifier, serial number, subject information, and certificate content.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for a single user is 10. The system throttles API calls that exceed this limit, which may affect your business. To prevent throttling, call this operation within the stated limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePcaAndExternalCACertificateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePcaAndExternalCACertificateListResponse
        /// </returns>
        public DescribePcaAndExternalCACertificateListResponse DescribePcaAndExternalCACertificateListWithOptions(DescribePcaAndExternalCACertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifiers))
            {
                query["Identifiers"] = request.Identifiers;
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
                Action = "DescribePcaAndExternalCACertificateList",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePcaAndExternalCACertificateListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns all your certification authority (CA) certificates. These include certificates generated by Private CA and imported external certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation performs a paged query to retrieve the details of all your CA certificates, including root and subordinate CA certificates. These details include the unique identifier, serial number, subject information, and certificate content.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for a single user is 10. The system throttles API calls that exceed this limit, which may affect your business. To prevent throttling, call this operation within the stated limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePcaAndExternalCACertificateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePcaAndExternalCACertificateListResponse
        /// </returns>
        public async Task<DescribePcaAndExternalCACertificateListResponse> DescribePcaAndExternalCACertificateListWithOptionsAsync(DescribePcaAndExternalCACertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifiers))
            {
                query["Identifiers"] = request.Identifiers;
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
                Action = "DescribePcaAndExternalCACertificateList",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePcaAndExternalCACertificateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns all your certification authority (CA) certificates. These include certificates generated by Private CA and imported external certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation performs a paged query to retrieve the details of all your CA certificates, including root and subordinate CA certificates. These details include the unique identifier, serial number, subject information, and certificate content.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for a single user is 10. The system throttles API calls that exceed this limit, which may affect your business. To prevent throttling, call this operation within the stated limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePcaAndExternalCACertificateListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePcaAndExternalCACertificateListResponse
        /// </returns>
        public DescribePcaAndExternalCACertificateListResponse DescribePcaAndExternalCACertificateList(DescribePcaAndExternalCACertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePcaAndExternalCACertificateListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns all your certification authority (CA) certificates. These include certificates generated by Private CA and imported external certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation performs a paged query to retrieve the details of all your CA certificates, including root and subordinate CA certificates. These details include the unique identifier, serial number, subject information, and certificate content.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for a single user is 10. The system throttles API calls that exceed this limit, which may affect your business. To prevent throttling, call this operation within the stated limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePcaAndExternalCACertificateListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePcaAndExternalCACertificateListResponse
        /// </returns>
        public async Task<DescribePcaAndExternalCACertificateListResponse> DescribePcaAndExternalCACertificateListAsync(DescribePcaAndExternalCACertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePcaAndExternalCACertificateListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a private certificate authority (CA) instance, including the remaining certificate quota.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to query the status of a private CA instance by its ID. The status information includes the instance\&quot;s status, the total number of certificates it can issue, and the number of certificates already issued.
        /// Before you call this operation, purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 for each user. If you exceed this limit, API calls are throttled, which can affect your business. Call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCAInstanceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCAInstanceStatusResponse
        /// </returns>
        public GetCAInstanceStatusResponse GetCAInstanceStatusWithOptions(GetCAInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a private certificate authority (CA) instance, including the remaining certificate quota.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to query the status of a private CA instance by its ID. The status information includes the instance\&quot;s status, the total number of certificates it can issue, and the number of certificates already issued.
        /// Before you call this operation, purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 for each user. If you exceed this limit, API calls are throttled, which can affect your business. Call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCAInstanceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCAInstanceStatusResponse
        /// </returns>
        public async Task<GetCAInstanceStatusResponse> GetCAInstanceStatusWithOptionsAsync(GetCAInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a private certificate authority (CA) instance, including the remaining certificate quota.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to query the status of a private CA instance by its ID. The status information includes the instance\&quot;s status, the total number of certificates it can issue, and the number of certificates already issued.
        /// Before you call this operation, purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 for each user. If you exceed this limit, API calls are throttled, which can affect your business. Call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCAInstanceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCAInstanceStatusResponse
        /// </returns>
        public GetCAInstanceStatusResponse GetCAInstanceStatus(GetCAInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCAInstanceStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a private certificate authority (CA) instance, including the remaining certificate quota.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to query the status of a private CA instance by its ID. The status information includes the instance\&quot;s status, the total number of certificates it can issue, and the number of certificates already issued.
        /// Before you call this operation, purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 for each user. If you exceed this limit, API calls are throttled, which can affect your business. Call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCAInstanceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCAInstanceStatusResponse
        /// </returns>
        public async Task<GetCAInstanceStatusResponse> GetCAInstanceStatusAsync(GetCAInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCAInstanceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the CRL URL of a CA</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to query the status information of a private CA instance that you purchased through the SSL Certificates Service console by using the ID of the private CA instance. For example, the status of the CA instance, the number of certificates contained, the number of issued certificates, and so on.
        /// Before calling this API, you must have purchased a private CA through the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">Certificate Management Service console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS Limit</h2>
        /// <para>The per-user QPS limit for this API is 10 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API appropriately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCaInstanceCrlAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCaInstanceCrlAddressResponse
        /// </returns>
        public GetCaInstanceCrlAddressResponse GetCaInstanceCrlAddressWithOptions(GetCaInstanceCrlAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaIdentifier))
            {
                query["CaIdentifier"] = request.CaIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCaInstanceCrlAddress",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCaInstanceCrlAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the CRL URL of a CA</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to query the status information of a private CA instance that you purchased through the SSL Certificates Service console by using the ID of the private CA instance. For example, the status of the CA instance, the number of certificates contained, the number of issued certificates, and so on.
        /// Before calling this API, you must have purchased a private CA through the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">Certificate Management Service console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS Limit</h2>
        /// <para>The per-user QPS limit for this API is 10 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API appropriately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCaInstanceCrlAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCaInstanceCrlAddressResponse
        /// </returns>
        public async Task<GetCaInstanceCrlAddressResponse> GetCaInstanceCrlAddressWithOptionsAsync(GetCaInstanceCrlAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaIdentifier))
            {
                query["CaIdentifier"] = request.CaIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCaInstanceCrlAddress",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCaInstanceCrlAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the CRL URL of a CA</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to query the status information of a private CA instance that you purchased through the SSL Certificates Service console by using the ID of the private CA instance. For example, the status of the CA instance, the number of certificates contained, the number of issued certificates, and so on.
        /// Before calling this API, you must have purchased a private CA through the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">Certificate Management Service console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS Limit</h2>
        /// <para>The per-user QPS limit for this API is 10 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API appropriately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCaInstanceCrlAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCaInstanceCrlAddressResponse
        /// </returns>
        public GetCaInstanceCrlAddressResponse GetCaInstanceCrlAddress(GetCaInstanceCrlAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCaInstanceCrlAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the CRL URL of a CA</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to query the status information of a private CA instance that you purchased through the SSL Certificates Service console by using the ID of the private CA instance. For example, the status of the CA instance, the number of certificates contained, the number of issued certificates, and so on.
        /// Before calling this API, you must have purchased a private CA through the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">Certificate Management Service console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS Limit</h2>
        /// <para>The per-user QPS limit for this API is 10 calls per second. If the limit is exceeded, API calls will be throttled, which may affect your business. Please call the API appropriately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCaInstanceCrlAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCaInstanceCrlAddressResponse
        /// </returns>
        public async Task<GetCaInstanceCrlAddressResponse> GetCaInstanceCrlAddressAsync(GetCaInstanceCrlAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCaInstanceCrlAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the end-entity instances under a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of a private Certificate Authority (CA) instance by its ID. It returns details for a private CA instance that you purchased in the Certificate Management Service (CAS) console. These details include the instance status, the number of certificates it contains, and the number of issued certificates.
        /// Before calling this operation, purchase a private CA from the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed the limit, API calls are throttled, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAllEndEntityInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllEndEntityInstanceResponse
        /// </returns>
        public ListAllEndEntityInstanceResponse ListAllEndEntityInstanceWithOptions(ListAllEndEntityInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecursiveChildren))
            {
                query["RecursiveChildren"] = request.RecursiveChildren;
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
                Action = "ListAllEndEntityInstance",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllEndEntityInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the end-entity instances under a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of a private Certificate Authority (CA) instance by its ID. It returns details for a private CA instance that you purchased in the Certificate Management Service (CAS) console. These details include the instance status, the number of certificates it contains, and the number of issued certificates.
        /// Before calling this operation, purchase a private CA from the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed the limit, API calls are throttled, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAllEndEntityInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllEndEntityInstanceResponse
        /// </returns>
        public async Task<ListAllEndEntityInstanceResponse> ListAllEndEntityInstanceWithOptionsAsync(ListAllEndEntityInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecursiveChildren))
            {
                query["RecursiveChildren"] = request.RecursiveChildren;
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
                Action = "ListAllEndEntityInstance",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllEndEntityInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the end-entity instances under a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of a private Certificate Authority (CA) instance by its ID. It returns details for a private CA instance that you purchased in the Certificate Management Service (CAS) console. These details include the instance status, the number of certificates it contains, and the number of issued certificates.
        /// Before calling this operation, purchase a private CA from the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed the limit, API calls are throttled, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAllEndEntityInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllEndEntityInstanceResponse
        /// </returns>
        public ListAllEndEntityInstanceResponse ListAllEndEntityInstance(ListAllEndEntityInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllEndEntityInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the end-entity instances under a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status of a private Certificate Authority (CA) instance by its ID. It returns details for a private CA instance that you purchased in the Certificate Management Service (CAS) console. These details include the instance status, the number of certificates it contains, and the number of issued certificates.
        /// Before calling this operation, purchase a private CA from the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second for each user. If you exceed the limit, API calls are throttled, which may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAllEndEntityInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllEndEntityInstanceResponse
        /// </returns>
        public async Task<ListAllEndEntityInstanceResponse> ListAllEndEntityInstanceAsync(ListAllEndEntityInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllEndEntityInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operation logs of a certificate authority (CA) certificate, such as issuance and revocation events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this API to query the operation logs for a Certificate Authority (CA) certificate. These logs record operations, such as certificate creation and status changes, for both root and subordinate CA certificates.
        /// This API is limited to 10 queries per second (QPS) per user. API calls that exceed this limit are throttled. This can impact your business. Ensure that you call the API within this limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCACertificateLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCACertificateLogResponse
        /// </returns>
        public ListCACertificateLogResponse ListCACertificateLogWithOptions(ListCACertificateLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListCACertificateLog",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCACertificateLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operation logs of a certificate authority (CA) certificate, such as issuance and revocation events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this API to query the operation logs for a Certificate Authority (CA) certificate. These logs record operations, such as certificate creation and status changes, for both root and subordinate CA certificates.
        /// This API is limited to 10 queries per second (QPS) per user. API calls that exceed this limit are throttled. This can impact your business. Ensure that you call the API within this limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCACertificateLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCACertificateLogResponse
        /// </returns>
        public async Task<ListCACertificateLogResponse> ListCACertificateLogWithOptionsAsync(ListCACertificateLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListCACertificateLog",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCACertificateLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operation logs of a certificate authority (CA) certificate, such as issuance and revocation events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this API to query the operation logs for a Certificate Authority (CA) certificate. These logs record operations, such as certificate creation and status changes, for both root and subordinate CA certificates.
        /// This API is limited to 10 queries per second (QPS) per user. API calls that exceed this limit are throttled. This can impact your business. Ensure that you call the API within this limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCACertificateLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCACertificateLogResponse
        /// </returns>
        public ListCACertificateLogResponse ListCACertificateLog(ListCACertificateLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCACertificateLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operation logs of a certificate authority (CA) certificate, such as issuance and revocation events.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this API to query the operation logs for a Certificate Authority (CA) certificate. These logs record operations, such as certificate creation and status changes, for both root and subordinate CA certificates.
        /// This API is limited to 10 queries per second (QPS) per user. API calls that exceed this limit are throttled. This can impact your business. Ensure that you call the API within this limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCACertificateLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCACertificateLogResponse
        /// </returns>
        public async Task<ListCACertificateLogResponse> ListCACertificateLogAsync(ListCACertificateLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCACertificateLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The QPS limit for this API is 10 per user. If you exceed this limit, your API calls will be throttled. To avoid impacting your business, please plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCertRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCertResponse
        /// </returns>
        public ListCertResponse ListCertWithOptions(ListCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AfterDate))
            {
                query["AfterDate"] = request.AfterDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeforeDate))
            {
                query["BeforeDate"] = request.BeforeDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceUuid))
            {
                query["InstanceUuid"] = request.InstanceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentIdentifier))
            {
                query["ParentIdentifier"] = request.ParentIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListCert",
                Version = "2020-06-30",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The QPS limit for this API is 10 per user. If you exceed this limit, your API calls will be throttled. To avoid impacting your business, please plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCertRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCertResponse
        /// </returns>
        public async Task<ListCertResponse> ListCertWithOptionsAsync(ListCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AfterDate))
            {
                query["AfterDate"] = request.AfterDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeforeDate))
            {
                query["BeforeDate"] = request.BeforeDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceUuid))
            {
                query["InstanceUuid"] = request.InstanceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentIdentifier))
            {
                query["ParentIdentifier"] = request.ParentIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSize))
            {
                query["ShowSize"] = request.ShowSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListCert",
                Version = "2020-06-30",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The QPS limit for this API is 10 per user. If you exceed this limit, your API calls will be throttled. To avoid impacting your business, please plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCertRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCertResponse
        /// </returns>
        public ListCertResponse ListCert(ListCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCertWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The QPS limit for this API is 10 per user. If you exceed this limit, your API calls will be throttled. To avoid impacting your business, please plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCertRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCertResponse
        /// </returns>
        public async Task<ListCertResponse> ListCertAsync(ListCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCertWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all client certificates and server certificates issued by a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API performs a paged query to retrieve the details of all client and server-side certificates that you have created. These details include the unique identifier, serial number, subject information, content, and status of each certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The QPS limit for a single user is 10 calls per second. If you exceed this limit, your API calls are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientCertificateResponse
        /// </returns>
        public ListClientCertificateResponse ListClientCertificateWithOptions(ListClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all client certificates and server certificates issued by a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API performs a paged query to retrieve the details of all client and server-side certificates that you have created. These details include the unique identifier, serial number, subject information, content, and status of each certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The QPS limit for a single user is 10 calls per second. If you exceed this limit, your API calls are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListClientCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientCertificateResponse
        /// </returns>
        public async Task<ListClientCertificateResponse> ListClientCertificateWithOptionsAsync(ListClientCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all client certificates and server certificates issued by a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API performs a paged query to retrieve the details of all client and server-side certificates that you have created. These details include the unique identifier, serial number, subject information, content, and status of each certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The QPS limit for a single user is 10 calls per second. If you exceed this limit, your API calls are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientCertificateResponse
        /// </returns>
        public ListClientCertificateResponse ListClientCertificate(ListClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all client certificates and server certificates issued by a private certificate authority (CA).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API performs a paged query to retrieve the details of all client and server-side certificates that you have created. These details include the unique identifier, serial number, subject information, content, and status of each certificate.</para>
        /// <h2>QPS limit</h2>
        /// <para>The QPS limit for a single user is 10 calls per second. If you exceed this limit, your API calls are throttled, which may affect your business. Call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListClientCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientCertificateResponse
        /// </returns>
        public async Task<ListClientCertificateResponse> ListClientCertificateAsync(ListClientCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists private certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation lists CA certificates, including root and subordinate CA certificates.
        /// This operation has a limit of 10 queries per second (QPS) for each user. If you exceed the limit, API calls are throttled, which may affect your business. Call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPcaCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPcaCaCertificateResponse
        /// </returns>
        public ListPcaCaCertificateResponse ListPcaCaCertificateWithOptions(ListPcaCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListPcaCaCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPcaCaCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists private certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation lists CA certificates, including root and subordinate CA certificates.
        /// This operation has a limit of 10 queries per second (QPS) for each user. If you exceed the limit, API calls are throttled, which may affect your business. Call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPcaCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPcaCaCertificateResponse
        /// </returns>
        public async Task<ListPcaCaCertificateResponse> ListPcaCaCertificateWithOptionsAsync(ListPcaCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListPcaCaCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPcaCaCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists private certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation lists CA certificates, including root and subordinate CA certificates.
        /// This operation has a limit of 10 queries per second (QPS) for each user. If you exceed the limit, API calls are throttled, which may affect your business. Call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPcaCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPcaCaCertificateResponse
        /// </returns>
        public ListPcaCaCertificateResponse ListPcaCaCertificate(ListPcaCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPcaCaCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists private certificate authority (CA) certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation lists CA certificates, including root and subordinate CA certificates.
        /// This operation has a limit of 10 queries per second (QPS) for each user. If you exceed the limit, API calls are throttled, which may affect your business. Call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPcaCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPcaCaCertificateResponse
        /// </returns>
        public async Task<ListPcaCaCertificateResponse> ListPcaCaCertificateAsync(ListPcaCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPcaCaCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all revoked client certificates and server certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query to retrieve the details of all revoked client and server-side certificates, such as the unique identifier, serial number, and revocation date.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this API is 10 for each user. If you exceed this limit, API calls are throttled, which may affect your business. We recommend that you call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRevokeCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRevokeCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all revoked client certificates and server certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query to retrieve the details of all revoked client and server-side certificates, such as the unique identifier, serial number, and revocation date.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this API is 10 for each user. If you exceed this limit, API calls are throttled, which may affect your business. We recommend that you call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRevokeCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRevokeCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all revoked client certificates and server certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query to retrieve the details of all revoked client and server-side certificates, such as the unique identifier, serial number, and revocation date.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this API is 10 for each user. If you exceed this limit, API calls are throttled, which may affect your business. We recommend that you call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRevokeCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRevokeCertificateResponse
        /// </returns>
        public ListRevokeCertificateResponse ListRevokeCertificate(ListRevokeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRevokeCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all revoked client certificates and server certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query to retrieve the details of all revoked client and server-side certificates, such as the unique identifier, serial number, and revocation date.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this API is 10 for each user. If you exceed this limit, API calls are throttled, which may affect your business. We recommend that you call this API at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRevokeCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRevokeCertificateResponse
        /// </returns>
        public async Task<ListRevokeCertificateResponse> ListRevokeCertificateAsync(ListRevokeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRevokeCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are attached to Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">Certificate Management Service console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.
        /// You can call this operation up to 10 times per second per Alibaba Cloud account. If the number of calls per second exceeds this limit, throttling is triggered. This may affect your business. We recommend that you plan your calls accordingly.</para>
        /// <h2>QPS limit</h2>
        /// <para>You can call this operation up to 10 times per second for each Alibaba Cloud account. If the number of calls per second exceeds this limit, throttling is triggered, which may affect your business. We recommend that you plan your calls accordingly.</para>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
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
                Version = "2020-06-30",
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
        /// <para>Queries the tags that are attached to Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">Certificate Management Service console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.
        /// You can call this operation up to 10 times per second per Alibaba Cloud account. If the number of calls per second exceeds this limit, throttling is triggered. This may affect your business. We recommend that you plan your calls accordingly.</para>
        /// <h2>QPS limit</h2>
        /// <para>You can call this operation up to 10 times per second for each Alibaba Cloud account. If the number of calls per second exceeds this limit, throttling is triggered, which may affect your business. We recommend that you plan your calls accordingly.</para>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
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
                Version = "2020-06-30",
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
        /// <para>Queries the tags that are attached to Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">Certificate Management Service console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.
        /// You can call this operation up to 10 times per second per Alibaba Cloud account. If the number of calls per second exceeds this limit, throttling is triggered. This may affect your business. We recommend that you plan your calls accordingly.</para>
        /// <h2>QPS limit</h2>
        /// <para>You can call this operation up to 10 times per second for each Alibaba Cloud account. If the number of calls per second exceeds this limit, throttling is triggered, which may affect your business. We recommend that you plan your calls accordingly.</para>
        /// </description>
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
        /// <para>Queries the tags that are attached to Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, you must purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">Certificate Management Service console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.
        /// You can call this operation up to 10 times per second per Alibaba Cloud account. If the number of calls per second exceeds this limit, throttling is triggered. This may affect your business. We recommend that you plan your calls accordingly.</para>
        /// <h2>QPS limit</h2>
        /// <para>You can call this operation up to 10 times per second for each Alibaba Cloud account. If the number of calls per second exceeds this limit, throttling is triggered, which may affect your business. We recommend that you plan your calls accordingly.</para>
        /// </description>
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
        /// <para>Moves a Certificate Management Service resource to a different resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status information of a private CA instance that you purchased in the Certificate Management Service (CAS) console. You can query by the private CA instance ID to retrieve information such as the status of the CA instance, the number of certificates it contains, and the number of issued certificates.
        /// Before you call this operation, you must purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. If you exceed this limit, API calls are throttled, which can affect your business. Call this operation within the specified limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
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
                Version = "2020-06-30",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a Certificate Management Service resource to a different resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status information of a private CA instance that you purchased in the Certificate Management Service (CAS) console. You can query by the private CA instance ID to retrieve information such as the status of the CA instance, the number of certificates it contains, and the number of issued certificates.
        /// Before you call this operation, you must purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. If you exceed this limit, API calls are throttled, which can affect your business. Call this operation within the specified limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
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
                Version = "2020-06-30",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a Certificate Management Service resource to a different resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status information of a private CA instance that you purchased in the Certificate Management Service (CAS) console. You can query by the private CA instance ID to retrieve information such as the status of the CA instance, the number of certificates it contains, and the number of issued certificates.
        /// Before you call this operation, you must purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. If you exceed this limit, API calls are throttled, which can affect your business. Call this operation within the specified limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a Certificate Management Service resource to a different resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the status information of a private CA instance that you purchased in the Certificate Management Service (CAS) console. You can query by the private CA instance ID to retrieve information such as the status of the CA instance, the number of certificates it contains, and the number of issued certificates.
        /// Before you call this operation, you must purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. If you exceed this limit, API calls are throttled, which can affect your business. Call this operation within the specified limit.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches tags to one or more Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation adds tags to one or more resources. You can add tags to private CA instances that you purchased in the Certificate Management Service (CAS) console.
        /// Before calling this operation, purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
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
                Version = "2020-06-30",
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
        /// <para>Attaches tags to one or more Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation adds tags to one or more resources. You can add tags to private CA instances that you purchased in the Certificate Management Service (CAS) console.
        /// Before calling this operation, purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
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
                Version = "2020-06-30",
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
        /// <para>Attaches tags to one or more Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation adds tags to one or more resources. You can add tags to private CA instances that you purchased in the Certificate Management Service (CAS) console.
        /// Before calling this operation, purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
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
        /// <para>Attaches tags to one or more Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation adds tags to one or more resources. You can add tags to private CA instances that you purchased in the Certificate Management Service (CAS) console.
        /// Before calling this operation, purchase a private CA in the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
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
        /// <para>Removes tags from one or more Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries status information for a private Certificate Authority (CA) instance that you purchased in the Certificate Management Service (CAS) console. You can use the private CA instance ID to retrieve information such as the instance status, the number of certificates it contains, and the number of certificates issued.
        /// Before you call this operation, you must purchase a private CA from the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. If you exceed this limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
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
                Version = "2020-06-30",
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
        /// <para>Removes tags from one or more Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries status information for a private Certificate Authority (CA) instance that you purchased in the Certificate Management Service (CAS) console. You can use the private CA instance ID to retrieve information such as the instance status, the number of certificates it contains, and the number of certificates issued.
        /// Before you call this operation, you must purchase a private CA from the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. If you exceed this limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
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
                Version = "2020-06-30",
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
        /// <para>Removes tags from one or more Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries status information for a private Certificate Authority (CA) instance that you purchased in the Certificate Management Service (CAS) console. You can use the private CA instance ID to retrieve information such as the instance status, the number of certificates it contains, and the number of certificates issued.
        /// Before you call this operation, you must purchase a private CA from the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. If you exceed this limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
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
        /// <para>Removes tags from one or more Certificate Management Service resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries status information for a private Certificate Authority (CA) instance that you purchased in the Certificate Management Service (CAS) console. You can use the private CA instance ID to retrieve information such as the instance status, the number of certificates it contains, and the number of certificates issued.
        /// Before you call this operation, you must purchase a private CA from the <a href="https://yundun.console.aliyun.com/?p=cas#/pca/rootlist">CAS console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/208553.html">Purchase a private CA</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>The queries per second (QPS) limit for this operation is 10 calls per second per user. If you exceed this limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a root or subordinate certificate authority (CA) certificate, such as revoking or disabling an active CA.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you create a CA certificate, its status is ISSUE by default. You can call this API operation to change the status of a CA certificate from ISSUE to REVOKE. A CA certificate in the ISSUE state can be used to issue certificates. A CA certificate in the REVOKE state cannot be used to issue certificates, and all certificates issued by this CA certificate become invalid.
        /// Before you call this API operation, create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and an intermediate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. If you exceed this limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCACertificateStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCACertificateStatusResponse
        /// </returns>
        public UpdateCACertificateStatusResponse UpdateCACertificateStatusWithOptions(UpdateCACertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a root or subordinate certificate authority (CA) certificate, such as revoking or disabling an active CA.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you create a CA certificate, its status is ISSUE by default. You can call this API operation to change the status of a CA certificate from ISSUE to REVOKE. A CA certificate in the ISSUE state can be used to issue certificates. A CA certificate in the REVOKE state cannot be used to issue certificates, and all certificates issued by this CA certificate become invalid.
        /// Before you call this API operation, create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and an intermediate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. If you exceed this limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCACertificateStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCACertificateStatusResponse
        /// </returns>
        public async Task<UpdateCACertificateStatusResponse> UpdateCACertificateStatusWithOptionsAsync(UpdateCACertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a root or subordinate certificate authority (CA) certificate, such as revoking or disabling an active CA.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you create a CA certificate, its status is ISSUE by default. You can call this API operation to change the status of a CA certificate from ISSUE to REVOKE. A CA certificate in the ISSUE state can be used to issue certificates. A CA certificate in the REVOKE state cannot be used to issue certificates, and all certificates issued by this CA certificate become invalid.
        /// Before you call this API operation, create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and an intermediate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. If you exceed this limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCACertificateStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCACertificateStatusResponse
        /// </returns>
        public UpdateCACertificateStatusResponse UpdateCACertificateStatus(UpdateCACertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCACertificateStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a root or subordinate certificate authority (CA) certificate, such as revoking or disabling an active CA.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you create a CA certificate, its status is ISSUE by default. You can call this API operation to change the status of a CA certificate from ISSUE to REVOKE. A CA certificate in the ISSUE state can be used to issue certificates. A CA certificate in the REVOKE state cannot be used to issue certificates, and all certificates issued by this CA certificate become invalid.
        /// Before you call this API operation, create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and an intermediate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation is limited to 10 queries per second (QPS) for each user. If you exceed this limit, API calls are throttled. This may affect your business. Plan your calls accordingly.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCACertificateStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCACertificateStatusResponse
        /// </returns>
        public async Task<UpdateCACertificateStatusResponse> UpdateCACertificateStatusAsync(UpdateCACertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCACertificateStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the properties of a private CA certificate, such as the export status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When a Certificate Authority (CA) certificate is created, its status is Normal by default. You can call this API operation to change the status of a CA certificate to Revoked. A CA certificate in the Normal status can be used to issue certificates. A revoked CA certificate cannot be used to issue certificates, and all certificates previously issued by it become invalid.
        /// Before you call this API operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>This API operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, API calls are throttled, which may affect your business. Call this API operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePcaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePcaCertificateResponse
        /// </returns>
        public UpdatePcaCertificateResponse UpdatePcaCertificateWithOptions(UpdatePcaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePcaCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePcaCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the properties of a private CA certificate, such as the export status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When a Certificate Authority (CA) certificate is created, its status is Normal by default. You can call this API operation to change the status of a CA certificate to Revoked. A CA certificate in the Normal status can be used to issue certificates. A revoked CA certificate cannot be used to issue certificates, and all certificates previously issued by it become invalid.
        /// Before you call this API operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>This API operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, API calls are throttled, which may affect your business. Call this API operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePcaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePcaCertificateResponse
        /// </returns>
        public async Task<UpdatePcaCertificateResponse> UpdatePcaCertificateWithOptionsAsync(UpdatePcaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePcaCertificate",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePcaCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the properties of a private CA certificate, such as the export status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When a Certificate Authority (CA) certificate is created, its status is Normal by default. You can call this API operation to change the status of a CA certificate to Revoked. A CA certificate in the Normal status can be used to issue certificates. A revoked CA certificate cannot be used to issue certificates, and all certificates previously issued by it become invalid.
        /// Before you call this API operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>This API operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, API calls are throttled, which may affect your business. Call this API operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePcaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePcaCertificateResponse
        /// </returns>
        public UpdatePcaCertificateResponse UpdatePcaCertificate(UpdatePcaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePcaCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the properties of a private CA certificate, such as the export status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When a Certificate Authority (CA) certificate is created, its status is Normal by default. You can call this API operation to change the status of a CA certificate to Revoked. A CA certificate in the Normal status can be used to issue certificates. A revoked CA certificate cannot be used to issue certificates, and all certificates previously issued by it become invalid.
        /// Before you call this API operation, you must create a root CA certificate by calling <a href="https://help.aliyun.com/document_detail/465962.html">CreateRootCACertificate</a> and a subordinate CA certificate by calling <a href="https://help.aliyun.com/document_detail/465959.html">CreateSubCACertificate</a>.</para>
        /// <h2>QPS limits</h2>
        /// <para>This API operation is limited to 10 queries per second (QPS) per user. If you exceed this limit, API calls are throttled, which may affect your business. Call this API operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePcaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePcaCertificateResponse
        /// </returns>
        public async Task<UpdatePcaCertificateResponse> UpdatePcaCertificateAsync(UpdatePcaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePcaCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a private CA certificate to Certificate Management Service for centralized management.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation uploads a PCA certificate to a certificate repository.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 calls per second for each user. If you exceed the limit, your API calls are throttled. Throttling may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadPcaCertToCasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadPcaCertToCasResponse
        /// </returns>
        public UploadPcaCertToCasResponse UploadPcaCertToCasWithOptions(UploadPcaCertToCasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadPcaCertToCas",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadPcaCertToCasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a private CA certificate to Certificate Management Service for centralized management.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation uploads a PCA certificate to a certificate repository.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 calls per second for each user. If you exceed the limit, your API calls are throttled. Throttling may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadPcaCertToCasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadPcaCertToCasResponse
        /// </returns>
        public async Task<UploadPcaCertToCasResponse> UploadPcaCertToCasWithOptionsAsync(UploadPcaCertToCasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadPcaCertToCas",
                Version = "2020-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadPcaCertToCasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a private CA certificate to Certificate Management Service for centralized management.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation uploads a PCA certificate to a certificate repository.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 calls per second for each user. If you exceed the limit, your API calls are throttled. Throttling may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadPcaCertToCasRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadPcaCertToCasResponse
        /// </returns>
        public UploadPcaCertToCasResponse UploadPcaCertToCas(UploadPcaCertToCasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadPcaCertToCasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a private CA certificate to Certificate Management Service for centralized management.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation uploads a PCA certificate to a certificate repository.</para>
        /// <h2>QPS limit</h2>
        /// <para>This operation has a queries per second (QPS) limit of 10 calls per second for each user. If you exceed the limit, your API calls are throttled. Throttling may affect your business. We recommend that you call this operation at a reasonable rate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadPcaCertToCasRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadPcaCertToCasResponse
        /// </returns>
        public async Task<UploadPcaCertToCasResponse> UploadPcaCertToCasAsync(UploadPcaCertToCasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadPcaCertToCasWithOptionsAsync(request, runtime);
        }

    }
}
