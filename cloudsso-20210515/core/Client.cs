// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudsso20210515.Models;

namespace AlibabaCloud.SDK.Cloudsso20210515
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudsso", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Adds a Security Assertion Markup Language (SAML) signing certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to two SAML signing certificates.
        /// This topic provides an example on how to add a SAML signing certificate to the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddExternalSAMLIdPCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddExternalSAMLIdPCertificateResponse
        /// </returns>
        public AddExternalSAMLIdPCertificateResponse AddExternalSAMLIdPCertificateWithOptions(AddExternalSAMLIdPCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.X509Certificate))
            {
                query["X509Certificate"] = request.X509Certificate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddExternalSAMLIdPCertificate",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddExternalSAMLIdPCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a Security Assertion Markup Language (SAML) signing certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to two SAML signing certificates.
        /// This topic provides an example on how to add a SAML signing certificate to the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddExternalSAMLIdPCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddExternalSAMLIdPCertificateResponse
        /// </returns>
        public async Task<AddExternalSAMLIdPCertificateResponse> AddExternalSAMLIdPCertificateWithOptionsAsync(AddExternalSAMLIdPCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.X509Certificate))
            {
                query["X509Certificate"] = request.X509Certificate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddExternalSAMLIdPCertificate",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddExternalSAMLIdPCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a Security Assertion Markup Language (SAML) signing certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to two SAML signing certificates.
        /// This topic provides an example on how to add a SAML signing certificate to the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddExternalSAMLIdPCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddExternalSAMLIdPCertificateResponse
        /// </returns>
        public AddExternalSAMLIdPCertificateResponse AddExternalSAMLIdPCertificate(AddExternalSAMLIdPCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddExternalSAMLIdPCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a Security Assertion Markup Language (SAML) signing certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to two SAML signing certificates.
        /// This topic provides an example on how to add a SAML signing certificate to the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddExternalSAMLIdPCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// AddExternalSAMLIdPCertificateResponse
        /// </returns>
        public async Task<AddExternalSAMLIdPCertificateResponse> AddExternalSAMLIdPCertificateAsync(AddExternalSAMLIdPCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddExternalSAMLIdPCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a policy to an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to add the system policy <c>AliyunECSFullAccess</c> to the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddPermissionPolicyToAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddPermissionPolicyToAccessConfigurationResponse
        /// </returns>
        public AddPermissionPolicyToAccessConfigurationResponse AddPermissionPolicyToAccessConfigurationWithOptions(AddPermissionPolicyToAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InlinePolicyDocument))
            {
                query["InlinePolicyDocument"] = request.InlinePolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionPolicyName))
            {
                query["PermissionPolicyName"] = request.PermissionPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionPolicyType))
            {
                query["PermissionPolicyType"] = request.PermissionPolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPermissionPolicyToAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPermissionPolicyToAccessConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a policy to an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to add the system policy <c>AliyunECSFullAccess</c> to the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddPermissionPolicyToAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddPermissionPolicyToAccessConfigurationResponse
        /// </returns>
        public async Task<AddPermissionPolicyToAccessConfigurationResponse> AddPermissionPolicyToAccessConfigurationWithOptionsAsync(AddPermissionPolicyToAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InlinePolicyDocument))
            {
                query["InlinePolicyDocument"] = request.InlinePolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionPolicyName))
            {
                query["PermissionPolicyName"] = request.PermissionPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionPolicyType))
            {
                query["PermissionPolicyType"] = request.PermissionPolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddPermissionPolicyToAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPermissionPolicyToAccessConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a policy to an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to add the system policy <c>AliyunECSFullAccess</c> to the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddPermissionPolicyToAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// AddPermissionPolicyToAccessConfigurationResponse
        /// </returns>
        public AddPermissionPolicyToAccessConfigurationResponse AddPermissionPolicyToAccessConfiguration(AddPermissionPolicyToAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPermissionPolicyToAccessConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a policy to an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to add the system policy <c>AliyunECSFullAccess</c> to the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddPermissionPolicyToAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// AddPermissionPolicyToAccessConfigurationResponse
        /// </returns>
        public async Task<AddPermissionPolicyToAccessConfigurationResponse> AddPermissionPolicyToAccessConfigurationAsync(AddPermissionPolicyToAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPermissionPolicyToAccessConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot add a user to a group that is synchronized by using SCIM.
        /// This topic provides an example on how to add the user <c>u-00q8wbq42wiltcrk****</c> to the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddUserToGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserToGroupResponse
        /// </returns>
        public AddUserToGroupResponse AddUserToGroupWithOptions(AddUserToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
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
                Action = "AddUserToGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot add a user to a group that is synchronized by using SCIM.
        /// This topic provides an example on how to add the user <c>u-00q8wbq42wiltcrk****</c> to the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddUserToGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserToGroupResponse
        /// </returns>
        public async Task<AddUserToGroupResponse> AddUserToGroupWithOptionsAsync(AddUserToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
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
                Action = "AddUserToGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot add a user to a group that is synchronized by using SCIM.
        /// This topic provides an example on how to add the user <c>u-00q8wbq42wiltcrk****</c> to the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddUserToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserToGroupResponse
        /// </returns>
        public AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserToGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot add a user to a group that is synchronized by using SCIM.
        /// This topic provides an example on how to add the user <c>u-00q8wbq42wiltcrk****</c> to the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddUserToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserToGroupResponse
        /// </returns>
        public async Task<AddUserToGroupResponse> AddUserToGroupAsync(AddUserToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserToGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the configurations of a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If single sign-on (SSO) logon is disabled, you can clear the configurations of a SAML IdP. If SSO logon is enabled, you cannot clear the configurations.
        /// This topic provides an example on how to clear the configurations of the SAML IdP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ClearExternalSAMLIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearExternalSAMLIdentityProviderResponse
        /// </returns>
        public ClearExternalSAMLIdentityProviderResponse ClearExternalSAMLIdentityProviderWithOptions(ClearExternalSAMLIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearExternalSAMLIdentityProvider",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearExternalSAMLIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the configurations of a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If single sign-on (SSO) logon is disabled, you can clear the configurations of a SAML IdP. If SSO logon is enabled, you cannot clear the configurations.
        /// This topic provides an example on how to clear the configurations of the SAML IdP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ClearExternalSAMLIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearExternalSAMLIdentityProviderResponse
        /// </returns>
        public async Task<ClearExternalSAMLIdentityProviderResponse> ClearExternalSAMLIdentityProviderWithOptionsAsync(ClearExternalSAMLIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearExternalSAMLIdentityProvider",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearExternalSAMLIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the configurations of a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If single sign-on (SSO) logon is disabled, you can clear the configurations of a SAML IdP. If SSO logon is enabled, you cannot clear the configurations.
        /// This topic provides an example on how to clear the configurations of the SAML IdP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ClearExternalSAMLIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearExternalSAMLIdentityProviderResponse
        /// </returns>
        public ClearExternalSAMLIdentityProviderResponse ClearExternalSAMLIdentityProvider(ClearExternalSAMLIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearExternalSAMLIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clears the configurations of a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If single sign-on (SSO) logon is disabled, you can clear the configurations of a SAML IdP. If SSO logon is enabled, you cannot clear the configurations.
        /// This topic provides an example on how to clear the configurations of the SAML IdP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ClearExternalSAMLIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearExternalSAMLIdentityProviderResponse
        /// </returns>
        public async Task<ClearExternalSAMLIdentityProviderResponse> ClearExternalSAMLIdentityProviderAsync(ClearExternalSAMLIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearExternalSAMLIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns access permissions on an account in your resource directory to a user or a group by using an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// For more information about how to assign permissions on an account in your resource directory, see <a href="https://help.aliyun.com/document_detail/266726.html">Overview of multi-account authorization</a>.
        /// This topic provides an example on how to assign access permissions on the account <c>114240524784****</c> in your resource directory to the CloudSSO user <c>u-00q8wbq42wiltcrk****</c> by using the access configuration <c>ac-00jhtfl8thteu6uj****</c>. After the call is successful, the CloudSSO user can access resources within the account in the resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessAssignmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessAssignmentResponse
        /// </returns>
        public CreateAccessAssignmentResponse CreateAccessAssignmentWithOptions(CreateAccessAssignmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessAssignment",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessAssignmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns access permissions on an account in your resource directory to a user or a group by using an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// For more information about how to assign permissions on an account in your resource directory, see <a href="https://help.aliyun.com/document_detail/266726.html">Overview of multi-account authorization</a>.
        /// This topic provides an example on how to assign access permissions on the account <c>114240524784****</c> in your resource directory to the CloudSSO user <c>u-00q8wbq42wiltcrk****</c> by using the access configuration <c>ac-00jhtfl8thteu6uj****</c>. After the call is successful, the CloudSSO user can access resources within the account in the resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessAssignmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessAssignmentResponse
        /// </returns>
        public async Task<CreateAccessAssignmentResponse> CreateAccessAssignmentWithOptionsAsync(CreateAccessAssignmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessAssignment",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessAssignmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns access permissions on an account in your resource directory to a user or a group by using an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// For more information about how to assign permissions on an account in your resource directory, see <a href="https://help.aliyun.com/document_detail/266726.html">Overview of multi-account authorization</a>.
        /// This topic provides an example on how to assign access permissions on the account <c>114240524784****</c> in your resource directory to the CloudSSO user <c>u-00q8wbq42wiltcrk****</c> by using the access configuration <c>ac-00jhtfl8thteu6uj****</c>. After the call is successful, the CloudSSO user can access resources within the account in the resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessAssignmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessAssignmentResponse
        /// </returns>
        public CreateAccessAssignmentResponse CreateAccessAssignment(CreateAccessAssignmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessAssignmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Assigns access permissions on an account in your resource directory to a user or a group by using an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// For more information about how to assign permissions on an account in your resource directory, see <a href="https://help.aliyun.com/document_detail/266726.html">Overview of multi-account authorization</a>.
        /// This topic provides an example on how to assign access permissions on the account <c>114240524784****</c> in your resource directory to the CloudSSO user <c>u-00q8wbq42wiltcrk****</c> by using the access configuration <c>ac-00jhtfl8thteu6uj****</c>. After the call is successful, the CloudSSO user can access resources within the account in the resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessAssignmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessAssignmentResponse
        /// </returns>
        public async Task<CreateAccessAssignmentResponse> CreateAccessAssignmentAsync(CreateAccessAssignmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessAssignmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about access configurations, see <a href="https://help.aliyun.com/document_detail/266737.html">Overview of access configurations</a>.
        /// This topic provides an example on how to create an access configuration named <c>ECS-Admin</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessConfigurationResponse
        /// </returns>
        public CreateAccessConfigurationResponse CreateAccessConfigurationWithOptions(CreateAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationName))
            {
                query["AccessConfigurationName"] = request.AccessConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelayState))
            {
                query["RelayState"] = request.RelayState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionDuration))
            {
                query["SessionDuration"] = request.SessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about access configurations, see <a href="https://help.aliyun.com/document_detail/266737.html">Overview of access configurations</a>.
        /// This topic provides an example on how to create an access configuration named <c>ECS-Admin</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessConfigurationResponse
        /// </returns>
        public async Task<CreateAccessConfigurationResponse> CreateAccessConfigurationWithOptionsAsync(CreateAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationName))
            {
                query["AccessConfigurationName"] = request.AccessConfigurationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelayState))
            {
                query["RelayState"] = request.RelayState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionDuration))
            {
                query["SessionDuration"] = request.SessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about access configurations, see <a href="https://help.aliyun.com/document_detail/266737.html">Overview of access configurations</a>.
        /// This topic provides an example on how to create an access configuration named <c>ECS-Admin</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessConfigurationResponse
        /// </returns>
        public CreateAccessConfigurationResponse CreateAccessConfiguration(CreateAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about access configurations, see <a href="https://help.aliyun.com/document_detail/266737.html">Overview of access configurations</a>.
        /// This topic provides an example on how to create an access configuration named <c>ECS-Admin</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessConfigurationResponse
        /// </returns>
        public async Task<CreateAccessConfigurationResponse> CreateAccessConfigurationAsync(CreateAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>A directory is a CloudSSO instance. Before you can use CloudSSO, you must create a directory. The directory is used to manage all CloudSSO resources.
        /// To create a directory, you must select a region. Alibaba Cloud stores data in the directory only in the region that you select. However, you can deploy Alibaba Cloud resources including Elastic Compute Service (ECS) instances and ApsaraDB RDS instances in other regions. You can also use your cloud account for logons and access the Alibaba Cloud resources in other regions. You can select a region to create a directory based on your security compliance requirements and the geographic location of specific users. If you do not have strict security compliance requirements, we recommend that you select a region that is the closest to the geographical location of the specific users. This way, access to cloud resources is accelerated. You can create the CloudSSO directory in the China (Shanghai), China (Hong Kong), US (Silicon Valley), or Germany (Frankfurt) region.
        /// This topic provides an example on how to create a directory named <c>example</c> in the China (Shanghai) region.</para>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>You can create only one directory for a management account.</description></item>
        /// <item><description>If you want to change the region of a directory, you must delete the directory and then create a directory in a different region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDirectoryResponse
        /// </returns>
        public CreateDirectoryResponse CreateDirectoryWithOptions(CreateDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryName))
            {
                query["DirectoryName"] = request.DirectoryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDirectory",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>A directory is a CloudSSO instance. Before you can use CloudSSO, you must create a directory. The directory is used to manage all CloudSSO resources.
        /// To create a directory, you must select a region. Alibaba Cloud stores data in the directory only in the region that you select. However, you can deploy Alibaba Cloud resources including Elastic Compute Service (ECS) instances and ApsaraDB RDS instances in other regions. You can also use your cloud account for logons and access the Alibaba Cloud resources in other regions. You can select a region to create a directory based on your security compliance requirements and the geographic location of specific users. If you do not have strict security compliance requirements, we recommend that you select a region that is the closest to the geographical location of the specific users. This way, access to cloud resources is accelerated. You can create the CloudSSO directory in the China (Shanghai), China (Hong Kong), US (Silicon Valley), or Germany (Frankfurt) region.
        /// This topic provides an example on how to create a directory named <c>example</c> in the China (Shanghai) region.</para>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>You can create only one directory for a management account.</description></item>
        /// <item><description>If you want to change the region of a directory, you must delete the directory and then create a directory in a different region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDirectoryResponse
        /// </returns>
        public async Task<CreateDirectoryResponse> CreateDirectoryWithOptionsAsync(CreateDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryName))
            {
                query["DirectoryName"] = request.DirectoryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDirectory",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>A directory is a CloudSSO instance. Before you can use CloudSSO, you must create a directory. The directory is used to manage all CloudSSO resources.
        /// To create a directory, you must select a region. Alibaba Cloud stores data in the directory only in the region that you select. However, you can deploy Alibaba Cloud resources including Elastic Compute Service (ECS) instances and ApsaraDB RDS instances in other regions. You can also use your cloud account for logons and access the Alibaba Cloud resources in other regions. You can select a region to create a directory based on your security compliance requirements and the geographic location of specific users. If you do not have strict security compliance requirements, we recommend that you select a region that is the closest to the geographical location of the specific users. This way, access to cloud resources is accelerated. You can create the CloudSSO directory in the China (Shanghai), China (Hong Kong), US (Silicon Valley), or Germany (Frankfurt) region.
        /// This topic provides an example on how to create a directory named <c>example</c> in the China (Shanghai) region.</para>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>You can create only one directory for a management account.</description></item>
        /// <item><description>If you want to change the region of a directory, you must delete the directory and then create a directory in a different region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDirectoryResponse
        /// </returns>
        public CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDirectoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>A directory is a CloudSSO instance. Before you can use CloudSSO, you must create a directory. The directory is used to manage all CloudSSO resources.
        /// To create a directory, you must select a region. Alibaba Cloud stores data in the directory only in the region that you select. However, you can deploy Alibaba Cloud resources including Elastic Compute Service (ECS) instances and ApsaraDB RDS instances in other regions. You can also use your cloud account for logons and access the Alibaba Cloud resources in other regions. You can select a region to create a directory based on your security compliance requirements and the geographic location of specific users. If you do not have strict security compliance requirements, we recommend that you select a region that is the closest to the geographical location of the specific users. This way, access to cloud resources is accelerated. You can create the CloudSSO directory in the China (Shanghai), China (Hong Kong), US (Silicon Valley), or Germany (Frankfurt) region.
        /// This topic provides an example on how to create a directory named <c>example</c> in the China (Shanghai) region.</para>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>You can create only one directory for a management account.</description></item>
        /// <item><description>If you want to change the region of a directory, you must delete the directory and then create a directory in a different region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDirectoryResponse
        /// </returns>
        public async Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDirectoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a group named <c>TestGroup</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a group named <c>TestGroup</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a group named <c>TestGroup</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a group named <c>TestGroup</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>SCIM credentials are required for SCIM synchronization. You can create up to two SCIM credentials.
        /// This topic provides an example on how to create a SCIM credential within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSCIMServerCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSCIMServerCredentialResponse
        /// </returns>
        public CreateSCIMServerCredentialResponse CreateSCIMServerCredentialWithOptions(CreateSCIMServerCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSCIMServerCredential",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSCIMServerCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>SCIM credentials are required for SCIM synchronization. You can create up to two SCIM credentials.
        /// This topic provides an example on how to create a SCIM credential within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSCIMServerCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSCIMServerCredentialResponse
        /// </returns>
        public async Task<CreateSCIMServerCredentialResponse> CreateSCIMServerCredentialWithOptionsAsync(CreateSCIMServerCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSCIMServerCredential",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSCIMServerCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>SCIM credentials are required for SCIM synchronization. You can create up to two SCIM credentials.
        /// This topic provides an example on how to create a SCIM credential within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSCIMServerCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSCIMServerCredentialResponse
        /// </returns>
        public CreateSCIMServerCredentialResponse CreateSCIMServerCredential(CreateSCIMServerCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSCIMServerCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>SCIM credentials are required for SCIM synchronization. You can create up to two SCIM credentials.
        /// This topic provides an example on how to create a SCIM credential within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSCIMServerCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSCIMServerCredentialResponse
        /// </returns>
        public async Task<CreateSCIMServerCredentialResponse> CreateSCIMServerCredentialAsync(CreateSCIMServerCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSCIMServerCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a user named <c>Alice</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstName))
            {
                query["FirstName"] = request.FirstName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastName))
            {
                query["LastName"] = request.LastName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a user named <c>Alice</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstName))
            {
                query["FirstName"] = request.FirstName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastName))
            {
                query["LastName"] = request.LastName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a user named <c>Alice</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a user named <c>Alice</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a RAM user provisioning for a member in your resource directory to create a RAM user that has the same username as a CloudSSO user. This way, the CloudSSO user can access the resources of the member as the RAM user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserProvisioningRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserProvisioningResponse
        /// </returns>
        public CreateUserProvisioningResponse CreateUserProvisioningWithOptions(CreateUserProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionStrategy))
            {
                query["DeletionStrategy"] = request.DeletionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationStrategy))
            {
                query["DuplicationStrategy"] = request.DuplicationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserProvisioning",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserProvisioningResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a RAM user provisioning for a member in your resource directory to create a RAM user that has the same username as a CloudSSO user. This way, the CloudSSO user can access the resources of the member as the RAM user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserProvisioningRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserProvisioningResponse
        /// </returns>
        public async Task<CreateUserProvisioningResponse> CreateUserProvisioningWithOptionsAsync(CreateUserProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionStrategy))
            {
                query["DeletionStrategy"] = request.DeletionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationStrategy))
            {
                query["DuplicationStrategy"] = request.DuplicationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserProvisioning",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserProvisioningResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a RAM user provisioning for a member in your resource directory to create a RAM user that has the same username as a CloudSSO user. This way, the CloudSSO user can access the resources of the member as the RAM user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserProvisioningRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserProvisioningResponse
        /// </returns>
        public CreateUserProvisioningResponse CreateUserProvisioning(CreateUserProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserProvisioningWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create a RAM user provisioning for a member in your resource directory to create a RAM user that has the same username as a CloudSSO user. This way, the CloudSSO user can access the resources of the member as the RAM user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserProvisioningRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserProvisioningResponse
        /// </returns>
        public async Task<CreateUserProvisioningResponse> CreateUserProvisioningAsync(CreateUserProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserProvisioningWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the access permissions on an account in a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to remove the access permissions on the account <c>114240524784****</c> in the resource directory from the CloudSSO user <c>u-00q8wbq42wiltcrk****</c>. The access permissions are assigned by using the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessAssignmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessAssignmentResponse
        /// </returns>
        public DeleteAccessAssignmentResponse DeleteAccessAssignmentWithOptions(DeleteAccessAssignmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeprovisionStrategy))
            {
                query["DeprovisionStrategy"] = request.DeprovisionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessAssignment",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessAssignmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the access permissions on an account in a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to remove the access permissions on the account <c>114240524784****</c> in the resource directory from the CloudSSO user <c>u-00q8wbq42wiltcrk****</c>. The access permissions are assigned by using the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessAssignmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessAssignmentResponse
        /// </returns>
        public async Task<DeleteAccessAssignmentResponse> DeleteAccessAssignmentWithOptionsAsync(DeleteAccessAssignmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeprovisionStrategy))
            {
                query["DeprovisionStrategy"] = request.DeprovisionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessAssignment",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessAssignmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the access permissions on an account in a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to remove the access permissions on the account <c>114240524784****</c> in the resource directory from the CloudSSO user <c>u-00q8wbq42wiltcrk****</c>. The access permissions are assigned by using the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessAssignmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessAssignmentResponse
        /// </returns>
        public DeleteAccessAssignmentResponse DeleteAccessAssignment(DeleteAccessAssignmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessAssignmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the access permissions on an account in a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to remove the access permissions on the account <c>114240524784****</c> in the resource directory from the CloudSSO user <c>u-00q8wbq42wiltcrk****</c>. The access permissions are assigned by using the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessAssignmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessAssignmentResponse
        /// </returns>
        public async Task<DeleteAccessAssignmentResponse> DeleteAccessAssignmentAsync(DeleteAccessAssignmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessAssignmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>The access configuration that you want to delete is de-provisioned from the accounts in your resource directory. For more information, see <a href="https://help.aliyun.com/document_detail/338352.html">DeprovisionAccessConfiguration</a>.</para>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to delete the access configuration whose ID is <c>ac-001j9mcm3k7335bc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessConfigurationResponse
        /// </returns>
        public DeleteAccessConfigurationResponse DeleteAccessConfigurationWithOptions(DeleteAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceRemovePermissionPolicies))
            {
                query["ForceRemovePermissionPolicies"] = request.ForceRemovePermissionPolicies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>The access configuration that you want to delete is de-provisioned from the accounts in your resource directory. For more information, see <a href="https://help.aliyun.com/document_detail/338352.html">DeprovisionAccessConfiguration</a>.</para>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to delete the access configuration whose ID is <c>ac-001j9mcm3k7335bc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessConfigurationResponse
        /// </returns>
        public async Task<DeleteAccessConfigurationResponse> DeleteAccessConfigurationWithOptionsAsync(DeleteAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceRemovePermissionPolicies))
            {
                query["ForceRemovePermissionPolicies"] = request.ForceRemovePermissionPolicies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>The access configuration that you want to delete is de-provisioned from the accounts in your resource directory. For more information, see <a href="https://help.aliyun.com/document_detail/338352.html">DeprovisionAccessConfiguration</a>.</para>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to delete the access configuration whose ID is <c>ac-001j9mcm3k7335bc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessConfigurationResponse
        /// </returns>
        public DeleteAccessConfigurationResponse DeleteAccessConfiguration(DeleteAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>The access configuration that you want to delete is de-provisioned from the accounts in your resource directory. For more information, see <a href="https://help.aliyun.com/document_detail/338352.html">DeprovisionAccessConfiguration</a>.</para>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to delete the access configuration whose ID is <c>ac-001j9mcm3k7335bc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessConfigurationResponse
        /// </returns>
        public async Task<DeleteAccessConfigurationResponse> DeleteAccessConfigurationAsync(DeleteAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>No resources are contained in the directory that you want to delete.</para>
        /// <list type="bullet">
        /// <item><description>Access permissions on the accounts in your resource directory are removed from all users and groups. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// <item><description>Users are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341671.html">DeleteUser</a>.</description></item>
        /// <item><description>Groups are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341821.html">DeleteGroup</a>.</description></item>
        /// <item><description>Access configurations are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/336907.html">DeleteAccessConfiguration</a>.</description></item>
        /// <item><description>System for Cross-domain Identity Management (SCIM) credentials are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341842.html">DeleteSCIMServerCredential</a>.</description></item>
        /// <item><description>Single sign-on (SSO) logon configurations are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341573.html">ClearExternalSAMLIdentityProvider</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to delete a directory whose ID is <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirectoryResponse
        /// </returns>
        public DeleteDirectoryResponse DeleteDirectoryWithOptions(DeleteDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDirectory",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>No resources are contained in the directory that you want to delete.</para>
        /// <list type="bullet">
        /// <item><description>Access permissions on the accounts in your resource directory are removed from all users and groups. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// <item><description>Users are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341671.html">DeleteUser</a>.</description></item>
        /// <item><description>Groups are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341821.html">DeleteGroup</a>.</description></item>
        /// <item><description>Access configurations are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/336907.html">DeleteAccessConfiguration</a>.</description></item>
        /// <item><description>System for Cross-domain Identity Management (SCIM) credentials are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341842.html">DeleteSCIMServerCredential</a>.</description></item>
        /// <item><description>Single sign-on (SSO) logon configurations are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341573.html">ClearExternalSAMLIdentityProvider</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to delete a directory whose ID is <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirectoryResponse
        /// </returns>
        public async Task<DeleteDirectoryResponse> DeleteDirectoryWithOptionsAsync(DeleteDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDirectory",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>No resources are contained in the directory that you want to delete.</para>
        /// <list type="bullet">
        /// <item><description>Access permissions on the accounts in your resource directory are removed from all users and groups. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// <item><description>Users are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341671.html">DeleteUser</a>.</description></item>
        /// <item><description>Groups are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341821.html">DeleteGroup</a>.</description></item>
        /// <item><description>Access configurations are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/336907.html">DeleteAccessConfiguration</a>.</description></item>
        /// <item><description>System for Cross-domain Identity Management (SCIM) credentials are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341842.html">DeleteSCIMServerCredential</a>.</description></item>
        /// <item><description>Single sign-on (SSO) logon configurations are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341573.html">ClearExternalSAMLIdentityProvider</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to delete a directory whose ID is <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirectoryResponse
        /// </returns>
        public DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDirectoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>No resources are contained in the directory that you want to delete.</para>
        /// <list type="bullet">
        /// <item><description>Access permissions on the accounts in your resource directory are removed from all users and groups. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// <item><description>Users are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341671.html">DeleteUser</a>.</description></item>
        /// <item><description>Groups are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341821.html">DeleteGroup</a>.</description></item>
        /// <item><description>Access configurations are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/336907.html">DeleteAccessConfiguration</a>.</description></item>
        /// <item><description>System for Cross-domain Identity Management (SCIM) credentials are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341842.html">DeleteSCIMServerCredential</a>.</description></item>
        /// <item><description>Single sign-on (SSO) logon configurations are deleted. For more information, see <a href="https://help.aliyun.com/document_detail/341573.html">ClearExternalSAMLIdentityProvider</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to delete a directory whose ID is <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDirectoryResponse
        /// </returns>
        public async Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDirectoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>The group that you want to delete is not associated with the following resources. If the group is associated with the resources, the deletion fails.</para>
        /// <list type="bullet">
        /// <item><description>Users: You must remove users from the group. For more information, see <a href="https://help.aliyun.com/document_detail/335116.html">RemoveUserFromGroup</a>.</description></item>
        /// <item><description>Access permissions: You must remove the access permissions on the accounts in your resource directory from the group. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot delete a group that is synchronized by using SCIM.
        /// This topic provides an example on how to delete the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public DeleteGroupResponse DeleteGroupWithOptions(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>The group that you want to delete is not associated with the following resources. If the group is associated with the resources, the deletion fails.</para>
        /// <list type="bullet">
        /// <item><description>Users: You must remove users from the group. For more information, see <a href="https://help.aliyun.com/document_detail/335116.html">RemoveUserFromGroup</a>.</description></item>
        /// <item><description>Access permissions: You must remove the access permissions on the accounts in your resource directory from the group. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot delete a group that is synchronized by using SCIM.
        /// This topic provides an example on how to delete the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public async Task<DeleteGroupResponse> DeleteGroupWithOptionsAsync(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>The group that you want to delete is not associated with the following resources. If the group is associated with the resources, the deletion fails.</para>
        /// <list type="bullet">
        /// <item><description>Users: You must remove users from the group. For more information, see <a href="https://help.aliyun.com/document_detail/335116.html">RemoveUserFromGroup</a>.</description></item>
        /// <item><description>Access permissions: You must remove the access permissions on the accounts in your resource directory from the group. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot delete a group that is synchronized by using SCIM.
        /// This topic provides an example on how to delete the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>The group that you want to delete is not associated with the following resources. If the group is associated with the resources, the deletion fails.</para>
        /// <list type="bullet">
        /// <item><description>Users: You must remove users from the group. For more information, see <a href="https://help.aliyun.com/document_detail/335116.html">RemoveUserFromGroup</a>.</description></item>
        /// <item><description>Access permissions: You must remove the access permissions on the accounts in your resource directory from the group. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot delete a group that is synchronized by using SCIM.
        /// This topic provides an example on how to delete the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public async Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a multi-factor authentication (MFA) device from a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to unbind the MFA device whose ID is <c>mfa-00ujhet8pycljj7j****</c> from the user whose ID is <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMFADeviceForUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMFADeviceForUserResponse
        /// </returns>
        public DeleteMFADeviceForUserResponse DeleteMFADeviceForUserWithOptions(DeleteMFADeviceForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFADeviceId))
            {
                query["MFADeviceId"] = request.MFADeviceId;
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
                Action = "DeleteMFADeviceForUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMFADeviceForUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a multi-factor authentication (MFA) device from a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to unbind the MFA device whose ID is <c>mfa-00ujhet8pycljj7j****</c> from the user whose ID is <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMFADeviceForUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMFADeviceForUserResponse
        /// </returns>
        public async Task<DeleteMFADeviceForUserResponse> DeleteMFADeviceForUserWithOptionsAsync(DeleteMFADeviceForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFADeviceId))
            {
                query["MFADeviceId"] = request.MFADeviceId;
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
                Action = "DeleteMFADeviceForUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMFADeviceForUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a multi-factor authentication (MFA) device from a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to unbind the MFA device whose ID is <c>mfa-00ujhet8pycljj7j****</c> from the user whose ID is <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMFADeviceForUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMFADeviceForUserResponse
        /// </returns>
        public DeleteMFADeviceForUserResponse DeleteMFADeviceForUser(DeleteMFADeviceForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMFADeviceForUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a multi-factor authentication (MFA) device from a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to unbind the MFA device whose ID is <c>mfa-00ujhet8pycljj7j****</c> from the user whose ID is <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMFADeviceForUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMFADeviceForUserResponse
        /// </returns>
        public async Task<DeleteMFADeviceForUserResponse> DeleteMFADeviceForUserAsync(DeleteMFADeviceForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMFADeviceForUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a SCIM credential is deleted, the synchronization task that uses the SCIM credential fails.
        /// This topic provides an example on how to delete the SCIM credential whose ID is <c>scimcred-004whl0kvfwcypbi****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSCIMServerCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSCIMServerCredentialResponse
        /// </returns>
        public DeleteSCIMServerCredentialResponse DeleteSCIMServerCredentialWithOptions(DeleteSCIMServerCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialId))
            {
                query["CredentialId"] = request.CredentialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSCIMServerCredential",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSCIMServerCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a SCIM credential is deleted, the synchronization task that uses the SCIM credential fails.
        /// This topic provides an example on how to delete the SCIM credential whose ID is <c>scimcred-004whl0kvfwcypbi****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSCIMServerCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSCIMServerCredentialResponse
        /// </returns>
        public async Task<DeleteSCIMServerCredentialResponse> DeleteSCIMServerCredentialWithOptionsAsync(DeleteSCIMServerCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialId))
            {
                query["CredentialId"] = request.CredentialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSCIMServerCredential",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSCIMServerCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a SCIM credential is deleted, the synchronization task that uses the SCIM credential fails.
        /// This topic provides an example on how to delete the SCIM credential whose ID is <c>scimcred-004whl0kvfwcypbi****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSCIMServerCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSCIMServerCredentialResponse
        /// </returns>
        public DeleteSCIMServerCredentialResponse DeleteSCIMServerCredential(DeleteSCIMServerCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSCIMServerCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a SCIM credential is deleted, the synchronization task that uses the SCIM credential fails.
        /// This topic provides an example on how to delete the SCIM credential whose ID is <c>scimcred-004whl0kvfwcypbi****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSCIMServerCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSCIMServerCredentialResponse
        /// </returns>
        public async Task<DeleteSCIMServerCredentialResponse> DeleteSCIMServerCredentialAsync(DeleteSCIMServerCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSCIMServerCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>Before you delete a user, make sure that the user is not associated with the following resources. Otherwise, the deletion fails.</para>
        /// <list type="bullet">
        /// <item><description>Multi-factor authentication (MFA) devices: You must delete the MFA devices bound to the user. For more information, see <a href="https://help.aliyun.com/document_detail/341675.html">DeleteMFADeviceForUser</a>.</description></item>
        /// <item><description>Access permissions: You must remove the access permissions on the accounts in your resource directory from the user. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// <item><description>Groups: You must remove the user from groups. For more information, see <a href="https://help.aliyun.com/document_detail/335116.html">RemoveUserFromGroup</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot delete a user that is synchronized by using SCIM.
        /// This topic provides an example on how to delete the user whose ID is <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
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
                Action = "DeleteUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>Before you delete a user, make sure that the user is not associated with the following resources. Otherwise, the deletion fails.</para>
        /// <list type="bullet">
        /// <item><description>Multi-factor authentication (MFA) devices: You must delete the MFA devices bound to the user. For more information, see <a href="https://help.aliyun.com/document_detail/341675.html">DeleteMFADeviceForUser</a>.</description></item>
        /// <item><description>Access permissions: You must remove the access permissions on the accounts in your resource directory from the user. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// <item><description>Groups: You must remove the user from groups. For more information, see <a href="https://help.aliyun.com/document_detail/335116.html">RemoveUserFromGroup</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot delete a user that is synchronized by using SCIM.
        /// This topic provides an example on how to delete the user whose ID is <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
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
                Action = "DeleteUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>Before you delete a user, make sure that the user is not associated with the following resources. Otherwise, the deletion fails.</para>
        /// <list type="bullet">
        /// <item><description>Multi-factor authentication (MFA) devices: You must delete the MFA devices bound to the user. For more information, see <a href="https://help.aliyun.com/document_detail/341675.html">DeleteMFADeviceForUser</a>.</description></item>
        /// <item><description>Access permissions: You must remove the access permissions on the accounts in your resource directory from the user. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// <item><description>Groups: You must remove the user from groups. For more information, see <a href="https://help.aliyun.com/document_detail/335116.html">RemoveUserFromGroup</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot delete a user that is synchronized by using SCIM.
        /// This topic provides an example on how to delete the user whose ID is <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>Before you delete a user, make sure that the user is not associated with the following resources. Otherwise, the deletion fails.</para>
        /// <list type="bullet">
        /// <item><description>Multi-factor authentication (MFA) devices: You must delete the MFA devices bound to the user. For more information, see <a href="https://help.aliyun.com/document_detail/341675.html">DeleteMFADeviceForUser</a>.</description></item>
        /// <item><description>Access permissions: You must remove the access permissions on the accounts in your resource directory from the user. For more information, see <a href="https://help.aliyun.com/document_detail/338350.html">DeleteAccessAssignment</a>.</description></item>
        /// <item><description>Groups: You must remove the user from groups. For more information, see <a href="https://help.aliyun.com/document_detail/335116.html">RemoveUserFromGroup</a>.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot delete a user that is synchronized by using SCIM.
        /// This topic provides an example on how to delete the user whose ID is <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserProvisioningRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserProvisioningResponse
        /// </returns>
        public DeleteUserProvisioningResponse DeleteUserProvisioningWithOptions(DeleteUserProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionStrategy))
            {
                query["DeletionStrategy"] = request.DeletionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserProvisioning",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserProvisioningResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserProvisioningRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserProvisioningResponse
        /// </returns>
        public async Task<DeleteUserProvisioningResponse> DeleteUserProvisioningWithOptionsAsync(DeleteUserProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionStrategy))
            {
                query["DeletionStrategy"] = request.DeletionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserProvisioning",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserProvisioningResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserProvisioningRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserProvisioningResponse
        /// </returns>
        public DeleteUserProvisioningResponse DeleteUserProvisioning(DeleteUserProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserProvisioningWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserProvisioningRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserProvisioningResponse
        /// </returns>
        public async Task<DeleteUserProvisioningResponse> DeleteUserProvisioningAsync(DeleteUserProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserProvisioningWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Resource Access Management (RAM) user provisioning event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserProvisioningEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserProvisioningEventResponse
        /// </returns>
        public DeleteUserProvisioningEventResponse DeleteUserProvisioningEventWithOptions(DeleteUserProvisioningEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserProvisioningEvent",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserProvisioningEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Resource Access Management (RAM) user provisioning event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserProvisioningEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserProvisioningEventResponse
        /// </returns>
        public async Task<DeleteUserProvisioningEventResponse> DeleteUserProvisioningEventWithOptionsAsync(DeleteUserProvisioningEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserProvisioningEvent",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserProvisioningEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Resource Access Management (RAM) user provisioning event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserProvisioningEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserProvisioningEventResponse
        /// </returns>
        public DeleteUserProvisioningEventResponse DeleteUserProvisioningEvent(DeleteUserProvisioningEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserProvisioningEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Resource Access Management (RAM) user provisioning event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserProvisioningEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserProvisioningEventResponse
        /// </returns>
        public async Task<DeleteUserProvisioningEventResponse> DeleteUserProvisioningEventAsync(DeleteUserProvisioningEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserProvisioningEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>De-provisions an access configuration from an account in your resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is automatically created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to de-provision the access configuration <c>ac-00jhtfl8thteu6uj****</c> from the account <c>114240524784****</c> in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeprovisionAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionAccessConfigurationResponse
        /// </returns>
        public DeprovisionAccessConfigurationResponse DeprovisionAccessConfigurationWithOptions(DeprovisionAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeprovisionAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeprovisionAccessConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>De-provisions an access configuration from an account in your resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is automatically created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to de-provision the access configuration <c>ac-00jhtfl8thteu6uj****</c> from the account <c>114240524784****</c> in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeprovisionAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionAccessConfigurationResponse
        /// </returns>
        public async Task<DeprovisionAccessConfigurationResponse> DeprovisionAccessConfigurationWithOptionsAsync(DeprovisionAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeprovisionAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeprovisionAccessConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>De-provisions an access configuration from an account in your resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is automatically created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to de-provision the access configuration <c>ac-00jhtfl8thteu6uj****</c> from the account <c>114240524784****</c> in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeprovisionAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionAccessConfigurationResponse
        /// </returns>
        public DeprovisionAccessConfigurationResponse DeprovisionAccessConfiguration(DeprovisionAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeprovisionAccessConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>De-provisions an access configuration from an account in your resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is automatically created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to de-provision the access configuration <c>ac-00jhtfl8thteu6uj****</c> from the account <c>114240524784****</c> in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeprovisionAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionAccessConfigurationResponse
        /// </returns>
        public async Task<DeprovisionAccessConfigurationResponse> DeprovisionAccessConfigurationAsync(DeprovisionAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeprovisionAccessConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the delegated administrator account of CloudSSO.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDelegateAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDelegateAccountResponse
        /// </returns>
        public DisableDelegateAccountResponse DisableDelegateAccountWithOptions(DisableDelegateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableDelegateAccount",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDelegateAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the delegated administrator account of CloudSSO.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDelegateAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDelegateAccountResponse
        /// </returns>
        public async Task<DisableDelegateAccountResponse> DisableDelegateAccountWithOptionsAsync(DisableDelegateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableDelegateAccount",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDelegateAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the delegated administrator account of CloudSSO.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDelegateAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDelegateAccountResponse
        /// </returns>
        public DisableDelegateAccountResponse DisableDelegateAccount(DisableDelegateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDelegateAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the delegated administrator account of CloudSSO.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableDelegateAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDelegateAccountResponse
        /// </returns>
        public async Task<DisableDelegateAccountResponse> DisableDelegateAccountAsync(DisableDelegateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDelegateAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If your CloudSSO has no directory, you can disable CloudSSO based on your business requirements. After you disable CloudSSO, you can enable it at any time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableServiceResponse
        /// </returns>
        public DisableServiceResponse DisableServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableService",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If your CloudSSO has no directory, you can disable CloudSSO based on your business requirements. After you disable CloudSSO, you can enable it at any time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableServiceResponse
        /// </returns>
        public async Task<DisableServiceResponse> DisableServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableService",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If your CloudSSO has no directory, you can disable CloudSSO based on your business requirements. After you disable CloudSSO, you can enable it at any time.</para>
        /// </description>
        /// 
        /// <returns>
        /// DisableServiceResponse
        /// </returns>
        public DisableServiceResponse DisableService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableServiceWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If your CloudSSO has no directory, you can disable CloudSSO based on your business requirements. After you disable CloudSSO, you can enable it at any time.</para>
        /// </description>
        /// 
        /// <returns>
        /// DisableServiceResponse
        /// </returns>
        public async Task<DisableServiceResponse> DisableServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableServiceWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the delegated administrator account of CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use the management account of a resource directory to specify a member of the resource directory as the delegated administrator account of CloudSSO. For more information, see <a href="https://help.aliyun.com/document_detail/208117.html">Add a delegated administrator account</a>.
        /// After the delegated administrator account of CloudSSO is specified, you can call this operation to enable the delegated administrator account of CloudSSO to manage CloudSSO resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableDelegateAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDelegateAccountResponse
        /// </returns>
        public EnableDelegateAccountResponse EnableDelegateAccountWithOptions(EnableDelegateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableDelegateAccount",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDelegateAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the delegated administrator account of CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use the management account of a resource directory to specify a member of the resource directory as the delegated administrator account of CloudSSO. For more information, see <a href="https://help.aliyun.com/document_detail/208117.html">Add a delegated administrator account</a>.
        /// After the delegated administrator account of CloudSSO is specified, you can call this operation to enable the delegated administrator account of CloudSSO to manage CloudSSO resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableDelegateAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDelegateAccountResponse
        /// </returns>
        public async Task<EnableDelegateAccountResponse> EnableDelegateAccountWithOptionsAsync(EnableDelegateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableDelegateAccount",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDelegateAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the delegated administrator account of CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use the management account of a resource directory to specify a member of the resource directory as the delegated administrator account of CloudSSO. For more information, see <a href="https://help.aliyun.com/document_detail/208117.html">Add a delegated administrator account</a>.
        /// After the delegated administrator account of CloudSSO is specified, you can call this operation to enable the delegated administrator account of CloudSSO to manage CloudSSO resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableDelegateAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDelegateAccountResponse
        /// </returns>
        public EnableDelegateAccountResponse EnableDelegateAccount(EnableDelegateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDelegateAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the delegated administrator account of CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use the management account of a resource directory to specify a member of the resource directory as the delegated administrator account of CloudSSO. For more information, see <a href="https://help.aliyun.com/document_detail/208117.html">Add a delegated administrator account</a>.
        /// After the delegated administrator account of CloudSSO is specified, you can call this operation to enable the delegated administrator account of CloudSSO to manage CloudSSO resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableDelegateAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDelegateAccountResponse
        /// </returns>
        public async Task<EnableDelegateAccountResponse> EnableDelegateAccountAsync(EnableDelegateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDelegateAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation only if your account belongs to the management account that is used to enable a resource directory and has the permissions to enable CloudSSO. For more information, see <a href="https://help.aliyun.com/document_detail/262819.html">Enable CloudSSO</a>.
        /// If you call this operation, you agree to the <a href="https://www.alibabacloud.com/help/doc-detail/42416.htm">Alibaba Cloud International Website Product Terms of Service</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableServiceResponse
        /// </returns>
        public EnableServiceResponse EnableServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableService",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation only if your account belongs to the management account that is used to enable a resource directory and has the permissions to enable CloudSSO. For more information, see <a href="https://help.aliyun.com/document_detail/262819.html">Enable CloudSSO</a>.
        /// If you call this operation, you agree to the <a href="https://www.alibabacloud.com/help/doc-detail/42416.htm">Alibaba Cloud International Website Product Terms of Service</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableServiceResponse
        /// </returns>
        public async Task<EnableServiceResponse> EnableServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableService",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation only if your account belongs to the management account that is used to enable a resource directory and has the permissions to enable CloudSSO. For more information, see <a href="https://help.aliyun.com/document_detail/262819.html">Enable CloudSSO</a>.
        /// If you call this operation, you agree to the <a href="https://www.alibabacloud.com/help/doc-detail/42416.htm">Alibaba Cloud International Website Product Terms of Service</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// EnableServiceResponse
        /// </returns>
        public EnableServiceResponse EnableService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableServiceWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables CloudSSO.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation only if your account belongs to the management account that is used to enable a resource directory and has the permissions to enable CloudSSO. For more information, see <a href="https://help.aliyun.com/document_detail/262819.html">Enable CloudSSO</a>.
        /// If you call this operation, you agree to the <a href="https://www.alibabacloud.com/help/doc-detail/42416.htm">Alibaba Cloud International Website Product Terms of Service</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// EnableServiceResponse
        /// </returns>
        public async Task<EnableServiceResponse> EnableServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableServiceWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the access configuration whose ID is <c>ac-00ccule7tadaijxc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessConfigurationResponse
        /// </returns>
        public GetAccessConfigurationResponse GetAccessConfigurationWithOptions(GetAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the access configuration whose ID is <c>ac-00ccule7tadaijxc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessConfigurationResponse
        /// </returns>
        public async Task<GetAccessConfigurationResponse> GetAccessConfigurationWithOptionsAsync(GetAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the access configuration whose ID is <c>ac-00ccule7tadaijxc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessConfigurationResponse
        /// </returns>
        public GetAccessConfigurationResponse GetAccessConfiguration(GetAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the access configuration whose ID is <c>ac-00ccule7tadaijxc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessConfigurationResponse
        /// </returns>
        public async Task<GetAccessConfigurationResponse> GetAccessConfigurationAsync(GetAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the directory whose ID is <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryResponse
        /// </returns>
        public GetDirectoryResponse GetDirectoryWithOptions(GetDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDirectory",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the directory whose ID is <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryResponse
        /// </returns>
        public async Task<GetDirectoryResponse> GetDirectoryWithOptionsAsync(GetDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDirectory",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the directory whose ID is <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryResponse
        /// </returns>
        public GetDirectoryResponse GetDirectory(GetDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDirectoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the directory whose ID is <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryResponse
        /// </returns>
        public async Task<GetDirectoryResponse> GetDirectoryAsync(GetDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDirectoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a Security Assertion Markup Language (SAML) service provider (SP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During SAML 2.0-based single sign-on (SSO) logon, CloudSSO is an SP, and the identity management system of an enterprise is an identity provider (IdP).
        /// This topic provides an example on how to query information about the SP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectorySAMLServiceProviderInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDirectorySAMLServiceProviderInfoResponse
        /// </returns>
        public GetDirectorySAMLServiceProviderInfoResponse GetDirectorySAMLServiceProviderInfoWithOptions(GetDirectorySAMLServiceProviderInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDirectorySAMLServiceProviderInfo",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDirectorySAMLServiceProviderInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a Security Assertion Markup Language (SAML) service provider (SP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During SAML 2.0-based single sign-on (SSO) logon, CloudSSO is an SP, and the identity management system of an enterprise is an identity provider (IdP).
        /// This topic provides an example on how to query information about the SP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectorySAMLServiceProviderInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDirectorySAMLServiceProviderInfoResponse
        /// </returns>
        public async Task<GetDirectorySAMLServiceProviderInfoResponse> GetDirectorySAMLServiceProviderInfoWithOptionsAsync(GetDirectorySAMLServiceProviderInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDirectorySAMLServiceProviderInfo",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDirectorySAMLServiceProviderInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a Security Assertion Markup Language (SAML) service provider (SP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During SAML 2.0-based single sign-on (SSO) logon, CloudSSO is an SP, and the identity management system of an enterprise is an identity provider (IdP).
        /// This topic provides an example on how to query information about the SP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectorySAMLServiceProviderInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDirectorySAMLServiceProviderInfoResponse
        /// </returns>
        public GetDirectorySAMLServiceProviderInfoResponse GetDirectorySAMLServiceProviderInfo(GetDirectorySAMLServiceProviderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDirectorySAMLServiceProviderInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a Security Assertion Markup Language (SAML) service provider (SP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During SAML 2.0-based single sign-on (SSO) logon, CloudSSO is an SP, and the identity management system of an enterprise is an identity provider (IdP).
        /// This topic provides an example on how to query information about the SP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectorySAMLServiceProviderInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDirectorySAMLServiceProviderInfoResponse
        /// </returns>
        public async Task<GetDirectorySAMLServiceProviderInfoResponse> GetDirectorySAMLServiceProviderInfoAsync(GetDirectorySAMLServiceProviderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDirectorySAMLServiceProviderInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the statistics of a directory whose ID is <c>d-00fc2p61****</c>. The statistics include the number of users, quota for users, number of groups, quota for groups, number of access configurations, quota for access configurations, number of access permissions that are assigned, number of system policies that can be configured for an access configuration, number of System for Cross-domain Identity Management (SCIM) credentials, number of asynchronous tasks, status of single sign-on (SSO) logon, and status of SCIM synchronization.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryStatisticsResponse
        /// </returns>
        public GetDirectoryStatisticsResponse GetDirectoryStatisticsWithOptions(GetDirectoryStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDirectoryStatistics",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDirectoryStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the statistics of a directory whose ID is <c>d-00fc2p61****</c>. The statistics include the number of users, quota for users, number of groups, quota for groups, number of access configurations, quota for access configurations, number of access permissions that are assigned, number of system policies that can be configured for an access configuration, number of System for Cross-domain Identity Management (SCIM) credentials, number of asynchronous tasks, status of single sign-on (SSO) logon, and status of SCIM synchronization.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryStatisticsResponse
        /// </returns>
        public async Task<GetDirectoryStatisticsResponse> GetDirectoryStatisticsWithOptionsAsync(GetDirectoryStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDirectoryStatistics",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDirectoryStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the statistics of a directory whose ID is <c>d-00fc2p61****</c>. The statistics include the number of users, quota for users, number of groups, quota for groups, number of access configurations, quota for access configurations, number of access permissions that are assigned, number of system policies that can be configured for an access configuration, number of System for Cross-domain Identity Management (SCIM) credentials, number of asynchronous tasks, status of single sign-on (SSO) logon, and status of SCIM synchronization.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryStatisticsResponse
        /// </returns>
        public GetDirectoryStatisticsResponse GetDirectoryStatistics(GetDirectoryStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDirectoryStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the statistics of a directory whose ID is <c>d-00fc2p61****</c>. The statistics include the number of users, quota for users, number of groups, quota for groups, number of access configurations, quota for access configurations, number of access permissions that are assigned, number of system policies that can be configured for an access configuration, number of System for Cross-domain Identity Management (SCIM) credentials, number of asynchronous tasks, status of single sign-on (SSO) logon, and status of SCIM synchronization.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDirectoryStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDirectoryStatisticsResponse
        /// </returns>
        public async Task<GetDirectoryStatisticsResponse> GetDirectoryStatisticsAsync(GetDirectoryStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDirectoryStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the configurations of the SAML IdP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalSAMLIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExternalSAMLIdentityProviderResponse
        /// </returns>
        public GetExternalSAMLIdentityProviderResponse GetExternalSAMLIdentityProviderWithOptions(GetExternalSAMLIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExternalSAMLIdentityProvider",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExternalSAMLIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the configurations of the SAML IdP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalSAMLIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExternalSAMLIdentityProviderResponse
        /// </returns>
        public async Task<GetExternalSAMLIdentityProviderResponse> GetExternalSAMLIdentityProviderWithOptionsAsync(GetExternalSAMLIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExternalSAMLIdentityProvider",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExternalSAMLIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the configurations of the SAML IdP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalSAMLIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExternalSAMLIdentityProviderResponse
        /// </returns>
        public GetExternalSAMLIdentityProviderResponse GetExternalSAMLIdentityProvider(GetExternalSAMLIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExternalSAMLIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the configurations of the SAML IdP within the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalSAMLIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExternalSAMLIdentityProviderResponse
        /// </returns>
        public async Task<GetExternalSAMLIdentityProviderResponse> GetExternalSAMLIdentityProviderAsync(GetExternalSAMLIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExternalSAMLIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the group <c>g-00jqzghi2n3o5hkh****</c> in the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public GetGroupResponse GetGroupWithOptions(GetGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the group <c>g-00jqzghi2n3o5hkh****</c> in the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public async Task<GetGroupResponse> GetGroupWithOptionsAsync(GetGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the group <c>g-00jqzghi2n3o5hkh****</c> in the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public GetGroupResponse GetGroup(GetGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the group <c>g-00jqzghi2n3o5hkh****</c> in the directory <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public async Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logon preference of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoginPreferenceResponse
        /// </returns>
        public GetLoginPreferenceResponse GetLoginPreferenceWithOptions(GetLoginPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginPreference",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginPreferenceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logon preference of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoginPreferenceResponse
        /// </returns>
        public async Task<GetLoginPreferenceResponse> GetLoginPreferenceWithOptionsAsync(GetLoginPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginPreference",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginPreferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logon preference of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoginPreferenceResponse
        /// </returns>
        public GetLoginPreferenceResponse GetLoginPreference(GetLoginPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoginPreferenceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logon preference of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoginPreferenceResponse
        /// </returns>
        public async Task<GetLoginPreferenceResponse> GetLoginPreferenceAsync(GetLoginPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoginPreferenceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you enable username-password logon for CloudSSO users, you can query the MFA setting for the users.
        /// This topic provides an example on how to query the MFA setting of all CloudSSO users that belong to the directory named <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationSettingInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationSettingInfoResponse
        /// </returns>
        public GetMFAAuthenticationSettingInfoResponse GetMFAAuthenticationSettingInfoWithOptions(GetMFAAuthenticationSettingInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMFAAuthenticationSettingInfo",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMFAAuthenticationSettingInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you enable username-password logon for CloudSSO users, you can query the MFA setting for the users.
        /// This topic provides an example on how to query the MFA setting of all CloudSSO users that belong to the directory named <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationSettingInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationSettingInfoResponse
        /// </returns>
        public async Task<GetMFAAuthenticationSettingInfoResponse> GetMFAAuthenticationSettingInfoWithOptionsAsync(GetMFAAuthenticationSettingInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMFAAuthenticationSettingInfo",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMFAAuthenticationSettingInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you enable username-password logon for CloudSSO users, you can query the MFA setting for the users.
        /// This topic provides an example on how to query the MFA setting of all CloudSSO users that belong to the directory named <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationSettingInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationSettingInfoResponse
        /// </returns>
        public GetMFAAuthenticationSettingInfoResponse GetMFAAuthenticationSettingInfo(GetMFAAuthenticationSettingInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMFAAuthenticationSettingInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you enable username-password logon for CloudSSO users, you can query the MFA setting for the users.
        /// This topic provides an example on how to query the MFA setting of all CloudSSO users that belong to the directory named <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationSettingInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationSettingInfoResponse
        /// </returns>
        public async Task<GetMFAAuthenticationSettingInfoResponse> GetMFAAuthenticationSettingInfoAsync(GetMFAAuthenticationSettingInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMFAAuthenticationSettingInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation is no longer maintained and updated. You can call the <a href="https://help.aliyun.com/document_detail/611286.html">GetMFAAuthenticationSettingInfo</a> operation to query more detailed information.
        /// This topic provides an example on how to query the MFA setting of the users that belong to the directory named <c>d-00fc2p61****</c>. The returned result shows that MFA is enabled for all the users.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationSettingsResponse
        /// </returns>
        public GetMFAAuthenticationSettingsResponse GetMFAAuthenticationSettingsWithOptions(GetMFAAuthenticationSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMFAAuthenticationSettings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMFAAuthenticationSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation is no longer maintained and updated. You can call the <a href="https://help.aliyun.com/document_detail/611286.html">GetMFAAuthenticationSettingInfo</a> operation to query more detailed information.
        /// This topic provides an example on how to query the MFA setting of the users that belong to the directory named <c>d-00fc2p61****</c>. The returned result shows that MFA is enabled for all the users.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationSettingsResponse
        /// </returns>
        public async Task<GetMFAAuthenticationSettingsResponse> GetMFAAuthenticationSettingsWithOptionsAsync(GetMFAAuthenticationSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMFAAuthenticationSettings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMFAAuthenticationSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation is no longer maintained and updated. You can call the <a href="https://help.aliyun.com/document_detail/611286.html">GetMFAAuthenticationSettingInfo</a> operation to query more detailed information.
        /// This topic provides an example on how to query the MFA setting of the users that belong to the directory named <c>d-00fc2p61****</c>. The returned result shows that MFA is enabled for all the users.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationSettingsResponse
        /// </returns>
        public GetMFAAuthenticationSettingsResponse GetMFAAuthenticationSettings(GetMFAAuthenticationSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMFAAuthenticationSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation is no longer maintained and updated. You can call the <a href="https://help.aliyun.com/document_detail/611286.html">GetMFAAuthenticationSettingInfo</a> operation to query more detailed information.
        /// This topic provides an example on how to query the MFA setting of the users that belong to the directory named <c>d-00fc2p61****</c>. The returned result shows that MFA is enabled for all the users.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationSettingsResponse
        /// </returns>
        public async Task<GetMFAAuthenticationSettingsResponse> GetMFAAuthenticationSettingsAsync(GetMFAAuthenticationSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMFAAuthenticationSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether multi-factor authentication (MFA) is enabled for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to check whether MFA is enabled for users in the directory whose ID is <c>d-00fc2p61****</c>. The returned result shows that MFA is in the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationStatusResponse
        /// </returns>
        public GetMFAAuthenticationStatusResponse GetMFAAuthenticationStatusWithOptions(GetMFAAuthenticationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMFAAuthenticationStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMFAAuthenticationStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether multi-factor authentication (MFA) is enabled for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to check whether MFA is enabled for users in the directory whose ID is <c>d-00fc2p61****</c>. The returned result shows that MFA is in the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationStatusResponse
        /// </returns>
        public async Task<GetMFAAuthenticationStatusResponse> GetMFAAuthenticationStatusWithOptionsAsync(GetMFAAuthenticationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMFAAuthenticationStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMFAAuthenticationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether multi-factor authentication (MFA) is enabled for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to check whether MFA is enabled for users in the directory whose ID is <c>d-00fc2p61****</c>. The returned result shows that MFA is in the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationStatusResponse
        /// </returns>
        public GetMFAAuthenticationStatusResponse GetMFAAuthenticationStatus(GetMFAAuthenticationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMFAAuthenticationStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether multi-factor authentication (MFA) is enabled for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to check whether MFA is enabled for users in the directory whose ID is <c>d-00fc2p61****</c>. The returned result shows that MFA is in the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMFAAuthenticationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMFAAuthenticationStatusResponse
        /// </returns>
        public async Task<GetMFAAuthenticationStatusResponse> GetMFAAuthenticationStatusAsync(GetMFAAuthenticationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMFAAuthenticationStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the password policy of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPasswordPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPasswordPolicyResponse
        /// </returns>
        public GetPasswordPolicyResponse GetPasswordPolicyWithOptions(GetPasswordPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordPolicy",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the password policy of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPasswordPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPasswordPolicyResponse
        /// </returns>
        public async Task<GetPasswordPolicyResponse> GetPasswordPolicyWithOptionsAsync(GetPasswordPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordPolicy",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the password policy of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPasswordPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPasswordPolicyResponse
        /// </returns>
        public GetPasswordPolicyResponse GetPasswordPolicy(GetPasswordPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPasswordPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the password policy of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPasswordPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPasswordPolicyResponse
        /// </returns>
        public async Task<GetPasswordPolicyResponse> GetPasswordPolicyAsync(GetPasswordPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPasswordPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of System for Cross-domain Identity Management (SCIM) synchronization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the status of SCIM synchronization within the directory <c>d-00fc2p61****</c>. The returned result shows that SCIM synchronization is in the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSCIMSynchronizationStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSCIMSynchronizationStatusResponse
        /// </returns>
        public GetSCIMSynchronizationStatusResponse GetSCIMSynchronizationStatusWithOptions(GetSCIMSynchronizationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSCIMSynchronizationStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSCIMSynchronizationStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of System for Cross-domain Identity Management (SCIM) synchronization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the status of SCIM synchronization within the directory <c>d-00fc2p61****</c>. The returned result shows that SCIM synchronization is in the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSCIMSynchronizationStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSCIMSynchronizationStatusResponse
        /// </returns>
        public async Task<GetSCIMSynchronizationStatusResponse> GetSCIMSynchronizationStatusWithOptionsAsync(GetSCIMSynchronizationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSCIMSynchronizationStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSCIMSynchronizationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of System for Cross-domain Identity Management (SCIM) synchronization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the status of SCIM synchronization within the directory <c>d-00fc2p61****</c>. The returned result shows that SCIM synchronization is in the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSCIMSynchronizationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSCIMSynchronizationStatusResponse
        /// </returns>
        public GetSCIMSynchronizationStatusResponse GetSCIMSynchronizationStatus(GetSCIMSynchronizationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSCIMSynchronizationStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of System for Cross-domain Identity Management (SCIM) synchronization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the status of SCIM synchronization within the directory <c>d-00fc2p61****</c>. The returned result shows that SCIM synchronization is in the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSCIMSynchronizationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSCIMSynchronizationStatusResponse
        /// </returns>
        public async Task<GetSCIMSynchronizationStatusResponse> GetSCIMSynchronizationStatusAsync(GetSCIMSynchronizationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSCIMSynchronizationStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of CloudSSO.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceStatusResponse
        /// </returns>
        public GetServiceStatusResponse GetServiceStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of CloudSSO.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceStatusResponse
        /// </returns>
        public async Task<GetServiceStatusResponse> GetServiceStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of CloudSSO.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceStatusResponse
        /// </returns>
        public GetServiceStatusResponse GetServiceStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceStatusWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of CloudSSO.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceStatusResponse
        /// </returns>
        public async Task<GetServiceStatusResponse> GetServiceStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceStatusWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about the task whose ID is <c>t-shfqw1u1edszvxw5****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public GetTaskResponse GetTaskWithOptions(GetTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about the task whose ID is <c>t-shfqw1u1edszvxw5****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public async Task<GetTaskResponse> GetTaskWithOptionsAsync(GetTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about the task whose ID is <c>t-shfqw1u1edszvxw5****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public GetTaskResponse GetTask(GetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about the task whose ID is <c>t-shfqw1u1edszvxw5****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public async Task<GetTaskResponse> GetTaskAsync(GetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the GetTaskStatus operation to query the status of an asynchronous task. If you want to query more information about an asynchronous task, call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation.
        /// This topic provides an example on how to query the information about the task whose ID is <c>t-shfqw1u1edszvxw5****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public GetTaskStatusResponse GetTaskStatusWithOptions(GetTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the GetTaskStatus operation to query the status of an asynchronous task. If you want to query more information about an asynchronous task, call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation.
        /// This topic provides an example on how to query the information about the task whose ID is <c>t-shfqw1u1edszvxw5****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public async Task<GetTaskStatusResponse> GetTaskStatusWithOptionsAsync(GetTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the GetTaskStatus operation to query the status of an asynchronous task. If you want to query more information about an asynchronous task, call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation.
        /// This topic provides an example on how to query the information about the task whose ID is <c>t-shfqw1u1edszvxw5****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public GetTaskStatusResponse GetTaskStatus(GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the GetTaskStatus operation to query the status of an asynchronous task. If you want to query more information about an asynchronous task, call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation.
        /// This topic provides an example on how to query the information about the task whose ID is <c>t-shfqw1u1edszvxw5****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public async Task<GetTaskStatusResponse> GetTaskStatusAsync(GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the user whose ID is <c>u-00q8wbq42wiltcrk****</c> in the <c>d-00fc2p61****</c> directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
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
                Action = "GetUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the user whose ID is <c>u-00q8wbq42wiltcrk****</c> in the <c>d-00fc2p61****</c> directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
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
                Action = "GetUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the user whose ID is <c>u-00q8wbq42wiltcrk****</c> in the <c>d-00fc2p61****</c> directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query information about the user whose ID is <c>u-00q8wbq42wiltcrk****</c> in the <c>d-00fc2p61****</c> directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of a user in a resource directory by using the ExternalId parameter.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetUserIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdResponse
        /// </returns>
        public GetUserIdResponse GetUserIdWithOptions(GetUserIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUserIdShrinkRequest request = new GetUserIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalId))
            {
                request.ExternalIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalId, "ExternalId", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalIdShrink))
            {
                query["ExternalId"] = request.ExternalIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserId",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of a user in a resource directory by using the ExternalId parameter.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetUserIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdResponse
        /// </returns>
        public async Task<GetUserIdResponse> GetUserIdWithOptionsAsync(GetUserIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUserIdShrinkRequest request = new GetUserIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalId))
            {
                request.ExternalIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalId, "ExternalId", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalIdShrink))
            {
                query["ExternalId"] = request.ExternalIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserId",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of a user in a resource directory by using the ExternalId parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdResponse
        /// </returns>
        public GetUserIdResponse GetUserId(GetUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of a user in a resource directory by using the ExternalId parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdResponse
        /// </returns>
        public async Task<GetUserIdResponse> GetUserIdAsync(GetUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of a single user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the MFA setting of the user named <c>u-00q8wbq42wiltcrk****</c>. The returned result shows that MFA is enabled for the user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserMFAAuthenticationSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserMFAAuthenticationSettingsResponse
        /// </returns>
        public GetUserMFAAuthenticationSettingsResponse GetUserMFAAuthenticationSettingsWithOptions(GetUserMFAAuthenticationSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
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
                Action = "GetUserMFAAuthenticationSettings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserMFAAuthenticationSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of a single user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the MFA setting of the user named <c>u-00q8wbq42wiltcrk****</c>. The returned result shows that MFA is enabled for the user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserMFAAuthenticationSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserMFAAuthenticationSettingsResponse
        /// </returns>
        public async Task<GetUserMFAAuthenticationSettingsResponse> GetUserMFAAuthenticationSettingsWithOptionsAsync(GetUserMFAAuthenticationSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
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
                Action = "GetUserMFAAuthenticationSettings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserMFAAuthenticationSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of a single user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the MFA setting of the user named <c>u-00q8wbq42wiltcrk****</c>. The returned result shows that MFA is enabled for the user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserMFAAuthenticationSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserMFAAuthenticationSettingsResponse
        /// </returns>
        public GetUserMFAAuthenticationSettingsResponse GetUserMFAAuthenticationSettings(GetUserMFAAuthenticationSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserMFAAuthenticationSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) setting of a single user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the MFA setting of the user named <c>u-00q8wbq42wiltcrk****</c>. The returned result shows that MFA is enabled for the user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetUserMFAAuthenticationSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserMFAAuthenticationSettingsResponse
        /// </returns>
        public async Task<GetUserMFAAuthenticationSettingsResponse> GetUserMFAAuthenticationSettingsAsync(GetUserMFAAuthenticationSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserMFAAuthenticationSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningResponse
        /// </returns>
        public GetUserProvisioningResponse GetUserProvisioningWithOptions(GetUserProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserProvisioning",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserProvisioningResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningResponse
        /// </returns>
        public async Task<GetUserProvisioningResponse> GetUserProvisioningWithOptionsAsync(GetUserProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserProvisioning",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserProvisioningResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningResponse
        /// </returns>
        public GetUserProvisioningResponse GetUserProvisioning(GetUserProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserProvisioningWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningResponse
        /// </returns>
        public async Task<GetUserProvisioningResponse> GetUserProvisioningAsync(GetUserProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserProvisioningWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the global configurations of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningConfigurationResponse
        /// </returns>
        public GetUserProvisioningConfigurationResponse GetUserProvisioningConfigurationWithOptions(GetUserProvisioningConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserProvisioningConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserProvisioningConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the global configurations of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningConfigurationResponse
        /// </returns>
        public async Task<GetUserProvisioningConfigurationResponse> GetUserProvisioningConfigurationWithOptionsAsync(GetUserProvisioningConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserProvisioningConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserProvisioningConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the global configurations of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningConfigurationResponse
        /// </returns>
        public GetUserProvisioningConfigurationResponse GetUserProvisioningConfiguration(GetUserProvisioningConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserProvisioningConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the global configurations of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningConfigurationResponse
        /// </returns>
        public async Task<GetUserProvisioningConfigurationResponse> GetUserProvisioningConfigurationAsync(GetUserProvisioningConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserProvisioningConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningEventResponse
        /// </returns>
        public GetUserProvisioningEventResponse GetUserProvisioningEventWithOptions(GetUserProvisioningEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserProvisioningEvent",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserProvisioningEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningEventResponse
        /// </returns>
        public async Task<GetUserProvisioningEventResponse> GetUserProvisioningEventWithOptionsAsync(GetUserProvisioningEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserProvisioningEvent",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserProvisioningEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningEventRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningEventResponse
        /// </returns>
        public GetUserProvisioningEventResponse GetUserProvisioningEvent(GetUserProvisioningEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserProvisioningEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningEventRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningEventResponse
        /// </returns>
        public async Task<GetUserProvisioningEventResponse> GetUserProvisioningEventAsync(GetUserProvisioningEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserProvisioningEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics of Resource Access Management (RAM) user provisioning events that are created for the member in a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningRdAccountStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningRdAccountStatisticsResponse
        /// </returns>
        public GetUserProvisioningRdAccountStatisticsResponse GetUserProvisioningRdAccountStatisticsWithOptions(GetUserProvisioningRdAccountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdMemberId))
            {
                query["RdMemberId"] = request.RdMemberId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserProvisioningRdAccountStatistics",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserProvisioningRdAccountStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics of Resource Access Management (RAM) user provisioning events that are created for the member in a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningRdAccountStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningRdAccountStatisticsResponse
        /// </returns>
        public async Task<GetUserProvisioningRdAccountStatisticsResponse> GetUserProvisioningRdAccountStatisticsWithOptionsAsync(GetUserProvisioningRdAccountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdMemberId))
            {
                query["RdMemberId"] = request.RdMemberId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserProvisioningRdAccountStatistics",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserProvisioningRdAccountStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics of Resource Access Management (RAM) user provisioning events that are created for the member in a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningRdAccountStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningRdAccountStatisticsResponse
        /// </returns>
        public GetUserProvisioningRdAccountStatisticsResponse GetUserProvisioningRdAccountStatistics(GetUserProvisioningRdAccountStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserProvisioningRdAccountStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics of Resource Access Management (RAM) user provisioning events that are created for the member in a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningRdAccountStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningRdAccountStatisticsResponse
        /// </returns>
        public async Task<GetUserProvisioningRdAccountStatisticsResponse> GetUserProvisioningRdAccountStatisticsAsync(GetUserProvisioningRdAccountStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserProvisioningRdAccountStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningStatisticsResponse
        /// </returns>
        public GetUserProvisioningStatisticsResponse GetUserProvisioningStatisticsWithOptions(GetUserProvisioningStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserProvisioningStatistics",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserProvisioningStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningStatisticsResponse
        /// </returns>
        public async Task<GetUserProvisioningStatisticsResponse> GetUserProvisioningStatisticsWithOptionsAsync(GetUserProvisioningStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserProvisioningStatistics",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserProvisioningStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningStatisticsResponse
        /// </returns>
        public GetUserProvisioningStatisticsResponse GetUserProvisioningStatistics(GetUserProvisioningStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserProvisioningStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserProvisioningStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserProvisioningStatisticsResponse
        /// </returns>
        public async Task<GetUserProvisioningStatisticsResponse> GetUserProvisioningStatisticsAsync(GetUserProvisioningStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserProvisioningStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access permissions that are assigned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the assigned access permissions on the account <c>114240524784****</c> in your resource directory. The returned result shows that access permissions on the account in your resource directory is assigned to one user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessAssignmentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessAssignmentsResponse
        /// </returns>
        public ListAccessAssignmentsResponse ListAccessAssignmentsWithOptions(ListAccessAssignmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessAssignments",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessAssignmentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access permissions that are assigned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the assigned access permissions on the account <c>114240524784****</c> in your resource directory. The returned result shows that access permissions on the account in your resource directory is assigned to one user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessAssignmentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessAssignmentsResponse
        /// </returns>
        public async Task<ListAccessAssignmentsResponse> ListAccessAssignmentsWithOptionsAsync(ListAccessAssignmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessAssignments",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessAssignmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access permissions that are assigned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the assigned access permissions on the account <c>114240524784****</c> in your resource directory. The returned result shows that access permissions on the account in your resource directory is assigned to one user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessAssignmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessAssignmentsResponse
        /// </returns>
        public ListAccessAssignmentsResponse ListAccessAssignments(ListAccessAssignmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessAssignmentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access permissions that are assigned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the assigned access permissions on the account <c>114240524784****</c> in your resource directory. The returned result shows that access permissions on the account in your resource directory is assigned to one user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessAssignmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessAssignmentsResponse
        /// </returns>
        public async Task<ListAccessAssignmentsResponse> ListAccessAssignmentsAsync(ListAccessAssignmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessAssignmentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access configurations that are provisioned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the accounts for which the access permission <c>ac-00ccule7tadaijxc****</c> is provisioned. The returned result shows that the access configuration is provisioned for two accounts in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessConfigurationProvisioningsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessConfigurationProvisioningsResponse
        /// </returns>
        public ListAccessConfigurationProvisioningsResponse ListAccessConfigurationProvisioningsWithOptions(ListAccessConfigurationProvisioningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisioningStatus))
            {
                query["ProvisioningStatus"] = request.ProvisioningStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessConfigurationProvisionings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessConfigurationProvisioningsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access configurations that are provisioned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the accounts for which the access permission <c>ac-00ccule7tadaijxc****</c> is provisioned. The returned result shows that the access configuration is provisioned for two accounts in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessConfigurationProvisioningsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessConfigurationProvisioningsResponse
        /// </returns>
        public async Task<ListAccessConfigurationProvisioningsResponse> ListAccessConfigurationProvisioningsWithOptionsAsync(ListAccessConfigurationProvisioningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisioningStatus))
            {
                query["ProvisioningStatus"] = request.ProvisioningStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessConfigurationProvisionings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessConfigurationProvisioningsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access configurations that are provisioned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the accounts for which the access permission <c>ac-00ccule7tadaijxc****</c> is provisioned. The returned result shows that the access configuration is provisioned for two accounts in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessConfigurationProvisioningsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessConfigurationProvisioningsResponse
        /// </returns>
        public ListAccessConfigurationProvisioningsResponse ListAccessConfigurationProvisionings(ListAccessConfigurationProvisioningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessConfigurationProvisioningsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access configurations that are provisioned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the accounts for which the access permission <c>ac-00ccule7tadaijxc****</c> is provisioned. The returned result shows that the access configuration is provisioned for two accounts in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessConfigurationProvisioningsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessConfigurationProvisioningsResponse
        /// </returns>
        public async Task<ListAccessConfigurationProvisioningsResponse> ListAccessConfigurationProvisioningsAsync(ListAccessConfigurationProvisioningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessConfigurationProvisioningsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the access configurations within the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains the <c>VPC-Admin</c> and <c>ECS-Admin</c> access configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessConfigurationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessConfigurationsResponse
        /// </returns>
        public ListAccessConfigurationsResponse ListAccessConfigurationsWithOptions(ListAccessConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusNotifications))
            {
                query["StatusNotifications"] = request.StatusNotifications;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessConfigurations",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessConfigurationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the access configurations within the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains the <c>VPC-Admin</c> and <c>ECS-Admin</c> access configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessConfigurationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessConfigurationsResponse
        /// </returns>
        public async Task<ListAccessConfigurationsResponse> ListAccessConfigurationsWithOptionsAsync(ListAccessConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusNotifications))
            {
                query["StatusNotifications"] = request.StatusNotifications;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessConfigurations",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessConfigurationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the access configurations within the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains the <c>VPC-Admin</c> and <c>ECS-Admin</c> access configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessConfigurationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessConfigurationsResponse
        /// </returns>
        public ListAccessConfigurationsResponse ListAccessConfigurations(ListAccessConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessConfigurationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the access configurations within the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains the <c>VPC-Admin</c> and <c>ECS-Admin</c> access configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAccessConfigurationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessConfigurationsResponse
        /// </returns>
        public async Task<ListAccessConfigurationsResponse> ListAccessConfigurationsAsync(ListAccessConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessConfigurationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries directories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the directories within your Alibaba Cloud account. The returned result shows that only one directory with the ID <c>d-00fc2p61****</c> is created within your Alibaba Cloud account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDirectoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDirectoriesResponse
        /// </returns>
        public ListDirectoriesResponse ListDirectoriesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDirectories",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDirectoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries directories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the directories within your Alibaba Cloud account. The returned result shows that only one directory with the ID <c>d-00fc2p61****</c> is created within your Alibaba Cloud account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDirectoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDirectoriesResponse
        /// </returns>
        public async Task<ListDirectoriesResponse> ListDirectoriesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDirectories",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDirectoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries directories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the directories within your Alibaba Cloud account. The returned result shows that only one directory with the ID <c>d-00fc2p61****</c> is created within your Alibaba Cloud account.</para>
        /// </description>
        /// 
        /// <returns>
        /// ListDirectoriesResponse
        /// </returns>
        public ListDirectoriesResponse ListDirectories()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDirectoriesWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries directories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the directories within your Alibaba Cloud account. The returned result shows that only one directory with the ID <c>d-00fc2p61****</c> is created within your Alibaba Cloud account.</para>
        /// </description>
        /// 
        /// <returns>
        /// ListDirectoriesResponse
        /// </returns>
        public async Task<ListDirectoriesResponse> ListDirectoriesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDirectoriesWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Security Assertion Markup Language (SAML) signing certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the SAML signing certificates within the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains one SAML signing certificate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExternalSAMLIdPCertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExternalSAMLIdPCertificatesResponse
        /// </returns>
        public ListExternalSAMLIdPCertificatesResponse ListExternalSAMLIdPCertificatesWithOptions(ListExternalSAMLIdPCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExternalSAMLIdPCertificates",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExternalSAMLIdPCertificatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Security Assertion Markup Language (SAML) signing certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the SAML signing certificates within the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains one SAML signing certificate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExternalSAMLIdPCertificatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExternalSAMLIdPCertificatesResponse
        /// </returns>
        public async Task<ListExternalSAMLIdPCertificatesResponse> ListExternalSAMLIdPCertificatesWithOptionsAsync(ListExternalSAMLIdPCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExternalSAMLIdPCertificates",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExternalSAMLIdPCertificatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Security Assertion Markup Language (SAML) signing certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the SAML signing certificates within the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains one SAML signing certificate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExternalSAMLIdPCertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExternalSAMLIdPCertificatesResponse
        /// </returns>
        public ListExternalSAMLIdPCertificatesResponse ListExternalSAMLIdPCertificates(ListExternalSAMLIdPCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExternalSAMLIdPCertificatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Security Assertion Markup Language (SAML) signing certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the SAML signing certificates within the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains one SAML signing certificate.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExternalSAMLIdPCertificatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExternalSAMLIdPCertificatesResponse
        /// </returns>
        public async Task<ListExternalSAMLIdPCertificatesResponse> ListExternalSAMLIdPCertificatesAsync(ListExternalSAMLIdPCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExternalSAMLIdPCertificatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users in a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the users in the group <c>g-00jqzghi2n3o5hkh****</c>. The returned result shows that the group contains the user <c>Alice</c> and the user <c>user1</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupMembersResponse
        /// </returns>
        public ListGroupMembersResponse ListGroupMembersWithOptions(ListGroupMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
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
                Action = "ListGroupMembers",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users in a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the users in the group <c>g-00jqzghi2n3o5hkh****</c>. The returned result shows that the group contains the user <c>Alice</c> and the user <c>user1</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupMembersResponse
        /// </returns>
        public async Task<ListGroupMembersResponse> ListGroupMembersWithOptionsAsync(ListGroupMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
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
                Action = "ListGroupMembers",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users in a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the users in the group <c>g-00jqzghi2n3o5hkh****</c>. The returned result shows that the group contains the user <c>Alice</c> and the user <c>user1</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupMembersResponse
        /// </returns>
        public ListGroupMembersResponse ListGroupMembers(ListGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupMembersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users in a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the users in the group <c>g-00jqzghi2n3o5hkh****</c>. The returned result shows that the group contains the user <c>Alice</c> and the user <c>user1</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupMembersResponse
        /// </returns>
        public async Task<ListGroupMembersResponse> ListGroupMembersAsync(ListGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupMembersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the groups in the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains three groups. The groups <c>group1</c> and <c>group2</c> are synchronized from an external identity provider (IdP). The group <c>TestGroup</c> is manually created in CloudSSO.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public ListGroupsResponse ListGroupsWithOptions(ListGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionType))
            {
                query["ProvisionType"] = request.ProvisionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the groups in the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains three groups. The groups <c>group1</c> and <c>group2</c> are synchronized from an external identity provider (IdP). The group <c>TestGroup</c> is manually created in CloudSSO.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public async Task<ListGroupsResponse> ListGroupsWithOptionsAsync(ListGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionType))
            {
                query["ProvisionType"] = request.ProvisionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the groups in the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains three groups. The groups <c>group1</c> and <c>group2</c> are synchronized from an external identity provider (IdP). The group <c>TestGroup</c> is manually created in CloudSSO.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries groups.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the groups in the directory <c>d-00fc2p61****</c>. The returned result shows that the directory contains three groups. The groups <c>group1</c> and <c>group2</c> are synchronized from an external identity provider (IdP). The group <c>TestGroup</c> is manually created in CloudSSO.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public async Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the groups to which a user is added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the groups to which the user <c>u-00q8wbq42wiltcrk****</c> is added. The returned result shows that the user is added to both the <c>TestGroup</c> and the <c>group1</c> groups.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListJoinedGroupsForUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJoinedGroupsForUserResponse
        /// </returns>
        public ListJoinedGroupsForUserResponse ListJoinedGroupsForUserWithOptions(ListJoinedGroupsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListJoinedGroupsForUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJoinedGroupsForUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the groups to which a user is added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the groups to which the user <c>u-00q8wbq42wiltcrk****</c> is added. The returned result shows that the user is added to both the <c>TestGroup</c> and the <c>group1</c> groups.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListJoinedGroupsForUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJoinedGroupsForUserResponse
        /// </returns>
        public async Task<ListJoinedGroupsForUserResponse> ListJoinedGroupsForUserWithOptionsAsync(ListJoinedGroupsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListJoinedGroupsForUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJoinedGroupsForUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the groups to which a user is added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the groups to which the user <c>u-00q8wbq42wiltcrk****</c> is added. The returned result shows that the user is added to both the <c>TestGroup</c> and the <c>group1</c> groups.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListJoinedGroupsForUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJoinedGroupsForUserResponse
        /// </returns>
        public ListJoinedGroupsForUserResponse ListJoinedGroupsForUser(ListJoinedGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJoinedGroupsForUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the groups to which a user is added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the groups to which the user <c>u-00q8wbq42wiltcrk****</c> is added. The returned result shows that the user is added to both the <c>TestGroup</c> and the <c>group1</c> groups.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListJoinedGroupsForUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJoinedGroupsForUserResponse
        /// </returns>
        public async Task<ListJoinedGroupsForUserResponse> ListJoinedGroupsForUserAsync(ListJoinedGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJoinedGroupsForUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) devices that are bound to a user. Up to two MFA devices can be bound to a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the MFA devices that are bound to the user <c>u-00q8wbq42wiltcrk****</c>. The returned result shows that the MFA device named <c>Alice-MFA1</c> is bound to the user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMFADevicesForUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMFADevicesForUserResponse
        /// </returns>
        public ListMFADevicesForUserResponse ListMFADevicesForUserWithOptions(ListMFADevicesForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
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
                Action = "ListMFADevicesForUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMFADevicesForUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) devices that are bound to a user. Up to two MFA devices can be bound to a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the MFA devices that are bound to the user <c>u-00q8wbq42wiltcrk****</c>. The returned result shows that the MFA device named <c>Alice-MFA1</c> is bound to the user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMFADevicesForUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMFADevicesForUserResponse
        /// </returns>
        public async Task<ListMFADevicesForUserResponse> ListMFADevicesForUserWithOptionsAsync(ListMFADevicesForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
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
                Action = "ListMFADevicesForUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMFADevicesForUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) devices that are bound to a user. Up to two MFA devices can be bound to a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the MFA devices that are bound to the user <c>u-00q8wbq42wiltcrk****</c>. The returned result shows that the MFA device named <c>Alice-MFA1</c> is bound to the user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMFADevicesForUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMFADevicesForUserResponse
        /// </returns>
        public ListMFADevicesForUserResponse ListMFADevicesForUser(ListMFADevicesForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMFADevicesForUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the multi-factor authentication (MFA) devices that are bound to a user. Up to two MFA devices can be bound to a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the MFA devices that are bound to the user <c>u-00q8wbq42wiltcrk****</c>. The returned result shows that the MFA device named <c>Alice-MFA1</c> is bound to the user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMFADevicesForUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMFADevicesForUserResponse
        /// </returns>
        public async Task<ListMFADevicesForUserResponse> ListMFADevicesForUserAsync(ListMFADevicesForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMFADevicesForUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the policies that are created for an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the policies that are created for the access configuration <c>ac-00jhtfl8thteu6uj****</c>. The returned result shows that the access configuration contains one system policy and one inline policy.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionPoliciesInAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionPoliciesInAccessConfigurationResponse
        /// </returns>
        public ListPermissionPoliciesInAccessConfigurationResponse ListPermissionPoliciesInAccessConfigurationWithOptions(ListPermissionPoliciesInAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionPolicyType))
            {
                query["PermissionPolicyType"] = request.PermissionPolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissionPoliciesInAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionPoliciesInAccessConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the policies that are created for an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the policies that are created for the access configuration <c>ac-00jhtfl8thteu6uj****</c>. The returned result shows that the access configuration contains one system policy and one inline policy.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionPoliciesInAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionPoliciesInAccessConfigurationResponse
        /// </returns>
        public async Task<ListPermissionPoliciesInAccessConfigurationResponse> ListPermissionPoliciesInAccessConfigurationWithOptionsAsync(ListPermissionPoliciesInAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionPolicyType))
            {
                query["PermissionPolicyType"] = request.PermissionPolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissionPoliciesInAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionPoliciesInAccessConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the policies that are created for an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the policies that are created for the access configuration <c>ac-00jhtfl8thteu6uj****</c>. The returned result shows that the access configuration contains one system policy and one inline policy.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionPoliciesInAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionPoliciesInAccessConfigurationResponse
        /// </returns>
        public ListPermissionPoliciesInAccessConfigurationResponse ListPermissionPoliciesInAccessConfiguration(ListPermissionPoliciesInAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPermissionPoliciesInAccessConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the policies that are created for an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the policies that are created for the access configuration <c>ac-00jhtfl8thteu6uj****</c>. The returned result shows that the access configuration contains one system policy and one inline policy.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionPoliciesInAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionPoliciesInAccessConfigurationResponse
        /// </returns>
        public async Task<ListPermissionPoliciesInAccessConfigurationResponse> ListPermissionPoliciesInAccessConfigurationAsync(ListPermissionPoliciesInAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPermissionPoliciesInAccessConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Cross-domain Identity Management (SCIM) credentials.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the SCIM credentials within the <c>d-00fc2p61****</c> directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSCIMServerCredentialsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSCIMServerCredentialsResponse
        /// </returns>
        public ListSCIMServerCredentialsResponse ListSCIMServerCredentialsWithOptions(ListSCIMServerCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSCIMServerCredentials",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSCIMServerCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Cross-domain Identity Management (SCIM) credentials.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the SCIM credentials within the <c>d-00fc2p61****</c> directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSCIMServerCredentialsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSCIMServerCredentialsResponse
        /// </returns>
        public async Task<ListSCIMServerCredentialsResponse> ListSCIMServerCredentialsWithOptionsAsync(ListSCIMServerCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSCIMServerCredentials",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSCIMServerCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Cross-domain Identity Management (SCIM) credentials.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the SCIM credentials within the <c>d-00fc2p61****</c> directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSCIMServerCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSCIMServerCredentialsResponse
        /// </returns>
        public ListSCIMServerCredentialsResponse ListSCIMServerCredentials(ListSCIMServerCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSCIMServerCredentialsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Cross-domain Identity Management (SCIM) credentials.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the SCIM credentials within the <c>d-00fc2p61****</c> directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSCIMServerCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSCIMServerCredentialsResponse
        /// </returns>
        public async Task<ListSCIMServerCredentialsResponse> ListSCIMServerCredentialsAsync(ListSCIMServerCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSCIMServerCredentialsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries asynchronous tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation queries the tasks within the previous 24 hours. This operation allows you to query the tasks within a maximum of 7 days. You can specify the start time of the query by using <c>Filter</c>.
        /// This topic provides an example on how to query the tasks within the previous 24 hours.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public ListTasksResponse ListTasksWithOptions(ListTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries asynchronous tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation queries the tasks within the previous 24 hours. This operation allows you to query the tasks within a maximum of 7 days. You can specify the start time of the query by using <c>Filter</c>.
        /// This topic provides an example on how to query the tasks within the previous 24 hours.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(ListTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries asynchronous tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation queries the tasks within the previous 24 hours. This operation allows you to query the tasks within a maximum of 7 days. You can specify the start time of the query by using <c>Filter</c>.
        /// This topic provides an example on how to query the tasks within the previous 24 hours.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public ListTasksResponse ListTasks(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries asynchronous tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation queries the tasks within the previous 24 hours. This operation allows you to query the tasks within a maximum of 7 days. You can specify the start time of the query by using <c>Filter</c>.
        /// This topic provides an example on how to query the tasks within the previous 24 hours.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) user provisioning events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserProvisioningEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserProvisioningEventsResponse
        /// </returns>
        public ListUserProvisioningEventsResponse ListUserProvisioningEventsWithOptions(ListUserProvisioningEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserProvisioningEvents",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserProvisioningEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) user provisioning events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserProvisioningEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserProvisioningEventsResponse
        /// </returns>
        public async Task<ListUserProvisioningEventsResponse> ListUserProvisioningEventsWithOptionsAsync(ListUserProvisioningEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserProvisioningEvents",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserProvisioningEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) user provisioning events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserProvisioningEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserProvisioningEventsResponse
        /// </returns>
        public ListUserProvisioningEventsResponse ListUserProvisioningEvents(ListUserProvisioningEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserProvisioningEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) user provisioning events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserProvisioningEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserProvisioningEventsResponse
        /// </returns>
        public async Task<ListUserProvisioningEventsResponse> ListUserProvisioningEventsAsync(ListUserProvisioningEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserProvisioningEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) user provisionings.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserProvisioningsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserProvisioningsResponse
        /// </returns>
        public ListUserProvisioningsResponse ListUserProvisioningsWithOptions(ListUserProvisioningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserProvisionings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserProvisioningsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) user provisionings.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserProvisioningsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserProvisioningsResponse
        /// </returns>
        public async Task<ListUserProvisioningsResponse> ListUserProvisioningsWithOptionsAsync(ListUserProvisioningsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalId))
            {
                query["PrincipalId"] = request.PrincipalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalType))
            {
                query["PrincipalType"] = request.PrincipalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserProvisionings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserProvisioningsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) user provisionings.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserProvisioningsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserProvisioningsResponse
        /// </returns>
        public ListUserProvisioningsResponse ListUserProvisionings(ListUserProvisioningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserProvisioningsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) user provisionings.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserProvisioningsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserProvisioningsResponse
        /// </returns>
        public async Task<ListUserProvisioningsResponse> ListUserProvisioningsAsync(ListUserProvisioningsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserProvisioningsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query users in the <c>d-00fc2p61****</c> directory. The returned result shows that the directory contains two users. The user <c>AliceLee</c> is synchronized from an external identity provider (IdP). The user <c>user1</c> is manually created within CloudSSO.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionType))
            {
                query["ProvisionType"] = request.ProvisionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query users in the <c>d-00fc2p61****</c> directory. The returned result shows that the directory contains two users. The user <c>AliceLee</c> is synchronized from an external identity provider (IdP). The user <c>user1</c> is manually created within CloudSSO.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionType))
            {
                query["ProvisionType"] = request.ProvisionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query users in the <c>d-00fc2p61****</c> directory. The returned result shows that the directory contains two users. The user <c>AliceLee</c> is synchronized from an external identity provider (IdP). The user <c>user1</c> is manually created within CloudSSO.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query users in the <c>d-00fc2p61****</c> directory. The returned result shows that the directory contains two users. The user <c>AliceLee</c> is synchronized from an external identity provider (IdP). The user <c>user1</c> is manually created within CloudSSO.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provisions an access configuration for an account in your resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is automatically created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to provision the access configuration <c>ac-00jhtfl8thteu6uj****</c> for the account <c>114240524784****</c> in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ProvisionAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProvisionAccessConfigurationResponse
        /// </returns>
        public ProvisionAccessConfigurationResponse ProvisionAccessConfigurationWithOptions(ProvisionAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProvisionAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProvisionAccessConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provisions an access configuration for an account in your resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is automatically created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to provision the access configuration <c>ac-00jhtfl8thteu6uj****</c> for the account <c>114240524784****</c> in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ProvisionAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProvisionAccessConfigurationResponse
        /// </returns>
        public async Task<ProvisionAccessConfigurationResponse> ProvisionAccessConfigurationWithOptionsAsync(ProvisionAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProvisionAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProvisionAccessConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provisions an access configuration for an account in your resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is automatically created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to provision the access configuration <c>ac-00jhtfl8thteu6uj****</c> for the account <c>114240524784****</c> in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ProvisionAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// ProvisionAccessConfigurationResponse
        /// </returns>
        public ProvisionAccessConfigurationResponse ProvisionAccessConfiguration(ProvisionAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProvisionAccessConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provisions an access configuration for an account in your resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, an asynchronous task is automatically created. You can call the <a href="https://help.aliyun.com/document_detail/340670.html">GetTask</a> operation to query the progress of the task based on the value of the <c>TaskId</c> response parameter.
        /// This topic provides an example on how to provision the access configuration <c>ac-00jhtfl8thteu6uj****</c> for the account <c>114240524784****</c> in your resource directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ProvisionAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// ProvisionAccessConfigurationResponse
        /// </returns>
        public async Task<ProvisionAccessConfigurationResponse> ProvisionAccessConfigurationAsync(ProvisionAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProvisionAccessConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a Security Assertion Markup Language (SAML) signing certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to remove the SAML signing certificate whose ID is <c>idp-c-00dt9gnl7fmjaw9c****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveExternalSAMLIdPCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveExternalSAMLIdPCertificateResponse
        /// </returns>
        public RemoveExternalSAMLIdPCertificateResponse RemoveExternalSAMLIdPCertificateWithOptions(RemoveExternalSAMLIdPCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveExternalSAMLIdPCertificate",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveExternalSAMLIdPCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a Security Assertion Markup Language (SAML) signing certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to remove the SAML signing certificate whose ID is <c>idp-c-00dt9gnl7fmjaw9c****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveExternalSAMLIdPCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveExternalSAMLIdPCertificateResponse
        /// </returns>
        public async Task<RemoveExternalSAMLIdPCertificateResponse> RemoveExternalSAMLIdPCertificateWithOptionsAsync(RemoveExternalSAMLIdPCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveExternalSAMLIdPCertificate",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveExternalSAMLIdPCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a Security Assertion Markup Language (SAML) signing certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to remove the SAML signing certificate whose ID is <c>idp-c-00dt9gnl7fmjaw9c****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveExternalSAMLIdPCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveExternalSAMLIdPCertificateResponse
        /// </returns>
        public RemoveExternalSAMLIdPCertificateResponse RemoveExternalSAMLIdPCertificate(RemoveExternalSAMLIdPCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveExternalSAMLIdPCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a Security Assertion Markup Language (SAML) signing certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to remove the SAML signing certificate whose ID is <c>idp-c-00dt9gnl7fmjaw9c****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveExternalSAMLIdPCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveExternalSAMLIdPCertificateResponse
        /// </returns>
        public async Task<RemoveExternalSAMLIdPCertificateResponse> RemoveExternalSAMLIdPCertificateAsync(RemoveExternalSAMLIdPCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveExternalSAMLIdPCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a policy from an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you remove an inline policy from an access configuration, the policy cannot be restored.
        /// This topic provides an example on how to remove the system policy <c>AliyunECSFullAccess</c> from the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemovePermissionPolicyFromAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemovePermissionPolicyFromAccessConfigurationResponse
        /// </returns>
        public RemovePermissionPolicyFromAccessConfigurationResponse RemovePermissionPolicyFromAccessConfigurationWithOptions(RemovePermissionPolicyFromAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionPolicyName))
            {
                query["PermissionPolicyName"] = request.PermissionPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionPolicyType))
            {
                query["PermissionPolicyType"] = request.PermissionPolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePermissionPolicyFromAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePermissionPolicyFromAccessConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a policy from an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you remove an inline policy from an access configuration, the policy cannot be restored.
        /// This topic provides an example on how to remove the system policy <c>AliyunECSFullAccess</c> from the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemovePermissionPolicyFromAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemovePermissionPolicyFromAccessConfigurationResponse
        /// </returns>
        public async Task<RemovePermissionPolicyFromAccessConfigurationResponse> RemovePermissionPolicyFromAccessConfigurationWithOptionsAsync(RemovePermissionPolicyFromAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionPolicyName))
            {
                query["PermissionPolicyName"] = request.PermissionPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionPolicyType))
            {
                query["PermissionPolicyType"] = request.PermissionPolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePermissionPolicyFromAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePermissionPolicyFromAccessConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a policy from an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you remove an inline policy from an access configuration, the policy cannot be restored.
        /// This topic provides an example on how to remove the system policy <c>AliyunECSFullAccess</c> from the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemovePermissionPolicyFromAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// RemovePermissionPolicyFromAccessConfigurationResponse
        /// </returns>
        public RemovePermissionPolicyFromAccessConfigurationResponse RemovePermissionPolicyFromAccessConfiguration(RemovePermissionPolicyFromAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePermissionPolicyFromAccessConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a policy from an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you remove an inline policy from an access configuration, the policy cannot be restored.
        /// This topic provides an example on how to remove the system policy <c>AliyunECSFullAccess</c> from the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemovePermissionPolicyFromAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// RemovePermissionPolicyFromAccessConfigurationResponse
        /// </returns>
        public async Task<RemovePermissionPolicyFromAccessConfigurationResponse> RemovePermissionPolicyFromAccessConfigurationAsync(RemovePermissionPolicyFromAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePermissionPolicyFromAccessConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a user from a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot remove a user from a group that is synchronized by using SCIM.
        /// This topic provides an example on how to remove the user <c>u-00q8wbq42wiltcrk****</c> from the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserFromGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromGroupResponse
        /// </returns>
        public RemoveUserFromGroupResponse RemoveUserFromGroupWithOptions(RemoveUserFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
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
                Action = "RemoveUserFromGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserFromGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a user from a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot remove a user from a group that is synchronized by using SCIM.
        /// This topic provides an example on how to remove the user <c>u-00q8wbq42wiltcrk****</c> from the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserFromGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromGroupResponse
        /// </returns>
        public async Task<RemoveUserFromGroupResponse> RemoveUserFromGroupWithOptionsAsync(RemoveUserFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
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
                Action = "RemoveUserFromGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserFromGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a user from a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot remove a user from a group that is synchronized by using SCIM.
        /// This topic provides an example on how to remove the user <c>u-00q8wbq42wiltcrk****</c> from the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserFromGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromGroupResponse
        /// </returns>
        public RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUserFromGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a user from a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot remove a user from a group that is synchronized by using SCIM.
        /// This topic provides an example on how to remove the user <c>u-00q8wbq42wiltcrk****</c> from the group <c>g-00jqzghi2n3o5hkh****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveUserFromGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromGroupResponse
        /// </returns>
        public async Task<RemoveUserFromGroupResponse> RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUserFromGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the password of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a user forgets the password, the password expires, or the password poses security risks, a CloudSSO administrator can reset the password for the user.</para>
        /// <remarks>
        /// <para> After you enable single sign-on (SSO) logon, the password of a user cannot be reset.
        /// This topic provides an example on how to reset the password of the user <c>u-00q8wbq42wiltcrk****</c>. The new password is automatically generated by the system.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetUserPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public ResetUserPasswordResponse ResetUserPasswordWithOptions(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateRandomPassword))
            {
                query["GenerateRandomPassword"] = request.GenerateRandomPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequirePasswordResetForNextLogin))
            {
                query["RequirePasswordResetForNextLogin"] = request.RequirePasswordResetForNextLogin;
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
                Action = "ResetUserPassword",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the password of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a user forgets the password, the password expires, or the password poses security risks, a CloudSSO administrator can reset the password for the user.</para>
        /// <remarks>
        /// <para> After you enable single sign-on (SSO) logon, the password of a user cannot be reset.
        /// This topic provides an example on how to reset the password of the user <c>u-00q8wbq42wiltcrk****</c>. The new password is automatically generated by the system.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetUserPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public async Task<ResetUserPasswordResponse> ResetUserPasswordWithOptionsAsync(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateRandomPassword))
            {
                query["GenerateRandomPassword"] = request.GenerateRandomPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequirePasswordResetForNextLogin))
            {
                query["RequirePasswordResetForNextLogin"] = request.RequirePasswordResetForNextLogin;
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
                Action = "ResetUserPassword",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the password of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a user forgets the password, the password expires, or the password poses security risks, a CloudSSO administrator can reset the password for the user.</para>
        /// <remarks>
        /// <para> After you enable single sign-on (SSO) logon, the password of a user cannot be reset.
        /// This topic provides an example on how to reset the password of the user <c>u-00q8wbq42wiltcrk****</c>. The new password is automatically generated by the system.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetUserPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the password of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a user forgets the password, the password expires, or the password poses security risks, a CloudSSO administrator can reset the password for the user.</para>
        /// <remarks>
        /// <para> After you enable single sign-on (SSO) logon, the password of a user cannot be reset.
        /// This topic provides an example on how to reset the password of the user <c>u-00q8wbq42wiltcrk****</c>. The new password is automatically generated by the system.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public async Task<ResetUserPasswordResponse> ResetUserPasswordAsync(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetUserPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retries a Resource Access Management (RAM) user provisioning event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetryUserProvisioningEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryUserProvisioningEventResponse
        /// </returns>
        public RetryUserProvisioningEventResponse RetryUserProvisioningEventWithOptions(RetryUserProvisioningEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationStrategy))
            {
                query["DuplicationStrategy"] = request.DuplicationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryUserProvisioningEvent",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryUserProvisioningEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retries a Resource Access Management (RAM) user provisioning event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetryUserProvisioningEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryUserProvisioningEventResponse
        /// </returns>
        public async Task<RetryUserProvisioningEventResponse> RetryUserProvisioningEventWithOptionsAsync(RetryUserProvisioningEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DuplicationStrategy))
            {
                query["DuplicationStrategy"] = request.DuplicationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryUserProvisioningEvent",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryUserProvisioningEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retries a Resource Access Management (RAM) user provisioning event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetryUserProvisioningEventRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryUserProvisioningEventResponse
        /// </returns>
        public RetryUserProvisioningEventResponse RetryUserProvisioningEvent(RetryUserProvisioningEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryUserProvisioningEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retries a Resource Access Management (RAM) user provisioning event.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetryUserProvisioningEventRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryUserProvisioningEventResponse
        /// </returns>
        public async Task<RetryUserProvisioningEventResponse> RetryUserProvisioningEventAsync(RetryUserProvisioningEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryUserProvisioningEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During SAML 2.0-based single sign-on (SSO) logon, CloudSSO is a service provider (SP), and the identity management system of an enterprise is an IdP.
        /// You can use one of the following methods to configure a SAML IdP. You can obtain the required metadata file or parameter values from your IdP.</para>
        /// <list type="bullet">
        /// <item><description>Use the metadata file: You can specify the <c>EncodedMetadataDocument</c> parameter to upload the metadata file.</description></item>
        /// <item><description>Manually configure the IdP: You can manually specify the following parameters for your IdP: <c>EntityId</c>, <c>LoginUrl</c>, <c>WantRequestSigned</c>, and <c>X509Certificate</c>.
        /// If you have configured a SAML IdP, the existing configurations are replaced after you call this operation.</description></item>
        /// <item><description>If the IdP is configured by using the metadata file, all existing configurations are replaced with new configurations.</description></item>
        /// <item><description>If the IdP is manually configured, the original parameter values that are different from the new parameter values are replaced.<remarks>
        /// <para> If SSO logon is enabled, new configurations immediately take effect. Take note of the impacts on the production environment.
        /// This topic provides an example on how to configure an IdP by using the metadata file within the directory <c>d-00fc2p61****</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetExternalSAMLIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetExternalSAMLIdentityProviderResponse
        /// </returns>
        public SetExternalSAMLIdentityProviderResponse SetExternalSAMLIdentityProviderWithOptions(SetExternalSAMLIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingType))
            {
                query["BindingType"] = request.BindingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodedMetadataDocument))
            {
                query["EncodedMetadataDocument"] = request.EncodedMetadataDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginUrl))
            {
                query["LoginUrl"] = request.LoginUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSOStatus))
            {
                query["SSOStatus"] = request.SSOStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WantRequestSigned))
            {
                query["WantRequestSigned"] = request.WantRequestSigned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.X509Certificate))
            {
                query["X509Certificate"] = request.X509Certificate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetExternalSAMLIdentityProvider",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetExternalSAMLIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During SAML 2.0-based single sign-on (SSO) logon, CloudSSO is a service provider (SP), and the identity management system of an enterprise is an IdP.
        /// You can use one of the following methods to configure a SAML IdP. You can obtain the required metadata file or parameter values from your IdP.</para>
        /// <list type="bullet">
        /// <item><description>Use the metadata file: You can specify the <c>EncodedMetadataDocument</c> parameter to upload the metadata file.</description></item>
        /// <item><description>Manually configure the IdP: You can manually specify the following parameters for your IdP: <c>EntityId</c>, <c>LoginUrl</c>, <c>WantRequestSigned</c>, and <c>X509Certificate</c>.
        /// If you have configured a SAML IdP, the existing configurations are replaced after you call this operation.</description></item>
        /// <item><description>If the IdP is configured by using the metadata file, all existing configurations are replaced with new configurations.</description></item>
        /// <item><description>If the IdP is manually configured, the original parameter values that are different from the new parameter values are replaced.<remarks>
        /// <para> If SSO logon is enabled, new configurations immediately take effect. Take note of the impacts on the production environment.
        /// This topic provides an example on how to configure an IdP by using the metadata file within the directory <c>d-00fc2p61****</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetExternalSAMLIdentityProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetExternalSAMLIdentityProviderResponse
        /// </returns>
        public async Task<SetExternalSAMLIdentityProviderResponse> SetExternalSAMLIdentityProviderWithOptionsAsync(SetExternalSAMLIdentityProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingType))
            {
                query["BindingType"] = request.BindingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodedMetadataDocument))
            {
                query["EncodedMetadataDocument"] = request.EncodedMetadataDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginUrl))
            {
                query["LoginUrl"] = request.LoginUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSOStatus))
            {
                query["SSOStatus"] = request.SSOStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WantRequestSigned))
            {
                query["WantRequestSigned"] = request.WantRequestSigned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.X509Certificate))
            {
                query["X509Certificate"] = request.X509Certificate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetExternalSAMLIdentityProvider",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetExternalSAMLIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During SAML 2.0-based single sign-on (SSO) logon, CloudSSO is a service provider (SP), and the identity management system of an enterprise is an IdP.
        /// You can use one of the following methods to configure a SAML IdP. You can obtain the required metadata file or parameter values from your IdP.</para>
        /// <list type="bullet">
        /// <item><description>Use the metadata file: You can specify the <c>EncodedMetadataDocument</c> parameter to upload the metadata file.</description></item>
        /// <item><description>Manually configure the IdP: You can manually specify the following parameters for your IdP: <c>EntityId</c>, <c>LoginUrl</c>, <c>WantRequestSigned</c>, and <c>X509Certificate</c>.
        /// If you have configured a SAML IdP, the existing configurations are replaced after you call this operation.</description></item>
        /// <item><description>If the IdP is configured by using the metadata file, all existing configurations are replaced with new configurations.</description></item>
        /// <item><description>If the IdP is manually configured, the original parameter values that are different from the new parameter values are replaced.<remarks>
        /// <para> If SSO logon is enabled, new configurations immediately take effect. Take note of the impacts on the production environment.
        /// This topic provides an example on how to configure an IdP by using the metadata file within the directory <c>d-00fc2p61****</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetExternalSAMLIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// SetExternalSAMLIdentityProviderResponse
        /// </returns>
        public SetExternalSAMLIdentityProviderResponse SetExternalSAMLIdentityProvider(SetExternalSAMLIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetExternalSAMLIdentityProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a Security Assertion Markup Language (SAML) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During SAML 2.0-based single sign-on (SSO) logon, CloudSSO is a service provider (SP), and the identity management system of an enterprise is an IdP.
        /// You can use one of the following methods to configure a SAML IdP. You can obtain the required metadata file or parameter values from your IdP.</para>
        /// <list type="bullet">
        /// <item><description>Use the metadata file: You can specify the <c>EncodedMetadataDocument</c> parameter to upload the metadata file.</description></item>
        /// <item><description>Manually configure the IdP: You can manually specify the following parameters for your IdP: <c>EntityId</c>, <c>LoginUrl</c>, <c>WantRequestSigned</c>, and <c>X509Certificate</c>.
        /// If you have configured a SAML IdP, the existing configurations are replaced after you call this operation.</description></item>
        /// <item><description>If the IdP is configured by using the metadata file, all existing configurations are replaced with new configurations.</description></item>
        /// <item><description>If the IdP is manually configured, the original parameter values that are different from the new parameter values are replaced.<remarks>
        /// <para> If SSO logon is enabled, new configurations immediately take effect. Take note of the impacts on the production environment.
        /// This topic provides an example on how to configure an IdP by using the metadata file within the directory <c>d-00fc2p61****</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetExternalSAMLIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// SetExternalSAMLIdentityProviderResponse
        /// </returns>
        public async Task<SetExternalSAMLIdentityProviderResponse> SetExternalSAMLIdentityProviderAsync(SetExternalSAMLIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetExternalSAMLIdentityProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the logon preference of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoginPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoginPreferenceResponse
        /// </returns>
        public SetLoginPreferenceResponse SetLoginPreferenceWithOptions(SetLoginPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToGetCredentials))
            {
                query["AllowUserToGetCredentials"] = request.AllowUserToGetCredentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginNetworkMasks))
            {
                query["LoginNetworkMasks"] = request.LoginNetworkMasks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoginPreference",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoginPreferenceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the logon preference of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoginPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetLoginPreferenceResponse
        /// </returns>
        public async Task<SetLoginPreferenceResponse> SetLoginPreferenceWithOptionsAsync(SetLoginPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToGetCredentials))
            {
                query["AllowUserToGetCredentials"] = request.AllowUserToGetCredentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginNetworkMasks))
            {
                query["LoginNetworkMasks"] = request.LoginNetworkMasks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetLoginPreference",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetLoginPreferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the logon preference of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoginPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoginPreferenceResponse
        /// </returns>
        public SetLoginPreferenceResponse SetLoginPreference(SetLoginPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoginPreferenceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the logon preference of CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetLoginPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// SetLoginPreferenceResponse
        /// </returns>
        public async Task<SetLoginPreferenceResponse> SetLoginPreferenceAsync(SetLoginPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoginPreferenceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables multi-factor authentication (MFA) for users in a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a CloudSSO administrator enables username-password logon for users, CloudSSO automatically enables MFA to improve security. The administrator can call this operation to enable or disable MFA based on the business requirements.
        /// This topic provides an example on how to enable MFA for users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetMFAAuthenticationStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetMFAAuthenticationStatusResponse
        /// </returns>
        public SetMFAAuthenticationStatusResponse SetMFAAuthenticationStatusWithOptions(SetMFAAuthenticationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFAAuthenticationStatus))
            {
                query["MFAAuthenticationStatus"] = request.MFAAuthenticationStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetMFAAuthenticationStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetMFAAuthenticationStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables multi-factor authentication (MFA) for users in a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a CloudSSO administrator enables username-password logon for users, CloudSSO automatically enables MFA to improve security. The administrator can call this operation to enable or disable MFA based on the business requirements.
        /// This topic provides an example on how to enable MFA for users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetMFAAuthenticationStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetMFAAuthenticationStatusResponse
        /// </returns>
        public async Task<SetMFAAuthenticationStatusResponse> SetMFAAuthenticationStatusWithOptionsAsync(SetMFAAuthenticationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFAAuthenticationStatus))
            {
                query["MFAAuthenticationStatus"] = request.MFAAuthenticationStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetMFAAuthenticationStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetMFAAuthenticationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables multi-factor authentication (MFA) for users in a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a CloudSSO administrator enables username-password logon for users, CloudSSO automatically enables MFA to improve security. The administrator can call this operation to enable or disable MFA based on the business requirements.
        /// This topic provides an example on how to enable MFA for users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetMFAAuthenticationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetMFAAuthenticationStatusResponse
        /// </returns>
        public SetMFAAuthenticationStatusResponse SetMFAAuthenticationStatus(SetMFAAuthenticationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetMFAAuthenticationStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables multi-factor authentication (MFA) for users in a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a CloudSSO administrator enables username-password logon for users, CloudSSO automatically enables MFA to improve security. The administrator can call this operation to enable or disable MFA based on the business requirements.
        /// This topic provides an example on how to enable MFA for users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetMFAAuthenticationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetMFAAuthenticationStatusResponse
        /// </returns>
        public async Task<SetMFAAuthenticationStatusResponse> SetMFAAuthenticationStatusAsync(SetMFAAuthenticationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetMFAAuthenticationStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a password policy for CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetPasswordPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetPasswordPolicyResponse
        /// </returns>
        public SetPasswordPolicyResponse SetPasswordPolicyWithOptions(SetPasswordPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLoginAttempts))
            {
                query["MaxLoginAttempts"] = request.MaxLoginAttempts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPasswordAge))
            {
                query["MaxPasswordAge"] = request.MaxPasswordAge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinPasswordDifferentChars))
            {
                query["MinPasswordDifferentChars"] = request.MinPasswordDifferentChars;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinPasswordLength))
            {
                query["MinPasswordLength"] = request.MinPasswordLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordNotContainUsername))
            {
                query["PasswordNotContainUsername"] = request.PasswordNotContainUsername;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordReusePrevention))
            {
                query["PasswordReusePrevention"] = request.PasswordReusePrevention;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordPolicy",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a password policy for CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetPasswordPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetPasswordPolicyResponse
        /// </returns>
        public async Task<SetPasswordPolicyResponse> SetPasswordPolicyWithOptionsAsync(SetPasswordPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLoginAttempts))
            {
                query["MaxLoginAttempts"] = request.MaxLoginAttempts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPasswordAge))
            {
                query["MaxPasswordAge"] = request.MaxPasswordAge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinPasswordDifferentChars))
            {
                query["MinPasswordDifferentChars"] = request.MinPasswordDifferentChars;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinPasswordLength))
            {
                query["MinPasswordLength"] = request.MinPasswordLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordNotContainUsername))
            {
                query["PasswordNotContainUsername"] = request.PasswordNotContainUsername;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordReusePrevention))
            {
                query["PasswordReusePrevention"] = request.PasswordReusePrevention;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordPolicy",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a password policy for CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetPasswordPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// SetPasswordPolicyResponse
        /// </returns>
        public SetPasswordPolicyResponse SetPasswordPolicy(SetPasswordPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetPasswordPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a password policy for CloudSSO users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetPasswordPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// SetPasswordPolicyResponse
        /// </returns>
        public async Task<SetPasswordPolicyResponse> SetPasswordPolicyAsync(SetPasswordPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetPasswordPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables System for Cross-domain Identity Management (SCIM) synchronization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can synchronize users or groups from an external identity provider (IdP) that supports SCIM 2.0 to CloudSSO only after SCIM synchronization is enabled. If you disable SCIM synchronization, you can no longer synchronize users or groups to CloudSSO. The following list describes the impacts after SCIM synchronization is enabled or disabled:</para>
        /// <list type="bullet">
        /// <item><description>After you enable SCIM synchronization, you cannot modify or delete the users or groups that are synchronized to CloudSSO by using SCIM. In addition, you cannot add users to or remove users from the groups. However, you can change the passwords of the users and enable or disable the logon of the users.</description></item>
        /// <item><description>After you disable SCIM synchronization, you can modify and delete the users and groups that are synchronized to CloudSSO by using SCIM. You can also add users to or remove users from the groups.
        /// This topic provides an example on how to enable SCIM synchronization within the directory <c>d-00fc2p61****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetSCIMSynchronizationStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSCIMSynchronizationStatusResponse
        /// </returns>
        public SetSCIMSynchronizationStatusResponse SetSCIMSynchronizationStatusWithOptions(SetSCIMSynchronizationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SCIMSynchronizationStatus))
            {
                query["SCIMSynchronizationStatus"] = request.SCIMSynchronizationStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSCIMSynchronizationStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSCIMSynchronizationStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables System for Cross-domain Identity Management (SCIM) synchronization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can synchronize users or groups from an external identity provider (IdP) that supports SCIM 2.0 to CloudSSO only after SCIM synchronization is enabled. If you disable SCIM synchronization, you can no longer synchronize users or groups to CloudSSO. The following list describes the impacts after SCIM synchronization is enabled or disabled:</para>
        /// <list type="bullet">
        /// <item><description>After you enable SCIM synchronization, you cannot modify or delete the users or groups that are synchronized to CloudSSO by using SCIM. In addition, you cannot add users to or remove users from the groups. However, you can change the passwords of the users and enable or disable the logon of the users.</description></item>
        /// <item><description>After you disable SCIM synchronization, you can modify and delete the users and groups that are synchronized to CloudSSO by using SCIM. You can also add users to or remove users from the groups.
        /// This topic provides an example on how to enable SCIM synchronization within the directory <c>d-00fc2p61****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetSCIMSynchronizationStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSCIMSynchronizationStatusResponse
        /// </returns>
        public async Task<SetSCIMSynchronizationStatusResponse> SetSCIMSynchronizationStatusWithOptionsAsync(SetSCIMSynchronizationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SCIMSynchronizationStatus))
            {
                query["SCIMSynchronizationStatus"] = request.SCIMSynchronizationStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSCIMSynchronizationStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSCIMSynchronizationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables System for Cross-domain Identity Management (SCIM) synchronization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can synchronize users or groups from an external identity provider (IdP) that supports SCIM 2.0 to CloudSSO only after SCIM synchronization is enabled. If you disable SCIM synchronization, you can no longer synchronize users or groups to CloudSSO. The following list describes the impacts after SCIM synchronization is enabled or disabled:</para>
        /// <list type="bullet">
        /// <item><description>After you enable SCIM synchronization, you cannot modify or delete the users or groups that are synchronized to CloudSSO by using SCIM. In addition, you cannot add users to or remove users from the groups. However, you can change the passwords of the users and enable or disable the logon of the users.</description></item>
        /// <item><description>After you disable SCIM synchronization, you can modify and delete the users and groups that are synchronized to CloudSSO by using SCIM. You can also add users to or remove users from the groups.
        /// This topic provides an example on how to enable SCIM synchronization within the directory <c>d-00fc2p61****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetSCIMSynchronizationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSCIMSynchronizationStatusResponse
        /// </returns>
        public SetSCIMSynchronizationStatusResponse SetSCIMSynchronizationStatus(SetSCIMSynchronizationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSCIMSynchronizationStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables System for Cross-domain Identity Management (SCIM) synchronization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can synchronize users or groups from an external identity provider (IdP) that supports SCIM 2.0 to CloudSSO only after SCIM synchronization is enabled. If you disable SCIM synchronization, you can no longer synchronize users or groups to CloudSSO. The following list describes the impacts after SCIM synchronization is enabled or disabled:</para>
        /// <list type="bullet">
        /// <item><description>After you enable SCIM synchronization, you cannot modify or delete the users or groups that are synchronized to CloudSSO by using SCIM. In addition, you cannot add users to or remove users from the groups. However, you can change the passwords of the users and enable or disable the logon of the users.</description></item>
        /// <item><description>After you disable SCIM synchronization, you can modify and delete the users and groups that are synchronized to CloudSSO by using SCIM. You can also add users to or remove users from the groups.
        /// This topic provides an example on how to enable SCIM synchronization within the directory <c>d-00fc2p61****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetSCIMSynchronizationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSCIMSynchronizationStatusResponse
        /// </returns>
        public async Task<SetSCIMSynchronizationStatusResponse> SetSCIMSynchronizationStatusAsync(SetSCIMSynchronizationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSCIMSynchronizationStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify the <c>Description</c>, <c>SessionDuration</c>, and <c>RelayState</c> parameters for an access configuration.
        /// This topic provides an example on how to change the initial web page in the access configuration <c>ac-00jhtfl8thteu6uj****</c> to <c>https://cloudsso.console.aliyun.com</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccessConfigurationResponse
        /// </returns>
        public UpdateAccessConfigurationResponse UpdateAccessConfigurationWithOptions(UpdateAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRelayState))
            {
                query["NewRelayState"] = request.NewRelayState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSessionDuration))
            {
                query["NewSessionDuration"] = request.NewSessionDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccessConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify the <c>Description</c>, <c>SessionDuration</c>, and <c>RelayState</c> parameters for an access configuration.
        /// This topic provides an example on how to change the initial web page in the access configuration <c>ac-00jhtfl8thteu6uj****</c> to <c>https://cloudsso.console.aliyun.com</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccessConfigurationResponse
        /// </returns>
        public async Task<UpdateAccessConfigurationResponse> UpdateAccessConfigurationWithOptionsAsync(UpdateAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRelayState))
            {
                query["NewRelayState"] = request.NewRelayState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSessionDuration))
            {
                query["NewSessionDuration"] = request.NewSessionDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccessConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify the <c>Description</c>, <c>SessionDuration</c>, and <c>RelayState</c> parameters for an access configuration.
        /// This topic provides an example on how to change the initial web page in the access configuration <c>ac-00jhtfl8thteu6uj****</c> to <c>https://cloudsso.console.aliyun.com</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccessConfigurationResponse
        /// </returns>
        public UpdateAccessConfigurationResponse UpdateAccessConfiguration(UpdateAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccessConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify the <c>Description</c>, <c>SessionDuration</c>, and <c>RelayState</c> parameters for an access configuration.
        /// This topic provides an example on how to change the initial web page in the access configuration <c>ac-00jhtfl8thteu6uj****</c> to <c>https://cloudsso.console.aliyun.com</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccessConfigurationResponse
        /// </returns>
        public async Task<UpdateAccessConfigurationResponse> UpdateAccessConfigurationAsync(UpdateAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccessConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you change the name of a directory, the URL that is used to log on to the CloudSSO user portal is changed. You must notify the CloudSSO users of the correct URL.
        /// This topic provides an example on how to change the name of a directory to <c>new-example</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDirectoryResponse
        /// </returns>
        public UpdateDirectoryResponse UpdateDirectoryWithOptions(UpdateDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDirectoryName))
            {
                query["NewDirectoryName"] = request.NewDirectoryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDirectory",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you change the name of a directory, the URL that is used to log on to the CloudSSO user portal is changed. You must notify the CloudSSO users of the correct URL.
        /// This topic provides an example on how to change the name of a directory to <c>new-example</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDirectoryResponse
        /// </returns>
        public async Task<UpdateDirectoryResponse> UpdateDirectoryWithOptionsAsync(UpdateDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDirectoryName))
            {
                query["NewDirectoryName"] = request.NewDirectoryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDirectory",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you change the name of a directory, the URL that is used to log on to the CloudSSO user portal is changed. You must notify the CloudSSO users of the correct URL.
        /// This topic provides an example on how to change the name of a directory to <c>new-example</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDirectoryResponse
        /// </returns>
        public UpdateDirectoryResponse UpdateDirectory(UpdateDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDirectoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you change the name of a directory, the URL that is used to log on to the CloudSSO user portal is changed. You must notify the CloudSSO users of the correct URL.
        /// This topic provides an example on how to change the name of a directory to <c>new-example</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDirectoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDirectoryResponse
        /// </returns>
        public async Task<UpdateDirectoryResponse> UpdateDirectoryAsync(UpdateDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDirectoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify <c>GroupName</c> and <c>Description</c> for a group.</para>
        /// <remarks>
        /// <para> If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot modify information about a group that is synchronized by using SCIM.
        /// This topic provides an example on how to modify the name of the group <c>g-00jqzghi2n3o5hkh****</c> to <c>NewTestGroup</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public UpdateGroupResponse UpdateGroupWithOptions(UpdateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewGroupName))
            {
                query["NewGroupName"] = request.NewGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify <c>GroupName</c> and <c>Description</c> for a group.</para>
        /// <remarks>
        /// <para> If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot modify information about a group that is synchronized by using SCIM.
        /// This topic provides an example on how to modify the name of the group <c>g-00jqzghi2n3o5hkh****</c> to <c>NewTestGroup</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public async Task<UpdateGroupResponse> UpdateGroupWithOptionsAsync(UpdateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewGroupName))
            {
                query["NewGroupName"] = request.NewGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify <c>GroupName</c> and <c>Description</c> for a group.</para>
        /// <remarks>
        /// <para> If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot modify information about a group that is synchronized by using SCIM.
        /// This topic provides an example on how to modify the name of the group <c>g-00jqzghi2n3o5hkh****</c> to <c>NewTestGroup</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify <c>GroupName</c> and <c>Description</c> for a group.</para>
        /// <remarks>
        /// <para> If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot modify information about a group that is synchronized by using SCIM.
        /// This topic provides an example on how to modify the name of the group <c>g-00jqzghi2n3o5hkh****</c> to <c>NewTestGroup</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public async Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an inline policy that is created for an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to modify an inline policy that is created for the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInlinePolicyForAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInlinePolicyForAccessConfigurationResponse
        /// </returns>
        public UpdateInlinePolicyForAccessConfigurationResponse UpdateInlinePolicyForAccessConfigurationWithOptions(UpdateInlinePolicyForAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InlinePolicyName))
            {
                query["InlinePolicyName"] = request.InlinePolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewInlinePolicyDocument))
            {
                query["NewInlinePolicyDocument"] = request.NewInlinePolicyDocument;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInlinePolicyForAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInlinePolicyForAccessConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an inline policy that is created for an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to modify an inline policy that is created for the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInlinePolicyForAccessConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInlinePolicyForAccessConfigurationResponse
        /// </returns>
        public async Task<UpdateInlinePolicyForAccessConfigurationResponse> UpdateInlinePolicyForAccessConfigurationWithOptionsAsync(UpdateInlinePolicyForAccessConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessConfigurationId))
            {
                query["AccessConfigurationId"] = request.AccessConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InlinePolicyName))
            {
                query["InlinePolicyName"] = request.InlinePolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewInlinePolicyDocument))
            {
                query["NewInlinePolicyDocument"] = request.NewInlinePolicyDocument;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInlinePolicyForAccessConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInlinePolicyForAccessConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an inline policy that is created for an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to modify an inline policy that is created for the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInlinePolicyForAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInlinePolicyForAccessConfigurationResponse
        /// </returns>
        public UpdateInlinePolicyForAccessConfigurationResponse UpdateInlinePolicyForAccessConfiguration(UpdateInlinePolicyForAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInlinePolicyForAccessConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an inline policy that is created for an access configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to modify an inline policy that is created for the access configuration <c>ac-00jhtfl8thteu6uj****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInlinePolicyForAccessConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInlinePolicyForAccessConfigurationResponse
        /// </returns>
        public async Task<UpdateInlinePolicyForAccessConfigurationResponse> UpdateInlinePolicyForAccessConfigurationAsync(UpdateInlinePolicyForAccessConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInlinePolicyForAccessConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you enable username-password logon for CloudSSO users, you can also configure MFA for the users.
        /// This topic provides an example on how to enable MFA for all CloudSSO users that belong to the directory named <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMFAAuthenticationSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMFAAuthenticationSettingsResponse
        /// </returns>
        public UpdateMFAAuthenticationSettingsResponse UpdateMFAAuthenticationSettingsWithOptions(UpdateMFAAuthenticationSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFAAuthenticationSettings))
            {
                query["MFAAuthenticationSettings"] = request.MFAAuthenticationSettings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationForRiskLogin))
            {
                query["OperationForRiskLogin"] = request.OperationForRiskLogin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMFAAuthenticationSettings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMFAAuthenticationSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you enable username-password logon for CloudSSO users, you can also configure MFA for the users.
        /// This topic provides an example on how to enable MFA for all CloudSSO users that belong to the directory named <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMFAAuthenticationSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMFAAuthenticationSettingsResponse
        /// </returns>
        public async Task<UpdateMFAAuthenticationSettingsResponse> UpdateMFAAuthenticationSettingsWithOptionsAsync(UpdateMFAAuthenticationSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFAAuthenticationSettings))
            {
                query["MFAAuthenticationSettings"] = request.MFAAuthenticationSettings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationForRiskLogin))
            {
                query["OperationForRiskLogin"] = request.OperationForRiskLogin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMFAAuthenticationSettings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMFAAuthenticationSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you enable username-password logon for CloudSSO users, you can also configure MFA for the users.
        /// This topic provides an example on how to enable MFA for all CloudSSO users that belong to the directory named <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMFAAuthenticationSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMFAAuthenticationSettingsResponse
        /// </returns>
        public UpdateMFAAuthenticationSettingsResponse UpdateMFAAuthenticationSettings(UpdateMFAAuthenticationSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMFAAuthenticationSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the multi-factor authentication (MFA) setting of all users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you enable username-password logon for CloudSSO users, you can also configure MFA for the users.
        /// This topic provides an example on how to enable MFA for all CloudSSO users that belong to the directory named <c>d-00fc2p61****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMFAAuthenticationSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMFAAuthenticationSettingsResponse
        /// </returns>
        public async Task<UpdateMFAAuthenticationSettingsResponse> UpdateMFAAuthenticationSettingsAsync(UpdateMFAAuthenticationSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMFAAuthenticationSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to disable the SCIM credential whose ID is <c>scimcred-004whl0kvfwcypbi****</c>. After the SCIM credential is disabled, the synchronization task that uses the SCIM credential fails. You can call this operation again to enable the SCIM credential.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSCIMServerCredentialStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSCIMServerCredentialStatusResponse
        /// </returns>
        public UpdateSCIMServerCredentialStatusResponse UpdateSCIMServerCredentialStatusWithOptions(UpdateSCIMServerCredentialStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialId))
            {
                query["CredentialId"] = request.CredentialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewStatus))
            {
                query["NewStatus"] = request.NewStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSCIMServerCredentialStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSCIMServerCredentialStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to disable the SCIM credential whose ID is <c>scimcred-004whl0kvfwcypbi****</c>. After the SCIM credential is disabled, the synchronization task that uses the SCIM credential fails. You can call this operation again to enable the SCIM credential.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSCIMServerCredentialStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSCIMServerCredentialStatusResponse
        /// </returns>
        public async Task<UpdateSCIMServerCredentialStatusResponse> UpdateSCIMServerCredentialStatusWithOptionsAsync(UpdateSCIMServerCredentialStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialId))
            {
                query["CredentialId"] = request.CredentialId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewStatus))
            {
                query["NewStatus"] = request.NewStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSCIMServerCredentialStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSCIMServerCredentialStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to disable the SCIM credential whose ID is <c>scimcred-004whl0kvfwcypbi****</c>. After the SCIM credential is disabled, the synchronization task that uses the SCIM credential fails. You can call this operation again to enable the SCIM credential.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSCIMServerCredentialStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSCIMServerCredentialStatusResponse
        /// </returns>
        public UpdateSCIMServerCredentialStatusResponse UpdateSCIMServerCredentialStatus(UpdateSCIMServerCredentialStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSCIMServerCredentialStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables a System for Cross-domain Identity Management (SCIM) credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to disable the SCIM credential whose ID is <c>scimcred-004whl0kvfwcypbi****</c>. After the SCIM credential is disabled, the synchronization task that uses the SCIM credential fails. You can call this operation again to enable the SCIM credential.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSCIMServerCredentialStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSCIMServerCredentialStatusResponse
        /// </returns>
        public async Task<UpdateSCIMServerCredentialStatusResponse> UpdateSCIMServerCredentialStatusAsync(UpdateSCIMServerCredentialStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSCIMServerCredentialStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify <c>FirstName</c>, <c>LastName</c>, <c>DisplayName</c>, <c>Email</c>, and <c>Description</c> for a user. You cannot modify <c>UserName</c> for a user.</para>
        /// <remarks>
        /// <para> If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot modify information about a user that is synchronized by using SCIM.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewEmail))
            {
                query["NewEmail"] = request.NewEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFirstName))
            {
                query["NewFirstName"] = request.NewFirstName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewLastName))
            {
                query["NewLastName"] = request.NewLastName;
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
                Action = "UpdateUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify <c>FirstName</c>, <c>LastName</c>, <c>DisplayName</c>, <c>Email</c>, and <c>Description</c> for a user. You cannot modify <c>UserName</c> for a user.</para>
        /// <remarks>
        /// <para> If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot modify information about a user that is synchronized by using SCIM.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewEmail))
            {
                query["NewEmail"] = request.NewEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFirstName))
            {
                query["NewFirstName"] = request.NewFirstName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewLastName))
            {
                query["NewLastName"] = request.NewLastName;
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
                Action = "UpdateUser",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify <c>FirstName</c>, <c>LastName</c>, <c>DisplayName</c>, <c>Email</c>, and <c>Description</c> for a user. You cannot modify <c>UserName</c> for a user.</para>
        /// <remarks>
        /// <para> If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot modify information about a user that is synchronized by using SCIM.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify <c>FirstName</c>, <c>LastName</c>, <c>DisplayName</c>, <c>Email</c>, and <c>Description</c> for a user. You cannot modify <c>UserName</c> for a user.</para>
        /// <remarks>
        /// <para> If System for Cross-domain Identity Management (SCIM) synchronization is enabled, you cannot modify information about a user that is synchronized by using SCIM.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the multi-factor authentication (MFA) setting of a single user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call the <a href="https://help.aliyun.com/document_detail/450134.html">UpdateMFAAuthenticationSettings</a> operation to set the MFAAuthenticationSettings parameter to <c>Byuser</c>, user-specific settings are applied. Then, you must call the UpdateUserMFAAuthenticationSettings operation to configure MFA for each user.
        /// By default, the MFAAuthenticationSettings parameter is set to <c>Enabled</c> for a new user.
        /// This topic provides an example on how to enable MFA for the user named <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserMFAAuthenticationSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserMFAAuthenticationSettingsResponse
        /// </returns>
        public UpdateUserMFAAuthenticationSettingsResponse UpdateUserMFAAuthenticationSettingsWithOptions(UpdateUserMFAAuthenticationSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMFAAuthenticationSettings))
            {
                query["UserMFAAuthenticationSettings"] = request.UserMFAAuthenticationSettings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserMFAAuthenticationSettings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserMFAAuthenticationSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the multi-factor authentication (MFA) setting of a single user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call the <a href="https://help.aliyun.com/document_detail/450134.html">UpdateMFAAuthenticationSettings</a> operation to set the MFAAuthenticationSettings parameter to <c>Byuser</c>, user-specific settings are applied. Then, you must call the UpdateUserMFAAuthenticationSettings operation to configure MFA for each user.
        /// By default, the MFAAuthenticationSettings parameter is set to <c>Enabled</c> for a new user.
        /// This topic provides an example on how to enable MFA for the user named <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserMFAAuthenticationSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserMFAAuthenticationSettingsResponse
        /// </returns>
        public async Task<UpdateUserMFAAuthenticationSettingsResponse> UpdateUserMFAAuthenticationSettingsWithOptionsAsync(UpdateUserMFAAuthenticationSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMFAAuthenticationSettings))
            {
                query["UserMFAAuthenticationSettings"] = request.UserMFAAuthenticationSettings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserMFAAuthenticationSettings",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserMFAAuthenticationSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the multi-factor authentication (MFA) setting of a single user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call the <a href="https://help.aliyun.com/document_detail/450134.html">UpdateMFAAuthenticationSettings</a> operation to set the MFAAuthenticationSettings parameter to <c>Byuser</c>, user-specific settings are applied. Then, you must call the UpdateUserMFAAuthenticationSettings operation to configure MFA for each user.
        /// By default, the MFAAuthenticationSettings parameter is set to <c>Enabled</c> for a new user.
        /// This topic provides an example on how to enable MFA for the user named <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserMFAAuthenticationSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserMFAAuthenticationSettingsResponse
        /// </returns>
        public UpdateUserMFAAuthenticationSettingsResponse UpdateUserMFAAuthenticationSettings(UpdateUserMFAAuthenticationSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserMFAAuthenticationSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the multi-factor authentication (MFA) setting of a single user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call the <a href="https://help.aliyun.com/document_detail/450134.html">UpdateMFAAuthenticationSettings</a> operation to set the MFAAuthenticationSettings parameter to <c>Byuser</c>, user-specific settings are applied. Then, you must call the UpdateUserMFAAuthenticationSettings operation to configure MFA for each user.
        /// By default, the MFAAuthenticationSettings parameter is set to <c>Enabled</c> for a new user.
        /// This topic provides an example on how to enable MFA for the user named <c>u-00q8wbq42wiltcrk****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserMFAAuthenticationSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserMFAAuthenticationSettingsResponse
        /// </returns>
        public async Task<UpdateUserMFAAuthenticationSettingsResponse> UpdateUserMFAAuthenticationSettingsAsync(UpdateUserMFAAuthenticationSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserMFAAuthenticationSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserProvisioningRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserProvisioningResponse
        /// </returns>
        public UpdateUserProvisioningResponse UpdateUserProvisioningWithOptions(UpdateUserProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDeletionStrategy))
            {
                query["NewDeletionStrategy"] = request.NewDeletionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDuplicationStrategy))
            {
                query["NewDuplicationStrategy"] = request.NewDuplicationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserProvisioning",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserProvisioningResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserProvisioningRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserProvisioningResponse
        /// </returns>
        public async Task<UpdateUserProvisioningResponse> UpdateUserProvisioningWithOptionsAsync(UpdateUserProvisioningRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDeletionStrategy))
            {
                query["NewDeletionStrategy"] = request.NewDeletionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDuplicationStrategy))
            {
                query["NewDuplicationStrategy"] = request.NewDuplicationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvisioningId))
            {
                query["UserProvisioningId"] = request.UserProvisioningId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserProvisioning",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserProvisioningResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserProvisioningRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserProvisioningResponse
        /// </returns>
        public UpdateUserProvisioningResponse UpdateUserProvisioning(UpdateUserProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserProvisioningWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserProvisioningRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserProvisioningResponse
        /// </returns>
        public async Task<UpdateUserProvisioningResponse> UpdateUserProvisioningAsync(UpdateUserProvisioningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserProvisioningWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the global configurations of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserProvisioningConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserProvisioningConfigurationResponse
        /// </returns>
        public UpdateUserProvisioningConfigurationResponse UpdateUserProvisioningConfigurationWithOptions(UpdateUserProvisioningConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDefaultLandingPage))
            {
                query["NewDefaultLandingPage"] = request.NewDefaultLandingPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSessionDuration))
            {
                query["NewSessionDuration"] = request.NewSessionDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserProvisioningConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserProvisioningConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the global configurations of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserProvisioningConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserProvisioningConfigurationResponse
        /// </returns>
        public async Task<UpdateUserProvisioningConfigurationResponse> UpdateUserProvisioningConfigurationWithOptionsAsync(UpdateUserProvisioningConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDefaultLandingPage))
            {
                query["NewDefaultLandingPage"] = request.NewDefaultLandingPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSessionDuration))
            {
                query["NewSessionDuration"] = request.NewSessionDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserProvisioningConfiguration",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserProvisioningConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the global configurations of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserProvisioningConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserProvisioningConfigurationResponse
        /// </returns>
        public UpdateUserProvisioningConfigurationResponse UpdateUserProvisioningConfiguration(UpdateUserProvisioningConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserProvisioningConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the global configurations of a Resource Access Management (RAM) user provisioning.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserProvisioningConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserProvisioningConfigurationResponse
        /// </returns>
        public async Task<UpdateUserProvisioningConfigurationResponse> UpdateUserProvisioningConfigurationAsync(UpdateUserProvisioningConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserProvisioningConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to change the status of the user whose ID is <c>u-00q8wbq42wiltcrk****</c> to Disabled. Users in the Disabled state cannot log on to the CloudSSO user portal.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserStatusResponse
        /// </returns>
        public UpdateUserStatusResponse UpdateUserStatusWithOptions(UpdateUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewStatus))
            {
                query["NewStatus"] = request.NewStatus;
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
                Action = "UpdateUserStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to change the status of the user whose ID is <c>u-00q8wbq42wiltcrk****</c> to Disabled. Users in the Disabled state cannot log on to the CloudSSO user portal.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserStatusResponse
        /// </returns>
        public async Task<UpdateUserStatusResponse> UpdateUserStatusWithOptionsAsync(UpdateUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewStatus))
            {
                query["NewStatus"] = request.NewStatus;
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
                Action = "UpdateUserStatus",
                Version = "2021-05-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to change the status of the user whose ID is <c>u-00q8wbq42wiltcrk****</c> to Disabled. Users in the Disabled state cannot log on to the CloudSSO user portal.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserStatusResponse
        /// </returns>
        public UpdateUserStatusResponse UpdateUserStatus(UpdateUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the status of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to change the status of the user whose ID is <c>u-00q8wbq42wiltcrk****</c> to Disabled. Users in the Disabled state cannot log on to the CloudSSO user portal.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateUserStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserStatusResponse
        /// </returns>
        public async Task<UpdateUserStatusResponse> UpdateUserStatusAsync(UpdateUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserStatusWithOptionsAsync(request, runtime);
        }

    }
}
