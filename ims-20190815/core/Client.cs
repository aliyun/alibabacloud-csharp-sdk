// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ims20190815.Models;

namespace AlibabaCloud.SDK.Ims20190815
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ims", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Adds a client ID to an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddClientIdToOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddClientIdToOIDCProviderResponse
        /// </returns>
        public AddClientIdToOIDCProviderResponse AddClientIdToOIDCProviderWithOptions(AddClientIdToOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddClientIdToOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddClientIdToOIDCProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a client ID to an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddClientIdToOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddClientIdToOIDCProviderResponse
        /// </returns>
        public async Task<AddClientIdToOIDCProviderResponse> AddClientIdToOIDCProviderWithOptionsAsync(AddClientIdToOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddClientIdToOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddClientIdToOIDCProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a client ID to an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddClientIdToOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// AddClientIdToOIDCProviderResponse
        /// </returns>
        public AddClientIdToOIDCProviderResponse AddClientIdToOIDCProvider(AddClientIdToOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddClientIdToOIDCProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a client ID to an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddClientIdToOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// AddClientIdToOIDCProviderResponse
        /// </returns>
        public async Task<AddClientIdToOIDCProviderResponse> AddClientIdToOIDCProviderAsync(AddClientIdToOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddClientIdToOIDCProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a fingerprint to an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to add the fingerprint <c>902ef2deeb3c5b13ea4c3d5193629309e231****</c> to the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddFingerprintToOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddFingerprintToOIDCProviderResponse
        /// </returns>
        public AddFingerprintToOIDCProviderResponse AddFingerprintToOIDCProviderWithOptions(AddFingerprintToOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fingerprint))
            {
                query["Fingerprint"] = request.Fingerprint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFingerprintToOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFingerprintToOIDCProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a fingerprint to an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to add the fingerprint <c>902ef2deeb3c5b13ea4c3d5193629309e231****</c> to the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddFingerprintToOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddFingerprintToOIDCProviderResponse
        /// </returns>
        public async Task<AddFingerprintToOIDCProviderResponse> AddFingerprintToOIDCProviderWithOptionsAsync(AddFingerprintToOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fingerprint))
            {
                query["Fingerprint"] = request.Fingerprint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFingerprintToOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFingerprintToOIDCProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a fingerprint to an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to add the fingerprint <c>902ef2deeb3c5b13ea4c3d5193629309e231****</c> to the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddFingerprintToOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// AddFingerprintToOIDCProviderResponse
        /// </returns>
        public AddFingerprintToOIDCProviderResponse AddFingerprintToOIDCProvider(AddFingerprintToOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFingerprintToOIDCProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a fingerprint to an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to add the fingerprint <c>902ef2deeb3c5b13ea4c3d5193629309e231****</c> to the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddFingerprintToOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// AddFingerprintToOIDCProviderResponse
        /// </returns>
        public async Task<AddFingerprintToOIDCProviderResponse> AddFingerprintToOIDCProviderAsync(AddFingerprintToOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFingerprintToOIDCProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a Resource Access Management (RAM) user to a RAM user group.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserToGroup",
                Version = "2019-08-15",
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
        /// <para>Adds a Resource Access Management (RAM) user to a RAM user group.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserToGroup",
                Version = "2019-08-15",
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
        /// <para>Adds a Resource Access Management (RAM) user to a RAM user group.</para>
        /// </summary>
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
        /// <para>Adds a Resource Access Management (RAM) user to a RAM user group.</para>
        /// </summary>
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
        /// <para>Binds a multi-factor authentication (MFA) device to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindMFADeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindMFADeviceResponse
        /// </returns>
        public BindMFADeviceResponse BindMFADeviceWithOptions(BindMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode1))
            {
                query["AuthenticationCode1"] = request.AuthenticationCode1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode2))
            {
                query["AuthenticationCode2"] = request.AuthenticationCode2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindMFADevice",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindMFADeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a multi-factor authentication (MFA) device to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindMFADeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindMFADeviceResponse
        /// </returns>
        public async Task<BindMFADeviceResponse> BindMFADeviceWithOptionsAsync(BindMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode1))
            {
                query["AuthenticationCode1"] = request.AuthenticationCode1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode2))
            {
                query["AuthenticationCode2"] = request.AuthenticationCode2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindMFADevice",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindMFADeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a multi-factor authentication (MFA) device to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindMFADeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// BindMFADeviceResponse
        /// </returns>
        public BindMFADeviceResponse BindMFADevice(BindMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindMFADeviceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a multi-factor authentication (MFA) device to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindMFADeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// BindMFADeviceResponse
        /// </returns>
        public async Task<BindMFADeviceResponse> BindMFADeviceAsync(BindMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindMFADeviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the password that is used to log on to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation is available only for RAM users. Before you call this operation, make sure that <c>AllowUserToChangePassword</c> in <a href="https://help.aliyun.com/document_detail/43765.html">SetSecurityPreference</a> is set to <c>True</c>. The value True indicates that RAM users can manage their passwords.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangePasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangePasswordResponse
        /// </returns>
        public ChangePasswordResponse ChangePasswordWithOptions(ChangePasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPassword))
            {
                query["NewPassword"] = request.NewPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPassword))
            {
                query["OldPassword"] = request.OldPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangePassword",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangePasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the password that is used to log on to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation is available only for RAM users. Before you call this operation, make sure that <c>AllowUserToChangePassword</c> in <a href="https://help.aliyun.com/document_detail/43765.html">SetSecurityPreference</a> is set to <c>True</c>. The value True indicates that RAM users can manage their passwords.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangePasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangePasswordResponse
        /// </returns>
        public async Task<ChangePasswordResponse> ChangePasswordWithOptionsAsync(ChangePasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPassword))
            {
                query["NewPassword"] = request.NewPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPassword))
            {
                query["OldPassword"] = request.OldPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangePassword",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangePasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the password that is used to log on to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation is available only for RAM users. Before you call this operation, make sure that <c>AllowUserToChangePassword</c> in <a href="https://help.aliyun.com/document_detail/43765.html">SetSecurityPreference</a> is set to <c>True</c>. The value True indicates that RAM users can manage their passwords.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangePasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangePasswordResponse
        /// </returns>
        public ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangePasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the password that is used to log on to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation is available only for RAM users. Before you call this operation, make sure that <c>AllowUserToChangePassword</c> in <a href="https://help.aliyun.com/document_detail/43765.html">SetSecurityPreference</a> is set to <c>True</c>. The value True indicates that RAM users can manage their passwords.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangePasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangePasswordResponse
        /// </returns>
        public async Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangePasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessKeyResponse
        /// </returns>
        public CreateAccessKeyResponse CreateAccessKeyWithOptions(CreateAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessKey",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessKeyResponse
        /// </returns>
        public async Task<CreateAccessKeyResponse> CreateAccessKeyWithOptionsAsync(CreateAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessKey",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessKeyResponse
        /// </returns>
        public CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessKeyResponse
        /// </returns>
        public async Task<CreateAccessKeyResponse> CreateAccessKeyAsync(CreateAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application secret for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppSecretResponse
        /// </returns>
        public CreateAppSecretResponse CreateAppSecretWithOptions(CreateAppSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppSecret",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application secret for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppSecretResponse
        /// </returns>
        public async Task<CreateAppSecretResponse> CreateAppSecretWithOptionsAsync(CreateAppSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppSecret",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application secret for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppSecretResponse
        /// </returns>
        public CreateAppSecretResponse CreateAppSecret(CreateAppSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppSecretWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application secret for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppSecretResponse
        /// </returns>
        public async Task<CreateAppSecretResponse> CreateAppSecretAsync(CreateAppSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppSecretWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public CreateApplicationResponse CreateApplicationWithOptions(CreateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenValidity))
            {
                query["AccessTokenValidity"] = request.AccessTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMultiTenant))
            {
                query["IsMultiTenant"] = request.IsMultiTenant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredefinedScopes))
            {
                query["PredefinedScopes"] = request.PredefinedScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolVersion))
            {
                query["ProtocolVersion"] = request.ProtocolVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUris))
            {
                query["RedirectUris"] = request.RedirectUris;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshTokenValidity))
            {
                query["RefreshTokenValidity"] = request.RefreshTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequiredScopes))
            {
                query["RequiredScopes"] = request.RequiredScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretRequired))
            {
                query["SecretRequired"] = request.SecretRequired;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public async Task<CreateApplicationResponse> CreateApplicationWithOptionsAsync(CreateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenValidity))
            {
                query["AccessTokenValidity"] = request.AccessTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMultiTenant))
            {
                query["IsMultiTenant"] = request.IsMultiTenant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredefinedScopes))
            {
                query["PredefinedScopes"] = request.PredefinedScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolVersion))
            {
                query["ProtocolVersion"] = request.ProtocolVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUris))
            {
                query["RedirectUris"] = request.RedirectUris;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshTokenValidity))
            {
                query["RefreshTokenValidity"] = request.RefreshTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequiredScopes))
            {
                query["RequiredScopes"] = request.RequiredScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretRequired))
            {
                query["SecretRequired"] = request.SecretRequired;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
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
                Version = "2019-08-15",
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
        /// <para>Creates a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
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
                Version = "2019-08-15",
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
        /// <para>Creates a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
        /// <para>Creates a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
        /// <para>Enables logon to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoginProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoginProfileResponse
        /// </returns>
        public CreateLoginProfileResponse CreateLoginProfileWithOptions(CreateLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFABindRequired))
            {
                query["MFABindRequired"] = request.MFABindRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordResetRequired))
            {
                query["PasswordResetRequired"] = request.PasswordResetRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoginProfile",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoginProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables logon to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoginProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLoginProfileResponse
        /// </returns>
        public async Task<CreateLoginProfileResponse> CreateLoginProfileWithOptionsAsync(CreateLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFABindRequired))
            {
                query["MFABindRequired"] = request.MFABindRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordResetRequired))
            {
                query["PasswordResetRequired"] = request.PasswordResetRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoginProfile",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoginProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables logon to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoginProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoginProfileResponse
        /// </returns>
        public CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoginProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables logon to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLoginProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLoginProfileResponse
        /// </returns>
        public async Task<CreateLoginProfileResponse> CreateLoginProfileAsync(CreateLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoginProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an OpenID Connect (OIDC) identity provider (IdP) to configure a trust relationship between Alibaba Cloud and an external IdP. This topic provides an example on how to create an IdP named TestOIDCProvider to configure a trust relationship between the external IdP Okta and Alibaba Cloud.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>Before you call this operation, make sure that the information such as the URL of the issuer, the fingerprints of HTTPS certificate authority (CA) certificates, and the client IDs are obtained from an external IdP, such as Google Workspace or Okta.</para>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>You can create a maximum of 100 OIDC IdPs in an Alibaba Cloud account.</description></item>
        /// <item><description>You can add a maximum of 50 client IDs to an OIDC IdP.</description></item>
        /// <item><description>You can add a maximum of five fingerprints to an OIDC IdP.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to create an IdP named <c>TestOIDCProvider</c> to configure a trust relationship between the external IdP and Alibaba Cloud.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOIDCProviderResponse
        /// </returns>
        public CreateOIDCProviderResponse CreateOIDCProviderWithOptions(CreateOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIds))
            {
                query["ClientIds"] = request.ClientIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fingerprints))
            {
                query["Fingerprints"] = request.Fingerprints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuanceLimitTime))
            {
                query["IssuanceLimitTime"] = request.IssuanceLimitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuerUrl))
            {
                query["IssuerUrl"] = request.IssuerUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOIDCProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an OpenID Connect (OIDC) identity provider (IdP) to configure a trust relationship between Alibaba Cloud and an external IdP. This topic provides an example on how to create an IdP named TestOIDCProvider to configure a trust relationship between the external IdP Okta and Alibaba Cloud.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>Before you call this operation, make sure that the information such as the URL of the issuer, the fingerprints of HTTPS certificate authority (CA) certificates, and the client IDs are obtained from an external IdP, such as Google Workspace or Okta.</para>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>You can create a maximum of 100 OIDC IdPs in an Alibaba Cloud account.</description></item>
        /// <item><description>You can add a maximum of 50 client IDs to an OIDC IdP.</description></item>
        /// <item><description>You can add a maximum of five fingerprints to an OIDC IdP.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to create an IdP named <c>TestOIDCProvider</c> to configure a trust relationship between the external IdP and Alibaba Cloud.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOIDCProviderResponse
        /// </returns>
        public async Task<CreateOIDCProviderResponse> CreateOIDCProviderWithOptionsAsync(CreateOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIds))
            {
                query["ClientIds"] = request.ClientIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fingerprints))
            {
                query["Fingerprints"] = request.Fingerprints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuanceLimitTime))
            {
                query["IssuanceLimitTime"] = request.IssuanceLimitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuerUrl))
            {
                query["IssuerUrl"] = request.IssuerUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOIDCProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an OpenID Connect (OIDC) identity provider (IdP) to configure a trust relationship between Alibaba Cloud and an external IdP. This topic provides an example on how to create an IdP named TestOIDCProvider to configure a trust relationship between the external IdP Okta and Alibaba Cloud.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>Before you call this operation, make sure that the information such as the URL of the issuer, the fingerprints of HTTPS certificate authority (CA) certificates, and the client IDs are obtained from an external IdP, such as Google Workspace or Okta.</para>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>You can create a maximum of 100 OIDC IdPs in an Alibaba Cloud account.</description></item>
        /// <item><description>You can add a maximum of 50 client IDs to an OIDC IdP.</description></item>
        /// <item><description>You can add a maximum of five fingerprints to an OIDC IdP.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to create an IdP named <c>TestOIDCProvider</c> to configure a trust relationship between the external IdP and Alibaba Cloud.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOIDCProviderResponse
        /// </returns>
        public CreateOIDCProviderResponse CreateOIDCProvider(CreateOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOIDCProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an OpenID Connect (OIDC) identity provider (IdP) to configure a trust relationship between Alibaba Cloud and an external IdP. This topic provides an example on how to create an IdP named TestOIDCProvider to configure a trust relationship between the external IdP Okta and Alibaba Cloud.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Prerequisites</h3>
        /// <para>Before you call this operation, make sure that the information such as the URL of the issuer, the fingerprints of HTTPS certificate authority (CA) certificates, and the client IDs are obtained from an external IdP, such as Google Workspace or Okta.</para>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>You can create a maximum of 100 OIDC IdPs in an Alibaba Cloud account.</description></item>
        /// <item><description>You can add a maximum of 50 client IDs to an OIDC IdP.</description></item>
        /// <item><description>You can add a maximum of five fingerprints to an OIDC IdP.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Operation description</h3>
        /// <para>This topic provides an example on how to create an IdP named <c>TestOIDCProvider</c> to configure a trust relationship between the external IdP and Alibaba Cloud.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOIDCProviderResponse
        /// </returns>
        public async Task<CreateOIDCProviderResponse> CreateOIDCProviderAsync(CreateOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOIDCProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSAMLProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSAMLProviderResponse
        /// </returns>
        public CreateSAMLProviderResponse CreateSAMLProviderWithOptions(CreateSAMLProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthnSignAlgo))
            {
                query["AuthnSignAlgo"] = request.AuthnSignAlgo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodedSAMLMetadataDocument))
            {
                query["EncodedSAMLMetadataDocument"] = request.EncodedSAMLMetadataDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderName))
            {
                query["SAMLProviderName"] = request.SAMLProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSAMLProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSAMLProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSAMLProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSAMLProviderResponse
        /// </returns>
        public async Task<CreateSAMLProviderResponse> CreateSAMLProviderWithOptionsAsync(CreateSAMLProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthnSignAlgo))
            {
                query["AuthnSignAlgo"] = request.AuthnSignAlgo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodedSAMLMetadataDocument))
            {
                query["EncodedSAMLMetadataDocument"] = request.EncodedSAMLMetadataDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderName))
            {
                query["SAMLProviderName"] = request.SAMLProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSAMLProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSAMLProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSAMLProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSAMLProviderResponse
        /// </returns>
        public CreateSAMLProviderResponse CreateSAMLProvider(CreateSAMLProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSAMLProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSAMLProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSAMLProviderResponse
        /// </returns>
        public async Task<CreateSAMLProviderResponse> CreateSAMLProviderAsync(CreateSAMLProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSAMLProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a RAM user named <c>test</c>.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilePhone))
            {
                query["MobilePhone"] = request.MobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2019-08-15",
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
        /// <para>Creates a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a RAM user named <c>test</c>.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilePhone))
            {
                query["MobilePhone"] = request.MobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2019-08-15",
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
        /// <para>Creates a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a RAM user named <c>test</c>.</para>
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
        /// <para>Creates a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to create a RAM user named <c>test</c>.</para>
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
        /// <para>Creates a virtual multi-factor authentication (MFA) device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualMFADeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualMFADeviceResponse
        /// </returns>
        public CreateVirtualMFADeviceResponse CreateVirtualMFADeviceWithOptions(CreateVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualMFADeviceName))
            {
                query["VirtualMFADeviceName"] = request.VirtualMFADeviceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualMFADevice",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualMFADeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual multi-factor authentication (MFA) device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualMFADeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualMFADeviceResponse
        /// </returns>
        public async Task<CreateVirtualMFADeviceResponse> CreateVirtualMFADeviceWithOptionsAsync(CreateVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualMFADeviceName))
            {
                query["VirtualMFADeviceName"] = request.VirtualMFADeviceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualMFADevice",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualMFADeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual multi-factor authentication (MFA) device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualMFADeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualMFADeviceResponse
        /// </returns>
        public CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVirtualMFADeviceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual multi-factor authentication (MFA) device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualMFADeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualMFADeviceResponse
        /// </returns>
        public async Task<CreateVirtualMFADeviceResponse> CreateVirtualMFADeviceAsync(CreateVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVirtualMFADeviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessKeyResponse
        /// </returns>
        public DeleteAccessKeyResponse DeleteAccessKeyWithOptions(DeleteAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessKey",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessKeyResponse
        /// </returns>
        public async Task<DeleteAccessKeyResponse> DeleteAccessKeyWithOptionsAsync(DeleteAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessKey",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessKeyResponse
        /// </returns>
        public DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessKeyResponse
        /// </returns>
        public async Task<DeleteAccessKeyResponse> DeleteAccessKeyAsync(DeleteAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific AccessKey pair that belongs to a Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessKeyInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessKeyInRecycleBinResponse
        /// </returns>
        public DeleteAccessKeyInRecycleBinResponse DeleteAccessKeyInRecycleBinWithOptions(DeleteAccessKeyInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
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
                Action = "DeleteAccessKeyInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessKeyInRecycleBinResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific AccessKey pair that belongs to a Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessKeyInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessKeyInRecycleBinResponse
        /// </returns>
        public async Task<DeleteAccessKeyInRecycleBinResponse> DeleteAccessKeyInRecycleBinWithOptionsAsync(DeleteAccessKeyInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
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
                Action = "DeleteAccessKeyInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessKeyInRecycleBinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific AccessKey pair that belongs to a Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessKeyInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessKeyInRecycleBinResponse
        /// </returns>
        public DeleteAccessKeyInRecycleBinResponse DeleteAccessKeyInRecycleBin(DeleteAccessKeyInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessKeyInRecycleBinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific AccessKey pair that belongs to a Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessKeyInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessKeyInRecycleBinResponse
        /// </returns>
        public async Task<DeleteAccessKeyInRecycleBinResponse> DeleteAccessKeyInRecycleBinAsync(DeleteAccessKeyInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessKeyInRecycleBinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the application secret of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppSecretResponse
        /// </returns>
        public DeleteAppSecretResponse DeleteAppSecretWithOptions(DeleteAppSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecretId))
            {
                query["AppSecretId"] = request.AppSecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppSecret",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the application secret of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppSecretResponse
        /// </returns>
        public async Task<DeleteAppSecretResponse> DeleteAppSecretWithOptionsAsync(DeleteAppSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecretId))
            {
                query["AppSecretId"] = request.AppSecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppSecret",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the application secret of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppSecretResponse
        /// </returns>
        public DeleteAppSecretResponse DeleteAppSecret(DeleteAppSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppSecretWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the application secret of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppSecretResponse
        /// </returns>
        public async Task<DeleteAppSecretResponse> DeleteAppSecretAsync(DeleteAppSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppSecretWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public DeleteApplicationResponse DeleteApplicationWithOptions(DeleteApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public async Task<DeleteApplicationResponse> DeleteApplicationWithOptionsAsync(DeleteApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Resource Access Management (RAM) user group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a RAM user group, make sure that no policies are attached to the group and no RAM users are included in the group.</para>
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
                Action = "DeleteGroup",
                Version = "2019-08-15",
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
        /// <para>Deletes a Resource Access Management (RAM) user group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a RAM user group, make sure that no policies are attached to the group and no RAM users are included in the group.</para>
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
                Action = "DeleteGroup",
                Version = "2019-08-15",
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
        /// <para>Deletes a Resource Access Management (RAM) user group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a RAM user group, make sure that no policies are attached to the group and no RAM users are included in the group.</para>
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
        /// <para>Deletes a Resource Access Management (RAM) user group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a RAM user group, make sure that no policies are attached to the group and no RAM users are included in the group.</para>
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
        /// <para>Disables logon to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoginProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoginProfileResponse
        /// </returns>
        public DeleteLoginProfileResponse DeleteLoginProfileWithOptions(DeleteLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoginProfile",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoginProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables logon to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoginProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoginProfileResponse
        /// </returns>
        public async Task<DeleteLoginProfileResponse> DeleteLoginProfileWithOptionsAsync(DeleteLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoginProfile",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoginProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables logon to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoginProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoginProfileResponse
        /// </returns>
        public DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoginProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables logon to the console for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLoginProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLoginProfileResponse
        /// </returns>
        public async Task<DeleteLoginProfileResponse> DeleteLoginProfileAsync(DeleteLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoginProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOIDCProviderResponse
        /// </returns>
        public DeleteOIDCProviderResponse DeleteOIDCProviderWithOptions(DeleteOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOIDCProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOIDCProviderResponse
        /// </returns>
        public async Task<DeleteOIDCProviderResponse> DeleteOIDCProviderWithOptionsAsync(DeleteOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOIDCProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOIDCProviderResponse
        /// </returns>
        public DeleteOIDCProviderResponse DeleteOIDCProvider(DeleteOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOIDCProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOIDCProviderResponse
        /// </returns>
        public async Task<DeleteOIDCProviderResponse> DeleteOIDCProviderAsync(DeleteOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOIDCProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a passkey for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePasskeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePasskeyResponse
        /// </returns>
        public DeletePasskeyResponse DeletePasskeyWithOptions(DeletePasskeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasskeyId))
            {
                query["PasskeyId"] = request.PasskeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePasskey",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePasskeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a passkey for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePasskeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePasskeyResponse
        /// </returns>
        public async Task<DeletePasskeyResponse> DeletePasskeyWithOptionsAsync(DeletePasskeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasskeyId))
            {
                query["PasskeyId"] = request.PasskeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePasskey",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePasskeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a passkey for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePasskeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePasskeyResponse
        /// </returns>
        public DeletePasskeyResponse DeletePasskey(DeletePasskeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePasskeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a passkey for a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePasskeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePasskeyResponse
        /// </returns>
        public async Task<DeletePasskeyResponse> DeletePasskeyAsync(DeletePasskeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePasskeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSAMLProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSAMLProviderResponse
        /// </returns>
        public DeleteSAMLProviderResponse DeleteSAMLProviderWithOptions(DeleteSAMLProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderName))
            {
                query["SAMLProviderName"] = request.SAMLProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSAMLProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSAMLProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSAMLProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSAMLProviderResponse
        /// </returns>
        public async Task<DeleteSAMLProviderResponse> DeleteSAMLProviderWithOptionsAsync(DeleteSAMLProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderName))
            {
                query["SAMLProviderName"] = request.SAMLProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSAMLProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSAMLProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSAMLProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSAMLProviderResponse
        /// </returns>
        public DeleteSAMLProviderResponse DeleteSAMLProvider(DeleteSAMLProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSAMLProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSAMLProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSAMLProviderResponse
        /// </returns>
        public async Task<DeleteSAMLProviderResponse> DeleteSAMLProviderAsync(DeleteSAMLProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSAMLProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Resource Access Management (RAM) user.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2019-08-15",
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
        /// <para>Deletes a Resource Access Management (RAM) user.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2019-08-15",
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
        /// <para>Deletes a Resource Access Management (RAM) user.</para>
        /// </summary>
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
        /// <para>Deletes a Resource Access Management (RAM) user.</para>
        /// </summary>
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
        /// <para>Deletes a specific Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserInRecycleBinResponse
        /// </returns>
        public DeleteUserInRecycleBinResponse DeleteUserInRecycleBinWithOptions(DeleteUserInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteUserInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserInRecycleBinResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserInRecycleBinResponse
        /// </returns>
        public async Task<DeleteUserInRecycleBinResponse> DeleteUserInRecycleBinWithOptionsAsync(DeleteUserInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteUserInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserInRecycleBinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserInRecycleBinResponse
        /// </returns>
        public DeleteUserInRecycleBinResponse DeleteUserInRecycleBin(DeleteUserInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserInRecycleBinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specific Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserInRecycleBinResponse
        /// </returns>
        public async Task<DeleteUserInRecycleBinResponse> DeleteUserInRecycleBinAsync(DeleteUserInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserInRecycleBinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a multi-factor authentication (MFA) device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualMFADeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualMFADeviceResponse
        /// </returns>
        public DeleteVirtualMFADeviceResponse DeleteVirtualMFADeviceWithOptions(DeleteVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteVirtualMFADevice",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualMFADeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a multi-factor authentication (MFA) device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualMFADeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualMFADeviceResponse
        /// </returns>
        public async Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceWithOptionsAsync(DeleteVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteVirtualMFADevice",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualMFADeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a multi-factor authentication (MFA) device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualMFADeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualMFADeviceResponse
        /// </returns>
        public DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVirtualMFADeviceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a multi-factor authentication (MFA) device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualMFADeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualMFADeviceResponse
        /// </returns>
        public async Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVirtualMFADeviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an external application or an internal application of the ServerApp type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to call this operation to uninstall an internal application, the type of the internal application must be <b>ServerApp</b>. Otherwise, an error occurs when you call this operation.</para>
        /// <remarks>
        /// <para> For <b>internal applications</b>, only internal applications of the ServerApp type need to be <b>installed or provisioned</b>. Therefore, only internal applications of the ServerApp type <b>can be uninstalled</b>. Internal applications of the WebApp and NativeApp types <b>do not need to and cannot be uninstalled</b>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeprovisionApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionApplicationResponse
        /// </returns>
        public DeprovisionApplicationResponse DeprovisionApplicationWithOptions(DeprovisionApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeprovisionApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeprovisionApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an external application or an internal application of the ServerApp type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to call this operation to uninstall an internal application, the type of the internal application must be <b>ServerApp</b>. Otherwise, an error occurs when you call this operation.</para>
        /// <remarks>
        /// <para> For <b>internal applications</b>, only internal applications of the ServerApp type need to be <b>installed or provisioned</b>. Therefore, only internal applications of the ServerApp type <b>can be uninstalled</b>. Internal applications of the WebApp and NativeApp types <b>do not need to and cannot be uninstalled</b>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeprovisionApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionApplicationResponse
        /// </returns>
        public async Task<DeprovisionApplicationResponse> DeprovisionApplicationWithOptionsAsync(DeprovisionApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeprovisionApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeprovisionApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an external application or an internal application of the ServerApp type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to call this operation to uninstall an internal application, the type of the internal application must be <b>ServerApp</b>. Otherwise, an error occurs when you call this operation.</para>
        /// <remarks>
        /// <para> For <b>internal applications</b>, only internal applications of the ServerApp type need to be <b>installed or provisioned</b>. Therefore, only internal applications of the ServerApp type <b>can be uninstalled</b>. Internal applications of the WebApp and NativeApp types <b>do not need to and cannot be uninstalled</b>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeprovisionApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionApplicationResponse
        /// </returns>
        public DeprovisionApplicationResponse DeprovisionApplication(DeprovisionApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeprovisionApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an external application or an internal application of the ServerApp type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to call this operation to uninstall an internal application, the type of the internal application must be <b>ServerApp</b>. Otherwise, an error occurs when you call this operation.</para>
        /// <remarks>
        /// <para> For <b>internal applications</b>, only internal applications of the ServerApp type need to be <b>installed or provisioned</b>. Therefore, only internal applications of the ServerApp type <b>can be uninstalled</b>. Internal applications of the WebApp and NativeApp types <b>do not need to and cannot be uninstalled</b>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeprovisionApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionApplicationResponse
        /// </returns>
        public async Task<DeprovisionApplicationResponse> DeprovisionApplicationAsync(DeprovisionApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeprovisionApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an installed external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeprovisionExternalApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionExternalApplicationResponse
        /// </returns>
        public DeprovisionExternalApplicationResponse DeprovisionExternalApplicationWithOptions(DeprovisionExternalApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeprovisionExternalApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeprovisionExternalApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an installed external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeprovisionExternalApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionExternalApplicationResponse
        /// </returns>
        public async Task<DeprovisionExternalApplicationResponse> DeprovisionExternalApplicationWithOptionsAsync(DeprovisionExternalApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeprovisionExternalApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeprovisionExternalApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an installed external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeprovisionExternalApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionExternalApplicationResponse
        /// </returns>
        public DeprovisionExternalApplicationResponse DeprovisionExternalApplication(DeprovisionExternalApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeprovisionExternalApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an installed external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeprovisionExternalApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeprovisionExternalApplicationResponse
        /// </returns>
        public async Task<DeprovisionExternalApplicationResponse> DeprovisionExternalApplicationAsync(DeprovisionExternalApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeprovisionExternalApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds and deletes a multi-factor authentication (MFA) device from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableVirtualMFARequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableVirtualMFAResponse
        /// </returns>
        public DisableVirtualMFAResponse DisableVirtualMFAWithOptions(DisableVirtualMFARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableVirtualMFA",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableVirtualMFAResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds and deletes a multi-factor authentication (MFA) device from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableVirtualMFARequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableVirtualMFAResponse
        /// </returns>
        public async Task<DisableVirtualMFAResponse> DisableVirtualMFAWithOptionsAsync(DisableVirtualMFARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableVirtualMFA",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableVirtualMFAResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds and deletes a multi-factor authentication (MFA) device from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableVirtualMFARequest
        /// </param>
        /// 
        /// <returns>
        /// DisableVirtualMFAResponse
        /// </returns>
        public DisableVirtualMFAResponse DisableVirtualMFA(DisableVirtualMFARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableVirtualMFAWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds and deletes a multi-factor authentication (MFA) device from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableVirtualMFARequest
        /// </param>
        /// 
        /// <returns>
        /// DisableVirtualMFAResponse
        /// </returns>
        public async Task<DisableVirtualMFAResponse> DisableVirtualMFAAsync(DisableVirtualMFARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableVirtualMFAWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the user credential report of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCredentialReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCredentialReportResponse
        /// </returns>
        public GenerateCredentialReportResponse GenerateCredentialReportWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCredentialReport",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCredentialReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the user credential report of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCredentialReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCredentialReportResponse
        /// </returns>
        public async Task<GenerateCredentialReportResponse> GenerateCredentialReportWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCredentialReport",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCredentialReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the user credential report of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GenerateCredentialReportResponse
        /// </returns>
        public GenerateCredentialReportResponse GenerateCredentialReport()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateCredentialReportWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the user credential report of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GenerateCredentialReportResponse
        /// </returns>
        public async Task<GenerateCredentialReportResponse> GenerateCredentialReportAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateCredentialReportWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a check report for Cloud Governance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateGovernanceReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateGovernanceReportResponse
        /// </returns>
        public GenerateGovernanceReportResponse GenerateGovernanceReportWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateGovernanceReport",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateGovernanceReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a check report for Cloud Governance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateGovernanceReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateGovernanceReportResponse
        /// </returns>
        public async Task<GenerateGovernanceReportResponse> GenerateGovernanceReportWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateGovernanceReport",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateGovernanceReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a check report for Cloud Governance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GenerateGovernanceReportResponse
        /// </returns>
        public GenerateGovernanceReportResponse GenerateGovernanceReport()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateGovernanceReportWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a check report for Cloud Governance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GenerateGovernanceReportResponse
        /// </returns>
        public async Task<GenerateGovernanceReportResponse> GenerateGovernanceReportAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateGovernanceReportWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a specific AccessKey pair of a Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessKeyInfoInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyInfoInRecycleBinResponse
        /// </returns>
        public GetAccessKeyInfoInRecycleBinResponse GetAccessKeyInfoInRecycleBinWithOptions(GetAccessKeyInfoInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyInfoInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyInfoInRecycleBinResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a specific AccessKey pair of a Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessKeyInfoInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyInfoInRecycleBinResponse
        /// </returns>
        public async Task<GetAccessKeyInfoInRecycleBinResponse> GetAccessKeyInfoInRecycleBinWithOptionsAsync(GetAccessKeyInfoInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyInfoInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyInfoInRecycleBinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a specific AccessKey pair of a Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessKeyInfoInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyInfoInRecycleBinResponse
        /// </returns>
        public GetAccessKeyInfoInRecycleBinResponse GetAccessKeyInfoInRecycleBin(GetAccessKeyInfoInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyInfoInRecycleBinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a specific AccessKey pair of a Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessKeyInfoInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyInfoInRecycleBinResponse
        /// </returns>
        public async Task<GetAccessKeyInfoInRecycleBinResponse> GetAccessKeyInfoInRecycleBinAsync(GetAccessKeyInfoInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyInfoInRecycleBinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the time when an AccessKey pair was used for the last time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedResponse
        /// </returns>
        public GetAccessKeyLastUsedResponse GetAccessKeyLastUsedWithOptions(GetAccessKeyLastUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsed",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the time when an AccessKey pair was used for the last time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedResponse
        /// </returns>
        public async Task<GetAccessKeyLastUsedResponse> GetAccessKeyLastUsedWithOptionsAsync(GetAccessKeyLastUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsed",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the time when an AccessKey pair was used for the last time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedResponse
        /// </returns>
        public GetAccessKeyLastUsedResponse GetAccessKeyLastUsed(GetAccessKeyLastUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the time when an AccessKey pair was used for the last time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessKeyLastUsedRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessKeyLastUsedResponse
        /// </returns>
        public async Task<GetAccessKeyLastUsedResponse> GetAccessKeyLastUsedAsync(GetAccessKeyLastUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the multi-factor authentication (MFA) devices of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountMFAInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountMFAInfoResponse
        /// </returns>
        public GetAccountMFAInfoResponse GetAccountMFAInfoWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountMFAInfo",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountMFAInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the multi-factor authentication (MFA) devices of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountMFAInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountMFAInfoResponse
        /// </returns>
        public async Task<GetAccountMFAInfoResponse> GetAccountMFAInfoWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountMFAInfo",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountMFAInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the multi-factor authentication (MFA) devices of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAccountMFAInfoResponse
        /// </returns>
        public GetAccountMFAInfoResponse GetAccountMFAInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountMFAInfoWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the multi-factor authentication (MFA) devices of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAccountMFAInfoResponse
        /// </returns>
        public async Task<GetAccountMFAInfoResponse> GetAccountMFAInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountMFAInfoWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security report of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountSecurityPracticeReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountSecurityPracticeReportResponse
        /// </returns>
        public GetAccountSecurityPracticeReportResponse GetAccountSecurityPracticeReportWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountSecurityPracticeReport",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountSecurityPracticeReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security report of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountSecurityPracticeReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountSecurityPracticeReportResponse
        /// </returns>
        public async Task<GetAccountSecurityPracticeReportResponse> GetAccountSecurityPracticeReportWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountSecurityPracticeReport",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountSecurityPracticeReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security report of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAccountSecurityPracticeReportResponse
        /// </returns>
        public GetAccountSecurityPracticeReportResponse GetAccountSecurityPracticeReport()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountSecurityPracticeReportWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security report of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAccountSecurityPracticeReportResponse
        /// </returns>
        public async Task<GetAccountSecurityPracticeReportResponse> GetAccountSecurityPracticeReportAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountSecurityPracticeReportWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the overview information about an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountSummaryResponse
        /// </returns>
        public GetAccountSummaryResponse GetAccountSummaryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountSummary",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the overview information about an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountSummaryResponse
        /// </returns>
        public async Task<GetAccountSummaryResponse> GetAccountSummaryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountSummary",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the overview information about an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAccountSummaryResponse
        /// </returns>
        public GetAccountSummaryResponse GetAccountSummary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountSummaryWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the overview information about an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAccountSummaryResponse
        /// </returns>
        public async Task<GetAccountSummaryResponse> GetAccountSummaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountSummaryWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an application secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppSecretResponse
        /// </returns>
        public GetAppSecretResponse GetAppSecretWithOptions(GetAppSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecretId))
            {
                query["AppSecretId"] = request.AppSecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppSecret",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an application secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppSecretResponse
        /// </returns>
        public async Task<GetAppSecretResponse> GetAppSecretWithOptionsAsync(GetAppSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecretId))
            {
                query["AppSecretId"] = request.AppSecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppSecret",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an application secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppSecretResponse
        /// </returns>
        public GetAppSecretResponse GetAppSecret(GetAppSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppSecretWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an application secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppSecretResponse
        /// </returns>
        public async Task<GetAppSecretResponse> GetAppSecretAsync(GetAppSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppSecretWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information about an application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the configurations of an application named <c>472457090344041****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public GetApplicationResponse GetApplicationWithOptions(GetApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information about an application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the configurations of an application named <c>472457090344041****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public async Task<GetApplicationResponse> GetApplicationWithOptionsAsync(GetApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information about an application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the configurations of an application named <c>472457090344041****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information about an application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the configurations of an application named <c>472457090344041****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public async Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installation information about a specified installed application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationProvisionInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationProvisionInfoResponse
        /// </returns>
        public GetApplicationProvisionInfoResponse GetApplicationProvisionInfoWithOptions(GetApplicationProvisionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationProvisionInfo",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationProvisionInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installation information about a specified installed application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationProvisionInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationProvisionInfoResponse
        /// </returns>
        public async Task<GetApplicationProvisionInfoResponse> GetApplicationProvisionInfoWithOptionsAsync(GetApplicationProvisionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationProvisionInfo",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationProvisionInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installation information about a specified installed application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationProvisionInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationProvisionInfoResponse
        /// </returns>
        public GetApplicationProvisionInfoResponse GetApplicationProvisionInfo(GetApplicationProvisionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationProvisionInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installation information about a specified installed application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationProvisionInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationProvisionInfoResponse
        /// </returns>
        public async Task<GetApplicationProvisionInfoResponse> GetApplicationProvisionInfoAsync(GetApplicationProvisionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationProvisionInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the user credential reports of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialReportResponse
        /// </returns>
        public GetCredentialReportResponse GetCredentialReportWithOptions(GetCredentialReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
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
                Action = "GetCredentialReport",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the user credential reports of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialReportResponse
        /// </returns>
        public async Task<GetCredentialReportResponse> GetCredentialReportWithOptionsAsync(GetCredentialReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
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
                Action = "GetCredentialReport",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the user credential reports of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialReportResponse
        /// </returns>
        public GetCredentialReportResponse GetCredentialReport(GetCredentialReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCredentialReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the user credential reports of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialReportResponse
        /// </returns>
        public async Task<GetCredentialReportResponse> GetCredentialReportAsync(GetCredentialReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCredentialReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the default domain name of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefaultDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDefaultDomainResponse
        /// </returns>
        public GetDefaultDomainResponse GetDefaultDomainWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultDomain",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the default domain name of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefaultDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDefaultDomainResponse
        /// </returns>
        public async Task<GetDefaultDomainResponse> GetDefaultDomainWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultDomain",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the default domain name of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDefaultDomainResponse
        /// </returns>
        public GetDefaultDomainResponse GetDefaultDomain()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDefaultDomainWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the default domain name of an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDefaultDomainResponse
        /// </returns>
        public async Task<GetDefaultDomainResponse> GetDefaultDomainAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDefaultDomainWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an installed external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExternalApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExternalApplicationResponse
        /// </returns>
        public GetExternalApplicationResponse GetExternalApplicationWithOptions(GetExternalApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExternalApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExternalApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an installed external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExternalApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExternalApplicationResponse
        /// </returns>
        public async Task<GetExternalApplicationResponse> GetExternalApplicationWithOptionsAsync(GetExternalApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExternalApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExternalApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an installed external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExternalApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExternalApplicationResponse
        /// </returns>
        public GetExternalApplicationResponse GetExternalApplication(GetExternalApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExternalApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an installed external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExternalApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExternalApplicationResponse
        /// </returns>
        public async Task<GetExternalApplicationResponse> GetExternalApplicationAsync(GetExternalApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExternalApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的单项ram治理报告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGovernanceItemReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGovernanceItemReportResponse
        /// </returns>
        public GetGovernanceItemReportResponse GetGovernanceItemReportWithOptions(GetGovernanceItemReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GovernanceItemType))
            {
                query["GovernanceItemType"] = request.GovernanceItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGovernanceItemReport",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGovernanceItemReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的单项ram治理报告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGovernanceItemReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGovernanceItemReportResponse
        /// </returns>
        public async Task<GetGovernanceItemReportResponse> GetGovernanceItemReportWithOptionsAsync(GetGovernanceItemReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GovernanceItemType))
            {
                query["GovernanceItemType"] = request.GovernanceItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGovernanceItemReport",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGovernanceItemReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的单项ram治理报告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGovernanceItemReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGovernanceItemReportResponse
        /// </returns>
        public GetGovernanceItemReportResponse GetGovernanceItemReport(GetGovernanceItemReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGovernanceItemReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户的单项ram治理报告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGovernanceItemReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGovernanceItemReportResponse
        /// </returns>
        public async Task<GetGovernanceItemReportResponse> GetGovernanceItemReportAsync(GetGovernanceItemReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGovernanceItemReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成熟度报告状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGovernanceReportStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGovernanceReportStatusResponse
        /// </returns>
        public GetGovernanceReportStatusResponse GetGovernanceReportStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGovernanceReportStatus",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGovernanceReportStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成熟度报告状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGovernanceReportStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGovernanceReportStatusResponse
        /// </returns>
        public async Task<GetGovernanceReportStatusResponse> GetGovernanceReportStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGovernanceReportStatus",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGovernanceReportStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成熟度报告状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGovernanceReportStatusResponse
        /// </returns>
        public GetGovernanceReportStatusResponse GetGovernanceReportStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGovernanceReportStatusWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成熟度报告状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGovernanceReportStatusResponse
        /// </returns>
        public async Task<GetGovernanceReportStatusResponse> GetGovernanceReportStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGovernanceReportStatusWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
                Action = "GetGroup",
                Version = "2019-08-15",
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
        /// <para>Queries the information about a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
                Action = "GetGroup",
                Version = "2019-08-15",
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
        /// <para>Queries the information about a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
        /// <para>Queries the information about a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
        /// <para>Queries the logon configurations of a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoginProfileResponse
        /// </returns>
        public GetLoginProfileResponse GetLoginProfileWithOptions(GetLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginProfile",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logon configurations of a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoginProfileResponse
        /// </returns>
        public async Task<GetLoginProfileResponse> GetLoginProfileWithOptionsAsync(GetLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginProfile",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logon configurations of a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoginProfileResponse
        /// </returns>
        public GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoginProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logon configurations of a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoginProfileResponse
        /// </returns>
        public async Task<GetLoginProfileResponse> GetLoginProfileAsync(GetLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoginProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an OIDC IdP.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to query the information about an OpenID Connect (OIDC) identity provider (IdP) named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOIDCProviderResponse
        /// </returns>
        public GetOIDCProviderResponse GetOIDCProviderWithOptions(GetOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOIDCProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an OIDC IdP.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to query the information about an OpenID Connect (OIDC) identity provider (IdP) named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOIDCProviderResponse
        /// </returns>
        public async Task<GetOIDCProviderResponse> GetOIDCProviderWithOptionsAsync(GetOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOIDCProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an OIDC IdP.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to query the information about an OpenID Connect (OIDC) identity provider (IdP) named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOIDCProviderResponse
        /// </returns>
        public GetOIDCProviderResponse GetOIDCProvider(GetOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOIDCProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an OIDC IdP.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to query the information about an OpenID Connect (OIDC) identity provider (IdP) named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOIDCProviderResponse
        /// </returns>
        public async Task<GetOIDCProviderResponse> GetOIDCProviderAsync(GetOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOIDCProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the password policy for RAM users.</para>
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
        public GetPasswordPolicyResponse GetPasswordPolicyWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordPolicy",
                Version = "2019-08-15",
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
        /// <para>Queries the details of the password policy for RAM users.</para>
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
        public async Task<GetPasswordPolicyResponse> GetPasswordPolicyWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordPolicy",
                Version = "2019-08-15",
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
        /// <para>Queries the details of the password policy for RAM users.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPasswordPolicyResponse
        /// </returns>
        public GetPasswordPolicyResponse GetPasswordPolicy()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPasswordPolicyWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the password policy for RAM users.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPasswordPolicyResponse
        /// </returns>
        public async Task<GetPasswordPolicyResponse> GetPasswordPolicyAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPasswordPolicyWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLProviderResponse
        /// </returns>
        public GetSAMLProviderResponse GetSAMLProviderWithOptions(GetSAMLProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderName))
            {
                query["SAMLProviderName"] = request.SAMLProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSAMLProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSAMLProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLProviderResponse
        /// </returns>
        public async Task<GetSAMLProviderResponse> GetSAMLProviderWithOptionsAsync(GetSAMLProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderName))
            {
                query["SAMLProviderName"] = request.SAMLProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSAMLProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSAMLProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLProviderResponse
        /// </returns>
        public GetSAMLProviderResponse GetSAMLProvider(GetSAMLProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSAMLProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSAMLProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSAMLProviderResponse
        /// </returns>
        public async Task<GetSAMLProviderResponse> GetSAMLProviderAsync(GetSAMLProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSAMLProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security preferences for RAM users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityPreferenceResponse
        /// </returns>
        public GetSecurityPreferenceResponse GetSecurityPreferenceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecurityPreference",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityPreferenceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security preferences for RAM users.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityPreferenceResponse
        /// </returns>
        public async Task<GetSecurityPreferenceResponse> GetSecurityPreferenceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecurityPreference",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityPreferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security preferences for RAM users.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSecurityPreferenceResponse
        /// </returns>
        public GetSecurityPreferenceResponse GetSecurityPreference()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecurityPreferenceWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the security preferences for RAM users.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSecurityPreferenceResponse
        /// </returns>
        public async Task<GetSecurityPreferenceResponse> GetSecurityPreferenceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecurityPreferenceWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a RAM user.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2019-08-15",
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
        /// <para>Queries the information about a RAM user.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2019-08-15",
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
        /// <para>Queries the information about a RAM user.</para>
        /// </summary>
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
        /// <para>Queries the information about a RAM user.</para>
        /// </summary>
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
        /// <para>Queries information about a specific Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInRecycleBinResponse
        /// </returns>
        public GetUserInRecycleBinResponse GetUserInRecycleBinWithOptions(GetUserInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
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
                Action = "GetUserInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInRecycleBinResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a specific Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInRecycleBinResponse
        /// </returns>
        public async Task<GetUserInRecycleBinResponse> GetUserInRecycleBinWithOptionsAsync(GetUserInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
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
                Action = "GetUserInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInRecycleBinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a specific Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserInRecycleBinResponse
        /// </returns>
        public GetUserInRecycleBinResponse GetUserInRecycleBin(GetUserInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserInRecycleBinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about a specific Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserInRecycleBinResponse
        /// </returns>
        public async Task<GetUserInRecycleBinResponse> GetUserInRecycleBinAsync(GetUserInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserInRecycleBinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the multi-factor authentication (MFA) device that is bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserMFAInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserMFAInfoResponse
        /// </returns>
        public GetUserMFAInfoResponse GetUserMFAInfoWithOptions(GetUserMFAInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserMFAInfo",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserMFAInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the multi-factor authentication (MFA) device that is bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserMFAInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserMFAInfoResponse
        /// </returns>
        public async Task<GetUserMFAInfoResponse> GetUserMFAInfoWithOptionsAsync(GetUserMFAInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserMFAInfo",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserMFAInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the multi-factor authentication (MFA) device that is bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserMFAInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserMFAInfoResponse
        /// </returns>
        public GetUserMFAInfoResponse GetUserMFAInfo(GetUserMFAInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserMFAInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the multi-factor authentication (MFA) device that is bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserMFAInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserMFAInfoResponse
        /// </returns>
        public async Task<GetUserMFAInfoResponse> GetUserMFAInfoAsync(GetUserMFAInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserMFAInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of user-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserSsoSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserSsoSettingsResponse
        /// </returns>
        public GetUserSsoSettingsResponse GetUserSsoSettingsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserSsoSettings",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserSsoSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of user-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserSsoSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserSsoSettingsResponse
        /// </returns>
        public async Task<GetUserSsoSettingsResponse> GetUserSsoSettingsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserSsoSettings",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserSsoSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of user-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserSsoSettingsResponse
        /// </returns>
        public GetUserSsoSettingsResponse GetUserSsoSettings()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserSsoSettingsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of user-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserSsoSettingsResponse
        /// </returns>
        public async Task<GetUserSsoSettingsResponse> GetUserSsoSettingsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserSsoSettingsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the mobile phone or email that is bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVerificationInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVerificationInfoResponse
        /// </returns>
        public GetVerificationInfoResponse GetVerificationInfoWithOptions(GetVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVerificationInfo",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVerificationInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the mobile phone or email that is bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVerificationInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVerificationInfoResponse
        /// </returns>
        public async Task<GetVerificationInfoResponse> GetVerificationInfoWithOptionsAsync(GetVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVerificationInfo",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVerificationInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the mobile phone or email that is bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVerificationInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVerificationInfoResponse
        /// </returns>
        public GetVerificationInfoResponse GetVerificationInfo(GetVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVerificationInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the mobile phone or email that is bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVerificationInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVerificationInfoResponse
        /// </returns>
        public async Task<GetVerificationInfoResponse> GetVerificationInfoAsync(GetVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVerificationInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs of an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessKeysResponse
        /// </returns>
        public ListAccessKeysResponse ListAccessKeysWithOptions(ListAccessKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessKeys",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs of an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessKeysResponse
        /// </returns>
        public async Task<ListAccessKeysResponse> ListAccessKeysWithOptionsAsync(ListAccessKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessKeys",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs of an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessKeysResponse
        /// </returns>
        public ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs of an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessKeysResponse
        /// </returns>
        public async Task<ListAccessKeysResponse> ListAccessKeysAsync(ListAccessKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs of a specific Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessKeysInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessKeysInRecycleBinResponse
        /// </returns>
        public ListAccessKeysInRecycleBinResponse ListAccessKeysInRecycleBinWithOptions(ListAccessKeysInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListAccessKeysInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessKeysInRecycleBinResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs of a specific Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessKeysInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessKeysInRecycleBinResponse
        /// </returns>
        public async Task<ListAccessKeysInRecycleBinResponse> ListAccessKeysInRecycleBinWithOptionsAsync(ListAccessKeysInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListAccessKeysInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessKeysInRecycleBinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs of a specific Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessKeysInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessKeysInRecycleBinResponse
        /// </returns>
        public ListAccessKeysInRecycleBinResponse ListAccessKeysInRecycleBin(ListAccessKeysInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessKeysInRecycleBinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs of a specific Resource Access Management (RAM) user in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessKeysInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessKeysInRecycleBinResponse
        /// </returns>
        public async Task<ListAccessKeysInRecycleBinResponse> ListAccessKeysInRecycleBinAsync(ListAccessKeysInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessKeysInRecycleBinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the secret IDs of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppSecretIdsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppSecretIdsResponse
        /// </returns>
        public ListAppSecretIdsResponse ListAppSecretIdsWithOptions(ListAppSecretIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppSecretIds",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppSecretIdsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the secret IDs of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppSecretIdsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppSecretIdsResponse
        /// </returns>
        public async Task<ListAppSecretIdsResponse> ListAppSecretIdsWithOptionsAsync(ListAppSecretIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppSecretIds",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppSecretIdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the secret IDs of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppSecretIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppSecretIdsResponse
        /// </returns>
        public ListAppSecretIdsResponse ListAppSecretIds(ListAppSecretIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppSecretIdsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the secret IDs of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppSecretIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppSecretIdsResponse
        /// </returns>
        public async Task<ListAppSecretIdsResponse> ListAppSecretIdsAsync(ListAppSecretIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppSecretIdsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installation information about all installed applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationProvisionInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationProvisionInfosResponse
        /// </returns>
        public ListApplicationProvisionInfosResponse ListApplicationProvisionInfosWithOptions(ListApplicationProvisionInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationProvisionInfos",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationProvisionInfosResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installation information about all installed applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationProvisionInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationProvisionInfosResponse
        /// </returns>
        public async Task<ListApplicationProvisionInfosResponse> ListApplicationProvisionInfosWithOptionsAsync(ListApplicationProvisionInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationProvisionInfos",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationProvisionInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installation information about all installed applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationProvisionInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationProvisionInfosResponse
        /// </returns>
        public ListApplicationProvisionInfosResponse ListApplicationProvisionInfos(ListApplicationProvisionInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationProvisionInfosWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installation information about all installed applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationProvisionInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationProvisionInfosResponse
        /// </returns>
        public async Task<ListApplicationProvisionInfosResponse> ListApplicationProvisionInfosAsync(ListApplicationProvisionInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationProvisionInfosWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the created applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the applications within the current account. The returned result shows that only one application named <c>myapp</c> belongs to the current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public ListApplicationsResponse ListApplicationsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplications",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the created applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the applications within the current account. The returned result shows that only one application named <c>myapp</c> belongs to the current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public async Task<ListApplicationsResponse> ListApplicationsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplications",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the created applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the applications within the current account. The returned result shows that only one application named <c>myapp</c> belongs to the current account.</para>
        /// </description>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public ListApplicationsResponse ListApplications()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the created applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the applications within the current account. The returned result shows that only one application named <c>myapp</c> belongs to the current account.</para>
        /// </description>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public async Task<ListApplicationsResponse> ListApplicationsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all installed external applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExternalApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExternalApplicationsResponse
        /// </returns>
        public ListExternalApplicationsResponse ListExternalApplicationsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExternalApplications",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExternalApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all installed external applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExternalApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExternalApplicationsResponse
        /// </returns>
        public async Task<ListExternalApplicationsResponse> ListExternalApplicationsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExternalApplications",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExternalApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all installed external applications.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListExternalApplicationsResponse
        /// </returns>
        public ListExternalApplicationsResponse ListExternalApplications()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExternalApplicationsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all installed external applications.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListExternalApplicationsResponse
        /// </returns>
        public async Task<ListExternalApplicationsResponse> ListExternalApplicationsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExternalApplicationsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) user groups.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2019-08-15",
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
        /// <para>Queries Resource Access Management (RAM) user groups.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2019-08-15",
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
        /// <para>Queries Resource Access Management (RAM) user groups.</para>
        /// </summary>
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
        /// <para>Queries Resource Access Management (RAM) user groups.</para>
        /// </summary>
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
        /// <para>Queries the Resource Access Management (RAM) user groups to which a RAM user belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsForUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsForUserResponse
        /// </returns>
        public ListGroupsForUserResponse ListGroupsForUserWithOptions(ListGroupsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupsForUser",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsForUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Resource Access Management (RAM) user groups to which a RAM user belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsForUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsForUserResponse
        /// </returns>
        public async Task<ListGroupsForUserResponse> ListGroupsForUserWithOptionsAsync(ListGroupsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupsForUser",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsForUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Resource Access Management (RAM) user groups to which a RAM user belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsForUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsForUserResponse
        /// </returns>
        public ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupsForUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Resource Access Management (RAM) user groups to which a RAM user belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsForUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsForUserResponse
        /// </returns>
        public async Task<ListGroupsForUserResponse> ListGroupsForUserAsync(ListGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupsForUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries OIDC IdPs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to query all OpenID Connect (OIDC) identity providers (IdPs) within your Alibaba Cloud account. The response shows that your Alibaba Cloud account has only one OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOIDCProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOIDCProvidersResponse
        /// </returns>
        public ListOIDCProvidersResponse ListOIDCProvidersWithOptions(ListOIDCProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOIDCProviders",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOIDCProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries OIDC IdPs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to query all OpenID Connect (OIDC) identity providers (IdPs) within your Alibaba Cloud account. The response shows that your Alibaba Cloud account has only one OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOIDCProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOIDCProvidersResponse
        /// </returns>
        public async Task<ListOIDCProvidersResponse> ListOIDCProvidersWithOptionsAsync(ListOIDCProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOIDCProviders",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOIDCProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries OIDC IdPs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to query all OpenID Connect (OIDC) identity providers (IdPs) within your Alibaba Cloud account. The response shows that your Alibaba Cloud account has only one OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOIDCProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOIDCProvidersResponse
        /// </returns>
        public ListOIDCProvidersResponse ListOIDCProviders(ListOIDCProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOIDCProvidersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries OIDC IdPs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to query all OpenID Connect (OIDC) identity providers (IdPs) within your Alibaba Cloud account. The response shows that your Alibaba Cloud account has only one OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOIDCProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOIDCProvidersResponse
        /// </returns>
        public async Task<ListOIDCProvidersResponse> ListOIDCProvidersAsync(ListOIDCProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOIDCProvidersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the passkeys that are bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPasskeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPasskeysResponse
        /// </returns>
        public ListPasskeysResponse ListPasskeysWithOptions(ListPasskeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPasskeys",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPasskeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the passkeys that are bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPasskeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPasskeysResponse
        /// </returns>
        public async Task<ListPasskeysResponse> ListPasskeysWithOptionsAsync(ListPasskeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPasskeys",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPasskeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the passkeys that are bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPasskeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPasskeysResponse
        /// </returns>
        public ListPasskeysResponse ListPasskeys(ListPasskeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPasskeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the passkeys that are bound to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPasskeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPasskeysResponse
        /// </returns>
        public async Task<ListPasskeysResponse> ListPasskeysAsync(ListPasskeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPasskeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries predefined application permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedScopesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedScopesResponse
        /// </returns>
        public ListPredefinedScopesResponse ListPredefinedScopesWithOptions(ListPredefinedScopesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPredefinedScopes",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPredefinedScopesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries predefined application permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedScopesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedScopesResponse
        /// </returns>
        public async Task<ListPredefinedScopesResponse> ListPredefinedScopesWithOptionsAsync(ListPredefinedScopesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPredefinedScopes",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPredefinedScopesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries predefined application permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedScopesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedScopesResponse
        /// </returns>
        public ListPredefinedScopesResponse ListPredefinedScopes(ListPredefinedScopesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPredefinedScopesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries predefined application permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedScopesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedScopesResponse
        /// </returns>
        public async Task<ListPredefinedScopesResponse> ListPredefinedScopesAsync(ListPredefinedScopesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPredefinedScopesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all metric values in the most recent governance check.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecentGovernanceMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecentGovernanceMetricsResponse
        /// </returns>
        public ListRecentGovernanceMetricsResponse ListRecentGovernanceMetricsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecentGovernanceMetrics",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentGovernanceMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all metric values in the most recent governance check.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecentGovernanceMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecentGovernanceMetricsResponse
        /// </returns>
        public async Task<ListRecentGovernanceMetricsResponse> ListRecentGovernanceMetricsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecentGovernanceMetrics",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentGovernanceMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all metric values in the most recent governance check.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRecentGovernanceMetricsResponse
        /// </returns>
        public ListRecentGovernanceMetricsResponse ListRecentGovernanceMetrics()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRecentGovernanceMetricsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all metric values in the most recent governance check.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRecentGovernanceMetricsResponse
        /// </returns>
        public async Task<ListRecentGovernanceMetricsResponse> ListRecentGovernanceMetricsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRecentGovernanceMetricsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about identity providers (IdPs) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSAMLProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSAMLProvidersResponse
        /// </returns>
        public ListSAMLProvidersResponse ListSAMLProvidersWithOptions(ListSAMLProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSAMLProviders",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSAMLProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about identity providers (IdPs) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSAMLProvidersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSAMLProvidersResponse
        /// </returns>
        public async Task<ListSAMLProvidersResponse> ListSAMLProvidersWithOptionsAsync(ListSAMLProvidersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSAMLProviders",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSAMLProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about identity providers (IdPs) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSAMLProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSAMLProvidersResponse
        /// </returns>
        public ListSAMLProvidersResponse ListSAMLProviders(ListSAMLProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSAMLProvidersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about identity providers (IdPs) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSAMLProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSAMLProvidersResponse
        /// </returns>
        public async Task<ListSAMLProvidersResponse> ListSAMLProvidersAsync(ListSAMLProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSAMLProvidersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>You must specify at least one of the following parameters or parameter pairs in a request to determine a query object:</para>
        /// <list type="bullet">
        /// <item><description><c>ResourceId.N</c></description></item>
        /// <item><description><c>Tag.N.Key</c></description></item>
        /// <item><description><c>Tag.N.Key</c> and <c>Tag.N.Value</c></description></item>
        /// </list>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePrincipalName))
            {
                query["ResourcePrincipalName"] = request.ResourcePrincipalName;
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
                Version = "2019-08-15",
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
        /// <para>Queries the tags that are added resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>You must specify at least one of the following parameters or parameter pairs in a request to determine a query object:</para>
        /// <list type="bullet">
        /// <item><description><c>ResourceId.N</c></description></item>
        /// <item><description><c>Tag.N.Key</c></description></item>
        /// <item><description><c>Tag.N.Key</c> and <c>Tag.N.Value</c></description></item>
        /// </list>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePrincipalName))
            {
                query["ResourcePrincipalName"] = request.ResourcePrincipalName;
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
                Version = "2019-08-15",
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
        /// <para>Queries the tags that are added resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>You must specify at least one of the following parameters or parameter pairs in a request to determine a query object:</para>
        /// <list type="bullet">
        /// <item><description><c>ResourceId.N</c></description></item>
        /// <item><description><c>Tag.N.Key</c></description></item>
        /// <item><description><c>Tag.N.Key</c> and <c>Tag.N.Value</c></description></item>
        /// </list>
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
        /// <para>Queries the tags that are added resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>You must specify at least one of the following parameters or parameter pairs in a request to determine a query object:</para>
        /// <list type="bullet">
        /// <item><description><c>ResourceId.N</c></description></item>
        /// <item><description><c>Tag.N.Key</c></description></item>
        /// <item><description><c>Tag.N.Key</c> and <c>Tag.N.Value</c></description></item>
        /// </list>
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
        /// <para>Queries the basic information about all Resource Access Management (RAM) users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the following API operations to query information about all RAM users:</para>
        /// <list type="bullet">
        /// <item><description>ListUsers: queries the details of all RAM users.</description></item>
        /// <item><description>ListUserBasicInfos: queries the basic information about all RAM users. The basic information includes only the logon names (<c>UserPrincipalName</c>), display names (<c>DisplayName</c>), and user IDs (<c>UserId</c>).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserBasicInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserBasicInfosResponse
        /// </returns>
        public ListUserBasicInfosResponse ListUserBasicInfosWithOptions(ListUserBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListUserBasicInfos",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserBasicInfosResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about all Resource Access Management (RAM) users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the following API operations to query information about all RAM users:</para>
        /// <list type="bullet">
        /// <item><description>ListUsers: queries the details of all RAM users.</description></item>
        /// <item><description>ListUserBasicInfos: queries the basic information about all RAM users. The basic information includes only the logon names (<c>UserPrincipalName</c>), display names (<c>DisplayName</c>), and user IDs (<c>UserId</c>).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserBasicInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserBasicInfosResponse
        /// </returns>
        public async Task<ListUserBasicInfosResponse> ListUserBasicInfosWithOptionsAsync(ListUserBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListUserBasicInfos",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserBasicInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about all Resource Access Management (RAM) users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the following API operations to query information about all RAM users:</para>
        /// <list type="bullet">
        /// <item><description>ListUsers: queries the details of all RAM users.</description></item>
        /// <item><description>ListUserBasicInfos: queries the basic information about all RAM users. The basic information includes only the logon names (<c>UserPrincipalName</c>), display names (<c>DisplayName</c>), and user IDs (<c>UserId</c>).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserBasicInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserBasicInfosResponse
        /// </returns>
        public ListUserBasicInfosResponse ListUserBasicInfos(ListUserBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserBasicInfosWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about all Resource Access Management (RAM) users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the following API operations to query information about all RAM users:</para>
        /// <list type="bullet">
        /// <item><description>ListUsers: queries the details of all RAM users.</description></item>
        /// <item><description>ListUserBasicInfos: queries the basic information about all RAM users. The basic information includes only the logon names (<c>UserPrincipalName</c>), display names (<c>DisplayName</c>), and user IDs (<c>UserId</c>).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserBasicInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserBasicInfosResponse
        /// </returns>
        public async Task<ListUserBasicInfosResponse> ListUserBasicInfosAsync(ListUserBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserBasicInfosWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all Resource Access Management (RAM) users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>You can call the following API operations to query the details of all RAM users:</para>
        /// <list type="bullet">
        /// <item><description>ListUsers: queries the details of all RAM users.</description></item>
        /// <item><description>ListUserBasicInfos: queries the basic information about all RAM users. The basic information includes only the logon names (<c>UserPrincipalName</c>), display names (<c>DisplayName</c>), and user IDs (<c>UserId</c>).</description></item>
        /// </list>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListUsers",
                Version = "2019-08-15",
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
        /// <para>Queries information about all Resource Access Management (RAM) users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>You can call the following API operations to query the details of all RAM users:</para>
        /// <list type="bullet">
        /// <item><description>ListUsers: queries the details of all RAM users.</description></item>
        /// <item><description>ListUserBasicInfos: queries the basic information about all RAM users. The basic information includes only the logon names (<c>UserPrincipalName</c>), display names (<c>DisplayName</c>), and user IDs (<c>UserId</c>).</description></item>
        /// </list>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListUsers",
                Version = "2019-08-15",
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
        /// <para>Queries information about all Resource Access Management (RAM) users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>You can call the following API operations to query the details of all RAM users:</para>
        /// <list type="bullet">
        /// <item><description>ListUsers: queries the details of all RAM users.</description></item>
        /// <item><description>ListUserBasicInfos: queries the basic information about all RAM users. The basic information includes only the logon names (<c>UserPrincipalName</c>), display names (<c>DisplayName</c>), and user IDs (<c>UserId</c>).</description></item>
        /// </list>
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
        /// <para>Queries information about all Resource Access Management (RAM) users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>You can call the following API operations to query the details of all RAM users:</para>
        /// <list type="bullet">
        /// <item><description>ListUsers: queries the details of all RAM users.</description></item>
        /// <item><description>ListUserBasicInfos: queries the basic information about all RAM users. The basic information includes only the logon names (<c>UserPrincipalName</c>), display names (<c>DisplayName</c>), and user IDs (<c>UserId</c>).</description></item>
        /// </list>
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
        /// <para>Queries Resource Access Management (RAM) users in a RAM user group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersForGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersForGroupResponse
        /// </returns>
        public ListUsersForGroupResponse ListUsersForGroupWithOptions(ListUsersForGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersForGroup",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersForGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) users in a RAM user group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersForGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersForGroupResponse
        /// </returns>
        public async Task<ListUsersForGroupResponse> ListUsersForGroupWithOptionsAsync(ListUsersForGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersForGroup",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersForGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) users in a RAM user group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersForGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersForGroupResponse
        /// </returns>
        public ListUsersForGroupResponse ListUsersForGroup(ListUsersForGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersForGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Resource Access Management (RAM) users in a RAM user group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersForGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersForGroupResponse
        /// </returns>
        public async Task<ListUsersForGroupResponse> ListUsersForGroupAsync(ListUsersForGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersForGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about all Resource Access Management (RAM) users in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersInRecycleBinResponse
        /// </returns>
        public ListUsersInRecycleBinResponse ListUsersInRecycleBinWithOptions(ListUsersInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersInRecycleBinResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about all Resource Access Management (RAM) users in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersInRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersInRecycleBinResponse
        /// </returns>
        public async Task<ListUsersInRecycleBinResponse> ListUsersInRecycleBinWithOptionsAsync(ListUsersInRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersInRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersInRecycleBinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about all Resource Access Management (RAM) users in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersInRecycleBinResponse
        /// </returns>
        public ListUsersInRecycleBinResponse ListUsersInRecycleBin(ListUsersInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersInRecycleBinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about all Resource Access Management (RAM) users in the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersInRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersInRecycleBinResponse
        /// </returns>
        public async Task<ListUsersInRecycleBinResponse> ListUsersInRecycleBinAsync(ListUsersInRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersInRecycleBinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries multi-factor authentication (MFA) devices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualMFADevicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualMFADevicesResponse
        /// </returns>
        public ListVirtualMFADevicesResponse ListVirtualMFADevicesWithOptions(ListVirtualMFADevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualMFADevices",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualMFADevicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries multi-factor authentication (MFA) devices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualMFADevicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualMFADevicesResponse
        /// </returns>
        public async Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesWithOptionsAsync(ListVirtualMFADevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualMFADevices",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualMFADevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries multi-factor authentication (MFA) devices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualMFADevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualMFADevicesResponse
        /// </returns>
        public ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVirtualMFADevicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries multi-factor authentication (MFA) devices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualMFADevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualMFADevicesResponse
        /// </returns>
        public async Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(ListVirtualMFADevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVirtualMFADevicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProvisionApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProvisionApplicationResponse
        /// </returns>
        public ProvisionApplicationResponse ProvisionApplicationWithOptions(ProvisionApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scopes))
            {
                query["Scopes"] = request.Scopes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProvisionApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProvisionApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProvisionApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProvisionApplicationResponse
        /// </returns>
        public async Task<ProvisionApplicationResponse> ProvisionApplicationWithOptionsAsync(ProvisionApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scopes))
            {
                query["Scopes"] = request.Scopes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProvisionApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProvisionApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProvisionApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// ProvisionApplicationResponse
        /// </returns>
        public ProvisionApplicationResponse ProvisionApplication(ProvisionApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProvisionApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProvisionApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// ProvisionApplicationResponse
        /// </returns>
        public async Task<ProvisionApplicationResponse> ProvisionApplicationAsync(ProvisionApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProvisionApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProvisionExternalApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProvisionExternalApplicationResponse
        /// </returns>
        public ProvisionExternalApplicationResponse ProvisionExternalApplicationWithOptions(ProvisionExternalApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scopes))
            {
                query["Scopes"] = request.Scopes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProvisionExternalApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProvisionExternalApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProvisionExternalApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProvisionExternalApplicationResponse
        /// </returns>
        public async Task<ProvisionExternalApplicationResponse> ProvisionExternalApplicationWithOptionsAsync(ProvisionExternalApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scopes))
            {
                query["Scopes"] = request.Scopes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProvisionExternalApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProvisionExternalApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProvisionExternalApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// ProvisionExternalApplicationResponse
        /// </returns>
        public ProvisionExternalApplicationResponse ProvisionExternalApplication(ProvisionExternalApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProvisionExternalApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an external application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProvisionExternalApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// ProvisionExternalApplicationResponse
        /// </returns>
        public async Task<ProvisionExternalApplicationResponse> ProvisionExternalApplicationAsync(ProvisionExternalApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProvisionExternalApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a client ID from an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the client ID <c>498469743454717****</c> from the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveClientIdFromOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveClientIdFromOIDCProviderResponse
        /// </returns>
        public RemoveClientIdFromOIDCProviderResponse RemoveClientIdFromOIDCProviderWithOptions(RemoveClientIdFromOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveClientIdFromOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveClientIdFromOIDCProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a client ID from an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the client ID <c>498469743454717****</c> from the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveClientIdFromOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveClientIdFromOIDCProviderResponse
        /// </returns>
        public async Task<RemoveClientIdFromOIDCProviderResponse> RemoveClientIdFromOIDCProviderWithOptionsAsync(RemoveClientIdFromOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveClientIdFromOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveClientIdFromOIDCProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a client ID from an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the client ID <c>498469743454717****</c> from the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveClientIdFromOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveClientIdFromOIDCProviderResponse
        /// </returns>
        public RemoveClientIdFromOIDCProviderResponse RemoveClientIdFromOIDCProvider(RemoveClientIdFromOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveClientIdFromOIDCProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a client ID from an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the client ID <c>498469743454717****</c> from the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveClientIdFromOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveClientIdFromOIDCProviderResponse
        /// </returns>
        public async Task<RemoveClientIdFromOIDCProviderResponse> RemoveClientIdFromOIDCProviderAsync(RemoveClientIdFromOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveClientIdFromOIDCProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a fingerprint from an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the fingerprint <c>6938fd4d98bab03faadb97b34396831e3780****</c> from the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveFingerprintFromOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveFingerprintFromOIDCProviderResponse
        /// </returns>
        public RemoveFingerprintFromOIDCProviderResponse RemoveFingerprintFromOIDCProviderWithOptions(RemoveFingerprintFromOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fingerprint))
            {
                query["Fingerprint"] = request.Fingerprint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveFingerprintFromOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveFingerprintFromOIDCProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a fingerprint from an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the fingerprint <c>6938fd4d98bab03faadb97b34396831e3780****</c> from the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveFingerprintFromOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveFingerprintFromOIDCProviderResponse
        /// </returns>
        public async Task<RemoveFingerprintFromOIDCProviderResponse> RemoveFingerprintFromOIDCProviderWithOptionsAsync(RemoveFingerprintFromOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fingerprint))
            {
                query["Fingerprint"] = request.Fingerprint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveFingerprintFromOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveFingerprintFromOIDCProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a fingerprint from an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the fingerprint <c>6938fd4d98bab03faadb97b34396831e3780****</c> from the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveFingerprintFromOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveFingerprintFromOIDCProviderResponse
        /// </returns>
        public RemoveFingerprintFromOIDCProviderResponse RemoveFingerprintFromOIDCProvider(RemoveFingerprintFromOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveFingerprintFromOIDCProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a fingerprint from an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to remove the fingerprint <c>6938fd4d98bab03faadb97b34396831e3780****</c> from the OIDC IdP named <c>TestOIDCProvider</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveFingerprintFromOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveFingerprintFromOIDCProviderResponse
        /// </returns>
        public async Task<RemoveFingerprintFromOIDCProviderResponse> RemoveFingerprintFromOIDCProviderAsync(RemoveFingerprintFromOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveFingerprintFromOIDCProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a Resource Access Management (RAM) user from a RAM user group.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUserFromGroup",
                Version = "2019-08-15",
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
        /// <para>Removes a Resource Access Management (RAM) user from a RAM user group.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUserFromGroup",
                Version = "2019-08-15",
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
        /// <para>Removes a Resource Access Management (RAM) user from a RAM user group.</para>
        /// </summary>
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
        /// <para>Removes a Resource Access Management (RAM) user from a RAM user group.</para>
        /// </summary>
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
        /// <para>Restores a specific AccessKey pair that belongs to a Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreAccessKeyFromRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreAccessKeyFromRecycleBinResponse
        /// </returns>
        public RestoreAccessKeyFromRecycleBinResponse RestoreAccessKeyFromRecycleBinWithOptions(RestoreAccessKeyFromRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
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
                Action = "RestoreAccessKeyFromRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreAccessKeyFromRecycleBinResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a specific AccessKey pair that belongs to a Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreAccessKeyFromRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreAccessKeyFromRecycleBinResponse
        /// </returns>
        public async Task<RestoreAccessKeyFromRecycleBinResponse> RestoreAccessKeyFromRecycleBinWithOptionsAsync(RestoreAccessKeyFromRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
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
                Action = "RestoreAccessKeyFromRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreAccessKeyFromRecycleBinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a specific AccessKey pair that belongs to a Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreAccessKeyFromRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreAccessKeyFromRecycleBinResponse
        /// </returns>
        public RestoreAccessKeyFromRecycleBinResponse RestoreAccessKeyFromRecycleBin(RestoreAccessKeyFromRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreAccessKeyFromRecycleBinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a specific AccessKey pair that belongs to a Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreAccessKeyFromRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreAccessKeyFromRecycleBinResponse
        /// </returns>
        public async Task<RestoreAccessKeyFromRecycleBinResponse> RestoreAccessKeyFromRecycleBinAsync(RestoreAccessKeyFromRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreAccessKeyFromRecycleBinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a specific Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreUserFromRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreUserFromRecycleBinResponse
        /// </returns>
        public RestoreUserFromRecycleBinResponse RestoreUserFromRecycleBinWithOptions(RestoreUserFromRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "RestoreUserFromRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreUserFromRecycleBinResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a specific Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreUserFromRecycleBinRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreUserFromRecycleBinResponse
        /// </returns>
        public async Task<RestoreUserFromRecycleBinResponse> RestoreUserFromRecycleBinWithOptionsAsync(RestoreUserFromRecycleBinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "RestoreUserFromRecycleBin",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreUserFromRecycleBinResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a specific Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreUserFromRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreUserFromRecycleBinResponse
        /// </returns>
        public RestoreUserFromRecycleBinResponse RestoreUserFromRecycleBin(RestoreUserFromRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreUserFromRecycleBinWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a specific Resource Access Management (RAM) user from the recycle bin.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestoreUserFromRecycleBinRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreUserFromRecycleBinResponse
        /// </returns>
        public async Task<RestoreUserFromRecycleBinResponse> RestoreUserFromRecycleBinAsync(RestoreUserFromRecycleBinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreUserFromRecycleBinWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the default domain name for an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultDomainResponse
        /// </returns>
        public SetDefaultDomainResponse SetDefaultDomainWithOptions(SetDefaultDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDomainName))
            {
                query["DefaultDomainName"] = request.DefaultDomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultDomain",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the default domain name for an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultDomainResponse
        /// </returns>
        public async Task<SetDefaultDomainResponse> SetDefaultDomainWithOptionsAsync(SetDefaultDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultDomainName))
            {
                query["DefaultDomainName"] = request.DefaultDomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultDomain",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the default domain name for an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultDomainResponse
        /// </returns>
        public SetDefaultDomainResponse SetDefaultDomain(SetDefaultDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the default domain name for an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultDomainResponse
        /// </returns>
        public async Task<SetDefaultDomainResponse> SetDefaultDomainAsync(SetDefaultDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the password policy for Resource Access Management (RAM) users.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HardExpire))
            {
                query["HardExpire"] = request.HardExpire;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLoginAttemps))
            {
                query["MaxLoginAttemps"] = request.MaxLoginAttemps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPasswordAge))
            {
                query["MaxPasswordAge"] = request.MaxPasswordAge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinimumPasswordDifferentCharacter))
            {
                query["MinimumPasswordDifferentCharacter"] = request.MinimumPasswordDifferentCharacter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinimumPasswordLength))
            {
                query["MinimumPasswordLength"] = request.MinimumPasswordLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordNotContainUserName))
            {
                query["PasswordNotContainUserName"] = request.PasswordNotContainUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordReusePrevention))
            {
                query["PasswordReusePrevention"] = request.PasswordReusePrevention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireLowercaseCharacters))
            {
                query["RequireLowercaseCharacters"] = request.RequireLowercaseCharacters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireNumbers))
            {
                query["RequireNumbers"] = request.RequireNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireSymbols))
            {
                query["RequireSymbols"] = request.RequireSymbols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireUppercaseCharacters))
            {
                query["RequireUppercaseCharacters"] = request.RequireUppercaseCharacters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordPolicy",
                Version = "2019-08-15",
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
        /// <para>Configures the password policy for Resource Access Management (RAM) users.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HardExpire))
            {
                query["HardExpire"] = request.HardExpire;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLoginAttemps))
            {
                query["MaxLoginAttemps"] = request.MaxLoginAttemps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPasswordAge))
            {
                query["MaxPasswordAge"] = request.MaxPasswordAge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinimumPasswordDifferentCharacter))
            {
                query["MinimumPasswordDifferentCharacter"] = request.MinimumPasswordDifferentCharacter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinimumPasswordLength))
            {
                query["MinimumPasswordLength"] = request.MinimumPasswordLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordNotContainUserName))
            {
                query["PasswordNotContainUserName"] = request.PasswordNotContainUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordReusePrevention))
            {
                query["PasswordReusePrevention"] = request.PasswordReusePrevention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireLowercaseCharacters))
            {
                query["RequireLowercaseCharacters"] = request.RequireLowercaseCharacters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireNumbers))
            {
                query["RequireNumbers"] = request.RequireNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireSymbols))
            {
                query["RequireSymbols"] = request.RequireSymbols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireUppercaseCharacters))
            {
                query["RequireUppercaseCharacters"] = request.RequireUppercaseCharacters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordPolicy",
                Version = "2019-08-15",
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
        /// <para>Configures the password policy for Resource Access Management (RAM) users.</para>
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
        /// <para>Configures the password policy for Resource Access Management (RAM) users.</para>
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
        /// <para>Configures security preferences for a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to enable multi-factor authentication (MFA) only for RAM users who initiated unusual logons.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SetSecurityPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSecurityPreferenceResponse
        /// </returns>
        public SetSecurityPreferenceResponse SetSecurityPreferenceWithOptions(SetSecurityPreferenceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetSecurityPreferenceShrinkRequest request = new SetSecurityPreferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VerificationTypes))
            {
                request.VerificationTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VerificationTypes, "VerificationTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToChangePassword))
            {
                query["AllowUserToChangePassword"] = request.AllowUserToChangePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToLoginWithPasskey))
            {
                query["AllowUserToLoginWithPasskey"] = request.AllowUserToLoginWithPasskey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManageAccessKeys))
            {
                query["AllowUserToManageAccessKeys"] = request.AllowUserToManageAccessKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManageMFADevices))
            {
                query["AllowUserToManageMFADevices"] = request.AllowUserToManageMFADevices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManagePersonalDingTalk))
            {
                query["AllowUserToManagePersonalDingTalk"] = request.AllowUserToManagePersonalDingTalk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSaveMFATicket))
            {
                query["EnableSaveMFATicket"] = request.EnableSaveMFATicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginNetworkMasks))
            {
                query["LoginNetworkMasks"] = request.LoginNetworkMasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginSessionDuration))
            {
                query["LoginSessionDuration"] = request.LoginSessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFAOperationForLogin))
            {
                query["MFAOperationForLogin"] = request.MFAOperationForLogin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationForRiskLogin))
            {
                query["OperationForRiskLogin"] = request.OperationForRiskLogin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationTypesShrink))
            {
                query["VerificationTypes"] = request.VerificationTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSecurityPreference",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSecurityPreferenceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures security preferences for a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to enable multi-factor authentication (MFA) only for RAM users who initiated unusual logons.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SetSecurityPreferenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSecurityPreferenceResponse
        /// </returns>
        public async Task<SetSecurityPreferenceResponse> SetSecurityPreferenceWithOptionsAsync(SetSecurityPreferenceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetSecurityPreferenceShrinkRequest request = new SetSecurityPreferenceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VerificationTypes))
            {
                request.VerificationTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VerificationTypes, "VerificationTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToChangePassword))
            {
                query["AllowUserToChangePassword"] = request.AllowUserToChangePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToLoginWithPasskey))
            {
                query["AllowUserToLoginWithPasskey"] = request.AllowUserToLoginWithPasskey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManageAccessKeys))
            {
                query["AllowUserToManageAccessKeys"] = request.AllowUserToManageAccessKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManageMFADevices))
            {
                query["AllowUserToManageMFADevices"] = request.AllowUserToManageMFADevices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManagePersonalDingTalk))
            {
                query["AllowUserToManagePersonalDingTalk"] = request.AllowUserToManagePersonalDingTalk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSaveMFATicket))
            {
                query["EnableSaveMFATicket"] = request.EnableSaveMFATicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginNetworkMasks))
            {
                query["LoginNetworkMasks"] = request.LoginNetworkMasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginSessionDuration))
            {
                query["LoginSessionDuration"] = request.LoginSessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFAOperationForLogin))
            {
                query["MFAOperationForLogin"] = request.MFAOperationForLogin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationForRiskLogin))
            {
                query["OperationForRiskLogin"] = request.OperationForRiskLogin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationTypesShrink))
            {
                query["VerificationTypes"] = request.VerificationTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSecurityPreference",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSecurityPreferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures security preferences for a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to enable multi-factor authentication (MFA) only for RAM users who initiated unusual logons.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetSecurityPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSecurityPreferenceResponse
        /// </returns>
        public SetSecurityPreferenceResponse SetSecurityPreference(SetSecurityPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSecurityPreferenceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures security preferences for a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to enable multi-factor authentication (MFA) only for RAM users who initiated unusual logons.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetSecurityPreferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSecurityPreferenceResponse
        /// </returns>
        public async Task<SetSecurityPreferenceResponse> SetSecurityPreferenceAsync(SetSecurityPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSecurityPreferenceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures information about user-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserSsoSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetUserSsoSettingsResponse
        /// </returns>
        public SetUserSsoSettingsResponse SetUserSsoSettingsWithOptions(SetUserSsoSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthnSignAlgo))
            {
                query["AuthnSignAlgo"] = request.AuthnSignAlgo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuxiliaryDomain))
            {
                query["AuxiliaryDomain"] = request.AuxiliaryDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataDocument))
            {
                query["MetadataDocument"] = request.MetadataDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoEnabled))
            {
                query["SsoEnabled"] = request.SsoEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoLoginWithDomain))
            {
                query["SsoLoginWithDomain"] = request.SsoLoginWithDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetUserSsoSettings",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserSsoSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures information about user-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserSsoSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetUserSsoSettingsResponse
        /// </returns>
        public async Task<SetUserSsoSettingsResponse> SetUserSsoSettingsWithOptionsAsync(SetUserSsoSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthnSignAlgo))
            {
                query["AuthnSignAlgo"] = request.AuthnSignAlgo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuxiliaryDomain))
            {
                query["AuxiliaryDomain"] = request.AuxiliaryDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataDocument))
            {
                query["MetadataDocument"] = request.MetadataDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoEnabled))
            {
                query["SsoEnabled"] = request.SsoEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoLoginWithDomain))
            {
                query["SsoLoginWithDomain"] = request.SsoLoginWithDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetUserSsoSettings",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserSsoSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures information about user-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserSsoSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// SetUserSsoSettingsResponse
        /// </returns>
        public SetUserSsoSettingsResponse SetUserSsoSettings(SetUserSsoSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetUserSsoSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures information about user-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserSsoSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// SetUserSsoSettingsResponse
        /// </returns>
        public async Task<SetUserSsoSettingsResponse> SetUserSsoSettingsAsync(SetUserSsoSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetUserSsoSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a mobile phone or email to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetVerificationInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetVerificationInfoResponse
        /// </returns>
        public SetVerificationInfoResponse SetVerificationInfoWithOptions(SetVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilePhone))
            {
                query["MobilePhone"] = request.MobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetVerificationInfo",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetVerificationInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a mobile phone or email to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetVerificationInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetVerificationInfoResponse
        /// </returns>
        public async Task<SetVerificationInfoResponse> SetVerificationInfoWithOptionsAsync(SetVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilePhone))
            {
                query["MobilePhone"] = request.MobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetVerificationInfo",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetVerificationInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a mobile phone or email to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetVerificationInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SetVerificationInfoResponse
        /// </returns>
        public SetVerificationInfoResponse SetVerificationInfo(SetVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetVerificationInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a mobile phone or email to a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetVerificationInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SetVerificationInfoResponse
        /// </returns>
        public async Task<SetVerificationInfoResponse> SetVerificationInfoAsync(SetVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetVerificationInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to resources.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePrincipalName))
            {
                query["ResourcePrincipalName"] = request.ResourcePrincipalName;
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
                Version = "2019-08-15",
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
        /// <para>Adds tags to resources.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePrincipalName))
            {
                query["ResourcePrincipalName"] = request.ResourcePrincipalName;
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
                Version = "2019-08-15",
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
        /// <para>Adds tags to resources.</para>
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
        /// <para>Adds tags to resources.</para>
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
        /// <para>Unbinds a multi-factor authentication (MFA) device from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindMFADeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindMFADeviceResponse
        /// </returns>
        public UnbindMFADeviceResponse UnbindMFADeviceWithOptions(UnbindMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindMFADevice",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindMFADeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a multi-factor authentication (MFA) device from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindMFADeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindMFADeviceResponse
        /// </returns>
        public async Task<UnbindMFADeviceResponse> UnbindMFADeviceWithOptionsAsync(UnbindMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindMFADevice",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindMFADeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a multi-factor authentication (MFA) device from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindMFADeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindMFADeviceResponse
        /// </returns>
        public UnbindMFADeviceResponse UnbindMFADevice(UnbindMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindMFADeviceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a multi-factor authentication (MFA) device from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindMFADeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindMFADeviceResponse
        /// </returns>
        public async Task<UnbindMFADeviceResponse> UnbindMFADeviceAsync(UnbindMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindMFADeviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a mobile phone or email from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindVerificationResponse
        /// </returns>
        public UnbindVerificationResponse UnbindVerificationWithOptions(UnbindVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilePhone))
            {
                query["MobilePhone"] = request.MobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindVerification",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a mobile phone or email from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindVerificationResponse
        /// </returns>
        public async Task<UnbindVerificationResponse> UnbindVerificationWithOptionsAsync(UnbindVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilePhone))
            {
                query["MobilePhone"] = request.MobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindVerification",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a mobile phone or email from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindVerificationResponse
        /// </returns>
        public UnbindVerificationResponse UnbindVerification(UnbindVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a mobile phone or email from a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindVerificationResponse
        /// </returns>
        public async Task<UnbindVerificationResponse> UnbindVerificationAsync(UnbindVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a resource.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePrincipalName))
            {
                query["ResourcePrincipalName"] = request.ResourcePrincipalName;
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
                Version = "2019-08-15",
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
        /// <para>Removes tags from a resource.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePrincipalName))
            {
                query["ResourcePrincipalName"] = request.ResourcePrincipalName;
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
                Version = "2019-08-15",
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
        /// <para>Removes tags from a resource.</para>
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
        /// <para>Removes tags from a resource.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAccessKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccessKeyResponse
        /// </returns>
        public UpdateAccessKeyResponse UpdateAccessKeyWithOptions(UpdateAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccessKey",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccessKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAccessKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccessKeyResponse
        /// </returns>
        public async Task<UpdateAccessKeyResponse> UpdateAccessKeyWithOptionsAsync(UpdateAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccessKey",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccessKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAccessKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccessKeyResponse
        /// </returns>
        public UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccessKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of an AccessKey pair for an Alibaba Cloud account or a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAccessKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAccessKeyResponse
        /// </returns>
        public async Task<UpdateAccessKeyResponse> UpdateAccessKeyAsync(UpdateAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccessKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a specified application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationResponse
        /// </returns>
        public UpdateApplicationResponse UpdateApplicationWithOptions(UpdateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAccessTokenValidity))
            {
                query["NewAccessTokenValidity"] = request.NewAccessTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewIsMultiTenant))
            {
                query["NewIsMultiTenant"] = request.NewIsMultiTenant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPredefinedScopes))
            {
                query["NewPredefinedScopes"] = request.NewPredefinedScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRedirectUris))
            {
                query["NewRedirectUris"] = request.NewRedirectUris;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRefreshTokenValidity))
            {
                query["NewRefreshTokenValidity"] = request.NewRefreshTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRequiredScopes))
            {
                query["NewRequiredScopes"] = request.NewRequiredScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSecretRequired))
            {
                query["NewSecretRequired"] = request.NewSecretRequired;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a specified application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationResponse
        /// </returns>
        public async Task<UpdateApplicationResponse> UpdateApplicationWithOptionsAsync(UpdateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAccessTokenValidity))
            {
                query["NewAccessTokenValidity"] = request.NewAccessTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewIsMultiTenant))
            {
                query["NewIsMultiTenant"] = request.NewIsMultiTenant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPredefinedScopes))
            {
                query["NewPredefinedScopes"] = request.NewPredefinedScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRedirectUris))
            {
                query["NewRedirectUris"] = request.NewRedirectUris;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRefreshTokenValidity))
            {
                query["NewRefreshTokenValidity"] = request.NewRefreshTokenValidity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewRequiredScopes))
            {
                query["NewRequiredScopes"] = request.NewRequiredScopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSecretRequired))
            {
                query["NewSecretRequired"] = request.NewSecretRequired;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplication",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a specified application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationResponse
        /// </returns>
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a specified application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationResponse
        /// </returns>
        public async Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewComments))
            {
                query["NewComments"] = request.NewComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
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
                Version = "2019-08-15",
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
        /// <para>Modifies information about a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewComments))
            {
                query["NewComments"] = request.NewComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
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
                Version = "2019-08-15",
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
        /// <para>Modifies information about a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
        /// <para>Modifies information about a Resource Access Management (RAM) user group.</para>
        /// </summary>
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
        /// <para>Modifies the console logon configurations of a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLoginProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoginProfileResponse
        /// </returns>
        public UpdateLoginProfileResponse UpdateLoginProfileWithOptions(UpdateLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFABindRequired))
            {
                query["MFABindRequired"] = request.MFABindRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordResetRequired))
            {
                query["PasswordResetRequired"] = request.PasswordResetRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoginProfile",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoginProfileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the console logon configurations of a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLoginProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoginProfileResponse
        /// </returns>
        public async Task<UpdateLoginProfileResponse> UpdateLoginProfileWithOptionsAsync(UpdateLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFABindRequired))
            {
                query["MFABindRequired"] = request.MFABindRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordResetRequired))
            {
                query["PasswordResetRequired"] = request.PasswordResetRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoginProfile",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoginProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the console logon configurations of a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLoginProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoginProfileResponse
        /// </returns>
        public UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLoginProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the console logon configurations of a Resource Access Management (RAM) user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLoginProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLoginProfileResponse
        /// </returns>
        public async Task<UpdateLoginProfileResponse> UpdateLoginProfileAsync(UpdateLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLoginProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description and client IDs of an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to change the description of the OIDC IdP named <c>TestOIDCProvider</c> to <c>This is a new OIDC Provider.</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOIDCProviderResponse
        /// </returns>
        public UpdateOIDCProviderResponse UpdateOIDCProviderWithOptions(UpdateOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIds))
            {
                query["ClientIds"] = request.ClientIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuanceLimitTime))
            {
                query["IssuanceLimitTime"] = request.IssuanceLimitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOIDCProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description and client IDs of an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to change the description of the OIDC IdP named <c>TestOIDCProvider</c> to <c>This is a new OIDC Provider.</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateOIDCProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOIDCProviderResponse
        /// </returns>
        public async Task<UpdateOIDCProviderResponse> UpdateOIDCProviderWithOptionsAsync(UpdateOIDCProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIds))
            {
                query["ClientIds"] = request.ClientIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuanceLimitTime))
            {
                query["IssuanceLimitTime"] = request.IssuanceLimitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OIDCProviderName))
            {
                query["OIDCProviderName"] = request.OIDCProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOIDCProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOIDCProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description and client IDs of an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to change the description of the OIDC IdP named <c>TestOIDCProvider</c> to <c>This is a new OIDC Provider.</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOIDCProviderResponse
        /// </returns>
        public UpdateOIDCProviderResponse UpdateOIDCProvider(UpdateOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOIDCProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description and client IDs of an OpenID Connect (OIDC) identity provider (IdP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <para>This topic provides an example on how to change the description of the OIDC IdP named <c>TestOIDCProvider</c> to <c>This is a new OIDC Provider.</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateOIDCProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOIDCProviderResponse
        /// </returns>
        public async Task<UpdateOIDCProviderResponse> UpdateOIDCProviderAsync(UpdateOIDCProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOIDCProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a passkey.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePasskeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePasskeyResponse
        /// </returns>
        public UpdatePasskeyResponse UpdatePasskeyWithOptions(UpdatePasskeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasskeyId))
            {
                query["PasskeyId"] = request.PasskeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasskeyName))
            {
                query["PasskeyName"] = request.PasskeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePasskey",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePasskeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a passkey.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePasskeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePasskeyResponse
        /// </returns>
        public async Task<UpdatePasskeyResponse> UpdatePasskeyWithOptionsAsync(UpdatePasskeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasskeyId))
            {
                query["PasskeyId"] = request.PasskeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasskeyName))
            {
                query["PasskeyName"] = request.PasskeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePasskey",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePasskeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a passkey.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePasskeyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePasskeyResponse
        /// </returns>
        public UpdatePasskeyResponse UpdatePasskey(UpdatePasskeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePasskeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a passkey.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePasskeyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePasskeyResponse
        /// </returns>
        public async Task<UpdatePasskeyResponse> UpdatePasskeyAsync(UpdatePasskeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePasskeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to change the description of an IdP named <c>test-provider</c> to <c>This is a new provider.</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSAMLProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSAMLProviderResponse
        /// </returns>
        public UpdateSAMLProviderResponse UpdateSAMLProviderWithOptions(UpdateSAMLProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthnSignAlgo))
            {
                query["AuthnSignAlgo"] = request.AuthnSignAlgo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewEncodedSAMLMetadataDocument))
            {
                query["NewEncodedSAMLMetadataDocument"] = request.NewEncodedSAMLMetadataDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderName))
            {
                query["SAMLProviderName"] = request.SAMLProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSAMLProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSAMLProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to change the description of an IdP named <c>test-provider</c> to <c>This is a new provider.</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSAMLProviderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSAMLProviderResponse
        /// </returns>
        public async Task<UpdateSAMLProviderResponse> UpdateSAMLProviderWithOptionsAsync(UpdateSAMLProviderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthnSignAlgo))
            {
                query["AuthnSignAlgo"] = request.AuthnSignAlgo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewEncodedSAMLMetadataDocument))
            {
                query["NewEncodedSAMLMetadataDocument"] = request.NewEncodedSAMLMetadataDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SAMLProviderName))
            {
                query["SAMLProviderName"] = request.SAMLProviderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSAMLProvider",
                Version = "2019-08-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSAMLProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to change the description of an IdP named <c>test-provider</c> to <c>This is a new provider.</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSAMLProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSAMLProviderResponse
        /// </returns>
        public UpdateSAMLProviderResponse UpdateSAMLProvider(UpdateSAMLProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSAMLProviderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies information about an identity provider (IdP) for role-based single sign-on (SSO).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to change the description of an IdP named <c>test-provider</c> to <c>This is a new provider.</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSAMLProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSAMLProviderResponse
        /// </returns>
        public async Task<UpdateSAMLProviderResponse> UpdateSAMLProviderAsync(UpdateSAMLProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSAMLProviderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example to show how to modify the name of a RAM user from <c>test@example.onaliyun.com</c> to <c>new@example.onaliyun.com</c>.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewComments))
            {
                query["NewComments"] = request.NewComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewEmail))
            {
                query["NewEmail"] = request.NewEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMobilePhone))
            {
                query["NewMobilePhone"] = request.NewMobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUserPrincipalName))
            {
                query["NewUserPrincipalName"] = request.NewUserPrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2019-08-15",
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
        /// <para>Modifies the information about a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example to show how to modify the name of a RAM user from <c>test@example.onaliyun.com</c> to <c>new@example.onaliyun.com</c>.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewComments))
            {
                query["NewComments"] = request.NewComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewEmail))
            {
                query["NewEmail"] = request.NewEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMobilePhone))
            {
                query["NewMobilePhone"] = request.NewMobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUserPrincipalName))
            {
                query["NewUserPrincipalName"] = request.NewUserPrincipalName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipalName))
            {
                query["UserPrincipalName"] = request.UserPrincipalName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2019-08-15",
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
        /// <para>Modifies the information about a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example to show how to modify the name of a RAM user from <c>test@example.onaliyun.com</c> to <c>new@example.onaliyun.com</c>.</para>
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
        /// <para>Modifies the information about a RAM user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example to show how to modify the name of a RAM user from <c>test@example.onaliyun.com</c> to <c>new@example.onaliyun.com</c>.</para>
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

    }
}
