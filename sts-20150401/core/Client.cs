// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sts20150401.Models;

namespace AlibabaCloud.SDK.Sts20150401
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "sts.aliyuncs.com"},
                {"ap-south-1", "sts.aliyuncs.com"},
                {"ap-southeast-2", "sts.aliyuncs.com"},
                {"cn-beijing-finance-pop", "sts.aliyuncs.com"},
                {"cn-beijing-gov-1", "sts.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "sts.aliyuncs.com"},
                {"cn-edge-1", "sts.aliyuncs.com"},
                {"cn-fujian", "sts.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "sts.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "sts.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "sts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "sts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "sts.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "sts.aliyuncs.com"},
                {"cn-hangzhou-test-306", "sts.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "sts.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "sts.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "sts.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "sts.aliyuncs.com"},
                {"cn-shanghai-inner", "sts.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "sts.aliyuncs.com"},
                {"cn-shenzhen-inner", "sts.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "sts.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "sts.aliyuncs.com"},
                {"cn-wuhan", "sts.aliyuncs.com"},
                {"cn-yushanfang", "sts.aliyuncs.com"},
                {"cn-zhangbei", "sts.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "sts.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "sts.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "sts.aliyuncs.com"},
                {"eu-west-1-oxs", "sts.aliyuncs.com"},
                {"rus-west-1-pop", "sts.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("sts", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Obtains a Security Token Service (STS) token to assume a Resource Access Management (RAM) role.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>You cannot use an Alibaba Cloud account to call this operation. The requester of this operation can only be a RAM user or RAM role. Make sure that the AliyunSTSAssumeRoleAccess policy is attached to the requester. After this policy is attached to the requester, the requester has the management permissions on STS.
        /// If you do not attach the AliyunSTSAssumeRoleAccess policy to the requester, the following error message is returned:
        /// <c>You are not authorized to do this action. You should be authorized by RAM.</c>
        /// You can refer to the following information to troubleshoot the error:</para>
        /// <list type="bullet">
        /// <item><description>Cause of the error: The policy that is required to assume a RAM role is not attached to the requester. To resolve this issue, attach the AliyunSTSAssumeRoleAccess policy or a custom policy to the requester. For more information, see <a href="https://help.aliyun.com/document_detail/39744.html">Can I specify the RAM role that a RAM user can assume?</a> and <a href="https://help.aliyun.com/document_detail/116146.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>Cause of the error: The requester is not authorized to assume the RAM role. To resolve this issue, add the requester to the Principal element in the trust policy of the RAM role For more information, see <a href="https://help.aliyun.com/document_detail/116819.html">Edit the trust policy of a RAM role</a>.</description></item>
        /// </list>
        /// <h3>Best practices</h3>
        /// <para>An STS token is valid for a period of time after it is issued, and the number of STS tokens that can be issued within an interval is also limited. Therefore, we recommend that you configure a proper validity period for an STS token and repeatedly use the token within this period. This prevents frequent issuing of STS tokens from adversely affecting your services if a large number of requests are sent. For more information about the limit, see <a href="https://help.aliyun.com/document_detail/39744.html">Is the number of STS API requests limited?</a> You can configure the <c>DurationSeconds</c> parameter to specify a validity period for an STS token.
        /// When you upload or download Object Storage Service (OSS) objects on mobile devices, a large number of STS API requests are sent. In this case, repeated use of an STS token may not meet your business requirements. To avoid the limit on STS API requests from affecting access to OSS, you can <b>add a signature to the URL of an OSS object</b>. For more information, see <a href="https://help.aliyun.com/document_detail/31952.html">Add signatures to URLs</a> and <a href="https://help.aliyun.com/document_detail/31926.html">Obtain signature information from the server and upload data to OSS</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleResponse
        /// </returns>
        public AssumeRoleResponse AssumeRoleWithOptions(AssumeRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSessionName))
            {
                query["RoleSessionName"] = request.RoleSessionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIdentity))
            {
                query["SourceIdentity"] = request.SourceIdentity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRole",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a Security Token Service (STS) token to assume a Resource Access Management (RAM) role.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>You cannot use an Alibaba Cloud account to call this operation. The requester of this operation can only be a RAM user or RAM role. Make sure that the AliyunSTSAssumeRoleAccess policy is attached to the requester. After this policy is attached to the requester, the requester has the management permissions on STS.
        /// If you do not attach the AliyunSTSAssumeRoleAccess policy to the requester, the following error message is returned:
        /// <c>You are not authorized to do this action. You should be authorized by RAM.</c>
        /// You can refer to the following information to troubleshoot the error:</para>
        /// <list type="bullet">
        /// <item><description>Cause of the error: The policy that is required to assume a RAM role is not attached to the requester. To resolve this issue, attach the AliyunSTSAssumeRoleAccess policy or a custom policy to the requester. For more information, see <a href="https://help.aliyun.com/document_detail/39744.html">Can I specify the RAM role that a RAM user can assume?</a> and <a href="https://help.aliyun.com/document_detail/116146.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>Cause of the error: The requester is not authorized to assume the RAM role. To resolve this issue, add the requester to the Principal element in the trust policy of the RAM role For more information, see <a href="https://help.aliyun.com/document_detail/116819.html">Edit the trust policy of a RAM role</a>.</description></item>
        /// </list>
        /// <h3>Best practices</h3>
        /// <para>An STS token is valid for a period of time after it is issued, and the number of STS tokens that can be issued within an interval is also limited. Therefore, we recommend that you configure a proper validity period for an STS token and repeatedly use the token within this period. This prevents frequent issuing of STS tokens from adversely affecting your services if a large number of requests are sent. For more information about the limit, see <a href="https://help.aliyun.com/document_detail/39744.html">Is the number of STS API requests limited?</a> You can configure the <c>DurationSeconds</c> parameter to specify a validity period for an STS token.
        /// When you upload or download Object Storage Service (OSS) objects on mobile devices, a large number of STS API requests are sent. In this case, repeated use of an STS token may not meet your business requirements. To avoid the limit on STS API requests from affecting access to OSS, you can <b>add a signature to the URL of an OSS object</b>. For more information, see <a href="https://help.aliyun.com/document_detail/31952.html">Add signatures to URLs</a> and <a href="https://help.aliyun.com/document_detail/31926.html">Obtain signature information from the server and upload data to OSS</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleResponse
        /// </returns>
        public async Task<AssumeRoleResponse> AssumeRoleWithOptionsAsync(AssumeRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSessionName))
            {
                query["RoleSessionName"] = request.RoleSessionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIdentity))
            {
                query["SourceIdentity"] = request.SourceIdentity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRole",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a Security Token Service (STS) token to assume a Resource Access Management (RAM) role.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>You cannot use an Alibaba Cloud account to call this operation. The requester of this operation can only be a RAM user or RAM role. Make sure that the AliyunSTSAssumeRoleAccess policy is attached to the requester. After this policy is attached to the requester, the requester has the management permissions on STS.
        /// If you do not attach the AliyunSTSAssumeRoleAccess policy to the requester, the following error message is returned:
        /// <c>You are not authorized to do this action. You should be authorized by RAM.</c>
        /// You can refer to the following information to troubleshoot the error:</para>
        /// <list type="bullet">
        /// <item><description>Cause of the error: The policy that is required to assume a RAM role is not attached to the requester. To resolve this issue, attach the AliyunSTSAssumeRoleAccess policy or a custom policy to the requester. For more information, see <a href="https://help.aliyun.com/document_detail/39744.html">Can I specify the RAM role that a RAM user can assume?</a> and <a href="https://help.aliyun.com/document_detail/116146.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>Cause of the error: The requester is not authorized to assume the RAM role. To resolve this issue, add the requester to the Principal element in the trust policy of the RAM role For more information, see <a href="https://help.aliyun.com/document_detail/116819.html">Edit the trust policy of a RAM role</a>.</description></item>
        /// </list>
        /// <h3>Best practices</h3>
        /// <para>An STS token is valid for a period of time after it is issued, and the number of STS tokens that can be issued within an interval is also limited. Therefore, we recommend that you configure a proper validity period for an STS token and repeatedly use the token within this period. This prevents frequent issuing of STS tokens from adversely affecting your services if a large number of requests are sent. For more information about the limit, see <a href="https://help.aliyun.com/document_detail/39744.html">Is the number of STS API requests limited?</a> You can configure the <c>DurationSeconds</c> parameter to specify a validity period for an STS token.
        /// When you upload or download Object Storage Service (OSS) objects on mobile devices, a large number of STS API requests are sent. In this case, repeated use of an STS token may not meet your business requirements. To avoid the limit on STS API requests from affecting access to OSS, you can <b>add a signature to the URL of an OSS object</b>. For more information, see <a href="https://help.aliyun.com/document_detail/31952.html">Add signatures to URLs</a> and <a href="https://help.aliyun.com/document_detail/31926.html">Obtain signature information from the server and upload data to OSS</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleResponse
        /// </returns>
        public AssumeRoleResponse AssumeRole(AssumeRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssumeRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a Security Token Service (STS) token to assume a Resource Access Management (RAM) role.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>You cannot use an Alibaba Cloud account to call this operation. The requester of this operation can only be a RAM user or RAM role. Make sure that the AliyunSTSAssumeRoleAccess policy is attached to the requester. After this policy is attached to the requester, the requester has the management permissions on STS.
        /// If you do not attach the AliyunSTSAssumeRoleAccess policy to the requester, the following error message is returned:
        /// <c>You are not authorized to do this action. You should be authorized by RAM.</c>
        /// You can refer to the following information to troubleshoot the error:</para>
        /// <list type="bullet">
        /// <item><description>Cause of the error: The policy that is required to assume a RAM role is not attached to the requester. To resolve this issue, attach the AliyunSTSAssumeRoleAccess policy or a custom policy to the requester. For more information, see <a href="https://help.aliyun.com/document_detail/39744.html">Can I specify the RAM role that a RAM user can assume?</a> and <a href="https://help.aliyun.com/document_detail/116146.html">Grant permissions to a RAM user</a>.</description></item>
        /// <item><description>Cause of the error: The requester is not authorized to assume the RAM role. To resolve this issue, add the requester to the Principal element in the trust policy of the RAM role For more information, see <a href="https://help.aliyun.com/document_detail/116819.html">Edit the trust policy of a RAM role</a>.</description></item>
        /// </list>
        /// <h3>Best practices</h3>
        /// <para>An STS token is valid for a period of time after it is issued, and the number of STS tokens that can be issued within an interval is also limited. Therefore, we recommend that you configure a proper validity period for an STS token and repeatedly use the token within this period. This prevents frequent issuing of STS tokens from adversely affecting your services if a large number of requests are sent. For more information about the limit, see <a href="https://help.aliyun.com/document_detail/39744.html">Is the number of STS API requests limited?</a> You can configure the <c>DurationSeconds</c> parameter to specify a validity period for an STS token.
        /// When you upload or download Object Storage Service (OSS) objects on mobile devices, a large number of STS API requests are sent. In this case, repeated use of an STS token may not meet your business requirements. To avoid the limit on STS API requests from affecting access to OSS, you can <b>add a signature to the URL of an OSS object</b>. For more information, see <a href="https://help.aliyun.com/document_detail/31952.html">Add signatures to URLs</a> and <a href="https://help.aliyun.com/document_detail/31926.html">Obtain signature information from the server and upload data to OSS</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleResponse
        /// </returns>
        public async Task<AssumeRoleResponse> AssumeRoleAsync(AssumeRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssumeRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Security Token Service (STS) token to assume a Resource Access Management (RAM) role during role-based single sign-on (SSO) by using OpenID Connect (OIDC).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>An OIDC token is obtained from an external identity provider (IdP).</description></item>
        /// <item><description>An OIDC IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/327123.html">Create an OIDC IdP</a> or <a href="https://help.aliyun.com/document_detail/327135.html">CreateOIDCProvider</a>.</description></item>
        /// <item><description>A RAM role whose trusted entity is an OIDC IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116805.html">Create a RAM role for a trusted IdP</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleWithOIDCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleWithOIDCResponse
        /// </returns>
        public AssumeRoleWithOIDCResponse AssumeRoleWithOIDCWithOptions(AssumeRoleWithOIDCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderArn))
            {
                query["OIDCProviderArn"] = request.OIDCProviderArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCToken))
            {
                query["OIDCToken"] = request.OIDCToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSessionName))
            {
                query["RoleSessionName"] = request.RoleSessionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRoleWithOIDC",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleWithOIDCResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Security Token Service (STS) token to assume a Resource Access Management (RAM) role during role-based single sign-on (SSO) by using OpenID Connect (OIDC).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>An OIDC token is obtained from an external identity provider (IdP).</description></item>
        /// <item><description>An OIDC IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/327123.html">Create an OIDC IdP</a> or <a href="https://help.aliyun.com/document_detail/327135.html">CreateOIDCProvider</a>.</description></item>
        /// <item><description>A RAM role whose trusted entity is an OIDC IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116805.html">Create a RAM role for a trusted IdP</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleWithOIDCRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleWithOIDCResponse
        /// </returns>
        public async Task<AssumeRoleWithOIDCResponse> AssumeRoleWithOIDCWithOptionsAsync(AssumeRoleWithOIDCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderArn))
            {
                query["OIDCProviderArn"] = request.OIDCProviderArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCToken))
            {
                query["OIDCToken"] = request.OIDCToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleSessionName))
            {
                query["RoleSessionName"] = request.RoleSessionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRoleWithOIDC",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleWithOIDCResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Security Token Service (STS) token to assume a Resource Access Management (RAM) role during role-based single sign-on (SSO) by using OpenID Connect (OIDC).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>An OIDC token is obtained from an external identity provider (IdP).</description></item>
        /// <item><description>An OIDC IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/327123.html">Create an OIDC IdP</a> or <a href="https://help.aliyun.com/document_detail/327135.html">CreateOIDCProvider</a>.</description></item>
        /// <item><description>A RAM role whose trusted entity is an OIDC IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116805.html">Create a RAM role for a trusted IdP</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleWithOIDCRequest
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleWithOIDCResponse
        /// </returns>
        public AssumeRoleWithOIDCResponse AssumeRoleWithOIDC(AssumeRoleWithOIDCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssumeRoleWithOIDCWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Security Token Service (STS) token to assume a Resource Access Management (RAM) role during role-based single sign-on (SSO) by using OpenID Connect (OIDC).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>An OIDC token is obtained from an external identity provider (IdP).</description></item>
        /// <item><description>An OIDC IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/327123.html">Create an OIDC IdP</a> or <a href="https://help.aliyun.com/document_detail/327135.html">CreateOIDCProvider</a>.</description></item>
        /// <item><description>A RAM role whose trusted entity is an OIDC IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116805.html">Create a RAM role for a trusted IdP</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleWithOIDCRequest
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleWithOIDCResponse
        /// </returns>
        public async Task<AssumeRoleWithOIDCResponse> AssumeRoleWithOIDCAsync(AssumeRoleWithOIDCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssumeRoleWithOIDCWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a Security Token Service (STS) token to assume a Resource Access Management (RAM) role during role-based single sign-on (SSO) by using Security Assertion Markup Language (SAML).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>A SAML response is obtained from an external identity provider (IdP).</description></item>
        /// <item><description>A SAML IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116083.html">Create a SAML IdP</a> or <a href="https://help.aliyun.com/document_detail/186846.html">CreateSAMLProvider</a>.</description></item>
        /// <item><description>A RAM role whose trusted entity is a SAML IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116805.html">Create a RAM role for a trusted IdP</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleWithSAMLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleWithSAMLResponse
        /// </returns>
        public AssumeRoleWithSAMLResponse AssumeRoleWithSAMLWithOptions(AssumeRoleWithSAMLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLAssertion))
            {
                query["SAMLAssertion"] = request.SAMLAssertion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderArn))
            {
                query["SAMLProviderArn"] = request.SAMLProviderArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRoleWithSAML",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleWithSAMLResponse>(DoRPCRequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a Security Token Service (STS) token to assume a Resource Access Management (RAM) role during role-based single sign-on (SSO) by using Security Assertion Markup Language (SAML).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>A SAML response is obtained from an external identity provider (IdP).</description></item>
        /// <item><description>A SAML IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116083.html">Create a SAML IdP</a> or <a href="https://help.aliyun.com/document_detail/186846.html">CreateSAMLProvider</a>.</description></item>
        /// <item><description>A RAM role whose trusted entity is a SAML IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116805.html">Create a RAM role for a trusted IdP</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleWithSAMLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleWithSAMLResponse
        /// </returns>
        public async Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLWithOptionsAsync(AssumeRoleWithSAMLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationSeconds))
            {
                query["DurationSeconds"] = request.DurationSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLAssertion))
            {
                query["SAMLAssertion"] = request.SAMLAssertion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderArn))
            {
                query["SAMLProviderArn"] = request.SAMLProviderArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssumeRoleWithSAML",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssumeRoleWithSAMLResponse>(await DoRPCRequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a Security Token Service (STS) token to assume a Resource Access Management (RAM) role during role-based single sign-on (SSO) by using Security Assertion Markup Language (SAML).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>A SAML response is obtained from an external identity provider (IdP).</description></item>
        /// <item><description>A SAML IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116083.html">Create a SAML IdP</a> or <a href="https://help.aliyun.com/document_detail/186846.html">CreateSAMLProvider</a>.</description></item>
        /// <item><description>A RAM role whose trusted entity is a SAML IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116805.html">Create a RAM role for a trusted IdP</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleWithSAMLRequest
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleWithSAMLResponse
        /// </returns>
        public AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssumeRoleWithSAMLWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a Security Token Service (STS) token to assume a Resource Access Management (RAM) role during role-based single sign-on (SSO) by using Security Assertion Markup Language (SAML).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>A SAML response is obtained from an external identity provider (IdP).</description></item>
        /// <item><description>A SAML IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116083.html">Create a SAML IdP</a> or <a href="https://help.aliyun.com/document_detail/186846.html">CreateSAMLProvider</a>.</description></item>
        /// <item><description>A RAM role whose trusted entity is a SAML IdP is created in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/116805.html">Create a RAM role for a trusted IdP</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AssumeRoleWithSAMLRequest
        /// </param>
        /// 
        /// <returns>
        /// AssumeRoleWithSAMLResponse
        /// </returns>
        public async Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssumeRoleWithSAMLWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the current requester belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallerIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCallerIdentityResponse
        /// </returns>
        public GetCallerIdentityResponse GetCallerIdentityWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCallerIdentity",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallerIdentityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the current requester belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallerIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCallerIdentityResponse
        /// </returns>
        public async Task<GetCallerIdentityResponse> GetCallerIdentityWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCallerIdentity",
                Version = "2015-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallerIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the current requester belongs.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCallerIdentityResponse
        /// </returns>
        public GetCallerIdentityResponse GetCallerIdentity()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCallerIdentityWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the current requester belongs.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCallerIdentityResponse
        /// </returns>
        public async Task<GetCallerIdentityResponse> GetCallerIdentityAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCallerIdentityWithOptionsAsync(runtime);
        }

    }
}
