// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Appstream_center20210220.Models;

namespace AlibabaCloud.SDK.Appstream_center20210220
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("appstream-center", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 身份认证查询接口
         *
         * @param request FindIdpListByLoginIdentifierRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FindIdpListByLoginIdentifierResponse
         */
        public FindIdpListByLoginIdentifierResponse FindIdpListByLoginIdentifierWithOptions(FindIdpListByLoginIdentifierRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientChannel))
            {
                body["ClientChannel"] = request.ClientChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginIdentifier))
            {
                body["LoginIdentifier"] = request.LoginIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportTypes))
            {
                body["SupportTypes"] = request.SupportTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindIdpListByLoginIdentifier",
                Version = "2021-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindIdpListByLoginIdentifierResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 身份认证查询接口
         *
         * @param request FindIdpListByLoginIdentifierRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FindIdpListByLoginIdentifierResponse
         */
        public async Task<FindIdpListByLoginIdentifierResponse> FindIdpListByLoginIdentifierWithOptionsAsync(FindIdpListByLoginIdentifierRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientChannel))
            {
                body["ClientChannel"] = request.ClientChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                body["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginIdentifier))
            {
                body["LoginIdentifier"] = request.LoginIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportTypes))
            {
                body["SupportTypes"] = request.SupportTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindIdpListByLoginIdentifier",
                Version = "2021-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindIdpListByLoginIdentifierResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 身份认证查询接口
         *
         * @param request FindIdpListByLoginIdentifierRequest
         * @return FindIdpListByLoginIdentifierResponse
         */
        public FindIdpListByLoginIdentifierResponse FindIdpListByLoginIdentifier(FindIdpListByLoginIdentifierRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindIdpListByLoginIdentifierWithOptions(request, runtime);
        }

        /**
         * @summary 身份认证查询接口
         *
         * @param request FindIdpListByLoginIdentifierRequest
         * @return FindIdpListByLoginIdentifierResponse
         */
        public async Task<FindIdpListByLoginIdentifierResponse> FindIdpListByLoginIdentifierAsync(FindIdpListByLoginIdentifierRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindIdpListByLoginIdentifierWithOptionsAsync(request, runtime);
        }

        /**
         * @summary GetLoginToken
         *
         * @param request GetLoginTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLoginTokenResponse
         */
        public GetLoginTokenResponse GetLoginTokenWithOptions(GetLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode))
            {
                query["AuthenticationCode"] = request.AuthenticationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentStage))
            {
                query["CurrentStage"] = request.CurrentStage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedFingerPrintData))
            {
                query["EncryptedFingerPrintData"] = request.EncryptedFingerPrintData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedKey))
            {
                query["EncryptedKey"] = request.EncryptedKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedPassword))
            {
                query["EncryptedPassword"] = request.EncryptedPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FingerPrintData))
            {
                query["FingerPrintData"] = request.FingerPrintData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpId))
            {
                query["IdpId"] = request.IdpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAlive))
            {
                query["KeepAlive"] = request.KeepAlive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAliveToken))
            {
                query["KeepAliveToken"] = request.KeepAliveToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginIdentifier))
            {
                query["LoginIdentifier"] = request.LoginIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginName))
            {
                query["LoginName"] = request.LoginName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPassword))
            {
                query["NewPassword"] = request.NewPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPassword))
            {
                query["OldPassword"] = request.OldPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneVerifyCode))
            {
                query["PhoneVerifyCode"] = request.PhoneVerifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoExtendsCookies))
            {
                query["SsoExtendsCookies"] = request.SsoExtendsCookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoSessionToken))
            {
                query["SsoSessionToken"] = request.SsoSessionToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenCode))
            {
                query["TokenCode"] = request.TokenCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UmidToken))
            {
                query["UmidToken"] = request.UmidToken;
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
                Action = "GetLoginToken",
                Version = "2021-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary GetLoginToken
         *
         * @param request GetLoginTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLoginTokenResponse
         */
        public async Task<GetLoginTokenResponse> GetLoginTokenWithOptionsAsync(GetLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode))
            {
                query["AuthenticationCode"] = request.AuthenticationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOS))
            {
                query["ClientOS"] = request.ClientOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentStage))
            {
                query["CurrentStage"] = request.CurrentStage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                query["DirectoryId"] = request.DirectoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedFingerPrintData))
            {
                query["EncryptedFingerPrintData"] = request.EncryptedFingerPrintData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedKey))
            {
                query["EncryptedKey"] = request.EncryptedKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedPassword))
            {
                query["EncryptedPassword"] = request.EncryptedPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FingerPrintData))
            {
                query["FingerPrintData"] = request.FingerPrintData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpId))
            {
                query["IdpId"] = request.IdpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAlive))
            {
                query["KeepAlive"] = request.KeepAlive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAliveToken))
            {
                query["KeepAliveToken"] = request.KeepAliveToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginIdentifier))
            {
                query["LoginIdentifier"] = request.LoginIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginName))
            {
                query["LoginName"] = request.LoginName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPassword))
            {
                query["NewPassword"] = request.NewPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPassword))
            {
                query["OldPassword"] = request.OldPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneVerifyCode))
            {
                query["PhoneVerifyCode"] = request.PhoneVerifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoExtendsCookies))
            {
                query["SsoExtendsCookies"] = request.SsoExtendsCookies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoSessionToken))
            {
                query["SsoSessionToken"] = request.SsoSessionToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenCode))
            {
                query["TokenCode"] = request.TokenCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UmidToken))
            {
                query["UmidToken"] = request.UmidToken;
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
                Action = "GetLoginToken",
                Version = "2021-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary GetLoginToken
         *
         * @param request GetLoginTokenRequest
         * @return GetLoginTokenResponse
         */
        public GetLoginTokenResponse GetLoginToken(GetLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoginTokenWithOptions(request, runtime);
        }

        /**
         * @summary GetLoginToken
         *
         * @param request GetLoginTokenRequest
         * @return GetLoginTokenResponse
         */
        public async Task<GetLoginTokenResponse> GetLoginTokenAsync(GetLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoginTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RefreshLoginTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshLoginTokenResponse
         */
        public RefreshLoginTokenResponse RefreshLoginTokenWithOptions(RefreshLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginIdentifier))
            {
                query["LoginIdentifier"] = request.LoginIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileRegion))
            {
                query["ProfileRegion"] = request.ProfileRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
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
                Action = "RefreshLoginToken",
                Version = "2021-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshLoginTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RefreshLoginTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshLoginTokenResponse
         */
        public async Task<RefreshLoginTokenResponse> RefreshLoginTokenWithOptionsAsync(RefreshLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginIdentifier))
            {
                query["LoginIdentifier"] = request.LoginIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginToken))
            {
                query["LoginToken"] = request.LoginToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileRegion))
            {
                query["ProfileRegion"] = request.ProfileRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
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
                Action = "RefreshLoginToken",
                Version = "2021-02-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshLoginTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RefreshLoginTokenRequest
         * @return RefreshLoginTokenResponse
         */
        public RefreshLoginTokenResponse RefreshLoginToken(RefreshLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshLoginTokenWithOptions(request, runtime);
        }

        /**
         * @param request RefreshLoginTokenRequest
         * @return RefreshLoginTokenResponse
         */
        public async Task<RefreshLoginTokenResponse> RefreshLoginTokenAsync(RefreshLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshLoginTokenWithOptionsAsync(request, runtime);
        }

    }
}
